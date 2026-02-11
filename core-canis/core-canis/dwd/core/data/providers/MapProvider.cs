using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.data.providers
{
	// Token: 0x020001D2 RID: 466
	public class MapProvider<K, V> : DataProvider
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x0007A8AC File Offset: 0x00078AAC
		// Note: this type is marked as 'beforefieldinit'.
		static MapProvider()
		{
			Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.data.providers", "MapProvider`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<K>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<V>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr);
			MapProvider<K, V>.NativeFieldInfoPtr_writableAll = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr, "writableAll");
			MapProvider<K, V>.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyVersionedMap_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr, 100667394);
			MapProvider<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr, 100667395);
			MapProvider<K, V>.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_IDictionary_2_K_V_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr, 100667396);
			MapProvider<K, V>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr, 100667397);
		}

		// Token: 0x17000728 RID: 1832
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x0007A990 File Offset: 0x00078B90
		public unsafe ReadOnlyVersionedMap<K, V> All
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 881824, RefRangeEnd = 881829, XrefRangeStart = 881811, XrefRangeEnd = 881824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapProvider<K, V>.NativeMethodInfoPtr_get_All_Public_get_ReadOnlyVersionedMap_2_K_V_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ReadOnlyVersionedMap<K, V>>(intPtr3) : null;
			}
		}

		// Token: 0x17000729 RID: 1833
		// (get) Token: 0x060019CC RID: 6604 RVA: 0x0007A9D0 File Offset: 0x00078BD0
		public unsafe override ulong Version
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881829, XrefRangeEnd = 881831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapProvider<K, V>.NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0007AA18 File Offset: 0x00078C18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 881831, XrefRangeEnd = 881858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Initialize(IDictionary<K, V> items)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(items);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MapProvider<K, V>.NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_IDictionary_2_K_V_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0007AA68 File Offset: 0x00078C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 881874, RefRangeEnd = 881875, XrefRangeStart = 881858, XrefRangeEnd = 881874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MapProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MapProvider<K, V>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MapProvider<K, V>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x0000B3EC File Offset: 0x000095EC
		public MapProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0007AAA4 File Offset: 0x00078CA4
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0000B3F5 File Offset: 0x000095F5
		public unsafe VersionedMap<K, V> writableAll
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapProvider<K, V>.NativeFieldInfoPtr_writableAll);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VersionedMap<K, V>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MapProvider<K, V>.NativeFieldInfoPtr_writableAll), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400121E RID: 4638
		private static readonly IntPtr NativeFieldInfoPtr_writableAll;

		// Token: 0x0400121F RID: 4639
		private static readonly IntPtr NativeMethodInfoPtr_get_All_Public_get_ReadOnlyVersionedMap_2_K_V_0;

		// Token: 0x04001220 RID: 4640
		private static readonly IntPtr NativeMethodInfoPtr_get_Version_Public_Virtual_get_UInt64_0;

		// Token: 0x04001221 RID: 4641
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Virtual_New_Void_IDictionary_2_K_V_0;

		// Token: 0x04001222 RID: 4642
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
