
// Task 5- Write a generic class GenericList<T> that keeps a list of elements of some parametric type T.
//         Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. 
//         Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, 
//        clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point3D
{
    
            public class GenericList<T>
            {
                
                private T[] elements;
                private int count = 0;

                public GenericList(int capacity)
                {
                    elements = new T[capacity];
                }
                
                public int Count
                {
                    get { return this.count; }
                }

                public void Add(T element) 
                {
                    if (count >= elements.Length)
                    {
                        AutoGrow();
                        
                    }

                    this.elements[count] = element;
                    count++;
                }

                private void AutoGrow()
                {
                    T[] newArr = new T[elements.Length * 2];
                    for (int i = 0; i < elements.Length; i++)
                    {
                        newArr[i] = elements[i];
                    }
                    elements = newArr;
                }


                public T this[int index]
                {
                    get
                    {
                        if (index >= count || index < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        T result = elements[index];
                        return result;
                    }
                }
                public void Remove(int ind)
                {
                       if (ind >= count || ind < 0)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                         T[] array = new T[elements.Length - 1];
                         for (int i = 0, j = 0; i < array.Length; i++, j++)
                         {
                             if (i == ind)
                             {
                                 j++;
                             }
                             array[i] = elements[j];
                         }
                         count--;
                         elements = array;
                    
                }
                public void Insert(T element,int index)
                {
                        if (index >= count)
                        {
                            throw new IndexOutOfRangeException(String.Format(
                                "Invalid index: {0}.", index));
                        }
                        T[] newArray = new T[elements.Length + 1];
                        for (int i = 0,j = 0 ; j < newArray.Length; i++,j++)
                        {
                            T temp = elements[i];
                            if (i==index)
                            {
                                j++;
                                newArray[i] = element;
                            }
                            newArray[j] = temp;
                        }
                        count++;
                        elements = newArray;
               }

                public void Clear()
                {

                }

                public void FindElement<T>(T element, GenericList<T> elements)
                {
                    for (int i = 0; i < elements.Count; i++)
                    {
                        if (elements[i].Equals(element))
                        {
                            Console.WriteLine("The element is at index: {0}", i);
                            return;
                        }
                    }
                    Console.WriteLine("No such element!");
                }
            }
    }

