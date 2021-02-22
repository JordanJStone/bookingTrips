using System.Collections.Generic;
using System.Data;
using Dapper;

namespace bookingTrips.Repositories
{
  public class PackageTripsRepository
  {
    public readonly IDbConnection _db;

    public PackageTripsRepository(IDbConnection db)
    {
      _db = db;
    }
    //NOTE dotnet add package dapper - to be able to communicate with db
    public IEnumerable<SinglePackage> GetAll()
    {
      string sql = "SELECT * FROM cruises, trips;";
      return _db.Query<SinglePackage>(sql);
    }
  }
}