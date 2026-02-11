using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.match.data
{
	// Token: 0x0200016A RID: 362
	public class PlayerPileObject : EntityObject
	{
		// Token: 0x0600150C RID: 5388 RVA: 0x000685B8 File Offset: 0x000667B8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPileObject()
		{
			Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "PlayerPileObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr);
			PlayerPileObject.NativeFieldInfoPtr_PlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr, "PlayerIndex");
			PlayerPileObject.NativeFieldInfoPtr_PileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr, "PileName");
			PlayerPileObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr, 100666475);
			PlayerPileObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr, 100666476);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x00068638 File Offset: 0x00066838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875442, XrefRangeEnd = 875444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerPileObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00068684 File Offset: 0x00066884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875444, XrefRangeEnd = 875448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPileObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPileObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPileObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x000094EB File Offset: 0x000076EB
		public PlayerPileObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x000686C0 File Offset: 0x000668C0
		// (set) Token: 0x06001511 RID: 5393 RVA: 0x000094F4 File Offset: 0x000076F4
		public unsafe int PlayerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileObject.NativeFieldInfoPtr_PlayerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileObject.NativeFieldInfoPtr_PlayerIndex)) = value;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x06001512 RID: 5394 RVA: 0x000686E8 File Offset: 0x000668E8
		// (set) Token: 0x06001513 RID: 5395 RVA: 0x0000950F File Offset: 0x0000770F
		public unsafe string PileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileObject.NativeFieldInfoPtr_PileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPileObject.NativeFieldInfoPtr_PileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeFieldInfoPtr_PlayerIndex;

		// Token: 0x04000F06 RID: 3846
		private static readonly IntPtr NativeFieldInfoPtr_PileName;

		// Token: 0x04000F07 RID: 3847
		private static readonly IntPtr NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000F08 RID: 3848
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
