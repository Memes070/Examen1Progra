using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1Progra
{
    class Vehiculos
    {

        private string codigo, marca, costo, modelo;


        public Vehiculos(string codigo, string marca, string costo, string modelo)
        {
            setCodigo(codigo);
            setMarca(marca);
            setCosto(costo);
            setModelo(modelo);
        }
        public void setCodigo(string n) { codigo = n; }
        public void setMarca(string a) { marca = a; }
        public void setCosto(string c) { costo = c; }
        public void setModelo(string m) { modelo = m; }

        public string getCodigo() { return codigo; }
        public string getMarca() { return marca; }
        public string getCosto() { return costo; }
        public string getModelo() { return modelo; }


        public void mostarVehiculo()
        {
            Console.WriteLine("\nCodigo: " + getCodigo() + "\nMarca: " + getMarca() + "\nCosto : " + getCosto() + "\n Modelo: " + getModelo());
        }
    }
   