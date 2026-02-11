using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002CE RID: 718
	public static class RuntimePanelUtils
	{
		// Token: 0x06003406 RID: 13318 RVA: 0x000D9F40 File Offset: 0x000D8140
		public static Vector2 ScreenToPanel(IPanel panel, Vector2 screenPosition)
		{
			return panel.Cast<BaseRuntimePanel>().ScreenToPanel(screenPosition);
		}

		// Token: 0x06003407 RID: 13319 RVA: 0x000D9F60 File Offset: 0x000D8160
		public static Vector2 CameraTransformWorldToPanel(IPanel panel, Vector3 worldPosition, Camera camera)
		{
			Vector2 vector = camera.WorldToScreenPoint(worldPosition);
			vector.y = (float)Screen.height - vector.y;
			return panel.Cast<BaseRuntimePanel>().ScreenToPanel(vector);
		}

		// Token: 0x06003408 RID: 13320 RVA: 0x000D9FA0 File Offset: 0x000D81A0
		public static Rect CameraTransformWorldToPanelRect(IPanel panel, Vector3 worldPosition, Vector2 worldSize, Camera camera)
		{
			worldSize.y = -worldSize.y;
			Vector2 vector = RuntimePanelUtils.CameraTransformWorldToPanel(panel, worldPosition, camera);
			Vector3 vector2 = worldPosition + camera.worldToCameraMatrix.MultiplyVector(worldSize);
			Vector2 vector3 = RuntimePanelUtils.CameraTransformWorldToPanel(panel, vector2, camera);
			return new Rect(vector, vector3 - vector);
		}

		// Token: 0x06003409 RID: 13321 RVA: 0x000D9FFC File Offset: 0x000D81FC
		public static void ResetDynamicAtlas(IPanel panel)
		{
			BaseVisualElementPanel baseVisualElementPanel = panel.TryCast<BaseVisualElementPanel>();
			bool flag = baseVisualElementPanel == null;
			if (!flag)
			{
				DynamicAtlas dynamicAtlas = baseVisualElementPanel.atlas.TryCast<DynamicAtlas>();
				if (dynamicAtlas != null)
				{
					dynamicAtlas.Reset();
				}
			}
		}

		// Token: 0x0600340A RID: 13322 RVA: 0x000DA034 File Offset: 0x000D8234
		public static void SetTextureDirty(IPanel panel, Texture2D texture)
		{
			BaseVisualElementPanel baseVisualElementPanel = panel.TryCast<BaseVisualElementPanel>();
			bool flag = baseVisualElementPanel == null;
			if (!flag)
			{
				DynamicAtlas dynamicAtlas = baseVisualElementPanel.atlas.TryCast<DynamicAtlas>();
				if (dynamicAtlas != null)
				{
					dynamicAtlas.SetDirty(texture);
				}
			}
		}
	}
}
