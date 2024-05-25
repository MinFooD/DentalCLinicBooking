using Microsoft.EntityFrameworkCore;

namespace DentalClinicBooking.Data
{
	public class DentalClinicBookingDBContext : DbContext
	{
		public DentalClinicBookingDBContext(DbContextOptions options) : base(options)
		{
		}


	}
}
