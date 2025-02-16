using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartScene : MonoBehaviour
{
    [SerializeField]private int  _timer = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "BilleRouge"){
        Invoke("Restart",_timer);}
    }
    private void Restart(){
       SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
