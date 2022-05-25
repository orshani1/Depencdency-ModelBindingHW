namespace DependencyInjectionsAndModelBinding.Models
{
    public class CrimeOrganization : ICrimeOrganization
    {
        public List<string> CrimesList { get; set; }
        public CrimeOrganization()
        {
            CrimesList = new List<string>();
        }

    }
}
