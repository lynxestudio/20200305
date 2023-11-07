using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BitwiseCalc
{
class BitwiseCalc
{
delegate int DelBinOp(int a,int b);
delegate int DelUriOp(int a);
static void Main(string[] args)
{
    ushort option = 0;
    do {
    option = Menu();
    switch(option){
    case 1:
        Console.WriteLine("\t\t[ & AND ]\n\n");
        BinaryOp((a, b) =>a & b);
        break;
    case 2:
        Console.WriteLine("\t\t[ | OR ]\n\n");
        BinaryOp((a,b) => a | b);
        break;
    case 3:
        Console.WriteLine("\t\t[ ^ Exclusive OR ]\n\n");
        BinaryOp((a,b) => a ^ b);
        break;
    case 4:
        Console.WriteLine("\t\t[ ~ NOT ]\n\n");
        UnaryOp(a => ~a);
        break;
    case 5:
        Console.WriteLine("\t\t[ << Shift Left ]\n\n");
        ShiftOp((a,b) => a << b);
        break;
    case 6:
        Console.WriteLine("\t\t[ >> Shift right ]\n\n");
        ShiftOp((a,b) => a >> b);
        break;
                
        }
    } while (option > 0);

}

static ushort Menu() {
ushort option = 0;
Console.WriteLine("\t\tOPERADORES BITWISE\n\n");
Console.WriteLine("1. & AND");
Console.WriteLine("2. | OR");
Console.WriteLine("3. ^ Exclusive OR");
Console.WriteLine("4. ~ NOT");
Console.WriteLine("5. << Shift Left");
Console.WriteLine("6. >> Shift right");
Console.WriteLine();
Console.WriteLine("0. Salir\n\n");
Console.Write("Elija opción: ");
try
{
    option = Convert.ToUInt16(Console.ReadLine());
}
catch (FormatException) {
    Console.WriteLine("Opción no válida");
    option = 0;
}
return option;
}

static void BinaryOp(DelBinOp del) {
int op1,op2,resp;
Console.Write("Teclee el primer operador: ");
op1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Teclee el segundo operador: ");
op2 = Convert.ToInt32(Console.ReadLine());
resp = del(op1,op2);
Console.WriteLine();
DisplayBinary(op1);
DisplayBinary(op2);
Console.WriteLine("----------------------------");
DisplayBinary(resp);
Pause();
}

static void ShiftOp(DelBinOp del)
{
int op1, op2,resp;
Console.Write("Teclee el primer operador: ");
op1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Teclee las posiciones: ");
op2 = Convert.ToInt32(Console.ReadLine());
resp = del(op1, op2);
Console.WriteLine();
DisplayBinary(op1);
Console.WriteLine("-----------------------");
DisplayBinary(resp);
Pause();
}

static void UnaryOp(DelUriOp del) {
int op1,resp;
Console.Write("Teclee el primer operador: ");
op1 = Convert.ToInt32(Console.ReadLine());
resp = del(op1);
DisplayBinary(op1);
Console.WriteLine("-----------------------");
DisplayBinary(resp);
Pause();
}

static void DisplayBinary(int i) {
Console.WriteLine("{0} = {1}",i, Convert.ToString(i, 2).PadLeft(32,'0'));
}

static void Pause() {
Console.Write("\n\nPresiona cualquier tecla para continuar.");
Console.Read();
}

}
}
