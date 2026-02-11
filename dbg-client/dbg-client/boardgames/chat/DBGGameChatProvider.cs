using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lotus;

namespace boardgames.chat
{
	// Token: 0x02000244 RID: 580
	public class DBGGameChatProvider : GameChatProvider
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		// Note: this type is marked as 'beforefieldinit'.
		static DBGGameChatProvider()
		{
			Il2CppClassPointerStore<DBGGameChatProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.chat", "DBGGameChatProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DBGGameChatProvider>.NativeClassPtr);
			DBGGameChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DBGGameChatProvider>.NativeClassPtr, 100667459);
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x00072B50 File Offset: 0x00070D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 531398, XrefRangeEnd = 531399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DBGGameChatProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DBGGameChatProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DBGGameChatProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0000E601 File Offset: 0x0000C801
		public DBGGameChatProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001052 RID: 4178
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
