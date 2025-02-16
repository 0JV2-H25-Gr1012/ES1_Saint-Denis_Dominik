using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    
     [SerializeField]private int  _timer = 5;
     [SerializeField] private GameObject _clef;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter(Collision other){
        
        if(other.gameObject == _clef ){
       Invoke("Off", _timer);}
    }
    private void Off(){
        gameObject.SetActive(false);
    }
}
