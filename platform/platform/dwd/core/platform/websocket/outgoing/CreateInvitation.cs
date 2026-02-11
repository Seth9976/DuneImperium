using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000022 RID: 34
	public class CreateInvitation : OutgoingWebSocketMessage
	{
		// Token: 0x06000182 RID: 386 RVA: 0x00002976 File Offset: 0x00000B76
		// Note: this type is marked as 'beforefieldinit'.
		static CreateInvitation()
		{
			Il2CppClassPointerStore<CreateInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "CreateInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateInvitation>.NativeClassPtr);
			CreateInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateInvitation>.NativeClassPtr, 100663587);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000A9B8 File Offset: 0x00008BB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167792, XrefRangeEnd = 1167801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CreateInvitation(string username)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateInvitation>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CreateInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000029AF File Offset: 0x00000BAF
		public CreateInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
