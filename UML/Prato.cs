using System;
using System.Collections.Generic;
using System.Linq;

  public class Prato{
  public String Nome { get; set; }
  public Decimal Preco { get; set; }
  public List<Ingrediente> Ingredientes { get; set; }

  public Prato(){
    Ingredientes = new List<Ingrediente>();
  }

  public void AdicionarIngrediente(Ingrediente ingrediente){
    Ingredientes.Add(ingrediente);
  }

  public Decimal CalcularLucro(){
    Decimal custoTotal = Ingredientes.Sum(i => i.Custo);
    Decimal lucro = Preco - custoTotal;
    return lucro;
  }
  
}