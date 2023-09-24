﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoureTechAssessment.Domain
{
	public class CountryDetail
	{
		public int Id { get; set; }
		public int CountryId { get; set; }
		public string Operator { get; set; }
		public string OperatorCode { get; set; }
		public Country Country { get; set; }
	}
}
