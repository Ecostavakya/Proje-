using SinemaSeans;

int seansid = 0;
int koltukSayi = 0;

Film film1 = new Film("Avengers", "120");
Film film2 = new Film("Sparta", "100");
Film film3 = new Film("Asteriks ve oburiks", "130");
Film secilenFilm;

Salon salon1 = new Salon("Salon 1A", 50);
Salon salon2 = new Salon("Salon 2A", 20);
Salon salon3 = new Salon("Salon 1B", 40);


filmSellect:
Console.WriteLine("Film seçiniz");
Console.WriteLine("1)" + film1.FilmAdi);
Console.WriteLine("2)" + film2.FilmAdi);
Console.WriteLine("3)" + film3.FilmAdi);

int seçilen_film = Convert.ToInt32(Console.ReadLine());
switch (seçilen_film)
{
    case 1:
        Console.WriteLine("Seçtiğin film " + film1.FilmAdi);
        secilenFilm = film1;
        break;
    case 2:
        Console.WriteLine("Seçtiğin film " + film2.FilmAdi);
        secilenFilm = film2;
        break;
    case 3:
        Console.WriteLine("Seçtiğin film " + film3.FilmAdi);
        secilenFilm = film3;
        break;
    default:
        Console.WriteLine("Geçerli film girin");
        goto filmSellect;
        break;
}
Seans seans1 = new Seans(secilenFilm, salon1, "10.15");
Seans seans2 = new Seans(secilenFilm, salon2, "11.55");
Seans seans3 = new Seans(secilenFilm, salon3, "14.30");
Seans secilenSeans;
seansSellect:
Console.WriteLine("Seans Seçiniz");
Console.WriteLine("1)" + seans1.Tarih);
Console.WriteLine("2)" + seans2.Tarih);
Console.WriteLine("3)" + seans3.Tarih);
int seçilen_Seans = Convert.ToInt32(Console.ReadLine());
switch (seçilen_Seans)
{
    case 1:
        Console.WriteLine("Seçtiğin Seans " + seans1.Tarih);
        secilenSeans = seans1;
        break;
    case 2:
        Console.WriteLine("Seçtiğin Seans " + seans2.Tarih);
        secilenSeans = seans2;
        break;
    case 3:
        Console.WriteLine("Seçtiğin Seans " + seans3.Tarih);
        secilenSeans = seans3;
        break;
    default:
        Console.WriteLine("Geçerli seans girin");
        goto seansSellect;
        break;
}


Console.Write("Müşteri ismini yazınız: ");
string musteriAdi = Convert.ToString(Console.ReadLine());

koltukYetersiz:
Console.Write("Kaç koltuk alınacak: ");
int koltuk=Convert.ToInt32(Console.ReadLine());
if (secilenSeans.Salon.SalonKapasitesi > koltuk)
{
    Console.WriteLine("Yetersiz koltuk");
    goto koltukYetersiz;
}

Console.WriteLine("Koltuk seçiniz");
string[] koltukYerleri = new string[koltuk];
for(int i=0; i<koltukYerleri.Length; i++)
{
    koltukYerleri[i] = Convert.ToString(Console.ReadLine());
}
Rezervasyon rezervasyon = new Rezervasyon(secilenSeans, musteriAdi, koltuk, koltukYerleri);

Console.WriteLine(rezervasyon.ToString());