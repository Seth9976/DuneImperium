using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200002C RID: 44
	public class Ping : OutgoingWebSocketMessage
	{
		// Token: 0x060001A0 RID: 416 RVA: 0x0000ACAC File Offset: 0x00008EAC
		// Note: this type is marked as 'beforefieldinit'.
		static Ping()
		{
			Il2CppClassPointerStore<Ping>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "Ping");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Ping>.NativeClassPtr);
			Ping.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ping>.NativeClassPtr, 100663597);
			Ping.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Ping>.NativeClassPtr, 100663598);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000AD04 File Offset: 0x00008F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167868, XrefRangeEnd = 1167889, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Ping()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Ping>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Ping.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000AD40 File Offset: 0x00008F40
		public unsafe override bool RequiresAuthentication
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Ping.NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00002C0A File Offset: 0x00000E0A
		public Ping(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400011F RID: 287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000120 RID: 288
		private static readonly IntPtr NativeMethodInfoPtr_get_RequiresAuthentication_Public_Virtual_get_Boolean_0;
	}
}
