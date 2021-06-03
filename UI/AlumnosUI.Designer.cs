
namespace OrangeSchoolMiguelPerez.UI
{
    partial class AlumnosUI
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bonoInput = new System.Windows.Forms.TextBox();
            this.adicionalInput = new System.Windows.Forms.TextBox();
            this.resultInput = new System.Windows.Forms.TextBox();
            this.alumnosBox = new System.Windows.Forms.ComboBox();
            this.manageButton = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Alumnos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Bono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Adicional:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Resultado:";
            // 
            // bonoInput
            // 
            this.bonoInput.Location = new System.Drawing.Point(160, 123);
            this.bonoInput.Name = "bonoInput";
            this.bonoInput.ReadOnly = true;
            this.bonoInput.Size = new System.Drawing.Size(221, 20);
            this.bonoInput.TabIndex = 20;
            // 
            // adicionalInput
            // 
            this.adicionalInput.Location = new System.Drawing.Point(160, 154);
            this.adicionalInput.Name = "adicionalInput";
            this.adicionalInput.ReadOnly = true;
            this.adicionalInput.Size = new System.Drawing.Size(221, 20);
            this.adicionalInput.TabIndex = 21;
            // 
            // resultInput
            // 
            this.resultInput.Location = new System.Drawing.Point(18, 202);
            this.resultInput.Name = "resultInput";
            this.resultInput.ReadOnly = true;
            this.resultInput.Size = new System.Drawing.Size(363, 20);
            this.resultInput.TabIndex = 22;
            // 
            // alumnosBox
            // 
            this.alumnosBox.FormattingEnabled = true;
            this.alumnosBox.Location = new System.Drawing.Point(160, 96);
            this.alumnosBox.Name = "alumnosBox";
            this.alumnosBox.Size = new System.Drawing.Size(221, 21);
            this.alumnosBox.TabIndex = 23;
            this.alumnosBox.SelectedIndexChanged += new System.EventHandler(this.setInputs);
            // 
            // manageButton
            // 
            this.manageButton.Location = new System.Drawing.Point(18, 256);
            this.manageButton.Name = "manageButton";
            this.manageButton.Size = new System.Drawing.Size(363, 23);
            this.manageButton.TabIndex = 24;
            this.manageButton.Text = "Gestionar Alumnos";
            this.manageButton.UseVisualStyleBackColor = true;
            this.manageButton.Click += new System.EventHandler(this.manageButton_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(302, 67);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 25;
            this.refreshBtn.Text = "Actualizar";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshButton);
            // 
            // AlumnosUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 390);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.manageButton);
            this.Controls.Add(this.alumnosBox);
            this.Controls.Add(this.resultInput);
            this.Controls.Add(this.adicionalInput);
            this.Controls.Add(this.bonoInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AlumnosUI";
            this.Text = "AlumnosUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bonoInput;
        private System.Windows.Forms.TextBox adicionalInput;
        private System.Windows.Forms.TextBox resultInput;
        private System.Windows.Forms.ComboBox alumnosBox;
        private System.Windows.Forms.Button manageButton;
        private System.Windows.Forms.Button refreshBtn;
    }
}