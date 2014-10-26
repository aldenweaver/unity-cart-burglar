#pragma strict

var menuSkin : GUISkin;

var wood : int = 0;
var stone : int = 0;
var clay : int = 0;

var fish : int = 0;
var cookedFish : int = 0;

var bottle : int = 0;
var bottledWater : int = 0;

var bandage : int = 0;

private var showGUI : boolean = false;

function Update() {
	if(Input.GetKeyDown("i")) {
		showGUI = !showGUI;
	}
	
	if(showGUI == true) {
		Time.timeScale = 0;
	
	}

}