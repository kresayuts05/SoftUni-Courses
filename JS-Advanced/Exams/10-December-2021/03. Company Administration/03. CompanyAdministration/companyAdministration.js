const companyAdministration = {

    hiringEmployee(name, position, yearsExperience) {
        if (position == "Programmer") {
            if (yearsExperience >= 3) {
                return `${name} was successfully hired for the position ${position}.`;
            } else {
                return `${name} is not approved for this position.`;
            }
        }
        throw new Error(`We are not looking for workers for this position.`);
    },
    calculateSalary(hours) {

        let payPerHour = 15;
        let totalAmount = payPerHour * hours;

        if (typeof hours !== "number" || hours < 0) {
            throw new Error("Invalid hours");
        } else if (hours > 160) {
            totalAmount += 1000;
        }
        return totalAmount;
    },
    firedEmployee(employees, index) {

        let result = [];

        if (!Array.isArray(employees) || !Number.isInteger(index) || index < 0 || index >= employees.length) {
            throw new Error("Invalid input");
        }
        for (let i = 0; i < employees.length; i++) {
            if (i !== index) {
                result.push(employees[i]);
            }
        }
        return result.join(", ");
    }

}

let {expect} = require ('chai')

describe("companyAdministration", function() {
    describe("hiringEmployee", function() {
        it("1", function() {
            expect(() => companyAdministration.hiringEmployee('kresa', 'chef', 14)).to.throw(Error, 'We are not looking for workers for this position.');
            
            expect(companyAdministration.hiringEmployee('kresa', 'Programmer', 3)).to.equal(`kresa was successfully hired for the position Programmer.`);
            expect(companyAdministration.hiringEmployee('kresa', 'Programmer', 5)).to.equal(`kresa was successfully hired for the position Programmer.`);
           
            expect(() => companyAdministration.hiringEmployee('kresa', 'Programmer', 2)).to.throw(Error, `kresa is not approved for this position.`);
        });
     });
});
