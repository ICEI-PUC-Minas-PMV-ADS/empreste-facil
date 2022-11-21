var slider = document.getElementById("meuLimite");
var output = document.getElementById("valor-solicitado");

output.innerHTML = slider.value;

slider.oninput = function (){
    output.innerHTML = this.value * 500;
}

slider.addEventListener("mousemove", function () {
    var x = slider.value;
    var color = 'linear-gradient(90deg, rgb(117,252,117)' + x + '%, rgb(214,214,214)' + x + '%)';
    slider.style.background = color;
})

/*********************   Simulador de parcelas da HOME     ***********************************/


function simular6()
{
    var taxa = 0.04
    var parcela6 = 6
    var valor = document.getElementById('valorSolicitado')
    var n1 = Number(valor.value)
    var simula6 = document.getElementById('simul6x')

    // Formula: PMT = [PV. (1 + i) ^ n] i / [(1 + i) ^ n - 1]

    var elemento1 = n1 * ((1 + taxa) ** parcela6) * taxa
    var elemento2 = ((1 + taxa) ** parcela6) - 1

    var res6 = elemento1 / elemento2


    simul6x.innerHTML = `6 x de ${res6.toLocaleString('pt-Br', { style: 'currency', currency: 'BRL' }) }`
}

function simular12()
{
    var taxa = 0.04
    var parcela12 = 12
    var valor = document.getElementById('valorSolicitado')
    var n1 = Number(valor.value)
    var simula12 = document.getElementById('simul12x')

    // Formula: PMT = [PV. (1 + i) ^ n] i / [(1 + i) ^ n - 1]

    var elemento1 = n1 * ((1 + taxa) ** parcela12) * taxa
    var elemento2 = ((1 + taxa) ** parcela12) - 1

    var res12 = elemento1 / elemento2


    simul12x.innerHTML = `12 x de ${res12.toLocaleString('pt-Br', { style: 'currency', currency: 'BRL' })}`
}

function simular18()
{
    var taxa = 0.04
    var parcela18 = 18
    var valor = document.getElementById('valorSolicitado')
    var n1 = Number(valor.value)
    var simula18 = document.getElementById('simul18x')

    // Formula: PMT = [PV. (1 + i) ^ n] i / [(1 + i) ^ n - 1]

    var elemento1 = n1 * ((1 + taxa) ** parcela18) * taxa
    var elemento2 = ((1 + taxa) ** parcela18) - 1

    var res18 = elemento1 / elemento2


    simul18x.innerHTML = `18 x de ${res18.toLocaleString('pt-Br', { style: 'currency', currency: 'BRL' })}`
}

function simular24()
{
    var taxa = 0.04
    var parcela24 = 24
    var valor = document.getElementById('valorSolicitado')
    var n1 = Number(valor.value)
    var simula24 = document.getElementById('simul24x')

    // Formula: PMT = [PV. (1 + i) ^ n] i / [(1 + i) ^ n - 1]

    var elemento1 = n1 * ((1 + taxa) ** parcela24) * taxa
    var elemento2 = ((1 + taxa) ** parcela24) - 1

    var res24 = elemento1 / elemento2


    simul24x.innerHTML = `24 x de ${res24.toLocaleString('pt-Br', { style: 'currency', currency: 'BRL' })}`
}

