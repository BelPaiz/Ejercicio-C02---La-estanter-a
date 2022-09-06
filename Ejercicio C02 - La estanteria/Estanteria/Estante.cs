using System.Text;

namespace Ejercicio_C02___La_estanteria.Estanteria
{
    internal class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        {
            _productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            _ubicacionEstante = ubicacion;
        }

        public Producto[] GetProducto()
        {
            return _productos;
        }

        static public string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Estante n° " + e._ubicacionEstante);

            for (int i = 0; i < e._productos.Length; i++)
            {
                sb.AppendLine(Producto.MostrarProducto(e._productos[i]).ToString());
            }
            return sb.ToString();
        }

        #region SOBRECARGAS

        public static bool operator ==(Estante e, Producto p)
        {
            bool result = false;
            for (int i = 0; i < e._productos.Length; i++)
            {
                if (e._productos[i] == p)
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            bool result = true;
            for (int i = 0; i < e._productos.Length; i++)
            {
                if ((e._productos[i] == p))
                {
                    result = false;
                }
            }
            return result;
        }

        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false;
            int len = e._productos.Length;
            if (e != p)
            {
                for (int i = 0; i < len; i++)
                {

                    if (e._productos[i] is null)
                    {
                        e._productos[i] = p;
                        retorno = true;
                        break;
                    }

                }
            }
                
            return retorno;
        }

        public static Estante operator -(Estante e, Producto p)
        {
            Producto buffer = new Producto("", "", 0);
            int len = e._productos.Length;
            for (int i = 0; i < len; i++)
            {
                if(e._productos[i] == p)
                {
                    e._productos[i] = buffer;
                }
            }
            return e;
        }

        #endregion


    }
}
