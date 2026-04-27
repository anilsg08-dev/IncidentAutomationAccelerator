
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace IncidentAutomationAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncidentController : ControllerBase
    {
        private static List<Incident> incidents = new List<Incident>
        {
            new Incident { IncidentID = 101, Category = "ERP Sync", Severity = "High", Description = "Order sync failed", SuggestedFix = "Restart ERP Service", ResolutionStatus = "Pending" },
            new Incident { IncidentID = 102, Category = "eCommerce", Severity = "Medium", Description = "Payment gateway timeout", SuggestedFix = "Clear Cache", ResolutionStatus = "Pending" }
        };

        [HttpGet]
        public IActionResult GetIncidents()
        {
            return Ok(incidents);
        }

        [HttpPost("resolve/{id}")]
        public IActionResult ResolveIncident(int id)
        {
            var incident = incidents.FirstOrDefault(i => i.IncidentID == id);
            if (incident == null) return NotFound();

            // Rule-based resolution
            if (incident.SuggestedFix.Contains("Restart"))
            {
                incident.ResolutionStatus = "Auto-Resolved";
                incident.ResolutionTimeMin = 5;
            }
            else if (incident.SuggestedFix.Contains("Cache"))
            {
                incident.ResolutionStatus = "Auto-Resolved";
                incident.ResolutionTimeMin = 3;
            }
            else
            {
                incident.ResolutionStatus = "Manual";
                incident.ResolutionTimeMin = 15;
            }

            return Ok(incident);
        }
    }

    public class Incident
    {
        public int IncidentID { get; set; }
        public string Category { get; set; }
        public string Severity { get; set; }
        public string Description { get; set; }
        public string SuggestedFix { get; set; }
        public string ResolutionStatus { get; set; }
        public int ResolutionTimeMin { get; set; }
    }
}
