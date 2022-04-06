class VegetableStore {
    availableProducts = [];

    constructor(owner, location) {
        this.owner = owner;
        this.location = location;
    }

    loadingVegetables(vegetables) {
        let added = [];

        vegetables.forEach(v => {
            let vegetable = v.split(' ');

            let type = vegetable[0];
            let quantity = Number(vegetable[1]);
            let price = Number(vegetable[2]);

            let exist = this.availableProducts.find(v => v['type'] === type);

            if (exist !== undefined) {
                if (exist['price'] < price) {
                    exist['price'] = price;
                }

                exist['quantity'] += quantity;
            } else {
                let newVegetable = {
                    type,
                    quantity,
                    price
                };

                this.availableProducts.push(newVegetable);
            }

            added.push(type);
        });

        function onlyUnique(value, index, self) {
            return self.indexOf(value) === index;
        };

        let distinctV = added.filter(onlyUnique);

        return 'Successfully added ' + distinctV.join(', ');
    }

    buyingVegetables(selectedProducts) {
        let totalPrice = 0;

        selectedProducts.forEach(v => {
            let vegetable = v.split(' ');

            let type = vegetable[0];
            let quantity = Number(vegetable[1]);

            let exist = this.availableProducts.find(v => v['type'] === type);

            if (exist === undefined) {
                throw new Error(`${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`);
            }

            if (exist['quantity'] < quantity) {
                throw new Error(`The quantity ${quantity} for the vegetable ${type} is not available in the store, your current bill is $${totalPrice.toFixed(2)}.`)
            }

            exist['quantity'] -= quantity;
            totalPrice += quantity * Number(exist['price']);
        });
        return `Great choice! You must pay the following amount $${totalPrice.toFixed(2)}.`
    }

    rottingVegetable(type, quantity) {
        let exist = this.availableProducts.find(v => v['type'] === type);

        if (exist === undefined) {
            throw new Error(`${type} is not available in the store.`);
        }

        if (exist['quantity'] < quantity) {/////////////
            exist['quantity'] = 0;

            return `The entire quantity of the ${type} has been removed.`;
        }

        exist['quantity'] -= quantity;

        return `Some quantity of the ${type} has been removed.`;
    }

    revision() {
        let result = "Available vegetables:";

        this.availableProducts.sort((a, b) => {
            return a['price'] - b['price'];
        });

        this.availableProducts.forEach(v => result += '\n' + `${v['type']}-${v['quantity']}-$${v['price']}`)

        result += '\n' + `The owner of the store is ${this.owner}, and the location is ${this.location}.`

        return result;
    }
}

