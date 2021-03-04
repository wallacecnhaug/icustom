Funcionalidade: Cadastro de Usuarios
	Os usuários no sistema podem ser adicionados. 
	Uma vez cadastrados no sistema, eles podem se utilizar do seu e-mail como "login".
	Os usuários também podem ser exibidos em uma listagem com seus dados cadastrados.


@CadastroUsuario
Cenario: Adicionar usuário válido com sucesso
	Dado que foi informado os dados de usuário com login 'adicionadosilva@email.com'
	E com nome 'Adicionado da Silva' 
	E com senha '123456789'
	E faço uma conferência dos dados na tela
	Quando clico no botão 'Salvar'
	Entao O sistema me retorna uma mensagem de sucesso: 'Login adicionadosilva@email.com cadastrado com sucesso.'

@CadastroUsuario
Cenario: Adicionar usuário inválido com tratamento de erro
	Dado que foi informado os dados de usuário com login 'adicionadosilva@email.com'
	E com nome 'Adicionado da Silva' 
	E com senha ''
	E faço uma conferência dos dados na tela
	Quando clico no botão 'Salvar'
	Entao O sistema me retorna uma mensagem de sucesso: 'Senha é obrigatório.'