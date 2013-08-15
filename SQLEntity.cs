using System;
using SQLEntity.Interfaces;

namespace SQLEntity {

	public abstract class SQLEntity : ISQLEntity {
		// PROPERTIES
		public Guid Id { get; set; }

		protected DatabaseSettings database_settings;
		protected SqlDatabase database;

		protected SQLEntity() {
			var entity_type = GetType();
			var entity_settings = EntitySettings.Get( entity_type );

			use_settings( entity_settings );
		}

		protected SQLEntity( DatabaseSettings database_settings ) {
			Id = Guid.NewGuid();
			
			this.database_settings = database_settings;
		}

		public virtual bool Create() {
			throw new NotImplementedException();
//			var sql_db = new SQL.Instance();
//			sql_db.Connect( nodus_settings.SqlDatabase );
//			
//			var entity_name = GetType().Name.ToLower();
//			var stored_procedure = entity_name + "_create";
//
//			var command = Utilities.Create.Sql.Command( stored_procedure );
//			command.parse_parameters( this );
//			
//			var reader = sql_db.Execute( command ).select_first();
//
//			return reader != null;
		}

	}

	public class SqlDatabase {}
}