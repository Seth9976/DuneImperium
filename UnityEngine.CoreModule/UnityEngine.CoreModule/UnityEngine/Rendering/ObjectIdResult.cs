using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Rendering
{
	// Token: 0x0200034A RID: 842
	public class ObjectIdResult
	{
		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000128A1 File Offset: 0x00010AA1
		public Il2CppReferenceArray<Object> idToObjectMapping
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002E40 RID: 11840 RVA: 0x000B4BFC File Offset: 0x000B2DFC
		public static int DecodeIdFromColor(Color color)
		{
			return (int)(color.r * 255f) + ((int)(color.g * 255f) << 8) + ((int)(color.b * 255f) << 16) + ((int)(color.a * 255f) << 24);
		}
	}
}
