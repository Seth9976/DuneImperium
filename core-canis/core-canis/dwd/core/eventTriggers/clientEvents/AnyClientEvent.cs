using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace dwd.core.eventTriggers.clientEvents
{
	// Token: 0x020001B0 RID: 432
	public class AnyClientEvent : ClientEvent
	{
		// Token: 0x0600185D RID: 6237 RVA: 0x0000AAC9 File Offset: 0x00008CC9
		// Note: this type is marked as 'beforefieldinit'.
		static AnyClientEvent()
		{
			Il2CppClassPointerStore<AnyClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientEvents", "AnyClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AnyClientEvent>.NativeClassPtr);
			AnyClientEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AnyClientEvent>.NativeClassPtr, 100667203);
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x00075450 File Offset: 0x00073650
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AnyClientEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AnyClientEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AnyClientEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x0000AB02 File Offset: 0x00008D02
		public AnyClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400113B RID: 4411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
