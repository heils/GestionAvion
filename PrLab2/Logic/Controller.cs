using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrLab2.Logic{
    class Controller{
        Empresa obj_emp = new Empresa();
        Avion obj_avion = new Avion();
        public String register_new_emp(String nit, String name, String date){
            try{
                int newNit = int.Parse(nit);
                if(name.Equals("") || date.Equals("") || nit.Equals("")){
                    throw new Exception("Campos vacíos");
                }else{
                    if (obj_emp.register_new_emp(newNit, name, date)){
                        return "Empresa agregada con éxito";
                    }else{
                        return "Ocurrió un error al intentar agregar la empresa";
                    }
                }
            }
            catch (Exception e){
                return "Verifique los valores ingresados";
            }
        }
        public String register_new_avion(String serial, String marca, String tipo, String longitud, String paisEns, String fechaEns, String idEmpresa){
            try{
                int newSerial = int.Parse(serial);
                int newLong = int.Parse(longitud);
                int newIdEmp = int.Parse(idEmpresa);
                if (serial.Equals("") || marca.Equals("") || longitud.Equals("") || paisEns.Equals("") || fechaEns.Equals("") || idEmpresa.Equals("")){
                    throw new Exception("Campos vacíos");
                }
                else{
                    if(obj_avion.register_new_avion(newSerial, marca, tipo, newLong, paisEns, fechaEns, newIdEmp)){
                        return "Avión agregado con éxito";
                    }
                    else{
                        return "Ocurrió un error al intentar agregar el avión";
                    }
                }
            }
            catch (Exception e){
                return "Verifique los valores ingresados";
            }
        }
        public DataSet query_aviones(String idEmpresa){
            try{
                
                int newEmpresa = int.Parse(idEmpresa);
                DataSet aviones = new DataSet();
                aviones = obj_avion.query_aviones(newEmpresa);
                return aviones;
            }
            catch (Exception e){
                return null;
            }
           
        }
        public String delete_avion(String serial){
            try{
                int newSerial = int.Parse(serial);
                if (serial.Equals("")){
                    throw new Exception("Campos vacíos");
                }else{
                    if (obj_avion.delete_avion(newSerial)){
                        return "Avión eliminado con éxito";
                    }else{
                        return "Ocurrió un error al intentar eliminar el avión";
                    }
                }
            }catch(Exception e){
                return "Verifique los valores ingresados";
            }
        }
    }
}
