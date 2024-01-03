using AreaAndCircumference;

class Program
{
    static void Main()
    {
        Sirkel sirkel = new(5);
        sirkel.ShowInfoCircle();
        Kvadrat kvadrat = new(4);
        kvadrat.ShowInfoKvadrat();
        Rektangel rektangel = new(2, 5);
        rektangel.ShowInfoRektangel();
    }
}