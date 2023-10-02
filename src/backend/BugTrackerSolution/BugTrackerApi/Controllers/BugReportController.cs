using Microsoft.AspNetCore.Mvc;

namespace BugTrackerApi.Controllers;

public class BugReportController : ControllerBase
{
    [HttpPost("/catalog/excel/bugs")]

    public async Task<ActionResult> AddABugReport()

    {
        return StatusCode(201);
    }

}


var request = new BugReportCreateRequest

{

    Description = "Excel Goes Boom",

    Narrative = "A big long thing with steps to reproduce"

};

var expectedReponse = new BugReportCreateResponse

{

    Id = "excel-goes-boom",

    User = "Bob",

    Issue = request,

    Status = IssueStatus.InTriage

};

