namespace Backend_PruebaOdoo
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
            dataGridUsuarios = new DataGridView();
            botonConsulta = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            dataGridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridUsuarios.Location = new Point(399, 12);
            dataGridUsuarios.Name = "dataGridUsuarios";
            dataGridUsuarios.RowHeadersWidth = 62;
            dataGridUsuarios.Size = new Size(389, 426);
            dataGridUsuarios.TabIndex = 0;
            // 
            // botonConsulta
            // 
            botonConsulta.Location = new Point(67, 382);
            botonConsulta.Name = "botonConsulta";
            botonConsulta.Size = new Size(218, 56);
            botonConsulta.TabIndex = 1;
            botonConsulta.Text = "Consultar";
            botonConsulta.UseVisualStyleBackColor = true;
            botonConsulta.Click += botonConsulta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonConsulta);
            Controls.Add(dataGridUsuarios);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridUsuarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridUsuarios;
        private Button botonConsulta;
    }
}
