var slider = document.getElementById("meuLimite");
var output = document.getElementById("valor-solicitado");

output.innerHTML = slider.value;

slider.oninput = function (){
    output.innerHTML = this.value;
}
