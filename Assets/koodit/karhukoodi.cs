using UnityEngine;
using UnityEngine.AI;

public class karhukoodi : MonoBehaviour
{

    public GameObject kohde = null;

    // Update is called once per frame
    void Update()
    {
        //navigointi tänne
       this.GetComponent<NavMeshAgent>().SetDestination(this.kohde.GetComponent<Transform>().position);
    }

    private void OnTriggerEnter(Collider other)
    {
        Animator animator = this.GetComponent<Animator>();
        int nykJuoksutila = animator.GetInteger("juoksutila");

        if (other.name.Equals("pelaaja"))
        {
            this.GetComponent<Animator>().SetInteger("juoksutila", 1);

        }

        if (nykJuoksutila == 1)
        {
            this.GetComponent<Animator>().SetInteger("juoksutila", 2);
        }

    }



    
}
