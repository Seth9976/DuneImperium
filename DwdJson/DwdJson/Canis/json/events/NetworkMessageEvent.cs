using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.json.events
{
	// Token: 0x0200001E RID: 30
	public class NetworkMessageEvent : DWDEvent
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x000061B4 File Offset: 0x000043B4
		// Note: this type is marked as 'beforefieldinit'.
		static NetworkMessageEvent()
		{
			Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json.events", "NetworkMessageEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr);
			NetworkMessageEvent.NativeMethodInfoPtr_get_MessageName_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr, 100663416);
			NetworkMessageEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr, 100663417);
			NetworkMessageEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr, 100663418);
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00006220 File Offset: 0x00004420
		public unsafe string MessageName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1249618, XrefRangeEnd = 1249626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageEvent.NativeMethodInfoPtr_get_MessageName_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00006258 File Offset: 0x00004458
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1249629, RefRangeEnd = 1249634, XrefRangeStart = 1249626, XrefRangeEnd = 1249629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NetworkMessageEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000629C File Offset: 0x0000449C
		[CallerCount(293)]
		[CachedScanResults(RefRangeStart = 881929, RefRangeEnd = 882222, XrefRangeStart = 881929, XrefRangeEnd = 882222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NetworkMessageEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NetworkMessageEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NetworkMessageEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000260E File Offset: 0x0000080E
		public NetworkMessageEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000094 RID: 148
		private static readonly IntPtr NativeMethodInfoPtr_get_MessageName_Public_get_String_0;

		// Token: 0x04000095 RID: 149
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000096 RID: 150
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
