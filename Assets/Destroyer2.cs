using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer2 : MonoBehaviour
{
    private Renderer renderer;
    private bool enabled = false;
    // Start is called before the first frame update
    void Start()
    {
        this.renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //objectが画面内に一度映ってから消えたら破壊する。
        if (!this.enabled && renderer.isVisible)
        {
            this.enabled = true;
        }
        if (this.enabled && !renderer.isVisible)
            Destroy(this.gameObject);
    }
}
