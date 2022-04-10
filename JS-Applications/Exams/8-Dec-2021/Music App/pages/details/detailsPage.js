import { detailsTemplate } from "./detailsTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _albumsService = undefined;

function initialize(router, renderHandler, albumsService) {
    _router = router;
    _renderHandler = renderHandler;
    _albumsService = albumsService;
}

async function deleteHandler(id, e) {
    e.preventDefault();

    try {
        await _albumsService.deleteItem(id);
        _router.redirect('/catalog');
    } catch (err) {
        alert(err);
    }
}

async function getView(context) {
    let id = context.params.id;
    let album = await _albumsService.get(id);
    let user = context.user;
    let isOwner = false;

    if (user !== undefined && user._id === album._ownerId) {
        isOwner = true;
    }
    let model = {
        album,
        deleteHandler,
        isOwner
    };
    let templateResult = detailsTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}