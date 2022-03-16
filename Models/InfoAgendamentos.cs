using System.Collections.Generic;
namespace Atividade_3.Models
{
    public class InfoAgendamentos
    {
        private static List<Agendamento> agendamento = new List<Agendamento>();
        public static void Incluir(Agendamento i)
        {
            agendamento.Add(i);
        }

        public static List<Agendamento> Listar()
        {
            return agendamento;
        }
    }
}