using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x0200000F RID: 15
	public class XRDisplaySubsystemDescriptor : IntegratedSubsystemDescriptor<XRDisplaySubsystem>
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00005530 File Offset: 0x00003730
		// Note: this type is marked as 'beforefieldinit'.
		static XRDisplaySubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRDisplaySubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr);
			XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr, 100663355);
			XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_disablesLegacyVr");
			XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::get_enableBackBufferMSAA");
			XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField = IL2CPP.ResolveICall<XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate>("UnityEngine.XR.XRDisplaySubsystemDescriptor::GetAvailableMirrorBlitModeCount");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x000055A4 File Offset: 0x000037A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258828, XrefRangeEnd = 1258831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRDisplaySubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRDisplaySubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRDisplaySubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000028D2 File Offset: 0x00000AD2
		public XRDisplaySubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010E RID: 270 RVA: 0x000028DB File Offset: 0x00000ADB
		public bool disablesLegacyVr
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010F RID: 271 RVA: 0x000028ED File Offset: 0x00000AED
		public bool enableBackBufferMSAA
		{
			get
			{
				return XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000028FF File Offset: 0x00000AFF
		public int GetAvailableMirrorBlitModeCount()
		{
			return XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000D3 RID: 211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000D4 RID: 212
		private static readonly XRDisplaySubsystemDescriptor.get_disablesLegacyVrDelegate get_disablesLegacyVrDelegateField;

		// Token: 0x040000D5 RID: 213
		private static readonly XRDisplaySubsystemDescriptor.get_enableBackBufferMSAADelegate get_enableBackBufferMSAADelegateField;

		// Token: 0x040000D6 RID: 214
		private static readonly XRDisplaySubsystemDescriptor.GetAvailableMirrorBlitModeCountDelegate GetAvailableMirrorBlitModeCountDelegateField;

		// Token: 0x0200007B RID: 123
		// (Invoke) Token: 0x06000240 RID: 576
		private delegate bool get_disablesLegacyVrDelegate(IntPtr @this);

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000242 RID: 578
		private delegate bool get_enableBackBufferMSAADelegate(IntPtr @this);

		// Token: 0x0200007D RID: 125
		// (Invoke) Token: 0x06000244 RID: 580
		private delegate int GetAvailableMirrorBlitModeCountDelegate(IntPtr @this);
	}
}
