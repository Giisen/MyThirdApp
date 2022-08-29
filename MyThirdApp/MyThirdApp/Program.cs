
// deklarera namn,ålder och en bool om vi har ätit frukost. Skriv ut dessa i WriteLine



var namn = "Krister";
var age = 45;
bool frukost = true;


Console.WriteLine("Hello Krister Ekelund!");

int heltal;

heltal = 1;

var heltal2 = 2L;

Console.WriteLine($"Heltal: {heltal}");
Console.WriteLine("Heltal: " + heltal);


if (frukost)
{
    Console.WriteLine($"Hej {namn} din ålder är {age}, bra att du ätit frukost!");
}

else
{
    Console.WriteLine($"Hej {namn} din ålder är {age}, kaffe är inte frukost, ät nåt innan skolan börjar.");
}

Console.ReadKey();


