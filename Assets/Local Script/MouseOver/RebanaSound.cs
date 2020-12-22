using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RebanaSound : MonoBehaviour
{

    public GameObject rebanaSound;
    // Start is called before the first frame update
    public void Start()
    {
        rebanaSound.SetActive(false);
    }

    public void OnMouseOver(){
        rebanaSound.SetActive(true);
    }

    public void OnMouseExit(){
        rebanaSound.SetActive(false);
    }

}
