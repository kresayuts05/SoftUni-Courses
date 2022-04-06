function solve() {
    let addBtn = document.getElementById('add-worker');

    let firstNameElement;
    let lastNameElement;
    let emailElement;
    let birthElement;
    let positionElement;
    let salaryElement;

    let firstName;
    let lastName;
    let email;
    let birth;
    let position;
    let salary;

    addBtn.addEventListener('click', addHandler);

    function addHandler(e) {
        e.preventDefault();

        firstNameElement = document.getElementById('fname');
        lastNameElement = document.getElementById('lname');
        emailElement = document.getElementById('email');
        birthElement = document.getElementById('birth');
        positionElement = document.getElementById('position');
        salaryElement = document.getElementById('salary');

        if (firstNameElement.value != ''
            && lastNameElement.value != ''
            && emailElement.value != ''
            && birthElement.value != ''
            && positionElement.value != ''
            && salaryElement.value != '') {

            firstName = firstNameElement.value;
            lastName = lastNameElement.value;
            email = emailElement.value;
            birth = birthElement.value;
            position = positionElement.value;
            salary = salaryElement.value;

            let bodyElement = document.getElementById('tbody');

            let trElement = document.createElement('tr');
            bodyElement.appendChild(trElement);

            let tdFname = document.createElement('td');
            tdFname.textContent = firstName;
            trElement.appendChild(tdFname);

            let tdLname = document.createElement('td');
            tdLname.textContent = lastName;
            trElement.appendChild(tdLname);

            let tdEmail = document.createElement('td');
            tdEmail.textContent = email;
            trElement.appendChild(tdEmail);

            let tdBirth = document.createElement('td');
            tdBirth.textContent = birth;
            trElement.appendChild(tdBirth);

            let tdPosition = document.createElement('td');
            tdPosition.textContent = position;
            trElement.appendChild(tdPosition);

            let tdSalary = document.createElement('td');
            tdSalary.textContent = salary;
            trElement.appendChild(tdSalary);

            let tdBtn = document.createElement('td');
            trElement.appendChild(tdBtn);

            let firedBtn = document.createElement('button');
            firedBtn.classList.add('fired');
            firedBtn.textContent = 'Fired';
            tdBtn.appendChild(firedBtn);

            let editBtn = document.createElement('button');
            editBtn.classList.add('edit');
            editBtn.textContent = 'Edit';
            tdBtn.appendChild(editBtn);

            let sumBudget = document.getElementById('sum');
            let sum = Number(sumBudget.textContent);
            let currSum = sum + Number(salary);
            sumBudget.textContent = currSum.toFixed(2);

            firstNameElement.value = '';
            lastNameElement.value = '';
            emailElement.value = '';
            birthElement.value = '';
            positionElement.value = '';
            salaryElement.value = '';

            editBtn.addEventListener('click', editHandler);

            function editHandler(e) {
                e.preventDefault();

                let children = Array.from(e.target.parentNode.parentNode.childNodes);

                firstNameElement.value = children[0].textContent;
                lastNameElement.value = children[1].textContent;
                emailElement.value = children[2].textContent;
                birthElement.value = children[3].textContent;
                positionElement.value = children[4].textContent;
                salaryElement.value = children[5].textContent;

                e.target.parentNode.parentNode.remove();

                let sumBudget = document.getElementById('sum');
                let sum = Number(sumBudget.textContent);
                let currSum = sum - Number(salaryElement.value);
                sumBudget.textContent = currSum.toFixed(2);
            }

            firedBtn.addEventListener('click', firedhandler);

            function firedhandler(e) {
                e.preventDefault();

                let children = Array.from(e.target.parentNode.parentNode.childNodes);

                salaryElement.value = children[5].textContent;

                e.target.parentNode.parentNode.remove();

                let sumBudget = document.getElementById('sum');
                let sum = Number(sumBudget.textContent);
                let currSum = sum - Number(salaryElement.value);
                sumBudget.textContent = currSum.toFixed(2);
            }
        }
    }
}
solve()