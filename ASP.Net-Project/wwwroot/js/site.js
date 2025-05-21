document.addEventListener('mousemove', onMouseMove);
window.addEventListener('resize', onResize);

function onMouseMove(event) {
    const x = event.clientX;
    const y = event.clientY;
    cursor.updateTargetPosition(x, y);
}
function onResize() {
    const { x, y, width, height } = menuBtn.getBoundingClientRect();
    gsap.set(cta, {
        left: x - width,
        top: y + height
    });
}

