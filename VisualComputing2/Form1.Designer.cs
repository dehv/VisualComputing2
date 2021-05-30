
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
            this.objectName = new System.Windows.Forms.Label();
            this.startPosition = new System.Windows.Forms.Label();
            this.startVelocity = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.startPosX = new System.Windows.Forms.TextBox();
            this.startPosY = new System.Windows.Forms.TextBox();
            this.xAcis = new System.Windows.Forms.Label();
            this.yAxis = new System.Windows.Forms.Label();
            this.textboxObjectName = new System.Windows.Forms.TextBox();
            this.addObject = new System.Windows.Forms.Button();
            this.btnStartSimulation = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sphereName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sphereColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlsGroup = new System.Windows.Forms.GroupBox();
            this.selectObject = new System.Windows.Forms.Label();
            this.massBox = new System.Windows.Forms.TextBox();
            this.impacts = new System.Windows.Forms.GroupBox();
            this.checkboxFriction = new System.Windows.Forms.CheckBox();
            this.checkboxWind = new System.Windows.Forms.CheckBox();
            this.checkboxGravitation = new System.Windows.Forms.CheckBox();
            this.weight = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.startVelX = new System.Windows.Forms.TextBox();
            this.startVelY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxColorObject = new System.Windows.Forms.TextBox();
            this.colorObject = new System.Windows.Forms.Label();
            this.DropDownList = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlsGroup.SuspendLayout();
            this.impacts.SuspendLayout();
            this.DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // objectName
            // 
            this.objectName.AutoSize = true;
            this.objectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectName.Location = new System.Drawing.Point(46, 159);
            this.objectName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.objectName.Name = "objectName";
            this.objectName.Size = new System.Drawing.Size(139, 18);
            this.objectName.TabIndex = 1;
            this.objectName.Text = "Name des Objektes";
            // 
            // startPosition
            // 
            this.startPosition.AutoSize = true;
            this.startPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPosition.Location = new System.Drawing.Point(53, 330);
            this.startPosition.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startPosition.Name = "startPosition";
            this.startPosition.Size = new System.Drawing.Size(91, 18);
            this.startPosition.TabIndex = 3;
            this.startPosition.Text = "Startposition";
            this.startPosition.Click += new System.EventHandler(this.startPosition_Click);
            // 
            // startVelocity
            // 
            this.startVelocity.AutoSize = true;
            this.startVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startVelocity.Location = new System.Drawing.Point(53, 412);
            this.startVelocity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.startVelocity.Name = "startVelocity";
            this.startVelocity.Size = new System.Drawing.Size(143, 18);
            this.startVelocity.TabIndex = 4;
            this.startVelocity.Text = "Startgeschwindigkeit";
            this.startVelocity.Click += new System.EventHandler(this.label2_Click);
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(168, 514);
            this.radiusBox.Margin = new System.Windows.Forms.Padding(5);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(265, 22);
            this.radiusBox.TabIndex = 9;
            // 
            // startPosX
            // 
            this.startPosX.Location = new System.Drawing.Point(145, 370);
            this.startPosX.Margin = new System.Windows.Forms.Padding(5);
            this.startPosX.Name = "startPosX";
            this.startPosX.Size = new System.Drawing.Size(93, 22);
            this.startPosX.TabIndex = 10;
            // 
            // startPosY
            // 
            this.startPosY.Location = new System.Drawing.Point(336, 370);
            this.startPosY.Margin = new System.Windows.Forms.Padding(5);
            this.startPosY.Name = "startPosY";
            this.startPosY.Size = new System.Drawing.Size(97, 22);
            this.startPosY.TabIndex = 11;
            this.startPosY.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // xAcis
            // 
            this.xAcis.AutoSize = true;
            this.xAcis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAcis.Location = new System.Drawing.Point(97, 366);
            this.xAcis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.xAcis.Name = "xAcis";
            this.xAcis.Size = new System.Drawing.Size(18, 18);
            this.xAcis.TabIndex = 12;
            this.xAcis.Text = "X";
            this.xAcis.Click += new System.EventHandler(this.label1_Click);
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis.Location = new System.Drawing.Point(292, 367);
            this.yAxis.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(17, 18);
            this.yAxis.TabIndex = 13;
            this.yAxis.Text = "Y";
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // textboxObjectName
            // 
            this.textboxObjectName.Location = new System.Drawing.Point(60, 183);
            this.textboxObjectName.Margin = new System.Windows.Forms.Padding(5);
            this.textboxObjectName.Name = "textboxObjectName";
            this.textboxObjectName.Size = new System.Drawing.Size(425, 22);
            this.textboxObjectName.TabIndex = 15;
            // 
            // addObject
            // 
            this.addObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObject.Location = new System.Drawing.Point(133, 895);
            this.addObject.Margin = new System.Windows.Forms.Padding(5);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(353, 70);
            this.addObject.TabIndex = 16;
            this.addObject.Text = "Objekt erstellen";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(2144, 870);
            this.btnStartSimulation.Margin = new System.Windows.Forms.Padding(5);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(200, 36);
            this.btnStartSimulation.TabIndex = 18;
            this.btnStartSimulation.Text = "Abspielen";
            this.btnStartSimulation.UseVisualStyleBackColor = true;
            this.btnStartSimulation.Click += new System.EventHandler(this.btnStartSimulation_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 39);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1568, 295);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // controlsGroup
            // 
            this.controlsGroup.Controls.Add(this.selectObject);
            this.controlsGroup.Controls.Add(this.massBox);
            this.controlsGroup.Controls.Add(this.impacts);
            this.controlsGroup.Controls.Add(this.weight);
            this.controlsGroup.Controls.Add(this.radius);
            this.controlsGroup.Controls.Add(this.label1);
            this.controlsGroup.Controls.Add(this.startVelX);
            this.controlsGroup.Controls.Add(this.startVelY);
            this.controlsGroup.Controls.Add(this.label2);
            this.controlsGroup.Controls.Add(this.textboxColorObject);
            this.controlsGroup.Controls.Add(this.colorObject);
            this.controlsGroup.Controls.Add(this.DropDownList);
            this.controlsGroup.Controls.Add(this.addObject);
            this.controlsGroup.Controls.Add(this.xAcis);
            this.controlsGroup.Controls.Add(this.objectName);
            this.controlsGroup.Controls.Add(this.startPosition);
            this.controlsGroup.Controls.Add(this.startVelocity);
            this.controlsGroup.Controls.Add(this.radiusBox);
            this.controlsGroup.Controls.Add(this.startPosX);
            this.controlsGroup.Controls.Add(this.startPosY);
            this.controlsGroup.Controls.Add(this.yAxis);
            this.controlsGroup.Controls.Add(this.textboxObjectName);
            this.controlsGroup.Location = new System.Drawing.Point(17, 37);
            this.controlsGroup.Margin = new System.Windows.Forms.Padding(5);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Padding = new System.Windows.Forms.Padding(5);
            this.controlsGroup.Size = new System.Drawing.Size(552, 1178);
            this.controlsGroup.TabIndex = 43;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Objekte und Parameter";
            // 
            // selectObject
            // 
            this.selectObject.AutoSize = true;
            this.selectObject.Location = new System.Drawing.Point(42, 47);
            this.selectObject.Name = "selectObject";
            this.selectObject.Size = new System.Drawing.Size(143, 17);
            this.selectObject.TabIndex = 28;
            this.selectObject.Text = "Wähle ein Objekt aus";
            this.selectObject.Click += new System.EventHandler(this.label3_Click);
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(168, 574);
            this.massBox.Margin = new System.Windows.Forms.Padding(5);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(265, 22);
            this.massBox.TabIndex = 27;
            this.massBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // impacts
            // 
            this.impacts.Controls.Add(this.checkboxFriction);
            this.impacts.Controls.Add(this.checkboxWind);
            this.impacts.Controls.Add(this.checkboxGravitation);
            this.impacts.Location = new System.Drawing.Point(65, 654);
            this.impacts.Margin = new System.Windows.Forms.Padding(4);
            this.impacts.Name = "impacts";
            this.impacts.Padding = new System.Windows.Forms.Padding(4);
            this.impacts.Size = new System.Drawing.Size(421, 212);
            this.impacts.TabIndex = 26;
            this.impacts.TabStop = false;
            this.impacts.Text = "Einflüsse";
            // 
            // checkboxFriction
            // 
            this.checkboxFriction.AutoSize = true;
            this.checkboxFriction.Location = new System.Drawing.Point(120, 162);
            this.checkboxFriction.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxFriction.Name = "checkboxFriction";
            this.checkboxFriction.Size = new System.Drawing.Size(83, 21);
            this.checkboxFriction.TabIndex = 6;
            this.checkboxFriction.Text = "Reibung";
            this.checkboxFriction.UseVisualStyleBackColor = true;
            // 
            // checkboxWind
            // 
            this.checkboxWind.AutoSize = true;
            this.checkboxWind.Location = new System.Drawing.Point(120, 103);
            this.checkboxWind.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxWind.Name = "checkboxWind";
            this.checkboxWind.Size = new System.Drawing.Size(62, 21);
            this.checkboxWind.TabIndex = 5;
            this.checkboxWind.Text = "Wind";
            this.checkboxWind.UseVisualStyleBackColor = true;
            // 
            // checkboxGravitation
            // 
            this.checkboxGravitation.AutoSize = true;
            this.checkboxGravitation.Location = new System.Drawing.Point(120, 46);
            this.checkboxGravitation.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxGravitation.Name = "checkboxGravitation";
            this.checkboxGravitation.Size = new System.Drawing.Size(99, 21);
            this.checkboxGravitation.TabIndex = 4;
            this.checkboxGravitation.Text = "Gravitation";
            this.checkboxGravitation.UseVisualStyleBackColor = true;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(59, 578);
            this.weight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(49, 17);
            this.weight.TabIndex = 25;
            this.weight.Text = "Masse";
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(57, 514);
            this.radius.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(52, 17);
            this.radius.TabIndex = 24;
            this.radius.Text = "Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            // 
            // startVelX
            // 
            this.startVelX.Location = new System.Drawing.Point(145, 452);
            this.startVelX.Margin = new System.Windows.Forms.Padding(5);
            this.startVelX.Name = "startVelX";
            this.startVelX.Size = new System.Drawing.Size(93, 22);
            this.startVelX.TabIndex = 20;
            // 
            // startVelY
            // 
            this.startVelY.Location = new System.Drawing.Point(336, 452);
            this.startVelY.Margin = new System.Windows.Forms.Padding(5);
            this.startVelY.Name = "startVelY";
            this.startVelY.Size = new System.Drawing.Size(97, 22);
            this.startVelY.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(292, 452);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // textboxColorObject
            // 
            this.textboxColorObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxColorObject.Location = new System.Drawing.Point(60, 257);
            this.textboxColorObject.Margin = new System.Windows.Forms.Padding(4);
            this.textboxColorObject.Name = "textboxColorObject";
            this.textboxColorObject.ReadOnly = true;
            this.textboxColorObject.Size = new System.Drawing.Size(425, 23);
            this.textboxColorObject.TabIndex = 19;
            this.textboxColorObject.Text = "klicke um Farbe auszuwählen";
            // 
            // colorObject
            // 
            this.colorObject.AutoSize = true;
            this.colorObject.Location = new System.Drawing.Point(46, 234);
            this.colorObject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorObject.Name = "colorObject";
            this.colorObject.Size = new System.Drawing.Size(132, 17);
            this.colorObject.TabIndex = 18;
            this.colorObject.Text = "Farbe des Objektes";
            this.colorObject.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // DropDownList
            // 
            this.DropDownList.BackColor = System.Drawing.SystemColors.Window;
            this.DropDownList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.entityBindingSource, "Position", true));
            this.DropDownList.DropDownHeight = 160;
            this.DropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownList.DropDownWidth = 240;
            this.DropDownList.FormattingEnabled = true;
            this.DropDownList.IntegralHeight = false;
            this.DropDownList.Items.AddRange(new object[] {
            "Kugel",
            "Rechteck",
            "Windbox"});
            this.DropDownList.Location = new System.Drawing.Point(60, 69);
            this.DropDownList.Margin = new System.Windows.Forms.Padding(4);
            this.DropDownList.Name = "DropDownList";
            this.DropDownList.Size = new System.Drawing.Size(425, 24);
            this.DropDownList.TabIndex = 17;
            this.DropDownList.SelectedIndexChanged += new System.EventHandler(this.DropDownList_SelectedIndexChanged);
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.dataGridView1);
            this.DataGridView.Location = new System.Drawing.Point(580, 932);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(5);
            this.DataGridView.Size = new System.Drawing.Size(1931, 283);
            this.DataGridView.TabIndex = 45;
            this.DataGridView.TabStop = false;
            this.DataGridView.Text = "RealTimeData";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1915, 870);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(219, 36);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(580, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1931, 811);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataSource = typeof(VisualComputing2.Entity);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2528, 1250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.btnStartSimulation);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Modellsimulation Kugelbahn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.impacts.ResumeLayout(false);
            this.impacts.PerformLayout();
            this.DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label objectName;
        private System.Windows.Forms.Label startPosition;
        private System.Windows.Forms.Label startVelocity;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.TextBox startPosX;
        private System.Windows.Forms.TextBox startPosY;
        private System.Windows.Forms.Label xAcis;
        private System.Windows.Forms.Label yAxis;
        private System.Windows.Forms.TextBox textboxObjectName;
        private System.Windows.Forms.Button addObject;
        private System.Windows.Forms.Button btnStartSimulation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox controlsGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sphereColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionX;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionY;
        private System.Windows.Forms.GroupBox DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn collision;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox DropDownList;
        private System.Windows.Forms.TextBox textboxColorObject;
        private System.Windows.Forms.Label colorObject;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox startVelX;
        private System.Windows.Forms.TextBox startVelY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.GroupBox impacts;
        private System.Windows.Forms.CheckBox checkboxFriction;
        private System.Windows.Forms.CheckBox checkboxWind;
        private System.Windows.Forms.CheckBox checkboxGravitation;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label radius;
        private System.Windows.Forms.Label selectObject;
        private System.Windows.Forms.BindingSource entityBindingSource;
    }
}

