            // Value type
            int x = 5;
            int y = x;
            x = 10;
            Console.WriteLine(y.ToString());
            Console.WriteLine(x.ToString());
            
            // Reference type, use Object.ReferenceEquals(a, b) for assert tests
            Book book1 = new Book("Cat");
            Book book2 = book1;
            book2.Name = "Dog";
            Console.WriteLine(book1.Name);
