using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void Start()
    {
        /*уничтожает объект, к которому
         * прикреплён скрипт*/
        Destroy(gameObject);
    }

}
