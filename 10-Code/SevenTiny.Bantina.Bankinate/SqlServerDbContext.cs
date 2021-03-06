﻿/*********************************************************
 * CopyRight: 7TINY CODE BUILDER. 
 * Version: 5.0.0
 * Author: 7tiny
 * Address: Earth
 * Create: 2018-04-19 23:57:48
 * Modify: 2018-04-19 23:57:48
 * Modify: 2018-08-31 15:57:00
 * E-mail: dong@7tiny.com | sevenTiny@foxmail.com 
 * GitHub: https://github.com/sevenTiny 
 * Personal web site: http://www.7tiny.com 
 * Technical WebSit: http://www.cnblogs.com/7tiny/ 
 * Description: 
 * Thx , Best Regards ~
 *********************************************************/
using SevenTiny.Bantina.Bankinate.DbContexts;

namespace SevenTiny.Bantina.Bankinate
{
    public abstract class SqlServerDbContext<TDataBase> : SqlDbContext<TDataBase> where TDataBase : class
    {
        protected SqlServerDbContext(string connectionString) : base(connectionString, DataBaseType.SqlServer) { }
        protected SqlServerDbContext(string connectionString_Read, string connectionString_ReadWrite) : base(connectionString_Read, connectionString_ReadWrite, DataBaseType.SqlServer) { }
    }
}