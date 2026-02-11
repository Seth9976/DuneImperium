using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.TextCore
{
	// Token: 0x02000005 RID: 5
	[Serializable]
	[StructLayout(2)]
	public struct GlyphMetrics
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00004504 File Offset: 0x00002704
		// Note: this type is marked as 'beforefieldinit'.
		static GlyphMetrics()
		{
			Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "GlyphMetrics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr);
			GlyphMetrics.NativeFieldInfoPtr_m_Width = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_Width");
			GlyphMetrics.NativeFieldInfoPtr_m_Height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_Height");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalBearingX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalBearingX");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalBearingY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalBearingY");
			GlyphMetrics.NativeFieldInfoPtr_m_HorizontalAdvance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, "m_HorizontalAdvance");
			GlyphMetrics.NativeMethodInfoPtr_get_width_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663345);
			GlyphMetrics.NativeMethodInfoPtr_get_height_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663346);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663347);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663348);
			GlyphMetrics.NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663349);
			GlyphMetrics.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663350);
			GlyphMetrics.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663351);
			GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663352);
			GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, 100663353);
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x0600006D RID: 109 RVA: 0x0000464C File Offset: 0x0000284C
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002318 File Offset: 0x00000518
		public unsafe float width
		{
			[CallerCount(58)]
			[CachedScanResults(RefRangeStart = 283150, RefRangeEnd = 283208, XrefRangeStart = 283150, XrefRangeEnd = 283208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_width_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Width = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600006E RID: 110 RVA: 0x0000467C File Offset: 0x0000287C
		// (set) Token: 0x06000078 RID: 120 RVA: 0x00002322 File Offset: 0x00000522
		public unsafe float height
		{
			[CallerCount(48)]
			[CachedScanResults(RefRangeStart = 644349, RefRangeEnd = 644397, XrefRangeStart = 644349, XrefRangeEnd = 644397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_height_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Height = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600006F RID: 111 RVA: 0x000046AC File Offset: 0x000028AC
		// (set) Token: 0x06000079 RID: 121 RVA: 0x0000232C File Offset: 0x0000052C
		public unsafe float horizontalBearingX
		{
			[CallerCount(26)]
			[CachedScanResults(RefRangeStart = 644403, RefRangeEnd = 644429, XrefRangeStart = 644403, XrefRangeEnd = 644429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalBearingX = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000070 RID: 112 RVA: 0x000046DC File Offset: 0x000028DC
		// (set) Token: 0x0600007A RID: 122 RVA: 0x00002336 File Offset: 0x00000536
		public unsafe float horizontalBearingY
		{
			[CallerCount(25)]
			[CachedScanResults(RefRangeStart = 644431, RefRangeEnd = 644456, XrefRangeStart = 644431, XrefRangeEnd = 644456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalBearingY = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000071 RID: 113 RVA: 0x0000470C File Offset: 0x0000290C
		// (set) Token: 0x0600007B RID: 123 RVA: 0x00002340 File Offset: 0x00000540
		public unsafe float horizontalAdvance
		{
			[CallerCount(16)]
			[CachedScanResults(RefRangeStart = 1252784, RefRangeEnd = 1252800, XrefRangeStart = 1252784, XrefRangeEnd = 1252784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_HorizontalAdvance = value;
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000473C File Offset: 0x0000293C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1252800, RefRangeEnd = 1252803, XrefRangeStart = 1252800, XrefRangeEnd = 1252800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GlyphMetrics(float width, float height, float bearingX, float bearingY, float advance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref width;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearingX;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bearingY;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref advance;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000047A8 File Offset: 0x000029A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252803, XrefRangeEnd = 1252807, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000047D8 File Offset: 0x000029D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252807, XrefRangeEnd = 1252811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000481C File Offset: 0x00002A1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252811, XrefRangeEnd = 1252817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(GlyphMetrics other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GlyphMetrics.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002306 File Offset: 0x00000506
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<GlyphMetrics>.NativeClassPtr, ref this));
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000485C File Offset: 0x00002A5C
		public static bool operator ==(GlyphMetrics lhs, GlyphMetrics rhs)
		{
			return lhs.width == rhs.width && lhs.height == rhs.height && lhs.horizontalBearingX == rhs.horizontalBearingX && lhs.horizontalBearingY == rhs.horizontalBearingY && lhs.horizontalAdvance == rhs.horizontalAdvance;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000048C4 File Offset: 0x00002AC4
		public static bool operator !=(GlyphMetrics lhs, GlyphMetrics rhs)
		{
			return !(lhs == rhs);
		}

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeFieldInfoPtr_m_Width;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeFieldInfoPtr_m_Height;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalBearingX;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalBearingY;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeFieldInfoPtr_m_HorizontalAdvance;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_width_Public_get_Single_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_height_Public_get_Single_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalBearingX_Public_get_Single_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalBearingY_Public_get_Single_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_horizontalAdvance_Public_get_Single_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_Single_Single_Single_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_GlyphMetrics_0;

		// Token: 0x04000062 RID: 98
		[FieldOffset(0)]
		public float m_Width;

		// Token: 0x04000063 RID: 99
		[FieldOffset(4)]
		public float m_Height;

		// Token: 0x04000064 RID: 100
		[FieldOffset(8)]
		public float m_HorizontalBearingX;

		// Token: 0x04000065 RID: 101
		[FieldOffset(12)]
		public float m_HorizontalBearingY;

		// Token: 0x04000066 RID: 102
		[FieldOffset(16)]
		public float m_HorizontalAdvance;
	}
}
