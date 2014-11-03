#pragma strict

function Start () {

}

function Update () {

}

function OnTriggerEnter(collider : Collider) {
	if(collider.gameObject.tag == "Player") {
		Inventory.inventoryArray[0]++;
		Destroy(this.gameObject);
	
	}
}