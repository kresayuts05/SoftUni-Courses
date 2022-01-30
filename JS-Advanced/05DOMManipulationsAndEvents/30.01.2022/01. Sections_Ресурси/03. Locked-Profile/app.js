function lockedProfile() {
    let profiles = document.querySelectorAll('.profile');

    for (const profile of profiles) {
        let radioButton = profile.getElementsByTagName("input");

        if (radioButton.checked === false) {
            let moreButton = profile.lastChild;

            moreButton.addEventListener("click", (e) => {
                e.target.parentNode.previousSibling.style.display = 'block';
            })
        }
    }
}