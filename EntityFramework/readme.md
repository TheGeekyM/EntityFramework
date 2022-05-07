#To add migration file 
add-migration <migration name>

#To update database
database update

#To rollback migration to specific version
database update -migartion:<version-number> -> database update -migartion:<0> // will rollback to be empty database 
or
database update <migration-name> //it will retirive all migrationd to <migration-name>

#Exclude Entity to be a table in db

`
//as a data annotation on  Navigation Property for example

[NotMapped]
public List<Post> Posts { get; set; } = null!; // Navigation Property
`

`
//or as a fluent api modelBuilder.Ignore<Post>()
`

# TO change table name 
1- from DbSet<>
2- [Table("Posts")] //data annotaion above the class
3- modelBuilde.Entity<Post>.ToTable("Posts"); // fluent api in our db context

# TO change schema name of table
1- [Table("Posts", Schema="blogging")] //data annotaion above the class
2- modelBuilde.Entity<Post>.ToTable("Posts", Schema: "blogging"); // fluent api in our db context

# TO change schema name to all tables
modelBuilde.HasDefaultShema("blogging"); // fluent api in our db context
