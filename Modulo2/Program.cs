using Modulo2.models;

Pessoa p1 = new Pessoa();
p1.Nome = "Rafael";
p1.Sobrenome = "Silva";

Pessoa p2 = new Pessoa();
p2.Nome = "Isabela";
p2.Sobrenome = "Castro";

Curso ingles = new Curso();
ingles.Nome = "Inglês";
ingles.Alunos = new List<Pessoa>();

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();
