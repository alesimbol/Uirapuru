using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIElements : MonoBehaviour
{
    [SerializeField] Toggle hardcore;
    [SerializeField] Animator animator;
    [SerializeField] SpriteRenderer spriteRenderer;
    [SerializeField] Sprite enable;
    [SerializeField] Sprite disabled;

    // Start is called before the first frame update
   
    public void Jeferson()
    {
        animator.speed = 1;
        if (hardcore.isOn)
            animator.Play("enable");
        else
            animator.Play("disable");
    }
    private void Start()
    {
        animator.speed = 0;
        if (hardcore.isOn)
          spriteRenderer.sprite = enable;
        else
          spriteRenderer.sprite = disabled;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
