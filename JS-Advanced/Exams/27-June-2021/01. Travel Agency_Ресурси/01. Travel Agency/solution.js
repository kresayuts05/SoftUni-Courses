window.addEventListener('load', solution);

function solution() {
  let submitButton = document.getElementById('submitBTN');
  let editButton = document.getElementById('editBTN');
  let continueButton = document.getElementById('continueBTN');

  let fullNameElement;
  let emailElement;
  let phoneNumberElement;
  let addressElement;
  let postCodeElement;
  let divBlockElement;

  let fullName;
  let email;
  let phoneNumber;
  let address;
  let postCode;


  submitButton.addEventListener('click', personalInfoHandler);

  function personalInfoHandler(e) {
    e.preventDefault();
    editButton.addEventListener('click', editPersonalInfoHandler);
    continueButton.addEventListener('click',continueButtonHandler);

    fullNameElement = document.getElementById('fname');
    emailElement = document.getElementById('email');
    phoneNumberElement = document.getElementById('phone');
    addressElement = document.getElementById('address');
    postCodeElement = document.getElementById('code');

    let infoPreview = document.getElementById('infoPreview');

    fullName = fullNameElement.value;
    email = emailElement.value;
    phoneNumber = phoneNumberElement.value;
    address = addressElement.value;
    postCode = postCodeElement.value;

    if (fullName.length > 0 && email.length > 0) {
      submitButton.disabled = true;
      editButton.disabled = false;
      continueButton.disabled = false;

      let liNameElement = document.createElement('li');
      let liEmailElement = document.createElement('li');

      infoPreview.appendChild(liNameElement);
      infoPreview.appendChild(liEmailElement);

      liNameElement.textContent = 'Full Name: ' + fullName;
      liEmailElement.textContent = 'Email: ' + email;

      if (phoneNumber.length > 0) {
        let liPhoneNumber = document.createElement('li');
        liPhoneNumber.textContent = 'Phone Number: ' + phoneNumber;

        infoPreview.appendChild(liPhoneNumber);
      }

      if (address.length > 0) {
        let liAddress = document.createElement('li');
        liAddress.textContent = 'Address: ' + address;

        infoPreview.appendChild(liAddress);
      }

      if (postCode.length > 0) {
        let liPostCode = document.createElement('li');
        liPostCode.textContent = 'Postal Code: ' + postCode;

        infoPreview.appendChild(liPostCode);
      }

      fullNameElement.value = '';
      emailElement.value = '';
      phoneNumberElement.value = '';
      addressElement.value = '';
      postCodeElement.value = '';
    }
  }

  function editPersonalInfoHandler(e) {
    e.preventDefault();
    continueButton.addEventListener('click',continueButtonHandler);

    submitButton.disabled = false;
    editButton.disabled = true;
    continueButton.disabled = true;

    fullNameElement.value = fullName;
    emailElement.value = email;
    phoneNumberElement.value = phoneNumber;
    addressElement.value = address;
    postCodeElement.value = postCode;

    let ulElement = document.getElementById('infoPreview');
    while (ulElement.hasChildNodes) {
      ulElement.removeChild(ulElement.childNodes[0]);

    }
  }

  function continueButtonHandler(e) {
    e.preventDefault();

    divBlockElement = document.getElementById('block');

    while (divBlockElement.hasChildNodes) {
      divBlockElement.removeChild(divBlockElement.childNodes[0]);
    }

    let h3Element = document.createElement('h3');
    divBlockElement.appendChild(h3Element);
    h3Element.value = 'Thank you for your reservation!';
  }
}
