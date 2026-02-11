using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200005A RID: 90
	[Serializable]
	public class XRGraphics : Object
	{
		// Token: 0x06000631 RID: 1585 RVA: 0x00025014 File Offset: 0x00023214
		// Note: this type is marked as 'beforefieldinit'.
		static XRGraphics()
		{
			Il2CppClassPointerStore<XRGraphics>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "XRGraphics");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr);
			XRGraphics.NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664101);
			XRGraphics.NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664102);
			XRGraphics.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664103);
			XRGraphics.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664104);
			XRGraphics.NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664105);
			XRGraphics.NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664106);
			XRGraphics.NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664107);
			XRGraphics.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664108);
			XRGraphics.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664109);
			XRGraphics.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664110);
			XRGraphics.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664111);
			XRGraphics.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr, 100664112);
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x00025134 File Offset: 0x00023334
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x00025164 File Offset: 0x00023364
		public unsafe static float eyeTextureResolutionScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960786, XrefRangeEnd = 960787, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960787, XrefRangeEnd = 960788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x00025198 File Offset: 0x00023398
		public unsafe static float renderViewportScale
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960788, XrefRangeEnd = 960789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000635 RID: 1589 RVA: 0x000251C8 File Offset: 0x000233C8
		public unsafe static bool enabled
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 960790, RefRangeEnd = 960791, XrefRangeStart = 960789, XrefRangeEnd = 960790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x000251F8 File Offset: 0x000233F8
		public unsafe static bool isDeviceActive
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960791, XrefRangeEnd = 960792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000637 RID: 1591 RVA: 0x00025228 File Offset: 0x00023428
		public unsafe static string loadedDeviceName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960792, XrefRangeEnd = 960795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000638 RID: 1592 RVA: 0x00025254 File Offset: 0x00023454
		public unsafe static Il2CppStringArray supportedDevices
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960795, XrefRangeEnd = 960800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00025288 File Offset: 0x00023488
		public unsafe static XRGraphics.StereoRenderingMode stereoRenderingMode
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960800, XrefRangeEnd = 960801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x000252B8 File Offset: 0x000234B8
		public unsafe static RenderTextureDescriptor eyeTextureDesc
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960801, XrefRangeEnd = 960803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x000252E8 File Offset: 0x000234E8
		public unsafe static int eyeTextureWidth
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960803, XrefRangeEnd = 960804, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x0600063C RID: 1596 RVA: 0x00025318 File Offset: 0x00023518
		public unsafe static int eyeTextureHeight
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960804, XrefRangeEnd = 960805, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00025348 File Offset: 0x00023548
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRGraphics()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRGraphics>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphics.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x000047E9 File Offset: 0x000029E9
		public XRGraphics(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400048A RID: 1162
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureResolutionScale_Public_Static_get_Single_0;

		// Token: 0x0400048B RID: 1163
		private static readonly IntPtr NativeMethodInfoPtr_set_eyeTextureResolutionScale_Public_Static_set_Void_Single_0;

		// Token: 0x0400048C RID: 1164
		private static readonly IntPtr NativeMethodInfoPtr_get_renderViewportScale_Public_Static_get_Single_0;

		// Token: 0x0400048D RID: 1165
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x0400048E RID: 1166
		private static readonly IntPtr NativeMethodInfoPtr_get_isDeviceActive_Public_Static_get_Boolean_0;

		// Token: 0x0400048F RID: 1167
		private static readonly IntPtr NativeMethodInfoPtr_get_loadedDeviceName_Public_Static_get_String_0;

		// Token: 0x04000490 RID: 1168
		private static readonly IntPtr NativeMethodInfoPtr_get_supportedDevices_Public_Static_get_Il2CppStringArray_0;

		// Token: 0x04000491 RID: 1169
		private static readonly IntPtr NativeMethodInfoPtr_get_stereoRenderingMode_Public_Static_get_StereoRenderingMode_0;

		// Token: 0x04000492 RID: 1170
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureDesc_Public_Static_get_RenderTextureDescriptor_0;

		// Token: 0x04000493 RID: 1171
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureWidth_Public_Static_get_Int32_0;

		// Token: 0x04000494 RID: 1172
		private static readonly IntPtr NativeMethodInfoPtr_get_eyeTextureHeight_Public_Static_get_Int32_0;

		// Token: 0x04000495 RID: 1173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000185 RID: 389
		public enum StereoRenderingMode
		{
			// Token: 0x04001042 RID: 4162
			MultiPass,
			// Token: 0x04001043 RID: 4163
			SinglePass,
			// Token: 0x04001044 RID: 4164
			SinglePassInstanced,
			// Token: 0x04001045 RID: 4165
			SinglePassMultiView
		}
	}
}
