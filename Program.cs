/*
ARRAY 3 DIMENSI

bentuk umum 
tipe[,,]namaArray = new tipe [jumlahHalaman,jumlahBaris,jumlahKolom];

*/

using System;

class demoArrayTigaDimensi
{
    static void Main ()
    {
        //inisialisasi array3d
        int [ ,, ] arrayTigaDimensi = new int [2,3,3]
        { 
            {
            {1,0,3},
            {4,-1,2},
            {8,2,1}
        },
        {
            {6,8,3},
            {4,3,6},
            {5,9,2}
        }
        };

        for (int halaman = 0; halaman <2 ; halaman++){
        Console.WriteLine("halaman ke- "+(halaman+1));
        for (int baris = 0; baris < 3; baris ++){
            for (int kolom = 0; kolom < 3; kolom++){
                Console.Write(arrayTigaDimensi[halaman,baris,kolom]+" ");
            }Console.WriteLine();
        }Console.WriteLine();
    }
    Console.WriteLine ("elemen A[1,1,2] bernilai : "+arrayTigaDimensi[1,1,2]);

    }
    //menampilkan elemen array
   

}