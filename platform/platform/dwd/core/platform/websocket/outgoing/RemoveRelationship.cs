using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x0200002F RID: 47
	public class RemoveRelationship : OutgoingWebSocketMessage
	{
		// Token: 0x060001AA RID: 426 RVA: 0x00002C97 File Offset: 0x00000E97
		// Note: this type is marked as 'beforefieldinit'.
		static RemoveRelationship()
		{
			Il2CppClassPointerStore<RemoveRelationship>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "RemoveRelationship");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoveRelationship>.NativeClassPtr);
			RemoveRelationship.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoveRelationship>.NativeClassPtr, 100663601);
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000AE34 File Offset: 0x00009034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167911, XrefRangeEnd = 1167920, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RemoveRelationship(string accountId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RemoveRelationship>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(accountId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoveRelationship.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002CD0 File Offset: 0x00000ED0
		public RemoveRelationship(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000123 RID: 291
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
