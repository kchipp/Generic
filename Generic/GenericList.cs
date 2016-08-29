using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericList<T> : IEnumerable<T>
    {
        T[] primaryList;

        public GenericList()//constructor
        {
            primaryList = new T[0];
        }

        public GenericList(T[] value)//overloaded constructor
        {
            this.primaryList = value;
        }

        public void Add(T item)
        {
            T[] temporaryList;
            temporaryList = new T[primaryList.Length + 1];
            for (int i = 0; i < primaryList.Length; i++)
            {
                temporaryList[i] = primaryList[i];
            }
            temporaryList[temporaryList.Length - 1] = item;
            primaryList = temporaryList;
        }


        public void Remove(T itemToRemove)

        {
            int counter = 0;
            T[] temporaryList;
            temporaryList = new T[primaryList.Length - 1];
            for (int i = 0; i < primaryList.Length; i++)
            {

                if (!primaryList[i].Equals(itemToRemove))
                {
                    temporaryList[counter] = primaryList[i];
                    counter++;
                }
            }
            primaryList = temporaryList;
        }
        public void Show()
        {
            foreach (var item in primaryList)
            {
                Console.WriteLine(item);
            }
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()

        {

            for (int i = 0; i < primaryList.Count(); i++)
            {
                yield return primaryList[i];
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            for (int i = 0; i < primaryList.Count(); i++)
            {
                yield return primaryList[i];
            }
        }

        public override string ToString()
        {
            string combineStrings = null;
            for (int i = 0; i < primaryList.Length; i++)
            {
                combineStrings += " " + primaryList[i];
            }
            return combineStrings;
        }

        public static GenericList<T> operator +(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> secondaryList = new GenericList<T>(new T[0]);
            for (int i = 0; i < firstItem.primaryList.Length; i++)
            {
                secondaryList.Add(firstItem.primaryList[i]);
            }

            for (int i = 0; i < secondItem.primaryList.Length; i++)
            {
                secondaryList.Add(secondItem.primaryList[i]);
            }
            return secondaryList;

        }

        public static GenericList<T> operator -(GenericList<T> firstItem, GenericList<T> secondItem)
        {
            GenericList<T> secondaryList = new GenericList<T>(new T[0]);
            secondaryList += firstItem;
            for (int i = 0; i < secondItem.primaryList.Length; i++)
            {
                secondaryList.Remove(secondItem.primaryList[i]);
            }
            return secondaryList;
        }


        public int Count
        {
            get
            {
                return primaryList.Length;
            }

        }

        public T GetItems(int item)
        {
            return primaryList[item];
        }

        public void Zipper(GenericList<T> listToZipper)
        {
            T[] tempList = new T[primaryList.Length];
            T[] tempList2 = new T[0];
            tempList = primaryList;
            primaryList = tempList2;
            for (int i = 0; i < tempList.Length || i < listToZipper.Count(); i++)
            {
                if (i < tempList.Length)
                {
                    Add(tempList[i]);
                }
                if (i < listToZipper.Count())
                {
                    Add(GetItems(i));
                }
            }
        }

    }//class
}//namespac
