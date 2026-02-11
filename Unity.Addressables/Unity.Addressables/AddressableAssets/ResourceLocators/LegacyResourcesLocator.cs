using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x02000022 RID: 34
	public class LegacyResourcesLocator : Object
	{
		// Token: 0x060002BC RID: 700 RVA: 0x00010D44 File Offset: 0x0000EF44
		// Note: this type is marked as 'beforefieldinit'.
		static LegacyResourcesLocator()
		{
			Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "LegacyResourcesLocator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr);
			LegacyResourcesLocator.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr, 100663858);
			LegacyResourcesLocator.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr, 100663859);
			LegacyResourcesLocator.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr, 100663860);
			LegacyResourcesLocator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr, 100663861);
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164193, XrefRangeEnd = 1164224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesLocator.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002BE RID: 702 RVA: 0x00010E48 File Offset: 0x0000F048
		public unsafe virtual IEnumerable<Object> Keys
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesLocator.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00010E88 File Offset: 0x0000F088
		public unsafe virtual string LocatorId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164224, XrefRangeEnd = 1164226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesLocator.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00010EC0 File Offset: 0x0000F0C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LegacyResourcesLocator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegacyResourcesLocator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LegacyResourcesLocator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00002E44 File Offset: 0x00001044
		public LegacyResourcesLocator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000221 RID: 545
		private static readonly IntPtr NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0;

		// Token: 0x04000222 RID: 546
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0;

		// Token: 0x04000223 RID: 547
		private static readonly IntPtr NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000224 RID: 548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
