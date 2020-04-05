using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace WitchOfAgnesi
{
    public partial class MainForm : Form
    {
        FuncCalc GetAgnesi;
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
            else if (check4 <= 0) {
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

        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            LeftBoardTextBox.Text = "";
            RightBoardTextBox.Text = "";
            StepTextBox.Text = "";
            ParamTextBox.Text = "";
            ValuesTable.Columns.Clear();
            WitchOfAgnesiChart.Series[0].Points.Clear();
            
        }

        private void IsEmpty(object sender, EventArgs e)
        {
            if (LeftBoardTextBox.Text == "" || RightBoardTextBox.Text == "" || StepTextBox.Text == "" || ParamTextBox.Text == "") {
                GetChart.Enabled = false;
            }
            else if (LeftBoardTextBox.Text != "" && RightBoardTextBox.Text != "" && StepTextBox.Text != "" && ParamTextBox.Text != "")
            {
                GetChart.Enabled = true;
            }
            if (LeftBoardTextBox.Text != "" || RightBoardTextBox.Text != "" || StepTextBox.Text != "" || ParamTextBox.Text != "" || ValuesTable.Columns.Count != 0)
            {
                ClearAll.Enabled = true;
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
    }
}
