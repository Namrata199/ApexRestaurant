using ApexRestaurant.Repository.Domain;

namespace ApexRestaurant.Repository.RRefStaffRole
{
    public class RefStaffRepository : GenericRepository<RefStaffRole>, IRefStaffRoleRepository
    {
        public RefStaffRepository(RestaurantContext dbContext)
        {
            DbContext = dbContext;
        }
    }
    
}