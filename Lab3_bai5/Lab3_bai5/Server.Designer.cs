namespace Lab3_bai5
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPort = new TextBox();
            label1 = new Label();
            listenBtt = new Button();
            label2 = new Label();
            connectedClientLabel = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            selectedSeatsLabel = new Label();
            emptySeatsLabel = new Label();
            checkBox1 = new CheckBox();
            buttonStop = new Button();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            SuspendLayout();
            // 
            // textBoxPort
            // 
            textBoxPort.BorderStyle = BorderStyle.FixedSingle;
            textBoxPort.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxPort.Location = new Point(66, 10);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.ReadOnly = true;
            textBoxPort.Size = new Size(111, 30);
            textBoxPort.TabIndex = 0;
            textBoxPort.Text = "8080";
            textBoxPort.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 1;
            label1.Text = "PORT";
            // 
            // listenBtt
            // 
            listenBtt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listenBtt.Location = new Point(12, 46);
            listenBtt.Name = "listenBtt";
            listenBtt.Size = new Size(165, 33);
            listenBtt.TabIndex = 2;
            listenBtt.Text = "LISTEN";
            listenBtt.UseVisualStyleBackColor = true;
            listenBtt.Click += listenBtt_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(154, 20);
            label2.TabIndex = 3;
            label2.Text = "Số thiết bị đã kết nối: ";
            // 
            // connectedClientLabel
            // 
            connectedClientLabel.AutoSize = true;
            connectedClientLabel.Location = new Point(162, 142);
            connectedClientLabel.Name = "connectedClientLabel";
            connectedClientLabel.Size = new Size(24, 20);
            connectedClientLabel.TabIndex = 4;
            connectedClientLabel.Text = "so";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Salmon;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(307, 10);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(360, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "Màn hình";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 390);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 3;
            label3.Text = "Số ghế đã chọn: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 421);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 3;
            label4.Text = "Số ghế trống:";
            // 
            // selectedSeatsLabel
            // 
            selectedSeatsLabel.AutoSize = true;
            selectedSeatsLabel.Location = new Point(326, 390);
            selectedSeatsLabel.Name = "selectedSeatsLabel";
            selectedSeatsLabel.Size = new Size(24, 20);
            selectedSeatsLabel.TabIndex = 4;
            selectedSeatsLabel.Text = "so";
            // 
            // emptySeatsLabel
            // 
            emptySeatsLabel.AutoSize = true;
            emptySeatsLabel.Location = new Point(314, 421);
            emptySeatsLabel.Name = "emptySeatsLabel";
            emptySeatsLabel.Size = new Size(24, 20);
            emptySeatsLabel.TabIndex = 4;
            emptySeatsLabel.Text = "so";
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(243, 85);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(53, 66);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "\r\n  1  \r\n";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonStop
            // 
            buttonStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStop.Location = new Point(12, 85);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(165, 33);
            buttonStop.TabIndex = 2;
            buttonStop.Text = "STOP";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // checkBox2
            // 
            checkBox2.Appearance = Appearance.Button;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox2.Location = new Point(348, 85);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(53, 66);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "\r\n  2  \r\n";
            checkBox2.TextAlign = ContentAlignment.MiddleCenter;
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.AutoSize = true;
            checkBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox3.Location = new Point(460, 85);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(53, 66);
            checkBox3.TabIndex = 7;
            checkBox3.Text = "\r\n  3  \r\n";
            checkBox3.TextAlign = ContentAlignment.MiddleCenter;
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.AutoSize = true;
            checkBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox4.Location = new Point(572, 85);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(53, 66);
            checkBox4.TabIndex = 7;
            checkBox4.Text = "\r\n  4  \r\n";
            checkBox4.TextAlign = ContentAlignment.MiddleCenter;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.AutoSize = true;
            checkBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox5.Location = new Point(679, 85);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(53, 66);
            checkBox5.TabIndex = 7;
            checkBox5.Text = "\r\n  5  \r\n";
            checkBox5.TextAlign = ContentAlignment.MiddleCenter;
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.AutoSize = true;
            checkBox6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox6.Location = new Point(243, 186);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(53, 66);
            checkBox6.TabIndex = 7;
            checkBox6.Text = "\r\n  6  \r\n";
            checkBox6.TextAlign = ContentAlignment.MiddleCenter;
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.Appearance = Appearance.Button;
            checkBox7.AutoSize = true;
            checkBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox7.Location = new Point(348, 186);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(53, 66);
            checkBox7.TabIndex = 7;
            checkBox7.Text = "\r\n  7  \r\n";
            checkBox7.TextAlign = ContentAlignment.MiddleCenter;
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.Appearance = Appearance.Button;
            checkBox8.AutoSize = true;
            checkBox8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox8.Location = new Point(460, 186);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(53, 66);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "\r\n  8  \r\n";
            checkBox8.TextAlign = ContentAlignment.MiddleCenter;
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.Appearance = Appearance.Button;
            checkBox9.AutoSize = true;
            checkBox9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox9.Location = new Point(572, 186);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(53, 66);
            checkBox9.TabIndex = 7;
            checkBox9.Text = "\r\n  9  \r\n";
            checkBox9.TextAlign = ContentAlignment.MiddleCenter;
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.Appearance = Appearance.Button;
            checkBox10.AutoSize = true;
            checkBox10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox10.Location = new Point(679, 186);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(54, 66);
            checkBox10.TabIndex = 7;
            checkBox10.Text = "\r\n 10 ";
            checkBox10.TextAlign = ContentAlignment.MiddleCenter;
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.Appearance = Appearance.Button;
            checkBox11.AutoSize = true;
            checkBox11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox11.Location = new Point(243, 286);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(54, 66);
            checkBox11.TabIndex = 7;
            checkBox11.Text = "\r\n 11 ";
            checkBox11.TextAlign = ContentAlignment.MiddleCenter;
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.Appearance = Appearance.Button;
            checkBox12.AutoSize = true;
            checkBox12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox12.Location = new Point(348, 286);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(54, 66);
            checkBox12.TabIndex = 7;
            checkBox12.Text = "\r\n 12 \r\n";
            checkBox12.TextAlign = ContentAlignment.MiddleCenter;
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.Appearance = Appearance.Button;
            checkBox13.AutoSize = true;
            checkBox13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox13.Location = new Point(460, 286);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(54, 66);
            checkBox13.TabIndex = 7;
            checkBox13.Text = "\r\n 13 \r\n";
            checkBox13.TextAlign = ContentAlignment.MiddleCenter;
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.Appearance = Appearance.Button;
            checkBox14.AutoSize = true;
            checkBox14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox14.Location = new Point(572, 286);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(54, 66);
            checkBox14.TabIndex = 7;
            checkBox14.Text = "\r\n 14 \r\n";
            checkBox14.TextAlign = ContentAlignment.MiddleCenter;
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.Appearance = Appearance.Button;
            checkBox15.AutoSize = true;
            checkBox15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox15.Location = new Point(679, 286);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(54, 66);
            checkBox15.TabIndex = 7;
            checkBox15.Text = "\r\n 15 \r\n";
            checkBox15.TextAlign = ContentAlignment.MiddleCenter;
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox15);
            Controls.Add(checkBox10);
            Controls.Add(checkBox5);
            Controls.Add(checkBox14);
            Controls.Add(checkBox9);
            Controls.Add(checkBox4);
            Controls.Add(checkBox13);
            Controls.Add(checkBox8);
            Controls.Add(checkBox3);
            Controls.Add(checkBox12);
            Controls.Add(checkBox7);
            Controls.Add(checkBox2);
            Controls.Add(checkBox11);
            Controls.Add(checkBox6);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(emptySeatsLabel);
            Controls.Add(selectedSeatsLabel);
            Controls.Add(connectedClientLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonStop);
            Controls.Add(listenBtt);
            Controls.Add(label1);
            Controls.Add(textBoxPort);
            Name = "Server";
            Opacity = 0.95D;
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPort;
        private Label label1;
        private Button listenBtt;
        private Label label2;
        private Label connectedClientLabel;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private Label selectedSeatsLabel;
        private Label emptySeatsLabel;
        private CheckBox checkBox1;
        private Button buttonStop;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox15;
    }
}
