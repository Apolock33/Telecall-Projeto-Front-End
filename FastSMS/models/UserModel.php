<?php
class UserModel {

    public function insert($conexao, $userData) {
        $nome = $userData['nome'];
        $dataNascimento = $userData['birthdate'];
        $sexo = $userData['gender'];
        $nomeMaterno = $userData['mother'];
        $cpf = $userData['cpf'];
        $celular = $userData['cellphone'];
        $telefoneFixo = $userData['phone'];
        $endereco = $userData['address'];
        $email = $userData['email'];
        $senha = password_hash($userData['password'], PASSWORD_DEFAULT); // Hash da senha
        $tipoUser = 'User'; // Padrão 'User'

        $query = "INSERT INTO usuarios (nome, data_nascimento, sexo, nome_materno, cpf, celular, telefone_fixo, endereco, login, senha, tipo_user) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";
        $stmt = $conexao->prepare($query);

        $stmt->bind_param("sssssssssss", $nome, $dataNascimento, $sexo, $nomeMaterno, $cpf, $celular, $telefoneFixo, $endereco, $email, $senha, $tipoUser);
        $result = $stmt->execute();

        $stmt->close();

        if ($result) {
            return true;
        } else {
            return false;
        }
    }
    
}
?>
