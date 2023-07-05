# yyj-slack-job-coaching

`Secrets.cs` in `Data` Folder

```cs
using Microsoft.CodeAnalysis.Elfie.Serialization;

namespace job_coaching_blazor_server.Data
{
    public class SMTP_Settings
    {
        public string server;
        public int port;
        public string username;
        public string password;
        public bool useSSL;
    }
    public class Secrets
    {
        public static string token = "xoxb-17";
        public static string channelID = "#general";

        public static SMTP_Settings smtpSettings = new SMTP_Settings
        {
            server = "smtp.example.com",
            port = 587,
            username = "support@example.com",
            password = "pa$$w0rD",
            useSSL = true
        };
    }
}
```
