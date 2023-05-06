namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            List<string> sehirler = new List<string>();
            sehirler.Add("aa");
            Console.WriteLine(sehirler.Count);
            sehirler[0] = "ss";



            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("AAAAAAAAAAAAA");
            sehirler2.Add("ccccccccccccc");
            Console.WriteLine(sehirler2.Count);
            sehirler2[0] = "BBBBBBBBBBB";


            foreach (string s in sehirler2.Items) 
            { 
                Console.WriteLine(s);
            }
        }
    }


    class MyList<T>
    {

        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0]; 
        }
        public void Add(T item) 
        {
            
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for(int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }
            _array[_array.Length - 1 ] = item;
        }
        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items 
        { 
            get 
            { 
                return _array; 
            } 
        }

        public T this[int index] 
        {
            get 
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }




    }
}