import { detailsTemplate } from "./detailsTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _theatresService = undefined;

function initialize(router, renderHandler, theatresService) {
    _router = router;
    _renderHandler = renderHandler;
    _theatresService = theatresService;
}

async function deleteHandler(id, e){
e.preventDefault();

    try{
        await _theatresService.deleteItem(id);
        _router.redirect('/profile');

    } catch(err){
        alert(err);
    }
}

async function getView(context) {
    let id = context.params.id;
    let theater = await _theatresService.get(id);
    let user = context.user;
    let isOwner = false;

    if(user !== undefined && user._id === theater._ownerId){
        isOwner = true;
    }
    let model = {
        theater,
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