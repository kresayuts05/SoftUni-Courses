import { detailsTemplate } from "./detailsTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _postsService = undefined;

function initialize(router, renderHandler, postsService) {
    _router = router;
    _renderHandler = renderHandler;
    _postsService = postsService;
}

async function deleteHandler(id, e) {
    e.preventDefault();

    try {
        let post = await _postsService.get(id);
        if (confirm(`Are you sure you want to delete ${post.title}`)) {
        await _postsService.deleteItem(id);
            _router.redirect('/');
        }
    } catch (err) {
        alert(err);
    }
}

async function getView(context) {
    let id = context.params.id;
    let post = await _postsService.get(id);
    let user = context.user;
    let isOwner = false;
    if (user !== undefined && user._id === post._ownerId) {
        isOwner = true;
    }

    let model = {
        post,
        deleteHandler,
        isOwner,
        isLoggedIn: user !== undefined
    };

    let templateResult = detailsTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}