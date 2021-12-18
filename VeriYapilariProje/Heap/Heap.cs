using System;
using System.Collections.Generic;
using VeriYapilariProje.Entities;

namespace VeriYapilariProje.Heap
{
    public class Heap
    {

        private List<HeapDugumu> heapArray;
        private int currentSize;
        public Heap()
        {
            heapArray = new List<HeapDugumu>();
            currentSize = 0;
        }
        public bool IsEmpty()
        {
            return currentSize == 0;
        }
        public bool Insert(Kisi eklenecekKisi)
        {
            foreach(HeapDugumu heapDugumu in heapArray)
            {
                if (heapDugumu != null)
                {
                    if (heapDugumu.kisi == eklenecekKisi)
                    {
                        return false;
                    }
                }
            }
            HeapDugumu newHeapDugumu = new HeapDugumu(eklenecekKisi);
            heapArray.Add(newHeapDugumu);
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && heapArray[parent].Deger < bottom.Deger)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            heapArray.Remove(heapArray[currentSize]);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && heapArray[leftChild].Deger < heapArray[rightChild].Deger)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.Deger >= heapArray[largerChild].Deger)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }

        public double UygunlukPuani(Kisi kisi) {
            foreach(HeapDugumu heapDugumu in heapArray)
            {
                if(heapDugumu.kisi == kisi)
                {
                    return heapDugumu.Deger;
                }
            }
            return 0;
        }
        public void DisplayHeap()
        {
            Console.WriteLine();
            Console.Write("Heap içerisindeki elemanlar: ");
            for (int m = 0; m < currentSize; m++)
                if (heapArray[m] != null)
                    Console.Write(heapArray[m].Deger + " ");
                else
                    Console.Write("-- ");
            Console.WriteLine();
            int emptyLeaf = 32;
            int itemsPerRow = 1;
            int column = 0;
            int j = 0;
            String separator = "...............................";
            Console.WriteLine(separator + separator);
            while (currentSize > 0)
            {
                if (column == 0)
                    for (int k = 0; k < emptyLeaf; k++)
                        Console.Write(' ');
                Console.Write(heapArray[j].Deger);

                if (++j == currentSize)
                    break;
                if (++column == itemsPerRow)
                {
                    emptyLeaf /= 2;
                    itemsPerRow *= 2;
                    column = 0;
                    Console.WriteLine();
                }
                else
                    for (int k = 0; k < emptyLeaf * 2 - 2; k++)
                        Console.Write(' ');
            }
            Console.WriteLine("\n" + separator + separator);
        }

        public List<Kisi> AdaylariListele()
        {
            List<Kisi> adaylar = new List<Kisi>();
            for(int i=0; i<currentSize; i++)
            {
                if (heapArray[i] != null)
                    adaylar.Add(heapArray[i].kisi);
            }
            return adaylar;
        }
    }
}
