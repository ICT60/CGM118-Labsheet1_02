using System;
using System.Windows.Forms;

namespace Labsheet1_02
{
    public partial class MainForm : Form
    {
        Square square;


        public MainForm()
        {
            InitializeComponent();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            _Initialize();
        }

        void btnArea_Click(object sender, EventArgs e)
        {
            _ShowSquareAreaHandler();
        }

        void _Initialize()
        {
            square = new Square();
            txtWidth.Text = square.Width.ToString();
            txtHeight.Text = square.Height.ToString();
        }

        void _ShowSquareAreaHandler()
        {
            double width = 0.0d;
            double height = 0.0d;

            var isCanParse = 
                double.TryParse(txtWidth.Text, out width) &&
                double.TryParse(txtHeight.Text, out height);

            if (isCanParse)
            {
                square.Width = width;
                square.Height = height;

                var result = string.Format("Area : {0}", square.Area);
                MessageBox.Show(result, "Result");
            }
            else
            {
                MessageBox.Show("Please enter only number..");
            }
        }
    }
}
