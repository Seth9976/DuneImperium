using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E9 RID: 745
	public class UxmlColorAttributeDescription : TypedUxmlAttributeDescription<Color>
	{
		// Token: 0x1700106B RID: 4203
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x000DC664 File Offset: 0x000DA864
		public override string defaultValueAsString
		{
			get
			{
				return base.defaultValue.ToString();
			}
		}

		// Token: 0x06003486 RID: 13446 RVA: 0x00015521 File Offset: 0x00013721
		public override Color GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x0001552E File Offset: 0x0001372E
		public bool TryGetValueFromBag(IUxmlAttributes bag, CreationContext cc, ref Color value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06003488 RID: 13448 RVA: 0x000DC68C File Offset: 0x000DA88C
		public static Color ConvertValueToColor(string v, Color defaultValue)
		{
			Color color;
			bool flag = v == null || !ColorUtility.TryParseHtmlString(v, out color);
			Color color2;
			if (flag)
			{
				color2 = defaultValue;
			}
			else
			{
				color2 = color;
			}
			return color2;
		}

		// Token: 0x02000583 RID: 1411
		[Serializable]
		public sealed class <>c
		{
		}
	}
}
