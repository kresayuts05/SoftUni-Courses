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

let { expect } = require('chai');

describe("companyAdministration", function () {
    describe("hiringEmployee", function () {
        it("1", function () {
            expect(() => companyAdministration.hiringEmployee('kresa', 'chef', 14)).to.throw(Error, 'We are not looking for workers for this position.');

            expect(companyAdministration.hiringEmployee('kresa', 'Programmer', 3)).to.equal(`kresa was successfully hired for the position Programmer.`);
            expect(companyAdministration.hiringEmployee('kresa', 'Programmer', 5)).to.equal(`kresa was successfully hired for the position Programmer.`);

            expect(companyAdministration.hiringEmployee('kresa', 'Programmer', 1)).to.equal(`kresa is not approved for this position.`);
        });
    });

    describe("calculateSalary", function () {
        it("2", function () {
            expect(companyAdministration.calculateSalary(4)).to.equal(60);
            expect(companyAdministration.calculateSalary(0)).to.equal(0);
            expect(companyAdministration.calculateSalary(160)).to.equal(15 * 160);
            expect(companyAdministration.calculateSalary(161)).to.equal(15*161 + 1000);

            expect(() => companyAdministration.calculateSalary(-1)).to.throw(Error, "Invalid hours");
            expect(() =>companyAdministration.calculateSalary(undefined)).to.throw(Error, "Invalid hours");
            expect(() =>companyAdministration.calculateSalary({})).to.throw(Error, "Invalid hours");
            expect(() =>companyAdministration.calculateSalary([])).to.throw(Error, "Invalid hours");
        });
    });

    describe("firedEmployee", function () {
        it("3", function () {
            expect(companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 1)).to.equal('Petar, George');

            expect(() => companyAdministration.firedEmployee({}, 1)).to.throw(Error, 'Invalid input');
            expect(() => companyAdministration.firedEmployee(undefined, 1)).to.throw(Error, 'Invalid input');
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], -1)).to.throw(Error, 'Invalid input');
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], 5)).to.throw(Error, 'Invalid input');
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], {})).to.throw(Error, 'Invalid input');
            expect(() => companyAdministration.firedEmployee(["Petar", "Ivan", "George"], undefined)).to.throw(Error, 'Invalid input');
        });
    });
});