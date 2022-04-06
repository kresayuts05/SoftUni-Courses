class LibraryCollection {
    books = [];

    constructor(capacity) {
        this.capacity = capacity;
    }

    addBook(bookName, bookAuthor) {
        if (this.books.length == this.capacity) {
            throw new Error('Not enough space in the collection.')
        }

        let book = {
            bookName,
            bookAuthor,
            'payed': false
        };

        this.books.push(book);

        return `The ${bookName}, with an author ${bookAuthor}, collect.`
    }

    payBook(bookName) {
        let book = this.books.find(b => b['bookName'] === bookName);

        if (book == undefined) {
            throw new Error(`${bookName} is not in the collection.`)
        }

        if(book['payed']){
            throw new Error(`${bookName} has already been paid.`)
        }

        book['payed'] = true;
        return `${bookName} has been successfully paid.`
    }

    removeBook(bookName) {
        let book = this.books.find(b => b['bookName'] === bookName);

        if(book == undefined){
            throw new Error('The book, you\'re looking for, is not found.');
        }

        if(!book['payed']){
            throw new Error(`${bookName} need to be paid before removing from the collection.`);
        }

       this.books =  this.books.filter(b => b !== bookName);

       return `${bookName} remove from the collection.`
    }

    getStatistics(bookAuthor){
        if(bookAuthor == undefined){
            let result = `The book collection has ${this.capacity - this.books.length} empty spots left.\n`;

            this.books.sort((a, b) => {
                return a['bookName'].localeCompare(b['bookName']);//asc
            })

            this.books.forEach(b => result +=  `${b.bookName} == ${b.bookAuthor} - ${b.payed ? 'Has Paid' : 'Not Paid' }.\n`);

            return result.trimEnd();
        }

        let authorBooks = this.books.filter(b => b['bookAuthor'] === bookAuthor);

        if(authorBooks.length == 0){
            throw new Error(`${bookAuthor} is not in the collection.`)
        }

        let result = ``;

        authorBooks.forEach(b => result +=`${b.bookName} == ${b.bookAuthor} - ${b.payed ? 'Has Paid' : 'Not Paid' }.\n`);

        return result.trimEnd();
    }
}
