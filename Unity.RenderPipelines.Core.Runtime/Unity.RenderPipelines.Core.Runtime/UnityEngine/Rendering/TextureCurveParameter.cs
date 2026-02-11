using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E2 RID: 226
	[Serializable]
	public class TextureCurveParameter : VolumeParameter<TextureCurve>
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x0004BDF0 File Offset: 0x00049FF0
		// Note: this type is marked as 'beforefieldinit'.
		static TextureCurveParameter()
		{
			Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "TextureCurveParameter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr);
			TextureCurveParameter.NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr, 100665733);
			TextureCurveParameter.NativeMethodInfoPtr_Release_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr, 100665734);
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x0004BE48 File Offset: 0x0004A048
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 977789, RefRangeEnd = 977797, XrefRangeStart = 977786, XrefRangeEnd = 977789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextureCurveParameter(TextureCurve value, bool overrideState = false)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureCurveParameter>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref overrideState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextureCurveParameter.NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x0004BEA4 File Offset: 0x0004A0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977797, XrefRangeEnd = 977803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextureCurveParameter.NativeMethodInfoPtr_Release_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00008B59 File Offset: 0x00006D59
		public TextureCurveParameter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TextureCurve_Boolean_0;

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Void_0;
	}
}
