namespace coursework
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.leftBoundaryPoint_TB = new System.Windows.Forms.TextBox();
            this.rightBoundaryPoint_TB = new System.Windows.Forms.TextBox();
            this.epsilon_TB = new System.Windows.Forms.TextBox();
            this.nle_setVariablesButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.nle_answerHolder = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.qe_setVariablesButton = new System.Windows.Forms.Button();
            this.qe_thirdCoeffTB = new System.Windows.Forms.TextBox();
            this.qe_secondCoeffTB = new System.Windows.Forms.TextBox();
            this.qe_firstCoeffTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.qe_answerHolder = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 336);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Non-linear equation";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel6);
            this.groupBox2.Controls.Add(this.panel5);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Location = new System.Drawing.Point(233, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 336);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quadratic equation";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(525, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 336);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time function";
            // 
            // groupBox4
            // 
            this.groupBox4.AccessibleName = "";
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(525, 367);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 232);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Debug frame";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "THE TASK";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.nle_setVariablesButton);
            this.panel2.Controls.Add(this.epsilon_TB);
            this.panel2.Controls.Add(this.rightBoundaryPoint_TB);
            this.panel2.Controls.Add(this.leftBoundaryPoint_TB);
            this.panel2.Controls.Add(this.label2);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(6, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 109);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SET VARIABLES";
            // 
            // leftBoundaryPoint_TB
            // 
            this.leftBoundaryPoint_TB.Location = new System.Drawing.Point(29, 50);
            this.leftBoundaryPoint_TB.Name = "leftBoundaryPoint_TB";
            this.leftBoundaryPoint_TB.Size = new System.Drawing.Size(37, 20);
            this.leftBoundaryPoint_TB.TabIndex = 2;
            this.leftBoundaryPoint_TB.TextChanged += new System.EventHandler(this.leftBoundaryPoint_TB_TextChanged);
            this.leftBoundaryPoint_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.leftBoundaryPoint_TB_KeyPress);
            // 
            // rightBoundaryPoint_TB
            // 
            this.rightBoundaryPoint_TB.Location = new System.Drawing.Point(79, 50);
            this.rightBoundaryPoint_TB.Name = "rightBoundaryPoint_TB";
            this.rightBoundaryPoint_TB.Size = new System.Drawing.Size(37, 20);
            this.rightBoundaryPoint_TB.TabIndex = 3;
            this.rightBoundaryPoint_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rightBoundaryPoint_TB_KeyPress);
            // 
            // epsilon_TB
            // 
            this.epsilon_TB.Location = new System.Drawing.Point(122, 50);
            this.epsilon_TB.Name = "epsilon_TB";
            this.epsilon_TB.Size = new System.Drawing.Size(55, 20);
            this.epsilon_TB.TabIndex = 4;
            this.epsilon_TB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.epsilon_TB_KeyPress);
            // 
            // nle_setVariablesButton
            // 
            this.nle_setVariablesButton.Location = new System.Drawing.Point(57, 76);
            this.nle_setVariablesButton.Name = "nle_setVariablesButton";
            this.nle_setVariablesButton.Size = new System.Drawing.Size(75, 23);
            this.nle_setVariablesButton.TabIndex = 5;
            this.nle_setVariablesButton.Text = "SET";
            this.nle_setVariablesButton.UseVisualStyleBackColor = true;
            this.nle_setVariablesButton.Click += new System.EventHandler(this.nle_setVariablesButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "[ a ;";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(76, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "b ]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(119, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "ε";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.nle_answerHolder);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(6, 240);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 80);
            this.panel3.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "ANSWER:";
            // 
            // nle_answerHolder
            // 
            this.nle_answerHolder.AutoSize = true;
            this.nle_answerHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nle_answerHolder.Location = new System.Drawing.Point(97, 31);
            this.nle_answerHolder.Name = "nle_answerHolder";
            this.nle_answerHolder.Size = new System.Drawing.Size(0, 20);
            this.nle_answerHolder.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(6, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 100);
            this.panel4.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(208, 71);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "THE TASK";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.qe_setVariablesButton);
            this.panel5.Controls.Add(this.qe_thirdCoeffTB);
            this.panel5.Controls.Add(this.qe_secondCoeffTB);
            this.panel5.Controls.Add(this.qe_firstCoeffTB);
            this.panel5.Controls.Add(this.label11);
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(6, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(239, 109);
            this.panel5.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(140, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "c1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(97, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "b1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(54, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "a1";
            // 
            // qe_setVariablesButton
            // 
            this.qe_setVariablesButton.Location = new System.Drawing.Point(78, 76);
            this.qe_setVariablesButton.Name = "qe_setVariablesButton";
            this.qe_setVariablesButton.Size = new System.Drawing.Size(75, 23);
            this.qe_setVariablesButton.TabIndex = 5;
            this.qe_setVariablesButton.Text = "SET";
            this.qe_setVariablesButton.UseVisualStyleBackColor = true;
            // 
            // qe_thirdCoeffTB
            // 
            this.qe_thirdCoeffTB.Location = new System.Drawing.Point(143, 50);
            this.qe_thirdCoeffTB.Name = "qe_thirdCoeffTB";
            this.qe_thirdCoeffTB.Size = new System.Drawing.Size(39, 20);
            this.qe_thirdCoeffTB.TabIndex = 4;
            // 
            // qe_secondCoeffTB
            // 
            this.qe_secondCoeffTB.Location = new System.Drawing.Point(100, 50);
            this.qe_secondCoeffTB.Name = "qe_secondCoeffTB";
            this.qe_secondCoeffTB.Size = new System.Drawing.Size(37, 20);
            this.qe_secondCoeffTB.TabIndex = 3;
            // 
            // qe_firstCoeffTB
            // 
            this.qe_firstCoeffTB.Location = new System.Drawing.Point(57, 50);
            this.qe_firstCoeffTB.Name = "qe_firstCoeffTB";
            this.qe_firstCoeffTB.Size = new System.Drawing.Size(37, 20);
            this.qe_firstCoeffTB.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "SET VARIABLES";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.qe_answerHolder);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(6, 240);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(239, 80);
            this.panel6.TabIndex = 9;
            // 
            // qe_answerHolder
            // 
            this.qe_answerHolder.AutoSize = true;
            this.qe_answerHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qe_answerHolder.Location = new System.Drawing.Point(97, 31);
            this.qe_answerHolder.Name = "qe_answerHolder";
            this.qe_answerHolder.Size = new System.Drawing.Size(0, 20);
            this.qe_answerHolder.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "ANSWER:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 611);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button nle_setVariablesButton;
        private System.Windows.Forms.TextBox epsilon_TB;
        private System.Windows.Forms.TextBox rightBoundaryPoint_TB;
        private System.Windows.Forms.TextBox leftBoundaryPoint_TB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label nle_answerHolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label qe_answerHolder;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button qe_setVariablesButton;
        private System.Windows.Forms.TextBox qe_thirdCoeffTB;
        private System.Windows.Forms.TextBox qe_secondCoeffTB;
        private System.Windows.Forms.TextBox qe_firstCoeffTB;
        private System.Windows.Forms.Label label11;
    }
}

