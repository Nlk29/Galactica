using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;

public class DragWindow : MonoBehaviour, IDragHandler
{
	[SerializeField]
	private RectTransform dragRectTransform;

	public void OnDrag(PointerEventData eventData)
	{
		
	}
}
