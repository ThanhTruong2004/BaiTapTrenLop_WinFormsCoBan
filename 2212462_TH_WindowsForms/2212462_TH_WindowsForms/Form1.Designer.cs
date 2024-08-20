namespace _2212462_TH_WindowsForms
{
    partial class MainForm
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
            label1 = new Label();
            txtTen = new TextBox();
            btnOK = new Button();
            label2 = new Label();
            txtSaoChep = new TextBox();
            btnSaoChep = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 95);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Nhập tên của bạn:";
            label1.Click += label1_Click;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(245, 87);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(223, 23);
            txtTen.TabIndex = 1;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(313, 136);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 2;
            btnOK.Text = "Xử lý";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 188);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 3;
            label2.Text = "Bạn đã nhập:";
            // 
            // txtSaoChep
            // 
            txtSaoChep.Location = new Point(245, 180);
            txtSaoChep.Name = "txtSaoChep";
            txtSaoChep.ReadOnly = true;
            txtSaoChep.ShortcutsEnabled = false;
            txtSaoChep.Size = new Size(223, 23);
            txtSaoChep.TabIndex = 4;
            txtSaoChep.TextChanged += txtSaoChep_TextChanged;
            // 
            // btnSaoChep
            // 
            btnSaoChep.Location = new Point(394, 136);
            btnSaoChep.Name = "btnSaoChep";
            btnSaoChep.Size = new Size(75, 23);
            btnSaoChep.TabIndex = 5;
            btnSaoChep.Text = "Sao chép";
            btnSaoChep.UseVisualStyleBackColor = true;
            btnSaoChep.Click += btnSaoChep_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSaoChep);
            Controls.Add(txtSaoChep);
            Controls.Add(label2);
            Controls.Add(btnOK);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "Chương trình đầu tiên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button btnOK;
        private Label label2;
        private TextBox txtSaoChep;
        private Button btnSaoChep;
    }
}
