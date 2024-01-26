namespace BolalarBogchasi.Formlar.Boshqaruvchi
{
    partial class Oraliq
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
            HodimMalumotlariga = new Button();
            BolaMalumotlariga = new Button();
            TolovMalumotlariga = new Button();
            SuspendLayout();
            // 
            // HodimMalumotlariga
            // 
            HodimMalumotlariga.Location = new Point(59, 29);
            HodimMalumotlariga.Name = "HodimMalumotlariga";
            HodimMalumotlariga.Size = new Size(216, 23);
            HodimMalumotlariga.TabIndex = 0;
            HodimMalumotlariga.Text = "Hodim";
            HodimMalumotlariga.UseVisualStyleBackColor = true;
            HodimMalumotlariga.Click += HodimMalumotlariga_Click;
            // 
            // BolaMalumotlariga
            // 
            BolaMalumotlariga.Location = new Point(59, 106);
            BolaMalumotlariga.Name = "BolaMalumotlariga";
            BolaMalumotlariga.Size = new Size(216, 23);
            BolaMalumotlariga.TabIndex = 1;
            BolaMalumotlariga.Text = "Bola";
            BolaMalumotlariga.UseVisualStyleBackColor = true;
            BolaMalumotlariga.Click += BolaMalumotlariga_Click;
            // 
            // TolovMalumotlariga
            // 
            TolovMalumotlariga.Location = new Point(59, 188);
            TolovMalumotlariga.Name = "TolovMalumotlariga";
            TolovMalumotlariga.Size = new Size(216, 23);
            TolovMalumotlariga.TabIndex = 2;
            TolovMalumotlariga.Text = "To'lov";
            TolovMalumotlariga.UseVisualStyleBackColor = true;
            TolovMalumotlariga.Click += TolovMalumotlariga_Click;
            // 
            // Oraliq
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 242);
            Controls.Add(TolovMalumotlariga);
            Controls.Add(BolaMalumotlariga);
            Controls.Add(HodimMalumotlariga);
            Name = "Oraliq";
            Text = "Oraliq";
            Load += Oraliq_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button HodimMalumotlariga;
        private Button BolaMalumotlariga;
        private Button TolovMalumotlariga;
    }
}