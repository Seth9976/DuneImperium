using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine
{
	// Token: 0x0200002C RID: 44
	public sealed class GUIGridSizer : GUILayoutEntry
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x00017798 File Offset: 0x00015998
		public static Rect GetRect(Il2CppReferenceArray<GUIContent> contents, int xCount, GUIStyle style, Il2CppReferenceArray<GUILayoutOption> options)
		{
			Rect rect = new Rect(0f, 0f, 0f, 0f);
			EventType type = Event.current.type;
			EventType eventType = type;
			if (eventType != EventType.Layout)
			{
				if (eventType == EventType.Used)
				{
					return GUILayoutEntry.kDummyRect;
				}
				rect = GUILayoutUtility.current.topLevel.GetNext().rect;
			}
			else
			{
				GUILayoutUtility.current.topLevel.Add(new GUIGridSizer(contents, xCount, style, options));
			}
			return rect;
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000686 RID: 1670 RVA: 0x00004DA2 File Offset: 0x00002FA2
		public int rows
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}
	}
}
