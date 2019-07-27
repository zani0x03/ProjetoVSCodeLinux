-- CREATE TABLE "setor" ----------------------------------------
CREATE TABLE `setor` ( 
	`codigo` BIGINT( 20 ) UNSIGNED AUTO_INCREMENT NOT NULL,
	`setor` VARCHAR( 45 ) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL,
	`status` TINYINT( 3 ) UNSIGNED NULL DEFAULT 1,
	`cadastro` BIGINT( 20 ) UNSIGNED NULL,
	`dataCadastro` DATETIME NULL
	PRIMARY KEY ( `codigo` ) )
CHARACTER SET = latin1
COLLATE = latin1_swedish_ci
ENGINE = INNODB
AUTO_INCREMENT = 225;
-- -------------------------------------------------------------
