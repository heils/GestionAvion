
using System.Windows.Forms;

namespace PrLab2
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
            this.tbControlMain = new System.Windows.Forms.TabControl();
            this.tbpRegEmp = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRegEmp = new System.Windows.Forms.DateTimePicker();
            this.txtNameEmp = new System.Windows.Forms.TextBox();
            this.txtNitEmp = new System.Windows.Forms.TextBox();
            this.btnAgregarEmpresa = new System.Windows.Forms.Button();
            this.tbpRegAvion = new System.Windows.Forms.TabPage();
            this.dtpRegAvion = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarAvion = new System.Windows.Forms.Button();
            this.txtIdEmpresaAvion = new System.Windows.Forms.TextBox();
            this.txtPaisEnsambleAvion = new System.Windows.Forms.TextBox();
            this.cbxTipoAvion = new System.Windows.Forms.ComboBox();
            this.txtLongitudAvion = new System.Windows.Forms.TextBox();
            this.txtMarcaAvion = new System.Windows.Forms.TextBox();
            this.txtSerialAvion = new System.Windows.Forms.TextBox();
            this.tbpConsultarAviones = new System.Windows.Forms.TabPage();
            this.dtgvAviones = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConsultarAviones = new System.Windows.Forms.Button();
            this.tbpEliminarAvion = new System.Windows.Forms.TabPage();
            this.btnBorrarAvion = new System.Windows.Forms.Button();
            this.txtBorrarAvion = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbControlMain.SuspendLayout();
            this.tbpRegEmp.SuspendLayout();
            this.tbpRegAvion.SuspendLayout();
            this.tbpConsultarAviones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAviones)).BeginInit();
            this.tbpEliminarAvion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControlMain
            // 
            this.tbControlMain.Controls.Add(this.tbpRegEmp);
            this.tbControlMain.Controls.Add(this.tbpRegAvion);
            this.tbControlMain.Controls.Add(this.tbpConsultarAviones);
            this.tbControlMain.Controls.Add(this.tbpEliminarAvion);
            this.tbControlMain.Location = new System.Drawing.Point(15, 18);
            this.tbControlMain.Name = "tbControlMain";
            this.tbControlMain.SelectedIndex = 0;
            this.tbControlMain.Size = new System.Drawing.Size(816, 456);
            this.tbControlMain.TabIndex = 0;
            // 
            // tbpRegEmp
            // 
            this.tbpRegEmp.Controls.Add(this.label3);
            this.tbpRegEmp.Controls.Add(this.label2);
            this.tbpRegEmp.Controls.Add(this.label1);
            this.tbpRegEmp.Controls.Add(this.dtpRegEmp);
            this.tbpRegEmp.Controls.Add(this.txtNameEmp);
            this.tbpRegEmp.Controls.Add(this.txtNitEmp);
            this.tbpRegEmp.Controls.Add(this.btnAgregarEmpresa);
            this.tbpRegEmp.Location = new System.Drawing.Point(4, 22);
            this.tbpRegEmp.Name = "tbpRegEmp";
            this.tbpRegEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegEmp.Size = new System.Drawing.Size(808, 430);
            this.tbpRegEmp.TabIndex = 0;
            this.tbpRegEmp.Text = "Registrar Empresa:";
            this.tbpRegEmp.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Seleccione la fecha de creación de la empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Digíte el NIT de la empresa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digíte el nombre de la empresa:";
            // 
            // dtpRegEmp
            // 
            this.dtpRegEmp.Location = new System.Drawing.Point(337, 211);
            this.dtpRegEmp.Name = "dtpRegEmp";
            this.dtpRegEmp.Size = new System.Drawing.Size(154, 20);
            this.dtpRegEmp.TabIndex = 4;
            // 
            // txtNameEmp
            // 
            this.txtNameEmp.Location = new System.Drawing.Point(336, 142);
            this.txtNameEmp.Name = "txtNameEmp";
            this.txtNameEmp.Size = new System.Drawing.Size(155, 20);
            this.txtNameEmp.TabIndex = 3;
            // 
            // txtNitEmp
            // 
            this.txtNitEmp.Location = new System.Drawing.Point(336, 81);
            this.txtNitEmp.Name = "txtNitEmp";
            this.txtNitEmp.Size = new System.Drawing.Size(155, 20);
            this.txtNitEmp.TabIndex = 1;
            // 
            // btnAgregarEmpresa
            // 
            this.btnAgregarEmpresa.Location = new System.Drawing.Point(358, 298);
            this.btnAgregarEmpresa.Name = "btnAgregarEmpresa";
            this.btnAgregarEmpresa.Size = new System.Drawing.Size(111, 43);
            this.btnAgregarEmpresa.TabIndex = 0;
            this.btnAgregarEmpresa.Text = "Agregar";
            this.btnAgregarEmpresa.UseVisualStyleBackColor = true;
            this.btnAgregarEmpresa.Click += new System.EventHandler(this.register_Click);
            // 
            // tbpRegAvion
            // 
            this.tbpRegAvion.Controls.Add(this.dtpRegAvion);
            this.tbpRegAvion.Controls.Add(this.label10);
            this.tbpRegAvion.Controls.Add(this.label9);
            this.tbpRegAvion.Controls.Add(this.label8);
            this.tbpRegAvion.Controls.Add(this.label7);
            this.tbpRegAvion.Controls.Add(this.label6);
            this.tbpRegAvion.Controls.Add(this.label5);
            this.tbpRegAvion.Controls.Add(this.label4);
            this.tbpRegAvion.Controls.Add(this.btnAgregarAvion);
            this.tbpRegAvion.Controls.Add(this.txtIdEmpresaAvion);
            this.tbpRegAvion.Controls.Add(this.txtPaisEnsambleAvion);
            this.tbpRegAvion.Controls.Add(this.cbxTipoAvion);
            this.tbpRegAvion.Controls.Add(this.txtLongitudAvion);
            this.tbpRegAvion.Controls.Add(this.txtMarcaAvion);
            this.tbpRegAvion.Controls.Add(this.txtSerialAvion);
            this.tbpRegAvion.Location = new System.Drawing.Point(4, 22);
            this.tbpRegAvion.Name = "tbpRegAvion";
            this.tbpRegAvion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegAvion.Size = new System.Drawing.Size(808, 430);
            this.tbpRegAvion.TabIndex = 1;
            this.tbpRegAvion.Text = "Registrar Avión";
            this.tbpRegAvion.UseVisualStyleBackColor = true;
            // 
            // dtpRegAvion
            // 
            this.dtpRegAvion.Location = new System.Drawing.Point(367, 259);
            this.dtpRegAvion.Name = "dtpRegAvion";
            this.dtpRegAvion.Size = new System.Drawing.Size(154, 20);
            this.dtpRegAvion.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(184, 299);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Digíte el id de la empresa del avión:\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(171, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Digíte la fecha de ensamble del avión:\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(177, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Digíte el país de ensamble del avión:\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Digíte la longitud del avión:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione el tipo del avión:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Digíte la marca del avión:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Digíte el serial del avión:\r\n";
            // 
            // btnAgregarAvion
            // 
            this.btnAgregarAvion.Location = new System.Drawing.Point(390, 351);
            this.btnAgregarAvion.Name = "btnAgregarAvion";
            this.btnAgregarAvion.Size = new System.Drawing.Size(111, 43);
            this.btnAgregarAvion.TabIndex = 9;
            this.btnAgregarAvion.Text = "Agregar";
            this.btnAgregarAvion.UseVisualStyleBackColor = true;
            this.btnAgregarAvion.Click += new System.EventHandler(this.btnAgregarAvion_Click);
            // 
            // txtIdEmpresaAvion
            // 
            this.txtIdEmpresaAvion.Location = new System.Drawing.Point(366, 296);
            this.txtIdEmpresaAvion.Name = "txtIdEmpresaAvion";
            this.txtIdEmpresaAvion.Size = new System.Drawing.Size(155, 20);
            this.txtIdEmpresaAvion.TabIndex = 8;
            // 
            // txtPaisEnsambleAvion
            // 
            this.txtPaisEnsambleAvion.Location = new System.Drawing.Point(366, 216);
            this.txtPaisEnsambleAvion.Name = "txtPaisEnsambleAvion";
            this.txtPaisEnsambleAvion.Size = new System.Drawing.Size(155, 20);
            this.txtPaisEnsambleAvion.TabIndex = 6;
            // 
            // cbxTipoAvion
            // 
            this.cbxTipoAvion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoAvion.FormattingEnabled = true;
            this.cbxTipoAvion.Items.AddRange(new object[] {
            "Comercial",
            "Carga",
            "Militar"});
            this.cbxTipoAvion.Location = new System.Drawing.Point(366, 137);
            this.cbxTipoAvion.Name = "cbxTipoAvion";
            this.cbxTipoAvion.Size = new System.Drawing.Size(155, 21);
            this.cbxTipoAvion.TabIndex = 5;
            // 
            // txtLongitudAvion
            // 
            this.txtLongitudAvion.Location = new System.Drawing.Point(366, 176);
            this.txtLongitudAvion.Name = "txtLongitudAvion";
            this.txtLongitudAvion.Size = new System.Drawing.Size(155, 20);
            this.txtLongitudAvion.TabIndex = 4;
            // 
            // txtMarcaAvion
            // 
            this.txtMarcaAvion.Location = new System.Drawing.Point(366, 94);
            this.txtMarcaAvion.Name = "txtMarcaAvion";
            this.txtMarcaAvion.Size = new System.Drawing.Size(155, 20);
            this.txtMarcaAvion.TabIndex = 3;
            // 
            // txtSerialAvion
            // 
            this.txtSerialAvion.Location = new System.Drawing.Point(366, 52);
            this.txtSerialAvion.Name = "txtSerialAvion";
            this.txtSerialAvion.Size = new System.Drawing.Size(155, 20);
            this.txtSerialAvion.TabIndex = 2;
            // 
            // tbpConsultarAviones
            // 
            this.tbpConsultarAviones.Controls.Add(this.dtgvAviones);
            this.tbpConsultarAviones.Controls.Add(this.label11);
            this.tbpConsultarAviones.Controls.Add(this.btnConsultarAviones);
            this.tbpConsultarAviones.Location = new System.Drawing.Point(4, 22);
            this.tbpConsultarAviones.Name = "tbpConsultarAviones";
            this.tbpConsultarAviones.Size = new System.Drawing.Size(808, 430);
            this.tbpConsultarAviones.TabIndex = 2;
            this.tbpConsultarAviones.Text = "Consultar Aviónes";
            this.tbpConsultarAviones.UseVisualStyleBackColor = true;
            // 
            // dtgvAviones
            // 
            this.dtgvAviones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAviones.Location = new System.Drawing.Point(20, 131);
            this.dtgvAviones.Name = "dtgvAviones";
            this.dtgvAviones.Size = new System.Drawing.Size(762, 258);
            this.dtgvAviones.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(307, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(188, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "CONSULTAR TODOS LOS AVIÓNES";
            // 
            // btnConsultarAviones
            // 
            this.btnConsultarAviones.Location = new System.Drawing.Point(348, 82);
            this.btnConsultarAviones.Name = "btnConsultarAviones";
            this.btnConsultarAviones.Size = new System.Drawing.Size(111, 43);
            this.btnConsultarAviones.TabIndex = 10;
            this.btnConsultarAviones.Text = "Consultar";
            this.btnConsultarAviones.UseVisualStyleBackColor = true;
            this.btnConsultarAviones.Click += new System.EventHandler(this.btnConsultarAviones_Click);
            // 
            // tbpEliminarAvion
            // 
            this.tbpEliminarAvion.Controls.Add(this.btnBorrarAvion);
            this.tbpEliminarAvion.Controls.Add(this.txtBorrarAvion);
            this.tbpEliminarAvion.Controls.Add(this.label12);
            this.tbpEliminarAvion.Location = new System.Drawing.Point(4, 22);
            this.tbpEliminarAvion.Name = "tbpEliminarAvion";
            this.tbpEliminarAvion.Size = new System.Drawing.Size(808, 430);
            this.tbpEliminarAvion.TabIndex = 3;
            this.tbpEliminarAvion.Text = "Eliminar Avión";
            this.tbpEliminarAvion.UseVisualStyleBackColor = true;
            // 
            // btnBorrarAvion
            // 
            this.btnBorrarAvion.Location = new System.Drawing.Point(381, 223);
            this.btnBorrarAvion.Name = "btnBorrarAvion";
            this.btnBorrarAvion.Size = new System.Drawing.Size(111, 43);
            this.btnBorrarAvion.TabIndex = 11;
            this.btnBorrarAvion.Text = "Borrar";
            this.btnBorrarAvion.UseVisualStyleBackColor = true;
            this.btnBorrarAvion.Click += new System.EventHandler(this.btnBorrarAvion_Click);
            // 
            // txtBorrarAvion
            // 
            this.txtBorrarAvion.Location = new System.Drawing.Point(360, 155);
            this.txtBorrarAvion.Name = "txtBorrarAvion";
            this.txtBorrarAvion.Size = new System.Drawing.Size(155, 20);
            this.txtBorrarAvion.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(192, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Digíte el serial del avión a borrar:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 491);
            this.Controls.Add(this.tbControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestión";
            this.tbControlMain.ResumeLayout(false);
            this.tbpRegEmp.ResumeLayout(false);
            this.tbpRegEmp.PerformLayout();
            this.tbpRegAvion.ResumeLayout(false);
            this.tbpRegAvion.PerformLayout();
            this.tbpConsultarAviones.ResumeLayout(false);
            this.tbpConsultarAviones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAviones)).EndInit();
            this.tbpEliminarAvion.ResumeLayout(false);
            this.tbpEliminarAvion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbControlMain;
        private System.Windows.Forms.TabPage tbpRegEmp;
        private System.Windows.Forms.TabPage tbpRegAvion;
        private System.Windows.Forms.TabPage tbpConsultarAviones;
        private System.Windows.Forms.TabPage tbpEliminarAvion;
        private System.Windows.Forms.TextBox txtNameEmp;
        private System.Windows.Forms.TextBox txtNitEmp;
        private System.Windows.Forms.Button btnAgregarEmpresa;
        private System.Windows.Forms.DateTimePicker dtpRegEmp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarAvion;
        private System.Windows.Forms.TextBox txtIdEmpresaAvion;
        private System.Windows.Forms.TextBox txtPaisEnsambleAvion;
        private System.Windows.Forms.ComboBox cbxTipoAvion;
        private System.Windows.Forms.TextBox txtLongitudAvion;
        private System.Windows.Forms.TextBox txtMarcaAvion;
        private System.Windows.Forms.TextBox txtSerialAvion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DateTimePicker dtpRegAvion;
        private Label label11;
        private Button btnConsultarAviones;
        private DataGridView dtgvAviones;
        private Button btnBorrarAvion;
        private TextBox txtBorrarAvion;
        private Label label12;
    }
}

