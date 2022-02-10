let isEvenOdd = require('../02-even-or-odd');
let assert = require('chai').assert;
const isOddOrEven = require('../02-even-or-odd');

describe('Should test is a strings lemgth is even or odd', () => {
    it('should return even', () => {
        let str = 'kresa' // odd
        let result = isOddOrEven(str);

        assert.equal(result, 'odd');
    });
})