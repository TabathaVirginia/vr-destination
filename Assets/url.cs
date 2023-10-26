using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class url : MonoBehaviour
{
    public string _url;

    public void Open() {
        Application.OpenURL(_url);
    }
}
