using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;
using Il2CppSystem.Security.Permissions;

namespace Il2CppSystem.Security
{
	// Token: 0x0200021F RID: 543
	[Serializable]
	public class PermissionSet : Object
	{
		// Token: 0x06002403 RID: 9219 RVA: 0x000C9B14 File Offset: 0x000C7D14
		// Note: this type is marked as 'beforefieldinit'.
		static PermissionSet()
		{
			Il2CppClassPointerStore<PermissionSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "PermissionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr);
			PermissionSet.NativeFieldInfoPtr_psUnrestricted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "psUnrestricted");
			PermissionSet.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "state");
			PermissionSet.NativeFieldInfoPtr_list = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "list");
			PermissionSet.NativeFieldInfoPtr__declsec = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "_declsec");
			PermissionSet.NativeFieldInfoPtr__ignored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "_ignored");
			PermissionSet.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, "action");
			PermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669379);
			PermissionSet.NativeMethodInfoPtr__ctor_Public_Void_PermissionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669380);
			PermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_IPermission_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669381);
			PermissionSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669382);
			PermissionSet.NativeMethodInfoPtr_Demand_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669383);
			PermissionSet.NativeMethodInfoPtr_CasOnlyDemand_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669384);
			PermissionSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669385);
			PermissionSet.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669386);
			PermissionSet.NativeMethodInfoPtr_IsUnrestricted_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669387);
			PermissionSet.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669388);
			PermissionSet.NativeMethodInfoPtr_ToXml_Public_Virtual_New_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669389);
			PermissionSet.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669390);
			PermissionSet.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669391);
			PermissionSet.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669392);
			PermissionSet.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669393);
			PermissionSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669394);
			PermissionSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr, 100669395);
		}

		// Token: 0x06002404 RID: 9220 RVA: 0x000C9D10 File Offset: 0x000C7F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369687, XrefRangeEnd = 1369693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PermissionSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002405 RID: 9221 RVA: 0x000C9D4C File Offset: 0x000C7F4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369693, XrefRangeEnd = 1369699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PermissionSet(PermissionState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr__ctor_Public_Void_PermissionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002406 RID: 9222 RVA: 0x000C9D94 File Offset: 0x000C7F94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369699, XrefRangeEnd = 1369705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PermissionSet(IPermission perm)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PermissionSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(perm);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_IPermission_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002407 RID: 9223 RVA: 0x000C9DE0 File Offset: 0x000C7FE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369705, XrefRangeEnd = 1369707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CopyTo(Array array, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002408 RID: 9224 RVA: 0x000C9E3C File Offset: 0x000C803C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369725, RefRangeEnd = 1369726, XrefRangeStart = 1369707, XrefRangeEnd = 1369725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Demand()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_Demand_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002409 RID: 9225 RVA: 0x000C9E70 File Offset: 0x000C8070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369726, XrefRangeEnd = 1369730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CasOnlyDemand(int skip)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref skip;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_CasOnlyDemand_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x000C9EB0 File Offset: 0x000C80B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369730, XrefRangeEnd = 1369731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x000C9EF0 File Offset: 0x000C80F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369753, RefRangeEnd = 1369754, XrefRangeStart = 1369731, XrefRangeEnd = 1369753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x000C9F2C File Offset: 0x000C812C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 484236, RefRangeEnd = 484237, XrefRangeStart = 484236, XrefRangeEnd = 484237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUnrestricted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_IsUnrestricted_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x000C9F68 File Offset: 0x000C8168
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369754, XrefRangeEnd = 1369755, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x000C9FAC File Offset: 0x000C81AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369801, RefRangeEnd = 1369802, XrefRangeStart = 1369755, XrefRangeEnd = 1369801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SecurityElement ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_ToXml_Public_Virtual_New_SecurityElement_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x1700071F RID: 1823
		// (get) Token: 0x0600240F RID: 9231 RVA: 0x000C9FF8 File Offset: 0x000C81F8
		public unsafe virtual int Count
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 467480, RefRangeEnd = 467481, XrefRangeStart = 467480, XrefRangeEnd = 467481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000720 RID: 1824
		// (get) Token: 0x06002410 RID: 9232 RVA: 0x000CA040 File Offset: 0x000C8240
		public unsafe virtual bool IsSynchronized
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369802, XrefRangeEnd = 1369803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000721 RID: 1825
		// (get) Token: 0x06002411 RID: 9233 RVA: 0x000CA088 File Offset: 0x000C8288
		public unsafe virtual Object SyncRoot
		{
			[CallerCount(1295)]
			[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x000CA0D4 File Offset: 0x000C82D4
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PermissionSet.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x000CA118 File Offset: 0x000C8318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369808, RefRangeEnd = 1369809, XrefRangeStart = 1369803, XrefRangeEnd = 1369808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x000CA170 File Offset: 0x000C8370
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PermissionSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002415 RID: 9237 RVA: 0x0000B7A9 File Offset: 0x000099A9
		public PermissionSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002416 RID: 9238 RVA: 0x000CA1B8 File Offset: 0x000C83B8
		// (set) Token: 0x06002417 RID: 9239 RVA: 0x0000B7B2 File Offset: 0x000099B2
		public unsafe static Il2CppReferenceArray<Object> psUnrestricted
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PermissionSet.NativeFieldInfoPtr_psUnrestricted, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PermissionSet.NativeFieldInfoPtr_psUnrestricted, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x000CA1E0 File Offset: 0x000C83E0
		// (set) Token: 0x06002419 RID: 9241 RVA: 0x0000B7C4 File Offset: 0x000099C4
		public unsafe PermissionState state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr_state);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr_state)) = value;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600241A RID: 9242 RVA: 0x000CA208 File Offset: 0x000C8408
		// (set) Token: 0x0600241B RID: 9243 RVA: 0x0000B7DF File Offset: 0x000099DF
		public unsafe ArrayList list
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr_list);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr_list), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x000CA238 File Offset: 0x000C8438
		// (set) Token: 0x0600241D RID: 9245 RVA: 0x0000B7FE File Offset: 0x000099FE
		public unsafe bool _declsec
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr__declsec);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr__declsec)) = value;
			}
		}

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x000CA260 File Offset: 0x000C8460
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x0000B819 File Offset: 0x00009A19
		public unsafe Il2CppStructArray<bool> _ignored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr__ignored);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PermissionSet.NativeFieldInfoPtr__ignored), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700071E RID: 1822
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x000CA290 File Offset: 0x000C8490
		// (set) Token: 0x06002421 RID: 9249 RVA: 0x0000B838 File Offset: 0x00009A38
		public unsafe static Il2CppReferenceArray<Object> action
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PermissionSet.NativeFieldInfoPtr_action, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PermissionSet.NativeFieldInfoPtr_action, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F82 RID: 8066
		private static readonly IntPtr NativeFieldInfoPtr_psUnrestricted;

		// Token: 0x04001F83 RID: 8067
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001F84 RID: 8068
		private static readonly IntPtr NativeFieldInfoPtr_list;

		// Token: 0x04001F85 RID: 8069
		private static readonly IntPtr NativeFieldInfoPtr__declsec;

		// Token: 0x04001F86 RID: 8070
		private static readonly IntPtr NativeFieldInfoPtr__ignored;

		// Token: 0x04001F87 RID: 8071
		private static readonly IntPtr NativeFieldInfoPtr_action;

		// Token: 0x04001F88 RID: 8072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001F89 RID: 8073
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PermissionState_0;

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IPermission_0;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_New_Void_Array_Int32_0;

		// Token: 0x04001F8C RID: 8076
		private static readonly IntPtr NativeMethodInfoPtr_Demand_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001F8D RID: 8077
		private static readonly IntPtr NativeMethodInfoPtr_CasOnlyDemand_Internal_Void_Int32_0;

		// Token: 0x04001F8E RID: 8078
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Virtual_Final_New_IEnumerator_0;

		// Token: 0x04001F8F RID: 8079
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;

		// Token: 0x04001F90 RID: 8080
		private static readonly IntPtr NativeMethodInfoPtr_IsUnrestricted_Public_Boolean_0;

		// Token: 0x04001F91 RID: 8081
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04001F92 RID: 8082
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Public_Virtual_New_SecurityElement_0;

		// Token: 0x04001F93 RID: 8083
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001F94 RID: 8084
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSynchronized_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04001F95 RID: 8085
		private static readonly IntPtr NativeMethodInfoPtr_get_SyncRoot_Public_Virtual_New_get_Object_0;

		// Token: 0x04001F96 RID: 8086
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;

		// Token: 0x04001F97 RID: 8087
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F98 RID: 8088
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
