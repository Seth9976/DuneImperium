using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000007 RID: 7
	public class ResourceLocatorInfo : Object
	{
		// Token: 0x0600002B RID: 43 RVA: 0x00005128 File Offset: 0x00003328
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocatorInfo()
		{
			Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "ResourceLocatorInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr);
			ResourceLocatorInfo.NativeFieldInfoPtr__Locator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, "<Locator>k__BackingField");
			ResourceLocatorInfo.NativeFieldInfoPtr__LocalHash_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, "<LocalHash>k__BackingField");
			ResourceLocatorInfo.NativeFieldInfoPtr__CatalogLocation_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, "<CatalogLocation>k__BackingField");
			ResourceLocatorInfo.NativeFieldInfoPtr__ContentUpdateAvailable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, "<ContentUpdateAvailable>k__BackingField");
			ResourceLocatorInfo.NativeMethodInfoPtr_get_Locator_Public_get_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663317);
			ResourceLocatorInfo.NativeMethodInfoPtr_set_Locator_Private_set_Void_IResourceLocator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663318);
			ResourceLocatorInfo.NativeMethodInfoPtr_get_LocalHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663319);
			ResourceLocatorInfo.NativeMethodInfoPtr_set_LocalHash_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663320);
			ResourceLocatorInfo.NativeMethodInfoPtr_get_CatalogLocation_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663321);
			ResourceLocatorInfo.NativeMethodInfoPtr_set_CatalogLocation_Private_set_Void_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663322);
			ResourceLocatorInfo.NativeMethodInfoPtr_get_ContentUpdateAvailable_Internal_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663323);
			ResourceLocatorInfo.NativeMethodInfoPtr_set_ContentUpdateAvailable_Internal_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663324);
			ResourceLocatorInfo.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocator_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663325);
			ResourceLocatorInfo.NativeMethodInfoPtr_get_HashLocation_Public_get_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663326);
			ResourceLocatorInfo.NativeMethodInfoPtr_get_CanUpdateContent_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663327);
			ResourceLocatorInfo.NativeMethodInfoPtr_UpdateContent_Internal_Void_IResourceLocator_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr, 100663328);
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00005298 File Offset: 0x00003498
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000052D8 File Offset: 0x000034D8
		public unsafe IResourceLocator Locator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_Locator_Public_get_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocator>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_set_Locator_Private_set_Void_IResourceLocator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000531C File Offset: 0x0000351C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x00005354 File Offset: 0x00003554
		public unsafe string LocalHash
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_LocalHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_set_LocalHash_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00005398 File Offset: 0x00003598
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000053D8 File Offset: 0x000035D8
		public unsafe IResourceLocation CatalogLocation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_CatalogLocation_Public_get_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_set_CatalogLocation_Private_set_Void_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0000541C File Offset: 0x0000361C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x00005458 File Offset: 0x00003658
		public unsafe bool ContentUpdateAvailable
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_ContentUpdateAvailable_Internal_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 287297, RefRangeEnd = 287316, XrefRangeStart = 287297, XrefRangeEnd = 287316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_set_ContentUpdateAvailable_Internal_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00005498 File Offset: 0x00003698
		[CallerCount(31)]
		[CachedScanResults(RefRangeStart = 487194, RefRangeEnd = 487225, XrefRangeStart = 487194, XrefRangeEnd = 487225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocatorInfo(IResourceLocator loc, string localHash, IResourceLocation remoteCatalogLocation)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocatorInfo>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(loc);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(localHash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(remoteCatalogLocation);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocator_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00005508 File Offset: 0x00003708
		public unsafe IResourceLocation HashLocation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1157883, RefRangeEnd = 1157884, XrefRangeStart = 1157876, XrefRangeEnd = 1157883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_HashLocation_Public_get_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr3) : null;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00005548 File Offset: 0x00003748
		public unsafe bool CanUpdateContent
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1157884, XrefRangeEnd = 1157893, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_get_CanUpdateContent_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005584 File Offset: 0x00003784
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1157896, RefRangeEnd = 1157897, XrefRangeStart = 1157893, XrefRangeEnd = 1157896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateContent(IResourceLocator locator, string hash, IResourceLocation loc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(locator);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(hash);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(loc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocatorInfo.NativeMethodInfoPtr_UpdateContent_Internal_Void_IResourceLocator_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002163 File Offset: 0x00000363
		public ResourceLocatorInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000039 RID: 57 RVA: 0x000055EC File Offset: 0x000037EC
		// (set) Token: 0x0600003A RID: 58 RVA: 0x0000216C File Offset: 0x0000036C
		public unsafe IResourceLocator _Locator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__Locator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__Locator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600003B RID: 59 RVA: 0x0000561C File Offset: 0x0000381C
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000218B File Offset: 0x0000038B
		public unsafe string _LocalHash_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__LocalHash_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__LocalHash_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005644 File Offset: 0x00003844
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000021AA File Offset: 0x000003AA
		public unsafe IResourceLocation _CatalogLocation_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__CatalogLocation_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__CatalogLocation_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005674 File Offset: 0x00003874
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000021C9 File Offset: 0x000003C9
		public unsafe bool _ContentUpdateAvailable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__ContentUpdateAvailable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocatorInfo.NativeFieldInfoPtr__ContentUpdateAvailable_k__BackingField)) = value;
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr__Locator_k__BackingField;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeFieldInfoPtr__LocalHash_k__BackingField;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeFieldInfoPtr__CatalogLocation_k__BackingField;

		// Token: 0x0400001D RID: 29
		private static readonly IntPtr NativeFieldInfoPtr__ContentUpdateAvailable_k__BackingField;

		// Token: 0x0400001E RID: 30
		private static readonly IntPtr NativeMethodInfoPtr_get_Locator_Public_get_IResourceLocator_0;

		// Token: 0x0400001F RID: 31
		private static readonly IntPtr NativeMethodInfoPtr_set_Locator_Private_set_Void_IResourceLocator_0;

		// Token: 0x04000020 RID: 32
		private static readonly IntPtr NativeMethodInfoPtr_get_LocalHash_Public_get_String_0;

		// Token: 0x04000021 RID: 33
		private static readonly IntPtr NativeMethodInfoPtr_set_LocalHash_Private_set_Void_String_0;

		// Token: 0x04000022 RID: 34
		private static readonly IntPtr NativeMethodInfoPtr_get_CatalogLocation_Public_get_IResourceLocation_0;

		// Token: 0x04000023 RID: 35
		private static readonly IntPtr NativeMethodInfoPtr_set_CatalogLocation_Private_set_Void_IResourceLocation_0;

		// Token: 0x04000024 RID: 36
		private static readonly IntPtr NativeMethodInfoPtr_get_ContentUpdateAvailable_Internal_get_Boolean_0;

		// Token: 0x04000025 RID: 37
		private static readonly IntPtr NativeMethodInfoPtr_set_ContentUpdateAvailable_Internal_set_Void_Boolean_0;

		// Token: 0x04000026 RID: 38
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResourceLocator_String_IResourceLocation_0;

		// Token: 0x04000027 RID: 39
		private static readonly IntPtr NativeMethodInfoPtr_get_HashLocation_Public_get_IResourceLocation_0;

		// Token: 0x04000028 RID: 40
		private static readonly IntPtr NativeMethodInfoPtr_get_CanUpdateContent_Public_get_Boolean_0;

		// Token: 0x04000029 RID: 41
		private static readonly IntPtr NativeMethodInfoPtr_UpdateContent_Internal_Void_IResourceLocator_String_IResourceLocation_0;
	}
}
