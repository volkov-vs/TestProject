
namespace TestProject.Forms
{
    partial class LogavatovskiyForm
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
            this.LayoutPanelBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.OK_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Login_Label = new System.Windows.Forms.Label();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_TextBox = new System.Windows.Forms.TextBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.LayoutPanelBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LayoutPanelBottom
            // 
            this.LayoutPanelBottom.Controls.Add(this.Cancel_Button);
            this.LayoutPanelBottom.Controls.Add(this.OK_Button);
            this.LayoutPanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LayoutPanelBottom.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.LayoutPanelBottom.Location = new System.Drawing.Point(0, 342);
            this.LayoutPanelBottom.Name = "LayoutPanelBottom";
            this.LayoutPanelBottom.Size = new System.Drawing.Size(686, 34);
            this.LayoutPanelBottom.TabIndex = 0;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(608, 3);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 1;
            this.Cancel_Button.Text = "Отмена";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // OK_Button
            // 
            this.OK_Button.Location = new System.Drawing.Point(527, 3);
            this.OK_Button.Name = "OK_Button";
            this.OK_Button.Size = new System.Drawing.Size(75, 23);
            this.OK_Button.TabIndex = 0;
            this.OK_Button.Text = "OK";
            this.OK_Button.UseVisualStyleBackColor = true;
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Login_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Password_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Login_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Password_TextBox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(686, 342);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Login_Label
            // 
            this.Login_Label.AutoSize = true;
            this.Login_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login_Label.Location = new System.Drawing.Point(3, 0);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(48, 26);
            this.Login_Label.TabIndex = 0;
            this.Login_Label.Text = "Логин:";
            this.Login_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Password_Label.Location = new System.Drawing.Point(3, 26);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(48, 26);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Пароль:";
            this.Password_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Login_TextBox
            // 
            this.Login_TextBox.Location = new System.Drawing.Point(57, 3);
            this.Login_TextBox.Name = "Login_TextBox";
            this.Login_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Login_TextBox.TabIndex = 2;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(57, 29);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Password_TextBox.TabIndex = 3;
            // 
            // LogavatovskiyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 376);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.LayoutPanelBottom);
            this.Name = "LogavatovskiyForm";
            this.Text = "Logavatovskiy";
            this.LayoutPanelBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel LayoutPanelBottom;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Login_Label;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox Login_TextBox;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}