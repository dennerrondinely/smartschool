namespace SmartSchool.API.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoID, int disciplinaId)
        {
            this.AlunoID = alunoID;
            this.DisciplinaId = disciplinaId;
        }
        public int AlunoID { get; set; }
        public Aluno Aluno { get; set; }
        public int DisciplinaId { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}