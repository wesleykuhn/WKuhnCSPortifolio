
namespace DemonstracaoWinForms
{
    partial class FRM_Main
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
            this.pnl_Background = new System.Windows.Forms.Panel();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_Resize = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Minimize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_JsonSerialize = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rtb_Serealized = new System.Windows.Forms.RichTextBox();
            this.pnl_Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Background
            // 
            this.pnl_Background.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Background.BackColor = System.Drawing.SystemColors.Control;
            this.pnl_Background.Controls.Add(this.rtb_Serealized);
            this.pnl_Background.Controls.Add(this.label5);
            this.pnl_Background.Controls.Add(this.btn_JsonSerialize);
            this.pnl_Background.Controls.Add(this.txt_Password);
            this.pnl_Background.Controls.Add(this.label4);
            this.pnl_Background.Controls.Add(this.txt_PhoneNumber);
            this.pnl_Background.Controls.Add(this.label3);
            this.pnl_Background.Controls.Add(this.txt_Email);
            this.pnl_Background.Controls.Add(this.label2);
            this.pnl_Background.Controls.Add(this.txt_Name);
            this.pnl_Background.Controls.Add(this.label1);
            this.pnl_Background.Location = new System.Drawing.Point(1, 30);
            this.pnl_Background.Name = "pnl_Background";
            this.pnl_Background.Size = new System.Drawing.Size(798, 469);
            this.pnl_Background.TabIndex = 0;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(9, 6);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(54, 19);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "label1";
            // 
            // btn_Resize
            // 
            this.btn_Resize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Resize.Location = new System.Drawing.Point(617, 3);
            this.btn_Resize.Name = "btn_Resize";
            this.btn_Resize.Size = new System.Drawing.Size(115, 25);
            this.btn_Resize.TabIndex = 2;
            this.btn_Resize.Text = "Maximilizar";
            this.btn_Resize.UseVisualStyleBackColor = true;
            this.btn_Resize.Click += new System.EventHandler(this.btn_Rezise_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.Location = new System.Drawing.Point(738, 3);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(61, 25);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Fechar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Minimize.Location = new System.Drawing.Point(496, 3);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Size = new System.Drawing.Size(115, 25);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.Text = "Minimizar";
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seu nome:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(90, 16);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(254, 25);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(94, 47);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(250, 25);
            this.txt_Email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seu e-mail:";
            // 
            // txt_PhoneNumber
            // 
            this.txt_PhoneNumber.Location = new System.Drawing.Point(106, 78);
            this.txt_PhoneNumber.Name = "txt_PhoneNumber";
            this.txt_PhoneNumber.Size = new System.Drawing.Size(238, 25);
            this.txt_PhoneNumber.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seu telefone:";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(98, 109);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(246, 25);
            this.txt_Password.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Uma senha:";
            // 
            // btn_JsonSerialize
            // 
            this.btn_JsonSerialize.Location = new System.Drawing.Point(375, 57);
            this.btn_JsonSerialize.Name = "btn_JsonSerialize";
            this.btn_JsonSerialize.Size = new System.Drawing.Size(139, 38);
            this.btn_JsonSerialize.TabIndex = 8;
            this.btn_JsonSerialize.Text = "Serializar";
            this.btn_JsonSerialize.UseVisualStyleBackColor = true;
            this.btn_JsonSerialize.Click += new System.EventHandler(this.btn_JsonSerialize_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Serializado:";
            // 
            // rtb_Serealized
            // 
            this.rtb_Serealized.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_Serealized.Location = new System.Drawing.Point(100, 216);
            this.rtb_Serealized.Name = "rtb_Serealized";
            this.rtb_Serealized.Size = new System.Drawing.Size(687, 146);
            this.rtb_Serealized.TabIndex = 10;
            this.rtb_Serealized.Text = "";
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.btn_Minimize);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_Resize);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.pnl_Background);
            this.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(400, 250);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário Principal";
            this.Load += new System.EventHandler(this.FRM_Main_Full_Load);
            this.Resize += new System.EventHandler(this.FRM_Main_Full_Resize);
            this.pnl_Background.ResumeLayout(false);
            this.pnl_Background.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Background;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Resize;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Minimize;
        private System.Windows.Forms.Button btn_JsonSerialize;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_Serealized;
        private System.Windows.Forms.Label label5;
    }
}

