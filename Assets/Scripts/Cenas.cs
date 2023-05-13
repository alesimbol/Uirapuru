using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Cenas : MonoBehaviour
{
    [SerializeField] GameObject PressStart;
    [SerializeField] GameObject TittleScreen;
    [SerializeField] GameObject FundoPreto;

    [SerializeField] GameObject newGame;
    public void TrocarCena(string cena)
    {
        SceneManager.LoadScene(cena);
    }
    public void Update()
    {
        if (Input.anyKeyDown && PressStart.activeSelf)
        {
            PressStart.SetActive(false);
            TittleScreen.SetActive(true);
            FundoPreto.SetActive(true);
        }
    }
    public void SetNewGameActive()
    {
        newGame.SetActive(true);
    }
}
