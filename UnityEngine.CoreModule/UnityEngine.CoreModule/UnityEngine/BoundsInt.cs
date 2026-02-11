using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000081 RID: 129
	[StructLayout(2)]
	public struct BoundsInt
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x0002BB90 File Offset: 0x00029D90
		// Note: this type is marked as 'beforefieldinit'.
		static BoundsInt()
		{
			Il2CppClassPointerStore<BoundsInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BoundsInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr);
			BoundsInt.NativeFieldInfoPtr_m_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Position");
			BoundsInt.NativeFieldInfoPtr_m_Size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, "m_Size");
			BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664120);
			BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664121);
			BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664122);
			BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664123);
			BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664124);
			BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664125);
			BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664126);
			BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664127);
			BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664128);
			BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, 100664129);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0002BCE0 File Offset: 0x00029EE0
		public unsafe Vector3Int position
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 648521, RefRangeEnd = 648525, XrefRangeStart = 648521, XrefRangeEnd = 648525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0002BD14 File Offset: 0x00029F14
		// (set) Token: 0x060006A3 RID: 1699 RVA: 0x0002BD44 File Offset: 0x00029F44
		public unsafe Vector3Int size
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648525, RefRangeEnd = 648526, XrefRangeStart = 648525, XrefRangeEnd = 648526, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0002BD78 File Offset: 0x00029F78
		[CallerCount(0)]
		public unsafe BoundsInt(Vector3Int position, Vector3Int size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0002BDB8 File Offset: 0x00029FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648561, XrefRangeEnd = 648562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0002BDE4 File Offset: 0x00029FE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648562, XrefRangeEnd = 648584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0002BE34 File Offset: 0x0002A034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648584, XrefRangeEnd = 648588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0002BE78 File Offset: 0x0002A078
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648588, RefRangeEnd = 648589, XrefRangeStart = 648588, XrefRangeEnd = 648588, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BoundsInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0002BEB8 File Offset: 0x0002A0B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648589, XrefRangeEnd = 648591, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoundsInt.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00004992 File Offset: 0x00002B92
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BoundsInt>.NativeClassPtr, ref this));
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x000049A4 File Offset: 0x00002BA4
		public int x
		{
			get
			{
				return this.m_Position.x;
			}
			set
			{
				this.m_Position.x = value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0002BF08 File Offset: 0x0002A108
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000049B4 File Offset: 0x00002BB4
		public int y
		{
			get
			{
				return this.m_Position.y;
			}
			set
			{
				this.m_Position.y = value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0002BF28 File Offset: 0x0002A128
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x000049C4 File Offset: 0x00002BC4
		public int z
		{
			get
			{
				return this.m_Position.z;
			}
			set
			{
				this.m_Position.z = value;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0002BF48 File Offset: 0x0002A148
		public Vector3 center
		{
			get
			{
				return new Vector3((float)this.x + (float)this.m_Size.x / 2f, (float)this.y + (float)this.m_Size.y / 2f, (float)this.z + (float)this.m_Size.z / 2f);
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x060006B2 RID: 1714 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		// (set) Token: 0x060006B3 RID: 1715 RVA: 0x000049D4 File Offset: 0x00002BD4
		public Vector3Int min
		{
			get
			{
				return new Vector3Int(this.xMin, this.yMin, this.zMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
				this.zMin = value.z;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x0002BFDC File Offset: 0x0002A1DC
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x00004A01 File Offset: 0x00002C01
		public Vector3Int max
		{
			get
			{
				return new Vector3Int(this.xMax, this.yMax, this.zMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
				this.zMax = value.z;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060006B6 RID: 1718 RVA: 0x0002C008 File Offset: 0x0002A208
		// (set) Token: 0x060006B7 RID: 1719 RVA: 0x0002C044 File Offset: 0x0002A244
		public int xMin
		{
			get
			{
				return Math.Min(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				int xMax = this.xMax;
				this.m_Position.x = value;
				this.m_Size.x = xMax - this.m_Position.x;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060006B8 RID: 1720 RVA: 0x0002C080 File Offset: 0x0002A280
		// (set) Token: 0x060006B9 RID: 1721 RVA: 0x0002C0BC File Offset: 0x0002A2BC
		public int yMin
		{
			get
			{
				return Math.Min(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				int yMax = this.yMax;
				this.m_Position.y = value;
				this.m_Size.y = yMax - this.m_Position.y;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060006BA RID: 1722 RVA: 0x0002C0F8 File Offset: 0x0002A2F8
		// (set) Token: 0x060006BB RID: 1723 RVA: 0x0002C134 File Offset: 0x0002A334
		public int zMin
		{
			get
			{
				return Math.Min(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				int zMax = this.zMax;
				this.m_Position.z = value;
				this.m_Size.z = zMax - this.m_Position.z;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0002C170 File Offset: 0x0002A370
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x00004A2E File Offset: 0x00002C2E
		public int xMax
		{
			get
			{
				return Math.Max(this.m_Position.x, this.m_Position.x + this.m_Size.x);
			}
			set
			{
				this.m_Size.x = value - this.m_Position.x;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0002C1AC File Offset: 0x0002A3AC
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x00004A4A File Offset: 0x00002C4A
		public int yMax
		{
			get
			{
				return Math.Max(this.m_Position.y, this.m_Position.y + this.m_Size.y);
			}
			set
			{
				this.m_Size.y = value - this.m_Position.y;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0002C1E8 File Offset: 0x0002A3E8
		// (set) Token: 0x060006C1 RID: 1729 RVA: 0x00004A66 File Offset: 0x00002C66
		public int zMax
		{
			get
			{
				return Math.Max(this.m_Position.z, this.m_Position.z + this.m_Size.z);
			}
			set
			{
				this.m_Size.z = value - this.m_Position.z;
			}
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00004A82 File Offset: 0x00002C82
		public void SetMinMax(Vector3Int minPosition, Vector3Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x0002C224 File Offset: 0x0002A424
		public void ClampToBounds(BoundsInt bounds)
		{
			this.position = new Vector3Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin), Math.Max(Math.Min(bounds.zMax, this.position.z), bounds.zMin));
			this.size = new Vector3Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y), Math.Min(bounds.zMax - this.position.z, this.size.z));
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0002C338 File Offset: 0x0002A538
		public bool Contains(Vector3Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.z >= this.zMin && position.x < this.xMax && position.y < this.yMax && position.z < this.zMax;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0002C3A8 File Offset: 0x0002A5A8
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0002C3C4 File Offset: 0x0002A5C4
		public static bool operator ==(BoundsInt lhs, BoundsInt rhs)
		{
			return lhs.m_Position == rhs.m_Position && lhs.m_Size == rhs.m_Size;
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x0002C400 File Offset: 0x0002A600
		public static bool operator !=(BoundsInt lhs, BoundsInt rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0002C41C File Offset: 0x0002A61C
		public BoundsInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new BoundsInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x040005A7 RID: 1447
		private static readonly IntPtr NativeFieldInfoPtr_m_Position;

		// Token: 0x040005A8 RID: 1448
		private static readonly IntPtr NativeFieldInfoPtr_m_Size;

		// Token: 0x040005A9 RID: 1449
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector3Int_0;

		// Token: 0x040005AA RID: 1450
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector3Int_0;

		// Token: 0x040005AB RID: 1451
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector3Int_0;

		// Token: 0x040005AC RID: 1452
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector3Int_0;

		// Token: 0x040005AD RID: 1453
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector3Int_Vector3Int_0;

		// Token: 0x040005AE RID: 1454
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040005AF RID: 1455
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x040005B0 RID: 1456
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005B1 RID: 1457
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BoundsInt_0;

		// Token: 0x040005B2 RID: 1458
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005B3 RID: 1459
		[FieldOffset(0)]
		public Vector3Int m_Position;

		// Token: 0x040005B4 RID: 1460
		[FieldOffset(12)]
		public Vector3Int m_Size;

		// Token: 0x020004A9 RID: 1193
		public struct PositionEnumerator
		{
		}
	}
}
