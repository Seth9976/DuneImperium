using System;
using dwd.core.eventTriggers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Networking.eventtriggers;

namespace worm.client.match
{
	// Token: 0x02000297 RID: 663
	public class WormClientEventResponder : ClientEventResponder
	{
		// Token: 0x06001B03 RID: 6915 RVA: 0x0006AFA4 File Offset: 0x000691A4
		// Note: this type is marked as 'beforefieldinit'.
		static WormClientEventResponder()
		{
			Il2CppClassPointerStore<WormClientEventResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.client.match", "WormClientEventResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormClientEventResponder>.NativeClassPtr);
			WormClientEventResponder.NativeMethodInfoPtr_InstallResponse_Public_Virtual_Void_ClientEventResponse_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormClientEventResponder>.NativeClassPtr, 100667220);
			WormClientEventResponder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormClientEventResponder>.NativeClassPtr, 100667221);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0006AFFC File Offset: 0x000691FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723981, XrefRangeEnd = 723999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InstallResponse(ClientEventResponse cer)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cer);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormClientEventResponder.NativeMethodInfoPtr_InstallResponse_Public_Virtual_Void_ClientEventResponse_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x0006B04C File Offset: 0x0006924C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723999, XrefRangeEnd = 724000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormClientEventResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormClientEventResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormClientEventResponder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x0000FB02 File Offset: 0x0000DD02
		public WormClientEventResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000F95 RID: 3989
		private static readonly IntPtr NativeMethodInfoPtr_InstallResponse_Public_Virtual_Void_ClientEventResponse_0;

		// Token: 0x04000F96 RID: 3990
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
