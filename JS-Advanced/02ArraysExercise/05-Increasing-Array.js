function solve(input) {
    let output = [];
    let currMax = input[0];

    output.push(currMax);    

    for (let i = 1; i < input.length; i++) {
        if(currMax <= input[i]){
            currMax = input[i];
            output.push(currMax);
        }
    }

    return output;
}

console.log(solve([1,
    3,
    8,
    4,
    10,
    12,
    3,
    2,
    24]
)); 