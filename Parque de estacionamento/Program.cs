// See https://aka.ms/new-console-template for more information


using Parque_de_estacionamento;
using System.Globalization;
using System.Text;
Console.OutputEncoding = Encoding.UTF8; //Para imprimir caracteres especiais na consola, neste caso o símbolo €, https://social.msdn.microsoft.com/Forums/vstudio/en-US/3fc38850-5829-4f30-8ff5-3335f998f5f9/c-convert-console-output-utf8-to-display-in-textbox-special-characters-problems

//Definindo a class Zona, com as suas variáveis z de cada zona
Zona z1 = new Zona(1, 45, 1.15, 20, 0, 0);
Zona z2 = new Zona(2, 120, 1.00, 15, 0, 0);
Zona z3 = new Zona(3, 9999, 0.62, 15, 0, 0); //Sem Duração Máxima


Menus.MenuGeral();




