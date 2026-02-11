using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.eventtriggers.clientactions
{
	// Token: 0x020000BC RID: 188
	public class InstallEventResponse : ClientAction
	{
		// Token: 0x0600061D RID: 1565 RVA: 0x00016064 File Offset: 0x00014264
		// Note: this type is marked as 'beforefieldinit'.
		static InstallEventResponse()
		{
			Il2CppClassPointerStore<InstallEventResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.eventtriggers.clientactions", "InstallEventResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InstallEventResponse>.NativeClassPtr);
			InstallEventResponse.NativeFieldInfoPtr_EventResponse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InstallEventResponse>.NativeClassPtr, "EventResponse");
			InstallEventResponse.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InstallEventResponse>.NativeClassPtr, 100663673);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x000160BC File Offset: 0x000142BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1195328, RefRangeEnd = 1195329, XrefRangeStart = 1195326, XrefRangeEnd = 1195328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InstallEventResponse(ClientEventResponse eventResponse)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InstallEventResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(eventResponse);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InstallEventResponse.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00005D3B File Offset: 0x00003F3B
		public InstallEventResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00016108 File Offset: 0x00014308
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00005D44 File Offset: 0x00003F44
		public unsafe ClientEventResponse EventResponse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponse.NativeFieldInfoPtr_EventResponse);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponse>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InstallEventResponse.NativeFieldInfoPtr_EventResponse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000333 RID: 819
		private static readonly IntPtr NativeFieldInfoPtr_EventResponse;

		// Token: 0x04000334 RID: 820
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponse_0;
	}
}
