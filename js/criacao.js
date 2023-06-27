const controle = document.querySelectorAll("[data-controle]")
const estatistica = document.querySelectorAll("[data-estatistica]")

const statos = {
 "forca":{
    "forca" : 10
 },
"agilidade":{
    "velicidade":10
},
"vitalidade":{
    "hp":  50
},
"inteligencia":{
    "mana":25
}
}



controle.forEach( (elemento) => {
    elemento.addEventListener('click', (evento) => {
        manipulaDados(evento.target.textContent, evento.target.parentNode)
        atualizaEstatistica(evento.target.dataset.estatistica)
    })
})

function manipulaDados(operacao, controle) {
    const ponto = controle.querySelector("[data-contador]");

    if (operacao === "-") {
        ponto.value = parseInt(ponto.value) - 1;
    } else {
        ponto.value = parseInt(ponto.value) + 1;
    }
}

function atualizaEstatistica(ponto) {
    estatistica.forEach( (elemento ) => {
        elemento.textContent = parseInt(elemento.textContent) + statos[ponto][elemento.dataset.estatistica]
    })
}