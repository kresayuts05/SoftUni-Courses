import { html} from "./../../node_modules/lit-html/lit-html.js";

export let navTemplate = (nav) => html `
<nav>
  <a href="/home">Theater</a>
  <ul>
    ${nav.isLoggedIn 
    ? loggedControls(nav)
    : guestControls()}
  </ul>
 </nav>`;

let loggedControls = (nav) => html`
<li><a href="/profile">Profile</a></li>
  <li><a href="/create">Create Event</a></li>
 <li><a href="javascript:void(0)" @click=${nav.logoutHandler}>Logout</a></li>`;

let guestControls = () => html`
<li><a href="/login">Login</a></li>
<li><a href="/register">Register</a></li>`;
