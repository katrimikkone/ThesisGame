using UnityEngine;

public class timanttikoodi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {

               Debug.Log("timantti ulos!!!");
               this.GetComponent<Animator>().SetInteger("timanttiulos", 1);
            //Destroy(gameObject);  // Tämä tuhoaa timantin
           
        }
    }
}
