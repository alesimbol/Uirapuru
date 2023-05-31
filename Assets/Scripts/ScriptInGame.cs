using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptInGame : MonoBehaviour
{
    [SerializeField]
    GameObject Hud;
    [SerializeField]
    GameObject Inventario;
    [SerializeField]
    GameObject MenuHabilidades;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I) && Hud.activeSelf == true)
        {
            Hud.SetActive(false);
            Inventario.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            Hud.SetActive(true);
            Inventario.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.H) && Hud.activeSelf == true)
        {
            Hud.SetActive(false);
            MenuHabilidades.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.H))
        {
            Hud.SetActive(true);
            MenuHabilidades.SetActive(false);
        }

    }
}
