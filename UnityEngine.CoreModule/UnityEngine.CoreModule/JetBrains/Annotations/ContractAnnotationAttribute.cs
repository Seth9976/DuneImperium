using System;

namespace JetBrains.Annotations
{
	// Token: 0x020002AC RID: 684
	public sealed class ContractAnnotationAttribute : Attribute
	{
		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x00011722 File Offset: 0x0000F922
		public string Contract
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x0001172F File Offset: 0x0000F92F
		public bool ForceFullStates
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
