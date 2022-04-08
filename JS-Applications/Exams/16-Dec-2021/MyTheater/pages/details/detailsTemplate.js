import { html } from "./../../node_modules/lit-html/lit-html.js";

export let detailsTemplate = (model) => html`
<section id="detailsPage">
    <div id="detailsBox">
        <div class="detailsInfo">
            <h1>Title: ${model.theater.title}</h1>
            <div>
                <img src="${model.theater.imageUrl}" />
            </div>
        </div>

        <div class="details">
            <h3>Theater Description</h3>
            <p>${model.theater.description}</p>
            <h4>Date: ${model.theater.date}</h4>
            <h4>Author: ${model.theater.author}</h4>
        </div>

        ${model.isOwner
        ? html`<div class="buttons">
            <a class="btn-delete" @click=${(e)=> model.deleteHandler(model.theater._id, e)}>Delete</a>
            <a class="btn-edit" href="/edit/${model.theater._id}">Edit</a>
        </div>`
        : html`<p class="likes">Likes: 0</p>
        <a class="btn-like" href="#">Like</a>`}
    </div>
</section>`;
