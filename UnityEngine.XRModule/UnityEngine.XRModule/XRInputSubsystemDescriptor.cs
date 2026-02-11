using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.XR
{
	// Token: 0x02000011 RID: 17
	public class XRInputSubsystemDescriptor : IntegratedSubsystemDescriptor<XRInputSubsystem>
	{
		// Token: 0x06000127 RID: 295 RVA: 0x00005810 File Offset: 0x00003A10
		// Note: this type is marked as 'beforefieldinit'.
		static XRInputSubsystemDescriptor()
		{
			Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.XRModule.dll", "UnityEngine.XR", "XRInputSubsystemDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr);
			XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr, 100663359);
			XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField = IL2CPP.ResolveICall<XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate>("UnityEngine.XR.XRInputSubsystemDescriptor::get_disablesLegacyInput");
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00005864 File Offset: 0x00003A64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1258848, XrefRangeEnd = 1258851, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRInputSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRInputSubsystemDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRInputSubsystemDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002A24 File Offset: 0x00000C24
		public XRInputSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600012A RID: 298 RVA: 0x00002A2D File Offset: 0x00000C2D
		public bool disablesLegacyInput
		{
			get
			{
				return XRInputSubsystemDescriptor.get_disablesLegacyInputDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000E4 RID: 228
		private static readonly XRInputSubsystemDescriptor.get_disablesLegacyInputDelegate get_disablesLegacyInputDelegateField;

		// Token: 0x02000085 RID: 133
		// (Invoke) Token: 0x06000254 RID: 596
		private delegate bool get_disablesLegacyInputDelegate(IntPtr @this);
	}
}
