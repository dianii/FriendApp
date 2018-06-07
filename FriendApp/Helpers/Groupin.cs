using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FriendApp.Helpers
{
    //Definimos clase K es por donde voy a agrupar ej N A, Lista tipo Find 
  public  class Groupin<K,T>: ObservableCollection<T>
    {
        public K Key { get; set; }
        public Groupin(K key, IEnumerable<T> items) {
            this.Key= Key;
            foreach (var item in items)
            {
                Items.Add(item);
            }
        }
    }
}
