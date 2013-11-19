using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Laboratorio
{
    public class fachadaregistrar
    {
        private static persistenciamateriales pers = new persistenciamaterialesoledb();

        public static void registrarmateriales(string nombre, int precioxunidad)
        {

            material m = new material();
            m.Nombrematerial = nombre;
            m.Precioxunidad = precioxunidad;
            pers.registrarmateriales(m);
        }
        private static persistenciaextraccion pers2 = new persistenciaextraccionoledb();
        public static void registrarextraccion(string cedula, string lugar, Boolean urgencia, Boolean azucar, Boolean colesterol, Boolean tsh, Boolean entrega, int costo, string encargado,string institucion)
        {
            extraccion e = new extraccion();
            e.Cedula = cedula;
            e.Lugar = lugar;
            e.Urgencia = urgencia;
            e.Azucar = azucar;
            e.Colesterol = colesterol;
            e.Tsh = tsh;            
            e.Entrega = entrega;
            e.Costo = costo;
            e.Encargado = encargado;
            e.Institucion = institucion;

            pers2.registrarextraccion(e);



        }

        private static persistenciainstitucion pers3 = new persistenciainstitucionoledb();
        public static void registrarinstitucion(string nombre, string mail, string telefono, string direccion)
        {

            institucion i = new institucion();
            i.Nombre = nombre;
            i.Mail = mail;
            i.Telefono = telefono;
            i.Direccion = direccion;
            pers3.registrarinstitucion(i);
        }

        private static persistenciacliente pers4 = new persistenciaclienteoledb();


        public static void registrarcliente(string cedula, string nombre, string direccion, string telefono, string email)
        {
            //pers.registrarcliente(cedula, nombre, direccion, telefono, email);
            clientes cli = new clientes();
            cli.Cedula = cedula;
            cli.Nombre = nombre;
            cli.Direccion = direccion;
            cli.Email = email;
            cli.Telefono = telefono;

            pers4.registrarcliente(cli);
        }

        public static PersistenciaEmpleado pers5 = new PersistenciaEmpleadoOleDb();

        public static void registrarempleado(string cedula, string nombre, string direccion, string telefono, string cargo)
        {
            Empleado em = new Empleado();
            em.Cedula = cedula;
            em.Nombre = nombre;
            em.Direccion = direccion;
            em.Telefono = telefono;
            em.Cargo = cargo;

            pers5.registrarempleado(em);
        }
    }
}