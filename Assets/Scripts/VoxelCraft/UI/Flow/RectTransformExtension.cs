using UnityEngine;

public static class RectTransformExtension
{
    public static void FillFull(this RectTransform rectTransform)
    {
        rectTransform.localPosition = Vector3.zero;
        rectTransform.anchorMin = Vector2.zero;
        rectTransform.anchorMax = Vector2.one;
        rectTransform.pivot = new Vector2(0.5f, 0.5f);

        rectTransform.sizeDelta = rectTransform.parent.GetComponent<RectTransform>().sizeDelta;
    }
}