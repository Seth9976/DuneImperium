using System;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000308 RID: 776
	public struct SnapAxisFilter
	{
		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x06002DB3 RID: 11699 RVA: 0x000B3CE0 File Offset: 0x000B1EE0
		public float x
		{
			get
			{
				return ((this.m_Mask & SnapAxis.X) == SnapAxis.X) ? 1f : 0f;
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002DB4 RID: 11700 RVA: 0x000B3D0C File Offset: 0x000B1F0C
		public float y
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Y) == SnapAxis.Y) ? 1f : 0f;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002DB5 RID: 11701 RVA: 0x000B3D38 File Offset: 0x000B1F38
		public float z
		{
			get
			{
				return ((this.m_Mask & SnapAxis.Z) == SnapAxis.Z) ? 1f : 0f;
			}
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x000B3D64 File Offset: 0x000B1F64
		public override string ToString()
		{
			return String.Format("{{{0}, {1}, {2}}}", this.x, this.y, this.z);
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x06002DB7 RID: 11703 RVA: 0x000B3DA4 File Offset: 0x000B1FA4
		public int active
		{
			get
			{
				int num = 0;
				bool flag = (this.m_Mask & SnapAxis.X) > SnapAxis.None;
				if (flag)
				{
					num++;
				}
				bool flag2 = (this.m_Mask & SnapAxis.Y) > SnapAxis.None;
				if (flag2)
				{
					num++;
				}
				bool flag3 = (this.m_Mask & SnapAxis.Z) > SnapAxis.None;
				if (flag3)
				{
					num++;
				}
				return num;
			}
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x000B3DF4 File Offset: 0x000B1FF4
		public static implicit operator Vector3(SnapAxisFilter mask)
		{
			return new Vector3(mask.x, mask.y, mask.z);
		}

		// Token: 0x06002DB9 RID: 11705 RVA: 0x000B3E20 File Offset: 0x000B2020
		public static explicit operator SnapAxisFilter(Vector3 v)
		{
			return new SnapAxisFilter(v);
		}

		// Token: 0x06002DBA RID: 11706 RVA: 0x000B3E38 File Offset: 0x000B2038
		public static explicit operator SnapAxis(SnapAxisFilter mask)
		{
			return mask.m_Mask;
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x000B3E50 File Offset: 0x000B2050
		public static SnapAxisFilter operator |(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask | right.m_Mask);
		}

		// Token: 0x06002DBC RID: 11708 RVA: 0x000B3E74 File Offset: 0x000B2074
		public static SnapAxisFilter operator &(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask & right.m_Mask);
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x000B3E98 File Offset: 0x000B2098
		public static SnapAxisFilter operator ^(SnapAxisFilter left, SnapAxisFilter right)
		{
			return new SnapAxisFilter(left.m_Mask ^ right.m_Mask);
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x000B3EBC File Offset: 0x000B20BC
		public static SnapAxisFilter operator ~(SnapAxisFilter left)
		{
			return new SnapAxisFilter(~left.m_Mask);
		}

		// Token: 0x06002DBF RID: 11711 RVA: 0x000B3EDC File Offset: 0x000B20DC
		public static Vector3 operator *(SnapAxisFilter mask, float value)
		{
			return new Vector3(mask.x * value, mask.y * value, mask.z * value);
		}

		// Token: 0x06002DC0 RID: 11712 RVA: 0x000B3F10 File Offset: 0x000B2110
		public static Vector3 operator *(SnapAxisFilter mask, Vector3 right)
		{
			return new Vector3(mask.x * right.x, mask.y * right.y, mask.z * right.z);
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x000B3F54 File Offset: 0x000B2154
		public static Vector3 operator *(Quaternion rotation, SnapAxisFilter mask)
		{
			int active = mask.active;
			bool flag = active > 2;
			Vector3 vector;
			if (flag)
			{
				vector = mask;
			}
			else
			{
				Vector3 vector2 = rotation * mask;
				vector2 = new Vector3(Mathf.Abs(vector2.x), Mathf.Abs(vector2.y), Mathf.Abs(vector2.z));
				bool flag2 = active > 1;
				if (flag2)
				{
					vector = new Vector3((float)((vector2.x > vector2.y || vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.x || vector2.y > vector2.z) ? 1 : 0), (float)((vector2.z > vector2.x || vector2.z > vector2.y) ? 1 : 0));
				}
				else
				{
					vector = new Vector3((float)((vector2.x > vector2.y && vector2.x > vector2.z) ? 1 : 0), (float)((vector2.y > vector2.z && vector2.y > vector2.x) ? 1 : 0), (float)((vector2.z > vector2.x && vector2.z > vector2.y) ? 1 : 0));
				}
			}
			return vector;
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x000B4098 File Offset: 0x000B2298
		public static bool operator ==(SnapAxisFilter left, SnapAxisFilter right)
		{
			return left.m_Mask == right.m_Mask;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x000B40B8 File Offset: 0x000B22B8
		public static bool operator !=(SnapAxisFilter left, SnapAxisFilter right)
		{
			return !(left == right);
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x06002DC4 RID: 11716 RVA: 0x000B40D4 File Offset: 0x000B22D4
		// (set) Token: 0x06002DC5 RID: 11717 RVA: 0x000B4110 File Offset: 0x000B2310
		public float Item
		{
			get
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				return (float)(SnapAxis.X & (this.m_Mask >> (i & 31))) * 1f;
			}
			set
			{
				bool flag = i < 0 || i > 2;
				if (flag)
				{
					throw new IndexOutOfRangeException();
				}
				this.m_Mask &= (SnapAxis)(~(SnapAxis)(1 << i));
				this.m_Mask |= (SnapAxis)(((value > 0f) ? 1 : 0) << (i & 31));
			}
		}

		// Token: 0x06002DC6 RID: 11718 RVA: 0x000B4168 File Offset: 0x000B2368
		public bool Equals(SnapAxisFilter other)
		{
			return this.m_Mask == other.m_Mask;
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x000B4188 File Offset: 0x000B2388
		public override bool Equals(Object obj)
		{
			bool flag = obj == null;
			return !flag && obj is SnapAxisFilter && this.Equals((SnapAxisFilter)obj);
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000B41C0 File Offset: 0x000B23C0
		public override int GetHashCode()
		{
			return this.m_Mask.GetHashCode();
		}

		// Token: 0x04002944 RID: 10564
		public const SnapAxis X = SnapAxis.X;

		// Token: 0x04002945 RID: 10565
		public const SnapAxis Y = SnapAxis.Y;

		// Token: 0x04002946 RID: 10566
		public const SnapAxis Z = SnapAxis.Z;

		// Token: 0x04002947 RID: 10567
		public SnapAxis m_Mask;
	}
}
