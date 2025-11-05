using UnityEngine;

public class Altar : MonoBehaviour
{
    public static void ReachAltar()
    {
        Debug.Log("Der Spieler hat den Altar erreicht! Spielende!");
        Time.timeScale = 0; // Stoppt das Spiel
    }
}
