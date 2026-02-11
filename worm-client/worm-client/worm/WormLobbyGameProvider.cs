using System;
using boardgames.data;
using boardgames.menus;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Networking.game;

namespace worm
{
	// Token: 0x02000052 RID: 82
	public class WormLobbyGameProvider : DBGLobbyGameProvider
	{
		// Token: 0x06000357 RID: 855 RVA: 0x0002339C File Offset: 0x0002159C
		// Note: this type is marked as 'beforefieldinit'.
		static WormLobbyGameProvider()
		{
			Il2CppClassPointerStore<WormLobbyGameProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm", "WormLobbyGameProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormLobbyGameProvider>.NativeClassPtr);
			WormLobbyGameProvider.NativeMethodInfoPtr_createPendingGameData_Protected_Virtual_PendingGameData_DWDPendingGameMetadata_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLobbyGameProvider>.NativeClassPtr, 100663845);
			WormLobbyGameProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormLobbyGameProvider>.NativeClassPtr, 100663846);
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000233F4 File Offset: 0x000215F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691583, XrefRangeEnd = 691589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override PendingGameData createPendingGameData(DWDPendingGameMetadata message)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormLobbyGameProvider.NativeMethodInfoPtr_createPendingGameData_Protected_Virtual_PendingGameData_DWDPendingGameMetadata_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PendingGameData>(intPtr3) : null;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00023450 File Offset: 0x00021650
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 691589, XrefRangeEnd = 691590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormLobbyGameProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormLobbyGameProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormLobbyGameProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000384F File Offset: 0x00001A4F
		public WormLobbyGameProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001FF RID: 511
		private static readonly IntPtr NativeMethodInfoPtr_createPendingGameData_Protected_Virtual_PendingGameData_DWDPendingGameMetadata_0;

		// Token: 0x04000200 RID: 512
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
