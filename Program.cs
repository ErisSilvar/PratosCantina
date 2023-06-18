using System;
using System.Collections.Generic;
using System.Linq;

public class Program{
  
  static void Main(string[] args){
    Ingrediente i1 = new Ingrediente { Nome = "Farinha de trigo", Custo = 6.5m};
    Ingrediente i2 = new Ingrediente { Nome = "Molho de tomate", Custo = 2.0m};
    Ingrediente i3 = new Ingrediente { Nome = "Queijo", Custo = 1.7m};
    Ingrediente i4 = new Ingrediente { Nome = "Carne", Custo = 1.8m};
    Ingrediente i5 = new Ingrediente { Nome = "Oregano", Custo = 0.5m};
    Ingrediente i6 = new Ingrediente { Nome = "Arroz", Custo = 1.5m};
    Ingrediente i7 = new Ingrediente { Nome = "Feijao", Custo = 1.5m};
    Ingrediente i8 = new Ingrediente { Nome = "Batata frita", Custo = 1.5m};
    Ingrediente i9 = new Ingrediente { Nome = "Alface", Custo = 1.5m};
    Ingrediente i10 = new Ingrediente { Nome = "Agua", Custo = 2.8m};
    Ingrediente i11 = new Ingrediente { Nome = "Macarrao", Custo = 1.5m};
    Ingrediente i12 = new Ingrediente { Nome = "Pao", Custo = 1.5m};
    Ingrediente i13 = new Ingrediente { Nome = "Alho", Custo = 1.5m};

    Prato p1 = new Prato { Nome = "Pizza", Preco = 50.0m};
    Prato p2 = new Prato { Nome = "Marmitex", Preco = 50.0m};
    Prato p3 = new Prato { Nome = "Sopa", Preco = 50.0m};
    Prato p4 = new Prato { Nome = "Macarrao", Preco = 80.0m};
    Prato p5 = new Prato { Nome = "Pao de alho", Preco = 10.0m};

    p1.AdicionarIngrediente(i1);
    p1.AdicionarIngrediente(i2);
    p1.AdicionarIngrediente(i3);
    p1.AdicionarIngrediente(i4);
    p1.AdicionarIngrediente(i5);

    p2.AdicionarIngrediente(i6);
    p2.AdicionarIngrediente(i7);
    p1.AdicionarIngrediente(i8);
    p1.AdicionarIngrediente(i9);

    p3.AdicionarIngrediente(i4);
    p3.AdicionarIngrediente(i10);

    p4.AdicionarIngrediente(i11);
    p4.AdicionarIngrediente(i3);
    p4.AdicionarIngrediente(i4);

    p5.AdicionarIngrediente(i12);
    p5.AdicionarIngrediente(i13);
    
    Decimal lucroPrato1 = p1.CalcularLucro();
    Decimal lucroPrato2 = p2.CalcularLucro();
    Decimal lucroPrato3 = p3.CalcularLucro();
    Decimal lucroPrato4 = p4.CalcularLucro();
    Decimal lucroPrato5 = p5.CalcularLucro();

    Console.WriteLine($"Lucro do prato '{p1.Nome}': " + lucroPrato1.ToString("C"));
    Console.WriteLine($"Lucro do prato '{p2.Nome}': " + lucroPrato2.ToString("C"));
    Console.WriteLine($"Lucro do prato '{p3.Nome}': " + lucroPrato3.ToString("C"));
    Console.WriteLine($"Lucro do prato '{p4.Nome}': " + lucroPrato4.ToString("C"));
    Console.WriteLine($"Lucro do prato '{p5.Nome}': " + lucroPrato5.ToString("C"));
  }
}