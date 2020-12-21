using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KetipungText : MonoBehaviour
{

    public GameObject ketipungText;
    // Start is called before the first frame update
    public void Start()
    {
        ketipungText.SetActive(false);
    }

    public void OnMouseOver(){
        ketipungText.SetActive(true);
    }

    public void OnMouseExit(){
        ketipungText.SetActive(false);
    }

}
