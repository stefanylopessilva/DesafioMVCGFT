/* Variáveis */

//var enderecoProduto = "https://localhost:44303/Produto/Produto/";
var enderecoProduto = "https://localhost:5001/Produto/Produto/";
//var enderecoVenda = "https://localhost:44303/Venda/";
var enderecoVenda = "https://localhost:5001/Venda/";
var compra = [];
var produto;
var saldo;
var valorTotalDaVenda = 0.00;

/* Inicio */

AtualizarValorTotalDaVenda();
$("#posvenda").hide();


/* Preenchimento de Campos*/

function AtualizarValorTotalDaVenda() {
    $("#valorTotalDaVenda").html(valorTotalDaVenda);
}

function preencherForumlario(dadosProduto) {
    $("#NomeProduto").val(dadosProduto.produto.nome)
    $("#CategoriaProduto").val(dadosProduto.produto.categoria.nome)
    $("#FornecedorProduto").val(dadosProduto.produto.fornecedor.nome)
    $("#PrecoCustoProduto").val(dadosProduto.produto.precoCusto)
    $("#PrecoVendaProduto").val(dadosProduto.produto.precoVenda)
    $("#SaldoDoItem").val(dadosProduto.saldo)
}

function limparForumlario() {
    $("#NomeProduto").val("");
    $("#CategoriaProduto").val("");
    $("#FornecedorProduto").val("");
    $("#PrecoCustoProduto").val("");
    $("#PrecoVendaProduto").val("");
    $("#QuantidadeProduto").val("");
    $("#SaldoDoItem").val("");
}

$('#tabelaProdutos').on('click', '.remover', function () {
    var indice = this.parentElement.parentElement.rowIndex - 1;

    valorTotalDaVenda -= compra[indice].subtotal;
    AtualizarValorTotalDaVenda();

    compra.splice(indice, 1)
    
    $(this).closest('tr').remove();
});


function adicionarProdutoNaTabela(p, q) {

    var produtoTemp = {};
    Object.assign(produtoTemp, produto)

    var venda = { produto: produtoTemp, quantidade: q, subtotal: produtoTemp.precoVenda * q };

    valorTotalDaVenda += venda.subtotal;
    AtualizarValorTotalDaVenda();

    compra.push(venda);

    $("#tbodyProdutos").append(`
    <tr>
        <td>${p.id}</td>
        <td>${p.nome}</td>
        <td>${q}</td>
        <td>R$${p.precoVenda}</td>
        <td>${p.unidade.nome}</td>
        <td>R$${p.precoVenda * q}</td>
        <td><button class="remover btn btn-danger" id="excluir">Excluir</button></td>
    </tr>`);
}

$("#produtoForm").on("submit", function (event) {
    event.preventDefault();
    var produtoTabela = produto;
    var quantidade = $("#QuantidadeProduto").val()

    if (saldo < quantidade) {
        alert(`Saldo indisponível! Esse item tem apenas ${saldo} de saldo!`);
    } else {
        adicionarProdutoNaTabela(produtoTabela, quantidade);
        limparForumlario();
    }

});

/* AJAX */
$("#pesquisarProduto").click(function () {
    var codProduto = $("#codProduto").val();
    var enderecoTemporario = enderecoProduto + codProduto
    $.post(enderecoTemporario, function (dados, estados) {
        /*alert("Dados: " + dados + " Status: " + status)*/
        produto = dados.produto;
        saldo = dados.saldo
        preencherForumlario(dados);
    }).fail(function() {
        alert("Produto inválido!");
    })
})


/* Finalização da Venda */

$("#BtnFinalizarVenda").click(function () {
    if (valorTotalDaVenda <= 0) {
        alert("Compra inválida! Nenhum produto selecionado!")
        return;
    } else {
        var valorPago = $("#valorPago").val();

        if (isNaN(valorPago)) {
            alert("VALOR INVÁLIDO!");
            return;
        } else if (valorPago < valorTotalDaVenda) {
            alert("Valor pago inferior ao valor da compra!");
            return;
        } else { 
            $("#posvenda").show();
            $("#prevenda").hide();
            $("#valorPago").prop("disabled", true)
            var valorTroco = valorPago - valorTotalDaVenda;
            $("#valorTroco").val(valorTroco);

            compra.forEach(elemento => {
                elemento.produto = elemento.produto.id;
            });

            var venda = {
                total: valorTotalDaVenda,
                troco: valorTroco,
                produtos: compra

            }

            $.ajax({
                type: "post",
                url: enderecoVenda,
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(venda),
                success: function (dados) {
                    console.log("Dados enviados com sucesso!");
                    console.log(dados);
                }
            });

            $('#tbodyProdutos').empty();
        }
    }
});

function restaurarTela() {
    $("#posvenda").hide();
    $("#prevenda").show();
    $("#valorPago").prop("disabled", false)
    $("#valorPago").val("");
    $("#valorTroco").val("");
}

$("#btnFechar").click(function () {
    restaurarTela();
});