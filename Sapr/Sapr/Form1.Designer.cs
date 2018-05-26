namespace Sapr
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.решениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.балка2ОпорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.калькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.информацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.цельПрограммыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.инструкцияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.обАвторахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.решениеToolStripMenuItem,
            this.информацияToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(490, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// решениеToolStripMenuItem
			// 
			this.решениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.балка2ОпорыToolStripMenuItem,
            this.калькуляторToolStripMenuItem});
			this.решениеToolStripMenuItem.Name = "решениеToolStripMenuItem";
			this.решениеToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
			this.решениеToolStripMenuItem.Text = "Решение";
			// 
			// балка2ОпорыToolStripMenuItem
			// 
			this.балка2ОпорыToolStripMenuItem.Name = "балка2ОпорыToolStripMenuItem";
			this.балка2ОпорыToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.балка2ОпорыToolStripMenuItem.Text = "Балка (2 опоры)";
			this.балка2ОпорыToolStripMenuItem.Click += new System.EventHandler(this.балка2ОпорыToolStripMenuItem_Click);
			// 
			// калькуляторToolStripMenuItem
			// 
			this.калькуляторToolStripMenuItem.Name = "калькуляторToolStripMenuItem";
			this.калькуляторToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.калькуляторToolStripMenuItem.Text = "Калькулятор";
			this.калькуляторToolStripMenuItem.Click += new System.EventHandler(this.калькуляторToolStripMenuItem_Click);
			// 
			// информацияToolStripMenuItem
			// 
			this.информацияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цельПрограммыToolStripMenuItem,
            this.инструкцияToolStripMenuItem,
            this.обАвторахToolStripMenuItem});
			this.информацияToolStripMenuItem.Name = "информацияToolStripMenuItem";
			this.информацияToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
			this.информацияToolStripMenuItem.Text = "Информация";
			// 
			// цельПрограммыToolStripMenuItem
			// 
			this.цельПрограммыToolStripMenuItem.Name = "цельПрограммыToolStripMenuItem";
			this.цельПрограммыToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.цельПрограммыToolStripMenuItem.Text = "Цель программы";
			this.цельПрограммыToolStripMenuItem.Click += new System.EventHandler(this.цельПрограммыToolStripMenuItem_Click);
			// 
			// инструкцияToolStripMenuItem
			// 
			this.инструкцияToolStripMenuItem.Name = "инструкцияToolStripMenuItem";
			this.инструкцияToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.инструкцияToolStripMenuItem.Text = "Инструкция";
			this.инструкцияToolStripMenuItem.Click += new System.EventHandler(this.инструкцияToolStripMenuItem_Click);
			// 
			// обАвторахToolStripMenuItem
			// 
			this.обАвторахToolStripMenuItem.Name = "обАвторахToolStripMenuItem";
			this.обАвторахToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
			this.обАвторахToolStripMenuItem.Text = "Об авторах";
			this.обАвторахToolStripMenuItem.Click += new System.EventHandler(this.обАвторахToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Sapr.Properties.Resources._715842e401125b9;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(490, 313);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "SupportBeam";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem решениеToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem балка2ОпорыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem информацияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem цельПрограммыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem инструкцияToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem обАвторахToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem;
	}
}

