using System;
using System.Collections.Generic;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL { get; set; }

        public Halaman(string url)
        {
            URL = url;
        }
    }
    public class HistoryManager
    {
        private LinkedList<Halaman> history = new LinkedList<Halaman>();
        private LinkedListNode<Halaman> current;
        public void KunjungiHalaman(string url)
        {
            var halaman = new Halaman(url);
            if (current != null)
            {
                var node = current.Next;
                while (node != null)
                {
                    var nextNode = node.Next;
                    history.Remove(node);
                    node = nextNode;
                }
            }

            history.AddLast(halaman);
            current = history.Last;
        }
        public string Kembali()
        {
            if (current?.Previous == null)
                return "Tidak ada halaman sebelumnya.";

            current = current.Previous;
            return current.Value.URL;
        }
        public string LihatHalamanSaatIni()
        {
            return current?.Value.URL ?? "Tidak ada halaman yang dikunjungi.";
        }
        public void TampilkanHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Tidak ada history.");
                return;
            }

            int index = 1;
            foreach (var halaman in history.Reverse())
            {
                Console.WriteLine($"{index}. {halaman.URL}");
                index++;
            }
        }
    }
}