// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


function typeWriter(elemento) {
    const textoArray = elemento.innerHTML.split('');
    elemento.innerHTML = '';
    textoArray.forEach((letra, i) => {
        setTimeout(() => elemento.innerHTML += letra, 150 * i);
    });
}

const titulo = document.querySelector('.escreve');

typeWriter(titulo);

const titulo2 = document.querySelector('.escreve2');

typeWriter(titulo2);

//

function mostraImagem(img) {
    if (img.files && img.files[0]) {
        var reader = new FileReader();
        var imagem = document.getElementById("imgUsuario");
        reader.onload = function (e) {
            imagem.src = e.target.result;
        };
        reader.readAsDataURL(img.files[0]);
    }
}