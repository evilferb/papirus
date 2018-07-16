namespace Papirus
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.студентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокУчащихсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.активУчебнойГруппыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.картаПерсонифицированногоУчетаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.родителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отметкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.семестровыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.годовыеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экзаменационныеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пропускиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статистикаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.msMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.AllowMerge = false;
            this.msMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.студентыToolStripMenuItem,
            this.отметкиToolStripMenuItem,
            this.пропускиToolStripMenuItem,
            this.статистикаToolStripMenuItem});
            this.msMain.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(984, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "msMain";
            // 
            // студентыToolStripMenuItem
            // 
            this.студентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокУчащихсяToolStripMenuItem,
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem,
            this.активУчебнойГруппыToolStripMenuItem,
            this.картаПерсонифицированногоУчетаToolStripMenuItem,
            this.родителиToolStripMenuItem});
            this.студентыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("студентыToolStripMenuItem.Image")));
            this.студентыToolStripMenuItem.Name = "студентыToolStripMenuItem";
            this.студентыToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.студентыToolStripMenuItem.Text = "Студенты";
            // 
            // списокУчащихсяToolStripMenuItem
            // 
            this.списокУчащихсяToolStripMenuItem.Name = "списокУчащихсяToolStripMenuItem";
            this.списокУчащихсяToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.списокУчащихсяToolStripMenuItem.Text = "Список учащихся";
            // 
            // соцПедХарактеристикаУчебнойГруппыToolStripMenuItem
            // 
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem.Name = "соцПедХарактеристикаУчебнойГруппыToolStripMenuItem";
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem.Text = "Соц. пед. характеристика учебной группы";
            this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem.Click += new System.EventHandler(this.соцПедХарактеристикаУчебнойГруппыToolStripMenuItem_Click);
            // 
            // активУчебнойГруппыToolStripMenuItem
            // 
            this.активУчебнойГруппыToolStripMenuItem.Name = "активУчебнойГруппыToolStripMenuItem";
            this.активУчебнойГруппыToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.активУчебнойГруппыToolStripMenuItem.Text = "Актив учебной группы";
            // 
            // картаПерсонифицированногоУчетаToolStripMenuItem
            // 
            this.картаПерсонифицированногоУчетаToolStripMenuItem.Name = "картаПерсонифицированногоУчетаToolStripMenuItem";
            this.картаПерсонифицированногоУчетаToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.картаПерсонифицированногоУчетаToolStripMenuItem.Text = "Карта персонифицированного учета";
            this.картаПерсонифицированногоУчетаToolStripMenuItem.Click += new System.EventHandler(this.картаПерсонифицированногоУчетаToolStripMenuItem_Click);
            // 
            // родителиToolStripMenuItem
            // 
            this.родителиToolStripMenuItem.Name = "родителиToolStripMenuItem";
            this.родителиToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.родителиToolStripMenuItem.Text = "Родители";
            // 
            // отметкиToolStripMenuItem
            // 
            this.отметкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.семестровыеToolStripMenuItem,
            this.годовыеToolStripMenuItem,
            this.экзаменационныеToolStripMenuItem});
            this.отметкиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("отметкиToolStripMenuItem.Image")));
            this.отметкиToolStripMenuItem.Name = "отметкиToolStripMenuItem";
            this.отметкиToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.отметкиToolStripMenuItem.Text = "Отметки";
            // 
            // семестровыеToolStripMenuItem
            // 
            this.семестровыеToolStripMenuItem.Name = "семестровыеToolStripMenuItem";
            this.семестровыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.семестровыеToolStripMenuItem.Text = "Семестровые";
            // 
            // годовыеToolStripMenuItem
            // 
            this.годовыеToolStripMenuItem.Name = "годовыеToolStripMenuItem";
            this.годовыеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.годовыеToolStripMenuItem.Text = "Годовые";
            // 
            // экзаменационныеToolStripMenuItem
            // 
            this.экзаменационныеToolStripMenuItem.Name = "экзаменационныеToolStripMenuItem";
            this.экзаменационныеToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.экзаменационныеToolStripMenuItem.Text = "Экзаменационные";
            // 
            // пропускиToolStripMenuItem
            // 
            this.пропускиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("пропускиToolStripMenuItem.Image")));
            this.пропускиToolStripMenuItem.Name = "пропускиToolStripMenuItem";
            this.пропускиToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.пропускиToolStripMenuItem.Text = "Пропуски";
            // 
            // статистикаToolStripMenuItem
            // 
            this.статистикаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("статистикаToolStripMenuItem.Image")));
            this.статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            this.статистикаToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.статистикаToolStripMenuItem.Text = "Статистика";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(861, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "03-11-23ТП";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(984, 507);
            this.dataGridView1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView1.Location = new System.Drawing.Point(0, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(984, 538);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "mainform";
            this.ShowIcon = false;
            this.Text = "Папирус";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainform_FormClosed);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem студентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отметкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пропускиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статистикаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокУчащихсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem картаПерсонифицированногоУчетаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соцПедХарактеристикаУчебнойГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem активУчебнойГруппыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem родителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem семестровыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem годовыеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экзаменационныеToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListView listView1;
    }
}