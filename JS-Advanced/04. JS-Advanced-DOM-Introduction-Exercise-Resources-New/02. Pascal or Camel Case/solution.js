function solve() {
  let textElement = document.getElementById('text').value;
  let conventionElement = document.getElementById('naming-convention').value;

  let result = applyNamingConvention(textElement, conventionElement);

  let resultElement = document.getElementById('result');
  resultElement.textContent = result;

  function applyNamingConvention(text, convention) {
    const conventionSwitch = {
      'Pascal Case': () => text
        .toLowerCase()
        .split(' ')
        .map(x => x[0].toUpperCase() + x.slice(1))
        .join(''),
      'Camel Case': () => text
        .toLowerCase()
        .split(' ')
        .map((x, i) => x = i !== 0 ? x[0].toUpperCase() + x.slice(1) : x)
        .join(''),
      default: () => 'Error!'
    };

    return (conventionSwitch[convention] || conventionSwitch.default)();
  }
}