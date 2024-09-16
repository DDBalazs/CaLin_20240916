using CaLin_20240916;
using System.Runtime.ConstrainedExecution;

List<Pet> pets = [
    new Pet() //1
    {
        Name = "Tódor",
        Spaces = "dog",
        Sex = true,
        BirthDate = new(2016, 06, 22),
    },
    new Pet() //2
    {
        Name = "Mr.Wick",
        Spaces = "hamster",
        Sex = true,
        BirthDate = new(2020, 05, 17),
    },
    new Pet() //3
    {
        Name = "Feri",
        Spaces = "crocodile",
        Sex = false,
        BirthDate = new(1965, 07, 30),
    },
    new Pet() //4
    {
        Name = "Izabelle",
        Spaces = "Giraffe",
        Sex = false,
        BirthDate = new(1999, 03, 17),
    },
    new Pet() //5
    {
        Name = "Thomas Edison",
        Spaces = "dog",
        Sex = true,
        BirthDate = new(2010, 05, 27),
    },
    new Pet() //6
    {
        Name = "Lotti",
        Spaces = "cat",
        Sex = false,
        BirthDate = new(1989, 9, 19),
    },
    new Pet() //7
    {
        Name = "Mobesz",
        Spaces = "rabbit",
        Sex = true,
        BirthDate = new(2020, 05, 17),
    },

];


/* ***ismert*** nevezetes algoritmus / programozási tételek
 * sorozatszámítás -> összegzés -> átlagszámítás
 * megszámlálás
 * szélsőérték meghatározása ( min,max)
 * [lineáris] keresés
 * eldöntés
 * kiválasztás
 * --------------------
 * [másolás]
 * kiválogatás
 * szétválogatás
 * [bármilyen] rendezés
 * halmaztételek {unió, metszet, differencia}
 */

Console.WriteLine($"Állatkák száma: {pets.Count} darab");

var lSum = pets.Sum(pet => pet.Age);
Console.WriteLine($"az állatok összéletkora: {lSum} év");

var lAvg = pets.Average(pet => pet.Age);
Console.WriteLine($"az állatok átlagéletkora {lAvg:0.00} év");

var LCnt = pets.Count(p => p.Spaces == "cat");
Console.WriteLine($"az állatok között {LCnt} db macska van");

var LCnt02 = pets.Count(p => p.Spaces == "dog" && p.Sex);
Console.WriteLine($"A fiú kutyusok: {LCnt02}");

var LMin = pets.Min(pet => pet.BirthDate);
Console.WriteLine($"A legöregebb állatka születésnapja: {LMin:MMMM dd.}");

var LMaxBy = pets.MaxBy(p => p.Name);
Console.WriteLine($"A névsorban utolsó állatka: {LMaxBy}");

//first

var LFrst = pets.First(p => p.Spaces == "dog");
Console.WriteLine($"A listában az első kutya {LFrst}");
//Ha van találat -> rendre ELSŐ metching element
//Ha nincs találat -> Sequence contains no matching element


//last

var LLst = pets.Last(p => p.BirthDate.Year <2000);
Console.WriteLine($"A listában az utolsó 2000 elött született állat: {LLst}");
//Ha van találat -> rendre UTOLSÓ metching element
//Ha nincs találat -> Sequence contains no matching element


//single

var LSng = pets.Single(p => p.Spaces == "hamster");
Console.WriteLine($"Az egyetlen höri: {LSng}");

//ha EGYETLEN találat van -> "A" matching element
//ha TÖBB találat van akkor error
//ha egyáltalán nincs egyezés akkor ugyanúgy error

//firstordefault
//lastordefeault
//singleorderdefault

//find
//indexof