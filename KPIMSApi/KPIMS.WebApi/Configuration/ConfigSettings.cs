using KPIMS.Core.UiModels;

namespace KPIMS.WebApi.Configuration
{
    public class ConfigSettings
    {
        private readonly IConfiguration _configuration;
        public static IWebHostEnvironment _hostEnvironment;
        public ConfigSettings(IConfiguration configuration, IWebHostEnvironment hostEnvironment)
        {
            _configuration = configuration;
            _hostEnvironment = hostEnvironment;
        }

        public IConfiguration GetConfiguration()
        {
            return _configuration;
        }

        public IWebHostEnvironment GetWebHostEnvironment()
        {
            return _hostEnvironment;
        }

        public string GetAPIRootPath()
        {
            return _hostEnvironment.WebRootPath;
        }

        public string GetJWTKey()
        {
            return _configuration.GetValue<string>("JWT") ?? "";
        }

        public string GetWebSiteLink()
        {
            return _configuration.GetValue<string>("WebSiteUrl") ?? "";
        }

        public SMTPSettings GetSMTPSettings()
        {
            return new SMTPSettings()
            {
                Port = Convert.ToInt32(_configuration["SMTPSettings:Port"]),
                Host = _configuration["SMTPSettings:Host"] ?? "",
                UserName = _configuration["SMTPSettings:UserName"] ?? "",
                Password = _configuration["SMTPSettings:Password"] ?? "",
                FromName = _configuration["SMTPSettings:FromName"] ?? "",
                FromEmail = _configuration["SMTPSettings:FromEmail"] ?? ""
            };
        }
    }
}
