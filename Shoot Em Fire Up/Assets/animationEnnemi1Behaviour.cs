using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationEnnemi1Behaviour : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine("DestroyTheGameobject");



    }
    IEnumerator DestroyTheGameobject()
    {
        yield return new WaitForSeconds(0.3f);

        Destroy(gameObject);
    }
}

