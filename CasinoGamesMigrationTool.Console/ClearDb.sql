BEGIN TRAN

EXEC sys.sp_MSforeachtable 'ALTER TABLE ? NOCHECK CONSTRAINT all'
EXEC sys.sp_msforeachtable 'delete from ?'

ROLLBACK TRAN