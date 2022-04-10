import { createTemplate } from "./createTemplate.js";

let _router = undefined;
let _renderHandler = undefined;
let _albumsService = undefined;
let _form = undefined;

function initialize(router, renderHandler, albumsService) {
    _router = router;
    _renderHandler = renderHandler;
    _albumsService = albumsService;
}

async function submitHandler(e){
    e.preventDefault();
    
    try{
        let formData = new FormData(e.target);
        _form.errorMessages = [];

        let name = formData.get('name');
        if(name.trim() === ''){
            _form.errorMessages.push('Name is required');
        }

        let imgUrl = formData.get('imgUrl');
        if(imgUrl.trim() === ''){
            _form.errorMessages.push('Image Url is required');
        }

        let price = formData.get('price');
        if(price.trim() === ''){
            _form.errorMessages.push('Price is required');
        }

        let releaseDate = formData.get('releaseDate');
        if(releaseDate.trim() === ''){
            _form.errorMessages.push('Release Date is required');
        }

        let artist = formData.get('artist');
        if(artist.trim() === ''){
            _form.errorMessages.push('Artist is required');
        }

        let genre = formData.get('genre');
        if(genre.trim() === ''){
            _form.errorMessages.push('Genre is required');
        }

        let description = formData.get('description');
        if(description.trim() === ''){
            _form.errorMessages.push('Description is required');
        }


        if(_form.errorMessages.length > 0){
            let templateResult = createTemplate(_form);
             alert(_form.errorMessages.join('\n'));

            return _renderHandler(templateResult);
        }

        let album = {
            name,
            imgUrl,
            price,
            releaseDate,
            artist,
            genre,
            description
        }
    
        let loginResult = await _albumsService.create(album);
        _router.redirect('/catalog');

    } catch (err){
        alert(err);
    }
   
}

async function getView(context) {
    _form = {
        submitHandler,
        errorMessages: []
    }

    let templateResult = createTemplate(_form);
    _renderHandler(templateResult);
}

export default {
    getView,
    initialize
}