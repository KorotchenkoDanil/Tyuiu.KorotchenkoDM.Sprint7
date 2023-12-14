using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KorotchenkoDM.Sprint7.Project.V14.Lib;

namespace Tyuiu.KorotchenkoDM.Sprint7.Project.V14
{
    public partial class FormMain_KDM : Form
    {
        public FormMain_KDM()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KDM_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint7\Tyuiu.KorotchenkoDM.Sprint7.Project.V14\bin\Debug\Routes.txt";
            foreach (var line in File.ReadLines(path))
            {
                var array = line.Split(',');
                dataGridViewData_KDM.Rows.Add(array);
            }
        }

        private void dataGridViewData_KDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.chartDiagram_KDM.ChartAreas[0].AxisX.Title = "Время";
            this.chartDiagram_KDM.ChartAreas[0].AxisY.Title = "Количество автомобилей";
            chartDiagram_KDM.Series[0].Points.Clear();
            string path = @"C:\Users\ДАНИЛ\source\repos\Tyuiu.KorotchenkoDM.Sprint7\Tyuiu.KorotchenkoDM.Sprint7.Project.V14\bin\Debug\Count.txt";

            int columns = 5;
            int rows = 23;
             
            string[] lines = File.ReadAllLines(path);
            int[,] matrix = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                int[] row = lines[i].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(Int32.Parse).ToArray();
                for (int j = 0; j < rows; j++)
                {                    
                    matrix[i, j] = row[j];
                }
            }

            int[] array = new int[23];

            if (dataGridViewData_KDM.CurrentCell.RowIndex.Equals(0) && e.RowIndex != -1)
            {
                if (dataGridViewData_KDM.CurrentCell != null && dataGridViewData_KDM.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_KDM.Series[0].Points.AddXY(j + ":00", matrix[0, j]);
                        array[j] = matrix[0, j];                        
                    }
                    textBoxAverage_KDM.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_KDM.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_KDM.Text = Convert.ToString(ds.Min(array));
                }                   
            }
            if (dataGridViewData_KDM.CurrentCell.RowIndex.Equals(1) && e.RowIndex != -1)
            {
                if (dataGridViewData_KDM.CurrentCell != null && dataGridViewData_KDM.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_KDM.Series[0].Points.AddXY(j + ":00", matrix[1, j]);
                        array[j] = matrix[1, j];
                    }
                    textBoxAverage_KDM.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_KDM.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_KDM.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_KDM.CurrentCell.RowIndex.Equals(2) && e.RowIndex != -1)
            {
                if (dataGridViewData_KDM.CurrentCell != null && dataGridViewData_KDM.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_KDM.Series[0].Points.AddXY(j + ":00", matrix[2, j]);
                        array[j] = matrix[2, j];
                    }
                    textBoxAverage_KDM.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_KDM.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_KDM.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_KDM.CurrentCell.RowIndex.Equals(3) && e.RowIndex != -1)
            {
                if (dataGridViewData_KDM.CurrentCell != null && dataGridViewData_KDM.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_KDM.Series[0].Points.AddXY(j + ":00", matrix[3, j]);
                        array[j] = matrix[3, j];
                    }
                    textBoxAverage_KDM.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_KDM.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_KDM.Text = Convert.ToString(ds.Min(array));
                }
            }
            if (dataGridViewData_KDM.CurrentCell.RowIndex.Equals(4) && e.RowIndex != -1)
            {
                if (dataGridViewData_KDM.CurrentCell != null && dataGridViewData_KDM.CurrentCell.Value != null)
                {
                    for (int j = 0; j < matrix.GetUpperBound(1); j++)
                    {
                        chartDiagram_KDM.Series[0].Points.AddXY(j + ":00", matrix[4, j]);
                        array[j] = matrix[4, j];
                    }
                    textBoxAverage_KDM.Text = Convert.ToString(ds.Average(array));
                    textBoxMax_KDM.Text = Convert.ToString(ds.Max(array));
                    textBoxMin_KDM.Text = Convert.ToString(ds.Min(array));
                }
            }            
        }

        private void buttonInfo_KDM_Click(object sender, EventArgs e)
        {
            FormAbout_KDM formAbout = new FormAbout_KDM();
            formAbout.ShowDialog();
        }
    }
}
