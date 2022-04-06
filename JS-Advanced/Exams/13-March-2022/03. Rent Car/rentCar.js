const rentCar = {
    searchCar(shop, model) {
        let findModel = [];
        if (Array.isArray(shop) && typeof model == 'string') {
            for (let i = 0; i < shop.length; i++) {
                if (model == shop[i]) {
                    findModel.push(shop[i]);
                }
            }
            if (findModel.length !== 0) {
                return `There is ${findModel.length} car of model ${model} in the catalog!`;
            } else {
                throw new Error('There are no such models in the catalog!')
            }
        } else {
            throw new Error('Invalid input!')
        }
    },
    calculatePriceOfCar(model, days) {
        let catalogue = {
            Volkswagen: 20,
            Audi: 36,
            Toyota: 40,
            BMW: 45,
            Mercedes: 50
        };

        if (typeof model == 'string' && Number.isInteger(days)) {
            if (catalogue.hasOwnProperty(model)) {
                let cost = catalogue[model] * days;
                return `You choose ${model} and it will cost $${cost}!`
            } else {
                throw new Error('No such model in the catalog!')
            }
        } else {
            throw new Error('Invalid input!')
        }
    },
    checkBudget(costPerDay, days, budget) {
        if (!Number.isInteger(costPerDay) 
        || !Number.isInteger(days) 
        || !Number.isInteger(budget)) {
            throw new Error('Invalid input!');
        } else {
            let cost = costPerDay * days;
            if (cost <= budget) {
                return `You rent a car!`
            } else {
                return 'You need a bigger budget!'
            }
        }
    }
};

let expect = require ("chai").expect;

describe("rentCar", function() {
    describe("searchCar", function() {
        it("1", function() {
            let arr = ["Volkswagen", "BMW", "Audi"];
            let model = 'BMW';

            expect(rentCar.searchCar(arr, model)).to.equal(`There is 1 car of model BMW in the catalog!`)
        });
        it("invalid", function() {
            expect(() => {rentCar.searchCar(["Volkswagen", "BMW", "Audi"], 5)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.searchCar({}, 'kfh')}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.searchCar([], 'BMW')}).to.throw(Error, 'There are no such models in the catalog!');
        });
     });

     describe("calculatePriceOfCar", function() {
        it("2", function() {
                expect(() => {rentCar.calculatePriceOfCar('BMW', '')}).to.throw(Error, 'Invalid input!');
                expect(() => {rentCar.calculatePriceOfCar([], '')}).to.throw(Error, 'Invalid input!');
                expect(() => {rentCar.calculatePriceOfCar(undefined, 5)}).to.throw(Error, 'Invalid input!');
                expect(() => {rentCar.calculatePriceOfCar('scs', 5.4)}).to.throw(Error, 'Invalid input!');
                expect(() => {rentCar.calculatePriceOfCar('kjhfgudi', 2)}).to.throw(Error, 'No such model in the catalog!');

              expect(rentCar.calculatePriceOfCar('BMW', 2)).to.equal('You choose BMW and it will cost $90!')
            });
     });

     describe("checkBudget", function() {
        it("3", function() {
            expect(() => {rentCar.checkBudget(undefined, 5, 4)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(undefined, 5, 4)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(undefined, 5, 4)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(5, {}, [])}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(undefined, 5, 0)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(NaN, 5, 0)}).to.throw(Error, 'Invalid input!');
         //   expect(() => {rentCar.checkBudget(4, 5, 0.1)}).to.throw(Error, 'Invalid input!');
            expect(() => {rentCar.checkBudget(1.5, 5, 0)}).to.throw(Error, 'Invalid input!');

            expect(rentCar.checkBudget(10, 2, 50)).to.equal(`You rent a car!`);
            expect(rentCar.checkBudget(10, 2, 20)).to.equal(`You rent a car!`);
            expect(rentCar.checkBudget(10, 2, 10)).to.equal('You need a bigger budget!');
        });
     });
});
