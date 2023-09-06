using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogParserByTime
{
    public partial class Form1 : Form //UI
    {
        OpenFileDialog _ofd = new OpenFileDialog(); //파일선택
        string _path = string.Empty;
        Dictionary<string, string> _dict = new Dictionary<string, string>(); 
        public Form1()
        {
            InitializeComponent();//디자이너 단에 정의된 폼컴포넌트
        }

        private void button1_Click(object sender, EventArgs e) //버튼1
        {
            if (_ofd.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = _ofd.FileName;
                this._path = fileFullName;
            }
        }

        private void button2_Click(object sender, EventArgs e) //버튼2
        {
            if (!File.Exists(_path))
            {
                return;
            }

            string[] allLines = File.ReadAllLines(_path);

            foreach (string line in allLines) //파일이 존재할시
            {
                if (isTargetStringContains(line, "Mode Change Req")) //Contains 메서드 
                {
                    string[] temp= line.Split(' '); //스플릿후 temp 변수에 넣음
                    ParsingData(temp); //파싱
                }
            }
        }

        private bool isTargetStringContains(string line, string containString)
        {
            bool result = line.Contains(containString);
            return result; //
        }

        private void ParsingData(string[] lines)
        {
            string time; //시간
            string chuteNo; //슈트넘버
            string chuteFull; 

            time = lines[0] + " " + lines[1];
            chuteNo = lines[10];
            chuteFull = lines[13];

            if(chuteFull.Equals("False"))
            {
                _dict.Add(chuteNo, time); //딕셔너리에 추가
            }
            else
            {
               TimeSpan ts = ParseLogString2DateTime(time).Subtract(ParseLogString2DateTime(_dict[chuteNo]));
               Console.WriteLine(string.Format("{0},{1}",chuteNo, ts.TotalSeconds.ToString())); //찍기
                _dict.Remove(chuteNo);
            }
        }

        public DateTime ParseLogString2DateTime(string logTimeFormat)
        {
            DateTime result = DateTime.ParseExact(logTimeFormat, "yyyy-MM-dd HH:mm:ss,fff", CultureInfo.InvariantCulture);
            return result;//
        }
    }
}
