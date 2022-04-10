import { dashboardTemplate } from "./dashboardTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _postsService = undefined;

function initialize(router, renderHandler, postsService) {
    _router = router;
    _renderHandler = renderHandler;
    _postsService = postsService;
}

async function getView(context) {
    let allPosts = await _postsService.getAllPosts();
    let templateResult = dashboardTemplate(allPosts);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}