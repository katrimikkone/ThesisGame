using UnityEngine;

public class timanttiQuit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {
            Debug.Log("Kerätty timantti, suljetaan peli.");
            Application.Quit();
        }
    }
}
