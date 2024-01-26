namespace BolalarBogchasi
{
    partial class Bolalar_bogchasi_kirish
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Bolalar_bogchasi_kirish));
            BogchaNomi = new Label();
            IDkiritish = new Label();
            KiritilganTelefonRaqam = new Label();
            IDningKirishdaTextBoxi = new TextBox();
            TelefonRaqamKirishda = new TextBox();
            KirishTekshiruvi = new Button();
            MalumotlarBerdi = new Button();
            SuspendLayout();
            // 
            // BogchaNomi
            // 
            BogchaNomi.AutoSize = true;
            BogchaNomi.BackColor = Color.Transparent;
            BogchaNomi.Font = new Font("Showcard Gothic", 24F, FontStyle.Underline, GraphicsUnit.Point);
            BogchaNomi.Location = new Point(138, 50);
            BogchaNomi.Name = "BogchaNomi";
            BogchaNomi.Size = new Size(155, 40);
            BogchaNomi.TabIndex = 0;
            BogchaNomi.Text = "Bog'cha";
            // 
            // IDkiritish
            // 
            IDkiritish.AutoSize = true;
            IDkiritish.BackColor = Color.Silver;
            IDkiritish.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDkiritish.Location = new Point(38, 147);
            IDkiritish.Name = "IDkiritish";
            IDkiritish.Size = new Size(380, 20);
            IDkiritish.TabIndex = 1;
            IDkiritish.Text = "Bog'cha tomonidan berilgan Idni kiriting:";
            // 
            // KiritilganTelefonRaqam
            // 
            KiritilganTelefonRaqam.AutoSize = true;
            KiritilganTelefonRaqam.BackColor = Color.Silver;
            KiritilganTelefonRaqam.Font = new Font("Showcard Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            KiritilganTelefonRaqam.Location = new Point(38, 217);
            KiritilganTelefonRaqam.Name = "KiritilganTelefonRaqam";
            KiritilganTelefonRaqam.Size = new Size(143, 20);
            KiritilganTelefonRaqam.TabIndex = 2;
            KiritilganTelefonRaqam.Text = "Telefon raqam:";
            // 
            // IDningKirishdaTextBoxi
            // 
            IDningKirishdaTextBoxi.Location = new Point(40, 180);
            IDningKirishdaTextBoxi.MaximumSize = new Size(203, 23);
            IDningKirishdaTextBoxi.MinimumSize = new Size(203, 23);
            IDningKirishdaTextBoxi.Name = "IDningKirishdaTextBoxi";
            IDningKirishdaTextBoxi.PlaceholderText = "1234";
            IDningKirishdaTextBoxi.Size = new Size(203, 23);
            IDningKirishdaTextBoxi.TabIndex = 3;
            IDningKirishdaTextBoxi.TextChanged += IDningKirishdaTextBoxi_TextChanged;
            // 
            // TelefonRaqamKirishda
            // 
            TelefonRaqamKirishda.Location = new Point(40, 261);
            TelefonRaqamKirishda.Name = "TelefonRaqamKirishda";
            TelefonRaqamKirishda.PlaceholderText = "+998xxXXXxxXX";
            TelefonRaqamKirishda.Size = new Size(203, 23);
            TelefonRaqamKirishda.TabIndex = 4;
            // 
            // KirishTekshiruvi
            // 
            KirishTekshiruvi.Location = new Point(41, 313);
            KirishTekshiruvi.Name = "KirishTekshiruvi";
            KirishTekshiruvi.Size = new Size(140, 25);
            KirishTekshiruvi.TabIndex = 5;
            KirishTekshiruvi.Text = "Idni unutdingizmi?";
            KirishTekshiruvi.UseVisualStyleBackColor = true;
            KirishTekshiruvi.Click += KirishTekshiruvi_Click;
            // 
            // MalumotlarBerdi
            // 
            MalumotlarBerdi.Location = new Point(250, 313);
            MalumotlarBerdi.Name = "MalumotlarBerdi";
            MalumotlarBerdi.Size = new Size(113, 23);
            MalumotlarBerdi.TabIndex = 6;
            MalumotlarBerdi.Text = "tekshir";
            MalumotlarBerdi.UseVisualStyleBackColor = true;
            MalumotlarBerdi.Click += MalumotlarBerdi_Click;
            // 
            // Bolalar_bogchasi_kirish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(448, 375);
            Controls.Add(MalumotlarBerdi);
            Controls.Add(KirishTekshiruvi);
            Controls.Add(TelefonRaqamKirishda);
            Controls.Add(IDningKirishdaTextBoxi);
            Controls.Add(KiritilganTelefonRaqam);
            Controls.Add(IDkiritish);
            Controls.Add(BogchaNomi);
            MaximumSize = new Size(464, 414);
            MinimumSize = new Size(464, 414);
            Name = "Bolalar_bogchasi_kirish";
            Text = "Bog'cha ";
            Load += Bolalar_bogchasi_kirish_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BogchaNomi;
        private Label IDkiritish;
        private Label KiritilganTelefonRaqam;
        private TextBox IDningKirishdaTextBoxi;
        private TextBox TelefonRaqamKirishda;
        private Button KirishTekshiruvi;
        private Button MalumotlarBerdi;
    }
}