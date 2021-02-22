using System.Collections.Generic;
using bookingTrips.Interfaces;
using bookingTrips.Services;
using Microsoft.AspNetCore.Mvc;

namespace bookingTrips.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class PurchasablesController : ControllerBase
  {

    private readonly PackageTripsService _service;

    public PurchasablesController(PackageTripsService service)
    {
      _service = service;
    }

    [HttpGet("packagetrips")]
    public ActionResult<IEnumerable<SingleTrip>> GetAll()
    {
      try
      {
        var data = _service.GetAll();
        return Ok(data);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }

    [HttpGet]
    public ActionResult<IEnumerable<IPurchasable>> GetAllPurchasable()
    {
      try
      {
        var data = _service.getAll();
        return Ok(data);
      }
      catch (System.Exception e)
      {
        return BadRequest(e.Message);
      }
    }






  }
}