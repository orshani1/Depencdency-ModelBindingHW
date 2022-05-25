using DependencyInjectionsAndModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionsAndModelBinding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonationsController : ControllerBase
    {
        private IDonations _donations { get; set; }
        public DonationsController(IDonations donations)
        {
            _donations = donations;
        }

        [HttpPost]
        [Route("give/{donatorName}/{donatorLastName}")]
        public IActionResult PostDonation([FromRoute] string donatorName, [FromRoute] string donatorLastName,
            int donationAmount, int asosiationNumber, [FromRoute] DateTime donationDate, [FromRoute] int largeAmount)
        {
            var donation = new Donation()
            {
                AsosiationNumber = asosiationNumber,
                DonationAmount = donationAmount,
                LargeAmount = largeAmount,
                DonatorLastName = donatorLastName,
                DonatorName = donatorName,
            };
            _donations.AddDonation(donation);
            return Ok();
        }
    }




}
