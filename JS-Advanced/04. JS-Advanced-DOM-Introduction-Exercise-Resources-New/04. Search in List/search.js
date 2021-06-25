function search() {
   let searchedText = document.getElementById('searchText').value;
   let allElements = Array.from(document.querySelectorAll('#towns li'));

   allElements.forEach(el => {
      el.style['font-weight'] = 'normal';
      el.style['text-decoration'] = 'none';
   });

   let targetList = allElements
      .filter(x => x.textContent.includes(searchedText))
      .map(x => {
         x.style['font-weight'] = 'bold';
         x.style['text-decoration'] = 'underline';
      });

      let result = document.getElementById('result');
      result.textContent = `${targetList.length} matches found`
}
