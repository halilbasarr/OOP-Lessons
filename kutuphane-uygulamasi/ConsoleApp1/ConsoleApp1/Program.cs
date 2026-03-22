using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    // 1. Interface (Arayüz) Kullanımı
    public interface IItem
    {
        string Title { get; set; }
        void GetInfo();
    }

    // 2. Base Class (Temel Sınıf) - Inheritance
    public abstract class LibraryItem : IItem
    {
        public string Title { get; set; }
        public int Year { get; set; }

        protected LibraryItem(string title, int year)
        {
            Title = title;
            Year = year;
        }

        public abstract void GetInfo(); // Polymorphism için abstract metod
    }

    // 3. Derived Class (Türetilmiş Sınıf)
    public class Book : LibraryItem
    {
        public string Author { get; set; }

        public Book(string title, string author, int year) : base(title, year)
        {
            Author = author;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"[Kitap] Başlık: {Title}, Yazar: {Author}, Yıl: {Year}");
        }
    }

    // 4. Koleksiyonlar ve Mantıksal İşlemler
    public class LibraryManager
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Title} kütüphaneye eklendi.");
        }

        public void ShowAllItems()
        {
            Console.WriteLine("\n--- Kütüphane Envanteri ---");
            foreach (var item in items)
            {
                item.GetInfo();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LibraryManager manager = new LibraryManager();

            // Nesne oluşturma
            manager.AddItem(new Book("Suç ve Ceza", "Dostoyevski", 1866));
            manager.AddItem(new Book("C# Notları", "Halil", 2026));

            // Listeleme
            manager.ShowAllItems();

            Console.WriteLine("\nÇıkış için bir tuşa basın...");
            Console.ReadKey();
        }
    }
}