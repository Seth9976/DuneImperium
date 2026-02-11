using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	// Token: 0x02000049 RID: 73
	public class LocationWrapper : Object
	{
		// Token: 0x0600039F RID: 927 RVA: 0x00012EF8 File Offset: 0x000110F8
		// Note: this type is marked as 'beforefieldinit'.
		static LocationWrapper()
		{
			Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceLocations", "LocationWrapper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr);
			LocationWrapper.NativeFieldInfoPtr_m_InternalLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, "m_InternalLocation");
			LocationWrapper.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663914);
			LocationWrapper.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663915);
			LocationWrapper.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663916);
			LocationWrapper.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663917);
			LocationWrapper.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663918);
			LocationWrapper.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663919);
			LocationWrapper.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663920);
			LocationWrapper.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663921);
			LocationWrapper.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663922);
			LocationWrapper.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr, 100663923);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00013004 File Offset: 0x00011204
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocationWrapper(IResourceLocation location)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocationWrapper>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x00013050 File Offset: 0x00011250
		public unsafe virtual string InternalId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141454, XrefRangeEnd = 1141458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00013088 File Offset: 0x00011288
		public unsafe virtual string ProviderId
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141458, XrefRangeEnd = 1141462, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x000130C0 File Offset: 0x000112C0
		public unsafe virtual IList<IResourceLocation> Dependencies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141462, XrefRangeEnd = 1141466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr3) : null;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00013100 File Offset: 0x00011300
		public unsafe virtual int DependencyHashCode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141466, XrefRangeEnd = 1141470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003A5 RID: 933 RVA: 0x0001313C File Offset: 0x0001133C
		public unsafe virtual bool HasDependencies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141470, XrefRangeEnd = 1141474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00013178 File Offset: 0x00011378
		public unsafe virtual Object Data
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141474, XrefRangeEnd = 1141478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003A7 RID: 935 RVA: 0x000131B8 File Offset: 0x000113B8
		public unsafe virtual string PrimaryKey
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141478, XrefRangeEnd = 1141482, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000131F0 File Offset: 0x000113F0
		public unsafe virtual Type ResourceType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141482, XrefRangeEnd = 1141486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00013230 File Offset: 0x00011430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141486, XrefRangeEnd = 1141490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int Hash(Type resultType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(resultType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationWrapper.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00003720 File Offset: 0x00001920
		public LocationWrapper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003AB RID: 939 RVA: 0x00013280 File Offset: 0x00011480
		// (set) Token: 0x060003AC RID: 940 RVA: 0x00003729 File Offset: 0x00001929
		public unsafe IResourceLocation m_InternalLocation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationWrapper.NativeFieldInfoPtr_m_InternalLocation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationWrapper.NativeFieldInfoPtr_m_InternalLocation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000278 RID: 632
		private static readonly IntPtr NativeFieldInfoPtr_m_InternalLocation;

		// Token: 0x04000279 RID: 633
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_0;

		// Token: 0x0400027A RID: 634
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400027B RID: 635
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400027C RID: 636
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0;

		// Token: 0x0400027D RID: 637
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x0400027E RID: 638
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400027F RID: 639
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04000280 RID: 640
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000281 RID: 641
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000282 RID: 642
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0;
	}
}
