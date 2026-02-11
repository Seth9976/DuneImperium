using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Security.Permissions;

namespace Il2CppSystem.Security
{
	// Token: 0x0200021E RID: 542
	[Serializable]
	public sealed class NamedPermissionSet : PermissionSet
	{
		// Token: 0x060023F5 RID: 9205 RVA: 0x000C97A0 File Offset: 0x000C79A0
		// Note: this type is marked as 'beforefieldinit'.
		static NamedPermissionSet()
		{
			Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "NamedPermissionSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr);
			NamedPermissionSet.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, "name");
			NamedPermissionSet.NativeFieldInfoPtr_description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, "description");
			NamedPermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669371);
			NamedPermissionSet.NativeMethodInfoPtr__ctor_Public_Void_String_PermissionState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669372);
			NamedPermissionSet.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669373);
			NamedPermissionSet.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669374);
			NamedPermissionSet.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669375);
			NamedPermissionSet.NativeMethodInfoPtr_ToXml_Public_Virtual_SecurityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669376);
			NamedPermissionSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669377);
			NamedPermissionSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr, 100669378);
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x000C9898 File Offset: 0x000C7A98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369620, XrefRangeEnd = 1369629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedPermissionSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x000C98D4 File Offset: 0x000C7AD4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369660, RefRangeEnd = 1369661, XrefRangeStart = 1369629, XrefRangeEnd = 1369660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedPermissionSet(string name, PermissionState state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref state;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr__ctor_Public_Void_String_PermissionState_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x000C9930 File Offset: 0x000C7B30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369662, RefRangeEnd = 1369663, XrefRangeStart = 1369661, XrefRangeEnd = 1369662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NamedPermissionSet(string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NamedPermissionSet>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x060023F9 RID: 9209 RVA: 0x000C997C File Offset: 0x000C7B7C
		// (set) Token: 0x060023FA RID: 9210 RVA: 0x000C99B4 File Offset: 0x000C7BB4
		public unsafe string Name
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369663, XrefRangeEnd = 1369674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr_set_Name_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060023FB RID: 9211 RVA: 0x000C99F8 File Offset: 0x000C7BF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369674, XrefRangeEnd = 1369681, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override SecurityElement ToXml()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr_ToXml_Public_Virtual_SecurityElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SecurityElement>(intPtr3) : null;
		}

		// Token: 0x060023FC RID: 9212 RVA: 0x000C9A38 File Offset: 0x000C7C38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369681, XrefRangeEnd = 1369685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060023FD RID: 9213 RVA: 0x000C9A88 File Offset: 0x000C7C88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369685, XrefRangeEnd = 1369687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NamedPermissionSet.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060023FE RID: 9214 RVA: 0x0000B762 File Offset: 0x00009962
		public NamedPermissionSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x060023FF RID: 9215 RVA: 0x000C9AC4 File Offset: 0x000C7CC4
		// (set) Token: 0x06002400 RID: 9216 RVA: 0x0000B76B File Offset: 0x0000996B
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedPermissionSet.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedPermissionSet.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002401 RID: 9217 RVA: 0x000C9AEC File Offset: 0x000C7CEC
		// (set) Token: 0x06002402 RID: 9218 RVA: 0x0000B78A File Offset: 0x0000998A
		public unsafe string description
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedPermissionSet.NativeFieldInfoPtr_description);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NamedPermissionSet.NativeFieldInfoPtr_description), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F78 RID: 8056
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04001F79 RID: 8057
		private static readonly IntPtr NativeFieldInfoPtr_description;

		// Token: 0x04001F7A RID: 8058
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001F7B RID: 8059
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_PermissionState_0;

		// Token: 0x04001F7C RID: 8060
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04001F7D RID: 8061
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04001F7E RID: 8062
		private static readonly IntPtr NativeMethodInfoPtr_set_Name_Public_set_Void_String_0;

		// Token: 0x04001F7F RID: 8063
		private static readonly IntPtr NativeMethodInfoPtr_ToXml_Public_Virtual_SecurityElement_0;

		// Token: 0x04001F80 RID: 8064
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04001F81 RID: 8065
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
	}
}
