using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetasSLN.dominio
{
    internal class Receta
    {
        public string nombre_receta { get; set; }
        public string cheff { get; set; }

        public int id_receta { get; set; }
        public int tipo_receta { get; set; }
        List<Ingredientes> list = new List<Ingredientes>();

        public void cargar_lista(Ingredientes i)
        {
            list.Add(i);
        }
        public void vaciar_lista()
        {
            list.Clear();
        }
        public List<Ingredientes> RetornarLista()
        {
            return list;
        }
        public bool buscar_list(Ingredientes a)
        {
            for (int i = 0; i <list.Count; i++)
            {
                if (list[i].id_ingrediente == a.id_ingrediente)
                {
                    return true;
                }
            }
            return false;
        }
        public void actualizar_lista(Ingredientes a)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].id_ingrediente == a.id_ingrediente)
                {
                    list[i].cantidad += a.cantidad;
                }
            }
        }
        public void eliminar(int i)
        {
            list.Remove(list[i]);
        }
    }
}
