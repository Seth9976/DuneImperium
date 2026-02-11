using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.clientevents;

namespace dwd.core.eventTriggers.clientEvents
{
	// Token: 0x020001B1 RID: 433
	public class NeverClientEvent : ClientEvent
	{
		// Token: 0x06001860 RID: 6240 RVA: 0x0000AB0B File Offset: 0x00008D0B
		// Note: this type is marked as 'beforefieldinit'.
		static NeverClientEvent()
		{
			Il2CppClassPointerStore<NeverClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.eventTriggers.clientEvents", "NeverClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NeverClientEvent>.NativeClassPtr);
			NeverClientEvent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NeverClientEvent>.NativeClassPtr, 100667204);
		}

		// Token: 0x06001861 RID: 6241 RVA: 0x0007548C File Offset: 0x0007368C
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NeverClientEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NeverClientEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NeverClientEvent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001862 RID: 6242 RVA: 0x0000AB44 File Offset: 0x00008D44
		public NeverClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400113C RID: 4412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
