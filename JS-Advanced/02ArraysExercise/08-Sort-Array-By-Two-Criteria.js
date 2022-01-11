function solve(arr){
    arr = arr.sort((a, b) => a.length - b.length || a.localeCompare(b));
    for(let el of arr){
        console.log(el);
    } 
 }
 
solve(['alpha',
    'beta',
    'gamma']
)