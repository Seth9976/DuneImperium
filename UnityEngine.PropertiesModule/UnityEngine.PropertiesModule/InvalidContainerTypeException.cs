using System;
using Il2CppSystem;

namespace Unity.Properties
{
	// Token: 0x02000040 RID: 64
	[Serializable]
	public class InvalidContainerTypeException : Exception
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00002F67 File Offset: 0x00001167
		public Type Type
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x060001CA RID: 458 RVA: 0x00002F74 File Offset: 0x00001174
		public static string GetMessageForType(Type type)
		{
			throw new NotSupportedException("Method unstripping failed");
		}
	}
}
