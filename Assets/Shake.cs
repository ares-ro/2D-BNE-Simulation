using NUnit.Framework;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shake : MonoBehaviour
{
    static Shake instance;

    float shakeStrength = 0;
    float shakeSpeed = 0;
    bool isRun = false;

    List<Vector2> posSeqList = new List<Vector2>();
    float lerpCut = 0.01f;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {

    }

    int moveSeq = 0;

    void FixedUpdate()
    {
        if (isRun)
        {
            if (moveSeq == 0 & gameObject.transform.localPosition.x > shakeStrength - lerpCut)
            {
                moveSeq = 1;
            }
            if (moveSeq == 1 & gameObject.transform.localPosition.x < lerpCut)
            {
                moveSeq = 2;
            }
            if (moveSeq == 2 & gameObject.transform.localPosition.x < -shakeStrength + lerpCut)
            {
                moveSeq = 3;
            }
            if (moveSeq == 3 & gameObject.transform.localPosition.x > -lerpCut)
            {
                moveSeq = 4;
            }

            if (moveSeq == 4 & gameObject.transform.localPosition.y > shakeStrength - lerpCut)
            {
                moveSeq = 5;
            }
            if (moveSeq == 5 & gameObject.transform.localPosition.y < lerpCut)
            {
                moveSeq = 6;
            }
            if (moveSeq == 6 & gameObject.transform.localPosition.y < -shakeStrength + lerpCut)
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

    public static void SetAndRun(float shakeStrength, float shakeSpeed, bool isRun)
    {
        instance.shakeStrength = shakeStrength;
        instance.shakeSpeed = shakeSpeed;

        instance.posSeqList.Clear();
        instance.posSeqList.Add(new Vector2(shakeStrength, 0));
        instance.posSeqList.Add(new Vector2(0, 0));
        instance.posSeqList.Add(new Vector2(-shakeStrength, 0));
        instance.posSeqList.Add(new Vector2(0, 0));
        instance.posSeqList.Add(new Vector2(0, shakeStrength));
        instance.posSeqList.Add(new Vector2(0, 0));
        instance.posSeqList.Add(new Vector2(0, -shakeStrength));
        instance.posSeqList.Add(new Vector2(0, 0));

        instance.isRun = isRun;
    }
    public static void Stop()
    {
        instance.isRun = false;
    }
}
