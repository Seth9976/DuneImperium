using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Globalization.Unicode
{
	// Token: 0x02000026 RID: 38
	public class NormalizationTableUtil : Object
	{
		// Token: 0x06000162 RID: 354 RVA: 0x0002A4DC File Offset: 0x000286DC
		// Note: this type is marked as 'beforefieldinit'.
		static NormalizationTableUtil()
		{
			Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Globalization.Unicode", "NormalizationTableUtil");
			NormalizationTableUtil.NativeFieldInfoPtr_Prop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Prop");
			NormalizationTableUtil.NativeFieldInfoPtr_Map = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Map");
			NormalizationTableUtil.NativeFieldInfoPtr_Combining = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Combining");
			NormalizationTableUtil.NativeFieldInfoPtr_Composite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Composite");
			NormalizationTableUtil.NativeFieldInfoPtr_Helper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, "Helper");
			NormalizationTableUtil.NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663520);
			NormalizationTableUtil.NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NormalizationTableUtil>.NativeClassPtr, 100663521);
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0002A590 File Offset: 0x00028790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276930, RefRangeEnd = 1276931, XrefRangeStart = 1276841, XrefRangeEnd = 1276930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int PropIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalizationTableUtil.NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0002A5D0 File Offset: 0x000287D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1276937, RefRangeEnd = 1276938, XrefRangeStart = 1276931, XrefRangeEnd = 1276937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int MapIdx(int cp)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref cp;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NormalizationTableUtil.NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000292E File Offset: 0x00000B2E
		public NormalizationTableUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0002A610 File Offset: 0x00028810
		// (set) Token: 0x06000167 RID: 359 RVA: 0x00002937 File Offset: 0x00000B37
		public unsafe static CodePointIndexer Prop
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Prop, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Prop, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0002A638 File Offset: 0x00028838
		// (set) Token: 0x06000169 RID: 361 RVA: 0x00002949 File Offset: 0x00000B49
		public unsafe static CodePointIndexer Map
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Map, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Map, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0002A660 File Offset: 0x00028860
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000295B File Offset: 0x00000B5B
		public unsafe static CodePointIndexer Combining
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Combining, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Combining, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0002A688 File Offset: 0x00028888
		// (set) Token: 0x0600016D RID: 365 RVA: 0x0000296D File Offset: 0x00000B6D
		public unsafe static CodePointIndexer Composite
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Composite, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Composite, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0002A6B0 File Offset: 0x000288B0
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000297F File Offset: 0x00000B7F
		public unsafe static CodePointIndexer Helper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(NormalizationTableUtil.NativeFieldInfoPtr_Helper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CodePointIndexer>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NormalizationTableUtil.NativeFieldInfoPtr_Helper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeFieldInfoPtr_Prop;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeFieldInfoPtr_Map;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeFieldInfoPtr_Combining;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeFieldInfoPtr_Composite;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeFieldInfoPtr_Helper;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_PropIdx_Public_Static_Int32_Int32_0;

		// Token: 0x040000F6 RID: 246
		private static readonly IntPtr NativeMethodInfoPtr_MapIdx_Public_Static_Int32_Int32_0;
	}
}
