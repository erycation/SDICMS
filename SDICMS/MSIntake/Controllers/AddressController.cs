using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MSIntake.IntakeDomain.Model.Dtos;
using MSIntake.IntakeDomain.Services.Interface;

namespace MSIntake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IAddressTypeService _addressTypeService;
        private readonly IAddressService _addressService;

        public AddressController(IAddressTypeService addressTypeService, 
                                 IAddressService addressService)
        {
            _addressTypeService = addressTypeService;
            _addressService = addressService;
        }

        [HttpGet("Type/{addressTypeId}")]
        public async Task<IActionResult> GetAddressTypeById(int addressTypeId)
        {
            var userResults = await _addressTypeService.GetAddressTypeById(addressTypeId);
            return Ok(userResults);
        }

        [HttpGet("Type/All")]
        public async Task<IActionResult> GetAddressTypes()
        {
            var userResults = await _addressTypeService.GetAddressTypes();
            return Ok(userResults);
        }

        [HttpGet("Get/{addressId}")]
        public async Task<IActionResult> GetAddressById(int addressId)
        {
            var userResults = await _addressService.GetAddressById(addressId);
            return Ok(userResults);
        }

        [HttpGet("GetAll/{addressTypeId}/{name}")]
        public async Task<IActionResult> GetAddressTypes(int addressTypeId, string name)
        {
            var userResults = await _addressService.GetAddressByType(addressTypeId, name);
            return Ok(userResults);
        }

        [HttpPost("Add")]
        public async Task<IActionResult> CreateAddress([FromBody] AddressDto addressDto)
        {
            var addressResults = await _addressService.CreateAddress(addressDto);
            return Ok(new { message = $"Successfully added.", data = addressResults });
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateAddress([FromBody] AddressDto addressDto)
        {
            var addressResults = await _addressService.UpdateAddress(addressDto);
            return Ok(new { message = $"Successfully updated.", data = addressResults });
        }
    }
}
