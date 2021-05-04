
namespace VisualComputing2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.accelerationBar = new System.Windows.Forms.TrackBar();
            this.numbSphere = new System.Windows.Forms.Label();
            this.sizeSphere = new System.Windows.Forms.Label();
            this.startPosition = new System.Windows.Forms.Label();
            this.startPoint = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.setWind = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.xAcis = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.Label();
            this.big = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addSphere = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.Label();
            this.startSimulation = new System.Windows.Forms.Button();
            this.wind = new System.Windows.Forms.Label();
            this.sphere1 = new System.Windows.Forms.Label();
            this.sphere2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accelerationBar)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // accelerationBar
            // 
            this.accelerationBar.Location = new System.Drawing.Point(199, 442);
            this.accelerationBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accelerationBar.Maximum = 5;
            this.accelerationBar.Minimum = -5;
            this.accelerationBar.Name = "accelerationBar";
            this.accelerationBar.Size = new System.Drawing.Size(139, 56);
            this.accelerationBar.TabIndex = 0;
            this.accelerationBar.Scroll += new System.EventHandler(this.accelerationBar_Scroll);
            // 
            // numbSphere
            // 
            this.numbSphere.AutoSize = true;
            this.numbSphere.Location = new System.Drawing.Point(196, 54);
            this.numbSphere.Name = "numbSphere";
            this.numbSphere.Size = new System.Drawing.Size(116, 17);
            this.numbSphere.TabIndex = 1;
            this.numbSphere.Text = "Anzahl der Kugel";
            // 
            // sizeSphere
            // 
            this.sizeSphere.AutoSize = true;
            this.sizeSphere.Location = new System.Drawing.Point(211, 421);
            this.sizeSphere.Name = "sizeSphere";
            this.sizeSphere.Size = new System.Drawing.Size(114, 17);
            this.sizeSphere.TabIndex = 2;
            this.sizeSphere.Text = "Größe der Kugel";
            // 
            // startPosition
            // 
            this.startPosition.AutoSize = true;
            this.startPosition.Location = new System.Drawing.Point(196, 104);
            this.startPosition.Name = "startPosition";
            this.startPosition.Size = new System.Drawing.Size(87, 17);
            this.startPosition.TabIndex = 3;
            this.startPosition.Text = "Startposition";
            this.startPosition.Click += new System.EventHandler(this.startPosition_Click);
            // 
            // startPoint
            // 
            this.startPoint.AutoSize = true;
            this.startPoint.Location = new System.Drawing.Point(196, 300);
            this.startPoint.Name = "startPoint";
            this.startPoint.Size = new System.Drawing.Size(73, 17);
            this.startPoint.TabIndex = 4;
            this.startPoint.Text = "Startpunkt";
            this.startPoint.Click += new System.EventHandler(this.label2_Click);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Location = new System.Drawing.Point(406, 300);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(223, 17);
            this.angle.TabIndex = 5;
            this.angle.Text = "(Grad) Winkel der schiefen Ebene";
            this.angle.Click += new System.EventHandler(this.angle_Click);
            // 
            // setWind
            // 
            this.setWind.AutoSize = true;
            this.setWind.Location = new System.Drawing.Point(337, 341);
            this.setWind.Name = "setWind";
            this.setWind.Size = new System.Drawing.Size(18, 17);
            this.setWind.TabIndex = 6;
            this.setWind.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(409, 618);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(337, 297);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(337, 99);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(427, 99);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // xAcis
            // 
            this.xAcis.AutoSize = true;
            this.xAcis.Location = new System.Drawing.Point(314, 99);
            this.xAcis.Name = "xAcis";
            this.xAcis.Size = new System.Drawing.Size(17, 17);
            this.xAcis.TabIndex = 12;
            this.xAcis.Text = "X";
            this.xAcis.Click += new System.EventHandler(this.label1_Click);
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Location = new System.Drawing.Point(406, 99);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(12, 12);
            this.yAxis.TabIndex = 13;
            this.yAxis.Text = "Y";
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // big
            // 
            this.big.AutoSize = true;
            this.big.Location = new System.Drawing.Point(345, 442);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(38, 17);
            this.big.TabIndex = 14;
            this.big.Text = "groß";
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(337, 54);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 22);
            this.textBox5.TabIndex = 15;
            // 
            // addSphere
            // 
            this.addSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSphere.Location = new System.Drawing.Point(27, 51);
            this.addSphere.Name = "addSphere";
            this.addSphere.Size = new System.Drawing.Size(133, 23);
            this.addSphere.TabIndex = 16;
            this.addSphere.Text = "Neue Kugel";
            this.addSphere.UseVisualStyleBackColor = true;
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Location = new System.Drawing.Point(155, 442);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(37, 17);
            this.small.TabIndex = 17;
            this.small.Text = "klein";
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // startSimulation
            // 
            this.startSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulation.Location = new System.Drawing.Point(833, 477);
            this.startSimulation.Name = "startSimulation";
            this.startSimulation.Size = new System.Drawing.Size(199, 50);
            this.startSimulation.TabIndex = 18;
            this.startSimulation.Text = "Simulation ansehen";
            this.startSimulation.UseVisualStyleBackColor = true;
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.Location = new System.Drawing.Point(196, 341);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(40, 17);
            this.wind.TabIndex = 19;
            this.wind.Text = "Wind";
            // 
            // sphere1
            // 
            this.sphere1.AutoSize = true;
            this.sphere1.Location = new System.Drawing.Point(69, 109);
            this.sphere1.Name = "sphere1";
            this.sphere1.Size = new System.Drawing.Size(60, 17);
            this.sphere1.TabIndex = 20;
            this.sphere1.Text = "Kugel01";
            this.sphere1.Click += new System.EventHandler(this.sphere1_Click);
            // 
            // sphere2
            // 
            this.sphere2.AutoSize = true;
            this.sphere2.Location = new System.Drawing.Point(69, 160);
            this.sphere2.Name = "sphere2";
            this.sphere2.Size = new System.Drawing.Size(60, 17);
            this.sphere2.TabIndex = 21;
            this.sphere2.Text = "Kugel02";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Y";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "X";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(429, 155);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 22);
            this.textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(337, 154);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 22);
            this.textBox7.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Startposition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sphere2);
            this.Controls.Add(this.sphere1);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.startSimulation);
            this.Controls.Add(this.small);
            this.Controls.Add(this.addSphere);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.big);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.xAcis);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.setWind);
            this.Controls.Add(this.angle);
            this.Controls.Add(this.startPoint);
            this.Controls.Add(this.startPosition);
            this.Controls.Add(this.sizeSphere);
            this.Controls.Add(this.numbSphere);
            this.Controls.Add(this.accelerationBar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accelerationBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar accelerationBar;
        private System.Windows.Forms.Label numbSphere;
        private System.Windows.Forms.Label sizeSphere;
        private System.Windows.Forms.Label startPosition;
        private System.Windows.Forms.Label startPoint;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.CheckBox setWind;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label xAcis;
        private System.Windows.Forms.Label yAxis;
        private System.Windows.Forms.Label big;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button addSphere;
        private System.Windows.Forms.Label small;
        private System.Windows.Forms.Button startSimulation;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.Label sphere1;
        private System.Windows.Forms.Label sphere2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label3;
    }
}

