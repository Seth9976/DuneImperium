using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000124 RID: 292
	public sealed class DisallowMultipleComponent : Attribute
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x0000936B File Offset: 0x0000756B
		// Note: this type is marked as 'beforefieldinit'.
		static DisallowMultipleComponent()
		{
			Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "DisallowMultipleComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr);
			DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr, 100666512);
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x0006F704 File Offset: 0x0006D904
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DisallowMultipleComponent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DisallowMultipleComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DisallowMultipleComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000093A4 File Offset: 0x000075A4
		public DisallowMultipleComponent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001536 RID: 5430
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
