using System;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200001D RID: 29
	[Serializable]
	public abstract class OpenTypeLayoutLookup
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x00002CEE File Offset: 0x00000EEE
		public virtual void UpdateRecords(int lookupIndex, uint glyphIndex)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002CF1 File Offset: 0x00000EF1
		public virtual void UpdateRecords(int lookupIndex, uint glyphIndex, float emScale)
		{
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x00002CF4 File Offset: 0x00000EF4
		public virtual void UpdateRecords(int lookupIndex, List<uint> glyphIndexes)
		{
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002CF7 File Offset: 0x00000EF7
		public virtual void UpdateRecords(int lookupIndex, List<uint> glyphIndexes, float emScale)
		{
		}
	}
}
