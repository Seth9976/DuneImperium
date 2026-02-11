using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000030 RID: 48
	public class SetStatus : OutgoingWebSocketMessage
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00002CD9 File Offset: 0x00000ED9
		// Note: this type is marked as 'beforefieldinit'.
		static SetStatus()
		{
			Il2CppClassPointerStore<SetStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "SetStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetStatus>.NativeClassPtr);
			SetStatus.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetStatus>.NativeClassPtr, 100663602);
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000AE80 File Offset: 0x00009080
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1167929, RefRangeEnd = 1167931, XrefRangeStart = 1167920, XrefRangeEnd = 1167929, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SetStatus(string status)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetStatus>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(status);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SetStatus.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002D12 File Offset: 0x00000F12
		public SetStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000124 RID: 292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
