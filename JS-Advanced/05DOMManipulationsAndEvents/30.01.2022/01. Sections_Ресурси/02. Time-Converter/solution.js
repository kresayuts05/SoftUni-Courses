function attachEventsListeners() {

    let daysButton = document.getElementById('daysBtn');
    let daysInput = document.getElementById('days');

    let hoursButton = document.getElementById('hoursBtn');
    let hoursInput = document.getElementById('hours');

    let minutesButton = document.getElementById('minutesBtn');
    let minutesInput = document.getElementById('minutes');

    let secondsButton = document.getElementById('secondsBtn');
    let secondsInput = document.getElementById('seconds');

    daysButton.addEventListener("click", (e) => {
        hoursInput.value = daysInput.value * 24;
        minutesInput.value = daysInput.value * 1440;
        secondsInput.value = daysInput.value * 86400;
    });

    hoursButton.addEventListener("click", (e) => {
        daysInput.value = hoursInput.value / 24;
        minutesInput.value = hoursInput.value * 60;
        secondsInput.value = hoursInput.value * 3600;
    });

    minutesButton.addEventListener("click", (e) => {
        daysInput.value = minutesInput.value / 1440;
        hoursInput.value = minutesInput.value / 60;
        secondsInput.value = minutesInput.value * 60;
    });

    secondsButton.addEventListener("click", (e) => {
        daysInput.value = secondsInput.value / 86400;
        hoursInput.value = secondsInput.value / 360;
        minutesInput.value = secondsInput.value / 60;
    });
}