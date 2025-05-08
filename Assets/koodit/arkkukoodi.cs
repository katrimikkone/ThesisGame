using UnityEngine;

public class arkkukoodi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {
            Debug.Log("arkkuauki!!!");
            this.GetComponent<Animator>().SetInteger("kansiauki", 1);
        }
    }
}
