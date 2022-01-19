function solve(input) {
    let result = {};

    input.sort(function (a, b) {
        return a[1] - b[1];
    });

    for (const step of input) {
        let [product, price] = step.split(' : ');

        if (result[product.charAt(0)] == undefined) {
            result[product.charAt(0)] = {};
        }

        result[product.charAt(0)][product] = Number(price);
    }
    console.log(result);
}

solve(['Appricot : 20.4',
    'Fridge : 1500',
    'TV : 1499',
    'Deodorant : 10',
    'Boiler : 300',
    'Apple : 1.25',
    'Anti-Bug Spray : 15',
    'T-Shirt : 10']
)