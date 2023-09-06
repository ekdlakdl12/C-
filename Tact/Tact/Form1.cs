using System.Globalization;

namespace Tact
{
    public partial class Form1 : Form
    {
        OpenFileDialog _ofd = new OpenFileDialog();
        FolderBrowserDialog _fbd = new FolderBrowserDialog();
        string _path = string.Empty;
        Dictionary<string, string> _dict = new Dictionary<string, string>();
        public Form1()//UI
        {
            InitializeComponent(); //디자이너 단에 정의된 폼컴포넌트
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_fbd.ShowDialog() == DialogResult.OK)
            {
                //string fileFullName = _ofd.FileName;
                //this._path = fileFullName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(_fbd.SelectedPath);
            foreach (string ff in files)
            {
                this._path = ff;
                string[] allLines = File.ReadAllLines(_path);

                foreach (string line in allLines)
                {
                    if (isTargetStringContains(line, "1$"))
                    {
                        string[] temp = line.Split(' ');
                        ParsingData(temp);
                    }
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
            string inductionNo;
            string[] temp;

            time = lines[0] + " " + lines[1];

            temp = lines[4].Split('$'); //
            inductionNo = temp[0];


            if (_dict.ContainsKey(inductionNo) == false)
            {
                _dict.Add(inductionNo, time);
            }
            else
            {
                TimeSpan ts = ParseLogString2DateTime(time).Subtract(ParseLogString2DateTime(_dict[inductionNo]));
                Console.WriteLine(string.Format("{0},{1}", inductionNo, ts.TotalSeconds.ToString()));
                //Console.WriteLine("hi");
                _dict[inductionNo] = time;
            }

        }

        public DateTime ParseLogString2DateTime(string logTimeFormat)
        {
            DateTime result = DateTime.ParseExact(logTimeFormat, "yyyy-MM-dd HH:mm:ss,fff", CultureInfo.InvariantCulture);
            return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}