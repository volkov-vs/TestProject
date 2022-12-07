
namespace TestProject.Forms
{
    partial class MarachevForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.dzCheckBox = new System.Windows.Forms.CheckBox();
            this.trainingMorningCheckBox = new System.Windows.Forms.CheckBox();
            this.trainingEveningCheckBox = new System.Windows.Forms.CheckBox();
            this.infoAboutDayRichTextBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.CancelButton);
            this.flowLayoutPanel1.Controls.Add(this.OKButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 32);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(641, 3);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(722, 3);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.infoLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.infoLabel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.infoLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoLabel4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.dzCheckBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.trainingMorningCheckBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.trainingEveningCheckBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.infoAboutDayRichTextBox, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel1.Location = new System.Drawing.Point(3, 0);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(129, 20);
            this.infoLabel1.TabIndex = 0;
            this.infoLabel1.Text = "Сделал домашку? ";
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel2
            // 
            this.infoLabel2.AutoSize = true;
            this.infoLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel2.Location = new System.Drawing.Point(3, 20);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(129, 20);
            this.infoLabel2.TabIndex = 1;
            this.infoLabel2.Text = "Позанимался утром?";
            this.infoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel3
            // 
            this.infoLabel3.AutoSize = true;
            this.infoLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel3.Location = new System.Drawing.Point(3, 40);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(129, 20);
            this.infoLabel3.TabIndex = 2;
            this.infoLabel3.Text = "Позанимался вечером?";
            this.infoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoLabel4
            // 
            this.infoLabel4.AutoSize = true;
            this.infoLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel4.Location = new System.Drawing.Point(3, 60);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(129, 102);
            this.infoLabel4.TabIndex = 3;
            this.infoLabel4.Text = "Как прошел день:";
            this.infoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dzCheckBox
            // 
            this.dzCheckBox.AutoSize = true;
            this.dzCheckBox.Location = new System.Drawing.Point(138, 3);
            this.dzCheckBox.Name = "dzCheckBox";
            this.dzCheckBox.Size = new System.Drawing.Size(15, 14);
            this.dzCheckBox.TabIndex = 4;
            this.dzCheckBox.UseVisualStyleBackColor = true;
            // 
            // trainingMorningCheckBox
            // 
            this.trainingMorningCheckBox.AutoSize = true;
            this.trainingMorningCheckBox.Location = new System.Drawing.Point(138, 23);
            this.trainingMorningCheckBox.Name = "trainingMorningCheckBox";
            this.trainingMorningCheckBox.Size = new System.Drawing.Size(15, 14);
            this.trainingMorningCheckBox.TabIndex = 5;
            this.trainingMorningCheckBox.UseVisualStyleBackColor = true;
            // 
            // trainingEveningCheckBox
            // 
            this.trainingEveningCheckBox.AutoSize = true;
            this.trainingEveningCheckBox.Location = new System.Drawing.Point(138, 43);
            this.trainingEveningCheckBox.Name = "trainingEveningCheckBox";
            this.trainingEveningCheckBox.Size = new System.Drawing.Size(15, 14);
            this.trainingEveningCheckBox.TabIndex = 6;
            this.trainingEveningCheckBox.UseVisualStyleBackColor = true;
            // 
            // infoAboutDayRichTextBox
            // 
            this.infoAboutDayRichTextBox.Location = new System.Drawing.Point(138, 63);
            this.infoAboutDayRichTextBox.Name = "infoAboutDayRichTextBox";
            this.infoAboutDayRichTextBox.Size = new System.Drawing.Size(100, 96);
            this.infoAboutDayRichTextBox.TabIndex = 7;
            this.infoAboutDayRichTextBox.Text = "";
            // 
            // MarachevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MarachevForm";
            this.Text = "MarachevForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel4;
        private System.Windows.Forms.CheckBox dzCheckBox;
        private System.Windows.Forms.CheckBox trainingMorningCheckBox;
        private System.Windows.Forms.CheckBox trainingEveningCheckBox;
        private System.Windows.Forms.RichTextBox infoAboutDayRichTextBox;
    }
}