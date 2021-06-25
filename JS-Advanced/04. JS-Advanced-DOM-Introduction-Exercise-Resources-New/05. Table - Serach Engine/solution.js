function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let searchedText = document.getElementById('searchField').value;
      let rowElements = Array.from(document.querySelectorAll('tbody tr'));

      rowElements.forEach(el => {
         el.className = '';
      })

      let filtredList = rowElements
         .filter(el => {
            let values = Array.from(el.children);
            if(values.some(x => x.textContent.includes(searchedText))){
               el.className = 'select';
            }
         });
  
   }
}