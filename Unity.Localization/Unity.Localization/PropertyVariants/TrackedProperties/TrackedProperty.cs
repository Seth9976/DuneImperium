using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Localization.PropertyVariants.TrackedProperties
{
	// Token: 0x020000E7 RID: 231
	[Serializable]
	public class TrackedProperty<TPrimitive> : Object
	{
		// Token: 0x06000B93 RID: 2963 RVA: 0x00034F84 File Offset: 0x00033184
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedProperty()
		{
			Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedProperties", "TrackedProperty`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrimitive>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr);
			TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_PropertyPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, "m_PropertyPath");
			TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, "m_VariantData");
			TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, "m_VariantLookup");
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665214);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665215);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665216);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_RemoveVariant_Public_Virtual_Final_New_Void_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665217);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_TPrimitive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665218);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_TPrimitive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665219);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_TPrimitive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665220);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665221);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_LocaleIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665222);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_SetValueFromString_Public_Virtual_Final_New_Void_LocaleIdentifier_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665223);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_New_String_TPrimitive_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665224);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_New_TPrimitive_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665225);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665226);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665227);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665228);
			TrackedProperty<TPrimitive>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, 100665229);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0003516C File Offset: 0x0003336C
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x000351A4 File Offset: 0x000333A4
		public unsafe virtual string PropertyPath
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000351E8 File Offset: 0x000333E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079636, XrefRangeEnd = 1079637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x0003523C File Offset: 0x0003343C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079637, XrefRangeEnd = 1079638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveVariant(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_RemoveVariant_Public_Virtual_Final_New_Void_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x00035284 File Offset: 0x00033484
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079638, XrefRangeEnd = 1079639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, out TPrimitive foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TPrimitive).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref foundValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_TPrimitive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TPrimitive).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				foundValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TPrimitive>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00035328 File Offset: 0x00033528
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079639, XrefRangeEnd = 1079641, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool GetValue(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback, out TPrimitive foundValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fallback));
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			IntPtr intPtr2;
			if (!typeof(TPrimitive).IsValueType)
			{
				intPtr = 0;
				intPtr2 = &intPtr;
			}
			else
			{
				intPtr2 = ref foundValue;
			}
			ptr2 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_TPrimitive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			if (!typeof(TPrimitive).IsValueType)
			{
				IntPtr intPtr5 = intPtr;
				foundValue = ((intPtr5 == 0) ? null : IL2CPP.PointerToValueGeneric<TPrimitive>(intPtr5, false, false));
			}
			return *IL2CPP.il2cpp_object_unbox(intPtr3);
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000353E0 File Offset: 0x000335E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079641, XrefRangeEnd = 1079647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValue(LocaleIdentifier localeIdentifier, TPrimitive value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(TPrimitive).IsValueType)
			{
				TPrimitive tprimitive = value;
				intPtr = ((tprimitive is string) ? IL2CPP.ManagedStringToIl2Cpp(tprimitive as string) : IL2CPP.Il2CppObjectBaseToPtr(tprimitive as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref value;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_TPrimitive_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x00035470 File Offset: 0x00033670
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079647, XrefRangeEnd = 1079648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetValueAsString(LocaleIdentifier localeIdentifier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000354C0 File Offset: 0x000336C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079648, XrefRangeEnd = 1079650, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetValueAsString(LocaleIdentifier localeIdentifier, LocaleIdentifier fallback)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(fallback));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_LocaleIdentifier_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x00035524 File Offset: 0x00033724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079650, XrefRangeEnd = 1079656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetValueFromString(LocaleIdentifier localeIdentifier, string stringValue)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(localeIdentifier));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(stringValue);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_SetValueFromString_Public_Virtual_Final_New_Void_LocaleIdentifier_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x00035580 File Offset: 0x00033780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079656, XrefRangeEnd = 1079661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ConvertToString(TPrimitive value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TPrimitive).IsValueType)
				{
					TPrimitive tprimitive = value;
					intPtr = ((tprimitive is string) ? IL2CPP.ManagedStringToIl2Cpp(tprimitive as string) : IL2CPP.Il2CppObjectBaseToPtr(tprimitive as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref value;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ConvertToString_Protected_Virtual_New_String_TPrimitive_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0003560C File Offset: 0x0003380C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1079671, RefRangeEnd = 1079672, XrefRangeStart = 1079661, XrefRangeEnd = 1079671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TPrimitive ConvertFromString(string value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_New_TPrimitive_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<TPrimitive>(intPtr, false, true);
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x00035664 File Offset: 0x00033864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079672, XrefRangeEnd = 1079683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x00035698 File Offset: 0x00033898
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079683, XrefRangeEnd = 1079691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000356CC File Offset: 0x000338CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1079691, XrefRangeEnd = 1079775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedProperty<TPrimitive>.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00035710 File Offset: 0x00033910
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 1079791, RefRangeEnd = 1079806, XrefRangeStart = 1079775, XrefRangeEnd = 1079791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedProperty()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x00006CD8 File Offset: 0x00004ED8
		public TrackedProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000BA5 RID: 2981 RVA: 0x0003574C File Offset: 0x0003394C
		// (set) Token: 0x06000BA6 RID: 2982 RVA: 0x00006CE1 File Offset: 0x00004EE1
		public unsafe string m_PropertyPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_PropertyPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_PropertyPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x00035774 File Offset: 0x00033974
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x00006D00 File Offset: 0x00004F00
		public unsafe List<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair> m_VariantData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x000357A4 File Offset: 0x000339A4
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x00006D1F File Offset: 0x00004F1F
		public unsafe Dictionary<LocaleIdentifier, TrackedProperty<TPrimitive>.LocaleIdentifierValuePair> m_VariantLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<LocaleIdentifier, TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.NativeFieldInfoPtr_m_VariantLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000822 RID: 2082
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertyPath;

		// Token: 0x04000823 RID: 2083
		private static readonly IntPtr NativeFieldInfoPtr_m_VariantData;

		// Token: 0x04000824 RID: 2084
		private static readonly IntPtr NativeFieldInfoPtr_m_VariantLookup;

		// Token: 0x04000825 RID: 2085
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertyPath_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000826 RID: 2086
		private static readonly IntPtr NativeMethodInfoPtr_set_PropertyPath_Public_Virtual_Final_New_set_Void_String_0;

		// Token: 0x04000827 RID: 2087
		private static readonly IntPtr NativeMethodInfoPtr_HasVariant_Public_Virtual_Final_New_Boolean_LocaleIdentifier_0;

		// Token: 0x04000828 RID: 2088
		private static readonly IntPtr NativeMethodInfoPtr_RemoveVariant_Public_Virtual_Final_New_Void_LocaleIdentifier_0;

		// Token: 0x04000829 RID: 2089
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_byref_TPrimitive_0;

		// Token: 0x0400082A RID: 2090
		private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_Boolean_LocaleIdentifier_LocaleIdentifier_byref_TPrimitive_0;

		// Token: 0x0400082B RID: 2091
		private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Final_New_Void_LocaleIdentifier_TPrimitive_0;

		// Token: 0x0400082C RID: 2092
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_0;

		// Token: 0x0400082D RID: 2093
		private static readonly IntPtr NativeMethodInfoPtr_GetValueAsString_Public_Virtual_Final_New_String_LocaleIdentifier_LocaleIdentifier_0;

		// Token: 0x0400082E RID: 2094
		private static readonly IntPtr NativeMethodInfoPtr_SetValueFromString_Public_Virtual_Final_New_Void_LocaleIdentifier_String_0;

		// Token: 0x0400082F RID: 2095
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToString_Protected_Virtual_New_String_TPrimitive_0;

		// Token: 0x04000830 RID: 2096
		private static readonly IntPtr NativeMethodInfoPtr_ConvertFromString_Protected_Virtual_New_TPrimitive_String_0;

		// Token: 0x04000831 RID: 2097
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000832 RID: 2098
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000833 RID: 2099
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000834 RID: 2100
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000181 RID: 385
		[Serializable]
		public class LocaleIdentifierValuePair : Object
		{
			// Token: 0x06000FD3 RID: 4051 RVA: 0x000434D4 File Offset: 0x000416D4
			// Note: this type is marked as 'beforefieldinit'.
			static LocaleIdentifierValuePair()
			{
				Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedProperty<TPrimitive>>.NativeClassPtr, "LocaleIdentifierValuePair"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TPrimitive>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr);
				TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr, "localeIdentifier");
				TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr, "value");
				TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr, 100665230);
			}

			// Token: 0x06000FD4 RID: 4052 RVA: 0x00043578 File Offset: 0x00041778
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LocaleIdentifierValuePair()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedProperty<TPrimitive>.LocaleIdentifierValuePair>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000FD5 RID: 4053 RVA: 0x000089A9 File Offset: 0x00006BA9
			public LocaleIdentifierValuePair(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700043C RID: 1084
			// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x000435B4 File Offset: 0x000417B4
			// (set) Token: 0x06000FD7 RID: 4055 RVA: 0x000089B2 File Offset: 0x00006BB2
			public LocaleIdentifier localeIdentifier
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier);
					return new LocaleIdentifier(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, intPtr));
				}
				set
				{
					cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_localeIdentifier), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LocaleIdentifier>.NativeClassPtr, (UIntPtr)0));
				}
			}

			// Token: 0x1700043D RID: 1085
			// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x000435E4 File Offset: 0x000417E4
			// (set) Token: 0x06000FD9 RID: 4057 RVA: 0x0004360C File Offset: 0x0004180C
			public unsafe TPrimitive value
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_value);
					return IL2CPP.PointerToValueGeneric<TPrimitive>(intPtr, true, false);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedProperty<TPrimitive>.LocaleIdentifierValuePair.NativeFieldInfoPtr_value);
					Type typeFromHandle = typeof(TPrimitive);
					if (!typeFromHandle.IsValueType)
					{
						if (!string.Equals(typeFromHandle.FullName, "System.String"))
						{
							IntPtr intPtr4;
							IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
							if (intPtr3 != 0)
							{
								intPtr4 = intPtr3;
								if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
								{
									IntPtr intPtr5 = intPtr3;
									cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
									return;
								}
							}
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
						}
						else
						{
							IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
						}
					}
					else
					{
						*intPtr2 = value;
					}
				}
			}

			// Token: 0x04000ADF RID: 2783
			private static readonly IntPtr NativeFieldInfoPtr_localeIdentifier;

			// Token: 0x04000AE0 RID: 2784
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04000AE1 RID: 2785
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
