using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.StyleSheets
{
	// Token: 0x02000283 RID: 643
	public static class StylePropertyUtil : Object
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x000CCBC0 File Offset: 0x000CADC0
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyUtil()
		{
			Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.StyleSheets", "StylePropertyUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr);
			StylePropertyUtil.NativeFieldInfoPtr_s_NameToId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, "s_NameToId");
			StylePropertyUtil.NativeFieldInfoPtr_s_IdToName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, "s_IdToName");
			StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, "s_AnimatableProperties");
			StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableWithUsageHintProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, "s_AnimatableWithUsageHintProperties");
			StylePropertyUtil.NativeMethodInfoPtr_TryGetEnumIntValue_Public_Static_Boolean_StyleEnumType_String_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, 100670298);
			StylePropertyUtil.NativeMethodInfoPtr_IsMatchingShorthand_Public_Static_Boolean_StylePropertyId_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, 100670299);
			StylePropertyUtil.NativeMethodInfoPtr_IsAnimatable_Public_Static_Boolean_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyUtil>.NativeClassPtr, 100670300);
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x000CCC7C File Offset: 0x000CAE7C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 357350, RefRangeEnd = 357357, XrefRangeStart = 357064, XrefRangeEnd = 357350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool TryGetEnumIntValue(StyleEnumType enumType, string value, out int intValue)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enumType;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &intValue;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyUtil.NativeMethodInfoPtr_TryGetEnumIntValue_Public_Static_Boolean_StyleEnumType_String_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x000CCCDC File Offset: 0x000CAEDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 357357, RefRangeEnd = 357359, XrefRangeStart = 357357, XrefRangeEnd = 357357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatchingShorthand(StylePropertyId shorthand, StylePropertyId id)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref shorthand;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref id;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyUtil.NativeMethodInfoPtr_IsMatchingShorthand_Public_Static_Boolean_StylePropertyId_StylePropertyId_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x000CCD28 File Offset: 0x000CAF28
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 357367, RefRangeEnd = 357370, XrefRangeStart = 357359, XrefRangeEnd = 357367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsAnimatable(StylePropertyId id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyUtil.NativeMethodInfoPtr_IsAnimatable_Public_Static_Boolean_StylePropertyId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003031 RID: 12337 RVA: 0x00013B3A File Offset: 0x00011D3A
		public StylePropertyUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06003032 RID: 12338 RVA: 0x000CCD68 File Offset: 0x000CAF68
		// (set) Token: 0x06003033 RID: 12339 RVA: 0x00013B43 File Offset: 0x00011D43
		public unsafe static Dictionary<string, StylePropertyId> s_NameToId
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyUtil.NativeFieldInfoPtr_s_NameToId, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, StylePropertyId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyUtil.NativeFieldInfoPtr_s_NameToId, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06003034 RID: 12340 RVA: 0x000CCD90 File Offset: 0x000CAF90
		// (set) Token: 0x06003035 RID: 12341 RVA: 0x00013B55 File Offset: 0x00011D55
		public unsafe static Dictionary<StylePropertyId, string> s_IdToName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyUtil.NativeFieldInfoPtr_s_IdToName, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StylePropertyId, string>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyUtil.NativeFieldInfoPtr_s_IdToName, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06003036 RID: 12342 RVA: 0x000CCDB8 File Offset: 0x000CAFB8
		// (set) Token: 0x06003037 RID: 12343 RVA: 0x00013B67 File Offset: 0x00011D67
		public unsafe static HashSet<StylePropertyId> s_AnimatableProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<StylePropertyId>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06003038 RID: 12344 RVA: 0x000CCDE0 File Offset: 0x000CAFE0
		// (set) Token: 0x06003039 RID: 12345 RVA: 0x00013B79 File Offset: 0x00011D79
		public unsafe static Dictionary<StylePropertyId, UsageHints> s_AnimatableWithUsageHintProperties
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableWithUsageHintProperties, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StylePropertyId, UsageHints>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StylePropertyUtil.NativeFieldInfoPtr_s_AnimatableWithUsageHintProperties, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00013B8B File Offset: 0x00011D8B
		public static IEnumerable<Type> GetAllowedAssetTypesForProperty(StylePropertyId id)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600303B RID: 12347 RVA: 0x000CCE08 File Offset: 0x000CB008
		public static IEnumerable<StylePropertyId> AllPropertyIds()
		{
			return StylePropertyUtil.s_IdToName.Keys;
		}

		// Token: 0x0400232D RID: 9005
		private static readonly IntPtr NativeFieldInfoPtr_s_NameToId;

		// Token: 0x0400232E RID: 9006
		private static readonly IntPtr NativeFieldInfoPtr_s_IdToName;

		// Token: 0x0400232F RID: 9007
		private static readonly IntPtr NativeFieldInfoPtr_s_AnimatableProperties;

		// Token: 0x04002330 RID: 9008
		private static readonly IntPtr NativeFieldInfoPtr_s_AnimatableWithUsageHintProperties;

		// Token: 0x04002331 RID: 9009
		private static readonly IntPtr NativeMethodInfoPtr_TryGetEnumIntValue_Public_Static_Boolean_StyleEnumType_String_byref_Int32_0;

		// Token: 0x04002332 RID: 9010
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingShorthand_Public_Static_Boolean_StylePropertyId_StylePropertyId_0;

		// Token: 0x04002333 RID: 9011
		private static readonly IntPtr NativeMethodInfoPtr_IsAnimatable_Public_Static_Boolean_StylePropertyId_0;

		// Token: 0x04002334 RID: 9012
		public const int k_GroupOffset = 16;
	}
}
