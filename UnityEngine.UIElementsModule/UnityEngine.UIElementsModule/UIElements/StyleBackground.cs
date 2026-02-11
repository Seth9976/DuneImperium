using System;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020002E1 RID: 737
	public struct StyleBackground
	{
		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x06003448 RID: 13384 RVA: 0x000DC0AC File Offset: 0x000DA2AC
		// (set) Token: 0x06003449 RID: 13385 RVA: 0x000154BE File Offset: 0x000136BE
		public Background value
		{
			get
			{
				return (this.m_Keyword == StyleKeyword.Undefined) ? this.m_Value : null;
			}
			set
			{
				this.m_Value = value;
				this.m_Keyword = StyleKeyword.Undefined;
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x0600344A RID: 13386 RVA: 0x000DC0D8 File Offset: 0x000DA2D8
		// (set) Token: 0x0600344B RID: 13387 RVA: 0x000154CF File Offset: 0x000136CF
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

		// Token: 0x0600344C RID: 13388 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
		public static bool operator ==(StyleBackground lhs, StyleBackground rhs)
		{
			return lhs.m_Keyword == rhs.m_Keyword && lhs.m_Value == rhs.m_Value;
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x000DC124 File Offset: 0x000DA324
		public static bool operator !=(StyleBackground lhs, StyleBackground rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x000DC140 File Offset: 0x000DA340
		public static implicit operator StyleBackground(StyleKeyword keyword)
		{
			return new StyleBackground(keyword);
		}

		// Token: 0x0600344F RID: 13391 RVA: 0x000DC158 File Offset: 0x000DA358
		public static implicit operator StyleBackground(Background v)
		{
			return new StyleBackground(v);
		}

		// Token: 0x06003450 RID: 13392 RVA: 0x000DC170 File Offset: 0x000DA370
		public static implicit operator StyleBackground(Texture2D v)
		{
			return new StyleBackground(v);
		}

		// Token: 0x06003451 RID: 13393 RVA: 0x000DC188 File Offset: 0x000DA388
		public bool Equals(StyleBackground other)
		{
			return other == this;
		}

		// Token: 0x06003452 RID: 13394 RVA: 0x000DC1A8 File Offset: 0x000DA3A8
		public override bool Equals(Object obj)
		{
			bool flag;
			if (obj is StyleBackground)
			{
				StyleBackground styleBackground = (StyleBackground)obj;
				flag = this.Equals(styleBackground);
			}
			else
			{
				flag = false;
			}
			return flag;
		}

		// Token: 0x06003453 RID: 13395 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
		public override int GetHashCode()
		{
			return (this.m_Value.GetHashCode() * 397) ^ (int)this.m_Keyword;
		}

		// Token: 0x06003454 RID: 13396 RVA: 0x000DC208 File Offset: 0x000DA408
		public override string ToString()
		{
			return this.DebugString<Background>();
		}

		// Token: 0x0400260B RID: 9739
		public Background m_Value;

		// Token: 0x0400260C RID: 9740
		public StyleKeyword m_Keyword;
	}
}
