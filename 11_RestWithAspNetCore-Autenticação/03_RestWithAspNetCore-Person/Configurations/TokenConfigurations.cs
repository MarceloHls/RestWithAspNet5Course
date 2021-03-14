namespace _03_RestWithAspNetCore_Person.Configurations
{
    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public string Secret { get; set; }
        public string Minutes { get; set; }
        public string DaysToExpiry { get; set; }


    }
}
