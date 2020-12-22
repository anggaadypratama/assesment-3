using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KetipungSound : MonoBehaviour
{

    public GameObject ketipungSound;
    // Start is called before the first frame update
    public void Start()
    {
        ketipungSound.SetActive(false);
    }

    public void OnMouseOver(){
        ketipungSound.SetActive(true);
    }

    public void OnMouseExit(){
        ketipungSound.SetActive(false);
    }

}
