using System;
using System.Collections.Generic;
using System.Linq;

public class Livro
{

    private int isbn;
    private string titulo;
    private string autor;
    private string editora;
    private List<Exemplar> exemplares;

    
    public Livro(int isbn, string titulo, string autor, string editora)
    {
        this.isbn = isbn;
        this.titulo = titulo;
        this.autor = autor;
        this.editora = editora;
        this.exemplares = new List<Exemplar>();
    }

    // Properties
    public int ISBN
    {
        get { return isbn; }
        set { isbn = value; }
    }

    public void AdicionarExemplar(Exemplar exemplar)
    {
        exemplares.Add(exemplar);
    }

    
    public int QtdeExemplares()
    {
        return exemplares.Count;
    }


    public int QtdeDisponiveis()
    {
        return exemplares.Count(ex => ex.Disponivel());
    }
    public int QtdeEmprestimos()
    {
        return exemplares.Sum(ex => ex.QtdeEmprestimos());
    }

    public double PercDisponibilidade()
    {
        int totalExemplares = QtdeExemplares();
        if (totalExemplares > 0)
        {
            int exemplaresDisponiveis = QtdeDisponiveis();
            return (double)exemplaresDisponiveis / totalExemplares * 100;
        }
        else
        {
            return 0.0;
        }
    }
}