using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F5 RID: 501
	public class UxmlAttributeDescription : Object
	{
		// Token: 0x06002776 RID: 10102 RVA: 0x000ADCE4 File Offset: 0x000ABEE4
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlAttributeDescription");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr);
			UxmlAttributeDescription.NativeFieldInfoPtr__name_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "<name>k__BackingField");
			UxmlAttributeDescription.NativeFieldInfoPtr_m_ObsoleteNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "m_ObsoleteNames");
			UxmlAttributeDescription.NativeFieldInfoPtr__type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "<type>k__BackingField");
			UxmlAttributeDescription.NativeFieldInfoPtr__typeNamespace_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "<typeNamespace>k__BackingField");
			UxmlAttributeDescription.NativeFieldInfoPtr__use_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "<use>k__BackingField");
			UxmlAttributeDescription.NativeFieldInfoPtr__restriction_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, "<restriction>k__BackingField");
			UxmlAttributeDescription.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669229);
			UxmlAttributeDescription.NativeMethodInfoPtr_get_name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669230);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669231);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_obsoleteNames_Public_set_Void_IEnumerable_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669232);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_type_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669233);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_typeNamespace_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669234);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_use_Public_set_Void_Use_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669235);
			UxmlAttributeDescription.NativeMethodInfoPtr_set_restriction_Public_set_Void_UxmlTypeRestriction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669236);
			UxmlAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBagAsString_Internal_Boolean_IUxmlAttributes_CreationContext_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669237);
			UxmlAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Protected_Boolean_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_byref_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669238);
			UxmlAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Protected_T_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr, 100669239);
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000ADE68 File Offset: 0x000AC068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343168, RefRangeEnd = 343170, XrefRangeStart = 343166, XrefRangeEnd = 343168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x000ADEA4 File Offset: 0x000AC0A4
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x000ADEDC File Offset: 0x000AC0DC
		public unsafe string name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_get_name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x000AE398 File Offset: 0x000AC598
		// (set) Token: 0x0600277A RID: 10106 RVA: 0x000ADF20 File Offset: 0x000AC120
		public unsafe IEnumerable<string> obsoleteNames
		{
			get
			{
				return this.m_ObsoleteNames;
			}
			[CallerCount(9)]
			[CachedScanResults(RefRangeStart = 343174, RefRangeEnd = 343183, XrefRangeStart = 343170, XrefRangeEnd = 343174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_obsoleteNames_Public_set_Void_IEnumerable_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06002790 RID: 10128 RVA: 0x00010170 File Offset: 0x0000E370
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x000ADF64 File Offset: 0x000AC164
		public unsafe string type
		{
			get
			{
				return this._type_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_type_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06002791 RID: 10129 RVA: 0x00010178 File Offset: 0x0000E378
		// (set) Token: 0x0600277C RID: 10108 RVA: 0x000ADFA8 File Offset: 0x000AC1A8
		public unsafe string typeNamespace
		{
			get
			{
				return this._typeNamespace_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_typeNamespace_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x00010180 File Offset: 0x0000E380
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x000ADFEC File Offset: 0x000AC1EC
		public unsafe UxmlAttributeDescription.Use use
		{
			get
			{
				return this._use_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137951, RefRangeEnd = 137952, XrefRangeStart = 137951, XrefRangeEnd = 137952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_use_Public_set_Void_Use_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x06002793 RID: 10131 RVA: 0x00010188 File Offset: 0x0000E388
		// (set) Token: 0x0600277E RID: 10110 RVA: 0x000AE02C File Offset: 0x000AC22C
		public unsafe UxmlTypeRestriction restriction
		{
			get
			{
				return this._restriction_k__BackingField;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_set_restriction_Public_set_Void_UxmlTypeRestriction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000AE070 File Offset: 0x000AC270
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343243, RefRangeEnd = 343245, XrefRangeStart = 343183, XrefRangeEnd = 343243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueFromBagAsString(IUxmlAttributes bag, CreationContext cc, out string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBagAsString_Internal_Boolean_IUxmlAttributes_CreationContext_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			value = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x000AE0F0 File Offset: 0x000AC2F0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 343249, RefRangeEnd = 343251, XrefRangeStart = 343245, XrefRangeEnd = 343249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool TryGetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue, ref T value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converterFunc);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.MethodInfoStoreGeneric_TryGetValueFromBag_Protected_Boolean_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_byref_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			IntPtr intPtr5 = intPtr2;
			value = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<T>(intPtr5, false, false));
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x000AE1DC File Offset: 0x000AC3DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 343253, RefRangeEnd = 343254, XrefRangeStart = 343251, XrefRangeEnd = 343253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetValueFromBag<T>(IUxmlAttributes bag, CreationContext cc, Func<string, T, T> converterFunc, T defaultValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(converterFunc);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = defaultValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref defaultValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(UxmlAttributeDescription.MethodInfoStoreGeneric_GetValueFromBag_Protected_T_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return IL2CPP.PointerToValueGeneric<T>(intPtr2, false, true);
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x000100B1 File Offset: 0x0000E2B1
		public UxmlAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C61 RID: 3169
		// (get) Token: 0x06002783 RID: 10115 RVA: 0x000AE298 File Offset: 0x000AC498
		// (set) Token: 0x06002784 RID: 10116 RVA: 0x000100BA File Offset: 0x0000E2BA
		public unsafe string _name_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__name_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__name_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C62 RID: 3170
		// (get) Token: 0x06002785 RID: 10117 RVA: 0x000AE2C0 File Offset: 0x000AC4C0
		// (set) Token: 0x06002786 RID: 10118 RVA: 0x000100D9 File Offset: 0x0000E2D9
		public unsafe Il2CppStringArray m_ObsoleteNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr_m_ObsoleteNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr_m_ObsoleteNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000C63 RID: 3171
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x000AE2F0 File Offset: 0x000AC4F0
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x000100F8 File Offset: 0x0000E2F8
		public unsafe string _type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__type_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__type_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x06002789 RID: 10121 RVA: 0x000AE318 File Offset: 0x000AC518
		// (set) Token: 0x0600278A RID: 10122 RVA: 0x00010117 File Offset: 0x0000E317
		public unsafe string _typeNamespace_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__typeNamespace_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__typeNamespace_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x0600278B RID: 10123 RVA: 0x000AE340 File Offset: 0x000AC540
		// (set) Token: 0x0600278C RID: 10124 RVA: 0x00010136 File Offset: 0x0000E336
		public unsafe UxmlAttributeDescription.Use _use_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__use_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__use_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x000AE368 File Offset: 0x000AC568
		// (set) Token: 0x0600278E RID: 10126 RVA: 0x00010151 File Offset: 0x0000E351
		public unsafe UxmlTypeRestriction _restriction_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__restriction_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UxmlTypeRestriction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlAttributeDescription.NativeFieldInfoPtr__restriction_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001C18 RID: 7192
		private static readonly IntPtr NativeFieldInfoPtr__name_k__BackingField;

		// Token: 0x04001C19 RID: 7193
		private static readonly IntPtr NativeFieldInfoPtr_m_ObsoleteNames;

		// Token: 0x04001C1A RID: 7194
		private static readonly IntPtr NativeFieldInfoPtr__type_k__BackingField;

		// Token: 0x04001C1B RID: 7195
		private static readonly IntPtr NativeFieldInfoPtr__typeNamespace_k__BackingField;

		// Token: 0x04001C1C RID: 7196
		private static readonly IntPtr NativeFieldInfoPtr__use_k__BackingField;

		// Token: 0x04001C1D RID: 7197
		private static readonly IntPtr NativeFieldInfoPtr__restriction_k__BackingField;

		// Token: 0x04001C1E RID: 7198
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C1F RID: 7199
		private static readonly IntPtr NativeMethodInfoPtr_get_name_Public_get_String_0;

		// Token: 0x04001C20 RID: 7200
		private static readonly IntPtr NativeMethodInfoPtr_set_name_Public_set_Void_String_0;

		// Token: 0x04001C21 RID: 7201
		private static readonly IntPtr NativeMethodInfoPtr_set_obsoleteNames_Public_set_Void_IEnumerable_1_String_0;

		// Token: 0x04001C22 RID: 7202
		private static readonly IntPtr NativeMethodInfoPtr_set_type_Protected_set_Void_String_0;

		// Token: 0x04001C23 RID: 7203
		private static readonly IntPtr NativeMethodInfoPtr_set_typeNamespace_Protected_set_Void_String_0;

		// Token: 0x04001C24 RID: 7204
		private static readonly IntPtr NativeMethodInfoPtr_set_use_Public_set_Void_Use_0;

		// Token: 0x04001C25 RID: 7205
		private static readonly IntPtr NativeMethodInfoPtr_set_restriction_Public_set_Void_UxmlTypeRestriction_0;

		// Token: 0x04001C26 RID: 7206
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueFromBagAsString_Internal_Boolean_IUxmlAttributes_CreationContext_byref_String_0;

		// Token: 0x04001C27 RID: 7207
		private static readonly IntPtr NativeMethodInfoPtr_TryGetValueFromBag_Protected_Boolean_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_byref_T_0;

		// Token: 0x04001C28 RID: 7208
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Protected_T_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_0;

		// Token: 0x04001C29 RID: 7209
		public const string xmlSchemaNamespace = "http://www.w3.org/2001/XMLSchema";

		// Token: 0x02000500 RID: 1280
		public enum Use
		{
			// Token: 0x04002CF1 RID: 11505
			None,
			// Token: 0x04002CF2 RID: 11506
			Optional,
			// Token: 0x04002CF3 RID: 11507
			Prohibited,
			// Token: 0x04002CF4 RID: 11508
			Required
		}

		// Token: 0x02000501 RID: 1281
		private sealed class MethodInfoStoreGeneric_TryGetValueFromBag_Protected_Boolean_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_byref_T_0<T>
		{
			// Token: 0x04002CF5 RID: 11509
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UxmlAttributeDescription.NativeMethodInfoPtr_TryGetValueFromBag_Protected_Boolean_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_byref_T_0, Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000502 RID: 1282
		private sealed class MethodInfoStoreGeneric_GetValueFromBag_Protected_T_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_0<T>
		{
			// Token: 0x04002CF6 RID: 11510
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(UxmlAttributeDescription.NativeMethodInfoPtr_GetValueFromBag_Protected_T_IUxmlAttributes_CreationContext_Func_3_String_T_T_T_0, Il2CppClassPointerStore<UxmlAttributeDescription>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
