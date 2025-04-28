using UnityEngine;

public class arkkukoodi : MonoBehaviour
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
            Debug.Log("arkkuauki!!!");
            this.GetComponent<Animator>().SetInteger("kansiauki", 1);
           // this.GetComponent<Animator>().SetInteger("arkkuauki", 2);
        }
    }
}
