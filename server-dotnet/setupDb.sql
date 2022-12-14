-- Active: 1665080377241@@annikadev.com@3306@longform
CREATE TABLE IF NOT EXISTS accounts(
  id VARCHAR(255) NOT NULL PRIMARY KEY,
  email VARCHAR(255) NOT NULL,
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

CREATE TABLE IF NOT EXISTS publications(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  title VARCHAR(255) NOT NULL,
  coverImgId INT,
  description VARCHAR(4095)
) DEFAULT CHARSET utf8;

CREATE TABLE IF NOT EXISTS publicationAuthors(
  id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
  authorId VARCHAR(255) NOT NULL,
  publicationId INT NOT NULL,
  isOwner BOOL NOT NULL
) DEFAULT CHARSET utf8;

CREATE TABLE IF NOT EXISTS tags(
  articleId INT NOT NULL,
  tag VARCHAR(255) NOT NULL COMMENT 'name of tag'
) DEFAULT CHARSET UTF8;

CREATE TABLE IF NOT EXISTS subscriptions(
  readerId VARCHAR(255) NOT NULL,
  authorId VARCHAR(255),
  publicationId INT,
  tag VARCHAR(255)
) DEFAULT CHARSET utf8;

CREATE TABLE IF NOT EXISTS blacklists(
  readerId VARCHAR(255) NOT NULL,
  reported BOOL DEFAULT 0,
  authorId VARCHAR(255),
  publicationId INT,
  tag VARCHAR(255)
) DEFAULT CHARSET utf8;