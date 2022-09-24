class Kalkulator{
    static void Main(string[] args){
        char ulangi;
        do{
            Console.WriteLine(" ");
            Console.WriteLine("Enter the action to be performed");
            string[] arrayOperator = {
                "Addition","Substraction","Multiplication","Division"
            };

            for(int i=0;i<arrayOperator.Length;i++){
            Console.WriteLine("Press "+i+" for : "+arrayOperator[i]);
            }
            Console.WriteLine(" ");

            Console.Write("Press (0/1/2/3): ");
            int press = Convert.ToInt32(Console.ReadLine());

            if(press == 0){
                Console.Write("Enter 1st input : ");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd input : ");
                double two = Convert.ToDouble(Console.ReadLine());

                double hasilTambah = tambah(one,two);

                Console.WriteLine("Hasil Penambahan : "+ hasilTambah);

            }
            if(press == 1){
                Console.Write("Enter 1st input : ");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd input : ");
                double two = Convert.ToDouble(Console.ReadLine());

                double hasilKurang = kurang(one,two);

                Console.WriteLine("Hasil Pengurangan : "+ hasilKurang);

            }
            if(press == 2){
                Console.Write("Enter 1st input : ");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd input : ");
                double two = Convert.ToDouble(Console.ReadLine());

                double hasilPerkalian = kali(one,two);

                Console.WriteLine("Hasil Perkalian : "+ hasilPerkalian);

            }
            if(press == 3){
                Console.Write("Enter 1st input : ");
                double one = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter 2nd input : ");
                double two = Convert.ToDouble(Console.ReadLine());

                double hasilPembagian = bagi(one,two);

                Console.WriteLine("Hasil Pembagian : "+ hasilPembagian);

            }
            Console.Write("Ulangi Operator (y/n) : ");
            ulangi = char.Parse(Console.ReadLine() ?? "");
        }while(ulangi == 'y' || ulangi == 'Y');
    }
    static double tambah(double one, double two) => one + two;
    static double kurang(double one, double two) => one - two;
    static double kali(double one, double two) => one * two;
    static double bagi(double one, double two) => one / two;
}

