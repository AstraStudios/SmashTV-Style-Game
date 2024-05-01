using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunLogic : MonoBehaviour
{
    [SerializeField] GameObject firePoint;
    //[SerializeField] GameObject bullet;

    RaycastHit2D hit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) FireRound();
    }

    void FireRound() {
        RaycastHit2D newHit = Physics2D.Raycast(firePoint.transform.position, -firePoint.transform.right);

        //if (!newHit.collider.CompareTag("Wall")) return;

        hit =  newHit;

        //Debug.Log(hit.collider.name);
        Debug.Log("Fired the glorious gun");
    }
}
