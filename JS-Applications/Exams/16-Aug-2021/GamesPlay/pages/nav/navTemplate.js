import { html } from "./../../node_modules/lit-html/lit-html.js"

export let navTemplate = (nav) => html`
<h1><a class="home" href="/home">GamesPlay</a></h1>
<nav>
    <a href="/all-games">All games</a>
    ${nav.isLoggedIn
    ? logInPlayer(nav) 
    : guestPlayer()}
</nav>`

let logInPlayer = (nav) => html`
<div id="user">
    <a href="/create">Create Game</a>
    <a href="javascript:void(0)" @click=${nav.logoutHandler}>Logout</a>
</div>`;

let guestPlayer = () => html`
<div id="guest">
    <a href="/login">Login</a>
    <a href="/register">Register</a>
</div>`