function search() {
   let towns = Array.from(document.querySelectorAll('#towns li'));
   let searchText = document.getElementById('searchText').value;

   towns.forEach(el => {
      el.style['text-decoration'] = 'none';
      el.style['font-weight'] = 'normal';
   });

   let targets = towns
      .filter(t => t.textContent.includes(searchText))
      .map(t => {
         t.style['text-decoration'] = 'underline';
         t.style['font-weight'] = 'bold';
      });

   let resultElement = document.getElementById('result');
   
   resultElement.textContent =  `${targets.length} matches found`;
}
