function solve(array, num) {
    let output = [];

    for (let i = 0; i < array.length; i += num) {
        output.push(array[i]);
    }

    return output;
}

console.log(solve(['5', 
'20', 
'31', 
'4', 
'20'], 
2
));