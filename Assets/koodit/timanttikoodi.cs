using UnityEngine;

public class timanttikoodi : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {

               Debug.Log("timantti ulos!");
               this.GetComponent<Animator>().SetInteger("timanttiulos", 1);
           
        }
    }
}
