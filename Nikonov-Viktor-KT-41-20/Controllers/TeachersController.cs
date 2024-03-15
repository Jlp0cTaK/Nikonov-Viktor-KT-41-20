using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nikonov_Viktor_KT_41_20.Data;
using Nikonov_Viktor_KT_41_20.Models;
using Nikonov_Viktor_KT_41_20.Interfaces.TeachersInterfaces;
using Nikonov_Viktor_KT_41_20.Filters.TeachersFilters;

namespace Nikonov_Viktor_KT_41_20.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeachersController : ControllerBase
    {
        private readonly ILogger<TeachersController> _logger;
        private readonly ITeachersService _teachersService;

        public TeachersController(ILogger<TeachersController> logger, ITeachersService teachersService)
        {
            _logger = logger;
            _teachersService = teachersService;
        }

        [HttpPost(Name = "GetTeachersByDepartments")]
        public async Task<IActionResult> GetTeachersByDepartmentsAsync(TeachersDepartmentFilter filter, CancellationToken cancellationToken = default)
        {
            var teachers = await _teachersService.GetTeachersByDepartmentsAsync(filter, cancellationToken);
            //throw new Exception("1123123");
            return Ok(teachers);
        }


    }
}
