import { myPostsTemplate } from "./myPostsTemplate.js"

let _router = undefined;
let _renderHandler = undefined;
let _postsService = undefined;

function initialize(router, renderHandler, postsService) {
    _router = router;
    _renderHandler = renderHandler;
    _postsService = postsService;
}

async function getView(context) {
    let user = context.user;
    let myPosts = [];
    if(user !== undefined){
        myPosts = await _postsService.getMyPosts(user._id);
    }

    let model = {
        posts: myPosts,
        user
    }

    let templateResult = myPostsTemplate(model);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}