function solve(input) {
    let output = [];
    let num = 1;

    for (let i = 0; i < input.length; i++) {
        if (input[i] === 'add') {
            output.push(num);
            num++;
        }
        else {
            output.pop();
            num++;
        }
    }

    if (output.length == 0) {
        console.log('Empty');
    }
    else {
        for (let i = 0; i < output.length; i++) {
            console.log(output[i]);
        }
    }
}

solve(['add',
    'add',
    'remove',
    'add',
    'add']
);