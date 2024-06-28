using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PooTA1
{
    internal class Persona
    {
        public int DNI, edad;
        public string Nombre, Direccion;

        public Persona(int DNI, int edad, string nombre, string direccion)
        {
            this.DNI = DNI;
            this.edad = edad;
            Nombre = nombre;
            Direccion = direccion;
        }
    }

    public class JsonArchivo<T>
    {
        public List<T> valores = new List<T>();
        public string ruta;

        public JsonArchivo(string r)
        {
            ruta = r;
        }

        public void Guardar()
        {
            string texto = JsonConvert.SerializeObject(valores);
            File.WriteAllText(ruta, texto);
        }

        public void Cargar()
        {
            try
            {
                string archivo = File.ReadAllText(ruta);
                valores = JsonConvert.DeserializeObject<List<T>>(archivo);
            }
            catch (Exception) { }
        }

        public void Insertar(T nuevo)
        {
            valores.Add(nuevo);
            Guardar();
        }

        public List<T> Buscar(Func<T, bool> criterio)
        {
            return valores.Where(criterio).ToList();
        }

        public void Eliminar(Func<T, bool> criterio)
        {
            valores = valores.Where(x => !criterio(x)).ToList();
        }

        public void Actualizar(Func<T, bool> criterio, T nuevo)
        {
            valores = valores.Select(x =>
            {
                if (criterio(x)) x = nuevo;
                return x;
            }).ToList();
        }
    }
}