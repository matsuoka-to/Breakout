using UnityEngine;
using System;

public class Block : MonoBehaviour
{
    [SerializeField]
    MeshRenderer meshRenderer;

    int type;
    Action callback;

    public void SetInit(int type, Action callback)
    {
        this.type = type;
        this.callback = callback;


        switch(type)
        {
            case 0:
                meshRenderer.material.color = Color.blue;
                break;
            case 1:
                meshRenderer.material.color = Color.red;
                break;
            case 2:
                meshRenderer.material.color = Color.yellow;
                break;
            case 3:
                meshRenderer.material.color = Color.magenta;
                break;
            case 4:
                meshRenderer.material.color = Color.cyan;
                break;

            default:
                break;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        callback?.Invoke();
    }
}
