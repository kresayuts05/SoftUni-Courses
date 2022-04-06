const bookSelection = {
  isGenreSuitable(genre, age) {
    if (age <= 12 && (genre === "Thriller" || genre === "Horror")) {
      return `Books with ${genre} genre are not suitable for kids at ${age} age`;
    } else {
      return `Those books are suitable`;
    }
  },
  isItAffordable(price, budget) {
    if (typeof price !== "number" || typeof budget !== "number") {
      throw new Error("Invalid input");
    }

    let result = budget - price;

    if (result < 0) {
      return "You don't have enough money";
    } else {
      return `Book bought. You have ${result}$ left`;
    }
  },
  suitableTitles(array, wantedGenre) {
    let resultArr = [];

    if (!Array.isArray(array) || typeof wantedGenre !== "string") {
      throw new Error("Invalid input");
    }
    array.map((obj) => {
      if (obj.genre === wantedGenre) {
        resultArr.push(obj.title);
      }
    });
    return resultArr;
  },
};

let {expect} = require ('chai')

describe("bookSelection", function() {
  describe("isGenreSuitable", function() {
      it("1", function() {
          expect(bookSelection.isGenreSuitable('Horror', 12)).to.equal(`Books with Horror genre are not suitable for kids at 12 age`);
          expect(bookSelection.isGenreSuitable('Horror', 10)).to.equal(`Books with Horror genre are not suitable for kids at 10 age`);
          expect(bookSelection.isGenreSuitable('Thriller', 12)).to.equal(`Books with Thriller genre are not suitable for kids at 12 age`);
          expect(bookSelection.isGenreSuitable('Thriller', 2)).to.equal(`Books with Thriller genre are not suitable for kids at 2 age`);
          
          expect(bookSelection.isGenreSuitable('Thriller', 15)).to.equal(`Those books are suitable`);
          expect(bookSelection.isGenreSuitable('Romantic', 15)).to.equal(`Those books are suitable`);
          expect(bookSelection.isGenreSuitable('Romantic', 10)).to.equal(`Those books are suitable`);
      });
   });

   describe("isItAffordable", function() {
    it("2", function() {
        expect(bookSelection.isItAffordable(15, 10)).to.equal(`You don't have enough money`);
        expect(bookSelection.isItAffordable(15, 30)).to.equal(`Book bought. You have 15$ left`);
        expect(bookSelection.isItAffordable(15, 15)).to.equal(`Book bought. You have 0$ left`);

        expect(() => bookSelection.isItAffordable(undefined, 5)).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable({}, 5)).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable('str', 5)).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable('', 5)).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable([], 5)).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable(5, 'dcdc')).to.throw(Error, "Invalid input");
        expect(() => bookSelection.isItAffordable('', 'dcdc')).to.throw(Error, "Invalid input");
    });
 });

 describe("suitableTitles ", function() {
  it("3", function() {

    let arr = [{ title: "The Da Vinci Code", genre: "Thriller" }, { title: "kresa", genre: "Horror" }];
      expect(() => bookSelection.suitableTitles(arr, [])).to.throw(Error, "Invalid input");
      expect(() => bookSelection.suitableTitles(arr, {})).to.throw(Error, "Invalid input");
      expect(() => bookSelection.suitableTitles({}, 'dd')).to.throw(Error, "Invalid input");
      expect(() => bookSelection.suitableTitles(undefined, undefined)).to.throw(Error, "Invalid input");
      expect(() => bookSelection.suitableTitles(5, [])).to.throw(Error, "Invalid input");

      expect(bookSelection.suitableTitles(arr, 'Horror')).to.eql(["kresa"]);
      expect(bookSelection.suitableTitles(arr, 'Thriller')).to.eql(["The Da Vinci Code"]);
  });
});
});

