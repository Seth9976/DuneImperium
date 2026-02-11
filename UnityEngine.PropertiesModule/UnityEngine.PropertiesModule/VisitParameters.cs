using System;

namespace Unity.Properties
{
	// Token: 0x02000037 RID: 55
	public struct VisitParameters
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002E8E File Offset: 0x0000108E
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00002E96 File Offset: 0x00001096
		public VisitExceptionKind IgnoreExceptions
		{
			get
			{
				return this.<IgnoreExceptions>k__BackingField;
			}
			set
			{
				this.<IgnoreExceptions>k__BackingField = value;
			}
		}

		// Token: 0x040000CF RID: 207
		public VisitExceptionKind <IgnoreExceptions>k__BackingField;
	}
}
