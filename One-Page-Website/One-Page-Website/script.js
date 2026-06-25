const images = [
"https://picsum.photos/id/1015/900/600",
"https://picsum.photos/id/1016/900/600",
"https://picsum.photos/id/1025/900/600",
"https://picsum.photos/id/1035/900/600"
];

let currentImageIndex = 0;

function openLightbox(index) {
currentImageIndex = index;
document.getElementById("lightbox").style.display = "block";
document.getElementById("lightbox-img").src = images[currentImageIndex];
}

function closeLightbox() {
document.getElementById("lightbox").style.display = "none";
}

function changeImage(direction) {
currentImageIndex = currentImageIndex + direction;

```
if (currentImageIndex < 0) {
    currentImageIndex = images.length - 1;
}

if (currentImageIndex >= images.length) {
    currentImageIndex = 0;
}

document.getElementById("lightbox-img").src = images[currentImageIndex];
```

}
