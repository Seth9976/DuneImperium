using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x02000055 RID: 85
	[Serializable]
	public class XRSystemData : ScriptableObject
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x0002DD04 File Offset: 0x0002BF04
		// Note: this type is marked as 'beforefieldinit'.
		static XRSystemData()
		{
			Il2CppClassPointerStore<XRSystemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "XRSystemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystemData>.NativeClassPtr);
			XRSystemData.NativeFieldInfoPtr_shaders = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystemData>.NativeClassPtr, "shaders");
			XRSystemData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemData>.NativeClassPtr, 100664115);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002DD5C File Offset: 0x0002BF5C
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 338035, RefRangeEnd = 338045, XrefRangeStart = 338035, XrefRangeEnd = 338045, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRSystemData()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRSystemData>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0000518E File Offset: 0x0000338E
		public XRSystemData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x0600070A RID: 1802 RVA: 0x0002DD98 File Offset: 0x0002BF98
		// (set) Token: 0x0600070B RID: 1803 RVA: 0x00005197 File Offset: 0x00003397
		public unsafe XRSystemData.ShaderResources shaders
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.NativeFieldInfoPtr_shaders);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<XRSystemData.ShaderResources>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.NativeFieldInfoPtr_shaders), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400056B RID: 1387
		private static readonly IntPtr NativeFieldInfoPtr_shaders;

		// Token: 0x0400056C RID: 1388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200016B RID: 363
		[Serializable]
		public sealed class ShaderResources : Object
		{
			// Token: 0x06001BFB RID: 7163 RVA: 0x000739D8 File Offset: 0x00071BD8
			// Note: this type is marked as 'beforefieldinit'.
			static ShaderResources()
			{
				Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<XRSystemData>.NativeClassPtr, "ShaderResources");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr);
				XRSystemData.ShaderResources.NativeFieldInfoPtr_xrOcclusionMeshPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr, "xrOcclusionMeshPS");
				XRSystemData.ShaderResources.NativeFieldInfoPtr_xrMirrorViewPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr, "xrMirrorViewPS");
				XRSystemData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr, 100664116);
			}

			// Token: 0x06001BFC RID: 7164 RVA: 0x00073A40 File Offset: 0x00071C40
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ShaderResources()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRSystemData.ShaderResources>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRSystemData.ShaderResources.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001BFD RID: 7165 RVA: 0x0000FE78 File Offset: 0x0000E078
			public ShaderResources(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A0B RID: 2571
			// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00073A7C File Offset: 0x00071C7C
			// (set) Token: 0x06001BFF RID: 7167 RVA: 0x0000FE81 File Offset: 0x0000E081
			public unsafe Shader xrOcclusionMeshPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.ShaderResources.NativeFieldInfoPtr_xrOcclusionMeshPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.ShaderResources.NativeFieldInfoPtr_xrOcclusionMeshPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A0C RID: 2572
			// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00073AAC File Offset: 0x00071CAC
			// (set) Token: 0x06001C01 RID: 7169 RVA: 0x0000FEA0 File Offset: 0x0000E0A0
			public unsafe Shader xrMirrorViewPS
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.ShaderResources.NativeFieldInfoPtr_xrMirrorViewPS);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRSystemData.ShaderResources.NativeFieldInfoPtr_xrMirrorViewPS), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001461 RID: 5217
			private static readonly IntPtr NativeFieldInfoPtr_xrOcclusionMeshPS;

			// Token: 0x04001462 RID: 5218
			private static readonly IntPtr NativeFieldInfoPtr_xrMirrorViewPS;

			// Token: 0x04001463 RID: 5219
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
