import { html} from "./../../node_modules/lit-html/lit-html.js";

export let detailsTemplate = (model) => html`
<section id="detailsPage">
  <div class="wrapper">
        <div class="albumCover">
            <img src="./images/Lorde.jpg">
        </div>
            <div class="albumInfo">
                    <div class="albumText">

                        <h1>Name: ${model.album.name}</h1>
                        <h3>Artist: ${model.album.artist}</h3>
                        <h4>Genre: ${model.album.genre}</h4>
                        <h4>Price: $${model.album.price}</h4>
                        <h4>Date: ${model.album.date}</h4>
                        <p>Description: ${model.album.description}</p>
                    </div>

                    ${model.isOwner 
                     ? html`
                           <div class="actionBtn">
                                <a href="/edit/${model.album._id}" class="edit">Edit</a>
                                 <a @click=${(e) => model.deleteHandler(model.album._id, e)} class="remove">Delete</a>
                           </div>`
                     : ''};
             </div>
    </div>
</section>`;