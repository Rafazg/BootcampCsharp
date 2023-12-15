using Modulo2.models;

Pessoa p1 = new(nome:"Rafael", sobrenome:"Silva");

Pessoa p2 = new(nome:"Isabela", sobrenome:"Castro");

Curso ingles = new Curso();
ingles.Nome = "Inglês";
ingles.Alunos = new List<Pessoa>();

ingles.AdicionarAluno(p1);
ingles.AdicionarAluno(p2);
ingles.ListarAlunos();
