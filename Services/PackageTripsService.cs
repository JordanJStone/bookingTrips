using System.Collections.Generic;
using bookingTrips.Repositories;

namespace bookingTrips.Services
{
  public class PackageTripsService
  {
    private readonly PackageTripsRepository _repo;

    public PackageTripsService(PackageTripsRepository repo)
    {
      _repo = repo;
    }
    internal IEnumerable<SinglePackage> getAll()
    {
      return _repo.GetAll();
    }
  }
}