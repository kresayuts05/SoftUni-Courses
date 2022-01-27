function solve() {
  let text = document.getElementById('text').value;
  let convention = document.getElementById('naming-convention').value;

  let result = applyNamingConvention(text, convention);

  let resultElement = document.getElementById('result');
  resultElement.textContent = result;

  function applyNamingConvention(text, convention) {
    const conventionSwitch = {
      'Camel Case': () => text
        .toLowerCase()
        .split(' ')
        .map((x, i) => x =  i !== 0 ? x[0].toUpperCase() + x.slice(1) : x)
        .join(''),
      'Pascal Case': () => text
        .toLowerCase()
        .split(' ')
        .map(x => x[0].toUpperCase() + x.slice(1))
        .join(''),
      default: () => 'Error!'
    };
    return (conventionSwitch[convention] || conventionSwitch.default)();
  }
}