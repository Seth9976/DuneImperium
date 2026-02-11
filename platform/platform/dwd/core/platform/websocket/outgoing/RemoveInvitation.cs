using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200002E RID: 46
	public class RemoveInvitation : OutgoingWebSocketMessage
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x00002C55 File Offset: 0x00000E55
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveInvitation()
		{
			Il2CppClassPointerStore<RemoveInvitation>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "RemoveInvitation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveInvitation>.NativeClassPtr);
			RemoveInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveInvitation>.NativeClassPtr, 100663600);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000ADD4 File Offset: 0x00008FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167898, XrefRangeEnd = 1167911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveInvitation(string username, string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveInvitation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveInvitation.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002C8E File Offset: 0x00000E8E
		public RemoveInvitation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000122 RID: 290
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;
	}
}
