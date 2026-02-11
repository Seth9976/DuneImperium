using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000019 RID: 25
	public sealed class LocationCacheKey : Object
	{
		// Token: 0x06000194 RID: 404 RVA: 0x0000B2F8 File Offset: 0x000094F8
		// Note: this type is marked as 'beforefieldinit'.
		static LocationCacheKey()
		{
			Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "LocationCacheKey");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr);
			LocationCacheKey.NativeFieldInfoPtr_m_Location = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, "m_Location");
			LocationCacheKey.NativeFieldInfoPtr_m_DesiredType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, "m_DesiredType");
			LocationCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, 100663595);
			LocationCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, 100663596);
			LocationCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, 100663597);
			LocationCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, 100663598);
			LocationCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_LocationCacheKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr, 100663599);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000B3B4 File Offset: 0x000095B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138630, XrefRangeEnd = 1138649, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocationCacheKey(IResourceLocation location, Type desiredType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocationCacheKey>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(location);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(desiredType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationCacheKey.NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000B414 File Offset: 0x00009614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138649, XrefRangeEnd = 1138653, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationCacheKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000B450 File Offset: 0x00009650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138653, XrefRangeEnd = 1138657, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000B4A0 File Offset: 0x000096A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138657, XrefRangeEnd = 1138661, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(IOperationCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationCacheKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000B4F0 File Offset: 0x000096F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138661, XrefRangeEnd = 1138663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(LocationCacheKey other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocationCacheKey.NativeMethodInfoPtr_Equals_Private_Boolean_LocationCacheKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00002A6D File Offset: 0x00000C6D
		public LocationCacheKey(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000B540 File Offset: 0x00009740
		// (set) Token: 0x0600019C RID: 412 RVA: 0x00002A76 File Offset: 0x00000C76
		public unsafe IResourceLocation m_Location
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationCacheKey.NativeFieldInfoPtr_m_Location);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IResourceLocation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationCacheKey.NativeFieldInfoPtr_m_Location), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000B570 File Offset: 0x00009770
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00002A95 File Offset: 0x00000C95
		public unsafe Type m_DesiredType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationCacheKey.NativeFieldInfoPtr_m_DesiredType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocationCacheKey.NativeFieldInfoPtr_m_DesiredType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeFieldInfoPtr_m_Location;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeFieldInfoPtr_m_DesiredType;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IResourceLocation_Type_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_IOperationCacheKey_0;

		// Token: 0x0400011E RID: 286
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Private_Boolean_LocationCacheKey_0;
	}
}
