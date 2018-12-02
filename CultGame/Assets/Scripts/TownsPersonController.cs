using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TownsPersonController : MonoBehaviour {

    private bool ePressed;
    private Animator anim;

    private bool hasGotten;

    private string[] firstNames;
    private string[] lastNames;

    private void Start()
    {
        hasGotten = false;
        anim = GetComponent<Animator>();
        firstNames = new string[] {
            "Scringly",
            "Phalanges",
            "Dopp",
            "Tump",
            "Brint",
            "Greppo",
            "Boog"
        };

        lastNames = new string[]
        {
            "Plumply",
            "McScooper",
            "Daniels",
            "Brumpus",
            "Tintly",
            "Gumptious",
            "Choogston"
        };
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E) && !hasGotten)
        {
            anim.SetBool("gotTitle", true);
            GiveName();
            hasGotten = true;
        }
    }

    private void GiveName()
    {
        GameManager.Instance.AppendNameText(AssembleName());
    }

    private string AssembleName()
    {
        
        int item1 = Random.Range(0, firstNames.Length);
        int item2 = Random.Range(0, lastNames.Length);
        string name = firstNames[item1] + " " + lastNames[item2] + ",";
        return name;
    }
}
