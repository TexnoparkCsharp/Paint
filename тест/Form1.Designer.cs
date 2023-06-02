namespace тест
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.fill = new System.Windows.Forms.Button();
            this.colour = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 36);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.clear);
            this.panel2.Controls.Add(this.save);
            this.panel2.Controls.Add(this.pic_color);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.line);
            this.panel2.Controls.Add(this.rectangle);
            this.panel2.Controls.Add(this.circle);
            this.panel2.Controls.Add(this.eraser);
            this.panel2.Controls.Add(this.pencil);
            this.panel2.Controls.Add(this.fill);
            this.panel2.Controls.Add(this.colour);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 73);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(713, 27);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Purple;
            this.clear.Location = new System.Drawing.Point(810, 39);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(157, 21);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Fuchsia;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Engravers MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.ForeColor = System.Drawing.Color.Purple;
            this.save.Location = new System.Drawing.Point(810, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(157, 21);
            this.save.TabIndex = 7;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pic_color.ForeColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(247, 16);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(33, 39);
            this.pic_color.TabIndex = 3;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.Color.DimGray;
            this.line.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("line.BackgroundImage")));
            this.line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line.ForeColor = System.Drawing.Color.DimGray;
            this.line.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.line.Location = new System.Drawing.Point(654, 8);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(53, 55);
            this.line.TabIndex = 6;
            this.line.UseVisualStyleBackColor = false;
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.DimGray;
            this.rectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rectangle.BackgroundImage")));
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.ForeColor = System.Drawing.Color.DimGray;
            this.rectangle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangle.Location = new System.Drawing.Point(595, 8);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(53, 55);
            this.rectangle.TabIndex = 5;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.DimGray;
            this.circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle.BackgroundImage")));
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.ForeColor = System.Drawing.Color.DimGray;
            this.circle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circle.Location = new System.Drawing.Point(536, 8);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(53, 55);
            this.circle.TabIndex = 4;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.DimGray;
            this.eraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraser.BackgroundImage")));
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser.ForeColor = System.Drawing.Color.DimGray;
            this.eraser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraser.Location = new System.Drawing.Point(477, 8);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(53, 55);
            this.eraser.TabIndex = 3;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.DimGray;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.ForeColor = System.Drawing.Color.DimGray;
            this.pencil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencil.Location = new System.Drawing.Point(418, 8);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(53, 55);
            this.pencil.TabIndex = 2;
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // fill
            // 
            this.fill.BackColor = System.Drawing.Color.DimGray;
            this.fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fill.BackgroundImage")));
            this.fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill.ForeColor = System.Drawing.Color.DimGray;
            this.fill.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fill.Location = new System.Drawing.Point(359, 8);
            this.fill.Name = "fill";
            this.fill.Size = new System.Drawing.Size(53, 55);
            this.fill.TabIndex = 1;
            this.fill.UseVisualStyleBackColor = false;
            this.fill.Click += new System.EventHandler(this.fill_Click);
            // 
            // colour
            // 
            this.colour.BackColor = System.Drawing.Color.DimGray;
            this.colour.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("colour.BackgroundImage")));
            this.colour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.colour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.colour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colour.ForeColor = System.Drawing.Color.DimGray;
            this.colour.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.colour.Location = new System.Drawing.Point(300, 8);
            this.colour.Name = "colour";
            this.colour.Size = new System.Drawing.Size(53, 55);
            this.colour.TabIndex = 0;
            this.colour.UseVisualStyleBackColor = false;
            this.colour.Click += new System.EventHandler(this.colour_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 73);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(984, 351);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 460);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button line;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button fill;
        private System.Windows.Forms.Button colour;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

