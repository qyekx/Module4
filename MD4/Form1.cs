using System;
using System.Collections.Generic;
using System.Drawing;  
using System.Windows.Forms;

namespace BookLibraryApp
{
    // Интерфейс IBook для книг
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        bool IsAvailable { get; }
        void Checkout();
        void Return();
    }

    // Класс художественной литературы
    public class FictionBook : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; }

        public FictionBook(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void Checkout()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                MessageBox.Show($"Книга '{Title}' была выдана.");
            }
            else
            {
                MessageBox.Show($"Книга '{Title}' недоступна для выдачи.");
            }
        }

        public void Return()
        {
            IsAvailable = true;
            MessageBox.Show($"Книга '{Title}' была возвращена.");
        }
    }

    // Класс научной литературы
    public class ScienceBook : IBook
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public bool IsAvailable { get; private set; }

        public ScienceBook(string title, string author)
        {
            Title = title;
            Author = author;
            IsAvailable = true;
        }

        public void Checkout()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                MessageBox.Show($"Книга '{Title}' была выдана.");
            }
            else
            {
                MessageBox.Show($"Книга '{Title}' недоступна для выдачи.");
            }
        }

        public void Return()
        {
            IsAvailable = true;
            MessageBox.Show($"Книга '{Title}' была возвращена.");
        }
    }

    // Основная форма для управления библиотекой
    public partial class Form1 : Form
    {
        private List<IBook> books;

        public Form1()
        {
            InitializeComponent();
            LoadBooks();
            UpdateBookList();
            ApplyDesign(); // Применяем новый дизайн
            SetupAnchors(); // Настройка растягивания интерфейса
        }

        // Метод для загрузки списка книг
        // Метод для загрузки списка книг
        // Метод для загрузки списка книг
        private void LoadBooks()
        {
            books = new List<IBook>
    {
        new FictionBook("Тихий Дон", "Михаил Шолохов"),
        new FictionBook("Мастер и Маргарита", "Михаил Булгаков"),
        new FictionBook("Двенадцать стульев", "Илья Ильф и Евгений Петров"),
        new FictionBook("А зори здесь тихие", "Борис Васильев"),
        new FictionBook("Собачье сердце", "Михаил Булгаков"),
        new FictionBook("Остров Крым", "Василий Аксёнов"),
        new FictionBook("Старик и море", "Эрнест Хемингуэй"), 
        new FictionBook("Шинель", "Николай Гоголь"),
        new FictionBook("Невский проспект", "Николай Гоголь"),
        new FictionBook("Дети Арбата", "Анатолий Рыбаков"),
        new FictionBook("Прощай, Грёза", "Василий Аксенов"),
        new FictionBook("Золотой телёнок", "Илья Ильф и Евгений Петров"),
        new FictionBook("Не бойся, я с тобой", "Александр Блок"), 
        new FictionBook("Анна Каренина", "Лев Толстой"),
        new FictionBook("Война и мир", "Лев Толстой"),
        new FictionBook("Чевенгур", "Андрей Платонов"),
        new FictionBook("Идиот", "Фёдор Достоевский"),
        new FictionBook("Братья Карамазовы", "Фёдор Достоевский"),
        new FictionBook("Убить пересмешника", "Харпер Ли"),
        new FictionBook("451 градус по Фаренгейту", "Рэй Брэдбери"),
        new FictionBook("Молодая гвардия", "Александр Фадеев"),
        new FictionBook("Как закалялась сталь", "Николай Островский"),
        new ScienceBook("Педагогическая поэма", "Антон Макаренко"),
        new ScienceBook("Основы кибернетики", "Анатолий Китов"),
        new ScienceBook("Земля и люди", "Владимир Обручев"),
        new ScienceBook("Наука и жизнь", "Светлана Аксенова"), 
        new ScienceBook("Краткая история времени", "Стивен Хокинг"),
        new ScienceBook("Общая теория относительности", "Альберт Эйнштейн"), 
        new ScienceBook("Биология", "Джеймс Уотсон"), 
        new ScienceBook("Физика", "Ричард Фейнман"), 
        new ScienceBook("Химия", "Дмитрий Менделеев") 
    };
        }




        // Обновляем отображение списка книг
        private void UpdateBookList()
        {
            listBoxBooks.Items.Clear();
            foreach (var book in books)
            {
                string status = book.IsAvailable ? "Доступна" : "Выдана";
                listBoxBooks.Items.Add($"{book.Title} - {book.Author} ({status})");
            }
        }

        // Метод для выдачи книги
        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                var selectedBook = books[listBoxBooks.SelectedIndex];
                selectedBook.Checkout();
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для выдачи.");
            }
        }

        // Метод для возврата книги
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedIndex >= 0)
            {
                var selectedBook = books[listBoxBooks.SelectedIndex];
                selectedBook.Return();
                UpdateBookList();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для возврата.");
            }
        }

        // Применение минималистичного дизайна
        private void ApplyDesign()
        {
            // Цвет фона формы
            this.BackColor = Color.LightBlue;

            // Настройка цвета для списка книг
            listBoxBooks.BackColor = Color.White;
            listBoxBooks.Font = new Font("Arial", 10);
            listBoxBooks.ForeColor = Color.DarkBlue;

            // Настройка кнопок
            buttonCheckout.BackColor = Color.LightGreen;
            buttonCheckout.ForeColor = Color.DarkGreen;
            buttonCheckout.FlatStyle = FlatStyle.Flat;

            buttonReturn.BackColor = Color.LightCoral;
            buttonReturn.ForeColor = Color.DarkRed;
            buttonReturn.FlatStyle = FlatStyle.Flat;
        }

        // Настройка растягивания элементов
        private void SetupAnchors()
        {
            // Привязка списка книг к верхней, левой и нижней границам формы
            listBoxBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;

            // Привязка кнопок к нижней границе формы
            buttonCheckout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonReturn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        }
    }
}
