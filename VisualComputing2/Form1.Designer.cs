
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
            this.objectName = new System.Windows.Forms.Label();
            this.startPosition = new System.Windows.Forms.Label();
            this.startVelocity = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
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
            this.DataGridView = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DropDownList = new System.Windows.Forms.ComboBox();
            this.colorObject = new System.Windows.Forms.Label();
            this.textboxColorObject = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radius = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.Label();
            this.impacts = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.checkboxGravitation = new System.Windows.Forms.CheckBox();
            this.checkboxWind = new System.Windows.Forms.CheckBox();
            this.checkboxFriction = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.controlsGroup.SuspendLayout();
            this.DataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.impacts.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // objectName
            // 
            this.objectName.AutoSize = true;
            this.objectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectName.Location = new System.Drawing.Point(40, 142);
            this.objectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.objectName.Name = "objectName";
            this.objectName.Size = new System.Drawing.Size(200, 25);
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
            this.startPosition.Size = new System.Drawing.Size(132, 25);
            this.startPosition.TabIndex = 3;
            this.startPosition.Text = "Startposition";
            this.startPosition.Click += new System.EventHandler(this.startPosition_Click);
            // 
            // startVelocity
            // 
            this.startVelocity.AutoSize = true;
            this.startVelocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startVelocity.Location = new System.Drawing.Point(40, 329);
            this.startVelocity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.startVelocity.Name = "startVelocity";
            this.startVelocity.Size = new System.Drawing.Size(210, 25);
            this.startVelocity.TabIndex = 4;
            this.startVelocity.Text = "Startgeschwindigkeit";
            this.startVelocity.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 401);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(124, 29);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(305, 266);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(71, 29);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(448, 266);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(74, 29);
            this.textBox4.TabIndex = 11;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // xAcis
            // 
            this.xAcis.AutoSize = true;
            this.xAcis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xAcis.Location = new System.Drawing.Point(269, 262);
            this.xAcis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.yAxis.Location = new System.Drawing.Point(415, 262);
            this.yAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(27, 25);
            this.yAxis.TabIndex = 13;
            this.yAxis.Text = "Y";
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // textboxObjectName
            // 
            this.textboxObjectName.Location = new System.Drawing.Point(267, 140);
            this.textboxObjectName.Margin = new System.Windows.Forms.Padding(4);
            this.textboxObjectName.Name = "textboxObjectName";
            this.textboxObjectName.Size = new System.Drawing.Size(374, 29);
            this.textboxObjectName.TabIndex = 15;
            // 
            // addObject
            // 
            this.addObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObject.Location = new System.Drawing.Point(376, 816);
            this.addObject.Margin = new System.Windows.Forms.Padding(4);
            this.addObject.Name = "addObject";
            this.addObject.Size = new System.Drawing.Size(265, 57);
            this.addObject.TabIndex = 16;
            this.addObject.Text = "Objekt erstellen";
            this.addObject.UseVisualStyleBackColor = true;
            // 
            // btnStartSimulation
            // 
            this.btnStartSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartSimulation.Location = new System.Drawing.Point(2289, 1064);
            this.btnStartSimulation.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartSimulation.Name = "btnStartSimulation";
            this.btnStartSimulation.Size = new System.Drawing.Size(275, 54);
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
            this.dataGridView1.Size = new System.Drawing.Size(1334, 336);
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
            this.controlsGroup.Controls.Add(this.textBox6);
            this.controlsGroup.Controls.Add(this.impacts);
            this.controlsGroup.Controls.Add(this.weight);
            this.controlsGroup.Controls.Add(this.radius);
            this.controlsGroup.Controls.Add(this.label1);
            this.controlsGroup.Controls.Add(this.textBox1);
            this.controlsGroup.Controls.Add(this.textBox5);
            this.controlsGroup.Controls.Add(this.label2);
            this.controlsGroup.Controls.Add(this.textboxColorObject);
            this.controlsGroup.Controls.Add(this.colorObject);
            this.controlsGroup.Controls.Add(this.DropDownList);
            this.controlsGroup.Controls.Add(this.addObject);
            this.controlsGroup.Controls.Add(this.xAcis);
            this.controlsGroup.Controls.Add(this.objectName);
            this.controlsGroup.Controls.Add(this.startPosition);
            this.controlsGroup.Controls.Add(this.startVelocity);
            this.controlsGroup.Controls.Add(this.textBox2);
            this.controlsGroup.Controls.Add(this.textBox3);
            this.controlsGroup.Controls.Add(this.textBox4);
            this.controlsGroup.Controls.Add(this.yAxis);
            this.controlsGroup.Controls.Add(this.textboxObjectName);
            this.controlsGroup.Location = new System.Drawing.Point(32, 52);
            this.controlsGroup.Margin = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Name = "controlsGroup";
            this.controlsGroup.Padding = new System.Windows.Forms.Padding(4);
            this.controlsGroup.Size = new System.Drawing.Size(678, 1438);
            this.controlsGroup.TabIndex = 43;
            this.controlsGroup.TabStop = false;
            this.controlsGroup.Text = "Objekte und Parameter";
            // 
            // DataGridView
            // 
            this.DataGridView.Controls.Add(this.dataGridView1);
            this.DataGridView.Location = new System.Drawing.Point(718, 1122);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Padding = new System.Windows.Forms.Padding(4);
            this.DataGridView.Size = new System.Drawing.Size(1841, 368);
            this.DataGridView.TabIndex = 45;
            this.DataGridView.TabStop = false;
            this.DataGridView.Text = "RealTimeData";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(2006, 1064);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(275, 54);
            this.btnReset.TabIndex = 46;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(718, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1852, 983);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // DropDownList
            // 
            this.DropDownList.DropDownHeight = 160;
            this.DropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDownList.DropDownWidth = 240;
            this.DropDownList.FormattingEnabled = true;
            this.DropDownList.IntegralHeight = false;
            this.DropDownList.Location = new System.Drawing.Point(45, 66);
            this.DropDownList.Name = "DropDownList";
            this.DropDownList.Size = new System.Drawing.Size(596, 32);
            this.DropDownList.TabIndex = 17;
            // 
            // colorObject
            // 
            this.colorObject.AutoSize = true;
            this.colorObject.Location = new System.Drawing.Point(40, 204);
            this.colorObject.Name = "colorObject";
            this.colorObject.Size = new System.Drawing.Size(183, 25);
            this.colorObject.TabIndex = 18;
            this.colorObject.Text = "Farbe des Objektes";
            this.colorObject.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // textboxColorObject
            // 
            this.textboxColorObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxColorObject.Location = new System.Drawing.Point(267, 201);
            this.textboxColorObject.Name = "textboxColorObject";
            this.textboxColorObject.ReadOnly = true;
            this.textboxColorObject.Size = new System.Drawing.Size(374, 29);
            this.textboxColorObject.TabIndex = 19;
            this.textboxColorObject.Text = "klicke um Farbe auszuwählen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(305, 333);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(71, 29);
            this.textBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(448, 333);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(74, 29);
            this.textBox5.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 329);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // radius
            // 
            this.radius.AutoSize = true;
            this.radius.Location = new System.Drawing.Point(40, 398);
            this.radius.Name = "radius";
            this.radius.Size = new System.Drawing.Size(72, 25);
            this.radius.TabIndex = 24;
            this.radius.Text = "Radius";
            // 
            // weight
            // 
            this.weight.AutoSize = true;
            this.weight.Location = new System.Drawing.Point(300, 401);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(71, 25);
            this.weight.TabIndex = 25;
            this.weight.Text = "Masse";
            // 
            // impacts
            // 
            this.impacts.Controls.Add(this.checkboxFriction);
            this.impacts.Controls.Add(this.checkboxWind);
            this.impacts.Controls.Add(this.checkboxGravitation);
            this.impacts.Location = new System.Drawing.Point(45, 471);
            this.impacts.Name = "impacts";
            this.impacts.Size = new System.Drawing.Size(596, 306);
            this.impacts.TabIndex = 26;
            this.impacts.TabStop = false;
            this.impacts.Text = "Einflüsse";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(398, 398);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(124, 29);
            this.textBox6.TabIndex = 27;
            // 
            // checkboxGravitation
            // 
            this.checkboxGravitation.AutoSize = true;
            this.checkboxGravitation.Location = new System.Drawing.Point(64, 80);
            this.checkboxGravitation.Name = "checkboxGravitation";
            this.checkboxGravitation.Size = new System.Drawing.Size(131, 29);
            this.checkboxGravitation.TabIndex = 4;
            this.checkboxGravitation.Text = "Gravitation";
            this.checkboxGravitation.UseVisualStyleBackColor = true;
            // 
            // checkboxWind
            // 
            this.checkboxWind.AutoSize = true;
            this.checkboxWind.Location = new System.Drawing.Point(64, 145);
            this.checkboxWind.Name = "checkboxWind";
            this.checkboxWind.Size = new System.Drawing.Size(84, 29);
            this.checkboxWind.TabIndex = 5;
            this.checkboxWind.Text = "Wind";
            this.checkboxWind.UseVisualStyleBackColor = true;
            // 
            // checkboxFriction
            // 
            this.checkboxFriction.AutoSize = true;
            this.checkboxFriction.Location = new System.Drawing.Point(64, 214);
            this.checkboxFriction.Name = "checkboxFriction";
            this.checkboxFriction.Size = new System.Drawing.Size(110, 29);
            this.checkboxFriction.TabIndex = 6;
            this.checkboxFriction.Text = "Reibung";
            this.checkboxFriction.UseVisualStyleBackColor = true;
            // 
            // ModSimWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2607, 1524);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.controlsGroup);
            this.Controls.Add(this.btnStartSimulation);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ModSimWindow";
            this.Text = "Modellsimulation Kugelbahn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.controlsGroup.ResumeLayout(false);
            this.controlsGroup.PerformLayout();
            this.DataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.impacts.ResumeLayout(false);
            this.impacts.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label objectName;
        private System.Windows.Forms.Label startPosition;
        private System.Windows.Forms.Label startVelocity;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox impacts;
        private System.Windows.Forms.CheckBox checkboxFriction;
        private System.Windows.Forms.CheckBox checkboxWind;
        private System.Windows.Forms.CheckBox checkboxGravitation;
        private System.Windows.Forms.Label weight;
        private System.Windows.Forms.Label radius;
    }
}

