using Market.Api.Dtos;
using Maroc.Core.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Market.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            try
            {
                var categories = await _categoryService.GetAllAsync();
                var categoriesDto = categories.Select(c => new CategoriesResponseDto
                {
                    Id = c.Id,
                    Name = c.Name,
                }).ToList();
                return Ok(categoriesDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            try
            {
                var category = await _categoryService.GetByIdAsync(id);

                if (category == null) 
                {
                    return NotFound();
                }
                var categoriesDto = new CategoriesResponseDto
                {
                    Id = category.Id,
                    Name = category.Name,
                };
                return Ok(categoriesDto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
