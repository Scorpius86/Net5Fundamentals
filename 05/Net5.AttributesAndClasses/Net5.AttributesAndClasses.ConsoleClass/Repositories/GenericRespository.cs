using Net5.AttributesAndClasses.ConsoleClass.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net5.AttributesAndClasses.ConsoleClass.Repositories
{
    public class GenericRespository<T>
    {
        public List<T> _items { get; set; }
        public GenericRespository()
        {
            _items = new List<T>();
        }
        public void Insert(T item)
        {
            _items.Add(item);
        }

        public void Delete(T item)
        {
            _items.Remove(item);
        }

        public void Update(T oldItem, T newItem)
        {
            _items.Remove(oldItem);
            _items.Add(newItem);
        }

        public List<T> List(){
            return _items;
        }

        public void DoWork<TT>(T param1, TT param2)
        {
            //Todo
        }
    }
}
