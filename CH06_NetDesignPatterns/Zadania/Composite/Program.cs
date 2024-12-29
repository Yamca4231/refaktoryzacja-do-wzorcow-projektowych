// Program główny
class Program
{
    static void Main(string[] args)
    {
        // Tworzenie liści (pozycji menu)
        var pierogi = new MenuItem("Pierogi ruskie", 25.99m);
        var schabowy = new MenuItem("Kotlet schabowy", 34.50m);
        var zurek = new MenuItem("Żurek", 18.00m);
        var kompot = new MenuItem("Kompot", 7.00m);

        // Tworzenie kompozytów (kategorii menu)
        var daniaGlowne = new MenuCategory("Dania Główne");
        daniaGlowne.Add(pierogi);
        daniaGlowne.Add(schabowy);

        var zupy = new MenuCategory("Zupy");
        zupy.Add(zurek);

        var napoje = new MenuCategory("Napoje");
        napoje.Add(kompot);

        var menu = new MenuCategory("Menu Restauracji Polskiej");
        menu.Add(zupy);
        menu.Add(daniaGlowne);
        menu.Add(napoje);

        // Wyświetlenie pełnego menu
        menu.Display(string.Empty);
    }
}