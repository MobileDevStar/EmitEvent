namespace EmitEvent
{
    partial class frmEmitEvent
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
            this.numKeyFrom = new System.Windows.Forms.NumericUpDown();
            this.labelKeyFrom = new System.Windows.Forms.Label();
            this.keyBox = new System.Windows.Forms.GroupBox();
            this.labelKeyTo = new System.Windows.Forms.Label();
            this.numKeyTo = new System.Windows.Forms.NumericUpDown();
            this.mouseBox = new System.Windows.Forms.GroupBox();
            this.labelMouseTo = new System.Windows.Forms.Label();
            this.numMouseTo = new System.Windows.Forms.NumericUpDown();
            this.labelMouseFrom = new System.Windows.Forms.Label();
            this.numMouseFrom = new System.Windows.Forms.NumericUpDown();
            this.labelInterval = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.labelHours = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboTypes = new System.Windows.Forms.ComboBox();
            this.labelEventType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyFrom)).BeginInit();
            this.keyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyTo)).BeginInit();
            this.mouseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // numKeyFrom
            // 
            this.numKeyFrom.Location = new System.Drawing.Point(137, 48);
            this.numKeyFrom.Name = "numKeyFrom";
            this.numKeyFrom.Size = new System.Drawing.Size(120, 23);
            this.numKeyFrom.TabIndex = 1;
            // 
            // labelKeyFrom
            // 
            this.labelKeyFrom.AutoSize = true;
            this.labelKeyFrom.Location = new System.Drawing.Point(86, 50);
            this.labelKeyFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyFrom.Name = "labelKeyFrom";
            this.labelKeyFrom.Size = new System.Drawing.Size(44, 17);
            this.labelKeyFrom.TabIndex = 0;
            this.labelKeyFrom.Text = "From:";
            // 
            // keyBox
            // 
            this.keyBox.Controls.Add(this.labelKeyTo);
            this.keyBox.Controls.Add(this.numKeyTo);
            this.keyBox.Controls.Add(this.labelKeyFrom);
            this.keyBox.Controls.Add(this.numKeyFrom);
            this.keyBox.Location = new System.Drawing.Point(46, 35);
            this.keyBox.Name = "keyBox";
            this.keyBox.Size = new System.Drawing.Size(583, 112);
            this.keyBox.TabIndex = 2;
            this.keyBox.TabStop = false;
            this.keyBox.Text = "KeyEvent";
            // 
            // labelKeyTo
            // 
            this.labelKeyTo.AutoSize = true;
            this.labelKeyTo.Location = new System.Drawing.Point(331, 52);
            this.labelKeyTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKeyTo.Name = "labelKeyTo";
            this.labelKeyTo.Size = new System.Drawing.Size(29, 17);
            this.labelKeyTo.TabIndex = 2;
            this.labelKeyTo.Text = "To:";
            // 
            // numKeyTo
            // 
            this.numKeyTo.Location = new System.Drawing.Point(367, 50);
            this.numKeyTo.Name = "numKeyTo";
            this.numKeyTo.Size = new System.Drawing.Size(120, 23);
            this.numKeyTo.TabIndex = 3;
            // 
            // mouseBox
            // 
            this.mouseBox.Controls.Add(this.labelMouseTo);
            this.mouseBox.Controls.Add(this.numMouseTo);
            this.mouseBox.Controls.Add(this.labelMouseFrom);
            this.mouseBox.Controls.Add(this.numMouseFrom);
            this.mouseBox.Location = new System.Drawing.Point(46, 172);
            this.mouseBox.Name = "mouseBox";
            this.mouseBox.Size = new System.Drawing.Size(583, 112);
            this.mouseBox.TabIndex = 3;
            this.mouseBox.TabStop = false;
            this.mouseBox.Text = "MouseEvent";
            // 
            // labelMouseTo
            // 
            this.labelMouseTo.AutoSize = true;
            this.labelMouseTo.Location = new System.Drawing.Point(331, 52);
            this.labelMouseTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMouseTo.Name = "labelMouseTo";
            this.labelMouseTo.Size = new System.Drawing.Size(29, 17);
            this.labelMouseTo.TabIndex = 2;
            this.labelMouseTo.Text = "To:";
            // 
            // numMouseTo
            // 
            this.numMouseTo.Location = new System.Drawing.Point(367, 50);
            this.numMouseTo.Name = "numMouseTo";
            this.numMouseTo.Size = new System.Drawing.Size(120, 23);
            this.numMouseTo.TabIndex = 3;
            // 
            // labelMouseFrom
            // 
            this.labelMouseFrom.AutoSize = true;
            this.labelMouseFrom.Location = new System.Drawing.Point(86, 50);
            this.labelMouseFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMouseFrom.Name = "labelMouseFrom";
            this.labelMouseFrom.Size = new System.Drawing.Size(44, 17);
            this.labelMouseFrom.TabIndex = 0;
            this.labelMouseFrom.Text = "From:";
            // 
            // numMouseFrom
            // 
            this.numMouseFrom.Location = new System.Drawing.Point(137, 48);
            this.numMouseFrom.Name = "numMouseFrom";
            this.numMouseFrom.Size = new System.Drawing.Size(120, 23);
            this.numMouseFrom.TabIndex = 1;
            // 
            // labelInterval
            // 
            this.labelInterval.AutoSize = true;
            this.labelInterval.Location = new System.Drawing.Point(43, 305);
            this.labelInterval.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInterval.Name = "labelInterval";
            this.labelInterval.Size = new System.Drawing.Size(58, 17);
            this.labelInterval.TabIndex = 4;
            this.labelInterval.Text = "Interval:";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(108, 305);
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 23);
            this.numInterval.TabIndex = 5;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(235, 307);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(25, 17);
            this.labelHours.TabIndex = 6;
            this.labelHours.Text = "(s)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(380, 362);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 33);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(513, 362);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(116, 33);
            this.btnStop.TabIndex = 8;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboTypes
            // 
            this.comboTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTypes.FormattingEnabled = true;
            this.comboTypes.Items.AddRange(new object[] {
            "Keyboard",
            "Mouse"});
            this.comboTypes.Location = new System.Drawing.Point(412, 300);
            this.comboTypes.Name = "comboTypes";
            this.comboTypes.Size = new System.Drawing.Size(121, 24);
            this.comboTypes.TabIndex = 9;
            // 
            // labelEventType
            // 
            this.labelEventType.AutoSize = true;
            this.labelEventType.Location = new System.Drawing.Point(321, 303);
            this.labelEventType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventType.Name = "labelEventType";
            this.labelEventType.Size = new System.Drawing.Size(84, 17);
            this.labelEventType.TabIndex = 10;
            this.labelEventType.Text = "Event Type:";
            // 
            // frmEmitEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 407);
            this.Controls.Add(this.labelEventType);
            this.Controls.Add(this.comboTypes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.labelInterval);
            this.Controls.Add(this.mouseBox);
            this.Controls.Add(this.keyBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmitEvent";
            this.Text = "Emit Event";
            this.Load += new System.EventHandler(this.frmEmitEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numKeyFrom)).EndInit();
            this.keyBox.ResumeLayout(false);
            this.keyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyTo)).EndInit();
            this.mouseBox.ResumeLayout(false);
            this.mouseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numKeyFrom;
        private System.Windows.Forms.Label labelKeyFrom;
        private System.Windows.Forms.GroupBox keyBox;
        private System.Windows.Forms.Label labelKeyTo;
        private System.Windows.Forms.NumericUpDown numKeyTo;
        private System.Windows.Forms.GroupBox mouseBox;
        private System.Windows.Forms.Label labelMouseTo;
        private System.Windows.Forms.NumericUpDown numMouseTo;
        private System.Windows.Forms.Label labelMouseFrom;
        private System.Windows.Forms.NumericUpDown numMouseFrom;
        private System.Windows.Forms.Label labelInterval;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ComboBox comboTypes;
        private System.Windows.Forms.Label labelEventType;
    }
}

