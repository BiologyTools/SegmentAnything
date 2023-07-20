namespace SegmentAnything
{
    partial class Init
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.preModelBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.setPremodelBut = new System.Windows.Forms.Button();
            this.setModelBut = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.okBut = new System.Windows.Forms.Button();
            this.cancelBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "PreModel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // preModelBox
            // 
            this.preModelBox.Location = new System.Drawing.Point(71, 30);
            this.preModelBox.Name = "preModelBox";
            this.preModelBox.Size = new System.Drawing.Size(248, 23);
            this.preModelBox.TabIndex = 2;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(71, 59);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(248, 23);
            this.modelBox.TabIndex = 3;
            // 
            // setPremodelBut
            // 
            this.setPremodelBut.Location = new System.Drawing.Point(325, 30);
            this.setPremodelBut.Name = "setPremodelBut";
            this.setPremodelBut.Size = new System.Drawing.Size(52, 23);
            this.setPremodelBut.TabIndex = 4;
            this.setPremodelBut.Text = "Set";
            this.setPremodelBut.UseVisualStyleBackColor = true;
            this.setPremodelBut.Click += new System.EventHandler(this.setPremodelBut_Click);
            // 
            // setModelBut
            // 
            this.setModelBut.Location = new System.Drawing.Point(325, 58);
            this.setModelBut.Name = "setModelBut";
            this.setModelBut.Size = new System.Drawing.Size(52, 24);
            this.setModelBut.TabIndex = 5;
            this.setModelBut.Text = "Set";
            this.setModelBut.UseVisualStyleBackColor = true;
            this.setModelBut.Click += new System.EventHandler(this.setModelBut_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Set Filepath to PreModel and Model";
            // 
            // okBut
            // 
            this.okBut.Location = new System.Drawing.Point(302, 88);
            this.okBut.Name = "okBut";
            this.okBut.Size = new System.Drawing.Size(75, 23);
            this.okBut.TabIndex = 7;
            this.okBut.Text = "OK";
            this.okBut.UseVisualStyleBackColor = true;
            this.okBut.Click += new System.EventHandler(this.okBut_Click_1);
            // 
            // cancelBut
            // 
            this.cancelBut.Location = new System.Drawing.Point(221, 88);
            this.cancelBut.Name = "cancelBut";
            this.cancelBut.Size = new System.Drawing.Size(75, 23);
            this.cancelBut.TabIndex = 8;
            this.cancelBut.Text = "Cancel";
            this.cancelBut.UseVisualStyleBackColor = true;
            this.cancelBut.Click += new System.EventHandler(this.cancelBut_Click);
            // 
            // Init
            // 
            this.AcceptButton = this.okBut;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBut;
            this.ClientSize = new System.Drawing.Size(384, 114);
            this.Controls.Add(this.cancelBut);
            this.Controls.Add(this.okBut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.setModelBut);
            this.Controls.Add(this.setPremodelBut);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.preModelBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Init";
            this.Text = "Init";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox preModelBox;
        private TextBox modelBox;
        private Button setPremodelBut;
        private Button setModelBut;
        private OpenFileDialog openFileDialog;
        private Label label3;
        private Button okBut;
        private Button cancelBut;
    }
}