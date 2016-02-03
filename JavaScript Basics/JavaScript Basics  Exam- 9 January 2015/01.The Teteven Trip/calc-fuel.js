function calcFuelConsumption(array) {
    var baseFuelConsumption = 10; //per 100km
    var gasMultiplier = 1.2;
    var petrolMultiplier = 1;
    var dieselMultiplier = 0.8;
    var luggageWeightMultiplier = 0.01;//per kg
    
    var route1 = 110; //km - 100km normal road and 10km snowy road
    var route2 = 95; //km = 65km normal road and 30km snowy road

    array.forEach(function (element) {
        elementArgs = element.split(/\s+/g);
        var carBrand = elementArgs[0];
        var carFuelType = elementArgs[1];
        var carRoute = Number(elementArgs[2]);
        var carLuggageWeight = Number(elementArgs[3]);
        
        var fuelConsumption = baseFuelConsumption;
        //calc fuelType consumption
        if (carFuelType === 'gas') {
            fuelConsumption *= gasMultiplier;
        } else if (carFuelType === 'petrol') {
            fuelConsumption = baseFuelConsumption;
        } else if (carFuelType === 'diesel') {
            fuelConsumption *= dieselMultiplier;
        }

        //calc luggage extra fuel consumption
        fuelConsumption += (carLuggageWeight * luggageWeightMultiplier);
        
        //calc route fuel consumption
        if (carRoute === 1) {
            
        } else if (carRoute === 2) {
            
        }
        
        

        //print output
        console.log(carBrand + ' ' + carFuelType + ' ' + carRoute //and more);
    });
}

var input = ['BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54'];

calcFuelConsumption(input);