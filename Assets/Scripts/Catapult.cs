using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult : MonoBehaviour
{
    [SerializeField]private int  _timer = 5;
     [SerializeField]private GameObject _canon;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other) {
        Invoke("SetActive",_timer);
        Debug.Log("hello");
    }
    
     private void SetActive(){
        _canon.SetActive(true);
        Debug.Log("bye");
    }
}
