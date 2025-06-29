using Microsoft.AspNetCore.Mvc;
using tcirs_service.DTOs;
using tcirs_service.Services;

namespace tcirs_service.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ListFController : ControllerBase
    {
        private readonly IListFService _listFService;

        public ListFController(IListFService listFService)
        {
            _listFService = listFService;
        }

        [HttpGet("page201")]
        public async Task<IActionResult> GetPage201()
        {
            var result = await _listFService.GetPage201();
            return Ok(result);
        }

        [HttpGet("page202/summary")]
        public async Task<IActionResult> GetPage202Summary()
        {
            try
            {
                var result = await _listFService.GetSummaryPage202();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);

            }

        }

        [HttpGet("page202")]
        public async Task<IActionResult> GetPage202([FromQuery] int flagSearch, [FromQuery] string search)
        {
            try
            {
                var result = await _listFService.GetPage202(flagSearch, Uri.UnescapeDataString(search));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet("page202/modal/{id}")]
        public async Task<IActionResult> GetModalListFPage202Model(int id)
        {
            try
            {
                var result = await _listFService.GetModalListFPage202Model(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("page202")]
        public async Task<IActionResult> InsrtPage202([FromBody] InsertPage202Model request)
        {
            try
            {
                var result = await _listFService.InsertPage202(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page203/{refNo}")]
        public async Task<IActionResult> GetPage203(string refNo)
        {
            try
            {
                var result = await _listFService.GetPage203Model(refNo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page204")]
        public async Task<IActionResult> GetPage204Model([FromQuery] int flagSearch, [FromQuery] string search)
        {
            try
            {
                var result = await _listFService.GetPage204Model(flagSearch, Uri.UnescapeDataString(search));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page204/summary")]
        public async Task<IActionResult> GetPage204Summary()
        {
            try
            {
                var result = await _listFService.GetSummaryPage204();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("page205")]
        public async Task<IActionResult> InsrtPage205([FromBody] Page205Model request)
        {
            try
            {
                var result = await _listFService.InsertPage205(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page206")]
        public async Task<IActionResult> GetPage206([FromQuery] string documentNo)
        {
            try
            {
                var result = await _listFService.GetPage206Model(Uri.UnescapeDataString(documentNo));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page205/modal/{refNo}")]
        public async Task<IActionResult> GetModalListFPage205Model(string refNo)
        {
            try
            {
                var result = await _listFService.GetModalListFPage205Model(refNo);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("running-number/{topic}")]
        public async Task<IActionResult> GetRunningNumber(string topic)
        {
            try
            {
                var result = await _listFService.GetRunningNumber(Uri.UnescapeDataString(topic));
                return Ok(new ListFRunningNumber { RunningNumber = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("running-number/file-name")]
        public async Task<IActionResult> GetRunningNumberFileName()
        {
            try
            {
                var result = await _listFService.GetRunningNumberFileName();
                return Ok(new { FileName = result });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("page215/search215Page")]
        public async Task<IActionResult> GetSearch215Pagel(string? p_house_bl, string? p_vasselname, string? p_company)
        {
            try
            {
                var result = await _listFService.GetSearch215Pagel(p_house_bl, p_vasselname, p_company);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}