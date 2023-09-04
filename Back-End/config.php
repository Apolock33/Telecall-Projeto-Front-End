<?php
class Config
{
    public function config()
    {
        $server = 'localhost:3307';
        $user = 'root';
        $password = 'Bio6971@@';
        $db = 'unisuam';

        $mysqli = new mysqli($server, $user, $password, $db);

        if ($mysqli->connect_errno) {
            exit("Erro: Não foi possível conectar com o Banco de Dados!");
        }

        return $mysqli;
    }
}
