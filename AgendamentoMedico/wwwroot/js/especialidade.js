async function loadEspecialidades() {
    console.log('Formulário enviado');
    const response = await fetch('/especialidade');
    const especialidades = await response.json();

    const list = document.getElementById('especialidadesList');
    list.innerHTML = '';

    especialidades.forEach(element => {
        const item = document.createElement('li');
        item.textContent = element.nome;
        list.appendChild(item);
    });
}

document.getElementById('especialidadeForm').addEventListener('submit', async function (e) {
    e.preventDefault();
    const nome = document.getElementById('especialidadeNome').value;
    const btn = e.target.querySelector('button');
    btn.disabled = true;

    const response = await fetch('/especialidade', {
        method: 'POST',
        headers: {'Content-Type': 'application/json'},
        body: JSON.stringify({nome})
    });

    if (response.ok) {
        document.getElementById('especialidadeNome').value = '';
        await loadEspecialidades();
        alert("Especialidade adicionada");
    } else {
        alert("Erro ao adicionar");
    }
    btn.disabled = false;
});

window.onload = loadEspecialidades;