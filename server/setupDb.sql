-- Active: 1665080377241@@annikadev.com@3306@longform
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY,
  name VARCHAR(255) NOT NULL,
  bio VARCHAR(4095),
  profileImgId INT
) DEFAULT CHARSET utf8;

CREATE TABLE IF NOT EXISTS articles(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  datePublished DATE DEFAULT CURRENT_TIMESTAMP COMMENT 'date of initial publication',
  dateRevised DATE DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'date of last revision',
  authorId VARCHAR(255) NOT NULL,
  publicationId INT,
  coverImgId INT DEFAULT 0,
  body VARCHAR(65535) COMMENT 'content of article in markdown'
) DEFAULT CHARSET utf8;