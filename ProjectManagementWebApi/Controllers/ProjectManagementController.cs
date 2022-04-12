using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagementWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectManagementController : ControllerBase {


        private readonly ILogger<WeatherForecastController> _logger;

        public ProjectManagementController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetProject")]
        public IEnumerable<ProjectDetail> Get()
        {
           List <ProjectDetail> prj = new List<ProjectDetail>();

            prj.Add(new ProjectDetail { Projecthr = 1, ProjectID = 2, ProjectSummary = "Test" });

            return prj;


        }

    }
    


    }

