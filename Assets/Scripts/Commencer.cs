using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commencer : MonoBehaviour
{
    [SerializeField] private GameObject _plateforme;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetUnactive(){
       _plateforme.SetActive(false);
    }
}
