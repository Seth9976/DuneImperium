using System;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.messages.timer
{
	// Token: 0x02000037 RID: 55
	public class GetServerTime : NetworkMessageEvent
	{
		// Token: 0x060001D6 RID: 470 RVA: 0x00003400 File Offset: 0x00001600
		// Note: this type is marked as 'beforefieldinit'.
		static GetServerTime()
		{
			Il2CppClassPointerStore<GetServerTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Canis.messages.timer", "GetServerTime");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GetServerTime>.NativeClassPtr);
			GetServerTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GetServerTime>.NativeClassPtr, 100663387);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000A998 File Offset: 0x00008B98
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 530639, RefRangeEnd = 530753, XrefRangeStart = 530639, XrefRangeEnd = 530753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GetServerTime()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GetServerTime>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GetServerTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00003439 File Offset: 0x00001639
		public GetServerTime(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
