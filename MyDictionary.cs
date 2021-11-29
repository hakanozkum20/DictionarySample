namespace DictionarySample
{
    public class MyDictionary<T>
    {
        T[] items;

        public MyDictionary()
        {
            items = new T[0];
        }

        public void Add(T item)
        {
            T[] temp =  items;
            items = new T[items.Length +1];
            for (var i = 0; i < temp.Length; i++)
            {
                items[i] = temp[i];
            }

            items[items.Length -1] = item;
            System.Console.WriteLine(items[items.Length-1]);
        }
    }
}