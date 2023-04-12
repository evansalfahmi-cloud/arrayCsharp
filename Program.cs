/*
INISIALISASI ARRAY

tipe [] namaArray = new tipe[] {nilai1,nilai2,nilai3,nilai4....};
*/

using System ;

class demoArray3 {
    static void Main (){
        //inisialisasi array
        int [] arrayA = new int[] {1000,2000,3000,4000,5000};
        char [] vokal = {'a','i', 'u', 'e', 'o'};

        //tampilarray
        Console.WriteLine ("Elemen dalam arrayA :");
        for (int i = 0; i<5; i++){
            Console.Write(arrayA[i]+" ");
        }

        Console.WriteLine("\n");

        Console.WriteLine("Elemen dalam array vokal :");
        for (int v = 0 ; v<5; v++)
        {
            Console.Write(vokal[v]+" ");
        }Console.WriteLine();
    }
}