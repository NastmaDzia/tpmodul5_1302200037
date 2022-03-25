using System;
namespace tpmodul5_1302200037
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo vidio = new SayaTubeVideo("Tutorial Design By Contract - Nastma Dzia Ulhaque");
            vidio.PrintVideoDetails();

            vidio.IncreasePlayCount(69);
            vidio.PrintVideoDetails();

            try
            {
                vidio.IncreasePlayCount(1900000000);
                vidio.PrintVideoDetails();
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}