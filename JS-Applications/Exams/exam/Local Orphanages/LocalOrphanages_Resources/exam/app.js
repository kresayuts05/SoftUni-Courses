import page from "./node_modules/page/page.mjs";
import createPage from "./pages/create/createPage.js";
import dashboardPage from "./pages/dashboard/dashboardPage.js";
import detailsPage from "./pages/details/detailsPage.js";
import editPage from "./pages/edit/editPage.js";
import loginPage from "./pages/login/loginPage.js";
import myPostsPage from "./pages/myPosts/myPostsPage.js";
import nav from "./pages/nav/nav.js";
import registerPage from "./pages/register/registerPage.js";
import { LitRenderer } from "./rendering/litRenderer.js";
import authService from "./services/authService.js";
import postsService from "./services/postsService.js"


let navElement = document.querySelector('header');
let appElement = document.getElementById('main-content');

let renderer = new LitRenderer();

let navRenderHandler = renderer.createRenderHandler(navElement);
let appRenderHandler = renderer.createRenderHandler(appElement);

nav.initialize(page, navRenderHandler, authService);
dashboardPage.initialize(page, appRenderHandler, postsService);
loginPage.initialize(page, appRenderHandler, authService );
registerPage.initialize(page, appRenderHandler, authService);
createPage.initialize(page, appRenderHandler, postsService);
detailsPage.initialize(page, appRenderHandler, postsService);
editPage.initialize(page, appRenderHandler, postsService);
myPostsPage.initialize(page, appRenderHandler, postsService);


page('/index.html', '/dashboard');
page('/', '/dashboard');

page(decorateContextWithUser);
page(nav.getView);

page('/dashboard', dashboardPage.getView);
page('/login', loginPage.getView);
page('/register', registerPage.getView);
page('/create', createPage.getView);
page('/data/posts/:id', detailsPage.getView);
page('/edit/:id', editPage.getView);
page('/myPosts', myPostsPage.getView);

page.start();

function decorateContextWithUser(context, next) {
    let user = authService.getUser();
    context.user = user;
    next();
}
