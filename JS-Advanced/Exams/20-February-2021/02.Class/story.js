class Story {
    constructor(title, creator) {
        this.title = title;
        this.creator = creator;

    }

    _comments = [];
    _likes = [];

    get _likes() {
        if (this._likes.length === 0) {
            return `${this.title} has 0 likes`;
        } else if (this._likes.length === 1) {
            return `${this._likes[0]} likes this story!`;
        } else {
            return `${this._likes[0]} and ${this._likes.length - 1} others like this story!`;
        }
    }

    like(username) {

        if (this._likes.includes(username)) {
            throw new Error('You can\'t like the same story twice!');
        }
        if (this.creator === username) {
            throw new Error('You can\'t like your own story!');
        }

        this._likes.push(username);
        return `${username} liked ${this.title}!`;
    }

    dislike(username) {
        if (!this._likes.includes(username)) {
            throw new Error('You can\'t dislike this story!');
        } else {
            this._likes = this._likes.filter(x => x !== username);
            return `${username} disliked ${this.title}`;
        }
    }

    comment(username, content, id) {
        if (username !== undefined && !this._comments.some(x => x.Id === id)) {
            let newComment = {
                Id: this._comments.length + 1,
                Username: username,
                Content: content,
                Replies: [],
            };

            this._comments.push(newComment);
            return `${username} commented on ${this.title}`;
        } else if (this._comments.some(x => x.Id === id)) {
            let newReply = {
                Id: Number(`${id}.${this._comments.find(c => c.Id === id).Replies.length + 1}`),
                Username: username,
                Content: content,
            }

            this._comments.Replies.push(newReply);
            return "You replied successfully";
        }
    }

    toString(sortingType) {
        if (sortingType === 'asc') {

        }
    }
}

let art = new Story("My Story", "Anny");
art.like("John");
console.log(art.likes);
art.dislike("John");
console.log(art.likes);


