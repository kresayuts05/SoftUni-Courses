import { homeTemplate } from "./homeTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _theatresService = undefined;

function initialize(router, renderHandler, theatresService) {
    _router = router;
    _renderHandler = renderHandler;
    _theatresService = theatresService;
}

async function getView(context) {
    let allTheatres = await _theatresService.getAllTheatres()
    let templateResult = homeTemplate(allTheatres);

    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}