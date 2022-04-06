class CarDealership {
    availableCars = [];
    soldCars = [];
    totalIncome = 0;

    constructor(name) {
        this.name = name;
    }

    addCar(model, horsepower, price, mileage) {
        if (model.length == 0
            || horsepower < 0
            || horsepower % 10 != 0
            || price < 0
            || mileage < 0) {
            throw new Error('Invalid input!');
        }

        let car = {
            model,
            horsepower,
            price,
            mileage
        };

        this.availableCars.push(car);

        return `New car added: ${model} - ${horsepower} HP - ${mileage.toFixed(2)} km - ${price.toFixed(2)}$`
    }

    sellCar(model, desiredMileage) {
        if (this.availableCars.find(c => c['model'] === model) == undefined) {
            throw new Error(`${model} was not found!`);
        }

        let car = this.availableCars.find(c => { return c['model'] === model });

        if (car['mileage'] > desiredMileage && car['mileage'] - desiredMileage <= 40000) {
            car['price'] -= car.price * 0.05;
        } else if (car['mileage'] - desiredMileage > 40000) {
            car['price'] -= car.price * 0.10;
        }

        this.availableCars = this.availableCars.filter(c => c['model'] !== model);

        let soldCar = {
            'model': car['model'],
            'horsepower': car['horsepower'],
            'soldPrice': car['price']
        };

        this.soldCars.push(soldCar);
        this.totalIncome += car['price'];

        return `${model} was sold for ${car['price'].toFixed(2)}$`;
    }

    currentCar() {
        if (this.availableCars.length == 0) {
            return 'There are no available cars';
        } else {
            let result = '-Available cars:';

            for (const c of this.availableCars) {
                result += '\n' + `---${c.model} - ${c.horsepower} HP - ${c.mileage.toFixed(2)} km - ${c.price.toFixed(2)}$`;
            }
            return result;
        }
    }

    salesReport(criteria) {
        if (!(criteria === 'horsepower' || criteria === 'model')) {
            throw new Error('Invalid criteria!');
        }

        if (criteria === 'horsepower') {
                this.soldCars.sort((a, b) => {
                    return b['horsepower'] - a['horsepower']; // des
                });
        } else {
            this.soldCars.sort((a, b) => {
                return a['model'].localeCompare(b['model']);//asc
            })
        }

        let result = `-${this.name} has a total income of ${this.totalIncome.toFixed(2)}$`;
        result += `\n-${this.soldCars.length} cars sold:`;

        for (const c of this.soldCars) {
            result += '\n' + `---${c.model} - ${c.horsepower} HP - ${c['soldPrice'].toFixed(2)}$`;
        }

        return result;
    }
}
let dealership = new CarDealership('SoftAuto');
dealership.addCar('Toyota Corolla', 100, 3500, 190000);
dealership.addCar('Mercedes C63', 300, 29000, 187000);
dealership.addCar('Audi A3', 120, 4900, 240000);
dealership.sellCar('Toyota Corolla', 230000);
dealership.sellCar('Mercedes C63', 110000);
console.log(dealership.salesReport('horsepower'));



