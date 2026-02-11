using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x020000A6 RID: 166
	public class AttributePrefabLookupData : PrefabLookupData
	{
		// Token: 0x0600098D RID: 2445 RVA: 0x0002944C File Offset: 0x0002764C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributePrefabLookupData()
		{
			Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.match.data", "AttributePrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr);
			AttributePrefabLookupData.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, "attribute");
			AttributePrefabLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, "flavors");
			AttributePrefabLookupData.NativeFieldInfoPtr_cachedAttributeVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, "cachedAttributeVersion");
			AttributePrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, 100664681);
			AttributePrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, 100664682);
			AttributePrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr, 100664683);
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x000294F4 File Offset: 0x000276F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117566, XrefRangeEnd = 1117575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributePrefabLookupData(IAttribute attribute)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributePrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributePrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_IAttribute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00029540 File Offset: 0x00027740
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117575, XrefRangeEnd = 1117589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributePrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0002958C File Offset: 0x0002778C
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117589, XrefRangeEnd = 1117593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributePrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000991 RID: 2449 RVA: 0x00006A1C File Offset: 0x00004C1C
		public AttributePrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000992 RID: 2450 RVA: 0x000295D4 File Offset: 0x000277D4
		// (set) Token: 0x06000993 RID: 2451 RVA: 0x00006A25 File Offset: 0x00004C25
		public unsafe IAttribute attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000994 RID: 2452 RVA: 0x00029604 File Offset: 0x00027804
		// (set) Token: 0x06000995 RID: 2453 RVA: 0x00006A44 File Offset: 0x00004C44
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x00029634 File Offset: 0x00027834
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00006A63 File Offset: 0x00004C63
		public unsafe ulong cachedAttributeVersion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_cachedAttributeVersion);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributePrefabLookupData.NativeFieldInfoPtr_cachedAttributeVersion)) = value;
			}
		}

		// Token: 0x040005F8 RID: 1528
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x040005F9 RID: 1529
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x040005FA RID: 1530
		private static readonly IntPtr NativeFieldInfoPtr_cachedAttributeVersion;

		// Token: 0x040005FB RID: 1531
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IAttribute_0;

		// Token: 0x040005FC RID: 1532
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x040005FD RID: 1533
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
