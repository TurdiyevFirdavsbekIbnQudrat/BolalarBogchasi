namespace BolalarBogchasi.Formlar.tolovQilindi
{
    partial class tolovqilindi
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
            BolaningIdsi = new Label();
            button1 = new Button();
            TolovganKun = new Label();
            Tolov_miqdori = new TextBox();
            ID_bogchadan_olingan = new TextBox();
            SuspendLayout();
            // 
            // BolaningIdsi
            // 
            BolaningIdsi.AutoSize = true;
            BolaningIdsi.Location = new Point(40, 71);
            BolaningIdsi.Name = "BolaningIdsi";
            BolaningIdsi.Size = new Size(20, 15);
            BolaningIdsi.TabIndex = 0;
            BolaningIdsi.Text = "Id:";
            // 
            // button1
            // 
            button1.Location = new Point(41, 131);
            button1.Name = "button1";
            button1.Size = new Size(205, 23);
            button1.TabIndex = 1;
            button1.Text = "tolov boldi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TolovganKun
            // 
            TolovganKun.AutoSize = true;
            TolovganKun.Location = new Point(40, 14);
            TolovganKun.Name = "TolovganKun";
            TolovganKun.Size = new Size(83, 15);
            TolovganKun.TabIndex = 2;
            TolovganKun.Text = "To'lov miqdori";
            // 
            // Tolov_miqdori
            // 
            Tolov_miqdori.Location = new Point(45, 36);
            Tolov_miqdori.Name = "Tolov_miqdori";
            Tolov_miqdori.PlaceholderText = "270000";
            Tolov_miqdori.Size = new Size(201, 23);
            Tolov_miqdori.TabIndex = 3;
            // 
            // ID_bogchadan_olingan
            // 
            ID_bogchadan_olingan.Location = new Point(45, 89);
            ID_bogchadan_olingan.Name = "ID_bogchadan_olingan";
            ID_bogchadan_olingan.PlaceholderText = "-1";
            ID_bogchadan_olingan.Size = new Size(201, 23);
            ID_bogchadan_olingan.TabIndex = 4;
            // 
            // tolovqilindi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 178);
            Controls.Add(ID_bogchadan_olingan);
            Controls.Add(Tolov_miqdori);
            Controls.Add(TolovganKun);
            Controls.Add(button1);
            Controls.Add(BolaningIdsi);
            Name = "tolovqilindi";
            Text = "tolovqilindi";
            Load += tolovqilindi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BolaningIdsi;
        private Button button1;
        private Label TolovganKun;
        private TextBox Tolov_miqdori;
        private TextBox ID_bogchadan_olingan;
    }
}