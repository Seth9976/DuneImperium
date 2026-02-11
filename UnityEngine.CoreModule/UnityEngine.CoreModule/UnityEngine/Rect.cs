using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct Rect
	{
		// Token: 0x060006F9 RID: 1785 RVA: 0x0002CFC0 File Offset: 0x0002B1C0
		// Note: this type is marked as 'beforefieldinit'.
		static Rect()
		{
			Il2CppClassPointerStore<Rect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Rect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Rect>.NativeClassPtr);
			Rect.NativeFieldInfoPtr_m_XMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_XMin");
			Rect.NativeFieldInfoPtr_m_YMin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_YMin");
			Rect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Width");
			Rect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Rect>.NativeClassPtr, "m_Height");
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664150);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664151);
			Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664152);
			Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664153);
			Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664154);
			Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664155);
			Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664156);
			Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664157);
			Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664158);
			Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664159);
			Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664160);
			Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664161);
			Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664162);
			Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664163);
			Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664164);
			Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664165);
			Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664166);
			Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664167);
			Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664168);
			Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664169);
			Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664170);
			Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664171);
			Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664172);
			Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664173);
			Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664174);
			Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664175);
			Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664176);
			Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664177);
			Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664178);
			Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664179);
			Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664180);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664181);
			Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664182);
			Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664183);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664184);
			Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664185);
			Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664186);
			Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664187);
			Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664188);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664189);
			Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664190);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664191);
			Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Rect>.NativeClassPtr, 100664192);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0002D39C File Offset: 0x0002B59C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 323501, RefRangeEnd = 323508, XrefRangeStart = 323501, XrefRangeEnd = 323508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Rect(float x, float y, float width, float height)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref width;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002D3F8 File Offset: 0x0002B5F8
		[CallerCount(0)]
		public unsafe Rect(Vector2 position, Vector2 size)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref position;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref size;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x0002D438 File Offset: 0x0002B638
		[CallerCount(0)]
		public unsafe Rect(Rect source)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref source;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr__ctor_Public_Void_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060006FD RID: 1789 RVA: 0x0002D46C File Offset: 0x0002B66C
		public unsafe static Rect zero
		{
			[CallerCount(36)]
			[CachedScanResults(RefRangeStart = 648711, RefRangeEnd = 648747, XrefRangeStart = 648711, XrefRangeEnd = 648711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0002D49C File Offset: 0x0002B69C
		[CallerCount(0)]
		public unsafe static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref xmin;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref xmax;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ymax;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060006FF RID: 1791 RVA: 0x0002D504 File Offset: 0x0002B704
		// (set) Token: 0x06000700 RID: 1792 RVA: 0x0002D534 File Offset: 0x0002B734
		public unsafe float x
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_x_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 644340, RefRangeEnd = 644349, XrefRangeStart = 644340, XrefRangeEnd = 644349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_x_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000701 RID: 1793 RVA: 0x0002D568 File Offset: 0x0002B768
		// (set) Token: 0x06000702 RID: 1794 RVA: 0x0002D598 File Offset: 0x0002B798
		public unsafe float y
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_y_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 644397, RefRangeEnd = 644403, XrefRangeStart = 644397, XrefRangeEnd = 644403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_y_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000703 RID: 1795 RVA: 0x0002D5CC File Offset: 0x0002B7CC
		// (set) Token: 0x06000704 RID: 1796 RVA: 0x0002D5FC File Offset: 0x0002B7FC
		public unsafe Vector2 position
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_position_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0002D630 File Offset: 0x0002B830
		// (set) Token: 0x06000706 RID: 1798 RVA: 0x0002D660 File Offset: 0x0002B860
		public unsafe Vector2 center
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_center_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000707 RID: 1799 RVA: 0x0002D694 File Offset: 0x0002B894
		// (set) Token: 0x06000708 RID: 1800 RVA: 0x0002D6C4 File Offset: 0x0002B8C4
		public unsafe Vector2 min
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_min_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000709 RID: 1801 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
		// (set) Token: 0x0600070A RID: 1802 RVA: 0x0002D728 File Offset: 0x0002B928
		public unsafe Vector2 max
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_max_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x0600070B RID: 1803 RVA: 0x0002D75C File Offset: 0x0002B95C
		// (set) Token: 0x0600070C RID: 1804 RVA: 0x0002D78C File Offset: 0x0002B98C
		public unsafe float width
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 644429, RefRangeEnd = 644431, XrefRangeStart = 644429, XrefRangeEnd = 644431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_width_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x0600070D RID: 1805 RVA: 0x0002D7C0 File Offset: 0x0002B9C0
		// (set) Token: 0x0600070E RID: 1806 RVA: 0x0002D7F0 File Offset: 0x0002B9F0
		public unsafe float height
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 642841, RefRangeEnd = 642843, XrefRangeStart = 642841, XrefRangeEnd = 642843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_height_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x0600070F RID: 1807 RVA: 0x0002D824 File Offset: 0x0002BA24
		// (set) Token: 0x06000710 RID: 1808 RVA: 0x0002D854 File Offset: 0x0002BA54
		public unsafe Vector2 size
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 648747, RefRangeEnd = 648748, XrefRangeStart = 648747, XrefRangeEnd = 648747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_size_Public_get_Vector2_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x06000711 RID: 1809 RVA: 0x0002D888 File Offset: 0x0002BA88
		// (set) Token: 0x06000712 RID: 1810 RVA: 0x0002D8B8 File Offset: 0x0002BAB8
		public unsafe float xMin
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000713 RID: 1811 RVA: 0x0002D8EC File Offset: 0x0002BAEC
		// (set) Token: 0x06000714 RID: 1812 RVA: 0x0002D91C File Offset: 0x0002BB1C
		public unsafe float yMin
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMin_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x0002D950 File Offset: 0x0002BB50
		// (set) Token: 0x06000716 RID: 1814 RVA: 0x0002D980 File Offset: 0x0002BB80
		public unsafe float xMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_xMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x0002D9B4 File Offset: 0x0002BBB4
		// (set) Token: 0x06000718 RID: 1816 RVA: 0x0002D9E4 File Offset: 0x0002BBE4
		public unsafe float yMax
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_get_yMax_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0002DA18 File Offset: 0x0002BC18
		[CallerCount(0)]
		public unsafe bool Contains(Vector2 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x0002DA58 File Offset: 0x0002BC58
		[CallerCount(0)]
		public unsafe bool Contains(Vector3 point)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref point;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x0002DA98 File Offset: 0x0002BC98
		[CallerCount(0)]
		public unsafe static Rect OrderMinMax(Rect rect)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rect;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x0002DAD8 File Offset: 0x0002BCD8
		[CallerCount(0)]
		public unsafe bool Overlaps(Rect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x0002DB18 File Offset: 0x0002BD18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648749, RefRangeEnd = 648751, XrefRangeStart = 648748, XrefRangeEnd = 648749, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Overlaps(Rect other, bool allowInverse)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref allowInverse;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x0002DB64 File Offset: 0x0002BD64
		[CallerCount(0)]
		public unsafe static bool operator !=(Rect lhs, Rect rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x0002DBB0 File Offset: 0x0002BDB0
		[CallerCount(0)]
		public unsafe static bool operator ==(Rect lhs, Rect rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002DBFC File Offset: 0x0002BDFC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 648755, RefRangeEnd = 648757, XrefRangeStart = 648751, XrefRangeEnd = 648755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0002DC2C File Offset: 0x0002BE2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648757, XrefRangeEnd = 648764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0002DC70 File Offset: 0x0002BE70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648764, XrefRangeEnd = 648768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(Rect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x0002DCB0 File Offset: 0x0002BEB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 648768, XrefRangeEnd = 648769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x0002DCDC File Offset: 0x0002BEDC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 648794, RefRangeEnd = 648797, XrefRangeStart = 648769, XrefRangeEnd = 648794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Rect.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00004B90 File Offset: 0x00002D90
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Rect>.NativeClassPtr, ref this));
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00004BA2 File Offset: 0x00002DA2
		public void Set(float x, float y, float width, float height)
		{
			this.m_XMin = x;
			this.m_YMin = y;
			this.m_Width = width;
			this.m_Height = height;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x0002DD2C File Offset: 0x0002BF2C
		public bool Contains(Vector3 point, bool allowInverse)
		{
			bool flag = !allowInverse;
			bool flag2;
			if (flag)
			{
				flag2 = this.Contains(point);
			}
			else
			{
				bool flag3 = (this.width < 0f && point.x <= this.xMin && point.x > this.xMax) || (this.width >= 0f && point.x >= this.xMin && point.x < this.xMax);
				bool flag4 = (this.height < 0f && point.y <= this.yMin && point.y > this.yMax) || (this.height >= 0f && point.y >= this.yMin && point.y < this.yMax);
				flag2 = flag3 && flag4;
			}
			return flag2;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x0002DE0C File Offset: 0x0002C00C
		public static Vector2 NormalizedToPoint(Rect rectangle, Vector2 normalizedRectCoordinates)
		{
			return new Vector2(Mathf.Lerp(rectangle.x, rectangle.xMax, normalizedRectCoordinates.x), Mathf.Lerp(rectangle.y, rectangle.yMax, normalizedRectCoordinates.y));
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0002DE58 File Offset: 0x0002C058
		public static Vector2 PointToNormalized(Rect rectangle, Vector2 point)
		{
			return new Vector2(Mathf.InverseLerp(rectangle.x, rectangle.xMax, point.x), Mathf.InverseLerp(rectangle.y, rectangle.yMax, point.y));
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x0002DEA4 File Offset: 0x0002C0A4
		public string ToString(string format)
		{
			return this.ToString(format, null);
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x0002DEC0 File Offset: 0x0002C0C0
		public float left
		{
			get
			{
				return this.m_XMin;
			}
		}

		// Token: 0x170001AB RID: 427
		// (get) Token: 0x0600072C RID: 1836 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		public float right
		{
			get
			{
				return this.m_XMin + this.m_Width;
			}
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600072D RID: 1837 RVA: 0x0002DEF8 File Offset: 0x0002C0F8
		public float top
		{
			get
			{
				return this.m_YMin;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x0002DF10 File Offset: 0x0002C110
		public float bottom
		{
			get
			{
				return this.m_YMin + this.m_Height;
			}
		}

		// Token: 0x040005D3 RID: 1491
		private static readonly IntPtr NativeFieldInfoPtr_m_XMin;

		// Token: 0x040005D4 RID: 1492
		private static readonly IntPtr NativeFieldInfoPtr_m_YMin;

		// Token: 0x040005D5 RID: 1493
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x040005D6 RID: 1494
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x040005D7 RID: 1495
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_0;

		// Token: 0x040005D8 RID: 1496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Vector2_Vector2_0;

		// Token: 0x040005D9 RID: 1497
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Rect_0;

		// Token: 0x040005DA RID: 1498
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Rect_0;

		// Token: 0x040005DB RID: 1499
		private static readonly IntPtr NativeMethodInfoPtr_MinMaxRect_Public_Static_Rect_Single_Single_Single_Single_0;

		// Token: 0x040005DC RID: 1500
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Single_0;

		// Token: 0x040005DD RID: 1501
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Single_0;

		// Token: 0x040005DE RID: 1502
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Single_0;

		// Token: 0x040005DF RID: 1503
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Single_0;

		// Token: 0x040005E0 RID: 1504
		private static readonly IntPtr NativeMethodInfoPtr_get_position_Public_get_Vector2_0;

		// Token: 0x040005E1 RID: 1505
		private static readonly IntPtr NativeMethodInfoPtr_set_position_Public_set_Void_Vector2_0;

		// Token: 0x040005E2 RID: 1506
		private static readonly IntPtr NativeMethodInfoPtr_get_center_Public_get_Vector2_0;

		// Token: 0x040005E3 RID: 1507
		private static readonly IntPtr NativeMethodInfoPtr_set_center_Public_set_Void_Vector2_0;

		// Token: 0x040005E4 RID: 1508
		private static readonly IntPtr NativeMethodInfoPtr_get_min_Public_get_Vector2_0;

		// Token: 0x040005E5 RID: 1509
		private static readonly IntPtr NativeMethodInfoPtr_set_min_Public_set_Void_Vector2_0;

		// Token: 0x040005E6 RID: 1510
		private static readonly IntPtr NativeMethodInfoPtr_get_max_Public_get_Vector2_0;

		// Token: 0x040005E7 RID: 1511
		private static readonly IntPtr NativeMethodInfoPtr_set_max_Public_set_Void_Vector2_0;

		// Token: 0x040005E8 RID: 1512
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x040005E9 RID: 1513
		private static readonly IntPtr NativeMethodInfoPtr_set_width_Public_set_Void_Single_0;

		// Token: 0x040005EA RID: 1514
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x040005EB RID: 1515
		private static readonly IntPtr NativeMethodInfoPtr_set_height_Public_set_Void_Single_0;

		// Token: 0x040005EC RID: 1516
		private static readonly IntPtr NativeMethodInfoPtr_get_size_Public_get_Vector2_0;

		// Token: 0x040005ED RID: 1517
		private static readonly IntPtr NativeMethodInfoPtr_set_size_Public_set_Void_Vector2_0;

		// Token: 0x040005EE RID: 1518
		private static readonly IntPtr NativeMethodInfoPtr_get_xMin_Public_get_Single_0;

		// Token: 0x040005EF RID: 1519
		private static readonly IntPtr NativeMethodInfoPtr_set_xMin_Public_set_Void_Single_0;

		// Token: 0x040005F0 RID: 1520
		private static readonly IntPtr NativeMethodInfoPtr_get_yMin_Public_get_Single_0;

		// Token: 0x040005F1 RID: 1521
		private static readonly IntPtr NativeMethodInfoPtr_set_yMin_Public_set_Void_Single_0;

		// Token: 0x040005F2 RID: 1522
		private static readonly IntPtr NativeMethodInfoPtr_get_xMax_Public_get_Single_0;

		// Token: 0x040005F3 RID: 1523
		private static readonly IntPtr NativeMethodInfoPtr_set_xMax_Public_set_Void_Single_0;

		// Token: 0x040005F4 RID: 1524
		private static readonly IntPtr NativeMethodInfoPtr_get_yMax_Public_get_Single_0;

		// Token: 0x040005F5 RID: 1525
		private static readonly IntPtr NativeMethodInfoPtr_set_yMax_Public_set_Void_Single_0;

		// Token: 0x040005F6 RID: 1526
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector2_0;

		// Token: 0x040005F7 RID: 1527
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Boolean_Vector3_0;

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeMethodInfoPtr_OrderMinMax_Private_Static_Rect_Rect_0;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_0;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeMethodInfoPtr_Overlaps_Public_Boolean_Rect_Boolean_0;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Rect_Rect_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Rect_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000602 RID: 1538
		[FieldOffset(0)]
		public float m_XMin;

		// Token: 0x04000603 RID: 1539
		[FieldOffset(4)]
		public float m_YMin;

		// Token: 0x04000604 RID: 1540
		[FieldOffset(8)]
		public float m_Width;

		// Token: 0x04000605 RID: 1541
		[FieldOffset(12)]
		public float m_Height;
	}
}
