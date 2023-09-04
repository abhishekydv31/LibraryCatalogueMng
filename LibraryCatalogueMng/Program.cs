internal class Program
{

    //Book Details: 1. book_Id, book_Name, book_Price, book_Author, book_description
    class Book {
        private int book_Id;
        private string book_Name;
        private int book_Price;
        private string book_Author;
        private string book_Description;

        public void set_BookId(int Id) 
        {
            book_Id = Id;
        }
        public int get_BookId() {
            return book_Id;
        }
        public void set_BookName(string Name) {
            book_Name = Name;
        }
        public string get_BookName() 
        {
            return book_Name;
        }
        public void set_BookPrice(int price) 
        {
            book_Price = price;
        }
        public int get_BookPrice() {
            return book_Price;
        }
        public void set_BookAuthor(string author) 
        {
            book_Author = author;
        }
        public string get_BookAuthor() 
        {
            return book_Author;
        }
        public void set_BookDescription(string desc) 
        {
            book_Description = desc;
        }
        public string get_BookDescription() 
        {
            return book_Description;
        }

    }
    private static void Main(string[] args)
    {
        int option_selected = 0;
        Console.WriteLine("******Welcome To Library*********");
        Console.WriteLine("\nSelect the operation to be performed:");
        Console.WriteLine("\n1. Add Book:\n2.Remove Book: \n3. Search By title: \n4. Search By Author: \n5. Search By Id:");
        option_selected = int.Parse(Console.ReadLine());
        switch (option_selected) 
        {
            case 1:
                Console.WriteLine("\nEnter the Id of Book:");
                Console.ReadLine();
                break;
        }
    }
}