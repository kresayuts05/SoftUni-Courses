const flowerShop = {
    calcPriceOfFlowers(flower, price, quantity) {
        if (typeof flower != 'string' || !Number.isInteger(price) || !Number.isInteger(quantity)) {
            throw new Error('Invalid input!');
        } else {
            let result = price * quantity;
            return `You need $${result.toFixed(2)} to buy ${flower}!`;
        }
    },
    checkFlowersAvailable(flower, gardenArr) {
        if (gardenArr.indexOf(flower) >= 0) {
            return `The ${flower} are available!`;
        } else {
            return `The ${flower} are sold! You need to purchase more!`;
        }
    },
    sellFlowers(gardenArr, space) {
        let shop = [];
        let i = 0;
        if (!Array.isArray(gardenArr) || !Number.isInteger(space) || space < 0 || space >= gardenArr.length) {
            throw new Error('Invalid input!');
        } else {
            while (gardenArr.length > i) {
                if (i != space) {
                    shop.push(gardenArr[i]);
                }
                i++
            }
        }
        return shop.join(' / ');
    }
}

let { expect } = require('chai')

describe("flowerShop", function () {
    describe("calcPriceOfFlowers", function () {
        it("1", function () {
            expect(flowerShop.calcPriceOfFlowers('kresa', 2, 10)).to.equal(`You need $20.00 to buy kresa!`);

            expect(() => flowerShop.calcPriceOfFlowers('kresa', 2.4, 10)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers(5, 4, 10)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('kresa', 2, 'str')).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers(undefined, 2, 'str')).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('kresa', undefined, 'str')).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.calcPriceOfFlowers('kresa', {}, 'str')).to.throw(Error, 'Invalid input!');

            let result = flowerShop.calcPriceOfFlowers('kresa', 2, 10);
            expect(result).to.equal(`You need $20.00 to buy kresa!`);
        });
    });

    describe("checkFlowersAvailable", function () {
        it("2", function () {
            expect(flowerShop.checkFlowersAvailable("Rose", ["Rose", "Lily", "Orchid"])).to.equal(`The Rose are available!`);
            expect(flowerShop.checkFlowersAvailable("Rose", ["Lily", "Orchid"])).to.equal(`The Rose are sold! You need to purchase more!`);
        });
    });

    describe("sellFlowers", function () {
        it("3", function () {
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 4)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], undefined)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], -1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers(undefined, 1)).to.throw(Error, 'Invalid input!');
            expect(() => flowerShop.sellFlowers({}, 1)).to.throw(Error, 'Invalid input!');

            expect(flowerShop.sellFlowers(["Rose", "Lily", "Orchid"], 1)).to.equal('Rose / Orchid');
        });
    });
});

