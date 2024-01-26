namespace BolalarBogchasi.Hodim_o_z_malumotlarini_ko_rishi
{
    partial class Hodim_Malumotlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            HodimningMaoshi = new Label();
            HodimMaoshiningQiymati = new Label();
            HodimQanchadanBerIshlamoqda = new Label();
            HodimIshkuniSoni = new Label();
            HodimningMaoshiChiqishKuni = new Label();
            HodimMaoshiningChiqishKuni = new Label();
            SuspendLayout();
            // 
            // HodimningMaoshi
            // 
            HodimningMaoshi.AutoSize = true;
            HodimningMaoshi.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimningMaoshi.Location = new Point(18, 163);
            HodimningMaoshi.Name = "HodimningMaoshi";
            HodimningMaoshi.Size = new Size(66, 22);
            HodimningMaoshi.TabIndex = 0;
            HodimningMaoshi.Text = "Maosh";
            // 
            // HodimMaoshiningQiymati
            // 
            HodimMaoshiningQiymati.AutoSize = true;
            HodimMaoshiningQiymati.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimMaoshiningQiymati.Location = new Point(215, 163);
            HodimMaoshiningQiymati.Name = "HodimMaoshiningQiymati";
            HodimMaoshiningQiymati.Size = new Size(75, 22);
            HodimMaoshiningQiymati.TabIndex = 1;
            HodimMaoshiningQiymati.Text = "Qiymati";
            // 
            // HodimQanchadanBerIshlamoqda
            // 
            HodimQanchadanBerIshlamoqda.AutoSize = true;
            HodimQanchadanBerIshlamoqda.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimQanchadanBerIshlamoqda.Location = new Point(18, 86);
            HodimQanchadanBerIshlamoqda.Name = "HodimQanchadanBerIshlamoqda";
            HodimQanchadanBerIshlamoqda.Size = new Size(184, 22);
            HodimQanchadanBerIshlamoqda.TabIndex = 2;
            HodimQanchadanBerIshlamoqda.Text = "Ishga boshlagan kuni";
            // 
            // HodimIshkuniSoni
            // 
            HodimIshkuniSoni.AutoSize = true;
            HodimIshkuniSoni.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimIshkuniSoni.Location = new Point(215, 86);
            HodimIshkuniSoni.Name = "HodimIshkuniSoni";
            HodimIshkuniSoni.Size = new Size(105, 22);
            HodimIshkuniSoni.TabIndex = 3;
            HodimIshkuniSoni.Text = "Kunlar soni";
            HodimIshkuniSoni.Click += HodimIshkuniSoni_Click;
            // 
            // HodimningMaoshiChiqishKuni
            // 
            HodimningMaoshiChiqishKuni.AutoSize = true;
            HodimningMaoshiChiqishKuni.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimningMaoshiChiqishKuni.Location = new Point(18, 125);
            HodimningMaoshiChiqishKuni.Name = "HodimningMaoshiChiqishKuni";
            HodimningMaoshiChiqishKuni.Size = new Size(174, 22);
            HodimningMaoshiChiqishKuni.TabIndex = 4;
            HodimningMaoshiChiqishKuni.Text = "Ishni boshlagan kun";
            // 
            // HodimMaoshiningChiqishKuni
            // 
            HodimMaoshiningChiqishKuni.AutoSize = true;
            HodimMaoshiningChiqishKuni.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HodimMaoshiningChiqishKuni.Location = new Point(215, 125);
            HodimMaoshiningChiqishKuni.Name = "HodimMaoshiningChiqishKuni";
            HodimMaoshiningChiqishKuni.Size = new Size(113, 22);
            HodimMaoshiningChiqishKuni.TabIndex = 5;
            HodimMaoshiningChiqishKuni.Text = "chiqishi kuni";
            // 
            // Hodim_Malumotlari
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(335, 221);
            Controls.Add(HodimMaoshiningChiqishKuni);
            Controls.Add(HodimningMaoshiChiqishKuni);
            Controls.Add(HodimIshkuniSoni);
            Controls.Add(HodimQanchadanBerIshlamoqda);
            Controls.Add(HodimMaoshiningQiymati);
            Controls.Add(HodimningMaoshi);
            MaximumSize = new Size(351, 260);
            MinimumSize = new Size(351, 260);
            Name = "Hodim_Malumotlari";
            Text = "Hodim Malumotlari";
            Load += Hodim_Malumotlari_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HodimningMaoshi;
        private Label HodimMaoshiningQiymati;
        private Label HodimQanchadanBerIshlamoqda;
        private Label HodimIshkuniSoni;
        private Label HodimningMaoshiChiqishKuni;
        private Label HodimMaoshiningChiqishKuni;
    }
}