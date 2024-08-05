// See https://aka.ms/new-console-template for more information
// NEW : bir türün yeni bir örneğini oluşturmak için kullanılır.

using PatikadevLibrary;
// parametre alan constructure kullanılarak örnek oluşturuldu
Books book1 = new Books("Adı Aylin","Ayşe","Kulin","Remzi Kitapevi",398);

// parametre almayan ctor kullanılarak örnek oluşturuldu.
Books book2 = new Books();
book2.BookName = "Refet";
book2.AuthorName = "Fatma Aliye";
book2.AuthorSurname = "Topuz";
book2.Publisher = "İthaki Yayınları";
book2.PageCount = 184;

book1.Recording();
book2.Recording();


