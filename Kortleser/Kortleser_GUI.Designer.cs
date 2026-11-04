namespace Kortleser
{
    partial class Kortleser_GUI
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
            tbLokasjon = new TextBox();
            label1 = new Label();
            tbKortID = new TextBox();
            tbPINKode = new TextBox();
            panel1 = new Panel();
            btnBekreft = new Button();
            label3 = new Label();
            label2 = new Label();
            bwHentData = new System.ComponentModel.BackgroundWorker();
            lAlarm = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbLokasjon
            // 
            tbLokasjon.Font = new Font("Segoe UI", 12F);
            tbLokasjon.Location = new Point(126, 34);
            tbLokasjon.Margin = new Padding(3, 4, 3, 4);
            tbLokasjon.Name = "tbLokasjon";
            tbLokasjon.ReadOnly = true;
            tbLokasjon.Size = new Size(114, 34);
            tbLokasjon.TabIndex = 0;
            tbLokasjon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 28);
            label1.TabIndex = 1;
            label1.Text = "Lokasjon";
            // 
            // tbKortID
            // 
            tbKortID.Location = new Point(51, 81);
            tbKortID.Margin = new Padding(3, 4, 3, 4);
            tbKortID.Name = "tbKortID";
            tbKortID.Size = new Size(114, 27);
            tbKortID.TabIndex = 2;
            tbKortID.KeyPress += tbKortID_KeyPress;
            // 
            // tbPINKode
            // 
            tbPINKode.Location = new Point(183, 81);
            tbPINKode.Margin = new Padding(3, 4, 3, 4);
            tbPINKode.Name = "tbPINKode";
            tbPINKode.Size = new Size(114, 27);
            tbPINKode.TabIndex = 3;
            tbPINKode.KeyPress += tbPINKode_KeyPress;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnBekreft);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbKortID);
            panel1.Controls.Add(tbPINKode);
            panel1.Location = new Point(30, 156);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 183);
            panel1.TabIndex = 4;
            // 
            // btnBekreft
            // 
            btnBekreft.Location = new Point(128, 120);
            btnBekreft.Margin = new Padding(3, 4, 3, 4);
            btnBekreft.Name = "btnBekreft";
            btnBekreft.Size = new Size(86, 31);
            btnBekreft.TabIndex = 6;
            btnBekreft.Text = "Bekreft";
            btnBekreft.UseVisualStyleBackColor = true;
            btnBekreft.Click += btnBekreft_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 49);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 5;
            label3.Text = "PINKode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 49);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 4;
            label2.Text = "KortID";
            // 
            // bwHentData
            // 
            bwHentData.DoWork += bwHentData_DoWork;
            bwHentData.RunWorkerCompleted += bwHentData_RunWorkerCompleted;
            // 
            // lAlarm
            // 
            lAlarm.AutoSize = true;
            lAlarm.BackColor = SystemColors.ControlDark;
            lAlarm.Font = new Font("Segoe UI", 20.2F, FontStyle.Bold);
            lAlarm.ForeColor = Color.Red;
            lAlarm.Location = new Point(113, 85);
            lAlarm.Name = "lAlarm";
            lAlarm.Size = new Size(152, 46);
            lAlarm.TabIndex = 5;
            lAlarm.Text = "ALARM!";
            lAlarm.Visible = false;
            // 
            // Kortleser_GUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 439);
            Controls.Add(lAlarm);
            Controls.Add(label1);
            Controls.Add(tbLokasjon);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Kortleser_GUI";
            Text = "Kortleser_GUI";
            FormClosing += Kortleser_GUI_FormClosing_1;
            Load += Kortleser_GUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLokasjon;
        private Label label1;
        private TextBox tbKortID;
        private TextBox tbPINKode;
        private Panel panel1;
        private Button btnBekreft;
        private Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker bwHentData;
        private Label lAlarm;
    }
}