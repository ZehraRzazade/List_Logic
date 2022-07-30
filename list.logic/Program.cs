using System;

namespace list.logic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> numbers = new MyList<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            Console.WriteLine("the number of digits:" + numbers.Count);
            numbers.Show();
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _newArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add( T item)
        {
            _newArray = _array;
            _array = new T[_array.Length + 1];
            for(int i = 0; i < _newArray.Length; i++)
            {
                _array[i] = _newArray[i];
                
            }
            _array[_array.Length - 1] = item;

            
        }
        public int Count
        {
            get { return _array.Length; }
        }
        public  void Show()
        {
            for(int i=0;i<_array.Length; i++)
            {
                Console.WriteLine( "number-"+i+" "+_array[i]);
            }
        }
    }
}
