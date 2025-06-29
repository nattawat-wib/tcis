using tcirs_service.DTOs;

namespace tcirs_service.Services
{
    public interface IListFService
    {
        Task<Page201Model> GetPage201();
        Task<SummaryPage202Model> GetSummaryPage202();
        Task<Page202Model> GetPage202(int flagSearch, string search);
        Task<ModalListFPage202Model> GetModalListFPage202Model(int id);
        Task<bool> InsertPage202(InsertPage202Model request);
        Task<List<Page203Model>> GetPage203Model(string refNo);
        Task<SummaryPage204Model> GetSummaryPage204();
        Task<List<Page204Model>> GetPage204Model(int flagSearch, string search);
        Task<bool> InsertPage205(Page205Model request);
        Task<List<ModalListFPage205Model>> GetModalListFPage205Model(string refNum);
        Task<Page206Model> GetPage206Model(string documentNo);
        Task<string> GetRunningNumber(string topic);
        Task<string> GetRunningNumberFileName();
        Task<List<Page215Model>> GetSearch215Pagel(string? p_house_bl, string? p_vasselname, string? p_company);
    }
}
