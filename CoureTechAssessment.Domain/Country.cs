using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Domain
{
	public class Country
	{
        public Country()
        {
			CountryDetails = new HashSet<CountryDetail>();
        }
        public int Id { get; set; }
		public string CountryCode { get; set; }
		public string Name { get; set; }
		public string CountryIso { get; set; }
		public ICollection<CountryDetail> CountryDetails { get; set; }
	}
}
