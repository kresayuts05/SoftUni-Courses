import page from "./node_modules/page/page.mjs";
import { LitRenderer } from "./rendering/litRenderer.js";
import authService from "./services/authService.js";
import albumsService from "./services/albumsService.js";
import nav from "./pages/nav/nav.js";
import homePage from "./pages/home/homePage.js";
import registerPage from "./pages/register/registerPage.js";
import loginPage from "./pages/login/loginPage.js";
import catalogPage from "./pages/catalog/catalogPage.js";
import createPage from "./pages/create/createPage.js";
import detailsPage from "./pages/details/detailsPage.js";
import editPage from "./pages/edit/editPage.js";

let navElement = document.querySelector('header');
let appElement = document.getElementById('main-content');

let renderer = new LitRenderer();

let navRenderHandler = renderer.createRenderHandler(navElement);
let appRenderHandler = renderer.createRenderHandler(appElement);

nav.initialize(page, navRenderHandler, authService);
homePage.initialize(page, appRenderHandler, authService);
registerPage.initialize(page, appRenderHandler, authService);
loginPage.initialize(page, appRenderHandler, authService);
catalogPage.initialize(page, appRenderHandler, albumsService);
createPage.initialize(page, appRenderHandler, albumsService);
detailsPage.initialize(page, appRenderHandler, albumsService);
editPage.initialize(page, appRenderHandler, albumsService);

page('/index.html', '/home');
page('/', '/home');

page(decorateContextWithUser);
page(nav.getView);

page('/home', homePage.getView);    
page('/register', registerPage.getView);    
page('/login', loginPage.getView);    
page('/catalog', catalogPage.getView);    
page('/create', createPage.getView);    //create - data/....
page('/data/albums/:id', detailsPage.getView);   //details
page('/edit/:id', editPage.getView);   


page.start();

function decorateContextWithUser(context, next) {
    let user = authService.getUser();
    context.user = user;
    next();
}