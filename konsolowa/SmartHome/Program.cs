internal class Program
{
    public class Device
    {
        /************************************************
            nazwa: Alert
            opis: wyświetla treść komunikatu o aktualnym stanie odkurzacza
            parametry: info - przechowuje treść komunikatu
            zwracany typ i opis: brak
            autor: https://github.com/Milosian
        ************************************************/
        public void Alert(string info)
        {
            Console.WriteLine(info);
        }
    }
    public class WashingMachine
    {
        private int program = 0;
        /************************************************
            nazwa: SetProgram
            opis: ustawia numer programu prania
            parametry: progNum - numer programu wybrany przez użytkownika
            zwracany typ i opis: int - numer programu
            autor: https://github.com/Milosian
        ************************************************/
        public int SetProgram(int progNum) {
            if(progNum > 0 && progNum <= 12) {
                program = progNum;
            }else
            {
                program = 0;
            }
            return program;
        }
    }
    public class Cleaner : Device
    {
        private bool status = false;
        /************************************************
            nazwa: on
            opis: włącza odkurzacz
            parametry: brak
            zwracany typ i opis: brak
            autor: https://github.com/Milosian
        ************************************************/
        public void on()
        {
            if (!status) { 
                status = true;
                Alert("Odkurzacz włączono");
            }
        }
        /************************************************
            nazwa: off
            opis: wyłącza odkurzacz
            parametry: brek
            zwracany typ i opis: brak
            autor: https://github.com/Milosian
        ************************************************/
        public void off()
        {
            if (status)
            {
                status = false;
                Alert("Odkurzacz wyłączono");
            }
        }
    }
    private static void Main(string[] args)
    {
        WashingMachine washing = new WashingMachine();
        Cleaner clean = new Cleaner();

        Console.WriteLine("Podaj numer prania 1..12");
        int progNum = Convert.ToInt32(Console.ReadLine());
        if (washing.SetProgram(progNum) != 0){
            Console.WriteLine("Program został ustawiony");
        }
        else
        {
            Console.WriteLine("Podano niepoprawny numer programu");
        }
        clean.on();
        clean.on();
        clean.on();
        clean.Alert("Odurzacz wyładował się");
        clean.off();
    }
}