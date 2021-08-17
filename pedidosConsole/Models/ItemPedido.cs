using System;
using System.Collections.Generic;
using System.Text;

namespace pedidosConsole.Models {
    public class ItemPedido {

        public Produto Produto { get; set; }

        private int Quantity;

        public int Quantidade {
            get => Quantity;

            set {
                if(value > 0) {
                    Quantity = value;
                }
            }
        }

        public double SubTotal() {
            return Produto.Preco * Quantidade;
        }


        public void Imprimir(ItemPedido item) {
            Console.WriteLine($"Descrição: {Produto.Nome} | Valor unitário: {Produto.Preco} " +
                $"| Quantidade: {item.Quantidade}");
        }
    }
}
