using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    List<Vector2> posSeqList = new List<Vector2>();
    float posBias = 55f;
    float lerpCut = 0.01f;
    float shakeSpeed = 0.8f;

    void Start()
    {
        posSeqList.Add(new Vector2(posBias, 0));
        posSeqList.Add(new Vector2(0, 0));
        posSeqList.Add(new Vector2(-posBias, 0));
        posSeqList.Add(new Vector2(0, 0));
        posSeqList.Add(new Vector2(0, posBias));
        posSeqList.Add(new Vector2(0, 0));
        posSeqList.Add(new Vector2(0, -posBias));
        posSeqList.Add(new Vector2(0, 0));
    }
    
    int moveSeq = 0;

    void FixedUpdate()
    {
        if (moveSeq == 0 & gameObject.transform.localPosition.x > posBias - lerpCut)
        {
            moveSeq = 1;
        }
        if (moveSeq == 1 & gameObject.transform.localPosition.x < lerpCut)
        {
            moveSeq = 2;
        }
        if (moveSeq == 2 & gameObject.transform.localPosition.x < -posBias + lerpCut)
        {
            moveSeq = 3;
        }
        if (moveSeq == 3 & gameObject.transform.localPosition.x > -lerpCut)
        {
            moveSeq = 4;
        }

        if (moveSeq == 4 & gameObject.transform.localPosition.y > posBias - lerpCut)
        {
            moveSeq = 5;
        }
        if (moveSeq == 5 & gameObject.transform.localPosition.y < lerpCut)
        {
            moveSeq = 6;
        }
        if (moveSeq == 6 & gameObject.transform.localPosition.y < -posBias + lerpCut)
        {
            moveSeq = 7;
        }
        if (moveSeq == 7 & gameObject.transform.localPosition.y > -lerpCut)
        {
            moveSeq = 0;
        }

        switch (moveSeq)
        {
            case 0:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[0], shakeSpeed);
                    break;
                }
            case 1:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[1], shakeSpeed);
                    break;
                }
            case 2:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[2], shakeSpeed);
                    break;
                }
            case 3:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[3], shakeSpeed);
                    break;
                }
            case 4:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[4], shakeSpeed);
                    break;
                }
            case 5:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[5], shakeSpeed);
                    break;
                }
            case 6:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[6], shakeSpeed);
                    break;
                }
            case 7:
                {
                    gameObject.transform.localPosition = Vector2.Lerp(gameObject.transform.localPosition, posSeqList[7], shakeSpeed);
                    break;
                }
        }
    }
}
