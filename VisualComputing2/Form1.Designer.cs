
namespace VisualComputing2
{
    partial class ModSimWindow
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
            this.numbSphere = new System.Windows.Forms.Label();
            this.sizeSphere = new System.Windows.Forms.Label();
            this.startPosition = new System.Windows.Forms.Label();
            this.startPoint = new System.Windows.Forms.Label();
            this.angle = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.xAcis = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.Label();
            this.big = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.addSphere = new System.Windows.Forms.Button();
            this.small = new System.Windows.Forms.Label();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.windVelocity = new System.Windows.Forms.Label();
            this.windTrackbar = new System.Windows.Forms.TrackBar();
            this.windSlow = new System.Windows.Forms.Label();
            this.windFast = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.controlsGroup2 = new System.Windows.Forms.GroupBox();
            this.sphereName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphereColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridView = new System.Windows.Forms.GroupBox();
            this.positionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphereSizeTrackbar = new System.Windows.Forms.TrackBar();
            this.btnReset = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.windTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlsGroup.SuspendLayout();
            this.controlsGroup2.SuspendLayout();
            this.DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sphereSizeTrackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numbSphere
            // 
            this.numbSphere.AutoSize = true;
            this.numbSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbSphere.Location = new System.Drawing.Point(37, 54);
            this.numbSphere.Name = "numbSphere";
            this.numbSphere.Size = new System.Drawing.Size(176, 25);
            this.numbSphere.TabIndex = 1;
            this.numbSphere.Text = "Anzahl der Kugel";
            // 
            // sizeSphere
            // 
            this.sizeSphere.AutoSize = true;
            this.sizeSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeSphere.Location = new System.Drawing.Point(81, 69);
            this.sizeSphere.Name = "sizeSphere";
            this.sizeSphere.Size = new System.Drawing.Size(170, 25);
            this.sizeSphere.TabIndex = 2;
            this.sizeSphere.Text = "Größe der Kugel";
            // 
            // startPosition
            // 
            this.startPosition.AutoSize = true;
            this.startPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPosition.Location = new System.Drawing.Point(39, 106);
            this.startPosition.Name = "startPosition";
            this.startPosition.Size = new System.Drawing.Size(132, 25);
            this.startPosition.TabIndex = 3;
            this.startPosition.Text = "Startposition";
            this.startPosition.Click += new System.EventHandler(this.startPosition_Click);
            // 
            // startPoint
            // 
            this.startPoint.AutoSize = true;
            this.startPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPoint.Location = new System.Drawing.Point(43, 164);
            this.startPoint.Name = "startPoint";
            this.startPoint.Size = new System.Drawing.Size(110, 25);
            this.startPoint.TabIndex = 4;
            this.startPoint.Text = "Startpunkt";
            this.startPoint.Click += new System.EventHandler(this.label2_Click);
            // 
            // angle
            // 
            this.angle.AutoSize = true;
            this.angle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angle.Location = new System.Drawing.Point(237, 191);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(262, 20);
            this.angle.TabIndex = 5;
            this.angle.Text = "(Grad) Winkel der schiefen Ebene";
            this.angle.Click += new System.EventHandler(this.angle_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(77, 22);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 111);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 22);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(344, 111);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 22);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // xAcis
            // 
            this.xAcis.AutoSize = true;
            this.xAcis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAcis.Location = new System.Drawing.Point(214, 108);
            this.xAcis.Name = "xAcis";
            this.xAcis.Size = new System.Drawing.Size(26, 25);
            this.xAcis.TabIndex = 12;
            this.xAcis.Text = "X";
            this.xAcis.Click += new System.EventHandler(this.label1_Click);
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis.Location = new System.Drawing.Point(320, 108);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(27, 25);
            this.yAxis.TabIndex = 13;
            this.yAxis.Text = "Y";
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // big
            // 
            this.big.AutoSize = true;
            this.big.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.big.Location = new System.Drawing.Point(235, 149);
            this.big.Name = "big";
            this.big.Size = new System.Drawing.Size(52, 25);
            this.big.TabIndex = 14;
            this.big.Text = "groß";
            this.big.Click += new System.EventHandler(this.big_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(240, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(77, 22);
            this.textBox5.TabIndex = 15;
            // 
            // addSphere
            // 
            this.addSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSphere.Location = new System.Drawing.Point(267, 271);
            this.addSphere.Name = "addSphere";
            this.addSphere.Size = new System.Drawing.Size(193, 38);
            this.addSphere.TabIndex = 16;
            this.addSphere.Text = "Kugel erstellen";
            this.addSphere.UseVisualStyleBackColor = true;
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.small.Location = new System.Drawing.Point(43, 149);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(52, 25);
            this.small.TabIndex = 17;
            this.small.Text = "klein";
            this.small.Click += new System.EventHandler(this.small_Click);
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(1665, 709);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(200, 36);
            this.btnStartSimulation.TabIndex = 18;
            this.btnStartSimulation.Text = "Abspielen";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            // 
            // windVelocity
            // 
            this.windVelocity.AutoSize = true;
            this.windVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windVelocity.Location = new System.Drawing.Point(360, 69);
            this.windVelocity.Name = "windVelocity";
            this.windVelocity.Size = new System.Drawing.Size(214, 25);
            this.windVelocity.TabIndex = 19;
            this.windVelocity.Text = "Windgeschwindigkeit";
            this.windVelocity.Click += new System.EventHandler(this.wind_Click);
            // 
            // windTrackbar
            // 
            this.windTrackbar.Location = new System.Drawing.Point(389, 112);
            this.windTrackbar.Name = "windTrackbar";
            this.windTrackbar.Size = new System.Drawing.Size(160, 80);
            this.windTrackbar.TabIndex = 27;
            // 
            // windSlow
            // 
            this.windSlow.AutoSize = true;
            this.windSlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSlow.Location = new System.Drawing.Point(339, 149);
            this.windSlow.Name = "windSlow";
            this.windSlow.Size = new System.Drawing.Size(86, 25);
            this.windSlow.TabIndex = 28;
            this.windSlow.Text = "langsam";
            // 
            // windFast
            // 
            this.windFast.AutoSize = true;
            this.windFast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windFast.Location = new System.Drawing.Point(533, 149);
            this.windFast.Name = "windFast";
            this.windFast.Size = new System.Drawing.Size(73, 25);
            this.windFast.TabIndex = 29;
            this.windFast.Text = "schnell";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sphereName,
            this.sphereColor,
            this.positionX,
            this.positionY,
            this.collision});
            this.dataGridView1.Location = new System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(970, 224);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.addSphere);
            this.controlsGroup.Controls.Add(this.xAcis);
            this.controlsGroup.Controls.Add(this.numbSphere);
            this.controlsGroup.Controls.Add(this.startPosition);
            this.controlsGroup.Controls.Add(this.startPoint);
            this.controlsGroup.Controls.Add(this.angle);
            this.controlsGroup.Controls.Add(this.textBox2);
            this.controlsGroup.Controls.Add(this.textBox3);
            this.controlsGroup.Controls.Add(this.textBox4);
            this.controlsGroup.Controls.Add(this.yAxis);
            this.controlsGroup.Controls.Add(this.textBox5);
            this.controlsGroup.Location = new System.Drawing.Point(35, 35);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Size = new System.Drawing.Size(499, 707);
            this.controlsGroup.TabIndex = 43;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Parameter festlegen";
            // 
            // controlsGroup2
            // 
            this.controlsGroup2.Controls.Add(this.sphereSizeTrackbar);
            this.controlsGroup2.Controls.Add(this.windVelocity);
            this.controlsGroup2.Controls.Add(this.sizeSphere);
            this.controlsGroup2.Controls.Add(this.big);
            this.controlsGroup2.Controls.Add(this.small);
            this.controlsGroup2.Controls.Add(this.windFast);
            this.controlsGroup2.Controls.Add(this.windTrackbar);
            this.controlsGroup2.Controls.Add(this.windSlow);
            this.controlsGroup2.Location = new System.Drawing.Point(35, 748);
            this.controlsGroup2.Name = "controlsGroup2";
            this.controlsGroup2.Size = new System.Drawing.Size(831, 245);
            this.controlsGroup2.TabIndex = 44;
            this.controlsGroup2.TabStop = false;
            this.controlsGroup2.Text = "Schieberegler";
            // 
            // sphereName
            // 
            this.sphereName.Frozen = true;
            this.sphereName.HeaderText = "Kugelname";
            this.sphereName.MinimumWidth = 9;
            this.sphereName.Name = "sphereName";
            this.sphereName.Width = 175;
            // 
            // sphereColor
            // 
            this.sphereColor.HeaderText = "Kugelfarbe";
            this.sphereColor.MinimumWidth = 9;
            this.sphereColor.Name = "sphereColor";
            this.sphereColor.Width = 175;
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.dataGridView1);
            this.DataGridView.Location = new System.Drawing.Point(872, 748);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(989, 245);
            this.DataGridView.TabIndex = 45;
            this.DataGridView.TabStop = false;
            this.DataGridView.Text = "RealTimeData";
            // 
            // positionX
            // 
            this.positionX.HeaderText = "X-Wert";
            this.positionX.MinimumWidth = 9;
            this.positionX.Name = "positionX";
            this.positionX.Width = 175;
            // 
            // positionY
            // 
            this.positionY.HeaderText = "Y-Wert";
            this.positionY.MinimumWidth = 9;
            this.positionY.Name = "positionY";
            this.positionY.Width = 175;
            // 
            // collision
            // 
            this.collision.HeaderText = "Kollision";
            this.collision.MinimumWidth = 9;
            this.collision.Name = "collision";
            this.collision.Width = 175;
            // 
            // sphereSizeTrackbar
            // 
            this.sphereSizeTrackbar.Location = new System.Drawing.Point(85, 112);
            this.sphereSizeTrackbar.Name = "sphereSizeTrackbar";
            this.sphereSizeTrackbar.Size = new System.Drawing.Size(160, 80);
            this.sphereSizeTrackbar.TabIndex = 30;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1459, 709);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(200, 36);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(540, 685);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1325, 8);
            this.progressBar1.TabIndex = 47;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(540, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1325, 637);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // ModSimWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.controlsGroup2);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.btnStartSimulation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModSimWindow";
            this.Text = "Modellsimulation Kugelbahn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.windTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.controlsGroup2.ResumeLayout(false);
            this.controlsGroup2.PerformLayout();
            this.DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sphereSizeTrackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label numbSphere;
        private System.Windows.Forms.Label sizeSphere;
        private System.Windows.Forms.Label startPosition;
        private System.Windows.Forms.Label startPoint;
        private System.Windows.Forms.Label angle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label xAcis;
        private System.Windows.Forms.Label yAxis;
        private System.Windows.Forms.Label big;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button addSphere;
        private System.Windows.Forms.Label small;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.Label windVelocity;
        private System.Windows.Forms.TrackBar windTrackbar;
        private System.Windows.Forms.Label windSlow;
        private System.Windows.Forms.Label windFast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.GroupBox controlsGroup2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionY;
        private System.Windows.Forms.GroupBox DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn collision;
        private System.Windows.Forms.TrackBar sphereSizeTrackbar;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

