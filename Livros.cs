using System;
using System.Collections.Generic;
using System.Linq;

public class Livros
{

    private List<Livro> acervo;

    
    public Livros()
    {
        acervo = new List<Livro>();
    }

    public IReadOnlyList<Livro> Acervo
    {
        get { return acervo.AsReadOnly(); }
    }
                                           
    public void Adicionar(Livro livro)
    {
        acervo.Add(livro);
    }


    public Livro PesquisarSintetico(Livro livro)
    {
        return acervo.Find(l => l.ISBN == livro.ISBN);
    }

    
    public Livro PesquisarAnalitico(Livro livro)
    {
        return acervo.Find(l => l.ISBN == livro.ISBN);
    }

    
    public void AdicionarExemplar(Livro livro, Exemplar exemplar)
    {
        Livro livroEncontrado = acervo.Find(l => l.ISBN == livro.ISBN);
        if (livroEncontrado != null)
        {
            livroEncontrado.AdicionarExemplar(exemplar);
            Console.WriteLine("Exemplar adicionado com sucesso.");
        }
        else
        {
            Console.WriteLine("Livro não encontrado na coleção.");
        }
    }

 
    public void RegistrarEmprestimo(Livro livro, Exemplar exemplar)
    {
        Livro livroEncontrado = acervo.Find(l => l.ISBN == livro.ISBN);
        if (livroEncontrado != null)
        {
            if (livroEncontrado.RegistrarEmprestimo(exemplar))
            {
                Console.WriteLine("Empréstimo registrado com sucesso.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado na coleção.");
        }
    }


    public void RegistrarDevolucao(Livro livro, Exemplar exemplar)
    {
        Livro livroEncontrado = acervo.Find(l => l.ISBN == livro.ISBN);
        if (livroEncontrado != null)
        {
            if (livroEncontrado.RegistrarDevolucao(exemplar))
            {
                Console.WriteLine("Devolução registrada com sucesso.");
            }
        }
        else
        {
            Console.WriteLine("Livro não encontrado na coleção.");
        }
    }
}



