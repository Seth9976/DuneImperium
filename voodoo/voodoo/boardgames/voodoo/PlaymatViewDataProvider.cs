using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.voodoo
{
	// Token: 0x0200009F RID: 159
	public class PlaymatViewDataProvider : EntityViewDataProvider
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0002825C File Offset: 0x0002645C
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatViewDataProvider()
		{
			Il2CppClassPointerStore<PlaymatViewDataProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "PlaymatViewDataProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatViewDataProvider>.NativeClassPtr);
			PlaymatViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatViewDataProvider>.NativeClassPtr, 100664645);
			PlaymatViewDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatViewDataProvider>.NativeClassPtr, 100664646);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x000282B4 File Offset: 0x000264B4
		[CallerCount(0)]
		public unsafe override EntityComponent ProvideData(EntityInitializationContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatViewDataProvider.NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00028310 File Offset: 0x00026510
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 496077, RefRangeEnd = 496274, XrefRangeStart = 496077, XrefRangeEnd = 496274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatViewDataProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatViewDataProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatViewDataProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00006882 File Offset: 0x00004A82
		public PlaymatViewDataProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040005C7 RID: 1479
		private static readonly IntPtr NativeMethodInfoPtr_ProvideData_Public_Virtual_EntityComponent_EntityInitializationContext_0;

		// Token: 0x040005C8 RID: 1480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
