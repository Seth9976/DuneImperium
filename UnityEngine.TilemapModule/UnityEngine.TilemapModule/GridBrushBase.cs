using System;

namespace UnityEngine
{
	// Token: 0x0200000E RID: 14
	public abstract class GridBrushBase : ScriptableObject
	{
		// Token: 0x06000147 RID: 327 RVA: 0x00002C60 File Offset: 0x00000E60
		public virtual void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002C63 File Offset: 0x00000E63
		public virtual void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005544 File Offset: 0x00003744
		public virtual void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Paint(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000055C4 File Offset: 0x000037C4
		public virtual void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
			for (int i = position.zMin; i < position.zMax; i++)
			{
				for (int j = position.yMin; j < position.yMax; j++)
				{
					for (int k = position.xMin; k < position.xMax; k++)
					{
						this.Erase(gridLayout, brushTarget, new Vector3Int(k, j, i));
					}
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002C66 File Offset: 0x00000E66
		public virtual void Select(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002C69 File Offset: 0x00000E69
		public virtual void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position)
		{
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002C6C File Offset: 0x00000E6C
		public virtual void Rotate(GridBrushBase.RotationDirection direction, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00002C6F File Offset: 0x00000E6F
		public virtual void Flip(GridBrushBase.FlipAxis flip, GridLayout.CellLayout layout)
		{
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00002C72 File Offset: 0x00000E72
		public virtual void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot)
		{
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002C75 File Offset: 0x00000E75
		public virtual void Move(GridLayout gridLayout, GameObject brushTarget, BoundsInt from, BoundsInt to)
		{
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002C78 File Offset: 0x00000E78
		public virtual void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002C7B File Offset: 0x00000E7B
		public virtual void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002C7E File Offset: 0x00000E7E
		public virtual void ChangeZPosition(int change)
		{
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002C81 File Offset: 0x00000E81
		public virtual void ResetZPosition()
		{
		}

		// Token: 0x02000067 RID: 103
		public enum Tool
		{
			// Token: 0x040000E8 RID: 232
			Select,
			// Token: 0x040000E9 RID: 233
			Move,
			// Token: 0x040000EA RID: 234
			Paint,
			// Token: 0x040000EB RID: 235
			Box,
			// Token: 0x040000EC RID: 236
			Pick,
			// Token: 0x040000ED RID: 237
			Erase,
			// Token: 0x040000EE RID: 238
			FloodFill,
			// Token: 0x040000EF RID: 239
			Other
		}

		// Token: 0x02000068 RID: 104
		public enum RotationDirection
		{
			// Token: 0x040000F1 RID: 241
			Clockwise,
			// Token: 0x040000F2 RID: 242
			CounterClockwise
		}

		// Token: 0x02000069 RID: 105
		public enum FlipAxis
		{
			// Token: 0x040000F4 RID: 244
			X,
			// Token: 0x040000F5 RID: 245
			Y
		}
	}
}
