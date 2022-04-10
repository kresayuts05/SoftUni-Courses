import { editTemplate } from "./editTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _postsService = undefined;
let _form = undefined

function initialize(router, renderHandler, postsService) {
    _router = router;
    _renderHandler = renderHandler;
    _postsService = postsService;
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

        let description = formData.get('description');
        if (description.trim() === '') {
            _form.errorMessages.push('Description is required');
        }

        let imageUrl = formData.get('imageUrl');
        if (imageUrl.trim() === '') {
            _form.errorMessages.push('Image Url is required');
        }

        let address = formData.get('address');
        if (address.trim() === '') {
            _form.errorMessages.push('Address is required');
        }

        let phone = formData.get('phone');
        if (address.trim() === '') {
            _form.errorMessages.push('Phone is required');
        }

        if (_form.errorMessages.length > 0) {
            let templateResult = editTemplate(_form);
            alert(_form.errorMessages.join('\n'));

            return _renderHandler(templateResult);
        }

        let post = {
            title,
            description,
            imageUrl,
            address,
            phone
        }

        await _postsService.update(post, id);
        _router.redirect(`/data/posts/${id}`); //details?
    } catch (err) {
        alert(err);
    }

}

async function getView(context) {
    let id = context.params.id;
    let post = await _postsService.get(id);

    _form = {
        submitHandler,
        errorMessages: [],
        post
    }

    let templateResult = editTemplate(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}