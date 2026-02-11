using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000058 RID: 88
	public static class EnumFieldHelpers : Object
	{
		// Token: 0x060007F7 RID: 2039 RVA: 0x000397DC File Offset: 0x000379DC
		// Note: this type is marked as 'beforefieldinit'.
		static EnumFieldHelpers()
		{
			Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "EnumFieldHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr);
			EnumFieldHelpers.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr, "type");
			EnumFieldHelpers.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr, "value");
			EnumFieldHelpers.NativeFieldInfoPtr_includeObsoleteValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr, "includeObsoleteValues");
			EnumFieldHelpers.NativeMethodInfoPtr_ExtractValue_Internal_Static_Boolean_IUxmlAttributes_CreationContext_byref_Type_byref_Enum_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnumFieldHelpers>.NativeClassPtr, 100664457);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0003985C File Offset: 0x00037A5C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 293792, RefRangeEnd = 293793, XrefRangeStart = 293761, XrefRangeEnd = 293792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool ExtractValue(IUxmlAttributes bag, CreationContext cc, out Type resEnumType, out Enum resEnumValue, out bool resIncludeObsoleteValues)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resEnumValue;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &resIncludeObsoleteValues;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(EnumFieldHelpers.NativeMethodInfoPtr_ExtractValue_Internal_Static_Boolean_IUxmlAttributes_CreationContext_byref_Type_byref_Enum_byref_Boolean_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			resEnumType = ((intPtr4 == 0) ? null : new Type(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00004C07 File Offset: 0x00002E07
		public EnumFieldHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000398F4 File Offset: 0x00037AF4
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x00004C10 File Offset: 0x00002E10
		public unsafe static UxmlTypeAttributeDescription<Enum> type
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumFieldHelpers.NativeFieldInfoPtr_type, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlTypeAttributeDescription<Enum>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumFieldHelpers.NativeFieldInfoPtr_type, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x0003991C File Offset: 0x00037B1C
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00004C22 File Offset: 0x00002E22
		public unsafe static UxmlStringAttributeDescription value
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumFieldHelpers.NativeFieldInfoPtr_value, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlStringAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumFieldHelpers.NativeFieldInfoPtr_value, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00039944 File Offset: 0x00037B44
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00004C34 File Offset: 0x00002E34
		public unsafe static UxmlBoolAttributeDescription includeObsoleteValues
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(EnumFieldHelpers.NativeFieldInfoPtr_includeObsoleteValues, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlBoolAttributeDescription>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(EnumFieldHelpers.NativeFieldInfoPtr_includeObsoleteValues, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005A3 RID: 1443
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040005A4 RID: 1444
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x040005A5 RID: 1445
		private static readonly IntPtr NativeFieldInfoPtr_includeObsoleteValues;

		// Token: 0x040005A6 RID: 1446
		private static readonly IntPtr NativeMethodInfoPtr_ExtractValue_Internal_Static_Boolean_IUxmlAttributes_CreationContext_byref_Type_byref_Enum_byref_Boolean_0;
	}
}
