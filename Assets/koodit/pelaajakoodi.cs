using Unity.VisualScripting;
using UnityEngine;


public class pelaajakoodi : MonoBehaviour
{
    public int kookoslkm = 0;

    // Update is called once per frame
    void Update()
    {
        Animator animator = this.GetComponent<Animator>();
        if (animator.GetInteger("FallFlat") == 1)
        {
            if (GetComponent<Rigidbody>().linearVelocity.y == 0) // Jos velocity on 0, lis‰t‰‰n putoamisvoimaa
            {
                GetComponent<Rigidbody>().linearVelocity = new Vector3(0, -5, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        

        if (other.name.Equals("kookosx"))
        {
            kookoslkm++;
            Debug.Log("Pelaajan kookokset: " + kookoslkm);
           
        }

        if (other.name.Equals("karhu"))
        {
           
            Debug.Log("Karhu havaittu!!! ");
            this.GetComponent<Animator>().SetInteger("FallFlat", 1);
            Invoke("LopetaPeli", 3f);
        }   

    }

    private void LopetaPeli()
    {
        Debug.Log("GAME OVER.");
        Application.Quit();
    }

  
}
