using System;
using boardgames.voodoo.data;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace boardgames.data
{
	// Token: 0x0200018F RID: 399
	public class PlaymatData : ManagedEntityDataComponent
	{
		// Token: 0x060011A7 RID: 4519 RVA: 0x00055A8C File Offset: 0x00053C8C
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatData()
		{
			Il2CppClassPointerStore<PlaymatData>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.data", "PlaymatData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatData>.NativeClassPtr);
			PlaymatData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatData>.NativeClassPtr, 100665771);
			PlaymatData.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatData>.NativeClassPtr, 100665772);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00055AE4 File Offset: 0x00053CE4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 515168, RefRangeEnd = 515169, XrefRangeStart = 515167, XrefRangeEnd = 515168, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatData(EntityComponent entityComponent)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatData>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(entityComponent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatData.NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00055B30 File Offset: 0x00053D30
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatData.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0000A729 File Offset: 0x00008929
		public PlaymatData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityComponent_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;
	}
}
