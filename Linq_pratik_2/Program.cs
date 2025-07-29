using Linq_pratik_2;

List<musicAlbum> list = new List<musicAlbum>()
{
    new musicAlbum { FullName="Ajda Pekkan", MusicGenre="Pop", ReleaseYear="1968", AlbumSales=20000000 },
    new musicAlbum { FullName="Sezen Aksu", MusicGenre="Türk Halk Müziği / Pop", ReleaseYear="1971", AlbumSales=10000000 },
    new musicAlbum { FullName="Funda Arar", MusicGenre="Pop", ReleaseYear="1999", AlbumSales=3000000 },
    new musicAlbum { FullName="Sertab Erener", MusicGenre="Pop", ReleaseYear="1994", AlbumSales=5000000 },
    new musicAlbum { FullName="Sıla", MusicGenre="Pop", ReleaseYear="2009", AlbumSales=3000000 },
    new musicAlbum { FullName="Serdar Ortaç", MusicGenre="Pop", ReleaseYear="1994", AlbumSales=10000000 },
    new musicAlbum { FullName="Tarkan", MusicGenre="Pop", ReleaseYear="1992", AlbumSales=40000000 },
    new musicAlbum { FullName="Hande Yener", MusicGenre="Pop", ReleaseYear="1999", AlbumSales=7000000 },
    new musicAlbum { FullName="Hadise", MusicGenre="Pop", ReleaseYear="2005", AlbumSales=5000000 },
    new musicAlbum { FullName="Gülben Ergen", MusicGenre="Pop / Türk Halk Müziği", ReleaseYear="1997", AlbumSales=10000000 },
    new musicAlbum { FullName="Neşet Ertaş", MusicGenre="Türk Halk Müziği / Türk Sanat Müziği", ReleaseYear="1960", AlbumSales=2000000 }
};
//Adı 'S' ile başlayan şarkıcılar
var list2 = list.Where(x => x.FullName.StartsWith("A"));
Console.WriteLine("Adı 'S' ile başlayan şarkıcılar");
foreach (var item in list2)
{
    Console.WriteLine(item.FullName);
}
//Albüm satışları 10 milyon'un üzerinde olan şarkıcılar
var list3 = list.Where(x => x.AlbumSales > 10000000);
Console.WriteLine("Albüm satışları 10 milyon'un üzerinde olan şarkıcılar");
foreach (var item in list3)
{
    Console.WriteLine(item.AlbumSales);
}
//En çok albüm satan şarkıcı
var singer = list.OrderByDescending(x => x.AlbumSales).FirstOrDefault();
Console.WriteLine("En çok albüm satan şarkıcı ");
Console.WriteLine($"En çok albüm satan şarkıcı: {singer.FullName}, Satış: {singer.AlbumSales}");
//en eski çıkış yapan şarkıcı
var singer1 = list.OrderBy(x => x.ReleaseYear).FirstOrDefault();
Console.WriteLine("En eski çıkış yapan şarkıcı ");
Console.WriteLine($"Sarkıcı : {singer1.FullName} Cıkış yılı : {singer1.ReleaseYear}");
//En yeni çıkış yapan şarkıcı
var singer2 = list.OrderByDescending(list => list.ReleaseYear).FirstOrDefault();
Console.WriteLine("En eski çıkış yapan şarkıcı ");
Console.WriteLine($"Sarkıcı : {singer2.FullName} Cıkış yılı : {singer2.ReleaseYear}");
