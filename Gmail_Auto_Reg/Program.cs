using mevoronin.RuCaptchaNETClient;
using Gmail_Auto_Reg;
using OpenQA.Selenium.Chrome;


AutoRegerClient client = new AutoRegerClient(new ChromeDriver(), new AutoRegerParams() { CountOfAccount = 3, RuCaptchaToken = "", TypeOfOutput = OutputType.TXT});
