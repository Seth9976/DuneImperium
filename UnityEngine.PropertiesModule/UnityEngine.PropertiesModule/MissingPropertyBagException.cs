using System;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class MissingPropertyBagException : Exception
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00002F5A File Offset: 0x0000115A
		public Type Type
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x00008400 File Offset: 0x00006600
		public static string GetMessageForType(Type type)
		{
			return String.Concat("No PropertyBag was found for Type=[", type.FullName, "]. Please make sure all types are declared ahead of time using [GeneratePropertyBagAttribute], [GeneratePropertyBagsForTypeAttribute] or [GeneratePropertyBagsForTypesQualifiedWithAttribute]");
		}
	}
}
