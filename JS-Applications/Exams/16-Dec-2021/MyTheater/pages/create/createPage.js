import { createTemplate } from "./createTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _theatresService = undefined;
let _form = undefined;

function initialize(router, renderHandler, theatresService) {
    _router = router;
    _renderHandler = renderHandler;
    _theatresService = theatresService;
}

async function submitHandler(e) {
    e.preventDefault();

    try {
        let formData = new FormData(e.target);
        _form.errorMessages = [];

        let title = formData.get('title');
        if (title.trim() === '') {
            _form.errorMessages.push('Title is required');
        }

        let author = formData.get('author');
        if (author.trim() === '') {
            _form.errorMessages.push('Author is required');
        }

        let date = formData.get('date');
        if (date.trim() === '') {
            _form.errorMessages.push('Date is required');
        }

        let imageUrl = formData.get('imageUrl');
        if (imageUrl.trim() === '') {
            _form.errorMessages.push('Image Url is required');
        }

        let description = formData.get('description');
        if (description.trim() === '') {
            _form.errorMessages.push('Description is required');
        }

        if (_form.errorMessages.length > 0) {
            let templateResult = createTemplate(_form);
            alert(_form.errorMessages.join('\n'));

            return _renderHandler(templateResult);
        }

        let theater = {
            title,
            date,
            author,
            imageUrl,
            description
        }

        let loginResult = await _theatresService.createItem(theater);
        _router.redirect('/home');

    } catch (err) {
        alert(err);
    }

}

async function getView(context) {
    _form = {
        submitHandler,
        errorMessages: []
    }

    let templateResult = createTemplate(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}