
namespace Tyuiu.KorotchenkoDM.Sprint7.Project.V14
{
    partial class FormAbout_KDM
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
            this.buttonOK_KDM = new System.Windows.Forms.Button();
            this.label_KDM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOK_KDM
            // 
            this.buttonOK_KDM.Location = new System.Drawing.Point(271, 102);
            this.buttonOK_KDM.Name = "buttonOK_KDM";
            this.buttonOK_KDM.Size = new System.Drawing.Size(99, 39);
            this.buttonOK_KDM.TabIndex = 0;
            this.buttonOK_KDM.Text = "OK";
            this.buttonOK_KDM.UseVisualStyleBackColor = true;
            this.buttonOK_KDM.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_KDM
            // 
            this.label_KDM.AutoSize = true;
            this.label_KDM.Location = new System.Drawing.Point(12, 9);
            this.label_KDM.Name = "label_KDM";
            this.label_KDM.Size = new System.Drawing.Size(319, 34);
            this.label_KDM.TabIndex = 1;
            this.label_KDM.Text = "Проект выполнил студент группы ИСТНб-23-1 \r\nКоротченко Д.М.";
            // 
            // FormAbout_KDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 153);
            this.Controls.Add(this.label_KDM);
            this.Controls.Add(this.buttonOK_KDM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormAbout_KDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О приложении";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_KDM;
        private System.Windows.Forms.Label label_KDM;
    }
}