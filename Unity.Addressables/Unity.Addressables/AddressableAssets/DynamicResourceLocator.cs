using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets
{
	// Token: 0x02000018 RID: 24
	public class DynamicResourceLocator : Object
	{
		// Token: 0x0600021B RID: 539 RVA: 0x0000EA34 File Offset: 0x0000CC34
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicResourceLocator()
		{
			Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets", "DynamicResourceLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr);
			DynamicResourceLocator.NativeFieldInfoPtr_m_Addressables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, "m_Addressables");
			DynamicResourceLocator.NativeFieldInfoPtr_m_AtlasSpriteProviderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, "m_AtlasSpriteProviderId");
			DynamicResourceLocator.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663752);
			DynamicResourceLocator.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663753);
			DynamicResourceLocator.NativeMethodInfoPtr_get_AtlasSpriteProviderId_Private_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663754);
			DynamicResourceLocator.NativeMethodInfoPtr_get_AllLocations_Public_get_IEnumerable_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663755);
			DynamicResourceLocator.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663756);
			DynamicResourceLocator.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663757);
			DynamicResourceLocator.NativeMethodInfoPtr_CreateDynamicLocations_Internal_Void_Type_IList_1_IResourceLocation_String_String_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr, 100663758);
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600021C RID: 540 RVA: 0x0000EB18 File Offset: 0x0000CD18
		public unsafe virtual string LocatorId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162780, XrefRangeEnd = 1162782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600021D RID: 541 RVA: 0x0000EB50 File Offset: 0x0000CD50
		public unsafe virtual IEnumerable<Object> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162782, XrefRangeEnd = 1162785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DynamicResourceLocator.NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_IEnumerable_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600021E RID: 542 RVA: 0x0000EB9C File Offset: 0x0000CD9C
		public unsafe string AtlasSpriteProviderId
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1162806, RefRangeEnd = 1162807, XrefRangeStart = 1162785, XrefRangeEnd = 1162806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr_get_AtlasSpriteProviderId_Private_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600021F RID: 543 RVA: 0x0000EBD4 File Offset: 0x0000CDD4
		public unsafe IEnumerable<IResourceLocation> AllLocations
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162807, XrefRangeEnd = 1162810, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr_get_AllLocations_Public_get_IEnumerable_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<IResourceLocation>>(intPtr3) : null;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000EC14 File Offset: 0x0000CE14
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DynamicResourceLocator(AddressablesImpl addr)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DynamicResourceLocator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(addr);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x0000EC60 File Offset: 0x0000CE60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162810, XrefRangeEnd = 1162858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Locate(Object key, Type type, out IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000222 RID: 546 RVA: 0x0000ECE4 File Offset: 0x0000CEE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1162930, RefRangeEnd = 1162931, XrefRangeStart = 1162858, XrefRangeEnd = 1162930, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDynamicLocations(Type type, IList<IResourceLocation> locations, string locName, string subKey, IResourceLocation mainLoc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(locName);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(subKey);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(mainLoc);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicResourceLocator.NativeMethodInfoPtr_CreateDynamicLocations_Internal_Void_Type_IList_1_IResourceLocation_String_String_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x0000299B File Offset: 0x00000B9B
		public DynamicResourceLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000224 RID: 548 RVA: 0x0000ED70 File Offset: 0x0000CF70
		// (set) Token: 0x06000225 RID: 549 RVA: 0x000029A4 File Offset: 0x00000BA4
		public unsafe AddressablesImpl m_Addressables
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResourceLocator.NativeFieldInfoPtr_m_Addressables);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AddressablesImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResourceLocator.NativeFieldInfoPtr_m_Addressables), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000226 RID: 550 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000029C3 File Offset: 0x00000BC3
		public unsafe string m_AtlasSpriteProviderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResourceLocator.NativeFieldInfoPtr_m_AtlasSpriteProviderId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DynamicResourceLocator.NativeFieldInfoPtr_m_AtlasSpriteProviderId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040001AD RID: 429
		private static readonly IntPtr NativeFieldInfoPtr_m_Addressables;

		// Token: 0x040001AE RID: 430
		private static readonly IntPtr NativeFieldInfoPtr_m_AtlasSpriteProviderId;

		// Token: 0x040001AF RID: 431
		private static readonly IntPtr NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x040001B0 RID: 432
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_New_get_IEnumerable_1_Object_0;

		// Token: 0x040001B1 RID: 433
		private static readonly IntPtr NativeMethodInfoPtr_get_AtlasSpriteProviderId_Private_get_String_0;

		// Token: 0x040001B2 RID: 434
		private static readonly IntPtr NativeMethodInfoPtr_get_AllLocations_Public_get_IEnumerable_1_IResourceLocation_0;

		// Token: 0x040001B3 RID: 435
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AddressablesImpl_0;

		// Token: 0x040001B4 RID: 436
		private static readonly IntPtr NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0;

		// Token: 0x040001B5 RID: 437
		private static readonly IntPtr NativeMethodInfoPtr_CreateDynamicLocations_Internal_Void_Type_IList_1_IResourceLocation_String_String_IResourceLocation_0;
	}
}
