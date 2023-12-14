
namespace Tyuiu.KorotchenkoDM.Sprint7.Project.V14
{
    partial class FormMain_KDM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelButtons_KDM = new System.Windows.Forms.Panel();
            this.groupBoxOutPut_KDM = new System.Windows.Forms.GroupBox();
            this.panelOutPut_KDM = new System.Windows.Forms.Panel();
            this.groupBoxButtons_KDM = new System.Windows.Forms.GroupBox();
            this.dataGridViewData_KDM = new System.Windows.Forms.DataGridView();
            this.ColumnNumber_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStart_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStop_KDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1_KDM = new System.Windows.Forms.Splitter();
            this.panelDiagram_KDM = new System.Windows.Forms.Panel();
            this.chartDiagram_KDM = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter2_KDM = new System.Windows.Forms.Splitter();
            this.panelInfo_KDM = new System.Windows.Forms.Panel();
            this.labelMin_KDM = new System.Windows.Forms.Label();
            this.labelMax_KDM = new System.Windows.Forms.Label();
            this.labelAverage_KDM = new System.Windows.Forms.Label();
            this.textBoxMin_KDM = new System.Windows.Forms.TextBox();
            this.textBoxMax_KDM = new System.Windows.Forms.TextBox();
            this.textBoxAverage_KDM = new System.Windows.Forms.TextBox();
            this.toolTip_KDM = new System.Windows.Forms.ToolTip(this.components);
            this.buttonInfo_KDM = new System.Windows.Forms.Button();
            this.buttonDone_KDM = new System.Windows.Forms.Button();
            this.panelButtons_KDM.SuspendLayout();
            this.groupBoxOutPut_KDM.SuspendLayout();
            this.panelOutPut_KDM.SuspendLayout();
            this.groupBoxButtons_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_KDM)).BeginInit();
            this.panelDiagram_KDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_KDM)).BeginInit();
            this.panelInfo_KDM.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons_KDM
            // 
            this.panelButtons_KDM.Controls.Add(this.groupBoxOutPut_KDM);
            this.panelButtons_KDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_KDM.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_KDM.Name = "panelButtons_KDM";
            this.panelButtons_KDM.Size = new System.Drawing.Size(1182, 100);
            this.panelButtons_KDM.TabIndex = 0;
            // 
            // groupBoxOutPut_KDM
            // 
            this.groupBoxOutPut_KDM.Controls.Add(this.buttonInfo_KDM);
            this.groupBoxOutPut_KDM.Controls.Add(this.buttonDone_KDM);
            this.groupBoxOutPut_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KDM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KDM.Name = "groupBoxOutPut_KDM";
            this.groupBoxOutPut_KDM.Size = new System.Drawing.Size(1182, 100);
            this.groupBoxOutPut_KDM.TabIndex = 0;
            this.groupBoxOutPut_KDM.TabStop = false;
            // 
            // panelOutPut_KDM
            // 
            this.panelOutPut_KDM.Controls.Add(this.groupBoxButtons_KDM);
            this.panelOutPut_KDM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOutPut_KDM.Location = new System.Drawing.Point(0, 100);
            this.panelOutPut_KDM.Name = "panelOutPut_KDM";
            this.panelOutPut_KDM.Size = new System.Drawing.Size(592, 453);
            this.panelOutPut_KDM.TabIndex = 1;
            // 
            // groupBoxButtons_KDM
            // 
            this.groupBoxButtons_KDM.Controls.Add(this.dataGridViewData_KDM);
            this.groupBoxButtons_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxButtons_KDM.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButtons_KDM.Name = "groupBoxButtons_KDM";
            this.groupBoxButtons_KDM.Size = new System.Drawing.Size(592, 453);
            this.groupBoxButtons_KDM.TabIndex = 0;
            this.groupBoxButtons_KDM.TabStop = false;
            this.groupBoxButtons_KDM.Text = "Вывод";
            // 
            // dataGridViewData_KDM
            // 
            this.dataGridViewData_KDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData_KDM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumber_KDM,
            this.ColumnType_KDM,
            this.ColumnStart_KDM,
            this.ColumnStop_KDM});
            this.dataGridViewData_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData_KDM.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewData_KDM.Name = "dataGridViewData_KDM";
            this.dataGridViewData_KDM.ReadOnly = true;
            this.dataGridViewData_KDM.RowHeadersVisible = false;
            this.dataGridViewData_KDM.RowHeadersWidth = 51;
            this.dataGridViewData_KDM.RowTemplate.Height = 24;
            this.dataGridViewData_KDM.Size = new System.Drawing.Size(586, 432);
            this.dataGridViewData_KDM.TabIndex = 0;
            this.dataGridViewData_KDM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_KDM_CellContentClick);
            this.dataGridViewData_KDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_KDM_CellContentClick);
            // 
            // ColumnNumber_KDM
            // 
            this.ColumnNumber_KDM.HeaderText = "Номер маршрута";
            this.ColumnNumber_KDM.MinimumWidth = 6;
            this.ColumnNumber_KDM.Name = "ColumnNumber_KDM";
            this.ColumnNumber_KDM.ReadOnly = true;
            this.ColumnNumber_KDM.Width = 125;
            // 
            // ColumnType_KDM
            // 
            this.ColumnType_KDM.HeaderText = "Вид транспорта";
            this.ColumnType_KDM.MinimumWidth = 6;
            this.ColumnType_KDM.Name = "ColumnType_KDM";
            this.ColumnType_KDM.ReadOnly = true;
            this.ColumnType_KDM.Width = 125;
            // 
            // ColumnStart_KDM
            // 
            this.ColumnStart_KDM.HeaderText = "Начальная остановка";
            this.ColumnStart_KDM.MinimumWidth = 6;
            this.ColumnStart_KDM.Name = "ColumnStart_KDM";
            this.ColumnStart_KDM.ReadOnly = true;
            this.ColumnStart_KDM.Width = 125;
            // 
            // ColumnStop_KDM
            // 
            this.ColumnStop_KDM.HeaderText = "Конечная остановка";
            this.ColumnStop_KDM.MinimumWidth = 6;
            this.ColumnStop_KDM.Name = "ColumnStop_KDM";
            this.ColumnStop_KDM.ReadOnly = true;
            this.ColumnStop_KDM.Width = 125;
            // 
            // splitter1_KDM
            // 
            this.splitter1_KDM.Location = new System.Drawing.Point(592, 100);
            this.splitter1_KDM.Name = "splitter1_KDM";
            this.splitter1_KDM.Size = new System.Drawing.Size(3, 453);
            this.splitter1_KDM.TabIndex = 2;
            this.splitter1_KDM.TabStop = false;
            // 
            // panelDiagram_KDM
            // 
            this.panelDiagram_KDM.Controls.Add(this.chartDiagram_KDM);
            this.panelDiagram_KDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDiagram_KDM.Location = new System.Drawing.Point(595, 100);
            this.panelDiagram_KDM.Name = "panelDiagram_KDM";
            this.panelDiagram_KDM.Size = new System.Drawing.Size(587, 309);
            this.panelDiagram_KDM.TabIndex = 3;
            // 
            // chartDiagram_KDM
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDiagram_KDM.ChartAreas.Add(chartArea1);
            this.chartDiagram_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartDiagram_KDM.Legends.Add(legend1);
            this.chartDiagram_KDM.Location = new System.Drawing.Point(0, 0);
            this.chartDiagram_KDM.Name = "chartDiagram_KDM";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "SeriesDiagram_KDM";
            this.chartDiagram_KDM.Series.Add(series1);
            this.chartDiagram_KDM.Size = new System.Drawing.Size(587, 309);
            this.chartDiagram_KDM.TabIndex = 0;
            this.chartDiagram_KDM.Text = "chart1";
            // 
            // splitter2_KDM
            // 
            this.splitter2_KDM.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2_KDM.Location = new System.Drawing.Point(595, 409);
            this.splitter2_KDM.Name = "splitter2_KDM";
            this.splitter2_KDM.Size = new System.Drawing.Size(587, 3);
            this.splitter2_KDM.TabIndex = 4;
            this.splitter2_KDM.TabStop = false;
            // 
            // panelInfo_KDM
            // 
            this.panelInfo_KDM.Controls.Add(this.labelMin_KDM);
            this.panelInfo_KDM.Controls.Add(this.labelMax_KDM);
            this.panelInfo_KDM.Controls.Add(this.labelAverage_KDM);
            this.panelInfo_KDM.Controls.Add(this.textBoxMin_KDM);
            this.panelInfo_KDM.Controls.Add(this.textBoxMax_KDM);
            this.panelInfo_KDM.Controls.Add(this.textBoxAverage_KDM);
            this.panelInfo_KDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfo_KDM.Location = new System.Drawing.Point(595, 412);
            this.panelInfo_KDM.Name = "panelInfo_KDM";
            this.panelInfo_KDM.Size = new System.Drawing.Size(587, 141);
            this.panelInfo_KDM.TabIndex = 5;
            // 
            // labelMin_KDM
            // 
            this.labelMin_KDM.AutoSize = true;
            this.labelMin_KDM.Location = new System.Drawing.Point(353, 13);
            this.labelMin_KDM.Name = "labelMin_KDM";
            this.labelMin_KDM.Size = new System.Drawing.Size(30, 17);
            this.labelMin_KDM.TabIndex = 2;
            this.labelMin_KDM.Text = "Min";
            // 
            // labelMax_KDM
            // 
            this.labelMax_KDM.AutoSize = true;
            this.labelMax_KDM.Location = new System.Drawing.Point(197, 13);
            this.labelMax_KDM.Name = "labelMax_KDM";
            this.labelMax_KDM.Size = new System.Drawing.Size(33, 17);
            this.labelMax_KDM.TabIndex = 2;
            this.labelMax_KDM.Text = "Max";
            // 
            // labelAverage_KDM
            // 
            this.labelAverage_KDM.AutoSize = true;
            this.labelAverage_KDM.Location = new System.Drawing.Point(31, 13);
            this.labelAverage_KDM.Name = "labelAverage_KDM";
            this.labelAverage_KDM.Size = new System.Drawing.Size(145, 17);
            this.labelAverage_KDM.TabIndex = 2;
            this.labelAverage_KDM.Text = "Среднее количество";
            // 
            // textBoxMin_KDM
            // 
            this.textBoxMin_KDM.Location = new System.Drawing.Point(356, 36);
            this.textBoxMin_KDM.Name = "textBoxMin_KDM";
            this.textBoxMin_KDM.ReadOnly = true;
            this.textBoxMin_KDM.Size = new System.Drawing.Size(100, 22);
            this.textBoxMin_KDM.TabIndex = 1;
            // 
            // textBoxMax_KDM
            // 
            this.textBoxMax_KDM.Location = new System.Drawing.Point(200, 36);
            this.textBoxMax_KDM.Name = "textBoxMax_KDM";
            this.textBoxMax_KDM.ReadOnly = true;
            this.textBoxMax_KDM.Size = new System.Drawing.Size(100, 22);
            this.textBoxMax_KDM.TabIndex = 1;
            // 
            // textBoxAverage_KDM
            // 
            this.textBoxAverage_KDM.Location = new System.Drawing.Point(34, 36);
            this.textBoxAverage_KDM.Name = "textBoxAverage_KDM";
            this.textBoxAverage_KDM.ReadOnly = true;
            this.textBoxAverage_KDM.Size = new System.Drawing.Size(100, 22);
            this.textBoxAverage_KDM.TabIndex = 1;
            // 
            // toolTip_KDM
            // 
            this.toolTip_KDM.ToolTipTitle = "Подсказка";
            // 
            // buttonInfo_KDM
            // 
            this.buttonInfo_KDM.BackgroundImage = global::Tyuiu.KorotchenkoDM.Sprint7.Project.V14.Properties.Resources.help;
            this.buttonInfo_KDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInfo_KDM.Location = new System.Drawing.Point(99, 12);
            this.buttonInfo_KDM.Name = "buttonInfo_KDM";
            this.buttonInfo_KDM.Size = new System.Drawing.Size(85, 82);
            this.buttonInfo_KDM.TabIndex = 1;
            this.toolTip_KDM.SetToolTip(this.buttonInfo_KDM, "О приложении");
            this.buttonInfo_KDM.UseVisualStyleBackColor = true;
            this.buttonInfo_KDM.Click += new System.EventHandler(this.buttonInfo_KDM_Click);
            // 
            // buttonDone_KDM
            // 
            this.buttonDone_KDM.BackgroundImage = global::Tyuiu.KorotchenkoDM.Sprint7.Project.V14.Properties.Resources.database_go;
            this.buttonDone_KDM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDone_KDM.Location = new System.Drawing.Point(6, 12);
            this.buttonDone_KDM.Name = "buttonDone_KDM";
            this.buttonDone_KDM.Size = new System.Drawing.Size(87, 82);
            this.buttonDone_KDM.TabIndex = 0;
            this.toolTip_KDM.SetToolTip(this.buttonDone_KDM, "Вывести маршруты");
            this.buttonDone_KDM.UseVisualStyleBackColor = true;
            this.buttonDone_KDM.Click += new System.EventHandler(this.buttonDone_KDM_Click);
            // 
            // FormMain_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 553);
            this.Controls.Add(this.panelInfo_KDM);
            this.Controls.Add(this.splitter2_KDM);
            this.Controls.Add(this.panelDiagram_KDM);
            this.Controls.Add(this.splitter1_KDM);
            this.Controls.Add(this.panelOutPut_KDM);
            this.Controls.Add(this.panelButtons_KDM);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormMain_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 7 | Проект | Вариант 14 | Коротченко Д.М.";
            this.panelButtons_KDM.ResumeLayout(false);
            this.groupBoxOutPut_KDM.ResumeLayout(false);
            this.panelOutPut_KDM.ResumeLayout(false);
            this.groupBoxButtons_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData_KDM)).EndInit();
            this.panelDiagram_KDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagram_KDM)).EndInit();
            this.panelInfo_KDM.ResumeLayout(false);
            this.panelInfo_KDM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_KDM;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KDM;
        private System.Windows.Forms.Button buttonDone_KDM;
        private System.Windows.Forms.Panel panelOutPut_KDM;
        private System.Windows.Forms.GroupBox groupBoxButtons_KDM;
        private System.Windows.Forms.Splitter splitter1_KDM;
        private System.Windows.Forms.DataGridView dataGridViewData_KDM;
        private System.Windows.Forms.Panel panelDiagram_KDM;
        private System.Windows.Forms.Splitter splitter2_KDM;
        private System.Windows.Forms.Panel panelInfo_KDM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagram_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumber_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStart_KDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStop_KDM;
        private System.Windows.Forms.Label labelMin_KDM;
        private System.Windows.Forms.Label labelMax_KDM;
        private System.Windows.Forms.Label labelAverage_KDM;
        private System.Windows.Forms.TextBox textBoxMin_KDM;
        private System.Windows.Forms.TextBox textBoxMax_KDM;
        private System.Windows.Forms.TextBox textBoxAverage_KDM;
        private System.Windows.Forms.ToolTip toolTip_KDM;
        private System.Windows.Forms.Button buttonInfo_KDM;
    }
}

