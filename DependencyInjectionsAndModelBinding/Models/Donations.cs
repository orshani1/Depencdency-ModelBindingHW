namespace DependencyInjectionsAndModelBinding.Models
{
    public class Donations : IDonations
    {
        private List<Donation> _DonationsList { get; set; }
        public Donations()
        {
            _DonationsList = new List<Donation>();
        }

        public void AddDonation(Donation donation)
        {
            _DonationsList.Add(donation);
        }
        public List<Donation> GetAllDonation()
        {
            return _DonationsList;
        }
    }
}
