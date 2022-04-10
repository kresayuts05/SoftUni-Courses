import { html } from "./../../node_modules/lit-html/lit-html.js";

export let myPostsTemplate = (model) => html`
<section id="my-posts-page">
    <h1 class="title">My Posts</h1>

    ${model.posts.length > 0
        ? html`<div class="my-posts"> ${model.posts.map(p => myPostTemplate(p))}</div>`
            : html`<h1 class="title no-posts-title">You have no posts yet!</h1>`}

</section>`;

let myPostTemplate = (post) => html`
<div class="post">
    <h2 class="post-title">${post.title}</h2>
    <img class="post-image" src="${post.imageUrl}" alt="Material Image">
    <div class="btn-wrapper">
        <a href="/data/posts/${post._id}" class="details-btn btn">Details</a>
    </div>
</div>`;