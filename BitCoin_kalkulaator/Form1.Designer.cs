namespace BitCoin_kalkulaator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Valivaluuta = new System.Windows.Forms.ComboBox();
            this.Arvuta = new System.Windows.Forms.Button();
            this.Bitcoinkogus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tulemustekst = new System.Windows.Forms.Label();
            this.Tulemus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Valivaluuta
            // 
            this.Valivaluuta.FormattingEnabled = true;
            this.Valivaluuta.Items.AddRange(new object[] {
            "USD",
            "GBP",
            "EEK"});
            this.Valivaluuta.Location = new System.Drawing.Point(24, 28);
            this.Valivaluuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Valivaluuta.Name = "Valivaluuta";
            this.Valivaluuta.Size = new System.Drawing.Size(457, 28);
            this.Valivaluuta.TabIndex = 0;
            this.Valivaluuta.Text = "Valivaluuta";
            this.Valivaluuta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Arvuta
            // 
            this.Arvuta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Arvuta.BackgroundImage")));
            this.Arvuta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Arvuta.Location = new System.Drawing.Point(492, 143);
            this.Arvuta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Arvuta.Name = "Arvuta";
            this.Arvuta.Size = new System.Drawing.Size(148, 151);
            this.Arvuta.TabIndex = 1;
            this.Arvuta.Text = "Arvuta BitCoini kurss";
            this.Arvuta.UseVisualStyleBackColor = true;
            this.Arvuta.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bitcoinkogus
            // 
            this.Bitcoinkogus.Location = new System.Drawing.Point(492, 28);
            this.Bitcoinkogus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bitcoinkogus.Name = "Bitcoinkogus";
            this.Bitcoinkogus.Size = new System.Drawing.Size(148, 26);
            this.Bitcoinkogus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(651, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sisesta BitCoini arv";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tulemustekst
            // 
            this.Tulemustekst.AutoSize = true;
            this.Tulemustekst.BackColor = System.Drawing.Color.Transparent;
            this.Tulemustekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Tulemustekst.ForeColor = System.Drawing.Color.Transparent;
            this.Tulemustekst.Location = new System.Drawing.Point(651, 75);
            this.Tulemustekst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Tulemustekst.Name = "Tulemustekst";
            this.Tulemustekst.Size = new System.Drawing.Size(231, 40);
            this.Tulemustekst.TabIndex = 4;
            this.Tulemustekst.Text = "Tulemustekst";
            this.Tulemustekst.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tulemus
            // 
            this.Tulemus.Location = new System.Drawing.Point(492, 82);
            this.Tulemus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tulemus.Name = "Tulemus";
            this.Tulemus.Size = new System.Drawing.Size(148, 26);
            this.Tulemus.TabIndex = 5;
            this.Tulemus.Text = "POLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(2096, 1434);
            this.Controls.Add(this.Tulemus);
            this.Controls.Add(this.Tulemustekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bitcoinkogus);
            this.Controls.Add(this.Arvuta);
            this.Controls.Add(this.Valivaluuta);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "BitCoin_kalkulaator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Valivaluuta;
        private System.Windows.Forms.Button Arvuta;
        private System.Windows.Forms.TextBox Bitcoinkogus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tulemustekst;
        private System.Windows.Forms.TextBox Tulemus;
    }
}

