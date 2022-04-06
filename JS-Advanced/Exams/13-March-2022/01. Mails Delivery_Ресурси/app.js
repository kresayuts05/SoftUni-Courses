function solve() {
    let addBtn = document.getElementById('add');
    let resetBtn = document.getElementById('reset');



    let recipientNameElement = document.getElementById('recipientName');
    let titleElement = document.getElementById('title');
    let messageElement = document.getElementById('message');

    let recipientName;
    let title;
    let message;

    addBtn.addEventListener('click', addHandler);
    resetBtn.addEventListener('click', resetHandler);

    function addHandler(e) {
        e.preventDefault();

        resetBtn.addEventListener('click', resetHandler);



        recipientName = recipientNameElement.value;
        title = titleElement.value;
        message = messageElement.value;


        if (recipientNameElement.value.length > 0
            && titleElement.value.length > 0
            && messageElement.value.length > 0) {

            let ulElement = document.getElementById('list');

            let liElement = document.createElement('li');
            ulElement.appendChild(liElement);

            let h4TitleElement = document.createElement('h4');
            h4TitleElement.textContent = 'Title: ' + title;
            liElement.appendChild(h4TitleElement);

            let h4RecipientElement = document.createElement('h4');
            h4RecipientElement.textContent = 'Recipient Name: ' + recipientName;
            liElement.appendChild(h4RecipientElement);

            let spanElement = document.createElement('span');
            spanElement.textContent = message;
            liElement.appendChild(spanElement);

            let divBtnElement = document.createElement('div');
            divBtnElement.setAttribute('id', 'list-action');
            liElement.appendChild(divBtnElement);

            let sendBtnElement = document.createElement('button');
            sendBtnElement.setAttribute('type', 'submit');
            sendBtnElement.setAttribute('id', 'send');
            sendBtnElement.textContent = 'Send';
            divBtnElement.appendChild(sendBtnElement);

            let deleteBtnElement = document.createElement('button');
            deleteBtnElement.setAttribute('type', 'submit');
            deleteBtnElement.setAttribute('id', 'delete');
            deleteBtnElement.textContent = 'Delete'
            divBtnElement.appendChild(deleteBtnElement);

            titleElement.value = '';
            recipientNameElement.value = '';
            messageElement.value = '';

            sendBtnElement.addEventListener('click', sendHandler);
            deleteBtnElement.addEventListener('click', deleteHandler);
        }
    }

    function resetHandler(e) {
        e.preventDefault();
        addBtn.addEventListener('click', addHandler);

        titleElement.value = '';
        recipientNameElement.value = '';
        messageElement.value = '';

        sendBtnElement.addEventListener('click', sendHandler);
        deleteBtnElement.addEventListener('click', deleteHandler);
    }

    function sendHandler(e) {
        e.preventDefault();
        addBtn.addEventListener('click', addHandler);
        resetBtn.addEventListener('click', resetHandler);

        e.currentTarget.parentElement.parentElement.remove();

        let ulSentElement = document.querySelector('.sent-list');

        let liElement = document.createElement('li');
        ulSentElement.appendChild(liElement);

        let spanName = document.createElement('span');
        spanName.textContent = 'To: ' + recipientName + ' ';
        liElement.appendChild(spanName);

        let spanTitle = document.createElement('span');
        spanTitle.textContent = 'Title: ' + title;
        liElement.appendChild(spanTitle);

        let divBtn = document.createElement('div');
        divBtn.classList.add('btn');
        liElement.appendChild(divBtn);

        let deleteBtnElement = document.createElement('button');
        deleteBtnElement.setAttribute('type', 'submit');
        deleteBtnElement.classList.add('delete');
        deleteBtnElement.textContent = 'Delete';
        divBtn.appendChild(deleteBtnElement);

        deleteBtnElement.addEventListener('click', deleteHandler);
    }

    function deleteHandler(e) {
        e.preventDefault();
        addBtn.addEventListener('click', addHandler);
        resetBtn.addEventListener('click', resetHandler);

        let ulDelete = document.querySelector('.delete-list');

        let liElement = document.createElement('li');
        ulDelete.appendChild(liElement);

        let spanName = document.createElement('span');
        spanName.textContent = 'To: ' + recipientName + ' ';
        liElement.appendChild(spanName);

        let spanTitle = document.createElement('span');
        spanTitle.textContent = 'Title: ' + title;
        liElement.appendChild(spanTitle);

        if (e.target.parentElement.parentElement.parentElement.className === 'sent-list') {
            e.target.parentElement.parentElement.remove();
        } else if (e.currentTarget.parentElement.hasAttribute('id')) {
            e.currentTarget.parentElement.parentElement.remove();
        }
    }
}
solve()