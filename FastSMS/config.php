<?php
//Variáveis de conexão
$dbHost = 'localhost:3307';
$dbUsername = 'root';
$dbPassword = 'Bio6971@@';
$dbName = 'projetofrontendunisuam';

$conexao = new mysqli($dbHost, $dbUsername, $dbPassword, $dbName);

if ($conexao->connect_errno) {
    echo "Erro de conexão com o banco de dados: " . $conexao->connect_error;
    exit();
}

?>
