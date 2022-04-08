import { html } from "lit-html";

export let catalogueTemplate = (games) => html`
<section id="catalog-page">
    <h1>All Games</h1>${games.length > 0
            ? games.map(g => gameTemplate(g))
        : html`<h3 class="no-articles">No articles yet</h3>`}
</section>
</div>`;

let gameTemplate = (game) => html`
<div class="allGames">
    <div class="allGames-info">
        <img src="${game.imageUrl}">
        <h6>Action</h6>
        <h2>Cover Fire</h2>
        <a href="/details" class="details-button">Details</a>
    </div>
</div>`; 