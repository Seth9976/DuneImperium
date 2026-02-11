using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Resources;

namespace Il2CppSystem
{
	// Token: 0x02000009 RID: 9
	public static class SR : Object
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00002958 File Offset: 0x00000B58
		// Note: this type is marked as 'beforefieldinit'.
		static SR()
		{
			Il2CppClassPointerStore<SR>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "System", "SR");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SR>.NativeClassPtr);
			SR.NativeFieldInfoPtr_s_usingResourceKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SR>.NativeClassPtr, "s_usingResourceKeys");
			SR.NativeFieldInfoPtr_s_resourceManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SR>.NativeClassPtr, "s_resourceManager");
			SR.NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663305);
			SR.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663306);
			SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663307);
			SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663308);
			SR.NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663309);
			SR.NativeMethodInfoPtr_get_NoServiceRegistered_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663310);
			SR.NativeMethodInfoPtr_get_ServiceCollectionReadOnly_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663311);
			SR.NativeMethodInfoPtr_get_TryAddIndistinguishableTypeToEnumerable_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663312);
			SR.NativeMethodInfoPtr_get_KeyedDescriptorMisuse_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663313);
			SR.NativeMethodInfoPtr_get_NonKeyedDescriptorMisuse_Internal_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SR>.NativeClassPtr, 100663314);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A78 File Offset: 0x00000C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264951, XrefRangeEnd = 1264955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UsingResourceKeys()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1264984, RefRangeEnd = 1264989, XrefRangeStart = 1264955, XrefRangeEnd = 1264984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetResourceString(string resourceKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002AE4 File Offset: 0x00000CE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1264989, XrefRangeEnd = 1265013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, Object p1)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002B34 File Offset: 0x00000D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265013, XrefRangeEnd = 1265041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string Format(string resourceFormat, Object p1, Object p2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(resourceFormat);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p1);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(p2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002B94 File Offset: 0x00000D94
		public unsafe static ResourceManager ResourceManager
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265041, XrefRangeEnd = 1265060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr3) : null;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public unsafe static string NoServiceRegistered
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265060, XrefRangeEnd = 1265066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_NoServiceRegistered_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002BF4 File Offset: 0x00000DF4
		public unsafe static string ServiceCollectionReadOnly
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1265072, RefRangeEnd = 1265073, XrefRangeStart = 1265066, XrefRangeEnd = 1265072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_ServiceCollectionReadOnly_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002C20 File Offset: 0x00000E20
		public unsafe static string TryAddIndistinguishableTypeToEnumerable
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265073, XrefRangeEnd = 1265079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_TryAddIndistinguishableTypeToEnumerable_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002C4C File Offset: 0x00000E4C
		public unsafe static string KeyedDescriptorMisuse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1265085, RefRangeEnd = 1265086, XrefRangeStart = 1265079, XrefRangeEnd = 1265085, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_KeyedDescriptorMisuse_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002C78 File Offset: 0x00000E78
		public unsafe static string NonKeyedDescriptorMisuse
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1265092, RefRangeEnd = 1265093, XrefRangeStart = 1265086, XrefRangeEnd = 1265092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SR.NativeMethodInfoPtr_get_NonKeyedDescriptorMisuse_Internal_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000215D File Offset: 0x0000035D
		public SR(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002CA4 File Offset: 0x00000EA4
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002166 File Offset: 0x00000366
		public unsafe static bool s_usingResourceKeys
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(SR.NativeFieldInfoPtr_s_usingResourceKeys, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SR.NativeFieldInfoPtr_s_usingResourceKeys, (void*)(&value));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002CC0 File Offset: 0x00000EC0
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002174 File Offset: 0x00000374
		public unsafe static ResourceManager s_resourceManager
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SR.NativeFieldInfoPtr_s_resourceManager, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ResourceManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SR.NativeFieldInfoPtr_s_resourceManager, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeFieldInfoPtr_s_usingResourceKeys;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeFieldInfoPtr_s_resourceManager;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_UsingResourceKeys_Internal_Static_Boolean_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_GetResourceString_Private_Static_String_String_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_0;

		// Token: 0x04000012 RID: 18
		private static readonly IntPtr NativeMethodInfoPtr_Format_Internal_Static_String_String_Object_Object_0;

		// Token: 0x04000013 RID: 19
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceManager_Internal_Static_get_ResourceManager_0;

		// Token: 0x04000014 RID: 20
		private static readonly IntPtr NativeMethodInfoPtr_get_NoServiceRegistered_Internal_Static_get_String_0;

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceCollectionReadOnly_Internal_Static_get_String_0;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeMethodInfoPtr_get_TryAddIndistinguishableTypeToEnumerable_Internal_Static_get_String_0;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyedDescriptorMisuse_Internal_Static_get_String_0;

		// Token: 0x04000018 RID: 24
		private static readonly IntPtr NativeMethodInfoPtr_get_NonKeyedDescriptorMisuse_Internal_Static_get_String_0;
	}
}
