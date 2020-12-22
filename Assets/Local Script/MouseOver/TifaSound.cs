using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TifaSound : MonoBehaviour
{

    public GameObject tifaSound;
    // Start is called before the first frame update
    public void Start()
    {
        tifaSound.SetActive(false);
    }

    public void OnMouseOver(){
        tifaSound.SetActive(true);
    }

    public void OnMouseExit(){
        tifaSound.SetActive(false);
    }

}
