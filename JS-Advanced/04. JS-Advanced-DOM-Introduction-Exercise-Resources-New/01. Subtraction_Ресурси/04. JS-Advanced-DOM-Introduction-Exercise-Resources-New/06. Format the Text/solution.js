function solve() {
  let input = document.getElementById('input').value;
  let outputElement = document.getElementById('output');

  let sentences = input
    .split('.')
    .filter(s => s !== '')
    .map(s => s + '.');

  let paragraphs = Math.ceil(sentences.length / 3);

  for (let index = 0; index < paragraphs; index++) {
    outputElement.innerHTML += `<p> ${sentences.splice(0, 3).join('')} </p>`;
  };
}