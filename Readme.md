# Usage
Install the nuget 

    Install-Package Argon.Util.EmailSender -Version 1.0.3

Add below object to the `appsettings.json`

```json
"EmailConfiguration":  {
 "From":  "YOUR_EMAIL",
 "SmtpServer":  "smtp.gmail.com",
 "Port":  465,
 "UserName":  "YOUR_EMAIL",
 "Password":  "YOUR_APP_PASSWORD"
 }
 ```

Add below code section to the ```startup.cs```

```c#
using EmailSender;
```

And to below code block to the ```ConfigureServices``` method

```c#
var emailConfig = Configuration
                  .GetSection("EmailConfiguration")
                  .Get<EmailConfiguration>();
                  
services.AddSingleton(emailConfig);
```

```c#
services.AddScoped<IEmailSender,EmailSender>();
```
