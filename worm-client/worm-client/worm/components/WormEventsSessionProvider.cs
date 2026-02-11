using System;
using boardgames.menus;
using Canis.json.events;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace worm.components
{
	// Token: 0x0200007C RID: 124
	public class WormEventsSessionProvider : OnlinePlaySessionProvider
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x00027950 File Offset: 0x00025B50
		// Note: this type is marked as 'beforefieldinit'.
		static WormEventsSessionProvider()
		{
			Il2CppClassPointerStore<WormEventsSessionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.components", "WormEventsSessionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsSessionProvider>.NativeClassPtr);
			WormEventsSessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSessionProvider>.NativeClassPtr, 100663999);
			WormEventsSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsSessionProvider>.NativeClassPtr, 100664000);
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x000279A8 File Offset: 0x00025BA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 694337, XrefRangeEnd = 694359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override NetworkMessageEvent RegisterUser(Dictionary<string, string> metadata)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(metadata);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsSessionProvider.NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<NetworkMessageEvent>(intPtr3) : null;
			}
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00027A04 File Offset: 0x00025C04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormEventsSessionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsSessionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsSessionProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x000045E8 File Offset: 0x000027E8
		public WormEventsSessionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040002CC RID: 716
		private static readonly IntPtr NativeMethodInfoPtr_RegisterUser_Protected_Virtual_NetworkMessageEvent_Dictionary_2_String_String_0;

		// Token: 0x040002CD RID: 717
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
