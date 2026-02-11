using System;

namespace UnityEngine.TerrainTools
{
	// Token: 0x02000016 RID: 22
	public struct BrushTransform
	{
		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x0000332D File Offset: 0x0000152D
		public Vector2 brushOrigin
		{
			get
			{
				return this.<brushOrigin>k__BackingField;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00003335 File Offset: 0x00001535
		public Vector2 brushU
		{
			get
			{
				return this.<brushU>k__BackingField;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x0000333D File Offset: 0x0000153D
		public Vector2 brushV
		{
			get
			{
				return this.<brushV>k__BackingField;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00003345 File Offset: 0x00001545
		public Vector2 targetOrigin
		{
			get
			{
				return this.<targetOrigin>k__BackingField;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001AA RID: 426 RVA: 0x0000334D File Offset: 0x0000154D
		public Vector2 targetX
		{
			get
			{
				return this.<targetX>k__BackingField;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00003355 File Offset: 0x00001555
		public Vector2 targetY
		{
			get
			{
				return this.<targetY>k__BackingField;
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000062C8 File Offset: 0x000044C8
		public Rect GetBrushXYBounds()
		{
			Vector2 vector = this.brushOrigin + this.brushU;
			Vector2 vector2 = this.brushOrigin + this.brushV;
			Vector2 vector3 = this.brushOrigin + this.brushU + this.brushV;
			float num = Mathf.Min(Mathf.Min(this.brushOrigin.x, vector.x), Mathf.Min(vector2.x, vector3.x));
			float num2 = Mathf.Max(Mathf.Max(this.brushOrigin.x, vector.x), Mathf.Max(vector2.x, vector3.x));
			float num3 = Mathf.Min(Mathf.Min(this.brushOrigin.y, vector.y), Mathf.Min(vector2.y, vector3.y));
			float num4 = Mathf.Max(Mathf.Max(this.brushOrigin.y, vector.y), Mathf.Max(vector2.y, vector3.y));
			return Rect.MinMaxRect(num, num3, num2, num4);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000063E0 File Offset: 0x000045E0
		public static BrushTransform FromRect(Rect brushRect)
		{
			Vector2 min = brushRect.min;
			Vector2 vector = new Vector2(brushRect.width, 0f);
			Vector2 vector2 = new Vector2(0f, brushRect.height);
			return new BrushTransform(min, vector, vector2);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00006428 File Offset: 0x00004628
		public Vector2 ToBrushUV(Vector2 targetXY)
		{
			return targetXY.x * this.targetX + targetXY.y * this.targetY + this.targetOrigin;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000646C File Offset: 0x0000466C
		public Vector2 FromBrushUV(Vector2 brushUV)
		{
			return brushUV.x * this.brushU + brushUV.y * this.brushV + this.brushOrigin;
		}

		// Token: 0x0400011C RID: 284
		public readonly Vector2 <brushOrigin>k__BackingField;

		// Token: 0x0400011D RID: 285
		public readonly Vector2 <brushU>k__BackingField;

		// Token: 0x0400011E RID: 286
		public readonly Vector2 <brushV>k__BackingField;

		// Token: 0x0400011F RID: 287
		public readonly Vector2 <targetOrigin>k__BackingField;

		// Token: 0x04000120 RID: 288
		public readonly Vector2 <targetX>k__BackingField;

		// Token: 0x04000121 RID: 289
		public readonly Vector2 <targetY>k__BackingField;
	}
}
