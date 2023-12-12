using System;
using System.Collections.Generic;

public class Exemplar
{
    
    private int tombo;
    private List<Emprestimo> emprestimos;


    public Exemplar(int tombo)
    {
        this.tombo = tombo;
        this.emprestimos = new List<Emprestimo>();
    }


    public int Tombo
    {
        get { return tombo; }
        set { tombo = value; }
    }

    
    public bool Disponivel()
    {
        return emprestimos.Count == 0;
    }

    
    public bool Emprestar()
    {
        if (Disponivel())
        {
            Emprestimo emprestimo = new Emprestimo(DateTime.Now, DateTime.MinValue);
            emprestimos.Add(emprestimo);
            return true;
        }
        else
        {
            Console.WriteLine("Exemplar não disponível para empréstimo.");
            return false;
        }
    }

    
    public bool Devolver()
    {
        if (!Disponivel())
        {
            Emprestimo ultimoEmprestimo = emprestimos[emprestimos.Count - 1];
            ultimoEmprestimo.DataDevolucao = DateTime.Now;
            return true;
        }
        else
        {
            Console.WriteLine("Exemplar já está disponível. Não pode ser devolvido novamente.");
            return false;
        }
    }

   
    public int QtdeEmprestimos()
    {
        return emprestimos.Count;
    }
}