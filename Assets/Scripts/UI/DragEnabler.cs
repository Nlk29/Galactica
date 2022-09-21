using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DragEnabler : MonoBehaviour, IDragHandler
{
	[SerializeField]
	private RectTransform dragRectTransform;

	private Canvas canvas;

	void Start()
	{
		GameObject temp = GameObject.FindGameObjectWithTag("Canvas");

		canvas = temp.GetComponent<Canvas>();
	}

	public void OnDrag(PointerEventData eventData)
	{
		dragRectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
	}
}
