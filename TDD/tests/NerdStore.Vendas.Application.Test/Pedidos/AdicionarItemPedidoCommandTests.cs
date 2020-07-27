using NerdStore.Vendas.Application.Commands;
using System;
using Xunit;

namespace NerdStore.Vendas.Application.Test.Pedidos
{
    [Trait("Categoria", "Vendas - Pedido Commands")]
    public class AdicionarItemPedidoCommandTests
    {
        [Fact(DisplayName = "Adicionar item command válido")]
        public void AdicionarItemPedidoCommand_CommandEstaValido_DevePassarValidacao()
        {
            // Arrange
            var pedidoCommand = new AdicionarItemPedidoCommand(Guid.NewGuid(), Guid.NewGuid(), "Produto Teste", 2, 100);

            // Act
            var result = pedidoCommand.EhValido();

            // Assert		  
            Assert.True(result);
        }
    }
}
