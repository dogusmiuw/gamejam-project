using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class Shake:MonoBehaviour
{
    [SerializeField]
    private GameObject hareket;

    private void Start() 
    {
        while (true)
        {
            StartCoroutine(SureTimeRoutuine());
        }
    }
    
    void ButtonImage()
    {
        hareket.GetComponent<RectTransform>().DOLocalMoveX(250,0.5f).SetEase(Ease.OutBack);
    }

    IEnumerator SureTimeRoutuine()
    {
        hareket.GetComponent<RectTransform>().DOLocalMoveX(250,0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
        hareket.GetComponent<RectTransform>().DOLocalMoveX(260,0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1f);
    }

}