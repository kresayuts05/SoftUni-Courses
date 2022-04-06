class Restaurant {
    menu = {};
    stockProducts = {};
    history = [];

    constructor(budgetMoney) {
        this.budgetMoney = budgetMoney;
    }

    loadProducts(arr) {
        arr.forEach(element => {
            element = element.split(' ');

            let name = element[0];
            let quantity = Number(element[1]);
            let price = Number(element[2]);

            if (this.budgetMoney - price >= 0) {
                if (this.stockProducts[name] === undefined) {
                    this.stockProducts[name] = quantity;

                } else {
                    this.stockProducts[name] = + quantity;
                }

                this.budgetMoney -= price;

                this.history.push(`Successfully loaded ${quantity} ${name}`);
            } else {
                this.history.push(`There was not enough money to load ${quantity} ${name}`)
            }

        });

        return this.history.join('\n');
    }

    addToMenu(meal, products, price) {
        if (this.menu[meal] === undefined) {
            this.menu[meal] = { 'products': products, 'price': Number(price) };

            if (Object.keys(this.menu).length === 1) {
                return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`;
            } else if (Object.keys(this.menu).length === 0 || Object.keys(this.menu).length > 1) {
                return `Great idea! Now with the ${meal} we have ${Object.keys(this.menu).length} meals in the menu, other ideas?`;
            }
        }
        else {
            return `The ${meal} is already in the our menu, try something different.`;
        }
    }

    showTheMenu() {
        let output = [];
        Object.keys(this.menu).forEach(el => output.push(`${el} - $ ${this.menu[el].price}`));

        return output.join('\n');
    }

    makeTheOrder(meal) {
        if (this.menu[meal] === undefined) {
            return `There is not ${meal} yet in our menu, do you want to order something else?`;
        } else {
            let productsStr = this.menu[meal].products;
            let productsNeeded = {};
            let productsArr = productsStr.forEach(s => s.split(' ').forEach(p => productsNeeded[p[0]] = Number(p[1])));

            let haveAllProducts = true;

            for (const product of Object.keys(productsNeeded)) {
                if (this.stockProducts[product] === undefined && Number(this.stockProducts[product]) - Number(productsNeeded[product]) < 0) {
                    haveAllProducts = false;
                    return `For the time being, we cannot complete your order (${meal}), we are very sorry...`;
                }
            }

            if (haveAllProducts) {
                for (const product of Object.keys(productsNeeded)) {
                   this.stockProducts[product] -= Number(productsNeeded[product]);
                }

                this.budgetMoney += Number(this.menu[meal].price);

                return `Your order (${meal}) will be completed in the next 30 minutes and will cost you ${this.menu[meal].price}.`
            }
        }
    }
}

let kitchen = new Restaurant(1000);
kitchen.loadProducts(['Yogurt 30 3', 'Honey 50 4', 'Strawberries 20 10', 'Banana 5 1']);
kitchen.addToMenu('frozenYogurt', ['Yogurt 1', 'Honey 1', 'Banana 1', 'Strawberries 10'], 9.99);
console.log(kitchen.makeTheOrder('frozenYogurt'));


