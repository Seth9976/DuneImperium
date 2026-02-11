using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.eventtriggers.clientactions
{
	// Token: 0x020000BB RID: 187
	public class ClientAction : GameMessage
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x00005CF9 File Offset: 0x00003EF9
		// Note: this type is marked as 'beforefieldinit'.
		static ClientAction()
		{
			Il2CppClassPointerStore<ClientAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.eventtriggers.clientactions", "ClientAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientAction>.NativeClassPtr);
			ClientAction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientAction>.NativeClassPtr, 100663672);
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00016028 File Offset: 0x00014228
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientAction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientAction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientAction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00005D32 File Offset: 0x00003F32
		public ClientAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000332 RID: 818
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
