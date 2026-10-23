namespace Sentral
{
    partial class Startskjerm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdministrasjon = new Button();
            btnRapporter = new Button();
            lblogg = new ListBox();
            OppdaterLogg = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // btnAdministrasjon
            // 
            btnAdministrasjon.Location = new Point(93, 73);
            btnAdministrasjon.Name = "btnAdministrasjon";
            btnAdministrasjon.Size = new Size(158, 90);
            btnAdministrasjon.TabIndex = 0;
            btnAdministrasjon.Text = "Administrasjon";
            btnAdministrasjon.UseVisualStyleBackColor = true;
            btnAdministrasjon.Click += btnAdministrasjon_Click;
            // 
            // btnRapporter
            // 
            btnRapporter.Location = new Point(414, 89);
            btnRapporter.Name = "btnRapporter";
            btnRapporter.Size = new Size(135, 83);
            btnRapporter.TabIndex = 1;
            btnRapporter.Text = "Rapporter";
            btnRapporter.UseVisualStyleBackColor = true;
            btnRapporter.Click += btnRapporter_Click;
            // 
            // lblogg
            // 
            lblogg.FormattingEnabled = true;
            lblogg.Location = new Point(57, 181);
            lblogg.Name = "lblogg";
            lblogg.Size = new Size(409, 184);
            lblogg.TabIndex = 2;
            // 
            // OppdaterLogg
            // 
            OppdaterLogg.DoWork += OppdaterLogg_DoWork;
            // 
            // Startskjerm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblogg);
            Controls.Add(btnRapporter);
            Controls.Add(btnAdministrasjon);
            Name = "Startskjerm";
            Text = "Sentral";
            Load += Startskjerm_Load;
            ResumeLayout(false);
        }



        #endregion

        private Button btnAdministrasjon;
        private Button btnRapporter;
        private ListBox lblogg;
        private System.ComponentModel.BackgroundWorker OppdaterLogg;
    }
}
