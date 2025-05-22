async function loadConvenios() {
    console.log('Formulário enviado');
    const response = await fetch('/Convenio');
    const Convenios = await response.json();

    const list = document.getElementById('ConveniosList');
    list.innerHTML = '';

    Convenios.forEach(element => {
        const item = document.createElement('li');
        item.textContent = element.nome;
        list.appendChild(item);
    });
}

document.getElementById('ConvenioForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    const nome = document.getElementById('ConvenioNome').value;
    const btn = e.target.querySelector('button');
    btn.disabled = true;

    const response = await fetch('/Convenio', {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({nome})
    });

    if (response.ok) {
        document.getElementById('ConvenioNome').value = '';
        await loadConvenios();
        alert("Convênio adicionado!");
    } else {
        alert("Erro ao adicionar");
    }
    btn.disabled = false;
});

window.onload = loadConvenios;