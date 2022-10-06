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
  datePublished DATETIME DEFAULT CURRENT_TIMESTAMP COMMENT 'date of initial publication',
  dateRevised DATETIME DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP COMMENT 'date of last revision',
  authorId VARCHAR(255) NOT NULL,
  publicationId INT,
  coverImgId INT DEFAULT 0,
  body TEXT COMMENT 'content of article in markdown'
) DEFAULT CHARSET utf8;

CREATE TABLE IF NOT EXISTS images(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  ownerId VARCHAR(255),
  title VARCHAR(255),
  protected BOOL DEFAULT 0,
  url VARCHAR(255) COMMENT 'temporary until blobs are implemented'
) DEFAULT CHARSET utf8;