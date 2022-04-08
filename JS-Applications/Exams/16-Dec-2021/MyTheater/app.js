import page from "./node_modules/page/page.mjs";
import homePage from "./pages/home/homePage.js";
import loginPage from "./pages/login/loginPage.js";
import registerPage from "./pages/register/registerPage.js";
import { LitRenderer } from "./rendering/litRenderer.js";
import authService from "./services/authService.js";
import nav from "./pages/nav/nav.js";
import theatresService from "./services/theatresService.js";
import createPage from "./pages/create/createPage.js";
import editPage from "./pages/edit/editPage.js";
import detailsPage from "./pages/details/detailsPage.js";
import profilePage from "./pages/profile/profilePage.js";

    
let navElement = document.querySelector('header');
let appElement = document.getElementById('content');

let renderer = new LitRenderer();

let navRenderHandler = renderer.createRenderHandler(navElement);
let appRenderHandler = renderer.createRenderHandler(appElement);

nav.initialize(page, navRenderHandler, authService);
homePage.initialize(page, appRenderHandler, theatresService);
loginPage.initialize(page, appRenderHandler, authService);
registerPage.initialize(page, appRenderHandler, authService);
detailsPage.initialize(page, appRenderHandler, theatresService);
createPage.initialize(page, appRenderHandler, theatresService);
editPage.initialize(page, appRenderHandler, theatresService);
profilePage.initialize(page, appRenderHandler, theatresService);


page('/index.html', '/home');
page('/', '/home');

page(decorateContextWithUser);
page(nav.getView);

page('/home', homePage.getView);
page('/login', loginPage.getView);
page('/register', registerPage.getView);
page('/data/theaters/:id', detailsPage.getView);
page('/create', createPage.getView);
page('/edit/:id', editPage.getView);
page('/profile', profilePage.getView);

page.start();

function decorateContextWithUser(context, next){
    let user = authService.getUser();
    context.user = user;
    next();
}