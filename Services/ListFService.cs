using tcirs_service.DTOs;
using tcirs_service.Repositories;

namespace tcirs_service.Services
{
    public class ListFService : IListFService
    {
        private readonly IListFRepositories _listFRepositories;
        public ListFService(IListFRepositories listFRepositories)
        {
            _listFRepositories = listFRepositories;
        }

        public async Task<Page201Model> GetPage201()
        {
            var noti = await _listFRepositories.GetNotiPage201();
            var listFPage201 = await _listFRepositories.GetListFPage201List();
            var countListF = await _listFRepositories.GetCountListF();
            var countReplyBook = await _listFRepositories.GetCountReplyBook();
            var countCompleteNoti = await _listFRepositories.GetCountCompleteNoti();
            var countIssueBookNoti = await _listFRepositories.GetCountIssueBookNoti();
            var notiCount = await _listFRepositories.GetNotiCount();

            return new Page201Model
            {
                Summary = new SummaryPage201Model
                {
                    CompleteNoti = countCompleteNoti,
                    IssueNoti = countIssueBookNoti,
                    ListF = countListF,
                    ReplyBook = countReplyBook
                },
                ListF = listFPage201,
                Noti = noti,
                NotiCount = notiCount
            };
        }
        public async Task<Page202Model> GetPage202(int flagSearch, string search)
        {

            var listFPage202 = await _listFRepositories.GetListFPage202List(flagSearch, search);

            var tasks = listFPage202.Select(async item =>
            {
                item.SubListF = await _listFRepositories.GetSubListFByDeclarationNo(item.ImpDeclarationNumber);
                return item;
            });
            var populatedList = await Task.WhenAll(tasks);
            return new Page202Model
            {

                ListF = populatedList.ToList()
            };
        }

        public async Task<SummaryPage202Model> GetSummaryPage202()
        {
            var countListF = await _listFRepositories.GetCountListF();
            var countOpenSurvey = await _listFRepositories.GetCountOpenSurvey();
            var countRestrictedGoods = await _listFRepositories.GetCountRestrictedGoods();
            var countDepositAtWarehouses = await _listFRepositories.GetCountDepositAtWarehouses();
            return new SummaryPage202Model
            {
                ListF = countListF,
                OpenSurvey = countOpenSurvey,
                RestrictedGoods = countRestrictedGoods,
                DepositAtWarehouses = countDepositAtWarehouses
            };
        }

        public async Task<ModalListFPage202Model> GetModalListFPage202Model(int id)
        {
            var modalListF = await _listFRepositories.GetModalListFPage202Model(id);
            modalListF.SubList = await _listFRepositories.GetModalSubListFPage202Models(id);
            return modalListF;
        }
        public async Task<bool> InsertPage202(InsertPage202Model request)
        {
            var success = await _listFRepositories.InsertPage202(request);
            return success;
        }

        public async Task<List<Page203Model>> GetPage203Model(string refNo)
        {
            var result = await _listFRepositories.GetPage203Model(refNo);
            return result;
        }

        public async Task<List<Page204Model>> GetPage204Model(int flagSearch, string search)
        {
            var result = await _listFRepositories.GetPage204Model(flagSearch, search);
            return result;
        }

        public async Task<SummaryPage204Model> GetSummaryPage204()
        {
            var countNotiDueDate = _listFRepositories.GetNotiDueDate();
            var countIssueLetter = _listFRepositories.GetIssueLetter();
            var countNotiWarehouses = _listFRepositories.GetNotiWarehouses();
            var countExemption = _listFRepositories.GetExemption();
            var countProgress = _listFRepositories.GetProgress();

            await Task.WhenAll(
                countNotiDueDate,
                countIssueLetter,
                countNotiWarehouses,
                countExemption,
                countProgress
            );

            return new SummaryPage204Model
            {
                NotiDueDate = await countNotiDueDate,
                IssueLetter = await countIssueLetter,
                NotiWarehouses = await countNotiWarehouses,
                Exemption = await countExemption,
                Progress = await countProgress
            };
        }

        public async Task<bool> InsertPage205(Page205Model request)
        {
            var success = await _listFRepositories.InsertPage205(request);
            return success;
        }

        public async Task<List<ModalListFPage205Model>> GetModalListFPage205Model(string refNum)
        {
            return await _listFRepositories.GetModalListFPage205Model(refNum);
        }

        public async Task<Page206Model> GetPage206Model(string documentNo)
        {

            var result = await _listFRepositories.GetPage206Model(documentNo);
            return result;
        }

        public async Task<string> GetRunningNumber(string topic)
        {
            return await _listFRepositories.GetRunningNumber(topic);
        }
        public async Task<string> GetRunningNumberFileName()
        {
            return await _listFRepositories.GetRunningNumberFileName();
        }

        public async Task<List<Page215Model>> GetSearch215Pagel(string? p_house_bl, string? p_vasselname, string? p_company)
        {
            var result = await _listFRepositories.GetSearch215Pagel(p_house_bl, p_vasselname, p_company);
            return result;
        }
    }
}
