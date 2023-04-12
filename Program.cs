/*
Array DUA DIMENSI

1 5 3
2 4 1
3 2 4
4 3 2

tipe [,] namaArray = new tipe [JumlahBaris, JumlahKolom];
*/

using System ;

class demoarrayDuaDimensi {
    static void Main (){
        //membuatarray 4x3
        int [,] tabelEmpatTiga = new int [4,3];

        //mengisi nilai kedalam elemen array
        tabelEmpatTiga[0,0] = 1;
        tabelEmpatTiga[0,1] = 5;
        tabelEmpatTiga[0,2] = 3;
        //baris kedua
        tabelEmpatTiga[1,0] = 2;
        tabelEmpatTiga[1,1] = 4;
        tabelEmpatTiga[1,2] = 1;
        //baris ketiga
        tabelEmpatTiga[2,0] = 3;
        tabelEmpatTiga[2,1] = 2;
        tabelEmpatTiga[2,2] = 4;
        //baris keempat
        tabelEmpatTiga[3,0] = 4;
        tabelEmpatTiga[3,1] = 3;
        tabelEmpatTiga[3,2] = 2;

        //tampilkan isi array
        Console.WriteLine("--isi array--");
        for (int baris = 0 ; baris <4; baris++){
            //cetak perbaris
            for (int kolom = 0 ; kolom <3; kolom ++){
                Console.Write(tabelEmpatTiga[baris,kolom]+" ");
            }//buat baris baru
            Console.WriteLine();
        }
    }
}