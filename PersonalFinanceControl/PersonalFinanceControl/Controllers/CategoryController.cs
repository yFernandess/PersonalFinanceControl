using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PersonalFinanceControl.Model;
using PersonalFinanceControl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalFinanceControl.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;
        private ICategoryService _categoryService;

        public CategoryController(ILogger<CategoryController> logger, ICategoryService categoryService)
        {
            _logger = logger;
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_categoryService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var category = _categoryService.FindByID(id);

            if (category == null) return NotFound();

            return Ok(category);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            if (category == null) return BadRequest();

            return Ok(_categoryService.Create(category));
        }
        
        [HttpPut]
        public IActionResult Put([FromBody] Category category)
        {
            if (category == null) return BadRequest();

            return Ok(_categoryService.Update(category));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _categoryService.Delete(id);
            return NoContent();
        }
    }
}
