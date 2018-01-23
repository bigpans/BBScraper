function carregarDados(data) {
    var obj = JSON.parse(data.usuario);
    $('#formulario').fadeOut();
    $('#resultadoHtml').fadeIn();
    console.log(obj);


    document.getElementById('nomeUsuario').textContent = obj.login.nomeCliente;
    document.getElementById('agencia').textContent = obj.login.dependenciaOrigem;
    document.getElementById('conta').textContent = obj.login.numeroContratoOrigem;
    document.getElementById('tipo').textContent = obj.login.segmento;
    document.getElementById('mci').textContent = obj.login.mci;
}