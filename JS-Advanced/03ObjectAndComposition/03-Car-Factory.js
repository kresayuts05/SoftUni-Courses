function solve(inputCar) {
    let power = Number(inputCar.power);
    let car = {
        model: inputCar.model,
        engine: {},
        carriage: {
            type: inputCar.carriage,
            color: inputCar.color,
        },
        wheels: [],
    };

    if (power <= 90) {
        car.engine.power = 90;
        car.engine.volume = 1800;
    } else if (power <= 120) {
        car.engine.power = 120;
        car.engine.volume = 2400;
    } else {
        car.engine.power = 200;
        car.engine.volume = 3500;
    };

    let wheelsize = Number(inputCar.wheelsize);
    if (wheelsize % 2 === 0) {
        wheelsize -= 1;
    }

    for (let index = 0; index < 4; index++) {
        car.wheels.push(wheelsize);
    }

    return car;
}

solve({
    model: 'Opel Vectra',
    power: 110,
    color: 'grey',
    carriage: 'coupe',
    wheelsize: 17
}
);
