﻿
SELECT *
FROM [dbo].[DocmahPages]
WHERE ISNULL(@parentId, -1) = ISNULL([ParentPageId], -1)
ORDER BY [Order]
