using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjControleCustomizado
{
    public partial class ucEstados: UserControl
    {
        public ucEstados()
        {
            InitializeComponent();
        }

    }

    private void ucEstados_Load(object sender, EventArgs e)
    {
        List<Estado> lista = new List<Estado>();
        lista.Add(new Estado("SP", "SAO PAULO"));
        lista.Add(new Estado("RJ", "RIO DE JANEIRO"));
        lista.Add(new Estado("MG", "MINAS GERAIS"));
        lista.Add(new Estado("ES", "ESPIRITO SANTO"));

        lista.Add(new Estado("PR", "PARANA"));
        lista.Add(new Estado("SC", "SANTA CATARINA"));
        lista.Add(new Estado("RS", "RIO GRANDE DO SUL"));

        lista.Add(new Estado("MT", "MATO GROSSO"));
        lista.Add(new Estado("MS", "MATO GROSSO DO SUL"));
        lista.Add(new Estado("GO", "GOIAS"));

        lista.Add(new Estado("TO", "TOCANTINS"));
        lista.Add(new Estado("AM", "AMAZONAS"));
        lista.Add(new Estado("PA", "PARA"));
        lista.Add(new Estado("RO", "RONDONIA"));
        lista.Add(new Estado("AP", "AMAPÁ"));
        lista.Add(new Estado("RR", "RORAIMA"));
        lista.Add(new Estado("AC", "ACRE"));

        lista.Add(new Estado("RN", "RIO GRANDE DO NORTE"));
        lista.Add(new Estado("PE", "PERNAMBUCO"));
        lista.Add(new Estado("PI", "PIAUI"));
        lista.Add(new Estado("MA", "MARANHÃO"));
        lista.Add(new Estado("SE", "SERGIPE"));
        lista.Add(new Estado("CE", "CEARA"));
        lista.Add(new Estado("PB", "PARAIBA"));
        lista.Add(new Estado("AL", "ALAGOAS"));
        lista.Add(new Estado("BH", "BAHIA"));
        lista.Add(new Estado("DF", "DISTRITO FEDERAL"));

        cbEstado.DataSource = lista;
        cbEstado.DisplayMember = "Nome";
        cbEstado.ValueMember = "Sigla";
    }
}
