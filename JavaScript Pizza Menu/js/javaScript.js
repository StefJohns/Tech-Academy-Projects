function pizzaOrder() {
    "use strict";
    var textPizza = "<h3>Your Pizza:</h3>",
        runningTotal = 0,
        sizeTotal = 0,
        a = 0,
        sizeArray = document.getElementsByClassName("size");
    for (a = 0; a < sizeArray.length; a++) {
		if (sizeArray[a].checked) {
			var selectedSize = sizeArray[a].value;
			textPizza = textPizza+selectedSize+" ";
		}
    }
    if (selectedSize === "10 Inch") {
        sizeTotal = 6.00
    } else if (selectedSize === "12 Inch") {
        sizeTotal = 10.00
    } else if (selectedSize === "16 Inch") {
        sizeTotal = 14.00
    } else if (selectedSize === "18 Inch") {
        sizeTotal = 16.00
    }
    runningTotal= sizeTotal;
    getCrust(runningTotal, textPizza);
};

function getCrust(runningTotal, textPizza) {
    var crustTotal = 0;
    var crustArray = document.getElementsByClassName("crust");
    for (var b = 0; b < crustArray.length; b++) {
		if (crustArray[b].checked) {
			var selectedCrust = crustArray[b].value;
			textPizza = textPizza+selectedCrust+"<br>";
		}
    }
    if (selectedCrust === "Hand Tossed") {
        crustTotal = 0.00
    } else if (selectedCrust === "Thin Crust") {
        crustTotal = 0.00
    } else if (selectedCrust === "Garlic Herb Butter") {
        crustTotal = 0.00
    } else if (selectedCrust === "Cheese Stuffed") {
        crustTotal = 3.00
    } else if (selectedCrust === "Deep Dish Style") {
        crustTotal = 0.00
    }
    runningTotal= (runningTotal + crustTotal);
    getSauce(runningTotal, textPizza);
};
function getSauce(runningTotal, textPizza) {
    var sauceTotal = 0;
    var sauceArray = document.getElementsByClassName("sauce");
    for (var c = 0; c < sauceArray.length; c++) {
		if (sauceArray[c].checked) {
			var selectedSauce = sauceArray[c].value;
			textPizza = textPizza+selectedSauce+"<br>";
		}
    }
    if (selectedSauce === "Robust Tomato") {
        sauceTotal = 0.00
    } else if (selectedSauce === "Hearty Marinara") {
        sauceTotal = 0.00
    } else if (selectedSauce === "Spicy Barbecue") {
        sauceTotal = 0.00
    } else if (selectedSauce === "Garlic Parmesan White") {
        sauceTotal = 0.00
    } 
    runningTotal= (runningTotal + sauceTotal);
    getCheese(runningTotal, textPizza);
};
function getCheese(runningTotal, textPizza) {
    var cheeseTotal = 0;
    var cheeseArray = document.getElementsByClassName("cheese");
    for (var d = 0; d < cheeseArray.length; d++) {
		if (cheeseArray[d].checked) {
			var selectedCheese = cheeseArray[d].value;
			textPizza = textPizza+selectedCheese+"<br>";
		}
    }
    if (selectedCheese === "None") {
        cheeseTotal = 0.00
    } else if (selectedCheese === "Regular") {
        cheeseTotal = 0.00
    } else if (selectedCheese === "Exxtra Cheesy") {
        cheeseTotal = 3.00
    } 
    runningTotal= (runningTotal + cheeseTotal);
    getVeg(runningTotal, textPizza);
};
function getVeg(runningTotal,textPizza) {
	var vegTotal = 0;
	var selectedVeg = [];
    var e;
	var vegArray = document.getElementsByClassName("veggies");
	for (e = 0; e < vegArray.length; e++) {
		if (vegArray[e].checked) {
            selectedVeg.push(vegArray[e].value)
			textPizza = textPizza+vegArray[e].value+"<br>";
		}
	}
	var vegCount = selectedVeg.length;
	if (vegCount >= 2) {
		vegTotal = (vegCount - 1);
	} else {
		vegTotal = 0;
	}
	runningTotal = (runningTotal + vegTotal);
    getMeat(runningTotal, textPizza);
};
function getMeat(runningTotal, textPizza) {
    var meatTotal = 0;
	var selectedMeat = [];
	var meatArray = document.getElementsByClassName("meats");
	for (var f = 0; f < meatArray.length; f++) {
		if (meatArray[f].checked) {
			selectedMeat.push(meatArray[f].value);
			textPizza = textPizza+meatArray[f].value+"<br>";
		}
	}
	var meatCount = selectedMeat.length;
	if (meatCount >= 2) {
		meatTotal = (meatCount - 1);
	} else {
		meatTotal = 0;
	}
	runningTotal = (runningTotal + meatTotal);
	document.getElementById("showText").innerHTML=textPizza;
	document.getElementById("totalPrice").innerHTML = "<h3>Total: <strong>$"+runningTotal+"</strong></h3>";
};

