import { html} from "./../../node_modules/lit-html/lit-html.js";

export let detailsTemplate = (model) => html`
<!--Details Page-->
<section id="game-details">
    <h1>Game Details</h1>
    <div class="info-section">

        <div class="game-header">
            <img class="game-img" src="${model.game.imageUrl}" />
            <h1> ${model.game.title}</h1>
            <span class="levels">MaxLevel: ${model.game.maxLevel}</span>
            <p class="type"> ${model.game.category}</p>
        </div>

        <p class="text">
            ${model.game.summary}
        </p>

        <!-- Edit/Delete buttons ( Only for creator of this game )  -->
        <div class="buttons">
        ${model.isOwner 
                ? html`
                <a class="button" href="/edit/${model.game._id}">Edit</a>
                <button class="button" @click=${(e) => model.deleteHandler(model.game._id, e)}>Delete</button>`
                : ''}
        </div>
    </div>
</section>`