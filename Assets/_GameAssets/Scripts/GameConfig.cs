
public class GameConfig {
    public static bool jugando;

    public static bool IsPlaying()
    {
        return jugando;
    }

    public static void ArrancaJuego()
    {
        jugando = true;

    }

    public static void PararJuego()
    {
        jugando = false;
    }
}
