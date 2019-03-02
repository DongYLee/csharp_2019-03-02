using System;

class Emp
{
    /*
   private int _Empno;

   public int Empno //일반속성
   {
       get
       {
           return _Empno;
       }
       set
       {
           this._Empno = value;
       }
   }*/

    public int Empno //자동구현속성
    {
        get; set;
    }
    /*
    public void SetEmpno(int Empno)
    {
        this.Empno = Empno;
    }
    public int GetEmpno()
    {
        return this.Empno;
    }*/
}

class EmpTest
{
    static void Main()
    {
        Emp e = new Emp(); e.Empno = 999;
        Console.WriteLine(e.Empno);
    }
}