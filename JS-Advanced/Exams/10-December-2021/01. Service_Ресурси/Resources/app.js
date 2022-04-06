window.addEventListener('load', solve);

function solve() {
    let sendBtn = document.querySelector('#right button');

    let productTypeElement;
    let descriptionElement;
    let nameElement;
    let phoneElement;

    let productType;
    let description;
    let name;
    let phone;

    sendBtn.addEventListener('click', sendHandler);

    function sendHandler(e) {
        e.preventDefault();

        productTypeElement = document.getElementById('type-product');
        descriptionElement = document.getElementById('description');
        nameElement = document.getElementById('client-name');
        phoneElement = document.getElementById('client-phone');

        productType = productTypeElement.value;
        description = descriptionElement.value;
        name = nameElement.value;
        phone = phoneElement.value;

        if (description != ''
            && name != ''
            && phone != ''
            && productType != '') {
            let ordersSection = document.getElementById('received-orders');

            let div = document.createElement('div');
            div.classList.add('container');
            ordersSection.appendChild(div);

            let h2Product = document.createElement('h2');
            h2Product.textContent = 'Product type for repair: ' + productType;
            div.appendChild(h2Product);

            let h3Information = document.createElement('h3');
            h3Information.textContent = 'Client information: ' + name + ', ' + phone;
            div.appendChild(h3Information);

            let h4Description = document.createElement('h4');
            h4Description.textContent = 'Description of the problem: ' + description;
            div.appendChild(h4Description);

            let startBtn = document.createElement('button');
            startBtn.classList.add('start-btn');
            startBtn.textContent = 'Start repair';
            div.appendChild(startBtn);

            let finishBtn = document.createElement('button');
            finishBtn.classList.add('finish-btn');
            finishBtn.textContent = 'Finish repair';
            finishBtn.disabled = true;
            div.appendChild(finishBtn);

            productTypeElement.value = '';
            descriptionElement.value = '';
            nameElement.value = '';
            phoneElement.value = '';

            startBtn.addEventListener('click', startHandler);
            finishBtn.addEventListener('click', finishHandler);

            function startHandler(e) {
                e.preventDefault();

                startBtn.disabled = true;
                finishBtn.disabled = false;
            }

            function finishHandler(e) {
                e.preventDefault();

                let finishSection = document.getElementById('completed-orders');

                let div = e.target.parentNode;
                let clone = div.cloneNode(true);
                clone.lastChild.remove();
                clone.lastChild.remove();

                finishSection.appendChild(clone);
                div.remove();

                clearBtn.addEventListener('click', clearHandler);
            }

            let clearBtn = document.querySelector('.clear-btn');

            

            function clearHandler(e){
                e.preventDefault();

                let section = document.getElementById('completed-orders')

                let divs = section.querySelectorAll('.container');
                
                for (let index = 0; index < divs.length; index++) {
                    divs[index].remove();
                }
            }
        }
    }
}