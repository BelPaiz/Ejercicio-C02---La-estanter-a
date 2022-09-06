using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C02___La_estanteria.Estanteria
{
    internal class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

        public Producto(string marca, string codigo, float precio)
        {
            this._codigoDeBarra = codigo;
            this._marca = marca;
            this._precio = precio;
        }

        public string GetMarca()
        {
            return this._marca;
        }
        
        public float GetPrecio()
        {
            return this._precio;
        }

        static public string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            if(p is not null)
            {
                sb.AppendLine("Marca: " + p._marca);
                sb.AppendLine("Precio: " + p._precio);
                sb.AppendLine("Codigo: " + p._codigoDeBarra.ToString());
            }
            

            return sb.ToString();

        }

        #region SOBRECARGAS

        public static explicit operator string(Producto p)
        {
            return p._codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool result = false;
            if(p1 is not null && p2 is not null)
            {
                if (p1._marca == p2._marca)
                {
                    if (p1._codigoDeBarra == p2._codigoDeBarra)
                    {
                        result = true;
                    }
                }
            }
            
            return result;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool result = true;
            if (p1 is null && p2 is null || ((p1._marca == p2._marca) && (p1._codigoDeBarra == p2._codigoDeBarra)))
            {
                result = false;
            }

            return result;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool result = false;
            if (p._marca == marca)
            {
                result = true;
            }
            return result;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool result = false;
            if (!(p._marca == marca))
            {
                result = true;
            }
            return result;
        }

        #endregion

    }
}
