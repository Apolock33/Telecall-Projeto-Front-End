<?php
if (isset($_POST['submit'])) {
    require_once 'controllers/UserController.php';
    $userController = new UserController();
    $userController->register();
}
?>



<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Registro</title>
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
</head>
<body>
    <div class="registration-container">
        <h2>Cadastro de usuárioATT</h2>
        <form >
            <label for="name">Nome completo</label>
            <input type="text" name="nome" id="nome" placeholder="Informe o seu nome completo">

            <label for="birthdate">Data de Nascimento</label>
            <input type="date" id="birthdate" name="birthdate" required>

            <label for="gender">Sexo</label>
            <select id="gender" name="gender" required>
                <option value="male">Masculino</option>
                <option value="female">Feminino</option>
                <option value="other">Outro</option>
            </select>

            <label for="mother">Nome Materno</label>
            <input type="text" id="mother" name="mother" required>

            <label for="cpf">CPF</label>
            <input type="text" id="cpf" name="cpf" placeholder="Informe o CPF" required >
            
            <label for="cellphone">Telefone Celular</label>
            <input type="text" id="cellphone" name="cellphone" placeholder="Informe o celular" required>
            
            <label for="phone">Telefone Fixo</label>
            <input type="text" id="phone" name="phone" placeholder="Informe o telefone fixo">
            
            <label for="address">ENDEREÇO COMPLETO</label>
            <textarea id="address" name="address" placeholder="Informe o endereço completo" required></textarea>
            
            <label for="email">Email</label>
            <input type="text" name="email" id="email" placeholder="Informe o e-mail" required minlength="6">
            
            <label for="password">Senha</label>
            <input type="password" id="password" name="password" placeholder="Informe a senha" required minlength="8">
            
            <label for="confirm-password">Confirmação de Senha</label>
            <input type="password" id="confirm-password" name="confirm-password" placeholder="Confirme a senha" required minlength="8">

            <input type="button" name="submit" id="submit" disabled>
            <button type="submit" id="clear-button">Enviar</button>
        </form>
    </div>

    <div id="result"></div> <!-- Local para exibir o resultado do PHP -->


</body>

<style>
    body {
        margin: 0;
        padding: 0;
        font-family: Arial, sans-serif;
        background-color: #f2f2f2;
        display: flex;
        justify-content: center;
        align-items: center;
        min-height: 100vh;
    }

    .registration-container {
        background-color: #fff;
        border-radius: 10px;
        box-shadow: 0px 0px 10px rgba(0, 0, 0, 0.1);
        padding-left: 140px;
        padding-right: 140px;            
        text-align: left;
        width: 400px;
    }

    .registration-form {
        display: flex;
        flex-direction: column;
        align-items: left;
    }

    label {
        font-weight: bold;
        margin-bottom: 10px;
    }

    select{
        padding: 15px;
        border: 1px solid #ccc;
        border-radius: 5px;
        margin-bottom: 20px;
        width: 107.5%;
    }

    input,        
    textarea {
        padding: 15px;
        border: 1px solid #ccc;
        border-radius: 5px;
        margin-bottom: 20px;
        width: 100%;
    }

    button {
        padding: 15px 30px;
        background-color: #007bff;
        color: #fff;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        transition: background-color 0.3s ease;
    }

    button[type="submit"]:hover {
        background-color: #0056b3;
    }

    button[type="button"] {
        background-color: #ccc;
        margin-top: 10px;
    }

    button[type="button"]:hover {
        background-color: #aaa;
    }
</style>

</html>

