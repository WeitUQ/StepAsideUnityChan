using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private GameObject unityChan;
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        this.unityChan = GameObject.Find("unitychan");
        this.difference = this.unityChan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3 (0, this.transform.position.y, this.unityChan.transform.position.z - this.difference);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}
