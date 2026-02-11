using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	// Token: 0x020001C0 RID: 448
	public sealed class StylePropertyName : ValueType
	{
		// Token: 0x06002348 RID: 9032 RVA: 0x0009F798 File Offset: 0x0009D998
		// Note: this type is marked as 'beforefieldinit'.
		static StylePropertyName()
		{
			Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "StylePropertyName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr);
			StylePropertyName.NativeFieldInfoPtr__id_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, "<id>k__BackingField");
			StylePropertyName.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, "<name>k__BackingField");
			StylePropertyName.NativeMethodInfoPtr_get_id_Internal_get_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668682);
			StylePropertyName.NativeMethodInfoPtr_get_name_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668683);
			StylePropertyName.NativeMethodInfoPtr_StylePropertyIdFromString_Internal_Static_StylePropertyId_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668684);
			StylePropertyName.NativeMethodInfoPtr__ctor_Internal_Void_StylePropertyId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668685);
			StylePropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668686);
			StylePropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668687);
			StylePropertyName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668688);
			StylePropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_StylePropertyName_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668689);
			StylePropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668690);
			StylePropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668691);
			StylePropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StylePropertyName_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668692);
			StylePropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr, 100668693);
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0009F8E0 File Offset: 0x0009DAE0
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyId id
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_get_id_Internal_get_StylePropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x0009F924 File Offset: 0x0009DB24
		public unsafe string name
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_get_name_Private_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0009F960 File Offset: 0x0009DB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337364, XrefRangeEnd = 337371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static UnityEngine.UIElements.StyleSheets.StylePropertyId StylePropertyIdFromString(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_StylePropertyIdFromString_Internal_Static_StylePropertyId_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0009F9A4 File Offset: 0x0009DBA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 337380, RefRangeEnd = 337384, XrefRangeStart = 337371, XrefRangeEnd = 337380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyName(UnityEngine.UIElements.StyleSheets.StylePropertyId stylePropertyId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref stylePropertyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr__ctor_Internal_Void_StylePropertyId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600234D RID: 9037 RVA: 0x0009F9F0 File Offset: 0x0009DBF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 337393, RefRangeEnd = 337397, XrefRangeStart = 337384, XrefRangeEnd = 337393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StylePropertyName(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0009FA40 File Offset: 0x0009DC40
		[CallerCount(0)]
		public unsafe static bool operator ==(StylePropertyName lhs, StylePropertyName rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0009FAA0 File Offset: 0x0009DCA0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 337397, RefRangeEnd = 337398, XrefRangeStart = 337397, XrefRangeEnd = 337397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(StylePropertyName lhs, StylePropertyName rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(lhs));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(rhs));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002350 RID: 9040 RVA: 0x0009FB00 File Offset: 0x0009DD00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337398, XrefRangeEnd = 337399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator StylePropertyName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_op_Implicit_Public_Static_StylePropertyName_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new StylePropertyName(intPtr);
			}
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0009FB3C File Offset: 0x0009DD3C
		[CallerCount(236)]
		[CachedScanResults(RefRangeStart = 283634, RefRangeEnd = 283870, XrefRangeStart = 283634, XrefRangeEnd = 283870, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0009FB80 File Offset: 0x0009DD80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 337399, XrefRangeEnd = 337402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x0009FBD4 File Offset: 0x0009DDD4
		[CallerCount(0)]
		public unsafe bool Equals(StylePropertyName other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(other));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StylePropertyName_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x0009FC2C File Offset: 0x0009DE2C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 323759, RefRangeEnd = 323772, XrefRangeStart = 323759, XrefRangeEnd = 323772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StylePropertyName.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002355 RID: 9045 RVA: 0x0000E751 File Offset: 0x0000C951
		public StylePropertyName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002356 RID: 9046 RVA: 0x0000E75A File Offset: 0x0000C95A
		public StylePropertyName()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StylePropertyName>.NativeClassPtr))
		{
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002357 RID: 9047 RVA: 0x0009FC68 File Offset: 0x0009DE68
		// (set) Token: 0x06002358 RID: 9048 RVA: 0x0000E76C File Offset: 0x0000C96C
		public unsafe UnityEngine.UIElements.StyleSheets.StylePropertyId _id_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyName.NativeFieldInfoPtr__id_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyName.NativeFieldInfoPtr__id_k__BackingField)) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002359 RID: 9049 RVA: 0x0009FC90 File Offset: 0x0009DE90
		// (set) Token: 0x0600235A RID: 9050 RVA: 0x0000E787 File Offset: 0x0000C987
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyName.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StylePropertyName.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x0009FCB8 File Offset: 0x0009DEB8
		public static bool IsNullOrEmpty(StylePropertyName propertyName)
		{
			return propertyName.id == UnityEngine.UIElements.StyleSheets.StylePropertyId.Unknown;
		}

		// Token: 0x04001946 RID: 6470
		private static readonly IntPtr NativeFieldInfoPtr__id_k__BackingField;

		// Token: 0x04001947 RID: 6471
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x04001948 RID: 6472
		private static readonly IntPtr NativeMethodInfoPtr_get_id_Internal_get_StylePropertyId_0;

		// Token: 0x04001949 RID: 6473
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Private_get_String_0;

		// Token: 0x0400194A RID: 6474
		private static readonly IntPtr NativeMethodInfoPtr_StylePropertyIdFromString_Internal_Static_StylePropertyId_String_0;

		// Token: 0x0400194B RID: 6475
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_StylePropertyId_0;

		// Token: 0x0400194C RID: 6476
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400194D RID: 6477
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0;

		// Token: 0x0400194E RID: 6478
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_StylePropertyName_StylePropertyName_0;

		// Token: 0x0400194F RID: 6479
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_StylePropertyName_String_0;

		// Token: 0x04001950 RID: 6480
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001951 RID: 6481
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001952 RID: 6482
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_StylePropertyName_0;

		// Token: 0x04001953 RID: 6483
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
