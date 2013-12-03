using System;
using System.Collections.Generic;
using SQL.Entity.Interfaces;

namespace SQL.Entity {
	
	public sealed class Settings {
		public Type EntityType {get; set;}
		public IDatabaseSettings DatabaseSettings {get; set;}
		
		static readonly Dictionary<Type, IDatabaseSettings> entity_settings_collection = new Dictionary<Type, IDatabaseSettings>();

		public static void Register<TEntity>( IDatabaseSettings database_settings ) where TEntity : ISQLEntity {
			Register( typeof( TEntity ), database_settings );
		}

		public static void Register( Type entity_type, IDatabaseSettings database_settings ) {
			entity_settings_collection[ entity_type ] = database_settings;
		}

		public static IDatabaseSettings Get<TEntity>() where TEntity : ISQLEntity {
			return Get( typeof( TEntity ) );
		}

		public static IDatabaseSettings Get( Type entity_type ) {
			return entity_settings_collection.ContainsKey( entity_type ) ? entity_settings_collection[entity_type] : null;
		}
	}

}