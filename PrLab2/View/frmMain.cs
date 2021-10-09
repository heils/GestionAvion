using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrLab2.Logic;

namespace PrLab2{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
            this.dtpRegEmp.Format = DateTimePickerFormat.Custom;
            this.dtpRegEmp.CustomFormat = "dd-MMM-yy";
            this.dtpRegAvion.Format = DateTimePickerFormat.Custom;
            this.dtpRegAvion.CustomFormat = "dd-MMM-yy";
        }
        Controller obj_cont = new Controller();
        private void register_Click(object sender, EventArgs e){
            MessageBox.Show(obj_cont.register_new_emp(this.txtNitEmp.Text, this.txtNameEmp.Text, this.dtpRegEmp.Text));
            clear_txt("1");
        }
        private void btnAgregarAvion_Click(object sender, EventArgs e){
            MessageBox.Show(obj_cont.register_new_avion(this.txtSerialAvion.Text, this.txtMarcaAvion.Text, this.cbxTipoAvion.SelectedItem.ToString(),
                this.txtLongitudAvion.Text,this.txtPaisEnsambleAvion.Text,this.dtpRegAvion.Text, this.txtIdEmpresaAvion.Text));
            clear_txt("0");
        }
        private void btnConsultarAviones_Click(object sender, EventArgs e){
            DataSet dt = new DataSet();
            dt = obj_cont.query_aviones(this.txtNitAvionBuscar.Text);
            this.dtgvAviones.DataSource = dt;
            this.dtgvAviones.DataMember = "Aviones";
        }
        private void btnBorrarAvion_Click(object sender, EventArgs e){
            MessageBox.Show(obj_cont.delete_avion(this.txtBorrarAvion.Text));
            this.txtBorrarAvion.ResetText();
        }
        public void clear_txt(String proc){
            if (proc.Equals("1")){
                this.txtNitEmp.ResetText();
                this.txtNameEmp.ResetText();
            }else{
                this.txtSerialAvion.ResetText();
                this.txtMarcaAvion.ResetText();
                this.txtLongitudAvion.ResetText();
                this.txtPaisEnsambleAvion.ResetText();
                this.txtIdEmpresaAvion.ResetText();
            }
        }
    }
}
