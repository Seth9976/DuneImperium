using System;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x020002F8 RID: 760
	public class StyleValidator
	{
		// Token: 0x060034C7 RID: 13511 RVA: 0x000DC904 File Offset: 0x000DAB04
		public bool IsUnitMissing(string propertySyntax, string propertyValue, out string unitHint)
		{
			unitHint = null;
			float num;
			bool flag = !Single.TryParse(propertyValue, out num);
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = propertySyntax.Contains("<length>") || propertySyntax.Contains("<length-percentage>");
				if (flag3)
				{
					unitHint = "px or %";
				}
				else
				{
					bool flag4 = propertySyntax.Contains("<time>");
					if (flag4)
					{
						unitHint = "s or ms";
					}
				}
				flag2 = !String.IsNullOrEmpty(unitHint);
			}
			return flag2;
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x000DC978 File Offset: 0x000DAB78
		public bool IsUnsupportedColor(string propertySyntax)
		{
			return propertySyntax.StartsWith("<color>");
		}
	}
}
