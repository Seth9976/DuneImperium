using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.clientevents
{
	// Token: 0x020000B9 RID: 185
	public class ClientEvent : Object
	{
		// Token: 0x0600060C RID: 1548 RVA: 0x00015DAC File Offset: 0x00013FAC
		// Note: this type is marked as 'beforefieldinit'.
		static ClientEvent()
		{
			Il2CppClassPointerStore<ClientEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.clientevents", "ClientEvent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientEvent>.NativeClassPtr);
			ClientEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEvent>.NativeClassPtr, 100663668);
			ClientEvent.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientEvent>.NativeClassPtr, 100663669);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00015E04 File Offset: 0x00014004
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195322, XrefRangeEnd = 1195324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ClientEvent.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00015E48 File Offset: 0x00014048
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClientEvent()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientEvent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClientEvent.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x00005C8A File Offset: 0x00003E8A
		public ClientEvent(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
