import { html } from "./../../node_modules/lit-html/lit-html.js";

export let navTemplate = (nav) => html`
<h1><a href="/">Orphelp</a></h1>

<nav>
    <a href="/dashboard">Dashboard</a>

    ${nav.isLoggedIn
     ? logged(nav)
     : notLogged()}

</nav>`;

let logged = (nav) => html`
<div id="user">
    <a href="/myPosts">My Posts</a>
    <a href="/create">Create Post</a>
    <a href="javascript:void(0)" @click=${ (e) => nav.logoutHandler(e)}>Logout</a>
</div>`;

let notLogged = () => html`
<div id="guest">
    <a href="/login">Login</a>
    <a href="/register">Register</a>
</div>`;