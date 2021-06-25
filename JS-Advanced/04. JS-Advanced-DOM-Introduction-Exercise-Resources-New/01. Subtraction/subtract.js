function subtract() {
    let firstNumElement = Number(document.getElementById('firstNumber').value);
    let secondNumElement = Number(document.getElementById('secondNumber').value);

    let result = firstNumElement-secondNumElement;

    let resultElement = document.getElementById('result');

    resultElement.textContent = result;
}