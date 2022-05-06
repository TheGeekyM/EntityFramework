#To add migration file 
add-migration <migration name>

#To update database
database update

#To rollback migration to specific version
database update -migartion:<version-number> -> database update -migartion:<0> // will rollback to be empty database 
or
database update <migration-name> //it will retirive all migrationd to <migration-name>