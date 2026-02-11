using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.match.data
{
	// Token: 0x0200016C RID: 364
	public class PlaymatPileObject : EntityObject
	{
		// Token: 0x06001518 RID: 5400 RVA: 0x000687F0 File Offset: 0x000669F0
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatPileObject()
		{
			Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "PlaymatPileObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr);
			PlaymatPileObject.NativeFieldInfoPtr_PileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr, "PileName");
			PlaymatPileObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr, 100666479);
			PlaymatPileObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr, 100666480);
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0006885C File Offset: 0x00066A5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875449, XrefRangeEnd = 875451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatPileObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x000688A8 File Offset: 0x00066AA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875451, XrefRangeEnd = 875455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatPileObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatPileObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatPileObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x00009537 File Offset: 0x00007737
		public PlaymatPileObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x000688E4 File Offset: 0x00066AE4
		// (set) Token: 0x0600151D RID: 5405 RVA: 0x00009540 File Offset: 0x00007740
		public unsafe string PileName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileObject.NativeFieldInfoPtr_PileName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatPileObject.NativeFieldInfoPtr_PileName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000F0B RID: 3851
		private static readonly IntPtr NativeFieldInfoPtr_PileName;

		// Token: 0x04000F0C RID: 3852
		private static readonly IntPtr NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000F0D RID: 3853
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
