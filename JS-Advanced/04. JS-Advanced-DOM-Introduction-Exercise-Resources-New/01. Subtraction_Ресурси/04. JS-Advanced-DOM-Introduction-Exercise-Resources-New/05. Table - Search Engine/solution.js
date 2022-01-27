function solve() {
   document.querySelector('#searchBtn').addEventListener('click', onClick);

   function onClick() {
      let searchTextElement = document.getElementById('searchField');
      let searchText = searchTextElement.value;
      let tableRows = Array.from(document.querySelectorAll('tbody tr'));

      tableRows.forEach(row => {
         row.className = '';
      });

      let selectedRows = tableRows
         .filter(row => {
            let values = Array.from(row.children);

            if (values.some(x => x.textContent.includes(searchText))) {
               row.className = 'select';
            }
         });

         searchTextElement.value = '';
   }
}