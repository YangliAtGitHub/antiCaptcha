using System.Configuration;

namespace CaptchaRecogizeDemo
{
    public static class Config
    {
        public static readonly string ResourceDir;

        static Config()
        {
            string ResourceDirTemp = ConfigurationManager.AppSettings["ResourceDir"].ToString().Trim();
            if( !ResourceDirTemp.EndsWith(@"\"))
            {
                ResourceDirTemp += @"\";
            }

            ResourceDir = ResourceDirTemp;
        }
    }
}
