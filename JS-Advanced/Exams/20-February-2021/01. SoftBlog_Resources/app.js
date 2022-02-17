function solve() {
   let createButton = document.querySelector('.btn.create');
   createButton.addEventListener("click", createBtnFunction);


   function createBtnFunction(e) {
      e.preventDefault();

      let sectionElement = document.querySelector('.site-content section');
      let articleElement = document.createElement('article');

      let titleText = document.getElementById('title');
      let titleElement = document.createElement('h1');
      titleElement.textContent = titleText.value;
      articleElement.appendChild(titleElement);

      let categoryText = document.getElementById('category');
      let pCategoryElement = document.createElement('p');
      pCategoryElement.textContent = 'Category:'
      let categoryStrongElement = document.createElement('strong');
      categoryStrongElement.textContent = categoryText.value;
      pCategoryElement.appendChild(categoryStrongElement);
      articleElement.appendChild(pCategoryElement);

      let creatotText = document.getElementById('creator');
      let pCreatorElement = document.createElement('p');
      pCreatorElement.textContent = 'Creator:'
      let strongElement = document.createElement('strong');
      strongElement.textContent = creatotText.value;
      pCreatorElement.appendChild(strongElement);
      articleElement.appendChild(pCreatorElement);

      let contentText = document.getElementById('content');
      let pContentElement = document.createElement('p');
      pContentElement.textContent = contentText.value;
      articleElement.appendChild(pContentElement);


      let divElement = document.createElement('div');
      divElement.className = "buttons";

      let deleteBtnElement = document.createElement('button');
      deleteBtnElement.className = "btn delete";
      deleteBtnElement.textContent = 'Delete'
      deleteBtnElement.addEventListener('click', deleteHandler);

      let archiveBtnElement = document.createElement('button');
      archiveBtnElement.className = "btn archive";
      archiveBtnElement.textContent = 'Archive';
      archiveBtnElement.addEventListener('click', archiveHandler);

      divElement.appendChild(deleteBtnElement);
      divElement.appendChild(archiveBtnElement);

      articleElement.appendChild(divElement);

      sectionElement.appendChild(articleElement)
      categoryText.value = '';
      creatotText.value = '';
      contentText.value = '';
      titleText.value = '';
   }

   function deleteHandler(e) {
      e.currentTarget.parentNode.parentNode.remove();
   }

   function archiveHandler(e) {
      let olElement = document.querySelector('.archive-section ol');
      let siblings = e.target.parentNode.parentNode.childNodes;

      let newLi = document.createElement('li');
      newLi.textContent = siblings[0].textContent;

      let archives = Array.from(olElement.querySelectorAll('li'));
      archives.push(newLi);

      e.currentTarget.parentNode.parentNode.remove();

      archives.sort((a, b) => a.textContent.localeCompare(b.textContent)).forEach(li => olElement.appendChild(li));
   };
}     
