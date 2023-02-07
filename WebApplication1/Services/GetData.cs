namespace WebApplication1.Services
{
    public class GetData
    {
        public GetData(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        public string FullName()
        {
            return "Alireza Alavi";
        }
    }
}