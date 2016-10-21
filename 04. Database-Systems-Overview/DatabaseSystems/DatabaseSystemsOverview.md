# Database systems

### 1. Database models
 * *__Hierarchical (tree):__* A hierarchical database model is a data model in which the data is organized into a tree-like structure. The data is stored as records which are connected to one another through links. A record is a collection of fields, with each field containing only one value. The entity type of a record defines which fields the record contains. A record in the hierarchical database model corresponds to a row (or tuple) in the relational database model and an entity type corresponds to a table (or relation). The hierarchical database model mandates that each child record has only one parent, whereas each parent record can have one or more child records.
 * *__Network / graph:__* The network model is a database model conceived as a flexible way of representing objects and their relationships. Its distinguishing feature is that the schema, viewed as a graph in which object types are nodes and relationship types are arcs, is not restricted to being a hierarchy or lattice.
 * *__Relational (table):__* The relational model is a mathematical model defined in terms of predicate logic and set theory, and systems implementing it have been used by mainframe, midrange and microcomputer systems. Three key terms are used extensively in relational database models: relations, attributes, and domains. A relation is a table with columns and rows. The named columns of the relation are called attributes, and the domain is the set of values the attributes are allowed to take.
 * *__Object-oriented:__* In the 1990s, the object-oriented programming paradigm was applied to database technology, creating a new database model known as object databases. This aims to avoid the object-relational impedance mismatch - the overhead of converting information between its representation in the database (for example as rows in tables) and its representation in the application program (typically as objects). Even further, the type system used in a particular application can be defined directly in the database, allowing the database to enforce the same data integrity invariants. Object databases also introduce the key ideas of object programming, such as encapsulation and polymorphism, into the world of databases.
 
 ### 2. RDBMS
RDBMS stands for Relational Database Management System. It organizes data into related rows and columns.
##### Features
* It stores data in tables.
* Tables have rows and column. 
* These tables are created using SQL. 
* And data from these tables are also retrieved using SQL
* Provides facility primary key to uniquely identify the rows
* Sharing a common column in two or more tables (primary and foreign key)

### 3. Database table
A table is a collection of related data held in a structured format within a database. It consists of fields (columns), and rows.

In relational databases and flat file databases, a table is a set of data elements (values) using a model of vertical columns (identifiable by name) and horizontal rows, the cell being the unit where a row and column intersect.

A table has a specified number of columns, but can have any number of rows. Each row is identified by one or more values appearing in a particular column subset. The columns subset which uniquely identifies a row is called the primary key.

### 4. Primary vs. Foreign key
Primary keys and foreign keys are two types of constraints that can be used to enforce data integrity in SQL Server tables.
* *__Primary Key:__* A table typically has a column or combination of columns that contain values that uniquely identify each row in the table. This column, or columns, is called the primary key (PK) of the table and enforces the entity integrity of the table. Because primary key constraints guarantee unique data, they are frequently defined on an identity column. PKs don't allow Null or duplicate values.
* *__Foreign Key:__* A foreign key (FK) is a column or combination of columns that is used to establish and enforce a link between the data in two tables to control the data that can be stored in the foreign key table. In a foreign key reference, a link is created between two tables when the column or columns that hold the primary key value for one table are referenced by the column or columns in another table. This column becomes a foreign key in the second table. It allows Null or duplicate values.

### 5. Types of relationships between tables
A relationship works by matching data in key columns — usually columns with the same name in both tables. In most cases, the relationship matches the primary key from one table, which provides a unique identifier for each row, with an entry in the foreign key in the other table. For example, book sales can be associated with the specific titles sold by creating a relationship between the title_id column in the titles table (the primary key) and the title_id column in the sales table (the foreign key).
* *__One-to-Many Relationship:__* A one-to-many relationship is the most common type of relationship. In this type of relationship, a row in table A can have many matching rows in table B, but a row in table B can have only one matching row in table A. For example, the publishers and titles tables have a one-to-many relationship: each publisher produces many titles, but each title comes from only one publisher.
* *__Many-to-Many Relationships:__* In a many-to-many relationship, a row in table A can have many matching rows in table B, and vice versa. You create such a relationship by defining a third table, called a junction table, whose primary key consists of the foreign keys from both table A and table B. For example, the authors table and the titles table have a many-to-many relationship that is defined by a one-to-many relationship from each of these tables to the titleauthors table. The primary key of the titleauthors table is the combination of the au_id column (the authors table's primary key) and the title_id column (the titles table's primary key).
* *__One-to-One Relationships:__* In a one-to-one relationship, a row in table A can have no more than one matching row in table B, and vice versa. A one-to-one relationship is created if both of the related columns are primary keys or have unique constraints.
This type of relationship is not common because most information related in this way would be all in one table. You might use a one-to-one relationship to:
  * Divide a table with many columns.
  * Isolate part of a table for security reasons.
  * Store data that is short-lived and could be easily deleted by simply deleting the table.
  * Store information that applies only to a subset of the main table.