using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x0200028D RID: 653
	public static class StyleSheetColor : Object
	{
		// Token: 0x060030D5 RID: 12501 RVA: 0x000CF4E4 File Offset: 0x000CD6E4
		// Note: this type is marked as 'beforefieldinit'.
		static StyleSheetColor()
		{
			Il2CppClassPointerStore<StyleSheetColor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StyleSheetColor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StyleSheetColor>.NativeClassPtr);
			StyleSheetColor.NativeFieldInfoPtr_s_NameToColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StyleSheetColor>.NativeClassPtr, "s_NameToColor");
			StyleSheetColor.NativeMethodInfoPtr_TryGetColor_Public_Static_Boolean_String_byref_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetColor>.NativeClassPtr, 100670384);
			StyleSheetColor.NativeMethodInfoPtr_HexToColor32_Private_Static_Color32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StyleSheetColor>.NativeClassPtr, 100670385);
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000CF550 File Offset: 0x000CD750
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 358655, RefRangeEnd = 358656, XrefRangeStart = 358648, XrefRangeEnd = 358655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetColor(string name, out Color color)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetColor.NativeMethodInfoPtr_TryGetColor_Public_Static_Boolean_String_byref_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000CF5A0 File Offset: 0x000CD7A0
		[CallerCount(0)]
		public unsafe static Color32 HexToColor32(uint color)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StyleSheetColor.NativeMethodInfoPtr_HexToColor32_Private_Static_Color32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x00013F41 File Offset: 0x00012141
		public StyleSheetColor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000CF5E0 File Offset: 0x000CD7E0
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x00013F4A File Offset: 0x0001214A
		public unsafe static Dictionary<string, Color32> s_NameToColor
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StyleSheetColor.NativeFieldInfoPtr_s_NameToColor, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Color32>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StyleSheetColor.NativeFieldInfoPtr_s_NameToColor, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040023A4 RID: 9124
		private static readonly IntPtr NativeFieldInfoPtr_s_NameToColor;

		// Token: 0x040023A5 RID: 9125
		private static readonly IntPtr NativeMethodInfoPtr_TryGetColor_Public_Static_Boolean_String_byref_Color_0;

		// Token: 0x040023A6 RID: 9126
		private static readonly IntPtr NativeMethodInfoPtr_HexToColor32_Private_Static_Color32_UInt32_0;
	}
}
