using UnityEngine;

public class timanttiQuit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {
            Debug.Log("Ker�tty timantti, suljetaan peli.");
            Application.Quit();
        }
    }
}
