using System;
using dwd.core.data.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.Events;

namespace dwd.core.match.data
{
	// Token: 0x02000167 RID: 359
	public class EntitiesProvider : DataProvider
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x00067F54 File Offset: 0x00066154
		// Note: this type is marked as 'beforefieldinit'.
		static EntitiesProvider()
		{
			Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "EntitiesProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr);
			EntitiesProvider.NativeFieldInfoPtr_OnInitialize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, "OnInitialize");
			EntitiesProvider.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, "entities");
			EntitiesProvider.NativeMethodInfoPtr_get_Entities_Public_Virtual_Final_New_get_Entities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666455);
			EntitiesProvider.NativeMethodInfoPtr_Initialize_Public_Void_Entities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666456);
			EntitiesProvider.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666457);
			EntitiesProvider.NativeMethodInfoPtr_assertInitialized_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666458);
			EntitiesProvider.NativeMethodInfoPtr_Find_Public_Static_EntitiesProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666459);
			EntitiesProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr, 100666460);
		}

		// Token: 0x170005F8 RID: 1528
		// (get) Token: 0x060014EF RID: 5359 RVA: 0x00068024 File Offset: 0x00066224
		public unsafe virtual Entities Entities
		{
			[CallerCount(126)]
			[CachedScanResults(RefRangeStart = 875250, RefRangeEnd = 875376, XrefRangeStart = 875250, XrefRangeEnd = 875250, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr_get_Entities_Public_Virtual_Final_New_get_Entities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr3) : null;
			}
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x00068064 File Offset: 0x00066264
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 875385, RefRangeEnd = 875387, XrefRangeStart = 875376, XrefRangeEnd = 875385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(Entities entities)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entities);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr_Initialize_Public_Void_Entities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x000680A8 File Offset: 0x000662A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875387, XrefRangeEnd = 875388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x000680DC File Offset: 0x000662DC
		[CallerCount(0)]
		public unsafe void assertInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr_assertInitialized_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x00068110 File Offset: 0x00066310
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 875391, RefRangeEnd = 875403, XrefRangeStart = 875388, XrefRangeEnd = 875391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static EntitiesProvider Find()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr_Find_Public_Static_EntitiesProvider_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntitiesProvider>(intPtr3) : null;
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00068144 File Offset: 0x00066344
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 875404, RefRangeEnd = 875407, XrefRangeStart = 875403, XrefRangeEnd = 875404, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntitiesProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntitiesProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntitiesProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00009439 File Offset: 0x00007639
		public EntitiesProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005F6 RID: 1526
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x00068180 File Offset: 0x00066380
		// (set) Token: 0x060014F7 RID: 5367 RVA: 0x00009442 File Offset: 0x00007642
		public unsafe UnityEvent OnInitialize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesProvider.NativeFieldInfoPtr_OnInitialize);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesProvider.NativeFieldInfoPtr_OnInitialize), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005F7 RID: 1527
		// (get) Token: 0x060014F8 RID: 5368 RVA: 0x000681B0 File Offset: 0x000663B0
		// (set) Token: 0x060014F9 RID: 5369 RVA: 0x00009461 File Offset: 0x00007661
		public unsafe Entities entities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesProvider.NativeFieldInfoPtr_entities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntitiesProvider.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeFieldInfoPtr_OnInitialize;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeFieldInfoPtr_entities;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_get_Entities_Public_Virtual_Final_New_get_Entities_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_Entities_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr_assertInitialized_Private_Void_0;

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Static_EntitiesProvider_0;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
