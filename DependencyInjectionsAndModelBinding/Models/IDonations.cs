
namespace DependencyInjectionsAndModelBinding.Models
{
    public interface IDonations
    {
        void AddDonation(Donation donation);
        List<Donation> GetAllDonation();
    }
}