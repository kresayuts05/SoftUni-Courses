import { html } from "./../../node_modules/lit-html/lit-html.js";

export let profileTemplate = (model) => html`
<section id="profilePage">
    <div class="userInfo">
        <div class="avatar">
            <img src="./images/profilePic.png">
        </div>
        <h2>${model.user.email}</h2>
    </div>
    <div class="board">
        ${model.theatres.length > 0
                ? model.theatres.map(t => eventTempate(t, model.user))
                : html`<div class="no-events">
            <p>This user has no events yet!</p>
        </div>`}
</section> >`;

let eventTempate = (theatre, user) => html`
<div class="eventBoard">
    <div class="event-info">
        <img src="./images/Moulin-Rouge!-The-Musical.jpg">
        <h2>${theatre.title}</h2>
        <h6>${theatre.date}</h6>
        <a href="/data/theatres/${user._id}" class="details-button">Details</a>
    </div>
</div>`;
