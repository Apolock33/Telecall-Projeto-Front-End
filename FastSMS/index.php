<?php

    $template = file_get_contents('views/Registration/register.php');
    
    require_once 'config.php';
    
    $action = isset($_GET['action']) ? $_GET['action'] : 'register';

    if ($action === 'register') {
        require_once 'controllers/UserController.php';
        $controller = new UserController($conexao); // Passando a conexão $conexao
        $controller->register();
    } elseif ($action === 'search') {

    }

?>

