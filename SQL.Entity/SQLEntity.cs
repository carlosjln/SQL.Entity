using System;
using SQL.Entity.Interfaces;

namespace SQL.Entity {

	public abstract class SQLEntity : ISQLEntity {
		// PROPERTIES
		public Guid Id { get; set; }

		protected IDatabaseSettings database_settings;
		
		protected SQLEntity() {
			var entity_type = GetType();
			database_settings = Settings.Get( entity_type );
		}

		protected SQLEntity( IDatabaseSettings database_settings ) {
			Id = Guid.NewGuid();
			this.database_settings = database_settings;
		}

		public virtual bool Save() {
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
}