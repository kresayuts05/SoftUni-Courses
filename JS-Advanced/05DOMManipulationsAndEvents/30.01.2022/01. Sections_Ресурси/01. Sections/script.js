function create(words) {
   let refToAppend = [];

   for (const word of words) {
      let div = document.createElement('div');
      let p = document.createElement('p');

      p.textContent = word;
      p.style.display = "none";
      
      div.appendChild(p);

      div.addEventListener("click", (e) => {
         e.currentTarget.firstChild.style.display = "block";
      });

      refToAppend.push(div);
   }

   let content = document.getElementById('content');
   refToAppend.forEach(r => content.appendChild(r));

}