using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000004 RID: 4
	[Serializable]
	[StructLayout(2)]
	public struct GlyphRect
	{
		// Token: 0x06000059 RID: 89 RVA: 0x0000412C File Offset: 0x0000232C
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphRect()
		{
			Il2CppClassPointerStore<GlyphRect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "GlyphRect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr);
			GlyphRect.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_X");
			GlyphRect.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Y");
			GlyphRect.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Width");
			GlyphRect.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "m_Height");
			GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, "s_ZeroGlyphRect");
			GlyphRect.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663335);
			GlyphRect.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663336);
			GlyphRect.NativeMethodInfoPtr_get_width_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663337);
			GlyphRect.NativeMethodInfoPtr_get_height_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663338);
			GlyphRect.NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663339);
			GlyphRect.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663340);
			GlyphRect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663341);
			GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663342);
			GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, 100663343);
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004274 File Offset: 0x00002474
		// (set) Token: 0x06000066 RID: 102 RVA: 0x000022DE File Offset: 0x000004DE
		public unsafe int x
		{
			[CallerCount(236)]
			[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600005B RID: 91 RVA: 0x000042A4 File Offset: 0x000024A4
		// (set) Token: 0x06000067 RID: 103 RVA: 0x000022E8 File Offset: 0x000004E8
		public unsafe int y
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 283125, RefRangeEnd = 283150, XrefRangeStart = 283125, XrefRangeEnd = 283150, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600005C RID: 92 RVA: 0x000042D4 File Offset: 0x000024D4
		// (set) Token: 0x06000068 RID: 104 RVA: 0x000022F2 File Offset: 0x000004F2
		public unsafe int width
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_width_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00004304 File Offset: 0x00002504
		// (set) Token: 0x06000069 RID: 105 RVA: 0x000022FC File Offset: 0x000004FC
		public unsafe int height
		{
			[CallerCount(85)]
			[CachedScanResults(RefRangeStart = 643827, RefRangeEnd = 643912, XrefRangeStart = 643827, XrefRangeEnd = 643912, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_height_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004334 File Offset: 0x00002534
		public unsafe static GlyphRect zero
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1252769, RefRangeEnd = 1252770, XrefRangeStart = 1252765, XrefRangeEnd = 1252769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004364 File Offset: 0x00002564
		[CallerCount(27)]
		[CachedScanResults(RefRangeStart = 608741, RefRangeEnd = 608768, XrefRangeStart = 608741, XrefRangeEnd = 608768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphRect(int x, int y, int width, int height)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000043C0 File Offset: 0x000025C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252770, XrefRangeEnd = 1252774, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000043F0 File Offset: 0x000025F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252774, XrefRangeEnd = 1252778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004434 File Offset: 0x00002634
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252778, XrefRangeEnd = 1252784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphRect other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphRect.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000022BE File Offset: 0x000004BE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphRect>.NativeClassPtr, ref this));
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00004474 File Offset: 0x00002674
		// (set) Token: 0x06000065 RID: 101 RVA: 0x000022D0 File Offset: 0x000004D0
		public unsafe static GlyphRect s_ZeroGlyphRect
		{
			get
			{
				GlyphRect glyphRect;
				IL2CPP.il2cpp_field_static_get_value(GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect, (void*)(&glyphRect));
				return glyphRect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GlyphRect.NativeFieldInfoPtr_s_ZeroGlyphRect, (void*)(&value));
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004490 File Offset: 0x00002690
		public static bool operator ==(GlyphRect lhs, GlyphRect rhs)
		{
			return lhs.x == rhs.x && lhs.y == rhs.y && lhs.width == rhs.width && lhs.height == rhs.height;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000044E8 File Offset: 0x000026E8
		public static bool operator !=(GlyphRect lhs, GlyphRect rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeFieldInfoPtr_s_ZeroGlyphRect;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Int32_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Int32_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_GlyphRect_0;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_Int32_0;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphRect_0;

		// Token: 0x04000050 RID: 80
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04000051 RID: 81
		[FieldOffset(4)]
		public int m_Y;

		// Token: 0x04000052 RID: 82
		[FieldOffset(8)]
		public int m_Width;

		// Token: 0x04000053 RID: 83
		[FieldOffset(12)]
		public int m_Height;
	}
}
