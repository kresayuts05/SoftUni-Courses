class Restaurant {
    constructor(budget) {
        this.budgetMoney = budget;
        this.menu = {};
        this.stockProducts = {};
        this.history = [];
    }

    loadProducts(products) {
        let currHistory = [];

        for (const product of products) {
            let arr = product.split(' ');
            let productName = arr[0];
            let productQuantity = Number(arr[1]);
            let price = Number(arr[2]);

            if (this.budgetMoney >= price) {
                this.budgetMoney -= price;

                const obj = {
                    name: productName,
                    quantity: productQuantity
                }

                if (this.stockProducts.productName === undefined) {
                    this.stockProducts.productName = obj;
                }
                else {
                    this.stockProducts.productName.quantity += productQuantity;
                }

                currHistory.push(`Successfully loaded ${productQuantity} ${productName}`);
                this.history.push(`Successfully loaded ${productQuantity} ${productName}`);
            } else {
                currHistory.push(`There was not enough money to load ${productQuantity} ${productName}`);
                this.history.push(`There was not enough money to load ${productQuantity} ${productName}`);
            }
        }
        currHistory = currHistory.map(x => x + '\n');
        let output = currHistory.join(''); // trim
        console.log(output);
        return output.trim();
    }

    addToMenu(meal, neededProducts, price) {

        const obj = {
            products: neededProducts,
            price: price
        }

        if (this.menu.meal === undefined) {
            this.menu.meal = obj;
        }
        else {
            return `The ${meal} is already in the our menu, try something different.`;
        }

        let keys = Object.keys(this.menu);

        let num = 0;
        for (const key in keys) {
            num++;
        }

        if (num === 1) {
            return `Great idea! Now with the ${meal} we have 1 meal in the menu, other ideas?`
        }
        else if (num > 1) // add zero
        {
            return `Great idea! Now with the ${meal} we have ${num} meals in the menu, other ideas?`;
        }
    }

    showTheMenu(){
        let output = "";

        if(this.menu === {})
        {
            return "Our menu is not ready yet, please come later...";
        }

        for (const key in this.menu) {
            output += `${key} - $ ${key.value}`;
            output += '\n';
        }

        return output;
    }

    makeTheOrder(meal){
        if(this.menu.meal === undefined)
        {
            return `There is not ${meal} yet in our menu, do you want to order something else?`
        }

        let needProducts = this.menu.meal.neededProducts;
        
    }
}

let kitchen = new Restaurant(1000);
console.log(kitchen.showTheMenu());


