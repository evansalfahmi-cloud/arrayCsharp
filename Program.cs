/*
ARRAY SEBAGAI NILAI KEMBALIAN METODE

selain sebagai parameter, array juga sering digunakan sebagainilai kembalian (return value) dari suatu metode


*/

using System;

class demoParameterArray
{
    //metode dengan nilai kembalian berupa array
    static int[] isiArray(int ukuran)
    {
        int[] temp = new int[ukuran];
        int nilai;

        Console.WriteLine("Mengisi array sebanyak " + ukuran + " elemen");
        for (int i = 0; i < ukuran; i++)
        {
            Console.Write("Masukkan nilai ke-" + (i + 1) + " : ");
            nilai = int.Parse(Console.ReadLine());

            //memasukkan nilai ke dalam array
            temp[i] = nilai;
        }
        //mengembalikan nilai berupa array
        return temp;
    }

    static double hitungRatarata(int[] A)
    {
        int jumlah = 0;
        for (int i = 0; i < A.Length; i++)
        {
            jumlah += A[i];
        }
        double rataRata = (double)jumlah / A.Length;
        return rataRata;
    }

    static void tampilkanArray(int[] A)
    {
        Console.Write("isi array : ");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(A[i] + " ");
        } Console.WriteLine();

    }

    static void Main()
    {
        //deklarasikan array
        int[] arrayID;

        //memanggil metode isi array;
        arrayID = isiArray(5);
        Console.WriteLine();

        //memanggil metode tampilkan array
        tampilkanArray(arrayID);

        //memanggil metode hitung rata rata
        Console.WriteLine("Nilai ratarata = " + hitungRatarata(arrayID));
    }

}