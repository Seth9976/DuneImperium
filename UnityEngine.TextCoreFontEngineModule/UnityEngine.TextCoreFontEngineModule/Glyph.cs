using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore
{
	// Token: 0x02000006 RID: 6
	[Serializable]
	public class Glyph : Object
	{
		// Token: 0x0600007E RID: 126 RVA: 0x000048E0 File Offset: 0x00002AE0
		// Note: this type is marked as 'beforefieldinit'.
		static Glyph()
		{
			Il2CppClassPointerStore<Glyph>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.TextCoreFontEngineModule.dll", "UnityEngine.TextCore", "Glyph");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Glyph>.NativeClassPtr);
			Glyph.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Index");
			Glyph.NativeFieldInfoPtr_m_Metrics = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Metrics");
			Glyph.NativeFieldInfoPtr_m_GlyphRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_GlyphRect");
			Glyph.NativeFieldInfoPtr_m_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_Scale");
			Glyph.NativeFieldInfoPtr_m_AtlasIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_AtlasIndex");
			Glyph.NativeFieldInfoPtr_m_ClassDefinitionType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Glyph>.NativeClassPtr, "m_ClassDefinitionType");
			Glyph.NativeMethodInfoPtr_get_index_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663354);
			Glyph.NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663355);
			Glyph.NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663356);
			Glyph.NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663357);
			Glyph.NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663358);
			Glyph.NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663359);
			Glyph.NativeMethodInfoPtr_get_scale_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663360);
			Glyph.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663361);
			Glyph.NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663362);
			Glyph.NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663363);
			Glyph.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663364);
			Glyph.NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663365);
			Glyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Glyph>.NativeClassPtr, 100663366);
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00004A8C File Offset: 0x00002C8C
		// (set) Token: 0x06000080 RID: 128 RVA: 0x00004AC8 File Offset: 0x00002CC8
		public unsafe uint index
		{
			[CallerCount(42)]
			[CachedScanResults(RefRangeStart = 334600, RefRangeEnd = 334642, XrefRangeStart = 334600, XrefRangeEnd = 334642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_index_Public_get_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307807, RefRangeEnd = 307812, XrefRangeStart = 307807, XrefRangeEnd = 307812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00004B08 File Offset: 0x00002D08
		// (set) Token: 0x06000082 RID: 130 RVA: 0x00004B44 File Offset: 0x00002D44
		public unsafe GlyphMetrics metrics
		{
			[CallerCount(38)]
			[CachedScanResults(RefRangeStart = 1252817, RefRangeEnd = 1252855, XrefRangeStart = 1252817, XrefRangeEnd = 1252817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1252855, RefRangeEnd = 1252859, XrefRangeStart = 1252855, XrefRangeEnd = 1252855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000083 RID: 131 RVA: 0x00004B84 File Offset: 0x00002D84
		// (set) Token: 0x06000084 RID: 132 RVA: 0x00004BC0 File Offset: 0x00002DC0
		public unsafe GlyphRect glyphRect
		{
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 1221101, RefRangeEnd = 1221119, XrefRangeStart = 1221101, XrefRangeEnd = 1221119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 755145, RefRangeEnd = 755149, XrefRangeStart = 755145, XrefRangeEnd = 755149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00004C00 File Offset: 0x00002E00
		// (set) Token: 0x06000086 RID: 134 RVA: 0x00004C3C File Offset: 0x00002E3C
		public unsafe float scale
		{
			[CallerCount(45)]
			[CachedScanResults(RefRangeStart = 1032702, RefRangeEnd = 1032747, XrefRangeStart = 1032702, XrefRangeEnd = 1032747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_scale_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 850305, RefRangeEnd = 850310, XrefRangeStart = 850305, XrefRangeEnd = 850310, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00004C7C File Offset: 0x00002E7C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x00004CB8 File Offset: 0x00002EB8
		public unsafe int atlasIndex
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 1252859, RefRangeEnd = 1252865, XrefRangeStart = 1252859, XrefRangeEnd = 1252859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 135903, RefRangeEnd = 135917, XrefRangeStart = 135903, XrefRangeEnd = 135917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 1252866, RefRangeEnd = 1252872, XrefRangeStart = 1252865, XrefRangeEnd = 1252866, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004D34 File Offset: 0x00002F34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1252872, XrefRangeEnd = 1252873, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph(GlyphMarshallingStruct glyphStruct)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref glyphStruct;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004D7C File Offset: 0x00002F7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1252874, RefRangeEnd = 1252875, XrefRangeStart = 1252873, XrefRangeEnd = 1252874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Glyph(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Glyph>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref metrics;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref glyphRect;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref scale;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref atlasIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Glyph.NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000234A File Offset: 0x0000054A
		public Glyph(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00004DFC File Offset: 0x00002FFC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002353 File Offset: 0x00000553
		public unsafe uint m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00004E24 File Offset: 0x00003024
		// (set) Token: 0x06000090 RID: 144 RVA: 0x0000236E File Offset: 0x0000056E
		public unsafe GlyphMetrics m_Metrics
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Metrics);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Metrics)) = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004E4C File Offset: 0x0000304C
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00002389 File Offset: 0x00000589
		public unsafe GlyphRect m_GlyphRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_GlyphRect);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_GlyphRect)) = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004E74 File Offset: 0x00003074
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000023A4 File Offset: 0x000005A4
		public unsafe float m_Scale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Scale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_Scale)) = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004E9C File Offset: 0x0000309C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x000023BF File Offset: 0x000005BF
		public unsafe int m_AtlasIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_AtlasIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_AtlasIndex)) = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00004EC4 File Offset: 0x000030C4
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000023DA File Offset: 0x000005DA
		public unsafe GlyphClassDefinitionType m_ClassDefinitionType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_ClassDefinitionType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Glyph.NativeFieldInfoPtr_m_ClassDefinitionType)) = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00004EEC File Offset: 0x000030EC
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000023F5 File Offset: 0x000005F5
		public GlyphClassDefinitionType classDefinitionType
		{
			get
			{
				return this.m_ClassDefinitionType;
			}
			set
			{
				this.m_ClassDefinitionType = value;
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00004F04 File Offset: 0x00003104
		public bool Compare(Glyph other)
		{
			return this.index == other.index && this.metrics == other.metrics && this.glyphRect == other.glyphRect && this.scale == other.scale && this.atlasIndex == other.atlasIndex;
		}

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeFieldInfoPtr_m_Metrics;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeFieldInfoPtr_m_GlyphRect;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeFieldInfoPtr_m_Scale;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasIndex;

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_m_ClassDefinitionType;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeMethodInfoPtr_get_index_Public_get_UInt32_0;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeMethodInfoPtr_set_index_Public_set_Void_UInt32_0;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeMethodInfoPtr_get_metrics_Public_get_GlyphMetrics_0;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeMethodInfoPtr_set_metrics_Public_set_Void_GlyphMetrics_0;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeMethodInfoPtr_get_glyphRect_Public_get_GlyphRect_0;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeMethodInfoPtr_set_glyphRect_Public_set_Void_GlyphRect_0;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeMethodInfoPtr_get_scale_Public_get_Single_0;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeMethodInfoPtr_set_scale_Public_set_Void_Single_0;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeMethodInfoPtr_get_atlasIndex_Public_get_Int32_0;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeMethodInfoPtr_set_atlasIndex_Public_set_Void_Int32_0;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_GlyphMarshallingStruct_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UInt32_GlyphMetrics_GlyphRect_Single_Int32_0;
	}
}
