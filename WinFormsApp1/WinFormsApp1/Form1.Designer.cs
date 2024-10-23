namespace WinFormsApp1
{
    partial class Form1
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
            txtNombreCliente = new TextBox();
            label2 = new Label();
            txtNumeroTel = new TextBox();
            label3 = new Label();
            txtCorreoElectronico = new TextBox();
            button1 = new Button();
            dgvCliente = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCliente).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(12, 27);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(172, 23);
            txtNombreCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 2;
            label2.Text = "Número de Télefono";
            // 
            // txtNumeroTel
            // 
            txtNumeroTel.Location = new Point(12, 71);
            txtNumeroTel.Name = "txtNumeroTel";
            txtNumeroTel.Size = new Size(172, 23);
            txtNumeroTel.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 4;
            label3.Text = "Correo Electronico";
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Location = new Point(12, 115);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(172, 23);
            txtCorreoElectronico.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(64, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvCliente
            // 
            dgvCliente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCliente.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvCliente.Location = new Point(212, 9);
            dgvCliente.Name = "dgvCliente";
            dgvCliente.RowTemplate.Height = 25;
            dgvCliente.Size = new Size(378, 117);
            dgvCliente.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Número Télefono";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Correo Electronico";
            Column3.Name = "Column3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvCliente);
            Controls.Add(button1);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(label3);
            Controls.Add(txtNumeroTel);
            Controls.Add(label2);
            Controls.Add(txtNombreCliente);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvCliente).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombreCliente;
        private Label label2;
        private TextBox txtNumeroTel;
        private Label label3;
        private TextBox txtCorreoElectronico;
        private Button button1;
        private DataGridView dgvCliente;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}