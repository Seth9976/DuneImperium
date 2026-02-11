using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002EC RID: 748
	public class UxmlValueBounds : UxmlTypeRestriction
	{
		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06003490 RID: 13456 RVA: 0x00015589 File Offset: 0x00013789
		// (set) Token: 0x06003491 RID: 13457 RVA: 0x00015596 File Offset: 0x00013796
		public string min
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06003492 RID: 13458 RVA: 0x000155A3 File Offset: 0x000137A3
		// (set) Token: 0x06003493 RID: 13459 RVA: 0x000155B0 File Offset: 0x000137B0
		public string max
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06003494 RID: 13460 RVA: 0x000155BD File Offset: 0x000137BD
		// (set) Token: 0x06003495 RID: 13461 RVA: 0x000155CA File Offset: 0x000137CA
		public bool excludeMin
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06003496 RID: 13462 RVA: 0x000155D7 File Offset: 0x000137D7
		// (set) Token: 0x06003497 RID: 13463 RVA: 0x000155E4 File Offset: 0x000137E4
		public bool excludeMax
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x000DC6F0 File Offset: 0x000DA8F0
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueBounds uxmlValueBounds = other.TryCast<UxmlValueBounds>();
			bool flag = uxmlValueBounds == null;
			return !flag && (this.min == uxmlValueBounds.min && this.max == uxmlValueBounds.max && this.excludeMin == uxmlValueBounds.excludeMin) && this.excludeMax == uxmlValueBounds.excludeMax;
		}
	}
}
