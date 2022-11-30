namespace TestProject.Forms
{
    partial class PeshkovForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.peshkovTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.studentLabel = new System.Windows.Forms.Label();
            this.groupLabel = new System.Windows.Forms.Label();
            this.nicknameLabel = new System.Windows.Forms.Label();
            this.peshkovTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(180, 132);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(261, 132);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // peshkovTableLayoutPanel
            // 
            this.peshkovTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.peshkovTableLayoutPanel.ColumnCount = 2;
            this.peshkovTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.85714F));
            this.peshkovTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.14286F));
            this.peshkovTableLayoutPanel.Controls.Add(this.studentLabel, 0, 0);
            this.peshkovTableLayoutPanel.Controls.Add(this.groupLabel, 0, 1);
            this.peshkovTableLayoutPanel.Controls.Add(this.nicknameLabel, 1, 0);
            this.peshkovTableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.peshkovTableLayoutPanel.Name = "peshkovTableLayoutPanel";
            this.peshkovTableLayoutPanel.RowCount = 2;
            this.peshkovTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.peshkovTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.peshkovTableLayoutPanel.Size = new System.Drawing.Size(329, 114);
            this.peshkovTableLayoutPanel.TabIndex = 2;
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentLabel.Location = new System.Drawing.Point(3, 0);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(135, 26);
            this.studentLabel.TabIndex = 0;
            this.studentLabel.Text = "Студент: Пешков Е.С.\r\n\r\n";
            // 
            // groupLabel
            // 
            this.groupLabel.AutoSize = true;
            this.groupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLabel.Location = new System.Drawing.Point(3, 26);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(135, 88);
            this.groupLabel.TabIndex = 1;
            this.groupLabel.Text = "Группа: ИСПк-о20";
            // 
            // nicknameLabel
            // 
            this.nicknameLabel.AutoSize = true;
            this.nicknameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nicknameLabel.Location = new System.Drawing.Point(144, 0);
            this.nicknameLabel.Name = "nicknameLabel";
            this.nicknameLabel.Size = new System.Drawing.Size(182, 26);
            this.nicknameLabel.TabIndex = 2;
            this.nicknameLabel.Text = "Никнейм GitHub: EgorPeshkov\r\n";
            // 
            // PeshkovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 167);
            this.Controls.Add(this.peshkovTableLayoutPanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Name = "PeshkovForm";
            this.Text = "PeshkovForm";
            this.Load += new System.EventHandler(this.PeshkovForm_Load);
            this.peshkovTableLayoutPanel.ResumeLayout(false);
            this.peshkovTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TableLayoutPanel peshkovTableLayoutPanel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.Label nicknameLabel;
    }
}