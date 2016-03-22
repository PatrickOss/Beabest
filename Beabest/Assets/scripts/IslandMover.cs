using UnityEngine;
using System.Collections;
using DG.Tweening;

public class IslandMover : MonoBehaviour
{

    public float posiotion;
    public float speed; // less means faster
    int loops = 20000000;  
    
    void Start()
    {
        DOTween.Init(false, true, LogBehaviour.ErrorsOnly); // dont know what it does       
        transform.DOLocalMoveY(posiotion,speed).SetRelative().SetLoops(loops,LoopType.Yoyo); // this makes our object change his position like yoyo
    }

}
