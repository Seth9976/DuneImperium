using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages
{
	// Token: 0x02000024 RID: 36
	public class IdleResignFromGame : GameMessage
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00002C65 File Offset: 0x00000E65
		// Note: this type is marked as 'beforefieldinit'.
		static IdleResignFromGame()
		{
			Il2CppClassPointerStore<IdleResignFromGame>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages", "IdleResignFromGame");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IdleResignFromGame>.NativeClassPtr);
			IdleResignFromGame.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IdleResignFromGame>.NativeClassPtr, 100663358);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000914C File Offset: 0x0000734C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IdleResignFromGame()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IdleResignFromGame>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IdleResignFromGame.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002C9E File Offset: 0x00000E9E
		public IdleResignFromGame(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000098 RID: 152
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
