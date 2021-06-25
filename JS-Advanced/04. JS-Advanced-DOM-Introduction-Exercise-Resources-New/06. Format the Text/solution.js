function solve() {
	let textArea = document.getElementById('input').value;

	let sentences = textArea
		.split('.')
		.filter(x => x !== '')
		.map(x => x + '.');

	let paragraphRoof = Math.ceil(sentences.length / 3);

	let result = document.getElementById('output');

	for (let index = 0; index < paragraphRoof; index++) {
		result.innerHTML += `<p>${sentences.splice(0, 3).join('')}</p>`;
	}
}