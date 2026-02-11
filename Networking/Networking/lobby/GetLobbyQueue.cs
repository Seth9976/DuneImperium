using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.lobby
{
	// Token: 0x02000095 RID: 149
	public class GetLobbyQueue : NetworkMessageEvent
	{
		// Token: 0x060004F8 RID: 1272 RVA: 0x00005059 File Offset: 0x00003259
		// Note: this type is marked as 'beforefieldinit'.
		static GetLobbyQueue()
		{
			Il2CppClassPointerStore<GetLobbyQueue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.lobby", "GetLobbyQueue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetLobbyQueue>.NativeClassPtr);
			GetLobbyQueue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetLobbyQueue>.NativeClassPtr, 100663624);
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x000136A4 File Offset: 0x000118A4
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetLobbyQueue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetLobbyQueue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetLobbyQueue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00005092 File Offset: 0x00003292
		public GetLobbyQueue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002B0 RID: 688
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
