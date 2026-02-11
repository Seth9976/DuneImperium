using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000024 RID: 36
	public sealed class GUIElement
	{
		// Token: 0x06000672 RID: 1650 RVA: 0x00004D23 File Offset: 0x00002F23
		public static void FeatureRemoved()
		{
			throw new Exception("GUIElement has been removed from Unity. Consider using https://docs.unity3d.com/ScriptReference/UIElements.Image.html, https://docs.unity3d.com/ScriptReference/UIElements.TextElement.html or TextMeshPro instead.");
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00017670 File Offset: 0x00015870
		public bool HitTest(Vector3 screenPosition)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0001768C File Offset: 0x0001588C
		public bool HitTest(Vector3 screenPosition, Camera camera)
		{
			GUIElement.FeatureRemoved();
			return false;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x000176A8 File Offset: 0x000158A8
		public Rect GetScreenRect(Camera camera)
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000176DC File Offset: 0x000158DC
		public Rect GetScreenRect()
		{
			GUIElement.FeatureRemoved();
			return new Rect(0f, 0f, 0f, 0f);
		}
	}
}
