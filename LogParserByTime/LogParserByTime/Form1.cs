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
    public partial class Form1 : Form
    {
        OpenFileDialog _ofd = new OpenFileDialog();
        string _path = string.Empty;
        Dictionary<string, string> _dict = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ofd.ShowDialog() == DialogResult.OK)
            {
                string fileFullName = _ofd.FileName;
                this._path = fileFullName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!File.Exists(_path))
            {
                return;
            }


            string[] allLines = File.ReadAllLines(_path);

            foreach (string line in allLines)
            {
                if (isTargetStringContains(line, "Mode Change Req"))
                {
                    string[] temp= line.Split(' ');
                    ParsingData(temp);
                }
            }
        }

        private bool isTargetStringContains(string line, string containString)
        {
            bool result = line.Contains(containString);
            return result;
        }

        private void ParsingData(string[] lines)
        {
            string time;
            string chuteNo;
            string chuteFull;

            time = lines[0] + " " + lines[1];
            chuteNo = lines[10];
            chuteFull = lines[13];

            if(chuteFull.Equals("False"))
            {
                _dict.Add(chuteNo, time);
            }
            else
            {
               TimeSpan ts = ParseLogString2DateTime(time).Subtract(ParseLogString2DateTime(_dict[chuteNo]));
               Console.WriteLine(string.Format("{0},{1}",chuteNo, ts.TotalSeconds.ToString()));
                _dict.Remove(chuteNo);
            }

        }

        public DateTime ParseLogString2DateTime(string logTimeFormat)
        {
            DateTime result = DateTime.ParseExact(logTimeFormat, "yyyy-MM-dd HH:mm:ss,fff", CultureInfo.InvariantCulture);
            return result;
        }
    }
}
