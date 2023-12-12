using System;

public class Emprestimo
{

    private DateTime dtEmprestimo;
    private DateTime dtDevolucao;

  
    public Emprestimo(DateTime dtEmprestimo, DateTime dtDevolucao)
    {
        this.dtEmprestimo = dtEmprestimo;
        this.dtDevolucao = dtDevolucao;
    }

    // Properties
    public DateTime DataEmprestimo
    {
        get { return dtEmprestimo; }
        set { dtEmprestimo = value; }
    }

    public DateTime DataDevolucao
    {
        get { return dtDevolucao; }
        set { dtDevolucao = value; }
    }
}