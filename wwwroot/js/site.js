let sliderImage = document.querySelector('.showingL');
let sliderImageR = document.querySelector('.showingR');

let count = 0;
function changeImage() {

  
    for (i = 0; i < 1; i++) {
        count = count + 1;
        if (count > 7) {
            count = 1;
        }
    }
    console.log(count);
    switch (count) {
        case 1:
            sliderImage.src = "/Samples/Banner1.jpg";
            sliderImageR.src = "/Samples/Banner4.jpg";
            break;
        case 2:
            sliderImage.src = "/Samples/Banner2.jpg";
            sliderImageR.src = "/Samples/Banner5.jpg";
            break;
        case 3:
            sliderImage.src = "/Samples/Banner3.jpg";
            sliderImageR.src = "/Samples/Banner7.jpg";
            break;
        case 4:
            sliderImage.src = "/Samples/Banner4.jpg";
            sliderImageR.src = "/Samples/Banner6.jpg";
            break;
        case 5:
            sliderImage.src = "/Samples/Banner5.jpg";
            sliderImageR.src = "/Samples/Banner1.jpg";
            break;
        case 6:
            sliderImage.src = "/Samples/Banner6.jpg";
            sliderImageR.src = "/Samples/Banner2.jpg";
            break;
        case 7:
            sliderImage.src = "/Samples/Banner7.jpg";
            sliderImageR.src = "/Samples/Banner3.jpg";
            break;

    }
}

setInterval(changeImage, 7000);