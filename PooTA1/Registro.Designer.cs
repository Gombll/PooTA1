namespace PooTA1
{
    partial class Registro
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxDNI = new TextBox();
            textBoxNombre = new TextBox();
            textBoxEdad = new TextBox();
            textBoxDireccion = new TextBox();
            buttonInsertar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            dataGridViewDatos = new DataGridView();
            DNI = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Edad = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(177, 57);
            label1.Name = "label1";
            label1.Size = new Size(95, 24);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(47, 57);
            label2.Name = "label2";
            label2.Size = new Size(47, 24);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(308, 57);
            label3.Name = "label3";
            label3.Size = new Size(63, 24);
            label3.TabIndex = 2;
            label3.Text = "Edad";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(424, 57);
            label4.Name = "label4";
            label4.Size = new Size(107, 24);
            label4.TabIndex = 3;
            label4.Text = "Direccion";
            label4.Click += label4_Click;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(47, 102);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(100, 23);
            textBoxDNI.TabIndex = 4;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(177, 102);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(100, 23);
            textBoxNombre.TabIndex = 5;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(308, 102);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(100, 23);
            textBoxEdad.TabIndex = 6;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(424, 102);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(293, 23);
            textBoxDireccion.TabIndex = 7;
            // 
            // buttonInsertar
            // 
            buttonInsertar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonInsertar.Location = new Point(47, 155);
            buttonInsertar.Name = "buttonInsertar";
            buttonInsertar.Size = new Size(100, 32);
            buttonInsertar.TabIndex = 8;
            buttonInsertar.Text = "Insertar";
            buttonInsertar.UseVisualStyleBackColor = true;
            buttonInsertar.Click += button1_Click;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonActualizar.Location = new Point(177, 155);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(100, 32);
            buttonActualizar.TabIndex = 9;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonEliminar.Location = new Point(308, 155);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(100, 32);
            buttonEliminar.TabIndex = 10;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { DNI, Nombre, Edad, Direccion });
            dataGridViewDatos.GridColor = SystemColors.MenuHighlight;
            dataGridViewDatos.Location = new Point(47, 215);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(669, 211);
            dataGridViewDatos.TabIndex = 11;
            dataGridViewDatos.CellContentClick += dataGridView1_CellContentClick;
            // 
            // DNI
            // 
            DNI.HeaderText = "DNI";
            DNI.Name = "DNI";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Edad
            // 
            Edad.HeaderText = "Edad";
            Edad.Name = "Edad";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(745, 450);
            Controls.Add(dataGridViewDatos);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonInsertar);
            Controls.Add(textBoxDireccion);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDNI);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxDNI;
        private TextBox textBoxNombre;
        private TextBox textBoxEdad;
        private TextBox textBoxDireccion;
        private Button buttonInsertar;
        private Button buttonActualizar;
        private Button buttonEliminar;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Edad;
        private DataGridViewTextBoxColumn Direccion;
    }
}