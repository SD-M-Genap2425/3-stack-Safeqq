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
        private LinkedListNode<Halaman> currentPage = null;

        public void KunjungiHalaman(string url)
        {
            var halamanBaru = new Halaman(url);
            if (currentPage != null)
            {
                var nextPages = currentPage.Next;
                while (nextPages != null)
                {
                    history.Remove(nextPages);
                    nextPages = nextPages.Next;
                }
            }
            history.AddLast(halamanBaru);
            currentPage = history.Last;
            Console.WriteLine($"Mengunjungi halaman: {url}");
        }

        public string Kembali()
        {
            if (currentPage?.Previous != null)
            {
                currentPage = currentPage.Previous;
                return currentPage.Value.URL;
            }
            else
            {
                return "Tidak ada halaman sebelumnya.";
            }
        }

        public string LihatHalamanSaatIni()
        {
            return currentPage?.Value.URL ?? "Tidak ada halaman yang dikunjungi.";
        }

        public void TampilkanHistory()
        {
            if (history.Count == 0)
            {
                Console.WriteLine("Tidak ada riwayat.");
                return;
            }

            Console.WriteLine("Menampilkan history:");
            var index = 1;
            foreach (var halaman in history.Reverse())
            {
                Console.WriteLine($"{index}. {halaman.URL}");
                index++;
            }
        }
    }
}