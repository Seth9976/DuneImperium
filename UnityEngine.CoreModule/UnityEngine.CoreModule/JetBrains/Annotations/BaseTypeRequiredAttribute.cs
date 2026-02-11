using System;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x020002AF RID: 687
	public sealed class BaseTypeRequiredAttribute : Attribute
	{
		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00011749 File Offset: 0x0000F949
		public Type BaseType
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
