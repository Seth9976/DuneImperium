using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E2 RID: 738
	public struct StyleBackgroundPosition
	{
		// Token: 0x17001067 RID: 4199
		// (get) Token: 0x06003455 RID: 13397 RVA: 0x000DC22C File Offset: 0x000DA42C
		// (set) Token: 0x06003456 RID: 13398 RVA: 0x000154D9 File Offset: 0x000136D9
		public BackgroundPosition value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(BackgroundPosition);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17001068 RID: 4200
		// (get) Token: 0x06003457 RID: 13399 RVA: 0x000DC258 File Offset: 0x000DA458
		// (set) Token: 0x06003458 RID: 13400 RVA: 0x000154EA File Offset: 0x000136EA
		public StyleKeyword keyword
		{
			get
			{
				return this.m_Keyword;
			}
			set
			{
				this.m_Keyword = value;
			}
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x000DC270 File Offset: 0x000DA470
		public static bool operator ==(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x000DC2A4 File Offset: 0x000DA4A4
		public static bool operator !=(StyleBackgroundPosition lhs, StyleBackgroundPosition rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600345B RID: 13403 RVA: 0x000DC2C0 File Offset: 0x000DA4C0
		public static implicit operator StyleBackgroundPosition(StyleKeyword keyword)
		{
			return new StyleBackgroundPosition(keyword);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x000DC2D8 File Offset: 0x000DA4D8
		public static implicit operator StyleBackgroundPosition(BackgroundPosition v)
		{
			return new StyleBackgroundPosition(v);
		}

		// Token: 0x0600345D RID: 13405 RVA: 0x000DC2F0 File Offset: 0x000DA4F0
		public bool Equals(StyleBackgroundPosition other)
		{
			return other == this;
		}

		// Token: 0x0600345E RID: 13406 RVA: 0x000DC310 File Offset: 0x000DA510
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleBackgroundPosition)
			{
				StyleBackgroundPosition styleBackgroundPosition = (StyleBackgroundPosition)obj;
				flag = this.Equals(styleBackgroundPosition);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600345F RID: 13407 RVA: 0x000DC33C File Offset: 0x000DA53C
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x06003460 RID: 13408 RVA: 0x000DC370 File Offset: 0x000DA570
		public override string ToString()
		{
			return this.DebugString<BackgroundPosition>();
		}

		// Token: 0x0400260D RID: 9741
		public BackgroundPosition m_Value;

		// Token: 0x0400260E RID: 9742
		public StyleKeyword m_Keyword;
	}
}
