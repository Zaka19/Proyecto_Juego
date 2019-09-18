namespace PruebaForms
{
    partial class EF_Users
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RaceHeroe = new System.Windows.Forms.ComboBox();
            this.ClassHeroe = new System.Windows.Forms.ComboBox();
            this.NameHeroe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FemaleHeroe = new System.Windows.Forms.RadioButton();
            this.MaleHeroe = new System.Windows.Forms.RadioButton();
            this.Heroe = new System.Windows.Forms.GroupBox();
            this.ImageHeroe = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.StoryHeroe = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Heroe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeroe)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RaceHeroe);
            this.groupBox1.Controls.Add(this.ClassHeroe);
            this.groupBox1.Controls.Add(this.NameHeroe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(72, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add";
            // 
            // RaceHeroe
            // 
            this.RaceHeroe.FormattingEnabled = true;
            this.RaceHeroe.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Star Guardian",
            "Demon"});
            this.RaceHeroe.Location = new System.Drawing.Point(51, 49);
            this.RaceHeroe.Name = "RaceHeroe";
            this.RaceHeroe.Size = new System.Drawing.Size(162, 21);
            this.RaceHeroe.TabIndex = 6;
            this.RaceHeroe.SelectedIndexChanged += new System.EventHandler(this.RaceHeroe_SelectedIndexChanged);
            // 
            // ClassHeroe
            // 
            this.ClassHeroe.FormattingEnabled = true;
            this.ClassHeroe.Items.AddRange(new object[] {
            "Mage",
            "Knight",
            "Dark Knight",
            "Fighter"});
            this.ClassHeroe.Location = new System.Drawing.Point(51, 78);
            this.ClassHeroe.Name = "ClassHeroe";
            this.ClassHeroe.Size = new System.Drawing.Size(162, 21);
            this.ClassHeroe.TabIndex = 5;
            // 
            // NameHeroe
            // 
            this.NameHeroe.Location = new System.Drawing.Point(51, 17);
            this.NameHeroe.MaxLength = 50;
            this.NameHeroe.Name = "NameHeroe";
            this.NameHeroe.Size = new System.Drawing.Size(162, 20);
            this.NameHeroe.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(7, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Race:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FemaleHeroe);
            this.groupBox2.Controls.Add(this.MaleHeroe);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox2.Location = new System.Drawing.Point(72, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sex:";
            // 
            // FemaleHeroe
            // 
            this.FemaleHeroe.AutoSize = true;
            this.FemaleHeroe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FemaleHeroe.Location = new System.Drawing.Point(120, 42);
            this.FemaleHeroe.Name = "FemaleHeroe";
            this.FemaleHeroe.Size = new System.Drawing.Size(59, 17);
            this.FemaleHeroe.TabIndex = 1;
            this.FemaleHeroe.TabStop = true;
            this.FemaleHeroe.Text = "Female";
            this.FemaleHeroe.UseVisualStyleBackColor = true;
            this.FemaleHeroe.CheckedChanged += new System.EventHandler(this.FemaleHeroe_CheckedChanged);
            // 
            // MaleHeroe
            // 
            this.MaleHeroe.AutoSize = true;
            this.MaleHeroe.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.MaleHeroe.Location = new System.Drawing.Point(120, 19);
            this.MaleHeroe.Name = "MaleHeroe";
            this.MaleHeroe.Size = new System.Drawing.Size(48, 17);
            this.MaleHeroe.TabIndex = 0;
            this.MaleHeroe.TabStop = true;
            this.MaleHeroe.Text = "Male";
            this.MaleHeroe.UseVisualStyleBackColor = true;
            this.MaleHeroe.CheckedChanged += new System.EventHandler(this.MaleHeroe_CheckedChanged);
            // 
            // Heroe
            // 
            this.Heroe.BackColor = System.Drawing.Color.Teal;
            this.Heroe.Controls.Add(this.ImageHeroe);
            this.Heroe.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Heroe.Location = new System.Drawing.Point(469, 27);
            this.Heroe.Name = "Heroe";
            this.Heroe.Size = new System.Drawing.Size(301, 411);
            this.Heroe.TabIndex = 2;
            this.Heroe.TabStop = false;
            this.Heroe.Text = "Heroe";
            // 
            // ImageHeroe
            // 
            this.ImageHeroe.Location = new System.Drawing.Point(33, 20);
            this.ImageHeroe.Name = "ImageHeroe";
            this.ImageHeroe.Size = new System.Drawing.Size(247, 374);
            this.ImageHeroe.TabIndex = 0;
            this.ImageHeroe.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.StoryHeroe);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox3.Location = new System.Drawing.Point(72, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "History Heroe";
            // 
            // StoryHeroe
            // 
            this.StoryHeroe.Location = new System.Drawing.Point(10, 20);
            this.StoryHeroe.Name = "StoryHeroe";
            this.StoryHeroe.Size = new System.Drawing.Size(300, 74);
            this.StoryHeroe.TabIndex = 0;
            this.StoryHeroe.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // EF_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Heroe);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EF_Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.EF_Users_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Heroe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageHeroe)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NameHeroe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ClassHeroe;
        private System.Windows.Forms.ComboBox RaceHeroe;
        private System.Windows.Forms.RadioButton MaleHeroe;
        private System.Windows.Forms.RadioButton FemaleHeroe;
        private System.Windows.Forms.GroupBox Heroe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox ImageHeroe;
        private System.Windows.Forms.RichTextBox StoryHeroe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
    }
}

