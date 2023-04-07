using DG.Tweening;
using UnityEngine;

public class DoTweenTest : MonoBehaviour
{
    public Material material;
    private void Start()
    {
        DOTween.Sequence()
            .Append(transform.DOMove(new Vector3(-4f, 0f, 4f), 2f))
            .AppendInterval(1f)
            .Append(transform.DOMove(new Vector3(4f, 0f, 4f), 2f))
            .Append(transform.DOScale(2f, 2f))
            .Append(material.DOColor(new Color(87f, 255f, 160f), 1f))
            .Append(transform.DOMove(new Vector3(0f, 0f, 0f), 1f))
            .Append(transform.DORotate(new Vector3(45f, 0f, 45f), 1f));
    }
}
