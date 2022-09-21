using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class DragEnabler : MonoBehaviour, IDragHandler, IPointerDownHandler
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

	public void OnPointerDown(PointerEventData eventData)
	{
		dragRectTransform.SetAsLastSibling();
	}
}
