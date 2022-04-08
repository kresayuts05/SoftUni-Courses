import { profileTemplate } from "./profileTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _theatresService = undefined;

function initialize(router, renderHandler, theatresService) {
    _router = router;
    _renderHandler = renderHandler;
    _theatresService = theatresService;
}

async function getView(context) {
    let user = context.user;
    let myTheatres = [];
    if(user !== undefined){
        myTheatres = await _theatresService.getMyTheatres(user._id);
    }

    let model = {
        theatres: myTheatres,
        user
    }

    let templateResult = profileTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}