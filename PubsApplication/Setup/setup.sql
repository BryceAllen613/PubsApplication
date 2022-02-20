USE pubs
GO

-- create a view that joins together the auhtors table
-- and the titles table via the titleauthor table.
-- this will make it easy to look up authors and their
-- titles for the pubs application
CREATE VIEW vAuthorTitles AS
SELECT a.au_fname,
		a.au_lname,
		t.title
FROM authors AS a
	JOIN titleauthor AS ta
		ON a.au_id = ta.au_id
	JOIN titles AS t
		ON t.title_id = ta.title_id
GO

-- create a stored procedure that will
-- update an auhtor's address info
CREATE PROCEDURE proc_ainfo
@author_id VARCHAR(11),
@new_addr VARCHAR(40),
@new_city VARCHAR(20),
@new_state CHAR(2),
@new_zip CHAR(5)
AS
UPDATE authors
SET address = @new_addr,
	city = @new_city,
	state = @new_state,
	zip = @new_zip
WHERE @author_id = au_id
GO

