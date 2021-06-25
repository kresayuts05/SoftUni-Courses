function solve(input) {
    let output = [];

    input.sort((a, b) => a - b);

    if (input.length % 2 == 1) {
        while (input.length > 1) {
            let min = input.shift();
            let max = input.pop();

            output.push(min);
            output.push(max);
        }

        output.push(input[0]);

        //input[Math.floor(input.length / 2)];
    }
    else {
        while (input.length > 0) {
            let min = input.shift();
            let max = input.pop();

            output.push(min);
            output.push(max);
        }
    }

    return output;
}

console.log(solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]));