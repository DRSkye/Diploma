namespace CourseWork2
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВвидеИзображенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.почиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.startTime = new System.Windows.Forms.Label();
            this.finishTime = new System.Windows.Forms.Label();
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.colorBoxFinish = new System.Windows.Forms.PictureBox();
            this.colorBoxStart = new System.Windows.Forms.PictureBox();
            this.colorButtonFinish = new System.Windows.Forms.Button();
            this.colorButtonStart = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.depthGroupBox = new System.Windows.Forms.GroupBox();
            this.depthBoxFinish = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.depthBoxStart = new System.Windows.Forms.TextBox();
            this.spectrGroupBox = new System.Windows.Forms.GroupBox();
            this.frequencyBoxFinish = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frequencyBoxStart = new System.Windows.Forms.TextBox();
            this.openButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.colorGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxStart)).BeginInit();
            this.depthGroupBox.SuspendLayout();
            this.spectrGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.логиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьВвидеИзображенияToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.открытьToolStripMenuItem.Text = "Открыть папку с данными";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openButton_Click);
            // 
            // сохранитьВвидеИзображенияToolStripMenuItem
            // 
            this.сохранитьВвидеИзображенияToolStripMenuItem.Name = "сохранитьВвидеИзображенияToolStripMenuItem";
            this.сохранитьВвидеИзображенияToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.сохранитьВвидеИзображенияToolStripMenuItem.Text = "Сохранить ввиде изображения";
            this.сохранитьВвидеИзображенияToolStripMenuItem.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // логиToolStripMenuItem
            // 
            this.логиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem1,
            this.почиститьToolStripMenuItem});
            this.логиToolStripMenuItem.Name = "логиToolStripMenuItem";
            this.логиToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.логиToolStripMenuItem.Text = "Логи";
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.openLogs_Click);
            // 
            // почиститьToolStripMenuItem
            // 
            this.почиститьToolStripMenuItem.Name = "почиститьToolStripMenuItem";
            this.почиститьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.почиститьToolStripMenuItem.Text = "Почистить";
            this.почиститьToolStripMenuItem.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 611);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спектрограмма";
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(6, 19);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(719, 586);
            this.imgBox.TabIndex = 0;
            this.imgBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.colorGroupBox);
            this.groupBox2.Controls.Add(this.startButton);
            this.groupBox2.Controls.Add(this.depthGroupBox);
            this.groupBox2.Controls.Add(this.spectrGroupBox);
            this.groupBox2.Controls.Add(this.openButton);
            this.groupBox2.Location = new System.Drawing.Point(750, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 611);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar);
            this.groupBox4.Location = new System.Drawing.Point(6, 468);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 78);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Прогресс выполнения";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(6, 37);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(228, 23);
            this.progressBar.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.startTime);
            this.groupBox3.Controls.Add(this.finishTime);
            this.groupBox3.Location = new System.Drawing.Point(6, 386);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 75);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Замер времени";
            // 
            // startTime
            // 
            this.startTime.AutoSize = true;
            this.startTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startTime.Location = new System.Drawing.Point(6, 16);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(79, 20);
            this.startTime.TabIndex = 13;
            this.startTime.Text = "00:00:00";
            // 
            // finishTime
            // 
            this.finishTime.AutoSize = true;
            this.finishTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.finishTime.Location = new System.Drawing.Point(6, 49);
            this.finishTime.Name = "finishTime";
            this.finishTime.Size = new System.Drawing.Size(79, 20);
            this.finishTime.TabIndex = 12;
            this.finishTime.Text = "00:00:00";
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.colorBoxFinish);
            this.colorGroupBox.Controls.Add(this.colorBoxStart);
            this.colorGroupBox.Controls.Add(this.colorButtonFinish);
            this.colorGroupBox.Controls.Add(this.colorButtonStart);
            this.colorGroupBox.Location = new System.Drawing.Point(6, 78);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Size = new System.Drawing.Size(240, 86);
            this.colorGroupBox.TabIndex = 2;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "Параметры цвета";
            // 
            // colorBoxFinish
            // 
            this.colorBoxFinish.BackColor = System.Drawing.Color.Red;
            this.colorBoxFinish.Location = new System.Drawing.Point(134, 48);
            this.colorBoxFinish.Name = "colorBoxFinish";
            this.colorBoxFinish.Size = new System.Drawing.Size(100, 23);
            this.colorBoxFinish.TabIndex = 3;
            this.colorBoxFinish.TabStop = false;
            // 
            // colorBoxStart
            // 
            this.colorBoxStart.BackColor = System.Drawing.Color.Snow;
            this.colorBoxStart.Location = new System.Drawing.Point(6, 48);
            this.colorBoxStart.Name = "colorBoxStart";
            this.colorBoxStart.Size = new System.Drawing.Size(100, 23);
            this.colorBoxStart.TabIndex = 2;
            this.colorBoxStart.TabStop = false;
            // 
            // colorButtonFinish
            // 
            this.colorButtonFinish.Location = new System.Drawing.Point(134, 19);
            this.colorButtonFinish.Name = "colorButtonFinish";
            this.colorButtonFinish.Size = new System.Drawing.Size(100, 23);
            this.colorButtonFinish.TabIndex = 1;
            this.colorButtonFinish.Text = "Цвет конца";
            this.colorButtonFinish.UseVisualStyleBackColor = true;
            this.colorButtonFinish.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorButtonStart
            // 
            this.colorButtonStart.Location = new System.Drawing.Point(6, 19);
            this.colorButtonStart.Name = "colorButtonStart";
            this.colorButtonStart.Size = new System.Drawing.Size(100, 23);
            this.colorButtonStart.TabIndex = 0;
            this.colorButtonStart.Text = "Цвет начала";
            this.colorButtonStart.UseVisualStyleBackColor = true;
            this.colorButtonStart.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.Location = new System.Drawing.Point(6, 552);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(246, 53);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Вычислить";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // depthGroupBox
            // 
            this.depthGroupBox.Controls.Add(this.depthBoxFinish);
            this.depthGroupBox.Controls.Add(this.label3);
            this.depthGroupBox.Controls.Add(this.label4);
            this.depthGroupBox.Controls.Add(this.depthBoxStart);
            this.depthGroupBox.Location = new System.Drawing.Point(6, 279);
            this.depthGroupBox.Name = "depthGroupBox";
            this.depthGroupBox.Size = new System.Drawing.Size(240, 101);
            this.depthGroupBox.TabIndex = 9;
            this.depthGroupBox.TabStop = false;
            this.depthGroupBox.Text = "Диапозон глубины (метры)";
            // 
            // depthBoxFinish
            // 
            this.depthBoxFinish.Location = new System.Drawing.Point(136, 68);
            this.depthBoxFinish.Name = "depthBoxFinish";
            this.depthBoxFinish.Size = new System.Drawing.Size(100, 20);
            this.depthBoxFinish.TabIndex = 7;
            this.depthBoxFinish.TextChanged += new System.EventHandler(this.depth_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Конечная:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(8, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Начальная:";
            // 
            // depthBoxStart
            // 
            this.depthBoxStart.Location = new System.Drawing.Point(136, 27);
            this.depthBoxStart.Name = "depthBoxStart";
            this.depthBoxStart.Size = new System.Drawing.Size(100, 20);
            this.depthBoxStart.TabIndex = 4;
            this.depthBoxStart.Text = "1";
            this.depthBoxStart.TextChanged += new System.EventHandler(this.depth_TextChanged);
            // 
            // spectrGroupBox
            // 
            this.spectrGroupBox.Controls.Add(this.frequencyBoxFinish);
            this.spectrGroupBox.Controls.Add(this.label2);
            this.spectrGroupBox.Controls.Add(this.label1);
            this.spectrGroupBox.Controls.Add(this.frequencyBoxStart);
            this.spectrGroupBox.Location = new System.Drawing.Point(6, 170);
            this.spectrGroupBox.Name = "spectrGroupBox";
            this.spectrGroupBox.Size = new System.Drawing.Size(240, 103);
            this.spectrGroupBox.TabIndex = 8;
            this.spectrGroupBox.TabStop = false;
            this.spectrGroupBox.Text = "Диапозон частот (Гц)";
            // 
            // frequencyBoxFinish
            // 
            this.frequencyBoxFinish.Location = new System.Drawing.Point(134, 66);
            this.frequencyBoxFinish.Name = "frequencyBoxFinish";
            this.frequencyBoxFinish.Size = new System.Drawing.Size(100, 20);
            this.frequencyBoxFinish.TabIndex = 3;
            this.frequencyBoxFinish.Text = "10000";
            this.frequencyBoxFinish.TextChanged += new System.EventHandler(this.frequency_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Конечная:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Начальная:";
            // 
            // frequencyBoxStart
            // 
            this.frequencyBoxStart.Location = new System.Drawing.Point(134, 25);
            this.frequencyBoxStart.Name = "frequencyBoxStart";
            this.frequencyBoxStart.Size = new System.Drawing.Size(100, 20);
            this.frequencyBoxStart.TabIndex = 0;
            this.frequencyBoxStart.Text = "0";
            this.frequencyBoxStart.TextChanged += new System.EventHandler(this.frequency_TextChanged);
            // 
            // openButton
            // 
            this.openButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openButton.Location = new System.Drawing.Point(6, 19);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(240, 53);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Открыть папку с данными";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 651);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Курсовая";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.colorGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorBoxStart)).EndInit();
            this.depthGroupBox.ResumeLayout(false);
            this.depthGroupBox.PerformLayout();
            this.spectrGroupBox.ResumeLayout(false);
            this.spectrGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.PictureBox colorBoxFinish;
        private System.Windows.Forms.PictureBox colorBoxStart;
        private System.Windows.Forms.Button colorButtonFinish;
        private System.Windows.Forms.Button colorButtonStart;
        private System.Windows.Forms.GroupBox depthGroupBox;
        private System.Windows.Forms.TextBox depthBoxFinish;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox depthBoxStart;
        private System.Windows.Forms.GroupBox spectrGroupBox;
        private System.Windows.Forms.TextBox frequencyBoxFinish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox frequencyBoxStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label startTime;
        private System.Windows.Forms.Label finishTime;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВвидеИзображенияToolStripMenuItem;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.ToolStripMenuItem логиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem почиститьToolStripMenuItem;
    }
}