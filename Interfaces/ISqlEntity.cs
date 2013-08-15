using System;
using DummyEntity.Interfaces;

namespace SQLEntity.Interfaces {

	public interface ISQLEntity : IEntity {
		new Guid Id {get; set;}
	}

}