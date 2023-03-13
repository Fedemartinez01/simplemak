use SystemERP_DB

--Datos de DocumentNumber pasan a Comments
UPDATE Clients SET Comments = DocumentNumber
UPDATE Clients SET DocumentNumber = null

--Asignamos CUITS genéricos de AFIP
UPDATE Clients SET DocumentNumber = '50-00000401-1'
where CountryId = 56
UPDATE Clients SET DocumentNumber = '50-00000200-0'
where CountryId = 61
UPDATE Clients SET DocumentNumber = '50-00000004-0'
where CountryId = 63
UPDATE Clients SET DocumentNumber = '50-00000005-9'
where CountryId = 64
UPDATE Clients SET DocumentNumber = '50-00000205-1'
where CountryId = 66
UPDATE Clients SET DocumentNumber = '50-00000158-6'
where CountryId = 67
UPDATE Clients SET DocumentNumber = '50-00000003-2'
where CountryId = 69
UPDATE Clients SET DocumentNumber = '50-00000242-6'
where CountryId = 71
UPDATE Clients SET DocumentNumber = '50-00000218-3'
where CountryId = 79
UPDATE Clients SET DocumentNumber = '50-00000002-4'
where CountryId = 82
UPDATE Clients SET DocumentNumber = '50-00000222-1'
where CountryId = 83
UPDATE Clients SET DocumentNumber = '50-00000401-1'
where CountryId = 190
UPDATE Clients SET DocumentNumber = '50-00000410-0'
where CountryId = 199
UPDATE Clients SET DocumentNumber = '50-00000424-0'
where CountryId = 213
