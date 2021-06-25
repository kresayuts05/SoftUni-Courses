function solve(input) {
    input.sort((a, b) => a.localeCompare(b)).forEach((el, index) => console.log((index + 1) + '.' + el));

    // for (let i = 0; i < input.length; i++) {
    //     console.log(i + 1 + `.${input[i]}`)
    // }
}

solve(["John", "Bob", "Christina", "Ema"])