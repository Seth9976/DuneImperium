using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020002CB RID: 715
	public struct Ray2D
	{
		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x06002D04 RID: 11524 RVA: 0x000B30B8 File Offset: 0x000B12B8
		// (set) Token: 0x06002D05 RID: 11525 RVA: 0x000119BA File Offset: 0x0000FBBA
		public Vector2 origin
		{
			get
			{
				return this.m_Origin;
			}
			set
			{
				this.m_Origin = value;
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x06002D06 RID: 11526 RVA: 0x000B30D0 File Offset: 0x000B12D0
		// (set) Token: 0x06002D07 RID: 11527 RVA: 0x000119C4 File Offset: 0x0000FBC4
		public Vector2 direction
		{
			get
			{
				return this.m_Direction;
			}
			set
			{
				this.m_Direction = value.normalized;
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x000B30E8 File Offset: 0x000B12E8
		public Vector2 GetPoint(float distance)
		{
			return this.m_Origin + this.m_Direction * distance;
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x000B3114 File Offset: 0x000B1314
		public override string ToString()
		{
			return this.ToString(null, null);
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x000B3130 File Offset: 0x000B1330
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x000119D4 File Offset: 0x0000FBD4
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04002866 RID: 10342
		public Vector2 m_Origin;

		// Token: 0x04002867 RID: 10343
		public Vector2 m_Direction;
	}
}
