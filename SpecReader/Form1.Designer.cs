namespace speccy2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.oslabel = new System.Windows.Forms.Label();
            this.cpulabel = new System.Windows.Forms.Label();
            this.ramlabel = new System.Windows.Forms.Label();
            this.mobolabel = new System.Windows.Forms.Label();
            this.gpulabel = new System.Windows.Forms.Label();
            this.storagelabel = new System.Windows.Forms.Label();
            this.audiolabel = new System.Windows.Forms.Label();
            this.cputemp = new System.Windows.Forms.Label();
            this.gputemp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // oslabel
            // 
            this.oslabel.AutoSize = true;
            this.oslabel.Location = new System.Drawing.Point(6, 16);
            this.oslabel.Name = "oslabel";
            this.oslabel.Size = new System.Drawing.Size(13, 13);
            this.oslabel.TabIndex = 1;
            this.oslabel.Text = "0";
            // 
            // cpulabel
            // 
            this.cpulabel.AutoSize = true;
            this.cpulabel.Location = new System.Drawing.Point(6, 16);
            this.cpulabel.Name = "cpulabel";
            this.cpulabel.Size = new System.Drawing.Size(13, 13);
            this.cpulabel.TabIndex = 3;
            this.cpulabel.Text = "0";
            // 
            // ramlabel
            // 
            this.ramlabel.AutoSize = true;
            this.ramlabel.Location = new System.Drawing.Point(9, 16);
            this.ramlabel.Name = "ramlabel";
            this.ramlabel.Size = new System.Drawing.Size(13, 13);
            this.ramlabel.TabIndex = 5;
            this.ramlabel.Text = "0";
            // 
            // mobolabel
            // 
            this.mobolabel.AutoSize = true;
            this.mobolabel.Location = new System.Drawing.Point(9, 16);
            this.mobolabel.Name = "mobolabel";
            this.mobolabel.Size = new System.Drawing.Size(13, 13);
            this.mobolabel.TabIndex = 7;
            this.mobolabel.Text = "0";
            // 
            // gpulabel
            // 
            this.gpulabel.AutoSize = true;
            this.gpulabel.Location = new System.Drawing.Point(9, 16);
            this.gpulabel.Name = "gpulabel";
            this.gpulabel.Size = new System.Drawing.Size(13, 13);
            this.gpulabel.TabIndex = 9;
            this.gpulabel.Text = "0";
            // 
            // storagelabel
            // 
            this.storagelabel.AutoSize = true;
            this.storagelabel.Location = new System.Drawing.Point(9, 16);
            this.storagelabel.Name = "storagelabel";
            this.storagelabel.Size = new System.Drawing.Size(13, 13);
            this.storagelabel.TabIndex = 11;
            this.storagelabel.Text = "0";
            // 
            // audiolabel
            // 
            this.audiolabel.AutoSize = true;
            this.audiolabel.Location = new System.Drawing.Point(6, 16);
            this.audiolabel.Name = "audiolabel";
            this.audiolabel.Size = new System.Drawing.Size(13, 13);
            this.audiolabel.TabIndex = 13;
            this.audiolabel.Text = "0";
            // 
            // cputemp
            // 
            this.cputemp.AutoSize = true;
            this.cputemp.Location = new System.Drawing.Point(587, 59);
            this.cputemp.Name = "cputemp";
            this.cputemp.Size = new System.Drawing.Size(95, 13);
            this.cputemp.TabIndex = 15;
            this.cputemp.Text = "CPU Temperature:";
            // 
            // gputemp
            // 
            this.gputemp.AutoSize = true;
            this.gputemp.Location = new System.Drawing.Point(587, 47);
            this.gputemp.Name = "gputemp";
            this.gputemp.Size = new System.Drawing.Size(96, 13);
            this.gputemp.TabIndex = 16;
            this.gputemp.Text = "GPU Temperature:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.oslabel);
            this.groupBox1.Location = new System.Drawing.Point(42, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 102);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operating System";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpulabel);
            this.groupBox2.Controls.Add(this.cputemp);
            this.groupBox2.Location = new System.Drawing.Point(42, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 115);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.storagelabel);
            this.groupBox3.Location = new System.Drawing.Point(42, 543);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(733, 123);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Storage";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.gpulabel);
            this.groupBox4.Controls.Add(this.gputemp);
            this.groupBox4.Location = new System.Drawing.Point(42, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(733, 100);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "GPU";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mobolabel);
            this.groupBox5.Location = new System.Drawing.Point(42, 672);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(733, 133);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Motherboard";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ramlabel);
            this.groupBox6.Location = new System.Drawing.Point(42, 399);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(733, 138);
            this.groupBox6.TabIndex = 21;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "RAM";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.audiolabel);
            this.groupBox7.Location = new System.Drawing.Point(42, 811);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(733, 100);
            this.groupBox7.TabIndex = 22;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Audio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "SpecReader";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 1007);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SpecReader";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label oslabel;
        private System.Windows.Forms.Label cpulabel;
        private System.Windows.Forms.Label ramlabel;
        private System.Windows.Forms.Label mobolabel;
        private System.Windows.Forms.Label gpulabel;
        private System.Windows.Forms.Label storagelabel;
        private System.Windows.Forms.Label audiolabel;
        private System.Windows.Forms.Label cputemp;
        private System.Windows.Forms.Label gputemp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label1;
    }
}

