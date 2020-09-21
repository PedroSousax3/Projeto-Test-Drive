DROP DATABASE `teste_drive`;
 
CREATE DATABASE `teste_drive`;

use `teste_drive`;
CREATE TABLE `tb_carro` (
 `id_carro` INT NOT NULL AUTO_INCREMENT,
 `tp_carro` VARCHAR(60) NOT NULL,
 `bt_usado` TINYINT NOT NULL,
 `nm_marca` VARCHAR(60) NOT NULL,
 `nm_modelo` VARCHAR(60) NULL,
 `dt_fabricao` DATE NULL,
 `dt_modelo` DATE NOT NULL,
 `nr_km` INT NULL,
 `ds_cor` VARCHAR(50) NULL,
 `bt_arcondicionado` TINYINT NULL,
 `ds_carro` VARCHAR(300) NULL,
 `vl_preco` DECIMAL NOT NULL,
 `dt_publicacao` DATETIME NOT NULL,
 PRIMARY KEY (`id_carro`))
ENGINE = InnoDB;

CREATE TABLE `tb_cliente` (
  `id_cliente` INT NOT NULL AUTO_INCREMENT,
  `nm_cliente` VARCHAR(150) NULL,
  `ds_cnh` VARCHAR(150) NULL,
  `ds_cpf` VARCHAR(150) NULL,
  `dt_data` DATE NULL,
  `nm_endereço` VARCHAR(150) NULL,
  `ds_rg` VARCHAR(150) NULL,
  `ds_numero` VARCHAR(150) NULL,
  PRIMARY KEY (`id_cliente`))
ENGINE = InnoDB;

CREATE TABLE `tb_funcionario` (
  `id_funcionario` INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  `nm_funcionario` INT NULL,
  `ds_cnh` VARCHAR(30) NULL,
  `ds_cpf` VARCHAR(30) NULL,
  `dt_nascimento` DATE NULL,
  `nm_endereço` VARCHAR(100) NULL,
  `ds_rg` VARCHAR(45) NULL,
  `ds_numero` VARCHAR(45) NULL,
  `nm_cargo` VARCHAR(45) NULL
);

CREATE TABLE `tb_agendamento` (
  `id_agendamento` INT NOT NULL AUTO_INCREMENT,
  `id_carro` INT NOT NULL,
  `id_cliente` INT NOT NULL,
  `id_funcionario` INT NOT NULL,
  `dt_agendamento` DATE NOT NULL,
  `hr_inicio` TIME NOT NULL,
  `hr_fim` TIME NOT NULL,
  `ds_status` VARCHAR(50) NULL DEFAULT 'Aguardando Comfirmação',
  `ds_agendamento` VARCHAR(200) NULL,
  PRIMARY KEY (`id_agendamento`),
  INDEX `id_carro_idx` (`id_carro` ASC) VISIBLE,
  INDEX `id_cliente_idx` (`id_cliente` ASC) VISIBLE,
  INDEX `id_funcionari_idx` (`id_funcionario` ASC) VISIBLE,
	CONSTRAINT `id_carro`
    FOREIGN KEY (`id_carro`)
    REFERENCES `teste_drive`.`tb_carro` (`id_carro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
	 CONSTRAINT `id_cliente`
    FOREIGN KEY (`id_cliente`)
    REFERENCES `teste_drive`.`tb_cliente` (`id_cliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
	CONSTRAINT `id_funcionario`
    FOREIGN KEY (`id_funcionario`)
    REFERENCES `teste_drive`.`tb_funcionario` (`id_funcionario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE `teste_drive`.`tb_login` (
  `id_login` INT NOT NULL AUTO_INCREMENT,
  `id_funcionario` INT NOT NULL,
  `id_cliente` INT NOT NULL,
  `ds_email` VARCHAR(150) NULL,
  `ds_senha` VARCHAR(150) NULL,
  PRIMARY KEY (`id_login`), 
  FOREIGN KEY (`id_cliente`) REFERENCES `teste_drive`.`tb_cliente` (`id_cliente`),
  FOREIGN KEY (`id_funcionario`) REFERENCES `teste_drive`.`tb_funcionario` (`id_funcionario`));

/*dotnet ef dbcontext scaffold "server=localhost;user id=root;password=1234;database=teste_drive" Pomelo.EntityFrameworkCore.MySql -o Models --data-annotations --force*/