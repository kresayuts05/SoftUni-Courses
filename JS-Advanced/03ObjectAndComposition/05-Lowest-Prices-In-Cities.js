function solve(input) {
    let result = {};

    for (const step of input) {
        let [currTown, product, currPrice] = step.split(' | ');
        currPrice = Number(currPrice);

        if (result[product] == undefined || result[product].price > currPrice) {
            result[product] = {
                price: currPrice,
                town: currTown,
            };
        }
    }

    for (const product in result) {
        console.log(`${product} -> ${result[product].price} (${result[product].town})`);
    }
}

solve(['Sample Town | Sample Product | 1000',
    'Sample Town | Orange | 2',
    'Sample Town | Peach | 1',
    'Sofia | Orange | 3',
    'Sofia | Peach | 2',
    'New York | Sample Product | 1000.1',
    'New York | Burger | 10']
)