using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Text;
using System.Linq;

namespace WitchOfAgnesi
{
    public partial class MainForm : Form
    {
        FuncCalc GetAgnesi;
        OpenFileDialog openFileDialog;
        SaveFileDialog saveFileDialog;
        public MainForm()
        {
            InitializeComponent();
        }

        private bool CheckValues(double check1, double check2, double check3, double check4) {
            if (check1 >= check2 || check1 + check3 > check2)
            {
                MessageBox.Show("Невозможно построить график в заданном интервале. Введите другие значения.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (check3 <= 0) {
                MessageBox.Show("Введено недопустимое значение шага. Введите другое значение шага(положительное число).", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (check4 <= 0)
            {
                MessageBox.Show("Значние параметра не соответствует его области допустимых значений. Введите другое значение параметра (a>0).", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void GetChart_Click(object sender, System.EventArgs e)
        {
            double leftB, step, rightB;
            GetAgnesi = new FuncCalc();
            try
            {
                leftB = Convert.ToDouble(LeftBoardTextBox.Text);
                rightB = Convert.ToDouble(RightBoardTextBox.Text);
                step = Convert.ToDouble(StepTextBox.Text);
                
                GetAgnesi.aNum = Convert.ToDouble(ParamTextBox.Text);
            }
            catch {
                MessageBox.Show("Введены некорректные данные. Повторите попытку.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!CheckValues(leftB,rightB,step,GetAgnesi.aNum)) {
                return;
            }
            WitchOfAgnesiChart.Series[0].Points.Clear();
            WitchOfAgnesiChart.Series[0].ChartType = SeriesChartType.Spline;
            ValuesTable.Columns.Clear();
            ValuesTable.Columns.Add("Xvalue", "X");
            ValuesTable.Columns.Add("Yvalue", "Y");
            for (double i = leftB;i <= rightB;i+=step) {
                double tmp = GetAgnesi.Calculate(i);
                WitchOfAgnesiChart.Series[0].Points.AddXY(i, tmp);
                ValuesTable.Rows.Add(i, Math.Round(tmp,5));
            }
            SaveResults.Enabled = true;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            LeftBoardTextBox.Text = "";
            RightBoardTextBox.Text = "";
            StepTextBox.Text = "";
            ParamTextBox.Text = "";
            ValuesTable.Columns.Clear();
            WitchOfAgnesiChart.Series[0].Points.Clear();
            ClearAll.Enabled = false;
        }

        private void IsEmpty(object sender, EventArgs e)
        {
            if (LeftBoardTextBox.Text == "" || RightBoardTextBox.Text == "" || StepTextBox.Text == "" || ParamTextBox.Text == "") {
                GetChart.Enabled = false;
                SaveData.Enabled = false;
            }
            else if (LeftBoardTextBox.Text != "" && RightBoardTextBox.Text != "" && StepTextBox.Text != "" && ParamTextBox.Text != "")
            {
                GetChart.Enabled = true;
                SaveData.Enabled = true;
            }
            if (LeftBoardTextBox.Text != "" || RightBoardTextBox.Text != "" || StepTextBox.Text != "" || ParamTextBox.Text != "" || ValuesTable.Columns.Count != 0)
            {
                ClearAll.Enabled = true;
                SaveResults.Enabled = false;
            }
            else {
                ClearAll.Enabled = false;
            }
        }
        private void KeyTyping(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar!= '-' && e.KeyChar !=',' && e.KeyChar != (int)Keys.Back)
                e.KeyChar = '\0';
        }

        private void LoadData_Click(object sender, EventArgs e)
        {
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string tmp = File.ReadAllText(openFileDialog.FileName, Encoding.Default);
                    string []array = tmp.Split(' ' , '\n').ToArray();
                    LeftBoardTextBox.Text = array[0];
                    RightBoardTextBox.Text = array[1];
                    StepTextBox.Text = array[2];
                    ParamTextBox.Text = array[3];
                }
                catch {
                    MessageBox.Show("Файл содержит некорректные данные или имеет неправильный формат. Выберите другой файл.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
        }

        private void SaveData_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            string tmp = LeftBoardTextBox.Text + " " + RightBoardTextBox.Text + " " + StepTextBox.Text + " " + ParamTextBox.Text;
            File.WriteAllText(filename, tmp);
            MessageBox.Show("Файл сохранен");
        }

        private void SaveResults_Click(object sender, EventArgs e)
        {
            saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog.FileName;
            string tmp = LeftBoardTextBox.Text + " " + RightBoardTextBox.Text + " " + StepTextBox.Text + " " + ParamTextBox.Text;
            tmp += "\n";
            File.WriteAllText(filename, tmp);
            tmp = Convert.ToString(ValuesTable.Columns[0].HeaderText) + " " + Convert.ToString(ValuesTable.Columns[1].HeaderText);
            tmp += "\n";
            File.AppendAllText(filename, tmp);
            for (int i = 0; i < ValuesTable.Rows.Count; i++)
            {
                tmp = Convert.ToString(ValuesTable.Rows[i].Cells[0].Value) + " " + Convert.ToString(ValuesTable.Rows[i].Cells[1].Value);
                tmp += "\n";
                File.AppendAllText(filename, tmp);
            }
            MessageBox.Show("Файл сохранен");
        }
    }
}
