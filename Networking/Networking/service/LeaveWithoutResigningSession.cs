using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Networking.service
{
	// Token: 0x02000057 RID: 87
	public class LeaveWithoutResigningSession : NetworkMessageEvent
	{
		// Token: 0x060002D5 RID: 725 RVA: 0x00003D89 File Offset: 0x00001F89
		// Note: this type is marked as 'beforefieldinit'.
		static LeaveWithoutResigningSession()
		{
			Il2CppClassPointerStore<LeaveWithoutResigningSession>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.service", "LeaveWithoutResigningSession");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LeaveWithoutResigningSession>.NativeClassPtr);
			LeaveWithoutResigningSession.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LeaveWithoutResigningSession>.NativeClassPtr, 100663438);
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x0000D16C File Offset: 0x0000B36C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LeaveWithoutResigningSession()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LeaveWithoutResigningSession>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LeaveWithoutResigningSession.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00003DC2 File Offset: 0x00001FC2
		public LeaveWithoutResigningSession(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400015F RID: 351
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
