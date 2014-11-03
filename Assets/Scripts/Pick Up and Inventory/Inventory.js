// Script modified from:

// Inventory
public static var inventoryArray : int[] = [1, 2, 0, 0, 0];
var inventoryText: GameObject;

function Update() {

	inventoryText.guiText.text = "Gold Coins " + "[" + inventoryArray[0] + "]" + "\n" + "Damage " + "[" + inventoryArray[1] + "]";

	//inventoryArray[0]++;
	//inventoryArray[1]++;
}