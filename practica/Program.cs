Personaje personaje = new Personaje
{
    Nombre = "Enrique",
    Vida = 100,
    Ataque = 20,
    Defensa = 10,
    Nivel = 1
};

Console.WriteLine(personaje.Nombre);

public class Personaje
{
    public string Nombre { get; set; } = string.Empty;
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    public int Nivel { get; set; }
}
