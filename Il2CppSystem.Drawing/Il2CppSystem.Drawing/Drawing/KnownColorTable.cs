using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Drawing
{
	// Token: 0x02000004 RID: 4
	public static class KnownColorTable : Object
	{
		// Token: 0x06000006 RID: 6 RVA: 0x0000224C File Offset: 0x0000044C
		// Note: this type is marked as 'beforefieldinit'.
		static KnownColorTable()
		{
			Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Drawing.dll", "System.Drawing", "KnownColorTable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr);
			KnownColorTable.NativeFieldInfoPtr_s_colorTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, "s_colorTable");
			KnownColorTable.NativeFieldInfoPtr_s_colorNameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, "s_colorNameTable");
			KnownColorTable.NativeMethodInfoPtr_EnsureColorTable_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663299);
			KnownColorTable.NativeMethodInfoPtr_InitColorTable_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663300);
			KnownColorTable.NativeMethodInfoPtr_EnsureColorNameTable_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663301);
			KnownColorTable.NativeMethodInfoPtr_InitColorNameTable_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663302);
			KnownColorTable.NativeMethodInfoPtr_KnownColorToArgb_Public_Static_Int32_KnownColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663303);
			KnownColorTable.NativeMethodInfoPtr_KnownColorToName_Public_Static_String_KnownColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663304);
			KnownColorTable.NativeMethodInfoPtr_UpdateSystemColors_Private_Static_Void_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownColorTable>.NativeClassPtr, 100663305);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002330 File Offset: 0x00000530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226511, XrefRangeEnd = 1226514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureColorTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_EnsureColorTable_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002358 File Offset: 0x00000558
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1226524, RefRangeEnd = 1226526, XrefRangeStart = 1226514, XrefRangeEnd = 1226524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitColorTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_InitColorTable_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002380 File Offset: 0x00000580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1226526, XrefRangeEnd = 1226529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureColorNameTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_EnsureColorNameTable_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023A8 File Offset: 0x000005A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1227061, RefRangeEnd = 1227064, XrefRangeStart = 1226529, XrefRangeEnd = 1227061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitColorNameTable()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_InitColorNameTable_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023D0 File Offset: 0x000005D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227064, XrefRangeEnd = 1227069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int KnownColorToArgb(KnownColor color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_KnownColorToArgb_Public_Static_Int32_KnownColor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002410 File Offset: 0x00000610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1227069, XrefRangeEnd = 1227074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string KnownColorToName(KnownColor color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_KnownColorToName_Public_Static_String_KnownColor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002448 File Offset: 0x00000648
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1227074, RefRangeEnd = 1227075, XrefRangeStart = 1227074, XrefRangeEnd = 1227074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateSystemColors(Il2CppStructArray<int> colorTable)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(colorTable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownColorTable.NativeMethodInfoPtr_UpdateSystemColors_Private_Static_Void_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002067 File Offset: 0x00000267
		public KnownColorTable(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002480 File Offset: 0x00000680
		// (set) Token: 0x06000010 RID: 16 RVA: 0x00002070 File Offset: 0x00000270
		public unsafe static Il2CppStructArray<int> s_colorTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownColorTable.NativeFieldInfoPtr_s_colorTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownColorTable.NativeFieldInfoPtr_s_colorTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000011 RID: 17 RVA: 0x000024A8 File Offset: 0x000006A8
		// (set) Token: 0x06000012 RID: 18 RVA: 0x00002082 File Offset: 0x00000282
		public unsafe static Il2CppStringArray s_colorNameTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(KnownColorTable.NativeFieldInfoPtr_s_colorNameTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(KnownColorTable.NativeFieldInfoPtr_s_colorNameTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000B2 RID: 178
		private static readonly IntPtr NativeFieldInfoPtr_s_colorTable;

		// Token: 0x040000B3 RID: 179
		private static readonly IntPtr NativeFieldInfoPtr_s_colorNameTable;

		// Token: 0x040000B4 RID: 180
		private static readonly IntPtr NativeMethodInfoPtr_EnsureColorTable_Private_Static_Void_0;

		// Token: 0x040000B5 RID: 181
		private static readonly IntPtr NativeMethodInfoPtr_InitColorTable_Private_Static_Void_0;

		// Token: 0x040000B6 RID: 182
		private static readonly IntPtr NativeMethodInfoPtr_EnsureColorNameTable_Private_Static_Void_0;

		// Token: 0x040000B7 RID: 183
		private static readonly IntPtr NativeMethodInfoPtr_InitColorNameTable_Private_Static_Void_0;

		// Token: 0x040000B8 RID: 184
		private static readonly IntPtr NativeMethodInfoPtr_KnownColorToArgb_Public_Static_Int32_KnownColor_0;

		// Token: 0x040000B9 RID: 185
		private static readonly IntPtr NativeMethodInfoPtr_KnownColorToName_Public_Static_String_KnownColor_0;

		// Token: 0x040000BA RID: 186
		private static readonly IntPtr NativeMethodInfoPtr_UpdateSystemColors_Private_Static_Void_Il2CppStructArray_1_Int32_0;
	}
}
