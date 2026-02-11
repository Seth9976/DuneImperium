using System;

namespace UnityEngine.UIElements
{
	// Token: 0x020002DA RID: 730
	public static class TextNative
	{
		// Token: 0x06003416 RID: 13334 RVA: 0x000DA120 File Offset: 0x000D8320
		public static float ComputeTextScaling(Matrix4x4 worldMatrix, float pixelsPerPoint)
		{
			Vector3 vector = new Vector3(worldMatrix.m00, worldMatrix.m10, worldMatrix.m20);
			Vector3 vector2 = new Vector3(worldMatrix.m01, worldMatrix.m11, worldMatrix.m21);
			float num = (vector.magnitude + vector2.magnitude) / 2f;
			return num * pixelsPerPoint;
		}
	}
}
