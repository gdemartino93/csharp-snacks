﻿//Snack1. L’utente inserisce due numeri in successione. Il software stampa il maggiore.

//Console.WriteLine("Inserisci il primo numero");
//int x = System.Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Inserisci il secondo numero");
//int y = System.Convert.ToInt32(Console.ReadLine());

//if (x > y)
//{ Console.WriteLine(x); }
//else
//{ Console.WriteLine(y); }

//Snack2.L’utente inserisce due parole in successione. Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Inserisci la prima parola");
//string x = Console.ReadLine();
//Console.WriteLine("Inserisci la seconda parola");
//string y = Console.ReadLine();

//if(x.Length > y.Length)
//{
//    Console.WriteLine(y);
//    Console.WriteLine(x);
//}
//else
//{
//    Console.WriteLine(x);
//    Console.WriteLine(y);
//}

////Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero. Il programma stampa la somma di tutti i numeri inseriti.
//List<int> numeri = new List<int>();

//int somma = 0;
//for (int i = 0; i < 10;  i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numero = Convert.ToInt32(Console.ReadLine());
//    numeri.Add(numero);
//}
//foreach (int numero in numeri)
//{
//    somma += numero; 
//}
//Console.WriteLine(somma);
//////Snack4. Calcola la somma e la media dei numeri da 2 a 10.
//List <int> numeri = new List<int>();

//for (int i = 2; i < 11; i++)
//{
//    numeri.Add(i); 
//}
//int sum = (int)numeri.Sum();
//int avg = (int)numeri.Average();
//Console.WriteLine($"La media dei numeri da 2 a 10 è {avg}. La somma è {sum}");

////Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,stampa il numero, se è dispari, stampa il numero successivo.

//Console.WriteLine("Inserisci il numero");
//int x = Convert.ToInt32(Console.ReadLine());

//if(x % 2 == 0)
//{
//    Console.WriteLine(x);
//}
//else
//{
//    Console.WriteLine(x + 1);
//}
////Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby. Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla festa.


//List<string> invitati = new List<string>()
//{
//    "Sara","Luca","Paolo"
//};
//bool? puoEntrare = null;
//Console.WriteLine("Inserisci il tuo nome");
//string nome = Console.ReadLine();

//foreach(string invitato in invitati)
//{
//    if(invitato.ToLower() == nome.ToLower())
//    {
//        puoEntrare = true;
//        Console.WriteLine("Puoi entrare");
//        break;
//    }
//    else
//    {
//       puoEntrare = false;
//    }
//}
//if (puoEntrare == false)
//{
//    Console.WriteLine("Non puoi entrare");
//};
////Snack7.Crea un array vuoto. Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo nell’array.

//List <int> dispari = new List <int> ();

//for(int i = 0; i < 6; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int x = Convert.ToInt32(Console.ReadLine());
//    if ( x % 2 == 0)
//    {
//        continue;
//    }
//    else
//    {
//        dispari.Add(x);
//    }
//}
//foreach (int x in dispari)
//{
//    Console.WriteLine(x);
//}

////Snack8. Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in posizione dispari.

//int[] numeri = { 1 , 2, 1, 4, 1,1 };
//int sum = 0;
//for(int i = 0; i < numeri.Length; i++)
//{
//    if (i % 2 != 0)
//    {
//        sum += numeri[i];
//    }
//}
//Console.WriteLine(sum);

////fino a quando la somma degli elementi è minore di 50.

//List <int> numeri = new List<int>();
//int sum = 0;

//do
//{
//    Console.WriteLine("Insiersci numero");
//    int x = Convert.ToInt32(Console.ReadLine());
//    sum += x;
//} while (sum < 50);
//Console.WriteLine($"la somma è {sum}");

////Snack10.Fai inserire un numero, che chiameremo N, all’utente. Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
////Ogni volta che ne crei uno, stampalo a schermo

//Console.WriteLine("Inserisci numero");
//int n = Convert.ToInt32(Console.ReadLine());
//var rand = new Random();

//for (int i = 0; i < n; i++)
//{
//    int[] array = new int[10];
//    Console.WriteLine($"L'array num {i} è:");
//    for (int j = 0; j < 10; j++)
//    {
//        array[j] = rand.Next(0, 10);
//        Console.Write($"{array[j]},");
//    }
//    Console.WriteLine();
//}

// Snack 11
//Dare la possibilità di inserire due parole. Verificare tramite una funzione che le due parole abbiano la stessa lunghezza. Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.
/////
//Console.WriteLine("Inserisci prima parola");
//string x = Console.ReadLine();
//Console.WriteLine("Inserisci seconda parola");
//string y = Console.ReadLine();

// string LunghezzaParole(string prima, string seconda)
//{
//    if (prima.Length == seconda.Length)
//    {
//        return prima + " " + seconda;
//    }
//    else
//    {
//        if (prima.Length > seconda.Length)
//        {
//            return prima;
//        }
//        else
//        {
//            return seconda;
//        }
//    }
//};

//Console.WriteLine(LunghezzaParole(x,y));

//Snack 12
//Scrivere una funzione per verificare se un numero è pari o dispari. Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.

string PariDispari(int x)
{
    if (x % 2 == 0)
    {
        return "Pari";
    }
    else
        return "Dispari";
}
Console.WriteLine("Insiersci numero");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PariDispari(numero));