using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.PropertyVariants.TrackedProperties;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants.TrackedObjects
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class TrackedObject : Object
	{
		// Token: 0x06000C13 RID: 3091 RVA: 0x00036B7C File Offset: 0x00034D7C
		// Note: this type is marked as 'beforefieldinit'.
		static TrackedObject()
		{
			Il2CppClassPointerStore<TrackedObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.PropertyVariants.TrackedObjects", "TrackedObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr);
			TrackedObject.NativeFieldInfoPtr_m_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, "m_Target");
			TrackedObject.NativeFieldInfoPtr_m_TrackedProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, "m_TrackedProperties");
			TrackedObject.NativeFieldInfoPtr_m_PropertiesLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, "m_PropertiesLookup");
			TrackedObject.NativeMethodInfoPtr_get_Target_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665298);
			TrackedObject.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665299);
			TrackedObject.NativeMethodInfoPtr_get_TrackedProperties_Public_get_IList_1_ITrackedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665300);
			TrackedObject.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_New_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665301);
			TrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665302);
			TrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_New_Void_ITrackedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665303);
			TrackedObject.NativeMethodInfoPtr_RemoveTrackedProperty_Public_Virtual_New_Boolean_ITrackedProperty_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665304);
			TrackedObject.NativeMethodInfoPtr_GetTrackedProperty_Public_T_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665305);
			TrackedObject.NativeMethodInfoPtr_GetTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665306);
			TrackedObject.NativeMethodInfoPtr_CreateCustomTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665307);
			TrackedObject.NativeMethodInfoPtr_ApplyLocale_Public_Abstract_Virtual_New_AsyncOperationHandle_Locale_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665308);
			TrackedObject.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665309);
			TrackedObject.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665310);
			TrackedObject.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665311);
			TrackedObject.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, 100665312);
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06000C14 RID: 3092 RVA: 0x00036D14 File Offset: 0x00034F14
		// (set) Token: 0x06000C15 RID: 3093 RVA: 0x00036D54 File Offset: 0x00034F54
		public unsafe Object Target
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr_get_Target_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 287292, RefRangeEnd = 287294, XrefRangeStart = 287292, XrefRangeEnd = 287294, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x00036D98 File Offset: 0x00034F98
		public unsafe IList<ITrackedProperty> TrackedProperties
		{
			[CallerCount(21)]
			[CachedScanResults(RefRangeStart = 373350, RefRangeEnd = 373371, XrefRangeStart = 373350, XrefRangeEnd = 373371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr_get_TrackedProperties_Public_get_IList_1_ITrackedProperty_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<ITrackedProperty>>(intPtr3) : null;
			}
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x00036DD8 File Offset: 0x00034FD8
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool CanTrackProperty(string propertyPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_New_Boolean_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x00036E30 File Offset: 0x00035030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080524, XrefRangeEnd = 1080544, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T AddTrackedProperty<T>(string propertyPath) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.MethodInfoStoreGeneric_AddTrackedProperty_Public_T_String_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x00036E7C File Offset: 0x0003507C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1080584, RefRangeEnd = 1080585, XrefRangeStart = 1080544, XrefRangeEnd = 1080584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddTrackedProperty(ITrackedProperty trackedProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trackedProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_New_Void_ITrackedProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000C1A RID: 3098 RVA: 0x00036ECC File Offset: 0x000350CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080585, XrefRangeEnd = 1080596, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool RemoveTrackedProperty(ITrackedProperty trackedProperty)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(trackedProperty);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_RemoveTrackedProperty_Public_Virtual_New_Boolean_ITrackedProperty_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x00036F24 File Offset: 0x00035124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080596, XrefRangeEnd = 1080614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe T GetTrackedProperty<T>(string propertyPath, bool create = true) where T : new()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref create;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.MethodInfoStoreGeneric_GetTrackedProperty_Public_T_String_Boolean_0<T>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x00036F7C File Offset: 0x0003517C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080614, XrefRangeEnd = 1080617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ITrackedProperty GetTrackedProperty(string propertyPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_GetTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITrackedProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x00036FD8 File Offset: 0x000351D8
		[CallerCount(74)]
		[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ITrackedProperty CreateCustomTrackedProperty(string propertyPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyPath);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_CreateCustomTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ITrackedProperty>(intPtr3) : null;
			}
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x00037034 File Offset: 0x00035234
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle ApplyLocale(Locale variantLocale, Locale defaultLocale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(variantLocale);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(defaultLocale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_ApplyLocale_Public_Abstract_Virtual_New_AsyncOperationHandle_Locale_Locale_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle(intPtr);
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003709C File Offset: 0x0003529C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void PostApplyTrackedProperties()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrackedObject.NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000370D8 File Offset: 0x000352D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080617, XrefRangeEnd = 1080640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0003710C File Offset: 0x0003530C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080640, XrefRangeEnd = 1080664, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C22 RID: 3106 RVA: 0x00037140 File Offset: 0x00035340
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1080684, RefRangeEnd = 1080692, XrefRangeStart = 1080664, XrefRangeEnd = 1080684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrackedObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C23 RID: 3107 RVA: 0x000071E3 File Offset: 0x000053E3
		public TrackedObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000352 RID: 850
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0003717C File Offset: 0x0003537C
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x000071EC File Offset: 0x000053EC
		public unsafe Object m_Target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_Target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x000371AC File Offset: 0x000353AC
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0000720B File Offset: 0x0000540B
		public unsafe TrackedObject.TrackedPropertiesCollection m_TrackedProperties
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_TrackedProperties);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrackedObject.TrackedPropertiesCollection>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_TrackedProperties), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x000371DC File Offset: 0x000353DC
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0000722A File Offset: 0x0000542A
		public unsafe Dictionary<string, ITrackedProperty> m_PropertiesLookup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_PropertiesLookup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, ITrackedProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.NativeFieldInfoPtr_m_PropertiesLookup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeFieldInfoPtr_m_Target;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeFieldInfoPtr_m_TrackedProperties;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeFieldInfoPtr_m_PropertiesLookup;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_get_Target_Public_get_Object_0;

		// Token: 0x04000872 RID: 2162
		private static readonly IntPtr NativeMethodInfoPtr_set_Target_Public_set_Void_Object_0;

		// Token: 0x04000873 RID: 2163
		private static readonly IntPtr NativeMethodInfoPtr_get_TrackedProperties_Public_get_IList_1_ITrackedProperty_0;

		// Token: 0x04000874 RID: 2164
		private static readonly IntPtr NativeMethodInfoPtr_CanTrackProperty_Public_Virtual_New_Boolean_String_0;

		// Token: 0x04000875 RID: 2165
		private static readonly IntPtr NativeMethodInfoPtr_AddTrackedProperty_Public_T_String_0;

		// Token: 0x04000876 RID: 2166
		private static readonly IntPtr NativeMethodInfoPtr_AddTrackedProperty_Public_Virtual_New_Void_ITrackedProperty_0;

		// Token: 0x04000877 RID: 2167
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrackedProperty_Public_Virtual_New_Boolean_ITrackedProperty_0;

		// Token: 0x04000878 RID: 2168
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedProperty_Public_T_String_Boolean_0;

		// Token: 0x04000879 RID: 2169
		private static readonly IntPtr NativeMethodInfoPtr_GetTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0;

		// Token: 0x0400087A RID: 2170
		private static readonly IntPtr NativeMethodInfoPtr_CreateCustomTrackedProperty_Public_Virtual_New_ITrackedProperty_String_0;

		// Token: 0x0400087B RID: 2171
		private static readonly IntPtr NativeMethodInfoPtr_ApplyLocale_Public_Abstract_Virtual_New_AsyncOperationHandle_Locale_Locale_0;

		// Token: 0x0400087C RID: 2172
		private static readonly IntPtr NativeMethodInfoPtr_PostApplyTrackedProperties_Protected_Virtual_New_Void_0;

		// Token: 0x0400087D RID: 2173
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400087E RID: 2174
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400087F RID: 2175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x02000188 RID: 392
		[Serializable]
		public class TrackedPropertiesCollection : Object
		{
			// Token: 0x06001014 RID: 4116 RVA: 0x00044014 File Offset: 0x00042214
			// Note: this type is marked as 'beforefieldinit'.
			static TrackedPropertiesCollection()
			{
				Il2CppClassPointerStore<TrackedObject.TrackedPropertiesCollection>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrackedObject>.NativeClassPtr, "TrackedPropertiesCollection");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrackedObject.TrackedPropertiesCollection>.NativeClassPtr);
				TrackedObject.TrackedPropertiesCollection.NativeFieldInfoPtr_items = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrackedObject.TrackedPropertiesCollection>.NativeClassPtr, "items");
				TrackedObject.TrackedPropertiesCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrackedObject.TrackedPropertiesCollection>.NativeClassPtr, 100665313);
			}

			// Token: 0x06001015 RID: 4117 RVA: 0x00044068 File Offset: 0x00042268
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1080516, XrefRangeEnd = 1080524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe TrackedPropertiesCollection()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrackedObject.TrackedPropertiesCollection>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrackedObject.TrackedPropertiesCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001016 RID: 4118 RVA: 0x00008C54 File Offset: 0x00006E54
			public TrackedPropertiesCollection(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000452 RID: 1106
			// (get) Token: 0x06001017 RID: 4119 RVA: 0x000440A4 File Offset: 0x000422A4
			// (set) Token: 0x06001018 RID: 4120 RVA: 0x00008C5D File Offset: 0x00006E5D
			public unsafe List<ITrackedProperty> items
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.TrackedPropertiesCollection.NativeFieldInfoPtr_items);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ITrackedProperty>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrackedObject.TrackedPropertiesCollection.NativeFieldInfoPtr_items), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000B02 RID: 2818
			private static readonly IntPtr NativeFieldInfoPtr_items;

			// Token: 0x04000B03 RID: 2819
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000189 RID: 393
		private sealed class MethodInfoStoreGeneric_AddTrackedProperty_Public_T_String_0<T>
		{
			// Token: 0x04000B04 RID: 2820
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TrackedObject.NativeMethodInfoPtr_AddTrackedProperty_Public_T_String_0, Il2CppClassPointerStore<TrackedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200018A RID: 394
		private sealed class MethodInfoStoreGeneric_GetTrackedProperty_Public_T_String_Boolean_0<T>
		{
			// Token: 0x04000B05 RID: 2821
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(TrackedObject.NativeMethodInfoPtr_GetTrackedProperty_Public_T_String_Boolean_0, Il2CppClassPointerStore<TrackedObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
