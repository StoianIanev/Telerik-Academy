var imgs = [
            '<img src="imgs/cute-husky-picture.jpg"/>',
            '<img src="imgs/images.jpg" />',
            '<img src="imgs/picture-image.jpg" />',
            '<img src="imgs/picture-wallpaper.jpg" />',
            '<img src="imgs/Small_Dogs_Picture.jpg" />',
            '<img src="imgs/squirrel-michelang_2384189k.jpg" />'
];

(function () {
    var currentSlide = 0;
    setSlideToCurrent();
    $('#next').on('click', nextSlide);
    $('#previous').on('click', prevSlide);
    function nextSlide() {
        currentSlide++;
        if (currentSlide === imgs.length) {
            currentSlide = 0;
        }
        setSlideToCurrent();
        resetTimer();
    }
    function prevSlide() {
        currentSlide--;
        if (currentSlide < 0) {
            currentSlide = imgs.length - 1;
        }
        setSlideToCurrent();
        resetTimer();
    }
    function setSlideToCurrent() {
        $('#current-slide').html(imgs[currentSlide]);
    }
    function resetTimer() {
        clearInterval(autoSlideChanger);
        autoSlideChanger = setInterval(nextSlide, 5000);
    }
    var autoSlideChanger = setInterval(nextSlide, 5000);
})();