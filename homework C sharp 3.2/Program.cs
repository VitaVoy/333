using System;

namespace homework_C_sharp_3._2
{
    class Complex
    {
        public double im;
        public double re;

        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + this.im;
            x3.re = x2.re + this.re;
            return x3;
        }

        public Complex Diff(Complex x2)
        {
            Complex x4 = new Complex();
            x4.im = x2.im - this.im;
            x4.re = x2.re - this.re;
            return x4;
        }

        public Complex Mult(Complex x2)
        {
            Complex x5 = new Complex();
            x5.im = x2.im * this.im;
            x5.re = x2.re * this.re;
            return x5;
        }
        public string ToString()
        {
            return re + "+" + im + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex complex1 = new Complex();
            complex1.re = 1;
            complex1.im = 1;

            Complex complex2 = new Complex();
            complex2.re = 2;
            complex2.im = 2;

            Complex result = complex1.Plus(complex2);
            Complex result1 = complex1.Diff(complex2);
            Complex result2 = complex1.Mult(complex2);
            Console.WriteLine(result.ToString());
            Console.WriteLine(result1.ToString());
            Console.WriteLine(result2.ToString());

        }
    }

}
