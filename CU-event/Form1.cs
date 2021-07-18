using ns1;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU_event
{
    public partial class Form1 : Form
    {
        private ChromeDriverService _driverService = null;
        private ChromeOptions _options = null;
        private ChromeDriver _driver = null;


        string Placeholder1 = "아이디 또는 18년 10월 이후 가입자 휴대폰번호 입력";
        string Placeholder2 = "비밀번호";
        public Form1()
        {
            InitializeComponent();

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            //_options.AddArgument("--headless");
            _options.AddArgument("disable-gpu");
            _options.AddArgument("user-agent=Mozilla/5.0 (Macintosh; Intel Mac OS X 10_12_6)" + "AppleWebKit/537.36 (KHTML, like Gecko) Chrome/61.0.3163.100 Safari/537.36");
        }



        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            _driver = new ChromeDriver(@"chrom", _options);
            _driver.Navigate().GoToUrl("https://apmember.bgfretail.com/login?service=https://apmembership.bgfretail.com/index");  // 웹 사이트에 접속합니다.
            //_driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            

            var element = _driver.FindElement(By.XPath("//*[@id='phone_id']"));
            element.SendKeys(bunifuMaterialTextbox1.Text);

            element = _driver.FindElement(By.XPath("//*[@id='password']"));
            element.SendKeys(bunifuMaterialTextbox2.Text);

            element = _driver.FindElement(By.XPath("//*[@id='login']/div[2]/div[8]/button"));
            _driver.ExecuteScript("arguments[0].click();", element);

            Thread.Sleep(300);
            
            _driver.Url = "https://apmembership.bgfretail.com/event/eventDetail?event_id=990";
            
            
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Refresh();
            bunifuMaterialTextbox2.Refresh();
            if (bunifuMaterialTextbox1.Text == "" )
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox1.ContainsFocus)
                {
                    bunifuMaterialTextbox1.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox1.Text = Placeholder1;
                }
            }
            if (bunifuMaterialTextbox2.Text == "")
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox2.ContainsFocus)
                {
                    bunifuMaterialTextbox2.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox2.isPassword = false;
                    bunifuMaterialTextbox2.Text = Placeholder2;
                }
            }
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Refresh();
            bunifuMaterialTextbox2.Refresh();
            if (bunifuMaterialTextbox1.Text == "")
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox1.ContainsFocus)
                {
                    bunifuMaterialTextbox1.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox1.Text = Placeholder1;
                }
            }
            if (bunifuMaterialTextbox2.Text == "")
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox2.ContainsFocus)
                {
                    bunifuMaterialTextbox2.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox2.isPassword = false;
                    bunifuMaterialTextbox2.Text = Placeholder2;
                }
            }
            if (bunifuMaterialTextbox1.Text == Placeholder1)
            {
                bunifuMaterialTextbox1.ForeColor = Color.Black;
                bunifuMaterialTextbox1.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Refresh();
            bunifuMaterialTextbox2.Refresh();
            if (bunifuMaterialTextbox1.Text == "")
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox1.ContainsFocus)
                {
                    bunifuMaterialTextbox1.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox1.Text = Placeholder1;
                }
            }
            if (bunifuMaterialTextbox2.Text == "")
            { //텍스트박스 내용이 사용자가 입력한 값이 아닌 Placeholder일 경우에만, 커서 포커스일때 빈칸으로 만들기
                if (!bunifuMaterialTextbox2.ContainsFocus)
                {
                    bunifuMaterialTextbox2.ForeColor = Color.DarkGray;
                    bunifuMaterialTextbox2.isPassword = false;
                    bunifuMaterialTextbox2.Text = Placeholder2;
                }
            }
            if (bunifuMaterialTextbox2.Text == Placeholder2)
            {
                bunifuMaterialTextbox2.ForeColor = Color.Black;
                bunifuMaterialTextbox2.Text = "";
            }
        }
    }
}
