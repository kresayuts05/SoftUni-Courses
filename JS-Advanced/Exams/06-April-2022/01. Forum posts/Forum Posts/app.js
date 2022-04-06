window.addEventListener("load", solve);

function solve() {
  let publishBtn = document.getElementById('publish-btn');

  let titleElement;
  let categoryElement;
  let contentElement;

  let title;
  let category;
  let content;

  publishBtn.addEventListener('click', publishHandler);

  function publishHandler(e) {
    e.preventDefault();

    titleElement = document.getElementById('post-title');
    categoryElement = document.getElementById('post-category');
    contentElement = document.getElementById('post-content');

    title = titleElement.value;
    category = categoryElement.value;
    content = contentElement.value;

    if (title !== ''
      && category !== ''
      && content != '') {
      let ul = document.getElementById('review-list');

      let li = document.createElement('li');
      li.classList.add('rpost');
      ul.appendChild(li);

      let article = document.createElement('article');
      li.appendChild(article);

      let h4Title = document.createElement('h4');
      h4Title.textContent = title;
      article.appendChild(h4Title);

      let pCategory = document.createElement('p');
      pCategory.textContent = 'Category: ' + category;
      article.appendChild(pCategory);

      let pContent = document.createElement('p');
      pContent.textContent = 'Content: ' + content;
      article.appendChild(pContent);

      let editBtn = document.createElement('button');
      editBtn.classList.add('action-btn');
      editBtn.classList.add('edit');
      editBtn.textContent = 'Edit';
      li.appendChild(editBtn);

      let approveBtn = document.createElement('button');
      approveBtn.classList.add('action-btn');
      approveBtn.classList.add('approve');
      approveBtn.textContent = 'Approve';
      li.appendChild(approveBtn);

      titleElement.value = '';
      categoryElement.value = '';
      contentElement.value = '';

      editBtn.addEventListener('click', editHandler);

      function editHandler(e) {
        e.preventDefault();

        let children = e.target.parentNode.firstChild.childNodes;

        titleElement.value = children[0].textContent;
        categoryElement.value = children[1].textContent.substring(10);
        contentElement.value = children[2].textContent.substring(9);

        e.target.parentNode.remove();
      }

      approveBtn.addEventListener('click', approveHandler);

      function approveHandler(e) {
        e.preventDefault();

        let liElement = e.currentTarget.parentNode;
        e.currentTarget.parentNode.remove();

        liElement.lastChild.remove();
        liElement.lastChild.remove();

        let ul = document.getElementById('published-list');
        ul.appendChild(li);
      }

      let clearBtm = document.getElementById('clear-btn');

      clearBtm.addEventListener('click', clearHandler);

      function clearHandler(e){
        e.preventDefault();

        let ul = document.getElementById('published-list');

        ul.innerHTML = '';
      }
    }
  }
}
