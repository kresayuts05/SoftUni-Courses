function solve(arr, rotate){
    for(let i = 1; i <= rotate; i++){
        let first = arr.pop();

        arr.unshift(first);
    }

    console.log(arr.join(' '));
}

solve(['Banana', 
'Orange', 
'Coconut', 
'Apple'], 
15
);