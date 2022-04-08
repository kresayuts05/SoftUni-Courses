import { editTemplate } from "./editTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _theatresService = undefined;
let _form = undefined;

function initialize(router, renderHandler, theatresService) {
    _router = router;
    _renderHandler = renderHandler;
    _theatresService = theatresService;
}

async function submitHandler(id, e) {
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
            let templateResult = editTemplate(_form);
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

        await _theatresService.update(theater, id);
        _router.redirect(`/data/theaters/${id}`);
        
    } catch (err) {
        alert(err);
    }

}

async function getView(context) {
    let id = context.params.id;
    let theater = await _theatresService.get(id);

    _form = {
        submitHandler,
        errorMessages: [],
        theater
    }
    let templateResult = editTemplate(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}