const controle = document.querySelectorAll("[data-controle]")
const estatistica = document.querySelectorAll("[data-estatistica]")
// const salvarItem = document.querySelectorId("salvar")

const charStatus = {
    "forca": {
        "forca": 10
    },
    "agilidade": {
        "velocidade": 10
    },
    "vitalidade": {
        "hp": 50
    },
    "inteligencia": {
        "mana": 25
    }
}

controle.forEach((elemento) => {
    elemento.addEventListener('click', (evento) => {
        const multiplicador = manipulaDados(evento.target.textContent, evento.target.parentNode);
        atualizaEstatistica(evento.target.dataset.ponto, multiplicador)
    })
})

function manipulaDados(operacao, controle) {
    const ponto = controle.querySelector("[data-contador]");
				if (operacao ==="-"&& ponto.value == 0) {
					return 0;
				}
				else{
					if (operacao === "-") {
						ponto.value = parseInt(ponto.value) - 1;
						return -1;
		} else {
						ponto.value = parseInt(ponto.value) + 1;
						return 1;
		}
}
				}
    

function atualizaEstatistica(ponto, multiplicador) {
    estatistica.forEach((elemento) => {
        const soma = charStatus[ponto][elemento.dataset.estatistica] * multiplicador;
        if (!isNaN(soma)) {
            elemento.textContent = parseInt(elemento.textContent) + soma;
        }
    })
}



function salvarInformacoes() {
    const data = {
        forca: document.querySelector("[data-contador='forca']").value,
        agilidade: document.querySelector("[data-contador='agilidade']").value,
        vitalidade: document.querySelector("[data-contador='vitalidade']").value,
        inteligencia: document.querySelector("[data-contador='inteligencia']").value,
        estatisticaForca: document.querySelector("[data-estatistica='forca']").textContent,
        estatisticaHP: document.querySelector("[data-estatistica='hp']").textContent,
        estatisticaMana: document.querySelector("[data-estatistica='mana']").textContent,
        estatisticaVelocidade: document.querySelector("[data-estatistica='velocidade']").textContent
    };

    const jsonData = JSON.stringify(data);
    const blob = new Blob([jsonData], { type: "application/json" });
    const url = URL.createObjectURL(blob);

    const link = document.createElement("a");
    link.href = url;
    link.download = "personagem.json";
    link.click();

    // Limpa a URL do objeto após o download
    URL.revokeObjectURL(url);
}


//carregar

function carregarInformacoes() {
    const input = document.createElement("input");
    input.type = "file";
    input.accept = "application/json";
  
    input.onchange = function (event) {
      const file = event.target.files[0];
      const reader = new FileReader();
  
      reader.onload = function (event) {
        const jsonData = event.target.result;
        const data = JSON.parse(jsonData);
								
        document.querySelector("[data-contador='forca']").value = data.forca;
        document.querySelector("[data-contador='agilidade']").value = data.agilidade;
        document.querySelector("[data-contador='vitalidade']").value = data.vitalidade;
        document.querySelector("[data-contador='inteligencia']").value = data.inteligencia;
        document.querySelector("[data-estatistica='forca']").textContent = data.estatisticaForca;
        document.querySelector("[data-estatistica='hp']").textContent = data.estatisticaHP;
        document.querySelector("[data-estatistica='mana']").textContent = data.estatisticaMana;
        document.querySelector("[data-estatistica='velocidade']").textContent = data.estatisticaVelocidade;
								console.log(data);
      };
  
      reader.readAsText(file);
    };
				
    input.click();
  }
  