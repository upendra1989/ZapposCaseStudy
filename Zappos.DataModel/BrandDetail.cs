namespace Zappos.DataModel
{
	using System;

	public class BrandDetailDataModel: BrandDataModel
	{
		public int DetailId { get; set; }
		public int Quantity { get; set; }
		public DateTime TimeReceived { get; set; }
	}
}
