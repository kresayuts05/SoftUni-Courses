function encodeAndDecodeMessages() {
    let firstTextArea = document.querySelectorAll('textArea')[0];
    let encodeButton = document.querySelectorAll('button')[0];

    let secondTextArea = document.querySelectorAll('textArea')[1];
    let decodeButton = document.querySelectorAll('button')[1];

    encodeButton.addEventListener('click', encode);
    decodeButton.addEventListener('click', decode);

    let encryptedMessage = '';
    let decryptedMessage = '';

    function encode() {
        let text = firstTextArea.nodeValue;

        for (const char of text) {
            let key = char.charCodeAt(0);
            key++;
            let newChar = String.fromCharCode(key);

            encryptedMessage += newChar;
        }
        firstTextArea.value = '';
        secondTextArea.value = encryptedMessage;
    }

    function decode() {
        for (const char of encryptedMessage) {
            let key = char.charCodeAt(0);
            key--;
            let newChar = String.fromCharCode(key);

            decryptedMessage += newChar;
        }

        secondTextArea.value = decryptedMessage;
    }

}