using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200002D RID: 45
	public class RemoveBlocked : OutgoingWebSocketMessage
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002C13 File Offset: 0x00000E13
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveBlocked()
		{
			Il2CppClassPointerStore<RemoveBlocked>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "RemoveBlocked");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveBlocked>.NativeClassPtr);
			RemoveBlocked.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveBlocked>.NativeClassPtr, 100663599);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000AD88 File Offset: 0x00008F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167889, XrefRangeEnd = 1167898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveBlocked(string accountID)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveBlocked>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountID);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveBlocked.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002C4C File Offset: 0x00000E4C
		public RemoveBlocked(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000121 RID: 289
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
