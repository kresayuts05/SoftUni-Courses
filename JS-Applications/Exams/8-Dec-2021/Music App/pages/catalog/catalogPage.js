import {catalogTemplate} from "./catalogTemplate.js"

let _router = undefined;
let _renderHandler = undefined;
let _albumsService = undefined;

function initialize(router, renderHandler, albumsService) {
    _router = router;
    _renderHandler = renderHandler;
    _albumsService = albumsService;
}

async function getView(context) {
    let user = context.user;
    let allAlbums = await _albumsService.getAllAlbums();
    let isLoggedIn = (user !== undefined);
    let templateResult = catalogTemplate(allAlbums, isLoggedIn);

    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}