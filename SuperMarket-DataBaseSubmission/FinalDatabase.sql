/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/28/2022 11:31:37 AM                        */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ADMIN') and o.name = 'FK_ADMIN_INHERITAN_EMPLOYEE')
alter table ADMIN
   drop constraint FK_ADMIN_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('BRANCH') and o.name = 'FK_BRANCH_HAS_SUPERMAR')
alter table BRANCH
   drop constraint FK_BRANCH_HAS_SUPERMAR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CASHIER') and o.name = 'FK_CASHIER_INHERITAN_EMPLOYEE')
alter table CASHIER
   drop constraint FK_CASHIER_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('CLEANING_STAFF') and o.name = 'FK_CLEANING_INHERITAN_EMPLOYEE')
alter table CLEANING_STAFF
   drop constraint FK_CLEANING_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"CONTAINS"') and o.name = 'FK_CONTAINS_CONTAINS_INVENTOR')
alter table "CONTAINS"
   drop constraint FK_CONTAINS_CONTAINS_INVENTOR
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"CONTAINS"') and o.name = 'FK_CONTAINS_CONTAINS2_PRODUCT')
alter table "CONTAINS"
   drop constraint FK_CONTAINS_CONTAINS2_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEAL_WITH') and o.name = 'FK_DEAL_WIT_DEAL_WITH_CUSTOMER')
alter table DEAL_WITH
   drop constraint FK_DEAL_WIT_DEAL_WITH_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DEAL_WITH') and o.name = 'FK_DEAL_WIT_DEAL_WITH_EMPLOYEE')
alter table DEAL_WITH
   drop constraint FK_DEAL_WIT_DEAL_WITH_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('DELIVERY') and o.name = 'FK_DELIVERY_INHERITAN_EMPLOYEE')
alter table DELIVERY
   drop constraint FK_DELIVERY_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ELECTRONIC_STAFF') and o.name = 'FK_ELECTRON_INHERITAN_EMPLOYEE')
alter table ELECTRONIC_STAFF
   drop constraint FK_ELECTRON_INHERITAN_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_MANAGES_EMPLOYEE')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_MANAGES_EMPLOYEE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('EMPLOYEE') and o.name = 'FK_EMPLOYEE_WORKS_FOR_SECTION')
alter table EMPLOYEE
   drop constraint FK_EMPLOYEE_WORKS_FOR_SECTION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"ORDER"') and o.name = 'FK_ORDER_R1_CUSTOMER')
alter table "ORDER"
   drop constraint FK_ORDER_R1_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('"ORDER"') and o.name = 'FK_ORDER_R2_PRODUCT')
alter table "ORDER"
   drop constraint FK_ORDER_R2_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_CONSISTS__PRODUCT_')
alter table PRODUCT
   drop constraint FK_PRODUCT_CONSISTS__PRODUCT_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT_GROUP') and o.name = 'FK_PRODUCT__HOLDS_SECTION')
alter table PRODUCT_GROUP
   drop constraint FK_PRODUCT__HOLDS_SECTION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SECTION') and o.name = 'FK_SECTION_CONSIST_O_BRANCH')
alter table SECTION
   drop constraint FK_SECTION_CONSIST_O_BRANCH
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SECTION_LOCATION') and o.name = 'FK_SECTION__OWNS_SECTION')
alter table SECTION_LOCATION
   drop constraint FK_SECTION__OWNS_SECTION
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUPPLIES') and o.name = 'FK_SUPPLIES_SUPPLIES_SUPPLIER')
alter table SUPPLIES
   drop constraint FK_SUPPLIES_SUPPLIES_SUPPLIER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('SUPPLIES') and o.name = 'FK_SUPPLIES_SUPPLIES2_PRODUCT')
alter table SUPPLIES
   drop constraint FK_SUPPLIES_SUPPLIES2_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VISIT') and o.name = 'FK_VISIT_VISIT_CUSTOMER')
alter table VISIT
   drop constraint FK_VISIT_VISIT_CUSTOMER
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('VISIT') and o.name = 'FK_VISIT_VISIT2_BRANCH')
alter table VISIT
   drop constraint FK_VISIT_VISIT2_BRANCH
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('ADMIN')
            and   name  = 'INHERITANCE_5_FK'
            and   indid > 0
            and   indid < 255)
   drop index ADMIN.INHERITANCE_5_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ADMIN')
            and   type = 'U')
   drop table ADMIN
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('BRANCH')
            and   name  = 'HAS_FK'
            and   indid > 0
            and   indid < 255)
   drop index BRANCH.HAS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('BRANCH')
            and   type = 'U')
   drop table BRANCH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CASHIER')
            and   type = 'U')
   drop table CASHIER
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CLEANING_STAFF')
            and   type = 'U')
   drop table CLEANING_STAFF
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"CONTAINS"')
            and   name  = 'CONTAINS2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "CONTAINS".CONTAINS2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"CONTAINS"')
            and   name  = 'CONTAINS_FK'
            and   indid > 0
            and   indid < 255)
   drop index "CONTAINS".CONTAINS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"CONTAINS"')
            and   type = 'U')
   drop table "CONTAINS"
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CUSTOMER')
            and   type = 'U')
   drop table CUSTOMER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEAL_WITH')
            and   name  = 'DEAL_WITH2_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEAL_WITH.DEAL_WITH2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('DEAL_WITH')
            and   name  = 'DEAL_WITH_FK'
            and   indid > 0
            and   indid < 255)
   drop index DEAL_WITH.DEAL_WITH_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DEAL_WITH')
            and   type = 'U')
   drop table DEAL_WITH
go

if exists (select 1
            from  sysobjects
           where  id = object_id('DELIVERY')
            and   type = 'U')
   drop table DELIVERY
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ELECTRONIC_STAFF')
            and   type = 'U')
   drop table ELECTRONIC_STAFF
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'MANAGES_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.MANAGES_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('EMPLOYEE')
            and   name  = 'WORKS_FOR_FK'
            and   indid > 0
            and   indid < 255)
   drop index EMPLOYEE.WORKS_FOR_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('EMPLOYEE')
            and   type = 'U')
   drop table EMPLOYEE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('INVENTORY')
            and   type = 'U')
   drop table INVENTORY
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"ORDER"')
            and   name  = 'R2_FK'
            and   indid > 0
            and   indid < 255)
   drop index "ORDER".R2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('"ORDER"')
            and   name  = 'R1_FK'
            and   indid > 0
            and   indid < 255)
   drop index "ORDER".R1_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('"ORDER"')
            and   type = 'U')
   drop table "ORDER"
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'CONSISTS_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.CONSISTS_OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT')
            and   type = 'U')
   drop table PRODUCT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT_GROUP')
            and   name  = 'HOLDS_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT_GROUP.HOLDS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT_GROUP')
            and   type = 'U')
   drop table PRODUCT_GROUP
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SECTION')
            and   name  = 'CONSIST_OF_FK'
            and   indid > 0
            and   indid < 255)
   drop index SECTION.CONSIST_OF_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SECTION')
            and   type = 'U')
   drop table SECTION
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SECTION_LOCATION')
            and   name  = 'OWNS_FK'
            and   indid > 0
            and   indid < 255)
   drop index SECTION_LOCATION.OWNS_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SECTION_LOCATION')
            and   type = 'U')
   drop table SECTION_LOCATION
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPERMARKET')
            and   type = 'U')
   drop table SUPERMARKET
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIER')
            and   type = 'U')
   drop table SUPPLIER
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUPPLIES')
            and   name  = 'SUPPLIES2_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUPPLIES.SUPPLIES2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('SUPPLIES')
            and   name  = 'SUPPLIES_FK'
            and   indid > 0
            and   indid < 255)
   drop index SUPPLIES.SUPPLIES_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('SUPPLIES')
            and   type = 'U')
   drop table SUPPLIES
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VISIT')
            and   name  = 'VISIT2_FK'
            and   indid > 0
            and   indid < 255)
   drop index VISIT.VISIT2_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('VISIT')
            and   name  = 'VISIT_FK'
            and   indid > 0
            and   indid < 255)
   drop index VISIT.VISIT_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('VISIT')
            and   type = 'U')
   drop table VISIT
go

/*==============================================================*/
/* Table: ADMIN                                                 */
/*==============================================================*/
create table ADMIN (
   ENUM                 int                  identity,
   ADMINPASS            varchar(10)          not null,
   USERNAME             varchar(15)          not null,
   constraint PK_ADMIN primary key (ENUM, ADMINPASS)
)
go

/*==============================================================*/
/* Index: INHERITANCE_5_FK                                      */
/*==============================================================*/




create nonclustered index INHERITANCE_5_FK on ADMIN (ENUM ASC)
go

/*==============================================================*/
/* Table: BRANCH                                                */
/*==============================================================*/
create table BRANCH (
   ADDRESS              varchar(100)         not null,
   BRANCH_ID            int                  identity,
   SMNAME               varchar(10)          not null,
   constraint PK_BRANCH primary key (BRANCH_ID)
)
go

/*==============================================================*/
/* Index: HAS_FK                                                */
/*==============================================================*/




create nonclustered index HAS_FK on BRANCH (SMNAME ASC)
go

/*==============================================================*/
/* Table: CASHIER                                               */
/*==============================================================*/
create table CASHIER (
   ENUM                 int                  not null,
   constraint PK_CASHIER primary key (ENUM)
)
go

/*==============================================================*/
/* Table: CLEANING_STAFF                                        */
/*==============================================================*/
create table CLEANING_STAFF (
   ENUM                 int                  not null,
   constraint PK_CLEANING_STAFF primary key (ENUM)
)
go

/*==============================================================*/
/* Table: "CONTAINS"                                            */
/*==============================================================*/
create table "CONTAINS" (
   INV_ID               int                  not null,
   PRODUCT_ID           int                  not null,
   constraint PK_CONTAINS primary key (INV_ID, PRODUCT_ID)
)
go

/*==============================================================*/
/* Index: CONTAINS_FK                                           */
/*==============================================================*/




create nonclustered index CONTAINS_FK on "CONTAINS" (INV_ID ASC)
go

/*==============================================================*/
/* Index: CONTAINS2_FK                                          */
/*==============================================================*/




create nonclustered index CONTAINS2_FK on "CONTAINS" (PRODUCT_ID ASC)
go

/*==============================================================*/
/* Table: CUSTOMER                                              */
/*==============================================================*/
create table CUSTOMER (
   CUSTOMER_ID          int                  identity,
   FNAME                char(10)             not null,
   LNAME                char(10)             not null,
   C_ADDRESS            varchar(100)         not null,
   USERNAME             varchar(15)          not null,
   PASSWORD             char(8)              not null,
   DISCOUNT             float                null,
   constraint PK_CUSTOMER primary key (CUSTOMER_ID, PASSWORD)
)
go

/*==============================================================*/
/* Table: DEAL_WITH                                             */
/*==============================================================*/
create table DEAL_WITH (
   CUSTOMER_ID          int                  not null,
   PASSWORD             char(8)              not null,
   ENUM                 int                  not null,
   constraint PK_DEAL_WITH primary key (CUSTOMER_ID, PASSWORD, ENUM)
)
go

/*==============================================================*/
/* Index: DEAL_WITH_FK                                          */
/*==============================================================*/




create nonclustered index DEAL_WITH_FK on DEAL_WITH (CUSTOMER_ID ASC,
  PASSWORD ASC)
go

/*==============================================================*/
/* Index: DEAL_WITH2_FK                                         */
/*==============================================================*/




create nonclustered index DEAL_WITH2_FK on DEAL_WITH (ENUM ASC)
go

/*==============================================================*/
/* Table: DELIVERY                                              */
/*==============================================================*/
create table DELIVERY (
   ENUM                 int                  not null,
   constraint PK_DELIVERY primary key (ENUM)
)
go

/*==============================================================*/
/* Table: ELECTRONIC_STAFF                                      */
/*==============================================================*/
create table ELECTRONIC_STAFF (
   ENUM                 int                  not null,
   constraint PK_ELECTRONIC_STAFF primary key (ENUM)
)
go

/*==============================================================*/
/* Table: EMPLOYEE                                              */
/*==============================================================*/
create table EMPLOYEE (
   ENUM                 int                  identity,
   EMP_ENUM             int                  null,
   SECTION_ID           int                  not null,
   ENAME                varchar(10)          not null,
   LNAME                char(10)             not null,
   PHONE                varchar(11)          not null,
   PNUM                 int                  not null,
   SALARY               float                not null,
   GENDER               varchar(6)           not null,
   DOB                  datetime             not null,
   AGE                  int                  not null,
   DATE_HIRED           datetime             not null,
   constraint PK_EMPLOYEE primary key (ENUM)
)
go

/*==============================================================*/
/* Index: WORKS_FOR_FK                                          */
/*==============================================================*/




create nonclustered index WORKS_FOR_FK on EMPLOYEE (SECTION_ID ASC)
go

/*==============================================================*/
/* Index: MANAGES_FK                                            */
/*==============================================================*/




create nonclustered index MANAGES_FK on EMPLOYEE (EMP_ENUM ASC)
go

/*==============================================================*/
/* Table: INVENTORY                                             */
/*==============================================================*/
create table INVENTORY (
   INV_ID               int                  not null,
   constraint PK_INVENTORY primary key (INV_ID)
)
go

/*==============================================================*/
/* Table: "ORDER"                                               */
/*==============================================================*/
create table "ORDER" (
   CUSTOMER_ID          int                  not null,
   PASSWORD             char(8)              not null,
   PRODUCT_ID           int                  not null,
   ORDER_ID2            int                  identity,
   ORDER_DATE           datetime             not null,
   PURCHASING           float                not null,
   constraint PK_ORDER primary key (CUSTOMER_ID, PASSWORD, PRODUCT_ID, ORDER_ID2)
)
go

/*==============================================================*/
/* Index: R1_FK                                                 */
/*==============================================================*/




create nonclustered index R1_FK on "ORDER" (CUSTOMER_ID ASC,
  PASSWORD ASC)
go

/*==============================================================*/
/* Index: R2_FK                                                 */
/*==============================================================*/




create nonclustered index R2_FK on "ORDER" (PRODUCT_ID ASC)
go

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT (
   PRODUCT_ID           int                  identity,
   PG_ID                int                  null,
   PNAME                varchar(20)          not null,
   STANDARD_PRICE       float                not null,
   QUANTITY             int                  not null,
   PRODUCT_DESCRIPTION  varchar(100)         not null,
   constraint PK_PRODUCT primary key (PRODUCT_ID)
)
go

/*==============================================================*/
/* Index: CONSISTS_OF_FK                                        */
/*==============================================================*/




create nonclustered index CONSISTS_OF_FK on PRODUCT (PG_ID ASC)
go

/*==============================================================*/
/* Table: PRODUCT_GROUP                                         */
/*==============================================================*/
create table PRODUCT_GROUP (
   PG_ID                int                  identity,
   SECTION_ID           int                  not null,
   PG_NAME              varchar(10)          not null,
   NUMBER_PURCHASED     int                  not null,
   constraint PK_PRODUCT_GROUP primary key (PG_ID)
)
go

/*==============================================================*/
/* Index: HOLDS_FK                                              */
/*==============================================================*/




create nonclustered index HOLDS_FK on PRODUCT_GROUP (SECTION_ID ASC)
go

/*==============================================================*/
/* Table: SECTION                                               */
/*==============================================================*/
create table SECTION (
   SECTION_ID           int                  identity,
   BRANCH_ID            int                  not null,
   SNAME                char(10)             not null,
   P_PRICE              int                  not null,
   constraint PK_SECTION primary key (SECTION_ID)
)
go

/*==============================================================*/
/* Index: CONSIST_OF_FK                                         */
/*==============================================================*/




create nonclustered index CONSIST_OF_FK on SECTION (BRANCH_ID ASC)
go

/*==============================================================*/
/* Table: SECTION_LOCATION                                      */
/*==============================================================*/
create table SECTION_LOCATION (
   S_LOCATION           varchar(100)         not null,
   S_LOCATION_ID        int                  not null,
   SECTION_ID           int                  not null,
   constraint PK_SECTION_LOCATION primary key (S_LOCATION_ID, S_LOCATION)
)
go

/*==============================================================*/
/* Index: OWNS_FK                                               */
/*==============================================================*/




create nonclustered index OWNS_FK on SECTION_LOCATION (SECTION_ID ASC)
go

/*==============================================================*/
/* Table: SUPERMARKET                                           */
/*==============================================================*/
create table SUPERMARKET (
   SMNAME               varchar(10)          not null,
   STOCKPRICE           float                not null,
   ADDRESS              varchar(100)         not null,
   SM_CITY              varchar(15)          not null,
   constraint PK_SUPERMARKET primary key (SMNAME)
)
go

/*==============================================================*/
/* Table: SUPPLIER                                              */
/*==============================================================*/
create table SUPPLIER (
   SID                  int                  identity,
   SP_NAME              varchar(20)          not null,
   SM_CITY              varchar(15)          not null,
   ADDRESS              varchar(100)         not null,
   constraint PK_SUPPLIER primary key (SID)
)
go

/*==============================================================*/
/* Table: SUPPLIES                                              */
/*==============================================================*/
create table SUPPLIES (
   SID                  int                  not null,
   PRODUCT_ID           int                  not null,
   constraint PK_SUPPLIES primary key (SID, PRODUCT_ID)
)
go

/*==============================================================*/
/* Index: SUPPLIES_FK                                           */
/*==============================================================*/




create nonclustered index SUPPLIES_FK on SUPPLIES (SID ASC)
go

/*==============================================================*/
/* Index: SUPPLIES2_FK                                          */
/*==============================================================*/




create nonclustered index SUPPLIES2_FK on SUPPLIES (PRODUCT_ID ASC)
go

/*==============================================================*/
/* Table: VISIT                                                 */
/*==============================================================*/
create table VISIT (
   CUSTOMER_ID          int                  not null,
   PASSWORD             char(8)              not null,
   BRANCH_ID            int                  not null,
   constraint PK_VISIT primary key (CUSTOMER_ID, PASSWORD, BRANCH_ID)
)
go

/*==============================================================*/
/* Index: VISIT_FK                                              */
/*==============================================================*/




create nonclustered index VISIT_FK on VISIT (CUSTOMER_ID ASC,
  PASSWORD ASC)
go

/*==============================================================*/
/* Index: VISIT2_FK                                             */
/*==============================================================*/




create nonclustered index VISIT2_FK on VISIT (BRANCH_ID ASC)
go

alter table ADMIN
   add constraint FK_ADMIN_INHERITAN_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
go

alter table BRANCH
   add constraint FK_BRANCH_HAS_SUPERMAR foreign key (SMNAME)
      references SUPERMARKET (SMNAME)
         on update cascade on delete cascade
go

alter table CASHIER
   add constraint FK_CASHIER_INHERITAN_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
go

alter table CLEANING_STAFF
   add constraint FK_CLEANING_INHERITAN_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
go

alter table "CONTAINS"
   add constraint FK_CONTAINS_CONTAINS_INVENTOR foreign key (INV_ID)
      references INVENTORY (INV_ID)
         on update cascade on delete cascade
go

alter table "CONTAINS"
   add constraint FK_CONTAINS_CONTAINS2_PRODUCT foreign key (PRODUCT_ID)
      references PRODUCT (PRODUCT_ID)
         on update cascade on delete cascade
go

alter table DEAL_WITH
   add constraint FK_DEAL_WIT_DEAL_WITH_CUSTOMER foreign key (CUSTOMER_ID, PASSWORD)
      references CUSTOMER (CUSTOMER_ID, PASSWORD)
         on update cascade on delete cascade
go

alter table DEAL_WITH
   add constraint FK_DEAL_WIT_DEAL_WITH_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
         on update cascade on delete cascade
go

alter table DELIVERY
   add constraint FK_DELIVERY_INHERITAN_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
go

alter table ELECTRONIC_STAFF
   add constraint FK_ELECTRON_INHERITAN_EMPLOYEE foreign key (ENUM)
      references EMPLOYEE (ENUM)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_MANAGES_EMPLOYEE foreign key (EMP_ENUM)
      references EMPLOYEE (ENUM)
go

alter table EMPLOYEE
   add constraint FK_EMPLOYEE_WORKS_FOR_SECTION foreign key (SECTION_ID)
      references SECTION (SECTION_ID)
         on update cascade on delete cascade
go

alter table "ORDER"
   add constraint FK_ORDER_R1_CUSTOMER foreign key (CUSTOMER_ID, PASSWORD)
      references CUSTOMER (CUSTOMER_ID, PASSWORD)
         on update cascade on delete cascade
go

alter table "ORDER"
   add constraint FK_ORDER_R2_PRODUCT foreign key (PRODUCT_ID)
      references PRODUCT (PRODUCT_ID)
         on update cascade on delete cascade
go

alter table PRODUCT
   add constraint FK_PRODUCT_CONSISTS__PRODUCT_ foreign key (PG_ID)
      references PRODUCT_GROUP (PG_ID)
         on update cascade on delete cascade
go

alter table PRODUCT_GROUP
   add constraint FK_PRODUCT__HOLDS_SECTION foreign key (SECTION_ID)
      references SECTION (SECTION_ID)
         on update cascade on delete cascade
go

alter table SECTION
   add constraint FK_SECTION_CONSIST_O_BRANCH foreign key (BRANCH_ID)
      references BRANCH (BRANCH_ID)
         on update cascade on delete cascade
go

alter table SECTION_LOCATION
   add constraint FK_SECTION__OWNS_SECTION foreign key (SECTION_ID)
      references SECTION (SECTION_ID)
         on update cascade on delete cascade
go

alter table SUPPLIES
   add constraint FK_SUPPLIES_SUPPLIES_SUPPLIER foreign key (SID)
      references SUPPLIER (SID)
         on update cascade on delete cascade
go

alter table SUPPLIES
   add constraint FK_SUPPLIES_SUPPLIES2_PRODUCT foreign key (PRODUCT_ID)
      references PRODUCT (PRODUCT_ID)
         on update cascade on delete cascade
go

alter table VISIT
   add constraint FK_VISIT_VISIT_CUSTOMER foreign key (CUSTOMER_ID, PASSWORD)
      references CUSTOMER (CUSTOMER_ID, PASSWORD)
         on update cascade on delete cascade
go

alter table VISIT
   add constraint FK_VISIT_VISIT2_BRANCH foreign key (BRANCH_ID)
      references BRANCH (BRANCH_ID)
         on update cascade on delete cascade
go

insert into dbo.SUPERMARKET values('Carrefour',100000,'Egypt','Giza');
insert into dbo.SUPERMARKET values('Kher Zman',200000,'Egypt','Giza');
insert into dbo.SUPERMARKET values('AswakOmar',300000,'Egypt','Giza');
insert into dbo.SUPERMARKET values('Elmothda',400000,'Egypt','Giza');
insert into dbo.SUPERMARKET values('Kazyon',500000,'Egypt','Giza');

insert into dbo.BRANCH values('haram','Carrefour');
insert into dbo.BRANCH values('MidanElGiza','Kher Zman');
insert into dbo.BRANCH values('Doki','AswakOmar');
insert into dbo.BRANCH values('Imbabah','Elmothda');
insert into dbo.BRANCH values('Mohandessin','Kazyon');

insert into dbo.CUSTOMER values('Ahmed','Mohamed','haram','AhmedMohamed','12345bnm',0.3);
insert into dbo.CUSTOMER values('soha','Aly','MidanElGiza','SohaAly','45678ghj',0.1);
insert into dbo.CUSTOMER values('Aly','Medhat','Doki','AlyMedhat','85236asd',0.4);
insert into dbo.CUSTOMER values('Khaled','Omar','Imbabah','KhaledOmar','52314mkn',0.3);
insert into dbo.CUSTOMER values('Ziad','Loay','Mohandessin','ZiadLoay','45678bmk',0.2);




insert into dbo.SECTION values(1,'Food',100);
insert into dbo.SECTION values(2,'nonFood',150);
insert into dbo.SECTION values(3,'bakery',120);
insert into dbo.SECTION values(4,'dairy',130);
insert into dbo.SECTION values(5,'fruit',180);


insert into dbo.SECTION_LOCATION values('1b',1,1);
insert into dbo.SECTION_LOCATION values('2c',2,2);
insert into dbo.SECTION_LOCATION values('3n',3,3);
insert into dbo.SECTION_LOCATION values('7m',4,4);
insert into dbo.SECTION_LOCATION values('6m',5,5);


insert into dbo.SUPPLIER values('Ahmed','Giza','Haram');
insert into dbo.SUPPLIER values('Aly','Aswan','Edfo');
insert into dbo.SUPPLIER values('Kamal','Alex','Smoha');
insert into dbo.SUPPLIER values('Basel','Cairo','Elsahel');
insert into dbo.SUPPLIER values('Gamal','Luxar','Esna');


insert into dbo.EMPLOYEE values(1,1,'Ahmed','Saad','01124523674',1,2500,'Male',convert(datetime,'2000-12-24 10:34:09 AM'),30,convert(datetime,'2020-12-24 04:34:09 AM'));
insert into dbo.EMPLOYEE values(2,2,'Aly','Foad','01121254874',2,3600,'Male',convert(datetime,'1995-12-24 02:34:09 AM'),30,convert(datetime,'2022-12-24 09:34:09 AM'));
insert into dbo.EMPLOYEE values(3,3,'Soha','Emad','01124754874',3,4000,'Female',convert(datetime,'1990-12-24 02:46:09 AM'),32,convert(datetime,'2016-12-24 11:34:09 AM'));
insert into dbo.EMPLOYEE values(4,4,'Salma','Foad','01122349874',4,2440,'Female',convert(datetime,'1998-12-24 02:46:09 AM'),26,convert(datetime,'2014-12-24 05:31:09 AM'));
insert into dbo.EMPLOYEE values(5,5,'Samy','Galal','01142399874',5,6500,'Male',convert(datetime,'1996-12-24 03:34:09 AM'),29,convert(datetime,'2013-12-24 07:34:09 AM'));


insert into dbo.ELECTRONIC_STAFF values(1);
insert into dbo.ELECTRONIC_STAFF values(2);
insert into dbo.ELECTRONIC_STAFF values(3);
insert into dbo.ELECTRONIC_STAFF values(4);
insert into dbo.ELECTRONIC_STAFF values(5);


insert into dbo.DELIVERY values(1);
insert into dbo.DELIVERY values(2);
insert into dbo.DELIVERY values(3);
insert into dbo.DELIVERY values(4);
insert into dbo.DELIVERY values(5);


insert into dbo.DEAL_WITH values(1,'12345bnm',1);
insert into dbo.DEAL_WITH values(2,'45678ghj',2);
insert into dbo.DEAL_WITH values(3,'85236asd',3);
insert into dbo.DEAL_WITH values(4,'52314mkn',4);
insert into dbo.DEAL_WITH values(5,'45678bmk',5);


insert into dbo.CLEANING_STAFF values(1);
insert into dbo.CLEANING_STAFF values(2);
insert into dbo.CLEANING_STAFF values(3);
insert into dbo.CLEANING_STAFF values(4);
insert into dbo.CLEANING_STAFF values(5);


insert into dbo.CASHIER values(1);
insert into dbo.CASHIER values(2);
insert into dbo.CASHIER values(3);
insert into dbo.CASHIER values(4);
insert into dbo.CASHIER values(5);


insert into dbo.PRODUCT_GROUP values(1,'Food',500);
insert into dbo.PRODUCT_GROUP values(2,'GrassFed',200);
insert into dbo.PRODUCT_GROUP values(3,'AllNatural',320);
insert into dbo.PRODUCT_GROUP values(4,'Beauty ',420);
insert into dbo.PRODUCT_GROUP values(5,'Electric ',150);



insert into dbo.PRODUCT values(1,'Potatoes',125,25,'amazing');
insert into dbo.PRODUCT values(2,'Green pepper',56,40,'Good');
insert into dbo.PRODUCT values(3,'Green Onions',89,70,'Cool');
insert into dbo.PRODUCT values(4,'Iceberg',240,90,'Good Quality');
insert into dbo.PRODUCT values(5,'Carrots',20,600,'Healthy');



insert into dbo.INVENTORY values(1);
insert into dbo.INVENTORY values(2);
insert into dbo.INVENTORY values(3);
insert into dbo.INVENTORY values(4);
insert into dbo.INVENTORY values(5);


insert into dbo.[CONTAINS] values(2,2);
insert into dbo.[CONTAINS] values(3,3);
insert into dbo.[CONTAINS] values(4,4);
insert into dbo.[CONTAINS] values(5,5);



insert into dbo.[ORDER] values(1,'12345bnm',1,convert(datetime,'2020-03-15'),150);
insert into dbo.[ORDER] values(2,'45678ghj',2,convert(datetime,'2018-05-15'),300);
insert into dbo.[ORDER] values(3,'85236asd',3,convert(datetime,'2015-08-15'),600);
insert into dbo.[ORDER] values(4,'52314mkn',4,convert(datetime,'2014-10-15'),750);
insert into dbo.[ORDER] values(5,'45678bmk',5,convert(datetime,'2013-11-15'),1000);
insert into dbo.[ORDER] values(1,'12345bnm',5,convert(datetime,'2022-06-1'),1000);
insert into dbo.[ORDER] values(3,'85236asd',5,convert(datetime,'2022-05-16'),1000);


insert into dbo.SUPPLIES values(1,1);
insert into dbo.SUPPLIES values(2,2);
insert into dbo.SUPPLIES values(3,3);
insert into dbo.SUPPLIES values(4,4);
insert into dbo.SUPPLIES values(5,5);


insert into dbo.VISIT values(1,'12345bnm',1);
insert into dbo.VISIT values(2,'45678ghj',2);
insert into dbo.VISIT values(3,'85236asd',3);
insert into dbo.VISIT values(4,'52314mkn',4);
insert into dbo.VISIT values(5,'45678bmk',5);



insert into dbo.[ADMIN] values('145698mkol','AhmedFlowks');
insert into dbo.[ADMIN] values('145879asde','AlySamy');
insert into dbo.[ADMIN] values('456325klfa','ZiadMhamed');
insert into dbo.[ADMIN] values('789562vbnc','MohamedGomaa');
insert into dbo.[ADMIN] values('124578bnmg','GamalKamal');

select * from dbo.[ADMIN]