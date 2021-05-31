
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
            this.recControls = new System.Windows.Forms.GroupBox();
            this.recRotation = new System.Windows.Forms.CheckBox();
            this.rotationSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.recWidth = new System.Windows.Forms.TextBox();
            this.recHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.recAngle = new System.Windows.Forms.TextBox();
            this.recPosX = new System.Windows.Forms.TextBox();
            this.recPosY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.windControls = new System.Windows.Forms.GroupBox();
            this.windSpeed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.windboxWidth = new System.Windows.Forms.TextBox();
            this.windboxHeight = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.windPosX = new System.Windows.Forms.TextBox();
            this.windPosY = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.directionX = new System.Windows.Forms.TextBox();
            this.directionY = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.entityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlsGroup.SuspendLayout();
            this.impacts.SuspendLayout();
            this.DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.recControls.SuspendLayout();
            this.windControls.SuspendLayout();
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
            this.objectName.Location = new System.Drawing.Point(34, 106);
            this.objectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectName.Name = "objectName";
            this.objectName.Size = new System.Drawing.Size(115, 15);
            this.objectName.TabIndex = 1;
            this.objectName.Text = "Name des Objektes";
            // 
            // startPosition
            // 
            this.startPosition.AutoSize = true;
            this.startPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startPosition.Location = new System.Drawing.Point(40, 268);
            this.startPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startPosition.Name = "startPosition";
            this.startPosition.Size = new System.Drawing.Size(75, 15);
            this.startPosition.TabIndex = 3;
            this.startPosition.Text = "Startposition";
            this.startPosition.Click += new System.EventHandler(this.startPosition_Click);
            // 
            // startVelocity
            // 
            this.startVelocity.AutoSize = true;
            this.startVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startVelocity.Location = new System.Drawing.Point(40, 335);
            this.startVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startVelocity.Name = "startVelocity";
            this.startVelocity.Size = new System.Drawing.Size(120, 15);
            this.startVelocity.TabIndex = 4;
            this.startVelocity.Text = "Startgeschwindigkeit";
            this.startVelocity.Click += new System.EventHandler(this.label2_Click);
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(126, 418);
            this.radiusBox.Margin = new System.Windows.Forms.Padding(4);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(200, 20);
            this.radiusBox.TabIndex = 9;
            // 
            // startPosX
            // 
            this.startPosX.Location = new System.Drawing.Point(109, 301);
            this.startPosX.Margin = new System.Windows.Forms.Padding(4);
            this.startPosX.Name = "startPosX";
            this.startPosX.Size = new System.Drawing.Size(71, 20);
            this.startPosX.TabIndex = 10;
            // 
            // startPosY
            // 
            this.startPosY.Location = new System.Drawing.Point(252, 301);
            this.startPosY.Margin = new System.Windows.Forms.Padding(4);
            this.startPosY.Name = "startPosY";
            this.startPosY.Size = new System.Drawing.Size(74, 20);
            this.startPosY.TabIndex = 11;
            this.startPosY.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // xAcis
            // 
            this.xAcis.AutoSize = true;
            this.xAcis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAcis.Location = new System.Drawing.Point(73, 297);
            this.xAcis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xAcis.Name = "xAcis";
            this.xAcis.Size = new System.Drawing.Size(15, 15);
            this.xAcis.TabIndex = 12;
            this.xAcis.Text = "X";
            this.xAcis.Click += new System.EventHandler(this.label1_Click);
            // 
            // yAxis
            // 
            this.yAxis.AutoSize = true;
            this.yAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yAxis.Location = new System.Drawing.Point(219, 298);
            this.yAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(14, 15);
            this.yAxis.TabIndex = 13;
            this.yAxis.Text = "Y";
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // textboxObjectName
            // 
            this.textboxObjectName.Location = new System.Drawing.Point(45, 126);
            this.textboxObjectName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxObjectName.Name = "textboxObjectName";
            this.textboxObjectName.Size = new System.Drawing.Size(320, 20);
            this.textboxObjectName.TabIndex = 15;
            // 
            // addObject
            // 
            this.addObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObject.Location = new System.Drawing.Point(100, 727);
            this.addObject.Margin = new System.Windows.Forms.Padding(4);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(265, 57);
            this.addObject.TabIndex = 16;
            this.addObject.Text = "Objekt erstellen";
            this.addObject.UseVisualStyleBackColor = true;
            this.addObject.Click += new System.EventHandler(this.addObject_Click);
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(1608, 707);
            this.btnStartSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(150, 29);
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
            this.dataGridView1.Location = new System.Drawing.Point(8, 32);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1176, 240);
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
            this.controlsGroup.Location = new System.Drawing.Point(13, 30);
            this.controlsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Size = new System.Drawing.Size(414, 957);
            this.controlsGroup.TabIndex = 43;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Objekte und Parameter";
            // 
            // selectObject
            // 
            this.selectObject.AutoSize = true;
            this.selectObject.Location = new System.Drawing.Point(32, 38);
            this.selectObject.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectObject.Name = "selectObject";
            this.selectObject.Size = new System.Drawing.Size(109, 13);
            this.selectObject.TabIndex = 28;
            this.selectObject.Text = "Wähle ein Objekt aus";
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(126, 466);
            this.massBox.Margin = new System.Windows.Forms.Padding(4);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(200, 20);
            this.massBox.TabIndex = 27;
            this.massBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // impacts
            // 
            this.impacts.Controls.Add(this.checkboxFriction);
            this.impacts.Controls.Add(this.checkboxWind);
            this.impacts.Controls.Add(this.checkboxGravitation);
            this.impacts.Location = new System.Drawing.Point(49, 531);
            this.impacts.Name = "impacts";
            this.impacts.Size = new System.Drawing.Size(316, 172);
            this.impacts.TabIndex = 26;
            this.impacts.TabStop = false;
            this.impacts.Text = "Einflüsse";
            // 
            // checkboxFriction
            // 
            this.checkboxFriction.AutoSize = true;
            this.checkboxFriction.Location = new System.Drawing.Point(90, 132);
            this.checkboxFriction.Name = "checkboxFriction";
            this.checkboxFriction.Size = new System.Drawing.Size(66, 17);
            this.checkboxFriction.TabIndex = 6;
            this.checkboxFriction.Text = "Reibung";
            this.checkboxFriction.UseVisualStyleBackColor = true;
            // 
            // checkboxWind
            // 
            this.checkboxWind.AutoSize = true;
            this.checkboxWind.Location = new System.Drawing.Point(90, 84);
            this.checkboxWind.Name = "checkboxWind";
            this.checkboxWind.Size = new System.Drawing.Size(51, 17);
            this.checkboxWind.TabIndex = 5;
            this.checkboxWind.Text = "Wind";
            this.checkboxWind.UseVisualStyleBackColor = true;
            // 
            // checkboxGravitation
            // 
            this.checkboxGravitation.AutoSize = true;
            this.checkboxGravitation.Location = new System.Drawing.Point(90, 37);
            this.checkboxGravitation.Name = "checkboxGravitation";
            this.checkboxGravitation.Size = new System.Drawing.Size(77, 17);
            this.checkboxGravitation.TabIndex = 4;
            this.checkboxGravitation.Text = "Gravitation";
            this.checkboxGravitation.UseVisualStyleBackColor = true;
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(44, 470);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(38, 13);
            this.weight.TabIndex = 25;
            this.weight.Text = "Masse";
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(43, 418);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(40, 13);
            this.radius.TabIndex = 24;
            this.radius.Text = "Radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 367);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            // 
            // startVelX
            // 
            this.startVelX.Location = new System.Drawing.Point(109, 367);
            this.startVelX.Margin = new System.Windows.Forms.Padding(4);
            this.startVelX.Name = "startVelX";
            this.startVelX.Size = new System.Drawing.Size(71, 20);
            this.startVelX.TabIndex = 20;
            // 
            // startVelY
            // 
            this.startVelY.Location = new System.Drawing.Point(252, 367);
            this.startVelY.Margin = new System.Windows.Forms.Padding(4);
            this.startVelY.Name = "startVelY";
            this.startVelY.Size = new System.Drawing.Size(74, 20);
            this.startVelY.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // textboxColorObject
            // 
            this.textboxColorObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxColorObject.Location = new System.Drawing.Point(45, 191);
            this.textboxColorObject.Name = "textboxColorObject";
            this.textboxColorObject.ReadOnly = true;
            this.textboxColorObject.Size = new System.Drawing.Size(320, 20);
            this.textboxColorObject.TabIndex = 19;
            this.textboxColorObject.Text = "klicke um Farbe auszuwählen";
            // 
            // colorObject
            // 
            this.colorObject.AutoSize = true;
            this.colorObject.Location = new System.Drawing.Point(34, 172);
            this.colorObject.Name = "colorObject";
            this.colorObject.Size = new System.Drawing.Size(99, 13);
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
            this.DropDownList.Location = new System.Drawing.Point(45, 57);
            this.DropDownList.Name = "DropDownList";
            this.DropDownList.Size = new System.Drawing.Size(320, 21);
            this.DropDownList.TabIndex = 17;
            this.DropDownList.SelectedIndexChanged += new System.EventHandler(this.DropDownList_SelectedIndexChanged);
            this.DropDownList.SelectedValueChanged += new System.EventHandler(this.DropDownList_SelectedValueChanged);
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.dataGridView1);
            this.DataGridView.Location = new System.Drawing.Point(435, 757);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridView.Size = new System.Drawing.Size(1448, 230);
            this.DataGridView.TabIndex = 45;
            this.DataGridView.TabStop = false;
            this.DataGridView.Text = "RealTimeData";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1436, 707);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(164, 29);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(435, 40);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1448, 659);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // recControls
            // 
            this.recControls.Controls.Add(this.recRotation);
            this.recControls.Controls.Add(this.rotationSpeed);
            this.recControls.Controls.Add(this.label4);
            this.recControls.Controls.Add(this.label5);
            this.recControls.Controls.Add(this.label6);
            this.recControls.Controls.Add(this.recWidth);
            this.recControls.Controls.Add(this.recHeight);
            this.recControls.Controls.Add(this.label7);
            this.recControls.Controls.Add(this.label9);
            this.recControls.Controls.Add(this.label11);
            this.recControls.Controls.Add(this.label12);
            this.recControls.Controls.Add(this.recAngle);
            this.recControls.Controls.Add(this.recPosX);
            this.recControls.Controls.Add(this.recPosY);
            this.recControls.Controls.Add(this.label13);
            this.recControls.Location = new System.Drawing.Point(13, 282);
            this.recControls.Margin = new System.Windows.Forms.Padding(4);
            this.recControls.Name = "recControls";
            this.recControls.Padding = new System.Windows.Forms.Padding(4);
            this.recControls.Size = new System.Drawing.Size(414, 451);
            this.recControls.TabIndex = 49;
            this.recControls.TabStop = false;
            this.recControls.Text = "Parameter des Rechtecks";
            this.recControls.Visible = false;
            // 
            // recRotation
            // 
            this.recRotation.AutoSize = true;
            this.recRotation.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.recRotation.Location = new System.Drawing.Point(215, 192);
            this.recRotation.Name = "recRotation";
            this.recRotation.Size = new System.Drawing.Size(66, 17);
            this.recRotation.TabIndex = 32;
            this.recRotation.Text = "Rotation";
            this.recRotation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recRotation.ThreeState = true;
            this.recRotation.UseVisualStyleBackColor = true;
            // 
            // rotationSpeed
            // 
            this.rotationSpeed.Location = new System.Drawing.Point(215, 251);
            this.rotationSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.rotationSpeed.Name = "rotationSpeed";
            this.rotationSpeed.Size = new System.Drawing.Size(111, 20);
            this.rotationSpeed.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rotationsgeschwindigkeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Winkel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "Breite";
            // 
            // recWidth
            // 
            this.recWidth.Location = new System.Drawing.Point(109, 130);
            this.recWidth.Margin = new System.Windows.Forms.Padding(4);
            this.recWidth.Name = "recWidth";
            this.recWidth.Size = new System.Drawing.Size(71, 20);
            this.recWidth.TabIndex = 20;
            // 
            // recHeight
            // 
            this.recHeight.Location = new System.Drawing.Point(252, 130);
            this.recHeight.Margin = new System.Windows.Forms.Padding(4);
            this.recHeight.Name = "recHeight";
            this.recHeight.Size = new System.Drawing.Size(74, 20);
            this.recHeight.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(212, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Höhe";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 59);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 35);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Position";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(40, 105);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 15);
            this.label12.TabIndex = 4;
            this.label12.Text = "Größe des Objektes";
            // 
            // recAngle
            // 
            this.recAngle.Location = new System.Drawing.Point(109, 190);
            this.recAngle.Margin = new System.Windows.Forms.Padding(4);
            this.recAngle.Name = "recAngle";
            this.recAngle.Size = new System.Drawing.Size(74, 20);
            this.recAngle.TabIndex = 9;
            // 
            // recPosX
            // 
            this.recPosX.Location = new System.Drawing.Point(109, 58);
            this.recPosX.Margin = new System.Windows.Forms.Padding(4);
            this.recPosX.Name = "recPosX";
            this.recPosX.Size = new System.Drawing.Size(71, 20);
            this.recPosX.TabIndex = 10;
            // 
            // recPosY
            // 
            this.recPosY.Location = new System.Drawing.Point(252, 58);
            this.recPosY.Margin = new System.Windows.Forms.Padding(4);
            this.recPosY.Name = "recPosY";
            this.recPosY.Size = new System.Drawing.Size(74, 20);
            this.recPosY.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(219, 58);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 13;
            this.label13.Text = "Y";
            // 
            // windControls
            // 
            this.windControls.Controls.Add(this.label19);
            this.windControls.Controls.Add(this.directionX);
            this.windControls.Controls.Add(this.directionY);
            this.windControls.Controls.Add(this.label20);
            this.windControls.Controls.Add(this.windSpeed);
            this.windControls.Controls.Add(this.label3);
            this.windControls.Controls.Add(this.label8);
            this.windControls.Controls.Add(this.label10);
            this.windControls.Controls.Add(this.windboxWidth);
            this.windControls.Controls.Add(this.windboxHeight);
            this.windControls.Controls.Add(this.label14);
            this.windControls.Controls.Add(this.label15);
            this.windControls.Controls.Add(this.label16);
            this.windControls.Controls.Add(this.label17);
            this.windControls.Controls.Add(this.windPosX);
            this.windControls.Controls.Add(this.windPosY);
            this.windControls.Controls.Add(this.label18);
            this.windControls.Location = new System.Drawing.Point(13, 282);
            this.windControls.Margin = new System.Windows.Forms.Padding(4);
            this.windControls.Name = "windControls";
            this.windControls.Padding = new System.Windows.Forms.Padding(4);
            this.windControls.Size = new System.Drawing.Size(414, 454);
            this.windControls.TabIndex = 50;
            this.windControls.TabStop = false;
            this.windControls.Text = "Parameter der Windbox";
            this.windControls.Visible = false;
            // 
            // windSpeed
            // 
            this.windSpeed.Location = new System.Drawing.Point(132, 305);
            this.windSpeed.Margin = new System.Windows.Forms.Padding(4);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(194, 20);
            this.windSpeed.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Geschwindigkeit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Windrichtung";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 151);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 22;
            this.label10.Text = "Breite";
            // 
            // windboxWidth
            // 
            this.windboxWidth.Location = new System.Drawing.Point(109, 150);
            this.windboxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.windboxWidth.Name = "windboxWidth";
            this.windboxWidth.Size = new System.Drawing.Size(71, 20);
            this.windboxWidth.TabIndex = 20;
            // 
            // windboxHeight
            // 
            this.windboxHeight.Location = new System.Drawing.Point(252, 150);
            this.windboxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.windboxHeight.Name = "windboxHeight";
            this.windboxHeight.Size = new System.Drawing.Size(74, 20);
            this.windboxHeight.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(212, 151);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Höhe";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(85, 65);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(37, 44);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 15);
            this.label16.TabIndex = 3;
            this.label16.Text = "Position";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 123);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(113, 15);
            this.label17.TabIndex = 4;
            this.label17.Text = "Größe der Windbox";
            // 
            // windPosX
            // 
            this.windPosX.Location = new System.Drawing.Point(109, 64);
            this.windPosX.Margin = new System.Windows.Forms.Padding(4);
            this.windPosX.Name = "windPosX";
            this.windPosX.Size = new System.Drawing.Size(71, 20);
            this.windPosX.TabIndex = 10;
            // 
            // windPosY
            // 
            this.windPosY.Location = new System.Drawing.Point(252, 64);
            this.windPosY.Margin = new System.Windows.Forms.Padding(4);
            this.windPosY.Name = "windPosY";
            this.windPosY.Size = new System.Drawing.Size(74, 20);
            this.windPosY.TabIndex = 11;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(219, 64);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 15);
            this.label18.TabIndex = 13;
            this.label18.Text = "Y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(85, 236);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(15, 15);
            this.label19.TabIndex = 30;
            this.label19.Text = "X";
            // 
            // directionX
            // 
            this.directionX.Location = new System.Drawing.Point(109, 235);
            this.directionX.Margin = new System.Windows.Forms.Padding(4);
            this.directionX.Name = "directionX";
            this.directionX.Size = new System.Drawing.Size(71, 20);
            this.directionX.TabIndex = 28;
            // 
            // directionY
            // 
            this.directionY.Location = new System.Drawing.Point(252, 235);
            this.directionY.Margin = new System.Windows.Forms.Padding(4);
            this.directionY.Name = "directionY";
            this.directionY.Size = new System.Drawing.Size(74, 20);
            this.directionY.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(219, 235);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(14, 15);
            this.label20.TabIndex = 31;
            this.label20.Text = "Y";
            // 
            // entityBindingSource
            // 
            this.entityBindingSource.DataSource = typeof(VisualComputing2.Entity);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1896, 1016);
            this.Controls.Add(this.windControls);
            this.Controls.Add(this.recControls);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.btnStartSimulation);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Modellsimulation Kugelbahn";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.impacts.ResumeLayout(false);
            this.impacts.PerformLayout();
            this.DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.recControls.ResumeLayout(false);
            this.recControls.PerformLayout();
            this.windControls.ResumeLayout(false);
            this.windControls.PerformLayout();
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
        private System.Windows.Forms.GroupBox recControls;
        private System.Windows.Forms.TextBox rotationSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recWidth;
        private System.Windows.Forms.TextBox recHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox recAngle;
        private System.Windows.Forms.TextBox recPosX;
        private System.Windows.Forms.TextBox recPosY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox recRotation;
        private System.Windows.Forms.GroupBox windControls;
        private System.Windows.Forms.TextBox windSpeed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox windboxWidth;
        private System.Windows.Forms.TextBox windboxHeight;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox windPosX;
        private System.Windows.Forms.TextBox windPosY;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox directionX;
        private System.Windows.Forms.TextBox directionY;
        private System.Windows.Forms.Label label20;
    }
}

