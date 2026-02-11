using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002B4 RID: 692
	public sealed class PathReferenceAttribute : Attribute
	{
		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00011770 File Offset: 0x0000F970
		public string BasePath
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
