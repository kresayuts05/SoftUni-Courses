let expect = require ("chai").expect
let testNumbers = require("./testNumbers.js")

describe("testFunction …", function() {
    describe("sumNumbers", function() {
        it("are numbers", function() {
             let n = 5;
             let n1 = 7;
             let n2 = -5
             let str = 'kresa'

            expect(testNumbers.sumNumbers(n, n1)).to.equal(12);
            expect(testNumbers.sumNumbers(n2, n1)).to.equal(2);
            expect(testNumbers.sumNumbers(n, str)).to.equal(undefined);
        });
     });
     // TODO: …
});
