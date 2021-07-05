using System;
namespace _07.Manual.Exercise._01.TERNARIA {
    class Program {
        static void Main(string[] args) {
            //---- > FORMA TRADICIONAL
            double preco = 34.5;
            double desconto;
            if(preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
            //----> FORMA TERNARIA
            double _preco = 34.5;
            double _desconto = (_preco < 20.0 && _preco > 10) ? _preco * 0.1 : _preco * 0.05;
            Console.WriteLine(_desconto);
        }
    }
}
