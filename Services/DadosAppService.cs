using afya_admin.Models;

namespace afya_admin.Services;

public class DadosAppService
{
    public List<Aluno> Alunos { get; } = new();

    public List<Projeto> Projetos { get; } = new();
}