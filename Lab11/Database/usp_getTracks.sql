--EXECUTE usp_GetTracks 'BAL%'
GO
CREATE PROCEDURE usp_GetTracks
(
	@trackName NVARCHAR(100)
)
AS
BEGIN
SELECT        
	C.TrackId, C.Name AS TrackName, 
	C.AlbumId, A.Title, 
	A.ArtistId, B.Name AS ArtistName, 
	C.MediaTypeId, D.Name AS MediaTypeName, 
	C.Composer, C.Milliseconds, 
    C.Bytes, C.UnitPrice
FROM    dbo.Album AS A INNER JOIN
	dbo.Artist AS B ON A.ArtistId = B.ArtistId INNER JOIN
	dbo.Track AS C ON A.AlbumId = C.AlbumId INNER JOIN
	dbo.MediaType AS D ON C.MediaTypeId = D.MediaTypeId
WHERE @trackName IS NULL OR C.Name LIKE @trackName
END