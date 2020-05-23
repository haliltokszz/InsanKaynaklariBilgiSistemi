using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariProje
{
    public class HashChain
    {
        int tableSize = 10;

        HashChainEntry[] table;

        public HashChain()
        {
            table = new HashChainEntry[tableSize];
            for (int i = 0; i < tableSize; i++)
                table[i] = null;
        }
        public void AddIlan(int key, object value)
        {
            int hash = (key % tableSize);
            if (table[hash] == null)
                table[hash] = new HashChainEntry(key, value);
            else
            {
                HashChainEntry entry = table[hash];
                while (entry.Next != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry.Anahtar == key)
                    entry.Deger = value;
                else
                    entry.Next = new HashChainEntry(key, value);
            }
        }
        public İlan GetIlan(int key)
        {
            int hash = (key % tableSize);
            if (table[hash] == null)
                return null;
            else
            {
                HashChainEntry entry = table[hash];
                while (entry != null && entry.Anahtar != key)
                    entry = entry.Next;
                if (entry == null)
                    return null;
                else
                    return (İlan)entry.Deger;
            }
        }

        public List<İlan> GetAll()
        {
            List<İlan> ilanlar = new List<İlan>();
            for(int i =0; i< tableSize; i++)
            {
                HashChainEntry entry = table[i];
                while (entry != null)
                {
                    ilanlar.Add((İlan)table[i].Deger);
                    entry = entry.Next;
                }
            }

            return ilanlar;
        }

        public İlan RemoveIlan(int key)
        {
            int hash = (key % tableSize);
            if (table[hash] == null)
                return null;
            else
            {
                HashChainEntry entry = table[hash];
                HashChainEntry previous = entry;
                while (entry.Next != null && entry.Anahtar != key)
                {
                    if (entry.Next.Anahtar == key)
                    {
                        previous = entry;
                    }
                    entry = entry.Next;
                }
                if (entry == null)
                    return null;
                else
                {
                    object temp = entry.Deger;
                    while (entry.Next != null)
                    {
                        entry.Anahtar = entry.Next.Anahtar;
                        entry.Deger = entry.Next.Deger;
                        if (entry.Next.Next != null)
                        {
                            entry.Next = entry.Next.Next;
                        }
                        else
                        {
                            entry.Next = null;
                            break;
                        }
                        entry = entry.Next;
                    }
                    if (previous == entry && entry.Next == null)
                    {
                        table[hash] = null;
                    }
                    else if (previous.Next.Next == null && previous.Next.Anahtar == key)
                        previous.Next = null;
                    return (İlan)temp;
                } 
            }
        }


    }
}
