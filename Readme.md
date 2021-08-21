# Usage
Install the nuget 

    Install-Package Argon.Util.EmailSender -Version 1.0.0

Add below object to the `appsettings.json`

`
"EmailConfiguration":  {
 "From":  "YOUR_EMAIL",
 "SmtpServer":  "smtp.gmail.com",
 "Port":  465,
 "UserName":  "YOUR_EMAIL",
 "Password":  "YOUR_APP_PASSWORD"
 }
 `

Add below code section to the `startup.cs`

`using EmailSender;`

And to below code block to the `ConfigureServices` method
`
var emailConfig = Configuration.GetSection("EmailConfiguration")
 .Get<EmailConfiguration>();
 services.AddSingleton(emailConfig);
 `

`services.AddScoped<IEmailSender,EmailSender>();`
