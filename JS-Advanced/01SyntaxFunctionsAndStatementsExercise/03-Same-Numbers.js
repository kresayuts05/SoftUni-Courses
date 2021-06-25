function solve(numInt) {
    let  num = String(numInt);
    let output = true;
    let sum = 0; 

    for (let i = 0; i < num.length - 1; i++) {
      let element = num[i];
      let nextElement = num[i+1];

      if(element != nextElement)
      {
          output = false;
      }

      sum += Number(nextElement);
    }
    sum += Number(num[0]);

    console.log(output);
    console.log(sum);
}

console.log(solve(222252));