
namespace OrangeSchool.UI
{
    partial class profes_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profes_form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.nombreLabel = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.txt_sal = new System.Windows.Forms.TextBox();
            this.txt_ape = new System.Windows.Forms.TextBox();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.apellidoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 92);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(128, 133);
            this.txt_nom.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(141, 20);
            this.txt_nom.TabIndex = 26;
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(14, 133);
            this.nombreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(85, 13);
            this.nombreLabel.TabIndex = 25;
            this.nombreLabel.Text = "Ingrese Nombre:";
            // 
            // back
            // 
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Location = new System.Drawing.Point(16, 231);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 25);
            this.back.TabIndex = 24;
            this.back.Text = "Volver";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // runButton
            // 
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.runButton.Location = new System.Drawing.Point(128, 231);
            this.runButton.Margin = new System.Windows.Forms.Padding(2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(140, 25);
            this.runButton.TabIndex = 23;
            this.runButton.Text = "Registrar";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.signUp_Click);
            // 
            // txt_sal
            // 
            this.txt_sal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_sal.Location = new System.Drawing.Point(128, 191);
            this.txt_sal.Margin = new System.Windows.Forms.Padding(2);
            this.txt_sal.Name = "txt_sal";
            this.txt_sal.Size = new System.Drawing.Size(141, 20);
            this.txt_sal.TabIndex = 22;
            // 
            // txt_ape
            // 
            this.txt_ape.Location = new System.Drawing.Point(128, 163);
            this.txt_ape.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ape.Name = "txt_ape";
            this.txt_ape.Size = new System.Drawing.Size(141, 20);
            this.txt_ape.TabIndex = 21;
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Location = new System.Drawing.Point(14, 191);
            this.salaryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(80, 13);
            this.salaryLabel.TabIndex = 20;
            this.salaryLabel.Text = "Ingrese Salario:";
            // 
            // apellidoLabel
            // 
            this.apellidoLabel.AutoSize = true;
            this.apellidoLabel.Location = new System.Drawing.Point(14, 163);
            this.apellidoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apellidoLabel.Name = "apellidoLabel";
            this.apellidoLabel.Size = new System.Drawing.Size(85, 13);
            this.apellidoLabel.TabIndex = 19;
            this.apellidoLabel.Text = "Ingrese Apellido:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 24);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Profesor";
            // 
            // profes_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 266);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.back);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.txt_sal);
            this.Controls.Add(this.txt_ape);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.apellidoLabel);
            this.Controls.Add(this.panel1);
            this.Name = "profes_form";
            this.Text = "Orange School Admin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox txt_sal;
        private System.Windows.Forms.TextBox txt_ape;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label apellidoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}