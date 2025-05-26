namespace CourseworkAppDevWinForms
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
            this.lb_AsciiEncoder = new System.Windows.Forms.Label();
            this.tb_InputString = new System.Windows.Forms.TextBox();
            this.tb_InputInt = new System.Windows.Forms.TextBox();
            this.lb_InputString = new System.Windows.Forms.Label();
            this.lb_InputInt = new System.Windows.Forms.Label();
            this.bt_Encode = new System.Windows.Forms.Button();
            this.bt_InputCode = new System.Windows.Forms.Button();
            this.bt_OutputCode = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.bt_Sort = new System.Windows.Forms.Button();
            this.pb_GreenwichLogo = new System.Windows.Forms.PictureBox();
            this.lb_note = new System.Windows.Forms.Label();
            this.lb_NoteButton = new System.Windows.Forms.Label();
            this.bt_UseWebcam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GreenwichLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_AsciiEncoder
            // 
            this.lb_AsciiEncoder.AutoSize = true;
            this.lb_AsciiEncoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AsciiEncoder.Location = new System.Drawing.Point(308, 28);
            this.lb_AsciiEncoder.Name = "lb_AsciiEncoder";
            this.lb_AsciiEncoder.Size = new System.Drawing.Size(161, 29);
            this.lb_AsciiEncoder.TabIndex = 0;
            this.lb_AsciiEncoder.Text = "Ascii Encoder";
            this.lb_AsciiEncoder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_AsciiEncoder.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_InputString
            // 
            this.tb_InputString.Location = new System.Drawing.Point(412, 117);
            this.tb_InputString.Name = "tb_InputString";
            this.tb_InputString.Size = new System.Drawing.Size(150, 20);
            this.tb_InputString.TabIndex = 1;
            // 
            // tb_InputInt
            // 
            this.tb_InputInt.Location = new System.Drawing.Point(412, 180);
            this.tb_InputInt.Name = "tb_InputInt";
            this.tb_InputInt.Size = new System.Drawing.Size(150, 20);
            this.tb_InputInt.TabIndex = 2;
            // 
            // lb_InputString
            // 
            this.lb_InputString.AutoSize = true;
            this.lb_InputString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputString.Location = new System.Drawing.Point(181, 112);
            this.lb_InputString.Name = "lb_InputString";
            this.lb_InputString.Size = new System.Drawing.Size(192, 24);
            this.lb_InputString.TabIndex = 3;
            this.lb_InputString.Text = "Enter string to convert";
            this.lb_InputString.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lb_InputInt
            // 
            this.lb_InputInt.AutoSize = true;
            this.lb_InputInt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_InputInt.Location = new System.Drawing.Point(241, 176);
            this.lb_InputInt.Name = "lb_InputInt";
            this.lb_InputInt.Size = new System.Drawing.Size(132, 24);
            this.lb_InputInt.TabIndex = 4;
            this.lb_InputInt.Text = "Enter shift step";
            // 
            // bt_Encode
            // 
            this.bt_Encode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Encode.Location = new System.Drawing.Point(123, 311);
            this.bt_Encode.Name = "bt_Encode";
            this.bt_Encode.Size = new System.Drawing.Size(96, 45);
            this.bt_Encode.TabIndex = 5;
            this.bt_Encode.Text = "Encode";
            this.bt_Encode.UseVisualStyleBackColor = true;
            this.bt_Encode.Click += new System.EventHandler(this.bt_Encode_Click);
            this.bt_Encode.MouseEnter += new System.EventHandler(this.bt_Encode_MouseEnter);
            this.bt_Encode.MouseLeave += new System.EventHandler(this.bt_Encode_MouseLeave);
            this.bt_Encode.MouseHover += new System.EventHandler(this.bt_Encode_MouseHover);
            // 
            // bt_InputCode
            // 
            this.bt_InputCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_InputCode.Location = new System.Drawing.Point(270, 311);
            this.bt_InputCode.Name = "bt_InputCode";
            this.bt_InputCode.Size = new System.Drawing.Size(96, 45);
            this.bt_InputCode.TabIndex = 6;
            this.bt_InputCode.Text = "Input Code";
            this.bt_InputCode.UseVisualStyleBackColor = true;
            this.bt_InputCode.Click += new System.EventHandler(this.bt_InputCode_Click);
            this.bt_InputCode.MouseLeave += new System.EventHandler(this.bt_InputCode_MouseLeave);
            this.bt_InputCode.MouseHover += new System.EventHandler(this.bt_InputCode_MouseHover);
            // 
            // bt_OutputCode
            // 
            this.bt_OutputCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_OutputCode.Location = new System.Drawing.Point(421, 311);
            this.bt_OutputCode.Name = "bt_OutputCode";
            this.bt_OutputCode.Size = new System.Drawing.Size(96, 45);
            this.bt_OutputCode.TabIndex = 7;
            this.bt_OutputCode.Text = "Output Code";
            this.bt_OutputCode.UseVisualStyleBackColor = true;
            this.bt_OutputCode.Click += new System.EventHandler(this.bt_OutputCode_Click);
            this.bt_OutputCode.MouseLeave += new System.EventHandler(this.bt_OutputCode_MouseLeave);
            this.bt_OutputCode.MouseHover += new System.EventHandler(this.bt_OutputCode_MouseHover);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.Location = new System.Drawing.Point(301, 239);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(72, 24);
            this.lb_Result.TabIndex = 8;
            this.lb_Result.Text = "Result: ";
            // 
            // bt_Sort
            // 
            this.bt_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Sort.Location = new System.Drawing.Point(578, 311);
            this.bt_Sort.Name = "bt_Sort";
            this.bt_Sort.Size = new System.Drawing.Size(96, 45);
            this.bt_Sort.TabIndex = 9;
            this.bt_Sort.Text = "Sort";
            this.bt_Sort.UseVisualStyleBackColor = true;
            this.bt_Sort.Click += new System.EventHandler(this.bt_Sort_Click);
            this.bt_Sort.MouseLeave += new System.EventHandler(this.bt_Sort_MouseLeave);
            this.bt_Sort.MouseHover += new System.EventHandler(this.bt_Sort_MouseHover);
            // 
            // pb_GreenwichLogo
            // 
            this.pb_GreenwichLogo.Image = global::CourseworkAppDevWinForms.Properties.Resources.greenwich_logo;
            this.pb_GreenwichLogo.Location = new System.Drawing.Point(-2, 0);
            this.pb_GreenwichLogo.Name = "pb_GreenwichLogo";
            this.pb_GreenwichLogo.Size = new System.Drawing.Size(148, 57);
            this.pb_GreenwichLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_GreenwichLogo.TabIndex = 10;
            this.pb_GreenwichLogo.TabStop = false;
            // 
            // lb_note
            // 
            this.lb_note.AutoSize = true;
            this.lb_note.Location = new System.Drawing.Point(337, 404);
            this.lb_note.Name = "lb_note";
            this.lb_note.Size = new System.Drawing.Size(0, 13);
            this.lb_note.TabIndex = 11;
            // 
            // lb_NoteButton
            // 
            this.lb_NoteButton.AutoSize = true;
            this.lb_NoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NoteButton.Location = new System.Drawing.Point(242, 392);
            this.lb_NoteButton.Name = "lb_NoteButton";
            this.lb_NoteButton.Size = new System.Drawing.Size(42, 16);
            this.lb_NoteButton.TabIndex = 12;
            this.lb_NoteButton.Text = "Note: ";
            // 
            // bt_UseWebcam
            // 
            this.bt_UseWebcam.Location = new System.Drawing.Point(578, 117);
            this.bt_UseWebcam.Name = "bt_UseWebcam";
            this.bt_UseWebcam.Size = new System.Drawing.Size(96, 23);
            this.bt_UseWebcam.TabIndex = 13;
            this.bt_UseWebcam.Text = "Use webcam";
            this.bt_UseWebcam.UseVisualStyleBackColor = true;
            this.bt_UseWebcam.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_UseWebcam);
            this.Controls.Add(this.lb_NoteButton);
            this.Controls.Add(this.lb_note);
            this.Controls.Add(this.pb_GreenwichLogo);
            this.Controls.Add(this.bt_Sort);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.bt_OutputCode);
            this.Controls.Add(this.bt_InputCode);
            this.Controls.Add(this.bt_Encode);
            this.Controls.Add(this.lb_InputInt);
            this.Controls.Add(this.lb_InputString);
            this.Controls.Add(this.tb_InputInt);
            this.Controls.Add(this.tb_InputString);
            this.Controls.Add(this.lb_AsciiEncoder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_GreenwichLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_AsciiEncoder;
        private System.Windows.Forms.TextBox tb_InputString;
        private System.Windows.Forms.TextBox tb_InputInt;
        private System.Windows.Forms.Label lb_InputString;
        private System.Windows.Forms.Label lb_InputInt;
        private System.Windows.Forms.Button bt_Encode;
        private System.Windows.Forms.Button bt_InputCode;
        private System.Windows.Forms.Button bt_OutputCode;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Button bt_Sort;
        private System.Windows.Forms.PictureBox pb_GreenwichLogo;
        private System.Windows.Forms.Label lb_note;
        private System.Windows.Forms.Label lb_NoteButton;
        private System.Windows.Forms.Button bt_UseWebcam;
    }
}

