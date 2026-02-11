using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E3 RID: 739
	public struct StyleBackgroundRepeat
	{
		// Token: 0x17001069 RID: 4201
		// (get) Token: 0x06003461 RID: 13409 RVA: 0x000DC394 File Offset: 0x000DA594
		// (set) Token: 0x06003462 RID: 13410 RVA: 0x000154F4 File Offset: 0x000136F4
		public BackgroundRepeat value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : default(BackgroundRepeat);
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x1700106A RID: 4202
		// (get) Token: 0x06003463 RID: 13411 RVA: 0x000DC3C0 File Offset: 0x000DA5C0
		// (set) Token: 0x06003464 RID: 13412 RVA: 0x00015505 File Offset: 0x00013705
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

		// Token: 0x06003465 RID: 13413 RVA: 0x000DC3D8 File Offset: 0x000DA5D8
		public static bool operator ==(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x000DC40C File Offset: 0x000DA60C
		public static bool operator !=(StyleBackgroundRepeat lhs, StyleBackgroundRepeat rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x06003467 RID: 13415 RVA: 0x000DC428 File Offset: 0x000DA628
		public static implicit operator StyleBackgroundRepeat(StyleKeyword keyword)
		{
			return new StyleBackgroundRepeat(keyword);
		}

		// Token: 0x06003468 RID: 13416 RVA: 0x000DC440 File Offset: 0x000DA640
		public static implicit operator StyleBackgroundRepeat(BackgroundRepeat v)
		{
			return new StyleBackgroundRepeat(v);
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x000DC458 File Offset: 0x000DA658
		public bool Equals(StyleBackgroundRepeat other)
		{
			return other == this;
		}

		// Token: 0x0600346A RID: 13418 RVA: 0x000DC478 File Offset: 0x000DA678
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleBackgroundRepeat)
			{
				StyleBackgroundRepeat styleBackgroundRepeat = (StyleBackgroundRepeat)obj;
				flag = this.Equals(styleBackgroundRepeat);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x000DC4A4 File Offset: 0x000DA6A4
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x000DC4D8 File Offset: 0x000DA6D8
		public override string ToString()
		{
			return this.DebugString<BackgroundRepeat>();
		}

		// Token: 0x0400260F RID: 9743
		public BackgroundRepeat m_Value;

		// Token: 0x04002610 RID: 9744
		public StyleKeyword m_Keyword;
	}
}
