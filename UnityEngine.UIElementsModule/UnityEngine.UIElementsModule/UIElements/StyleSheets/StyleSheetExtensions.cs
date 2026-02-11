using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028E RID: 654
	public static class StyleSheetExtensions : Object
	{
		// Token: 0x060030DB RID: 12507 RVA: 0x000CF608 File Offset: 0x000CD808
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheetExtensions()
		{
			Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleSheetExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr);
			StyleSheetExtensions.NativeMethodInfoPtr_ReadAsString_Public_Static_String_StyleSheet_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr, 100670387);
			StyleSheetExtensions.NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetExtensions>.NativeClassPtr, 100670388);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000CF660 File Offset: 0x000CD860
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 358665, RefRangeEnd = 358671, XrefRangeStart = 358656, XrefRangeEnd = 358665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadAsString(this StyleSheet sheet, StyleValueHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sheet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handle;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetExtensions.NativeMethodInfoPtr_ReadAsString_Public_Static_String_StyleSheet_StyleValueHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000CF6AC File Offset: 0x000CD8AC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 358672, RefRangeEnd = 358675, XrefRangeStart = 358671, XrefRangeEnd = 358672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsVarFunction(this StyleValueHandle handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetExtensions.NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x00013F5C File Offset: 0x0001215C
		public StyleSheetExtensions(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040023A7 RID: 9127
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsString_Public_Static_String_StyleSheet_StyleValueHandle_0;

		// Token: 0x040023A8 RID: 9128
		private static readonly IntPtr NativeMethodInfoPtr_IsVarFunction_Public_Static_Boolean_StyleValueHandle_0;
	}
}
