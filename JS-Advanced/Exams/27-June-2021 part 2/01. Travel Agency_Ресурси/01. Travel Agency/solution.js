window.addEventListener('load', solution);

function solution() {
  let submitBtn = document.getElementById('submitBTN');
  let editBtn = document.getElementById('editBTN');
  let continueBtn = document.getElementById('continueBTN');

  let fullNameElement;
  let emailElement;
  let phoneNumberElement;
  let addressElement;
  let postalCodeElement;

  let fullName;
  let email;
  let phoneNumber;
  let address;
  let postalCode;

  submitBtn.addEventListener("click", submitHandler);

  function submitHandler(e) {
    e.preventDefault();

    fullNameElement = document.getElementById('fname');
    emailElement = document.getElementById('email');
    phoneNumberElement = document.getElementById('phone');
    addressElement = document.getElementById('address');
    postalCodeElement = document.getElementById('code');

    let infoPreviewElement = document.getElementById('infoPreview');

    fullName = fullNameElement.value;
    email = emailElement.value;
    phoneNumber = phoneNumberElement.value;
    address = addressElement.value;
    postalCode = postalCodeElement.value;

    if (fullName.length > 0 && email.length > 0) {
      let liNameElement = document.createElement("li");
      let liEmailElement = document.createElement("li");

      liNameElement.textContent = 'Full Name: ' + fullName;
      infoPreviewElement.appendChild(liNameElement);

      liEmailElement.textContent = 'Email: ' + email;
      infoPreviewElement.appendChild(liEmailElement);

      if (phoneNumber.length > 0) {
        let liPhoneNumber = document.createElement("li");
        liPhoneNumber.textContent = 'Phone Number: ' + phoneNumber;

        infoPreviewElement.appendChild(liPhoneNumber);
      }

      if (address.length > 0) {
        let liAddress = document.createElement("li");
        liAddress.textContent = 'Address: ' + address;

        infoPreviewElement.appendChild(liAddress);
      }

      if (postalCode.length > 0) {
        let liPostCode = document.createElement("li");
        liPostCode.textContent = 'Postal Code: ' + postalCode;

        infoPreviewElement.appendChild(liPostCode);
      }

      submitBtn.disabled = true;
      editBtn.disabled = false;
      continueBtn.disabled = false;

      fullNameElement.value = '';
      emailElement.value = '';
      phoneNumberElement.value = '';
      addressElement.value = '';
      postalCodeElement.value = '';
    }

    editBtn.addEventListener("click", editBtnHandler);
    continueBtn.addEventListener("click", continueBtnHandler);

    function editBtnHandler(e) {
      e.preventDefault();

      //continueBtn.addEventListener("click", continueBtnHandler);

      submitBtn.disabled = false;
      editBtn.disabled = true;
      continueBtn.disabled = true;

      fullNameElement.value = fullName;
      emailElement.value = email;
      phoneNumberElement.value = phoneNumber;
      addressElement.value = address;
      postalCodeElement.value = postalCode;

      let ulElement = document.getElementById('infoPreview');

      ulElement.innerHTML = '';
    }

    function continueBtnHandler(e) {
      e.preventDefault();

      let divEl = document.getElementById('block');
      divEl.innerHTML = '';

      let h3 = document.createElement('h3');
      h3.textContent = 'Thank you for your reservation!';
      divEl.appendChild(h3);
    }
  }
}
