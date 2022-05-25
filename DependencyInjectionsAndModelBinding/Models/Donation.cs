namespace DependencyInjectionsAndModelBinding.Models
{
    public class Donation
    {
        public string DonatorName { get; set; } = string.Empty;
        public string DonatorLastName { get; set; } = string.Empty;
        public int DonationAmount { get; set; }
        public int AsosiationNumber { get; set; }
        public int LargeAmount { get; set; }


    }
}
