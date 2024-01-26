namespace BolalarBogchasi.Formlar.Idni_Unutdingizmi
{
    partial class Idni_unutdingizmi
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
            IdOlishUchunRaqamKiritish = new Label();
            RaqamniJonatish = new Button();
            RaqamniKiritishIdOLishgaTextBox = new TextBox();
            HarakatOrtga = new Button();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // IdOlishUchunRaqamKiritish
            // 
            IdOlishUchunRaqamKiritish.AutoSize = true;
            IdOlishUchunRaqamKiritish.Location = new Point(32, 104);
            IdOlishUchunRaqamKiritish.Name = "IdOlishUchunRaqamKiritish";
            IdOlishUchunRaqamKiritish.Size = new Size(235, 15);
            IdOlishUchunRaqamKiritish.TabIndex = 0;
            IdOlishUchunRaqamKiritish.Text = "Idingizni bilish uchun raqamingizni kiriting:";
            // 
            // RaqamniJonatish
            // 
            RaqamniJonatish.Location = new Point(79, 190);
            RaqamniJonatish.Name = "RaqamniJonatish";
            RaqamniJonatish.Size = new Size(141, 23);
            RaqamniJonatish.TabIndex = 1;
            RaqamniJonatish.Text = "Raqamni jo'natish";
            RaqamniJonatish.UseVisualStyleBackColor = true;
            RaqamniJonatish.Click += RaqamniJonatish_Click;
            // 
            // RaqamniKiritishIdOLishgaTextBox
            // 
            RaqamniKiritishIdOLishgaTextBox.Location = new Point(32, 146);
            RaqamniKiritishIdOLishgaTextBox.Name = "RaqamniKiritishIdOLishgaTextBox";
            RaqamniKiritishIdOLishgaTextBox.Size = new Size(233, 23);
            RaqamniKiritishIdOLishgaTextBox.TabIndex = 2;
            // 
            // HarakatOrtga
            // 
            HarakatOrtga.Location = new Point(12, 5);
            HarakatOrtga.Name = "HarakatOrtga";
            HarakatOrtga.Size = new Size(47, 23);
            HarakatOrtga.TabIndex = 3;
            HarakatOrtga.Text = "<-";
            HarakatOrtga.UseVisualStyleBackColor = true;
            HarakatOrtga.Click += HarakatOrtga_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(32, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 4;
            // 
            // Idni_unutdingizmi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(306, 279);
            Controls.Add(comboBox1);
            Controls.Add(HarakatOrtga);
            Controls.Add(RaqamniKiritishIdOLishgaTextBox);
            Controls.Add(RaqamniJonatish);
            Controls.Add(IdOlishUchunRaqamKiritish);
            Name = "Idni_unutdingizmi";
            Text = "Idni_unutdingizmi";
            Load += Idni_unutdingizmi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IdOlishUchunRaqamKiritish;
        private Button RaqamniJonatish;
        private TextBox RaqamniKiritishIdOLishgaTextBox;
        private Button HarakatOrtga;
        private ComboBox comboBox1;
    }
}