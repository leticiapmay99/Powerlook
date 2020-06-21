using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerLook_Aluguel
{
    class MeusFormularios
    {
        public static Form_cad_produto  FormProduto { get; set; }
        public static Form_cad_Fornecedor FormFornecedor { get; set; }
        public static Form_cad_cliente FormCliente { get; set; }
        public static Form_cad_funcionario FormFuncionario { get; set; }

        public static Form_cad_categoria FormCategoria { get; set; }


        public static Form_Venda FormVenda { get; set; }


        public static Form_buscas FormBuscas { get; set; }

        public static Form_busca_CategoriaVestido FormCategoriaVestidos { get; set; }
        public static Form_relatorios FormRelatorios { get; set; }
        public static Form_relatorio_produto FormRelatoriosProduto { get; set; }
        public static Form_relatorio_cliente FormRelatoriosCliente{ get; set; }
        public static Form_relatorio_fornecedor FormRelatoriosFornecedor{ get; set; }

      
    }
}
