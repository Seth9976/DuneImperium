using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace boardgames.match.data
{
	// Token: 0x020000A7 RID: 167
	public class AttributesPrefabLookupData : PrefabLookupData
	{
		// Token: 0x06000998 RID: 2456 RVA: 0x0002965C File Offset: 0x0002785C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributesPrefabLookupData()
		{
			Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.match.data", "AttributesPrefabLookupData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr);
			AttributesPrefabLookupData.NativeFieldInfoPtr_flavors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr, "flavors");
			AttributesPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr, 100664684);
			AttributesPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr, 100664685);
			AttributesPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr, 100664686);
		}

		// Token: 0x06000999 RID: 2457 RVA: 0x000296DC File Offset: 0x000278DC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1117622, RefRangeEnd = 1117624, XrefRangeStart = 1117593, XrefRangeEnd = 1117622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributesPrefabLookupData(ReadOnlyAttributes attributes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributesPrefabLookupData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributesPrefabLookupData.NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00029728 File Offset: 0x00027928
		public unsafe override HashSet<string> Flavors
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesPrefabLookupData.NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr3) : null;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x0600099B RID: 2459 RVA: 0x00029774 File Offset: 0x00027974
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AttributesPrefabLookupData.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00006A7E File Offset: 0x00004C7E
		public AttributesPrefabLookupData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600099D RID: 2461 RVA: 0x000297BC File Offset: 0x000279BC
		// (set) Token: 0x0600099E RID: 2462 RVA: 0x00006A87 File Offset: 0x00004C87
		public unsafe HashSet<string> flavors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesPrefabLookupData.NativeFieldInfoPtr_flavors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AttributesPrefabLookupData.NativeFieldInfoPtr_flavors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005FE RID: 1534
		private static readonly IntPtr NativeFieldInfoPtr_flavors;

		// Token: 0x040005FF RID: 1535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ReadOnlyAttributes_0;

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeMethodInfoPtr_get_Flavors_Public_Virtual_get_HashSet_1_String_0;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;
	}
}
