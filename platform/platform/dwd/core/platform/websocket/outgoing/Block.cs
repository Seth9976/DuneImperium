using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace dwd.core.platform.websocket.outgoing
{
	// Token: 0x02000021 RID: 33
	public class Block : OutgoingWebSocketMessage
	{
		// Token: 0x0600017F RID: 383 RVA: 0x00002934 File Offset: 0x00000B34
		// Note: this type is marked as 'beforefieldinit'.
		static Block()
		{
			Il2CppClassPointerStore<Block>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket.outgoing", "Block");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Block>.NativeClassPtr);
			Block.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Block>.NativeClassPtr, 100663586);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000A96C File Offset: 0x00008B6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167783, XrefRangeEnd = 1167792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Block(string username)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Block>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(username);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Block.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000296D File Offset: 0x00000B6D
		public Block(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
