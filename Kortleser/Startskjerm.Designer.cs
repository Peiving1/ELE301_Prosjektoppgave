namespace Kortleser
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
            btnok = new Button();
            cbKortleser = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnok
            // 
            btnok.Location = new Point(347, 163);
            btnok.Name = "btnok";
            btnok.Size = new Size(81, 29);
            btnok.TabIndex = 0;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // cbKortleser
            // 
            cbKortleser.Font = new Font("Segoe UI", 12F);
            cbKortleser.FormattingEnabled = true;
            cbKortleser.Location = new Point(103, 163);
            cbKortleser.Name = "cbKortleser";
            cbKortleser.Size = new Size(198, 29);
            cbKortleser.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(143, 140);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 2;
            label1.Text = "Tilgjenglige rom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(133, 49);
            label2.Name = "label2";
            label2.Size = new Size(295, 30);
            label2.TabIndex = 3;
            label2.Text = "Velg Posisjon for kortleseren";
            // 
            // Startskjerm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 309);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbKortleser);
            Controls.Add(btnok);
            Name = "Startskjerm";
            Text = "Kortleser valg";
            Load += Startskjerm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnok;
        private ComboBox cbKortleser;
        private Label label1;
        private Label label2;
    }
}
