using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.match.data
{
	// Token: 0x02000169 RID: 361
	public class PlayerObject : EntityObject
	{
		// Token: 0x06001506 RID: 5382 RVA: 0x0006849C File Offset: 0x0006669C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerObject()
		{
			Il2CppClassPointerStore<PlayerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "PlayerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerObject>.NativeClassPtr);
			PlayerObject.NativeFieldInfoPtr_PlayerIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerObject>.NativeClassPtr, "PlayerIndex");
			PlayerObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerObject>.NativeClassPtr, 100666473);
			PlayerObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerObject>.NativeClassPtr, 100666474);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x00068508 File Offset: 0x00066708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875440, XrefRangeEnd = 875442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x00068554 File Offset: 0x00066754
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x000094C7 File Offset: 0x000076C7
		public PlayerObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00068590 File Offset: 0x00066790
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x000094D0 File Offset: 0x000076D0
		public unsafe int PlayerIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerObject.NativeFieldInfoPtr_PlayerIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerObject.NativeFieldInfoPtr_PlayerIndex)) = value;
			}
		}

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeFieldInfoPtr_PlayerIndex;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
