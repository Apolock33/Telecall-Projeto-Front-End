<?php
require_once 'models/UserModel.php';

class UserController {
    private $db;

    public function __construct($conexao) {
        $this->db = $conexao;
    }

    public function register() {
        if (isset($_POST['submit'])) {
            $userModel = new UserModel();
            $userModel->insert($this->db, $_POST); // Passando a conexão $this->db e os dados $_POST
        }
        include 'views/Registration/register.php';
    }

    public function login() {
        if (isset($_POST['submit'])) {
            $userModel = new UserModel();
            $userModel->insert($this->db, $_POST); // Passando a conexão $this->db e os dados $_POST
        }
        include 'views/Registration/register.php';
    }
}
?>
