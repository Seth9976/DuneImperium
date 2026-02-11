using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.AddressableAssets.ResourceLocators
{
	// Token: 0x02000024 RID: 36
	public class ResourceLocationMap : Object
	{
		// Token: 0x060002DA RID: 730 RVA: 0x000113E4 File Offset: 0x0000F5E4
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocationMap()
		{
			Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.ResourceLocators", "ResourceLocationMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr);
			ResourceLocationMap.NativeFieldInfoPtr__LocatorId_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, "<LocatorId>k__BackingField");
			ResourceLocationMap.NativeFieldInfoPtr_locations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, "locations");
			ResourceLocationMap.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663870);
			ResourceLocationMap.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663871);
			ResourceLocationMap.NativeMethodInfoPtr_set_LocatorId_Private_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663872);
			ResourceLocationMap.NativeMethodInfoPtr__ctor_Public_Void_String_IList_1_ResourceLocationData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663873);
			ResourceLocationMap.NativeMethodInfoPtr_get_Locations_Public_get_Dictionary_2_Object_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663874);
			ResourceLocationMap.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663875);
			ResourceLocationMap.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663876);
			ResourceLocationMap.NativeMethodInfoPtr_Add_Public_Void_Object_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663877);
			ResourceLocationMap.NativeMethodInfoPtr_Add_Public_Void_Object_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr, 100663878);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000114F0 File Offset: 0x0000F6F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164260, XrefRangeEnd = 1164269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationMap(string id, int capacity = 0)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref capacity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060002DC RID: 732 RVA: 0x0001154C File Offset: 0x0000F74C
		// (set) Token: 0x060002DD RID: 733 RVA: 0x00011584 File Offset: 0x0000F784
		public unsafe virtual string LocatorId
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_set_LocatorId_Private_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000115C8 File Offset: 0x0000F7C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164386, RefRangeEnd = 1164387, XrefRangeStart = 1164269, XrefRangeEnd = 1164386, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationMap(string id, IList<ResourceLocationData> locations)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocationMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr__ctor_Public_Void_String_IList_1_ResourceLocationData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00011628 File Offset: 0x0000F828
		public unsafe Dictionary<Object, IList<IResourceLocation>> Locations
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_get_Locations_Public_get_Dictionary_2_Object_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, IList<IResourceLocation>>>(intPtr3) : null;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00011668 File Offset: 0x0000F868
		public unsafe virtual IEnumerable<Object> Keys
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1164387, XrefRangeEnd = 1164391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000116A8 File Offset: 0x0000F8A8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1164449, RefRangeEnd = 1164452, XrefRangeStart = 1164391, XrefRangeEnd = 1164449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			locations = ((intPtr4 == 0) ? null : new IList<IResourceLocation>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001172C File Offset: 0x0000F92C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164467, RefRangeEnd = 1164468, XrefRangeStart = 1164452, XrefRangeEnd = 1164467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object key, IResourceLocation location)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(location);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_Add_Public_Void_Object_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00011780 File Offset: 0x0000F980
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1164472, RefRangeEnd = 1164473, XrefRangeStart = 1164468, XrefRangeEnd = 1164472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Add(Object key, IList<IResourceLocation> locations)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationMap.NativeMethodInfoPtr_Add_Public_Void_Object_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002F3E File Offset: 0x0000113E
		public ResourceLocationMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060002E5 RID: 741 RVA: 0x000117D4 File Offset: 0x0000F9D4
		// (set) Token: 0x060002E6 RID: 742 RVA: 0x00002F47 File Offset: 0x00001147
		public unsafe string _LocatorId_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationMap.NativeFieldInfoPtr__LocatorId_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationMap.NativeFieldInfoPtr__LocatorId_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060002E7 RID: 743 RVA: 0x000117FC File Offset: 0x0000F9FC
		// (set) Token: 0x060002E8 RID: 744 RVA: 0x00002F66 File Offset: 0x00001166
		public unsafe Dictionary<Object, IList<IResourceLocation>> locations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationMap.NativeFieldInfoPtr_locations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<Object, IList<IResourceLocation>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationMap.NativeFieldInfoPtr_locations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000234 RID: 564
		private static readonly IntPtr NativeFieldInfoPtr__LocatorId_k__BackingField;

		// Token: 0x04000235 RID: 565
		private static readonly IntPtr NativeFieldInfoPtr_locations;

		// Token: 0x04000236 RID: 566
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;

		// Token: 0x04000237 RID: 567
		private static readonly IntPtr NativeMethodInfoPtr_get_LocatorId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000238 RID: 568
		private static readonly IntPtr NativeMethodInfoPtr_set_LocatorId_Private_set_Void_String_0;

		// Token: 0x04000239 RID: 569
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_IList_1_ResourceLocationData_0;

		// Token: 0x0400023A RID: 570
		private static readonly IntPtr NativeMethodInfoPtr_get_Locations_Public_get_Dictionary_2_Object_IList_1_IResourceLocation_0;

		// Token: 0x0400023B RID: 571
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Virtual_Final_New_get_IEnumerable_1_Object_0;

		// Token: 0x0400023C RID: 572
		private static readonly IntPtr NativeMethodInfoPtr_Locate_Public_Virtual_Final_New_Boolean_Object_Type_byref_IList_1_IResourceLocation_0;

		// Token: 0x0400023D RID: 573
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_IResourceLocation_0;

		// Token: 0x0400023E RID: 574
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Void_Object_IList_1_IResourceLocation_0;
	}
}
