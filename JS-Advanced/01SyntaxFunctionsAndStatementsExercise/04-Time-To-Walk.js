function solve(steps, footprintInMetres, speed) {
    let footprint = footprintInMetres / 1000;

    let distance = footprint * steps;

    let breaks = Math.floor(distance / 0.5);

    let timeInSeconds = (distance / speed) * 3600 + breaks * 60;
    let seconds = timeInSeconds % 60;

    let timeInMinutes = timeInSeconds / 60; 
    let minutes = Math.floor(timeInMinutes % 60);

    let timeInHours = String(Math.floor(timeInMinutes / 60));

    let output = `${timeInHours.padStart(2, '0')}:${minutes}:${seconds.toFixed()}`;

    console.log(output);
}

solve(2564, 0.70, 5.5);