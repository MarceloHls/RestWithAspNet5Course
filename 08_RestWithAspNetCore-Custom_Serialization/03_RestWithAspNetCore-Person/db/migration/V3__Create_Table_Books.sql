CREATE TABLE IF NOT EXISTS books(
    id bigint NOT NULL AUTO_INCREMENT,
    title varchar(250) NOT NULL,
    autor varchar(250) NOT NULL,
    year varchar(10) NOT NULL,
    PRIMARY KEY (id)
)