using tcirs_service.DTOs;

namespace tcirs_service.Repositories
{
    public interface IListFRepositories
    {
        public Task<List<ListFPage201Model>> GetListFPage201List();
        public Task<List<NotiPage201Model>> GetNotiPage201();
        public Task<int> GetNotiCount();
        public Task<int> GetCountListF();
        public Task<int> GetCountReplyBook();
        public Task<int> GetCountCompleteNoti();
        public Task<int> GetCountIssueBookNoti();
        public Task<int> GetCountOpenSurvey();
        public Task<int> GetCountRestrictedGoods();
        public Task<int> GetCountDepositAtWarehouses();

        public Task<List<ListFPage202Model>> GetListFPage202List(int flagSearch, string search);
        public Task<List<SubListFModel>> GetSubListFByDeclarationNo(string declarationNo);
        public Task<ModalListFPage202Model> GetModalListFPage202Model(int id);
        public Task<List<ModalSubListFPage202Model>> GetModalSubListFPage202Models(int id);
        public Task<bool> InsertPage202(InsertPage202Model request);

        public Task<List<Page203Model>> GetPage203Model(string refNo);
        public Task<List<Page204Model>> GetPage204Model(int flagSearch, string documentNo);

        public Task<bool> InsertPage205(Page205Model request);
        public Task<int> GetNotiDueDate();
        public Task<int> GetIssueLetter();
        public Task<int> GetNotiWarehouses();
        public Task<int> GetExemption();
        public Task<int> GetProgress();
        Task<List<ModalListFPage205Model>> GetModalListFPage205Model(string refNum);
        public Task<Page206Model> GetPage206Model(string documentNo);
        public Task<string> GetRunningNumber(string topic);
        public Task<string> GetRunningNumberFileName();
        public Task<List<Page215Model>> GetSearch215Pagel(string? p_house_bl, string? p_vasselname, string? p_company);
    }
}
