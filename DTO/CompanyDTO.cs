namespace CologneStore.DTO
{
	public class CompanyDTO
	{
		public int id { get; set; }
        public string CompanyName { get; set; }
        public string RegistrationNumber { get; set; }
		public string CompanyAddress { get; set; }
		public string CIPCImage { get; set; }
		public IFormFile? ImageFile { get; set; }
	}
}
