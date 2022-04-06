const testNumbers = {
    sumNumbers: function (num1, num2) {
        let sum = 0;

        if (typeof(num1) !== 'number' || typeof(num2) !== 'number') {
            return undefined;
        } else {
            sum = (num1 + num2).toFixed(2);
            return sum
        }
    },
    numberChecker: function (input) {
        input = Number(input);

        if (isNaN(input)) {
            throw new Error('The input is not a number!');
        }

        if (input % 2 === 0) {
            return 'The number is even!';
        } else {
            return 'The number is odd!';
        }

    },
    averageSumArray: function (arr) {

        let arraySum = 0;

        for (let i = 0; i < arr.length; i++) {
            arraySum += arr[i]
        }

        return arraySum / arr.length
    }
};

let expect = require ("chai").expect;

describe("testFunction", function() {
    describe("sumNumbers", function() {
        it("are numbers", function() {
             let n = 5;
             let n1 = 7;
             let n2 = -5
             let str = 'kresa'

            expect(testNumbers.sumNumbers(n, n1)).to.equal('12.00');
            expect(testNumbers.sumNumbers(n2, n1)).to.equal('2.00');
            expect(testNumbers.sumNumbers(n2, n1)).to.not.equal('2');
            expect(testNumbers.sumNumbers(n, str)).to.equal(undefined);
        }); 
     });

     describe("numberChecker", function() {
        it("validate", function() {
            expect(() => testNumbers.numberChecker('str')).to.throw(Error, 'The input is not a number!');
            expect(() => testNumbers.numberChecker('NaN')).to.throw(Error, 'The input is not a number!');
            expect(testNumbers.numberChecker('5')).to.equal('The number is odd!');
            expect(testNumbers.numberChecker('4')).to.equal('The number is even!');
            expect(testNumbers.numberChecker(5)).to.equal('The number is odd!');
            expect(testNumbers.numberChecker(4)).to.equal('The number is even!');
        }); 
     });

     describe("averageSumArray", function() {
        it("test", function() {
            let arr = [1, 2, 6, 4, 5];

            expect(testNumbers.averageSumArray(arr)).to.equal(3.6)
        }); 
     });

});

