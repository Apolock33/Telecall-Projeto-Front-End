<?php
require_once('config.php');

$connection = new Config();
$connection->config();

$action = isset($_GET['action']) ? $_GET['action'] : null;
