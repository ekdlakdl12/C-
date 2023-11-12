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

//Selenium Library
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

//만들었더니 크롬 드라이버 버전이랑 현재 크롬버전이 맞지않아 사용이 불가능함


namespace ExamSelenium
{
    public partial class Form1 : Form
    {
        protected ChromeDriverService _driverService = null;
        protected ChromeOptions _options = null;
        protected ChromeDriver _driver = null;

        public Form1()
        {
            InitializeComponent();

            _driverService = ChromeDriverService.CreateDefaultService();
            _driverService.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("disable-gpu");
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        //로그인 버튼 이벤트
        private void button1_Click(object sender, EventArgs e)
        {
            string caption = button1.Text;

            if (caption == "로그인")
            {   
                //아이디 로그인박스 지정
                string id = textBox1.Text;
                //비밀번호 로그인 박스 지정
                string pw = textBox2.Text;

                if (checkBox1.Checked == false)

                    _options.AddArgument("headless"); //창을 숨기는 옵션

                _driver = new ChromeDriver(_driverService, _options); //크롬관련 기능 사용을 위한 메서드

                _driver.Navigate().GoToUrl("https://www.naver.com"); //웹사이트 접속

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10); // 충돌방지 

                var element = _driver.FindElement(By.XPath("//*[@id='account']/div/a/i")); //찿으려는요소 html테그
                element.Click();

                Thread.Sleep(3000);

                element = _driver.FindElement(By.XPath("//*[@id='id']"));
                element.SendKeys(id); //??

                element = _driver.FindElement(By.XPath("//*[@id='pw']"));
                element.SendKeys(pw); //??

                element = _driver.FindElement(By.XPath("//*[@id='log,login']"));
                element.Click(); //??

                button1.Text = "로그아웃";
            }
            else
            {
                _driver.Quit(); //종료

                button1.Text = "로그인";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
