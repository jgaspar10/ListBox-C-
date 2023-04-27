
namespace ListBoxApp
{
    partial class ListBoxAppUI
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
            this.remove_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.add_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.clearList_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.count_button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.input_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remove_button
            // 
            this.remove_button.BorderRadius = 5;
            this.remove_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.remove_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.remove_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.remove_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.remove_button.FillColor = System.Drawing.Color.Teal;
            this.remove_button.FillColor2 = System.Drawing.Color.Teal;
            this.remove_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.remove_button.ForeColor = System.Drawing.Color.White;
            this.remove_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.remove_button.Location = new System.Drawing.Point(132, 189);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(263, 35);
            this.remove_button.TabIndex = 6;
            this.remove_button.Text = "Remove Item";
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // add_button
            // 
            this.add_button.BorderRadius = 5;
            this.add_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add_button.FillColor = System.Drawing.Color.Teal;
            this.add_button.FillColor2 = System.Drawing.Color.Teal;
            this.add_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.add_button.Location = new System.Drawing.Point(132, 134);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(263, 35);
            this.add_button.TabIndex = 5;
            this.add_button.Text = "Add";
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // clearList_button
            // 
            this.clearList_button.BorderRadius = 5;
            this.clearList_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearList_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearList_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearList_button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearList_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearList_button.FillColor = System.Drawing.Color.Teal;
            this.clearList_button.FillColor2 = System.Drawing.Color.Teal;
            this.clearList_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.clearList_button.ForeColor = System.Drawing.Color.White;
            this.clearList_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.clearList_button.Location = new System.Drawing.Point(132, 337);
            this.clearList_button.Name = "clearList_button";
            this.clearList_button.Size = new System.Drawing.Size(263, 35);
            this.clearList_button.TabIndex = 7;
            this.clearList_button.Text = "Clear List";
            this.clearList_button.Click += new System.EventHandler(this.clearList_button_Click);
            // 
            // count_button
            // 
            this.count_button.BorderRadius = 5;
            this.count_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.count_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.count_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.count_button.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.count_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.count_button.FillColor = System.Drawing.Color.Teal;
            this.count_button.FillColor2 = System.Drawing.Color.Teal;
            this.count_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_button.ForeColor = System.Drawing.Color.White;
            this.count_button.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.count_button.Location = new System.Drawing.Point(132, 282);
            this.count_button.Name = "count_button";
            this.count_button.Size = new System.Drawing.Size(263, 35);
            this.count_button.TabIndex = 8;
            this.count_button.Text = "Count Items";
            this.count_button.Click += new System.EventHandler(this.count_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Teal;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ColumnWidth = 2;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(472, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(213, 300);
            this.listBox1.TabIndex = 10;
            // 
            // input_txtbox
            // 
            this.input_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.input_txtbox.DefaultText = "";
            this.input_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.input_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.input_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.input_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_txtbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.input_txtbox.Location = new System.Drawing.Point(132, 68);
            this.input_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.input_txtbox.Name = "input_txtbox";
            this.input_txtbox.PasswordChar = '\0';
            this.input_txtbox.PlaceholderText = "Enter info";
            this.input_txtbox.SelectedText = "";
            this.input_txtbox.Size = new System.Drawing.Size(263, 35);
            this.input_txtbox.TabIndex = 12;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 59);
            this.guna2Panel1.TabIndex = 13;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Teal;
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 391);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(800, 59);
            this.guna2Panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "ListBox Project";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.listBox1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(550, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "List Box";
            // 
            // ListBoxAppUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.input_txtbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.count_button);
            this.Controls.Add(this.clearList_button);
            this.Controls.Add(this.remove_button);
            this.Controls.Add(this.add_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListBoxAppUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ListBoxAppUI_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton remove_button;
        private Guna.UI2.WinForms.Guna2GradientButton add_button;
        private Guna.UI2.WinForms.Guna2GradientButton clearList_button;
        private Guna.UI2.WinForms.Guna2GradientButton count_button;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox input_txtbox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label2;
    }
}

