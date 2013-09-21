namespace WindowsFormsApplication1
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
            this.tbProxyAddress = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbUname = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChangeProxy = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnNoProxy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbProxyAddress
            // 
            this.tbProxyAddress.Location = new System.Drawing.Point(128, 9);
            this.tbProxyAddress.Name = "tbProxyAddress";
            this.tbProxyAddress.Size = new System.Drawing.Size(131, 20);
            this.tbProxyAddress.TabIndex = 1;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(128, 39);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(131, 20);
            this.tbPort.TabIndex = 5;
            // 
            // tbUname
            // 
            this.tbUname.Location = new System.Drawing.Point(128, 69);
            this.tbUname.Name = "tbUname";
            this.tbUname.Size = new System.Drawing.Size(131, 20);
            this.tbUname.TabIndex = 6;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(128, 99);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(131, 20);
            this.tbPass.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Proxy address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password";
            // 
            // btnChangeProxy
            // 
            this.btnChangeProxy.Location = new System.Drawing.Point(266, 9);
            this.btnChangeProxy.Name = "btnChangeProxy";
            this.btnChangeProxy.Size = new System.Drawing.Size(75, 23);
            this.btnChangeProxy.TabIndex = 12;
            this.btnChangeProxy.Text = "Change";
            this.btnChangeProxy.UseVisualStyleBackColor = true;
            this.btnChangeProxy.Click += new System.EventHandler(this.btnChangeProxy_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(266, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNoProxy
            // 
            this.btnNoProxy.Location = new System.Drawing.Point(266, 67);
            this.btnNoProxy.Name = "btnNoProxy";
            this.btnNoProxy.Size = new System.Drawing.Size(75, 23);
            this.btnNoProxy.TabIndex = 14;
            this.btnNoProxy.Text = "NoProxy";
            this.btnNoProxy.UseVisualStyleBackColor = true;
            this.btnNoProxy.Click += new System.EventHandler(this.btnNoProxy_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(266, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Load proxy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 133);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNoProxy);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnChangeProxy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUname);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbProxyAddress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Easy Proxy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbProxyAddress;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbUname;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChangeProxy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnNoProxy;
        private System.Windows.Forms.Button button1;

    }
}

