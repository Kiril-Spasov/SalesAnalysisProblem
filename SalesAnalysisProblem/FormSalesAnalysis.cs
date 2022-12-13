using System;
using System.IO;
using System.Windows.Forms;

namespace SalesAnalysisProblem
{
    public partial class FormSalesAnalysis : Form
    {
        public FormSalesAnalysis()
        {
            InitializeComponent();
        }

        private void BtnShowAnalysis_Click(object sender, EventArgs e)
        {
            int[,] salesTable = new int[11, 4];
            int[] totalSalesPerStyle = new int[11];
            int[] totalSalesPerColor = new int[4];
            int totalSales = 0;

            string path = Application.StartupPath + @"\sales.txt";
            salesTable = LoadDataFromFile(path);

            CalculateTotalSalesPerStyle(salesTable, totalSalesPerStyle);
            CalculateTotalSalesPerColor(salesTable, totalSalesPerColor);
            CalculateTotalSales(salesTable, ref totalSales);

            DisplayAnalysis(salesTable, totalSalesPerStyle, totalSalesPerColor, totalSales);

        }

        private int[,] LoadDataFromFile(string path)
        {
            int[,] salesTable = new int[11, 4];

            string line = "";
            bool finished = false;

            int style;
            int color;
            int sales;

            StreamReader streamReader = new StreamReader(path);

            while (finished == false)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    style = Convert.ToInt32(line);
                    color = Convert.ToInt32(streamReader.ReadLine());
                    sales = Convert.ToInt32(streamReader.ReadLine());

                    salesTable[style, color] += sales;
                }
            }
            return salesTable;
        }


        private void CalculateTotalSalesPerStyle(int[,] salesTable, int[] totalSalesPerStyle)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    totalSalesPerStyle[r] += salesTable[r, c];
                }
            }
        }

        private void CalculateTotalSalesPerColor(int[,] salesTable, int[] totalSalesPerColor)
        {
            for (int c = 1; c <= 3; c++)
            {
                for (int r = 1; r <= 10; r++)
                {
                    totalSalesPerColor[c] += salesTable[r, c];
                }
            }
        }

        private void CalculateTotalSales(int[,] salesTable, ref int totalSales)
        {
            for (int r = 1; r <= 10; r++)
            {
                for (int c = 1; c <= 3; c++)
                {
                    totalSales += salesTable[r, c];
                }
            }
        }

        private void DisplayAnalysis(int[,] salesTable, int[] totalSalesPerStyle, int[] totalSalesPerColor, int totalSales)
        {
            int[] style = new int[11];

            TxtResult.Text += "Style#      Color1      Color2      Color3      Total" + Environment.NewLine;

            for (int i = 1; i <= 10; i++)
            {
                TxtResult.Text += i + "\t";

                for (int j = 1; j <= 3; j++)
                {
                    TxtResult.Text += salesTable[i, j] + "\t";
                }

                TxtResult.Text += totalSalesPerStyle[i] + Environment.NewLine;
            }

            TxtResult.Text += "Totals";

            for (int i = 1; i < totalSalesPerColor.Length; i++)
            {
                TxtResult.Text += "\t" + totalSalesPerColor[i];
            }

            TxtResult.Text += "\t" + totalSales;
            
        }
    }
}
