using System ;

class demoArray {
    static void Main (){
        //membuat aray dari tipe char
        char [] vokal = new char [5];

        //mengisi nilai elemen array
        vokal[0] = 'a';
        vokal[1] = 'i';
        vokal[2] = 'u';
        vokal[3] = 'e';
        vokal[4] = 'o';

        //menampilkan elemen array
        Console.WriteLine("--huruf vokal--");
        for (int i = 0; i < 5 ; i++){
            Console.Write(vokal[i] + " ");
        }
        Console.WriteLine();
    }
}