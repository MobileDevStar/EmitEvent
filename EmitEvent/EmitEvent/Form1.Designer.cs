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
            this.labelDuration = new System.Windows.Forms.Label();
            this.numDuration = new System.Windows.Forms.NumericUpDown();
            this.labelHours = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyFrom)).BeginInit();
            this.keyBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyTo)).BeginInit();
            this.mouseBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).BeginInit();
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
            this.labelKeyFrom.Click += new System.EventHandler(this.label2_Click);
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
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(43, 327);
            this.labelDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(66, 17);
            this.labelDuration.TabIndex = 4;
            this.labelDuration.Text = "Duration:";
            // 
            // numDuration
            // 
            this.numDuration.Location = new System.Drawing.Point(126, 325);
            this.numDuration.Name = "numDuration";
            this.numDuration.Size = new System.Drawing.Size(120, 23);
            this.numDuration.TabIndex = 5;
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Location = new System.Drawing.Point(253, 327);
            this.labelHours.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(38, 17);
            this.labelHours.TabIndex = 6;
            this.labelHours.Text = "(hrs)";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(369, 319);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(116, 33);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 319);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 33);
            this.button2.TabIndex = 8;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmEmitEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 407);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.numDuration);
            this.Controls.Add(this.labelDuration);
            this.Controls.Add(this.mouseBox);
            this.Controls.Add(this.keyBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEmitEvent";
            this.Text = "Emit Event";
            ((System.ComponentModel.ISupportInitialize)(this.numKeyFrom)).EndInit();
            this.keyBox.ResumeLayout(false);
            this.keyBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numKeyTo)).EndInit();
            this.mouseBox.ResumeLayout(false);
            this.mouseBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMouseFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDuration)).EndInit();
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
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.NumericUpDown numDuration;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button2;
    }
}

