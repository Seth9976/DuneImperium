using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028A RID: 650
	public sealed class SelectorMatchRecord : ValueType
	{
		// Token: 0x060030B9 RID: 12473 RVA: 0x000CEE90 File Offset: 0x000CD090
		// Note: this type is marked as 'beforefieldinit'.
		static SelectorMatchRecord()
		{
			Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "SelectorMatchRecord");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr);
			SelectorMatchRecord.NativeFieldInfoPtr_sheet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr, "sheet");
			SelectorMatchRecord.NativeFieldInfoPtr_styleSheetIndexInStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr, "styleSheetIndexInStack");
			SelectorMatchRecord.NativeFieldInfoPtr_complexSelector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr, "complexSelector");
			SelectorMatchRecord.NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr, 100670370);
			SelectorMatchRecord.NativeMethodInfoPtr_Compare_Public_Static_Int32_SelectorMatchRecord_SelectorMatchRecord_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr, 100670371);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000CEF24 File Offset: 0x000CD124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 358463, XrefRangeEnd = 358464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SelectorMatchRecord(StyleSheet sheet, int styleSheetIndexInStack)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref styleSheetIndexInStack;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorMatchRecord.NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000CEF84 File Offset: 0x000CD184
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358471, RefRangeEnd = 358472, XrefRangeStart = 358464, XrefRangeEnd = 358471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(SelectorMatchRecord a, SelectorMatchRecord b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(a));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(b));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SelectorMatchRecord.NativeMethodInfoPtr_Compare_Public_Static_Int32_SelectorMatchRecord_SelectorMatchRecord_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030BC RID: 12476 RVA: 0x00013E89 File Offset: 0x00012089
		public SelectorMatchRecord(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060030BD RID: 12477 RVA: 0x00013E92 File Offset: 0x00012092
		public SelectorMatchRecord()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SelectorMatchRecord>.NativeClassPtr))
		{
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x060030BE RID: 12478 RVA: 0x000CEFE4 File Offset: 0x000CD1E4
		// (set) Token: 0x060030BF RID: 12479 RVA: 0x00013EA4 File Offset: 0x000120A4
		public unsafe StyleSheet sheet
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_sheet);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleSheet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_sheet), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x060030C0 RID: 12480 RVA: 0x000CF014 File Offset: 0x000CD214
		// (set) Token: 0x060030C1 RID: 12481 RVA: 0x00013EC3 File Offset: 0x000120C3
		public unsafe int styleSheetIndexInStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_styleSheetIndexInStack);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_styleSheetIndexInStack)) = value;
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x060030C2 RID: 12482 RVA: 0x000CF03C File Offset: 0x000CD23C
		// (set) Token: 0x060030C3 RID: 12483 RVA: 0x00013EDE File Offset: 0x000120DE
		public unsafe StyleComplexSelector complexSelector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_complexSelector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StyleComplexSelector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SelectorMatchRecord.NativeFieldInfoPtr_complexSelector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002396 RID: 9110
		private static readonly IntPtr NativeFieldInfoPtr_sheet;

		// Token: 0x04002397 RID: 9111
		private static readonly IntPtr NativeFieldInfoPtr_styleSheetIndexInStack;

		// Token: 0x04002398 RID: 9112
		private static readonly IntPtr NativeFieldInfoPtr_complexSelector;

		// Token: 0x04002399 RID: 9113
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StyleSheet_Int32_0;

		// Token: 0x0400239A RID: 9114
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Public_Static_Int32_SelectorMatchRecord_SelectorMatchRecord_0;
	}
}
