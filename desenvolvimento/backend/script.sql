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

CREATE TABLE `tb_agendamento` (
 `id_agendamento` INT NOT NULL AUTO_INCREMENT,
 `id_carro` INT NOT NULL,
 `id_cliente` INT NOT NULL,
 `id_funcionario` INT NULL,
 `dt_agendamento` DATE NOT NULL,
 `hr_inicio` TIME NOT NULL,
 `hr_fim` TIME NOT NULL,
 `ds_status` VARCHAR(50) NULL DEFAULT 'Aguardando Comfirmação',
 `ds_agendamento` VARCHAR(200) NULL,
 PRIMARY KEY (`id_agendamento`),
 INDEX `id_carro_idx` (`id_carro` ASC) VISIBLE,
 CONSTRAINT `id_carro`
 FOREIGN KEY (`id_carro`)
 REFERENCES `tb_carro` (`id_carro`)
 ON DELETE NO ACTION
 ON UPDATE NO ACTION)
ENGINE = InnoDB;

/*dotnet ef dbcontext scaffold "server=localhost;user id=root;password=1234;database=teste_drive" Pomelo.EntityFrameworkCore.MySql -o Models --data-annotations --force*/