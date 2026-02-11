using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000086 RID: 134
	[StructLayout(2)]
	public struct RectInt
	{
		// Token: 0x0600072F RID: 1839 RVA: 0x0002DF30 File Offset: 0x0002C130
		// Note: this type is marked as 'beforefieldinit'.
		static RectInt()
		{
			Il2CppClassPointerStore<RectInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RectInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RectInt>.NativeClassPtr);
			RectInt.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_XMin");
			RectInt.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_YMin");
			RectInt.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Width");
			RectInt.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RectInt>.NativeClassPtr, "m_Height");
			RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664193);
			RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664194);
			RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664195);
			RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664196);
			RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664197);
			RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664198);
			RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664199);
			RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664200);
			RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664201);
			RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664202);
			RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664203);
			RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664204);
			RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664205);
			RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664206);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664207);
			RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664208);
			RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RectInt>.NativeClassPtr, 100664209);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000730 RID: 1840 RVA: 0x0002E104 File Offset: 0x0002C304
		// (set) Token: 0x06000731 RID: 1841 RVA: 0x0002E134 File Offset: 0x0002C334
		public unsafe int x
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x0002E168 File Offset: 0x0002C368
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x0002E198 File Offset: 0x0002C398
		public unsafe int y
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000734 RID: 1844 RVA: 0x0002E1CC File Offset: 0x0002C3CC
		// (set) Token: 0x06000735 RID: 1845 RVA: 0x0002E1FC File Offset: 0x0002C3FC
		public unsafe int width
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 310301, RefRangeEnd = 310309, XrefRangeStart = 310301, XrefRangeEnd = 310309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000736 RID: 1846 RVA: 0x0002E230 File Offset: 0x0002C430
		// (set) Token: 0x06000737 RID: 1847 RVA: 0x0002E260 File Offset: 0x0002C460
		public unsafe int height
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 310309, RefRangeEnd = 310312, XrefRangeStart = 310309, XrefRangeEnd = 310312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000738 RID: 1848 RVA: 0x0002E294 File Offset: 0x0002C494
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x0002E538 File Offset: 0x0002C738
		public unsafe int xMin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648797, XrefRangeEnd = 648801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMin_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				int xMax = this.xMax;
				this.m_XMin = value;
				this.m_Width = xMax - this.m_XMin;
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000739 RID: 1849 RVA: 0x0002E2C4 File Offset: 0x0002C4C4
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0002E564 File Offset: 0x0002C764
		public unsafe int yMin
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648801, XrefRangeEnd = 648805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMin_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				int yMax = this.yMax;
				this.m_YMin = value;
				this.m_Height = yMax - this.m_YMin;
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x0600073A RID: 1850 RVA: 0x0002E2F4 File Offset: 0x0002C4F4
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00004C12 File Offset: 0x00002E12
		public unsafe int xMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648805, XrefRangeEnd = 648809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_xMax_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value - this.m_XMin;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x0600073B RID: 1851 RVA: 0x0002E324 File Offset: 0x0002C524
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x00004C23 File Offset: 0x00002E23
		public unsafe int yMax
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648809, XrefRangeEnd = 648813, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_get_yMax_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value - this.m_YMin;
			}
		}

		// Token: 0x0600073C RID: 1852 RVA: 0x0002E354 File Offset: 0x0002C554
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RectInt(int xMin, int yMin, int width, int height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xMin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yMin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0002E3B0 File Offset: 0x0002C5B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 648846, RefRangeEnd = 648847, XrefRangeStart = 648813, XrefRangeEnd = 648846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(RectInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0002E3F0 File Offset: 0x0002C5F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648847, XrefRangeEnd = 648848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0002E41C File Offset: 0x0002C61C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648848, XrefRangeEnd = 648870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0002E46C File Offset: 0x0002C66C
		[CallerCount(0)]
		public unsafe bool Equals(RectInt other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RectInt.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00004BC2 File Offset: 0x00002DC2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RectInt>.NativeClassPtr, ref this));
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0002E4AC File Offset: 0x0002C6AC
		public Vector2 center
		{
			get
			{
				return new Vector2((float)this.x + (float)this.m_Width / 2f, (float)this.y + (float)this.m_Height / 2f);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0002E4F0 File Offset: 0x0002C6F0
		// (set) Token: 0x06000744 RID: 1860 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public Vector2Int min
		{
			get
			{
				return new Vector2Int(this.xMin, this.yMin);
			}
			set
			{
				this.xMin = value.x;
				this.yMin = value.y;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0002E514 File Offset: 0x0002C714
		// (set) Token: 0x06000746 RID: 1862 RVA: 0x00004BF3 File Offset: 0x00002DF3
		public Vector2Int max
		{
			get
			{
				return new Vector2Int(this.xMax, this.yMax);
			}
			set
			{
				this.xMax = value.x;
				this.yMax = value.y;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0002E590 File Offset: 0x0002C790
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x00004C34 File Offset: 0x00002E34
		public Vector2Int position
		{
			get
			{
				return new Vector2Int(this.m_XMin, this.m_YMin);
			}
			set
			{
				this.m_XMin = value.x;
				this.m_YMin = value.y;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0002E5B4 File Offset: 0x0002C7B4
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x00004C51 File Offset: 0x00002E51
		public Vector2Int size
		{
			get
			{
				return new Vector2Int(this.m_Width, this.m_Height);
			}
			set
			{
				this.m_Width = value.x;
				this.m_Height = value.y;
			}
		}

		// Token: 0x0600074F RID: 1871 RVA: 0x00004C6E File Offset: 0x00002E6E
		public void SetMinMax(Vector2Int minPosition, Vector2Int maxPosition)
		{
			this.min = minPosition;
			this.max = maxPosition;
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		public void ClampToBounds(RectInt bounds)
		{
			this.position = new Vector2Int(Math.Max(Math.Min(bounds.xMax, this.position.x), bounds.xMin), Math.Max(Math.Min(bounds.yMax, this.position.y), bounds.yMin));
			this.size = new Vector2Int(Math.Min(bounds.xMax - this.position.x, this.size.x), Math.Min(bounds.yMax - this.position.y, this.size.y));
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0002E69C File Offset: 0x0002C89C
		public bool Contains(Vector2Int position)
		{
			return position.x >= this.xMin && position.y >= this.yMin && position.x < this.xMax && position.y < this.yMax;
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x0002E6F0 File Offset: 0x0002C8F0
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002E70C File Offset: 0x0002C90C
		public RectInt.PositionEnumerator allPositionsWithin
		{
			get
			{
				return new RectInt.PositionEnumerator(this.min, this.max);
			}
		}

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Int32_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Int32_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Int32_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Int32_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Int32_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Int32_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_RectInt_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000619 RID: 1561
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x0400061A RID: 1562
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_RectInt_0;

		// Token: 0x0400061B RID: 1563
		[FieldOffset(0)]
		public int m_XMin;

		// Token: 0x0400061C RID: 1564
		[FieldOffset(4)]
		public int m_YMin;

		// Token: 0x0400061D RID: 1565
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x0400061E RID: 1566
		[FieldOffset(12)]
		public int m_Height;

		// Token: 0x020004AB RID: 1195
		public struct PositionEnumerator
		{
		}
	}
}
