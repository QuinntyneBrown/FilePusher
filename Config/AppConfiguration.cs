using System.Configuration;


namespace FilePusher.Config
{
    public class AppConfiguration: ConfigurationSection
    {
        [ConfigurationProperty("projectFolderPath", IsRequired = true)]
        public string ProjectFolderPath
        {
            get { return (string)this["projectFolderPath"]; }
            set { this["projectFolderPath"] = value; }
        }

        [ConfigurationProperty("filePath", IsRequired = true)]
        public string FilePath
        {
            get { return (string)this["filePath"]; }
            set { this["filePath"] = value; }
        }

        public static AppConfiguration Config
        {
            get { return ConfigurationManager.GetSection("appConfiguration") as AppConfiguration; }
        }
    }
}
