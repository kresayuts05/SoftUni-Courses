function solve(inputArr, sortingCriteria) {
    class Ticket {
        constructor(arr) {
            this.destination = arr[0];
            this.price = Number(arr[1]);
            this.status = arr[2];
        }
    }

    let output = [];
    for (const arr of inputArr) {
        let arr1 = arr.split('|');
        output.push(new Ticket(arr1));
    }

    if (sortingCriteria === 'destination') {
        output.sort((a, b) => a.destination.localeCompare(b.destination));
    } else if (sortingCriteria === 'price') {
        output.sort();
    } else if (sortingCriteria === 'status') {
        i = 2;
        output.sort((a, b) => a.status.localeCompare(b.status));
    }

    console.log(output);

    return output;
}

solve(['Philadelphia|94.20|available',
    'New York City|95.99|available',
    'New York City|95.99|sold',
    'Boston|126.20|departed'],
    'destination'
);