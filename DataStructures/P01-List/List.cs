using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class List<T>
{
    public T[] basic = new T[0];

    public void Add(T element)
    {
        T[] oldArrayValues = basic;
        basic = new T[basic.Length + 1];
        Array.Copy(oldArrayValues, basic, oldArrayValues.Length);
        basic[basic.Length - 1] = element;
    }

    public int Count()
    {
        return basic.Length;
    }

    public void Insert(int index, T element)
    {
        if (index >= 0 && index < basic.Length)
        {
            T[] oldArrayValues = basic;
            basic = new T[basic.Length + 1];
            //TODO
        }
    }
    public T Get(int index)
    {
        if (index >= 0 && index < basic.Length)
        {
            return basic[index];
        }
        throw new IndexOutOfRangeException();
    }

}