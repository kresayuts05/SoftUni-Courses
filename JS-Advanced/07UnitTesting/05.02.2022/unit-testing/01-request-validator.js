
function solve(input) {
    validateMethod(input);
    validateUri(input);
    validateVersion(input);
    validateMessage(input);
    return input;

    function validateMethod(input) {
        let methodValues = ['GET', 'POST', 'DELETE', 'CONNECT'];

        if (input['method'] === undefined || !methodValues.includes(input.method)) {
            throw new Error('Invalid request header: Invalid Method');
        }
    }

    function validateUri(input) {
        const re =/^(\.*\d*[a-z]+\d*[a-z]*\.*\d*[a-z]*\d*)+$/;

        if (input['uri'] === undefined || input.uri.match(re) === null || input.uri === '') {
            throw new Error('Invalid request header: Invalid URI');
        }
    }

    function validateVersion(input) {
        let versionValues = ['HTTP/0\.9', 'HTTP/1\.0', 'HTTP/1\.1', 'HTTP/2\.0'];

        if (input['version'] === undefined || !versionValues.includes(input.version)) {
            throw new Error('Invalid request header: Invalid Version');
        }
    }

    function validateMessage(input) {
        const reg = new RegExp('[\<\>\\\&\'\"]', 'g');

        if (input['message'] === undefined || reg.test(input.message)) {
            if (input.message === '') {

            } else {
                throw new Error('Invalid request header: Invalid Message');
            }
        }
    }

}
try {
    console.log(solve({
        method: 'GET',
        uri: 'define apps',
        version: 'HTTP/1.1',
        message: ''
      }
      ))
}
catch (e) {
    console.error(e);
}

