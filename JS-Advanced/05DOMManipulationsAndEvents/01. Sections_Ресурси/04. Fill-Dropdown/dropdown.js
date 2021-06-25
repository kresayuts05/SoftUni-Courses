function addItem() {
    let itemText = document.getElementById('newItemText');
    let itemValue = document.getElementById('newItemValue');

    let selectField = document.getElementById('menu');
    let option = document.createElement('option');

    option.textContent = itemText.value;
    option.value = itemValue.value;

    if (option.value.length > 0 && option.textContent.length > 0) {
        selectField.appendChild(option);
    }

    itemText.value = '';
    itemValue.value = '';
}