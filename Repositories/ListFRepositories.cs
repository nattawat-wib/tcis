using Dapper;
using Newtonsoft.Json;
using Npgsql;
using NpgsqlTypes;
using tcirs_service.DTOs;
using tcirs_service.Extension;
namespace tcirs_service.Repositories
{
    public class ListFRepositories : BaseRepository, IListFRepositories
    {
        public ListFRepositories(IConfiguration configuration) : base(configuration) { }

        public async Task<int> GetCountCompleteNoti()
        {
            var query = @"
                    SELECT count(*) 
                    FROM ugms.send_doc_header 
                    WHERE release_date + release_day * INTERVAL '1 day' <= CURRENT_DATE
                    AND documen_type='F';
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetCountDepositAtWarehouses()
        {
            var query = @"
                    SELECT count(*) 
                    FROM ugms.import_list_f la
                    LEFT JOIN ugms.send_doc_header sh on sh.importrefno=la.importrefno
                    WHERE sh.status='3'
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetCountIssueBookNoti()
        {
            var query = @"
                    SELECT count(*) 
                    FROM ugms.send_doc_header sh  
                    WHERE sh.documen_type='F'
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetCountListF()
        {
            var query = @"
                        SELECT 
                        COUNT(*) AS lista
                        FROM ugms.import_list_f lf
                        WHERE lf.status = 'ListF';
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetCountOpenSurvey()
        {
            var query = @"
                    select COUNT(*)  FROM ugms.import_list_f WHERE status = 'INSP'
            ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetCountReplyBook()
        {
            var query = @"
                    SELECT count(*) 
                    FROM ugms.import_list_a la
                    LEFT JOIN ugms.send_doc_header sh on sh.importrefno=la.importrefno
                    WHERE sh.status='3'
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<List<ListFPage201Model>> GetListFPage201List()
        {
            var query = @"
                    SELECT 
                        i.REFNUM AS REFNUM,
                        TO_DATE(i.dtearv::TEXT, 'YYYYMMDD') AS ArriveDate,
                        impa.listf_date as ListFDate,
                        concat('เกินกำหนด',impa.liftf_day,'วัน') as DaysOverdue ,
                        i.VSLNME AS VasselName,
                        i.CMPNME AS CompanyName,
                        i.HOUBIL AS HouseBillofLanding,
                        i.IMPDCLNUM AS IMPDeclarationNumber,
                        i.TOTPKGFGN AS TotalPackageAmount,
                        i.DCLSTS,
                        impa.status AS ImportStatus
                    FROM imp.imp3000 i
                    INNER JOIN ugms.import_list_f impa ON impa.importrefno = i.refnum
                    ORDER BY impa.listf_date DESC
                    LIMIT 100;
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryAsync<ListFPage201Model>(query);
            return result.ToList();
        }

        public async Task<int> GetNotiCount()
        {
            var query = @"
                    SELECT COUNT(*) AS today_new_entries
                    FROM ugms.send_doc_header
                    WHERE DATE(created_date) = CURRENT_DATE;
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<List<NotiPage201Model>> GetNotiPage201()
        {

            var query = @"
                    SELECT imp.houbil as Houbil, 
                           imp.vslnme as Vslnme, 
                           sh.release_day as ReleaseDay, 
                           st.status_name_th as Status
                    FROM ugms.send_doc_header sh
                    LEFT JOIN ugms.import_list_f im ON im.importrefno = sh.importrefno
                    LEFT JOIN imp.imp3000 imp ON imp.refnum = sh.importrefno
                    LEFT JOIN ugms.send_doc_status st ON st.id = sh.status
                    WHERE sh.documen_type = 'F'
                    ORDER BY sh.created_by DESC
                    LIMIT 10;
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryAsync<NotiPage201Model>(query);
            return result.ToList();
        }

        public async Task<int> GetCountRestrictedGoods()
        {
            var query = @"select COUNT(*)  FROM ugms.import_inspection WHERE prohibited_good ='1'";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<List<ListFPage202Model>> GetListFPage202List(int flagSearch, string search)
        {
            var conditions = new List<string>();
            var parameters = new DynamicParameters();

            if (flagSearch == 1 && !string.IsNullOrWhiteSpace(search))
            {
                conditions.Add("i.VSLNME LIKE @VesselName");
                parameters.Add("VesselName", $"%{search}%");
            }
            else if (flagSearch == 2 && !string.IsNullOrWhiteSpace(search))
            {
                conditions.Add("i.CMPNME LIKE @CompanyName");
                parameters.Add("CompanyName", $"%{search}%");
            }
            else if (flagSearch == 3 && !string.IsNullOrWhiteSpace(search))
            {
                conditions.Add("i.HOUBIL LIKE @HouseBill");
                parameters.Add("HouseBill", $"%{search}%");
            }

            var whereClause = conditions.Count > 0 ? "WHERE " + string.Join(" OR ", conditions) : "";

            var query = $@"
                    SELECT 
                        impa.id AS Id,
                        i.REFNUM AS RefNum,
                        TO_DATE(i.dtearv::TEXT, 'YYYYMMDD') AS ArriveDate,
                        impa.listf_date as ListFDate,
                        concat('เกินกำหนด', impa.liftf_day, 'วัน') as DaysOverdue,
                        i.VSLNME AS VasselName,
                        i.CMPNME AS CompanyName,
                        i.HOUBIL AS HouseBillofLanding,
                        i.shpmrk as ShippinfMask ,
                        i.IMPDCLNUM AS ImpDeclarationNumber,
                        i.TOTPKGFGN AS TotalPackageAmount,
                        i.DCLSTS as ImpStatus,
                        impa.status AS Status
                    FROM imp.imp3000 i
                    INNER JOIN ugms.import_list_f impa ON impa.importrefno = i.refnum
                    {whereClause}
                ";

            using var connection = CreateConnection();
            var result = await connection.QueryAsync<ListFPage202Model>(query, parameters);
            return result.ToList();
        }

        public async Task<List<SubListFModel>> GetSubListFByDeclarationNo(string declarationNo)
        {
            string query = @"
                    SELECT 
                    imp.impdclnum AS ImpDclNum ,
                    imp.vslnme AS VasselName,       
                    imp.houbil AS ReleaseLocationCode, 
                    TO_DATE(imp.dtearv::TEXT, 'YYYYMMDD') AS ArriveDate,
                    imp.potrea AS DischargePort,
                    impi.pkgamt AS TotalPackage,
                    impi.pkgunt AS PackageUnit,  
                    impi.wgt AS NetWeight,
                    impi.wgtunt AS NetWeightUnit 
                FROM imp.imp3000 imp
                INNER JOIN imp.imp3200 impi ON impi.impdclnum = imp.impdclnum
                WHERE imp.impdclnum = '${dataItem}'";
            query = query.Replace("${dataItem}", declarationNo);

            using var connection = CreateConnection();
            await connection.OpenAsync();
            var result = await connection.QueryAsync<SubListFModel>(query);
            return result.ToList();
        }

        public async Task<bool> InsertPage202(InsertPage202Model request)
        {
            await using var connection = CreateConnection();
            await connection.OpenAsync();

            await using var transaction = await connection.BeginTransactionAsync();

            try
            {
                var recipientsJson = JsonConvert.SerializeObject(request.Recipients ?? new List<RecipientModel>());

                await using var cmd = new NpgsqlCommand(@"
                        CALL ugms.sp_insert_document(
                            @p_importrefno,
                            @p_documentno,
                            @p_documen_type,
                            @p_release_department,
                            @p_release_date,
                            @p_release_by,
                            @p_status,
                            @p_created_by,
                            @p_release_day,
                            @p_recipients
                        );
                    ", connection, transaction);

                cmd.Parameters.AddWithValue("p_importrefno", request.ImportRefNo);
                cmd.Parameters.AddWithValue("p_documentno", request.DocumentNo);
                cmd.Parameters.AddWithValue("p_documen_type", request.DocumentType);
                cmd.Parameters.AddWithValue("p_release_department", request.ReleaseDepartment);
                cmd.Parameters.Add("p_release_date", NpgsqlDbType.Date).Value = request.ReleaseDate.Date;
                cmd.Parameters.AddWithValue("p_release_by", request.ReleaseBy);
                cmd.Parameters.AddWithValue("p_status", request.Status);
                cmd.Parameters.AddWithValue("p_created_by", request.CreateBy);
                cmd.Parameters.AddWithValue("p_release_day", request.ReleaseDay ?? 0);
                cmd.Parameters.Add("p_recipients", NpgsqlDbType.Jsonb).Value = recipientsJson;

                await cmd.ExecuteNonQueryAsync();
                await transaction.CommitAsync();
                return true;
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"Error in InsertPage202: {ex.Message}");
                return false;
            }
        }


        public async Task<ModalListFPage202Model> GetModalListFPage202Model(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);

            string query = @"
                    SELECT 
                        TO_DATE(CAST(im.dtearv AS TEXT), 'YYYYMMDD') AS ArriveDate,
                        im.cmpnme AS CompanyName,    
                        im.vslnme AS VasselName,       
                        im.dclsts AS ImpStatus,          
                        im.shpmrk AS ShippingMark,     
                        im.TOTPKGAMT AS TotalPackage,    
                        im.PKGUNT AS PackageUnit     
                    FROM ugms.import_list_f lf 
                    LEFT JOIN imp.imp3000 im ON im.refnum = lf.importrefno
                    WHERE lf.id = @id
                ";

            using var connection = CreateConnection();
            await connection.OpenAsync();

            var result = await connection.QueryFirstOrDefaultAsync<ModalListFPage202Model>(query, parameters);
            return result ?? new ModalListFPage202Model();
        }

        public async Task<List<ModalSubListFPage202Model>> GetModalSubListFPage202Models(int id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("id", id);

            string query = @"
                    SELECT 
                        TO_DATE(CAST(im.dtearv AS TEXT), 'YYYYMMDD') AS ArriveDate,
                        im.cmpnme AS CompanyName,
                        im.vslnme AS VasselName,
                        im.dclsts AS ImpStatus,
                        im.shpmrk AS ShippingMark,
                        im.TOTPKGAMT AS TotalPackage,
                        im.PKGUNT AS PackageUnit, 
                        fd.house_bl_no AS HouseBill,
                        fd.product_code AS ProductCode,
                        fd.product_desc_en AS ProductNameEn,
                        fd.product_desc_th AS ProductNameTh,
                        fd.weight AS Weight,
                        fd.weight_unit AS WeightUnit
                    FROM ugms.import_list_f lf 
                    LEFT JOIN ugms.import_listf_detail fd ON fd.listf_id = lf.""id""   
                    LEFT JOIN imp.imp3000 im ON im.refnum = lf.importrefno           
                    WHERE lf.id = @id";

            using var connection = CreateConnection();
            await connection.OpenAsync();

            var result = await connection.QueryAsync<ModalSubListFPage202Model>(query, parameters);
            return result.ToList();
        }

        public async Task<List<Page203Model>> GetPage203Model(string refNo)
        {
            var parameters = new DynamicParameters();
            parameters.Add("RefNum", refNo);

            string query = @"
                    SELECT 
                            ip.refnum AS RefNum,
                            TO_CHAR(
                                TO_DATE(TO_CHAR(ip.dtearv, 'FM99999999'), 'YYYYMMDD'),
                                'DD/MM/YYYY'
                            ) AS Arivedate,
                            ip.vslnme AS Vasselname,
                            ip.cmpnme AS Companyname,
                            sh.documentno AS DocumentNo,
                            sh.release_date AS ReleaseDate,
                            ip.houbil AS HouseofBilling,
                            ip.shpmrk AS ShipingMask,
                            CONCAT(ip.TOTPKGAMT, ' ', ip.PKGUNT) AS Package,
                            (
                                SELECT ld.product_desc_en
                                FROM ugms.import_listf_detail ld
                                WHERE ld.listf_id = fd.id
                                LIMIT 1
                            ) AS ProductDesc,
                            ip.POTLDG AS Potldg
                    FROM ugms.import_list_f lf
                    LEFT JOIN ugms.import_listf_detail fd ON fd.listf_id = lf.id
                    LEFT JOIN imp.imp3000 ip ON ip.refnum = lf.importrefno
                    LEFT JOIN ugms.send_doc_header sh ON sh.importrefno = lf.importrefno
                    WHERE lf.importrefno = @RefNum;";
            using var connection = CreateConnection();
            await connection.OpenAsync();

            var result = await connection.QueryAsync<Page203Model>(query, parameters);
            return result.ToList();
        }

        public async Task<List<Page204Model>> GetPage204Model(int flagSearch, string search)
        {
            var sql = @"
                            SELECT 
                                hd.documentno AS DocumentNo,
                                dc.""DocName"" AS DocName,
                                hd.release_date AS ReleaseDate,
                                hd.release_day AS ReleaseDay,
                                hd.release_by AS ReleaseBy,
                                de.consinee_name AS ConsigneeName,
                                de.vassel_name AS VasselName,
                                us.fullname AS FullName,
                                sa.status_name_th AS StatusNameTh,
                                lf.importrefno AS ImportRefNo     
                            FROM UGMS.send_doc_header hd
                            LEFT JOIN ugms.import_list_f lf ON lf.importrefno = hd.importrefno
                            LEFT JOIN ugms.import_listf_detail de ON de.listf_id = lf.""id""
                            LEFT JOIN master.msusers us ON us.userid = hd.release_by
                            LEFT JOIN ugms.msdocument dc ON dc.""DocType"" = hd.documen_type
                            LEFT JOIN ugms.msstatus sa ON sa.status_code = lf.status
                            WHERE hd.documen_type IN ('3', '5')
                            AND (
                                (@flagSearch = 1 AND hd.documentno = @search)
                             OR (@flagSearch = 2 AND de.house_bl_no ILIKE CONCAT('%', @search, '%'))
                             OR (@flagSearch = 3 AND de.vassel_name    ILIKE CONCAT('%', @search, '%'))
                            )
                            ";

            var parameters = new
            {
                flagSearch = flagSearch,
                search = search ?? ""
            };
            using var connection = CreateConnection();
            await connection.OpenAsync();
            var result = await connection.QueryAsync<Page204Model>(sql, parameters);
            return result.ToList();
        }

        public async Task<bool> GetPage205Model(Page205Model request)
        {
            var sql = @"
                        INSERT INTO ugms.send_doc_warehouse (
                            importrefno,
                            documentno,
                            p_ref_doc_listf,
                            documen_type,
                            release_department,
                            release_date,
                            release_by,
                            status,
                            created_by,
                            created_date,
                            release_day
                        )
                        SELECT 
                            @p_importrefno,
                            hd.documentno,
                            @p_ref_doc_listf,
                            @p_documen_type,
                            @p_release_department,
                            @p_release_date,
                            @p_release_by,
                            @p_status,
                            @p_created_by,
                            CURRENT_TIMESTAMP,
                            15
                        FROM ugms.send_doc_header hd
                        WHERE hd.documentno = @p_ref_doc_listf
                    ";

            using var connection = CreateConnection();
            await connection.OpenAsync();

            using var command = new NpgsqlCommand(sql, connection);
            command.Parameters.AddWithValue("@p_importrefno", request.ImportRefNo);
            command.Parameters.AddWithValue("@p_ref_doc_listf", request.RefDocListF);
            command.Parameters.AddWithValue("@p_documen_type", request.DocumentType);
            command.Parameters.AddWithValue("@p_release_department", request.ReleaseDepartment);
            command.Parameters.AddWithValue("@p_release_date", request.ReleaseDate);
            command.Parameters.AddWithValue("@p_release_by", request.ReleaseBy);
            command.Parameters.AddWithValue("@p_status", request.Status);
            command.Parameters.AddWithValue("@p_created_by", request.CreateBy);

            await command.ExecuteNonQueryAsync();
            return true;
        }

        public async Task<int> GetNotiDueDate()
        {
            var query = @"
                        SELECT COUNT(*) 
                        FROM ugms.send_doc_header sh
                        WHERE (sh.recive_date + sh.release_day) <= CURRENT_DATE
                        AND sh.status = 2  and sh.documen_type='F' ;
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetIssueLetter()
        {
            var query = @"
                        SELECT COUNT(*) 
                        FROM ugms.send_doc_header sh
                        WHERE sh.status = 3  and sh.documen_type='F' ;
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetNotiWarehouses()
        {
            var query = @"
                            SELECT COUNT(*) 
                            FROM ugms.send_doc_header sh
                            WHERE sh.status = 5 ;
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetExemption()
        {
            var query = @"
                            SELECT COUNT(*)
                            FROM ugms.send_doc_header sh
                            WHERE sh.status = 6  ;
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }

        public async Task<int> GetProgress()
        {
            var query = @"
                        select count(*) FROM ugms.import_list_f lf WHERE lf.status ='Success';
                ";
            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<int>(query);
            return result;
        }
        public async Task<bool> InsertPage205(Page205Model request)
        {
            var sql = @"
                        INSERT INTO ugms.send_doc_warehouse (
                            importrefno,
                            documentno,
                            p_ref_doc_listf,
                            documen_type,
                            release_department,
                            release_date,
                            release_by,
                            status,
                            created_by,
                            created_date,
                            release_day
                        )
                        SELECT 
                            @p_importrefno,
                            hd.documentno,
                            @p_ref_doc_listf,
                            @p_documen_type,
                            @p_release_department,
                            @p_release_date,
                            @p_release_by,
                            @p_status,
                            @p_created_by,
                            CURRENT_TIMESTAMP,
                            15
                        FROM ugms.send_doc_header hd
                        WHERE hd.documentno = @p_ref_doc_listf
                    ";

            await using var connection = CreateConnection();
            await connection.OpenAsync();

            await using var transaction = await connection.BeginTransactionAsync();

            try
            {
                await using var command = new NpgsqlCommand(sql, connection, transaction);
                command.Parameters.AddWithValue("@p_importrefno", request.ImportRefNo);
                command.Parameters.AddWithValue("@p_ref_doc_listf", request.RefDocListF);
                command.Parameters.AddWithValue("@p_documen_type", request.DocumentType);
                command.Parameters.AddWithValue("@p_release_department", request.ReleaseDepartment);
                command.Parameters.AddWithValue("@p_release_date", request.ReleaseDate);
                command.Parameters.AddWithValue("@p_release_by", request.ReleaseBy);
                command.Parameters.AddWithValue("@p_status", request.Status);
                command.Parameters.AddWithValue("@p_created_by", request.CreateBy);

                var affectedRows = await command.ExecuteNonQueryAsync();

                if (affectedRows > 0)
                {
                    await transaction.CommitAsync();
                    return true;
                }
                else
                {
                    await transaction.RollbackAsync();
                    return false;
                }
            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine($"InsertPage205 Error: {ex.Message}");
                return false;
            }
        }

        public async Task<Page206Model> GetPage206Model(string documentNo)
        {
            using var connection = new NpgsqlConnection(_connectionString); // PostgreSQL connection
            string query = @"
                    SELECT 
                        ip.refnum AS Refnum ,
                        ip.vslnme AS Vasselname ,
                        ip.cmpnme AS Companyname ,
                        sh.documentno AS Documentno ,
                        ms.fullname AS Fullname ,
                        ms.department AS Department
                    FROM ugms.import_list_f lf
                    LEFT JOIN ugms.import_listf_detail fd ON fd.listf_id = lf.""id""
                    LEFT JOIN imp.imp3000 ip ON ip.refnum = lf.importrefno
                    LEFT JOIN ugms.send_doc_header sh ON sh.importrefno = lf.importrefno
                    LEFT JOIN ugms.send_doc_warehouse iw ON iw.documentno = sh.documentno
                    LEFT JOIN master.msusers ms ON ms.userid = sh.release_by
                    WHERE sh.documentno = @DocumentNo;
                ";

            return await connection.QueryFirstOrDefaultAsync<Page206Model>(query, new { DocumentNo = documentNo }) ?? new Page206Model();
        }

        public async Task<List<ModalListFPage205Model>> GetModalListFPage205Model(string refNum)
        {
            var parameters = new DynamicParameters();
            parameters.Add("refNum", refNum);
            string query = @"
                    SELECT 
                        ip.refNum,
                        TO_CHAR(
                            TO_DATE(TO_CHAR(ip.dtearv, 'FM99999999'), 'YYYYMMDD'),
                            'DD/MM/YYYY'
                        ) AS ariveDate,
                        ip.vslnme AS vasselName,
                        ip.cmpnme AS companyName,
                        sh.documentno as documentNo,
                        sh.release_date as releaseDate,
                        ip.houbil AS houseOfBilling,
                        ip.shpmrk AS shipingMask,
                        CONCAT(ip.TOTPKGAMT, ' ', ip.PKGUNT) AS Package,
                         (SELECT ld.product_desc_th
                         FROM ugms.import_listf_detail ld 
                         WHERE ld.listf_id=fd.id
                         LIMIT 1) AS productDescTh,
                        (SELECT ld.product_desc_en
                         FROM ugms.import_listf_detail ld 
                         WHERE ld.listf_id=fd.id
                         LIMIT 1) AS productDescEn,
                        (SELECT ld.product_code
                             FROM ugms.import_listf_detail ld 
                             WHERE ld.listf_id=fd.id
                             LIMIT 1) AS ProductCode,
                         ip.POTLDG as potldg,
                         fd.quantity as quantity,
                         fd.quantity_unit as quantityUnit
                    FROM ugms.import_list_f lf
                    LEFT JOIN ugms.import_listf_detail fd ON fd.listf_id=lf.""id""
                    LEFT JOIN imp.imp3000 ip ON ip.refnum = lf.importrefno
                    LEFT JOIN ugms.send_doc_header sh ON sh.importrefno = lf.importrefno
                    WHERE lf.importrefno= @refNum
                ";
            using var connection = CreateConnection();
            await connection.OpenAsync();

            return (await connection.QueryAsync<ModalListFPage205Model>(query, parameters)).ToList();
        }

        public async Task<string> GetRunningNumber(string topic)
        {
            var query = @"
                        SELECT CONCAT(""Topic"", ""Year"", '/', LPAD(CAST(""Running"" AS TEXT), 4, '0'))
                        FROM ugms.running_number
                        WHERE ""Topic"" = @Topic
                        LIMIT 1;
                    ";

            using var connection = CreateConnection();
            var result = await connection.QueryFirstOrDefaultAsync<string>(query, new { Topic = topic });
            return result ?? string.Empty;
        }

        public async Task<string> GetRunningNumberFileName()
        {
            var thaiYear = DateTime.Now.Year + 543;
            var month = DateTime.Now.Month.ToString("D2");
            var parameters = new DynamicParameters();
            parameters.Add("Topic", "ListF");
            parameters.Add("Year", thaiYear);

            var query = @"
                    SELECT COALESCE(MAX(""Running""),0) + 1 AS ""Running""
                    FROM ugms.running_number 
                    WHERE ""Topic"" = @Topic AND ""Year"" = @Year ;
                ";

            using var connection = CreateConnection();
            await connection.OpenAsync();

            int currentRunning = await connection.QueryFirstOrDefaultAsync<int>(query, parameters);

            var runningNumber = $"ListF{thaiYear}{month}{currentRunning.ToString("D6")}";
            return runningNumber;
        }

        public async Task<List<Page215Model>> GetSearch215Pagel(string? p_house_bl, string? p_vasselname, string? p_company)
        {
            var parameters = new DynamicParameters();
            var conditions = new List<string>();

            string query = @"

                    SELECT 
                    ld.house_bl_no as p_house_bl ,
                    ld.consinee_name as p_company,
                    ld.vassel_name as p_vasselname,
                    concat(ld.quantity,'/',ld.quantity_unit) as p_quantity,
                    concat(ld.weight,'/',ld.weight_unit) as p_weight ,
                    ld.impdclnum as importno,
                    lf.listf_date as p_listfdate,
                    lf.status as p_stastus
                        FROM ugms.import_list_f lf
                    left join ugms.import_listf_detail  ld on ld.listf_id=lf.id
                    WHERE 1=1
                ";

            if (!string.IsNullOrWhiteSpace(p_house_bl))
            {
                conditions.Add("AND ld.house_bl_no LIKE CONCAT('%', @p_house_bl, '%')");
                parameters.Add("p_house_bl", p_house_bl);
            }

            if (!string.IsNullOrWhiteSpace(p_vasselname))
            {
                conditions.Add("AND ld.vassel_name LIKE CONCAT('%', @p_vasselname, '%')");
                parameters.Add("p_vasselname", p_vasselname);
            }

            if (!string.IsNullOrWhiteSpace(p_company))
            {
                conditions.Add("AND ld.consinee_name LIKE CONCAT('%', @p_company, '%')");
                parameters.Add("p_company", p_company);
            }
            query += string.Join("\n", conditions);

            using var connection = CreateConnection();
            await connection.OpenAsync();

            return (await connection.QueryAsync<Page215Model>(query, parameters)).ToList();
        }
    }
}
