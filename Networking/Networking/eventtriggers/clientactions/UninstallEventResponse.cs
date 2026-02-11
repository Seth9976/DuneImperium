using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.eventtriggers.clientactions
{
	// Token: 0x020000BE RID: 190
	public sealed class UninstallEventResponse : ClientAction
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x000163A4 File Offset: 0x000145A4
		// Note: this type is marked as 'beforefieldinit'.
		static UninstallEventResponse()
		{
			Il2CppClassPointerStore<UninstallEventResponse>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.eventtriggers.clientactions", "UninstallEventResponse");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UninstallEventResponse>.NativeClassPtr);
			UninstallEventResponse.NativeFieldInfoPtr_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UninstallEventResponse>.NativeClassPtr, "Handle");
			UninstallEventResponse.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UninstallEventResponse>.NativeClassPtr, 100663675);
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x000163FC File Offset: 0x000145FC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1195328, RefRangeEnd = 1195329, XrefRangeStart = 1195328, XrefRangeEnd = 1195329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UninstallEventResponse(ClientEventResponseID handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UninstallEventResponse>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UninstallEventResponse.NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00005E1E File Offset: 0x0000401E
		public UninstallEventResponse(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00016448 File Offset: 0x00014648
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x00005E27 File Offset: 0x00004027
		public unsafe ClientEventResponseID Handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponse.NativeFieldInfoPtr_Handle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClientEventResponseID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UninstallEventResponse.NativeFieldInfoPtr_Handle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400033C RID: 828
		private static readonly IntPtr NativeFieldInfoPtr_Handle;

		// Token: 0x0400033D RID: 829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ClientEventResponseID_0;
	}
}
