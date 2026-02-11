using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.voodoo
{
	// Token: 0x020000EC RID: 236
	public class PlayerPileDataProvider : EntityViewDataProvider
	{
		// Token: 0x06000A40 RID: 2624 RVA: 0x0003DB30 File Offset: 0x0003BD30
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPileDataProvider()
		{
			Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.voodoo", "PlayerPileDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr);
			PlayerPileDataProvider.NativeFieldInfoPtr_pileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr, "pileName");
			PlayerPileDataProvider.NativeFieldInfoPtr_disableIfNull = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr, "disableIfNull");
			PlayerPileDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr, 100664781);
			PlayerPileDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr, 100664782);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0003DBB0 File Offset: 0x0003BDB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506666, XrefRangeEnd = 506679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerPileDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0003DC0C File Offset: 0x0003BE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 506679, XrefRangeEnd = 506683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPileDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPileDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPileDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00006E9D File Offset: 0x0000509D
		public PlayerPileDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000A44 RID: 2628 RVA: 0x0003DC48 File Offset: 0x0003BE48
		// (set) Token: 0x06000A45 RID: 2629 RVA: 0x00006EA6 File Offset: 0x000050A6
		public unsafe string pileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileDataProvider.NativeFieldInfoPtr_pileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileDataProvider.NativeFieldInfoPtr_pileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000A46 RID: 2630 RVA: 0x0003DC70 File Offset: 0x0003BE70
		// (set) Token: 0x06000A47 RID: 2631 RVA: 0x00006EC5 File Offset: 0x000050C5
		public unsafe bool disableIfNull
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileDataProvider.NativeFieldInfoPtr_disableIfNull);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileDataProvider.NativeFieldInfoPtr_disableIfNull)) = value;
			}
		}

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_pileName;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeFieldInfoPtr_disableIfNull;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
