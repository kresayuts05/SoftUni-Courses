import page from "./node_modules/page/page.mjs"
import allGames from "./pages/allGames/allGames.js";
import createPage from "./pages/create/createPage.js";
import detailsPage from "./pages/details/detailsPage.js";
import editPage from "./pages/edit/editPage.js";
import homePage from "./pages/home/homePage.js";
import loginPage from "./pages/login/loginPage.js";
import nav from "./pages/nav/nav.js";
import registerPage from "./pages/register/registerPage.js"
import { LitRenderer } from "./rendering/litRenderer.js";
import authService from "./services/authService.js";
import gamesService from "./services/gamesService.js";

//Dom elements
let navElement = document.querySelector('body header');
let appElement = document.getElementById('main-content');

let renderer = new LitRenderer();

//rendering
let navRenderHandler = renderer.createRenderHandler(navElement);
let appRenderHandler = renderer.createRenderHandler(appElement);


//initializing
nav.initialize(page, navRenderHandler, authService);
homePage.initialize(page, appRenderHandler, gamesService);
loginPage.initialize(page, appRenderHandler, authService);
registerPage.initialize(page, appRenderHandler, authService);
createPage.initialize(page, appRenderHandler, gamesService);
detailsPage.initialize(page, appRenderHandler, gamesService);
editPage.initialize(page, appRenderHandler, gamesService);
allGames.initialize(page, appRenderHandler, gamesService);

//ilustarting at the beggining
page('/index.html', '/home');
page('/', '/home');

//ilustrating pages
page(decorateContextWithUser);
page(nav.getView);

page('/home', homePage.getView);
page('/login', loginPage.getView);
page('/register', registerPage.getView);
page('/create', createPage.getView);
page('/data/games/:id', detailsPage.getView);
page('/edit/:id', editPage.getView);
page('/all-games', allGames.getView);

page.start();

function decorateContextWithUser(context, next) {
    let user = authService.getUser();
    context.user = user;
    next();
}