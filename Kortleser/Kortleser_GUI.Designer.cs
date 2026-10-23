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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbLokasjon
            // 
            tbLokasjon.Font = new Font("Segoe UI", 12F);
            tbLokasjon.Location = new Point(110, 30);
            tbLokasjon.Name = "tbLokasjon";
            tbLokasjon.ReadOnly = true;
            tbLokasjon.Size = new Size(100, 29);
            tbLokasjon.TabIndex = 0;
            tbLokasjon.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 30);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 1;
            label1.Text = "Lokasjon";
            // 
            // tbKortID
            // 
            tbKortID.Location = new Point(45, 61);
            tbKortID.Name = "tbKortID";
            tbKortID.Size = new Size(100, 23);
            tbKortID.TabIndex = 2;
            tbKortID.KeyPress += tbKortID_KeyPress;
            // 
            // tbPINKode
            // 
            tbPINKode.Location = new Point(160, 61);
            tbPINKode.Name = "tbPINKode";
            tbPINKode.Size = new Size(100, 23);
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
            panel1.Location = new Point(26, 117);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 138);
            panel1.TabIndex = 4;
            // 
            // btnBekreft
            // 
            btnBekreft.Location = new Point(112, 90);
            btnBekreft.Name = "btnBekreft";
            btnBekreft.Size = new Size(75, 23);
            btnBekreft.TabIndex = 6;
            btnBekreft.Text = "Bekreft";
            btnBekreft.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 37);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 5;
            label3.Text = "PINKode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 37);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "KortID";
            // 
            // Kortleser_GUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 329);
            Controls.Add(label1);
            Controls.Add(tbLokasjon);
            Controls.Add(panel1);
            Name = "Kortleser_GUI";
            Text = "Kortleser_GUI";
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
    }
}