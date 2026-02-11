using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002EB RID: 747
	public class UxmlValueMatches : UxmlTypeRestriction
	{
		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x0600348D RID: 13453 RVA: 0x0001556F File Offset: 0x0001376F
		// (set) Token: 0x0600348E RID: 13454 RVA: 0x0001557C File Offset: 0x0001377C
		public string regex
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

		// Token: 0x0600348F RID: 13455 RVA: 0x000DC6B8 File Offset: 0x000DA8B8
		public override bool Equals(UxmlTypeRestriction other)
		{
			UxmlValueMatches uxmlValueMatches = other.TryCast<UxmlValueMatches>();
			bool flag = uxmlValueMatches == null;
			return !flag && this.regex == uxmlValueMatches.regex;
		}
	}
}
