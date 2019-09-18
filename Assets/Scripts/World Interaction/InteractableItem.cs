﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InteractableItem : Interactable
{
	// Inspector Fields
	[Header("Interactable Item Data")]
	[SerializeField] protected Item item;
	[SerializeField] protected int stackSize;

	public override void Interact()
	{
		HandleItem(item);
		Destroy(gameObject);
	}

	private void HandleItem(Item _item)
	{
		Toolbox.instance.GetInventoryManager().inventory.AddItem(item, stackSize);
	}

	public override void ActivateInteractionUI()
	{
		if (!hasInteractionUI) return;

		if (!activeUI)
		{
			activeUI = true;
		}
	}

	public override void DeactivateInteractionUI()
	{
		if (!hasInteractionUI) return;

		if (activeUI)
		{
			activeUI = false;
		}
	}
}
