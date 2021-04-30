
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
            this.enableDebugDrawCheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.posXBox = new System.Windows.Forms.TextBox();
            this.posYBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.velYBox = new System.Windows.Forms.TextBox();
            this.velXBox = new System.Windows.Forms.TextBox();
            this.currentObjectLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // enableDebugDrawCheck
            // 
            this.enableDebugDrawCheck.AutoSize = true;
            this.enableDebugDrawCheck.Checked = true;
            this.enableDebugDrawCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableDebugDrawCheck.Cursor = System.Windows.Forms.Cursors.Default;
            this.enableDebugDrawCheck.Location = new System.Drawing.Point(113, 3);
            this.enableDebugDrawCheck.Name = "enableDebugDrawCheck";
            this.enableDebugDrawCheck.Size = new System.Drawing.Size(94, 17);
            this.enableDebugDrawCheck.TabIndex = 1;
            this.enableDebugDrawCheck.Text = "Enable Debug";
            this.enableDebugDrawCheck.UseVisualStyleBackColor = true;
            this.enableDebugDrawCheck.CheckedChanged += new System.EventHandler(this.EnableDebugDraw_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentObjectLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.velYBox);
            this.panel1.Controls.Add(this.velXBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.posYBox);
            this.panel1.Controls.Add(this.posXBox);
            this.panel1.Controls.Add(this.enableDebugDrawCheck);
            this.panel1.Location = new System.Drawing.Point(1160, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 533);
            this.panel1.TabIndex = 2;
            // 
            // posXBox
            // 
            this.posXBox.Location = new System.Drawing.Point(3, 87);
            this.posXBox.Name = "posXBox";
            this.posXBox.Size = new System.Drawing.Size(100, 20);
            this.posXBox.TabIndex = 2;
            // 
            // posYBox
            // 
            this.posYBox.Location = new System.Drawing.Point(114, 87);
            this.posYBox.Name = "posYBox";
            this.posYBox.Size = new System.Drawing.Size(100, 20);
            this.posYBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Position(X,Y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Velocity(X,Y)";
            // 
            // velYBox
            // 
            this.velYBox.Location = new System.Drawing.Point(114, 126);
            this.velYBox.Name = "velYBox";
            this.velYBox.Size = new System.Drawing.Size(100, 20);
            this.velYBox.TabIndex = 6;
            // 
            // velXBox
            // 
            this.velXBox.Location = new System.Drawing.Point(3, 126);
            this.velXBox.Name = "velXBox";
            this.velXBox.Size = new System.Drawing.Size(100, 20);
            this.velXBox.TabIndex = 5;
            // 
            // currentObjectLabel
            // 
            this.currentObjectLabel.AutoSize = true;
            this.currentObjectLabel.Location = new System.Drawing.Point(6, 37);
            this.currentObjectLabel.Name = "currentObjectLabel";
            this.currentObjectLabel.Size = new System.Drawing.Size(81, 13);
            this.currentObjectLabel.TabIndex = 8;
            this.currentObjectLabel.Text = "Current Object: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1386, 557);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox enableDebugDrawCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox posYBox;
        private System.Windows.Forms.TextBox posXBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox velYBox;
        private System.Windows.Forms.TextBox velXBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label currentObjectLabel;
    }
}

