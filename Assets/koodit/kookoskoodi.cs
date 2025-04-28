using Unity.VisualScripting;
using UnityEngine;

public class kookoskoodi : MonoBehaviour
{
    public GameObject savu = null;
    private GameObject savuefekti = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //pyöritetään kookosta hitaasti x-akselinsa ympäri
        this.GetComponent<Transform>().Rotate(0, 30f * Time.deltaTime, 0);
        //this.kookoksenkoordinaatit.GetComponent<Transform>().position

    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Equals("pelaaja"))
        {
            this.savuefekti = Instantiate(this.savu, this.transform.position, Quaternion.identity);
            Destroy(gameObject);  // Tämä tuhoaa vain sen kookoksen, johon osuttiin
        }
    }
}