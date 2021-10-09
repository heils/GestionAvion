using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrLab2.Data;

namespace PrLab2.Logic{
    class Avion{
        DataB dt = new DataB();
        public Boolean register_new_avion (int serial, String marca, String tipo, int longitud, String paisEns, String fechaEns, int idEmpresa){
            return dt.reg_avion(serial,marca,tipo,longitud,paisEns,fechaEns,idEmpresa);
        }
        public DataSet query_aviones(int idEmpresa){
            DataSet aviones = new DataSet();
            aviones = dt.query_aviones(idEmpresa);
            return aviones;
        }
        public Boolean delete_avion(int serial){
            return dt.delete_avion(serial);
        }
    }
}
