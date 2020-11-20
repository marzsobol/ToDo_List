namespace Command
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pilne = new System.Windows.Forms.Label();
            this.niepilne = new System.Windows.Forms.Label();
            this.wazne = new System.Windows.Forms.Label();
            this.niewazne = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.b_wp = new System.Windows.Forms.Button();
            this.b_w_np = new System.Windows.Forms.Button();
            this.b_nw_p = new System.Windows.Forms.Button();
            this.b_nw_np = new System.Windows.Forms.Button();
            this.waznepilne = new System.Windows.Forms.ListBox();
            this.niewaznepilne = new System.Windows.Forms.ListBox();
            this.niepilnewazne = new System.Windows.Forms.ListBox();
            this.niepilneniewazne = new System.Windows.Forms.ListBox();
            this.b_main = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(24, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 202);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pilne
            // 
            this.pilne.AutoSize = true;
            this.pilne.BackColor = System.Drawing.Color.Transparent;
            this.pilne.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pilne.ForeColor = System.Drawing.Color.RoyalBlue;
            this.pilne.Location = new System.Drawing.Point(512, 60);
            this.pilne.Name = "pilne";
            this.pilne.Size = new System.Drawing.Size(66, 23);
            this.pilne.TabIndex = 1;
            this.pilne.Text = "PILNE";
            this.pilne.Click += new System.EventHandler(this.pilne_Click);
            // 
            // niepilne
            // 
            this.niepilne.AutoSize = true;
            this.niepilne.BackColor = System.Drawing.Color.Transparent;
            this.niepilne.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niepilne.ForeColor = System.Drawing.Color.RoyalBlue;
            this.niepilne.Location = new System.Drawing.Point(762, 60);
            this.niepilne.Name = "niepilne";
            this.niepilne.Size = new System.Drawing.Size(100, 23);
            this.niepilne.TabIndex = 2;
            this.niepilne.Text = "NIEPILNE";
            this.niepilne.Click += new System.EventHandler(this.niepilne_Click);
            // 
            // wazne
            // 
            this.wazne.AutoSize = true;
            this.wazne.BackColor = System.Drawing.Color.Transparent;
            this.wazne.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wazne.ForeColor = System.Drawing.Color.RoyalBlue;
            this.wazne.Location = new System.Drawing.Point(366, 129);
            this.wazne.Name = "wazne";
            this.wazne.Size = new System.Drawing.Size(81, 23);
            this.wazne.TabIndex = 3;
            this.wazne.Text = "WAŻNE";
            this.wazne.Click += new System.EventHandler(this.wazne_Click);
            // 
            // niewazne
            // 
            this.niewazne.AutoSize = true;
            this.niewazne.BackColor = System.Drawing.Color.Transparent;
            this.niewazne.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niewazne.ForeColor = System.Drawing.Color.RoyalBlue;
            this.niewazne.Location = new System.Drawing.Point(332, 256);
            this.niewazne.Name = "niewazne";
            this.niewazne.Size = new System.Drawing.Size(115, 23);
            this.niewazne.TabIndex = 4;
            this.niewazne.Text = "NIEWAŻNE";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Add.Location = new System.Drawing.Point(56, 333);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 50);
            this.Add.TabIndex = 9;
            this.Add.Text = "Add Task";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // b_wp
            // 
            this.b_wp.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_wp.Location = new System.Drawing.Point(214, 60);
            this.b_wp.Name = "b_wp";
            this.b_wp.Size = new System.Drawing.Size(106, 64);
            this.b_wp.TabIndex = 10;
            this.b_wp.Text = "Przenieś Ważne Pilne";
            this.b_wp.UseVisualStyleBackColor = true;
            this.b_wp.Click += new System.EventHandler(this.b_wp_Click);
            // 
            // b_w_np
            // 
            this.b_w_np.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_w_np.Location = new System.Drawing.Point(214, 145);
            this.b_w_np.Name = "b_w_np";
            this.b_w_np.Size = new System.Drawing.Size(106, 65);
            this.b_w_np.TabIndex = 11;
            this.b_w_np.Text = "Przenieś Ważne Niepilne";
            this.b_w_np.UseVisualStyleBackColor = true;
            this.b_w_np.Click += new System.EventHandler(this.b_w_np_Click);
            // 
            // b_nw_p
            // 
            this.b_nw_p.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_nw_p.Location = new System.Drawing.Point(214, 230);
            this.b_nw_p.Name = "b_nw_p";
            this.b_nw_p.Size = new System.Drawing.Size(106, 66);
            this.b_nw_p.TabIndex = 12;
            this.b_nw_p.Text = "Przenieś Nieważne Pilne";
            this.b_nw_p.UseVisualStyleBackColor = true;
            this.b_nw_p.Click += new System.EventHandler(this.b_nw_p_Click);
            // 
            // b_nw_np
            // 
            this.b_nw_np.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_nw_np.Location = new System.Drawing.Point(214, 315);
            this.b_nw_np.Name = "b_nw_np";
            this.b_nw_np.Size = new System.Drawing.Size(106, 68);
            this.b_nw_np.TabIndex = 13;
            this.b_nw_np.Text = "Przenieś Nieważne Niepilne";
            this.b_nw_np.UseVisualStyleBackColor = true;
            this.b_nw_np.Click += new System.EventHandler(this.b_nw_np_Click);
            // 
            // waznepilne
            // 
            this.waznepilne.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.waznepilne.FormattingEnabled = true;
            this.waznepilne.ItemHeight = 18;
            this.waznepilne.Location = new System.Drawing.Point(453, 95);
            this.waznepilne.Name = "waznepilne";
            this.waznepilne.Size = new System.Drawing.Size(206, 94);
            this.waznepilne.TabIndex = 14;
            this.waznepilne.SelectedIndexChanged += new System.EventHandler(this.waznepilne_SelectedIndexChanged);
            // 
            // niewaznepilne
            // 
            this.niewaznepilne.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niewaznepilne.FormattingEnabled = true;
            this.niewaznepilne.ItemHeight = 18;
            this.niewaznepilne.Location = new System.Drawing.Point(453, 232);
            this.niewaznepilne.Name = "niewaznepilne";
            this.niewaznepilne.Size = new System.Drawing.Size(206, 94);
            this.niewaznepilne.TabIndex = 15;
            this.niewaznepilne.SelectedIndexChanged += new System.EventHandler(this.niewaznepilne_SelectedIndexChanged);
            // 
            // niepilnewazne
            // 
            this.niepilnewazne.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niepilnewazne.FormattingEnabled = true;
            this.niepilnewazne.ItemHeight = 18;
            this.niepilnewazne.Location = new System.Drawing.Point(705, 95);
            this.niepilnewazne.Name = "niepilnewazne";
            this.niepilnewazne.Size = new System.Drawing.Size(206, 94);
            this.niepilnewazne.TabIndex = 16;
            this.niepilnewazne.SelectedIndexChanged += new System.EventHandler(this.niepilnewazne_SelectedIndexChanged);
            // 
            // niepilneniewazne
            // 
            this.niepilneniewazne.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.niepilneniewazne.FormattingEnabled = true;
            this.niepilneniewazne.ItemHeight = 18;
            this.niepilneniewazne.Location = new System.Drawing.Point(705, 232);
            this.niepilneniewazne.Name = "niepilneniewazne";
            this.niepilneniewazne.Size = new System.Drawing.Size(206, 94);
            this.niepilneniewazne.TabIndex = 17;
            this.niepilneniewazne.SelectedIndexChanged += new System.EventHandler(this.niepilneniewazne_SelectedIndexChanged);
            // 
            // b_main
            // 
            this.b_main.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b_main.Location = new System.Drawing.Point(614, 364);
            this.b_main.Name = "b_main";
            this.b_main.Size = new System.Drawing.Size(143, 59);
            this.b_main.TabIndex = 18;
            this.b_main.Text = "Przenieś do głównego";
            this.b_main.UseVisualStyleBackColor = true;
            this.b_main.Click += new System.EventHandler(this.b_main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(345, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "Macierz Eisenhowera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(941, 364);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(111, 58);
            this.test.TabIndex = 20;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1104, 557);
            this.Controls.Add(this.test);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_main);
            this.Controls.Add(this.niepilneniewazne);
            this.Controls.Add(this.niepilnewazne);
            this.Controls.Add(this.niewaznepilne);
            this.Controls.Add(this.waznepilne);
            this.Controls.Add(this.b_nw_np);
            this.Controls.Add(this.b_nw_p);
            this.Controls.Add(this.b_w_np);
            this.Controls.Add(this.b_wp);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.niewazne);
            this.Controls.Add(this.wazne);
            this.Controls.Add(this.niepilne);
            this.Controls.Add(this.pilne);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label pilne;
        private System.Windows.Forms.Label niepilne;
        private System.Windows.Forms.Label wazne;
        private System.Windows.Forms.Label niewazne;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button b_wp;
        private System.Windows.Forms.Button b_w_np;
        private System.Windows.Forms.Button b_nw_p;
        private System.Windows.Forms.Button b_nw_np;
        public System.Windows.Forms.ListBox waznepilne;
        public System.Windows.Forms.ListBox niewaznepilne;
        public System.Windows.Forms.ListBox niepilnewazne;
        public System.Windows.Forms.ListBox niepilneniewazne;
        private System.Windows.Forms.Button b_main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button test;
    }
}

