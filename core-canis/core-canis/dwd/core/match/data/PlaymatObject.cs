using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace dwd.core.match.data
{
	// Token: 0x0200016B RID: 363
	public class PlaymatObject : EntityObject
	{
		// Token: 0x06001514 RID: 5396 RVA: 0x00068710 File Offset: 0x00066910
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatObject()
		{
			Il2CppClassPointerStore<PlaymatObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.match.data", "PlaymatObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatObject>.NativeClassPtr);
			PlaymatObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatObject>.NativeClassPtr, 100666477);
			PlaymatObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatObject>.NativeClassPtr, 100666478);
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x00068768 File Offset: 0x00066968
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 875448, XrefRangeEnd = 875449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override EntityComponent getEntity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlaymatObject.NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr3) : null;
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x000687B4 File Offset: 0x000669B4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0000952E File Offset: 0x0000772E
		public PlaymatObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F09 RID: 3849
		private static readonly IntPtr NativeMethodInfoPtr_getEntity_Protected_Virtual_EntityComponent_0;

		// Token: 0x04000F0A RID: 3850
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
