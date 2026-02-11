using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering.RenderGraphModule;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000F3 RID: 243
	public class ClearTargetsPass : Object
	{
		// Token: 0x0600132F RID: 4911 RVA: 0x00057794 File Offset: 0x00055994
		// Note: this type is marked as 'beforefieldinit'.
		static ClearTargetsPass()
		{
			Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "ClearTargetsPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr);
			ClearTargetsPass.NativeFieldInfoPtr_s_ClearProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr, "s_ClearProfilingSampler");
			ClearTargetsPass.NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_UniversalRenderer_RTClearFlags_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr, 100665681);
			ClearTargetsPass.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr, 100665682);
		}

		// Token: 0x06001330 RID: 4912 RVA: 0x00057800 File Offset: 0x00055A00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 620545, RefRangeEnd = 620546, XrefRangeStart = 620507, XrefRangeEnd = 620545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Render(RenderGraph graph, UniversalRenderer renderer, RTClearFlags clearFlags, Color clearColor)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(graph);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderer);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearFlags;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearColor;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTargetsPass.NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_UniversalRenderer_RTClearFlags_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001331 RID: 4913 RVA: 0x00057864 File Offset: 0x00055A64
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ClearTargetsPass()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTargetsPass.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001332 RID: 4914 RVA: 0x0000B566 File Offset: 0x00009766
		public ClearTargetsPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x000578A0 File Offset: 0x00055AA0
		// (set) Token: 0x06001334 RID: 4916 RVA: 0x0000B56F File Offset: 0x0000976F
		public unsafe static ProfilingSampler s_ClearProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ClearTargetsPass.NativeFieldInfoPtr_s_ClearProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ClearTargetsPass.NativeFieldInfoPtr_s_ClearProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E0F RID: 3599
		private static readonly IntPtr NativeFieldInfoPtr_s_ClearProfilingSampler;

		// Token: 0x04000E10 RID: 3600
		private static readonly IntPtr NativeMethodInfoPtr_Render_Internal_Static_Void_RenderGraph_UniversalRenderer_RTClearFlags_Color_0;

		// Token: 0x04000E11 RID: 3601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001CE RID: 462
		public class PassData : Object
		{
			// Token: 0x060020BB RID: 8379 RVA: 0x0007F428 File Offset: 0x0007D628
			// Note: this type is marked as 'beforefieldinit'.
			static PassData()
			{
				Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr, "PassData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr);
				ClearTargetsPass.PassData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr, "color");
				ClearTargetsPass.PassData.NativeFieldInfoPtr_depth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr, "depth");
				ClearTargetsPass.PassData.NativeFieldInfoPtr_clearFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr, "clearFlags");
				ClearTargetsPass.PassData.NativeFieldInfoPtr_clearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr, "clearColor");
				ClearTargetsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr, 100665684);
			}

			// Token: 0x060020BC RID: 8380 RVA: 0x0007F4B8 File Offset: 0x0007D6B8
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PassData()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearTargetsPass.PassData>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTargetsPass.PassData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020BD RID: 8381 RVA: 0x00012CAA File Offset: 0x00010EAA
			public PassData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BCC RID: 3020
			// (get) Token: 0x060020BE RID: 8382 RVA: 0x0007F4F4 File Offset: 0x0007D6F4
			// (set) Token: 0x060020BF RID: 8383 RVA: 0x00012CB3 File Offset: 0x00010EB3
			public unsafe TextureHandle color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x17000BCD RID: 3021
			// (get) Token: 0x060020C0 RID: 8384 RVA: 0x0007F51C File Offset: 0x0007D71C
			// (set) Token: 0x060020C1 RID: 8385 RVA: 0x00012CCE File Offset: 0x00010ECE
			public unsafe TextureHandle depth
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_depth);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_depth)) = value;
				}
			}

			// Token: 0x17000BCE RID: 3022
			// (get) Token: 0x060020C2 RID: 8386 RVA: 0x0007F544 File Offset: 0x0007D744
			// (set) Token: 0x060020C3 RID: 8387 RVA: 0x00012CE9 File Offset: 0x00010EE9
			public unsafe RTClearFlags clearFlags
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_clearFlags);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_clearFlags)) = value;
				}
			}

			// Token: 0x17000BCF RID: 3023
			// (get) Token: 0x060020C4 RID: 8388 RVA: 0x0007F56C File Offset: 0x0007D76C
			// (set) Token: 0x060020C5 RID: 8389 RVA: 0x00012D04 File Offset: 0x00010F04
			public unsafe Color clearColor
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_clearColor);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ClearTargetsPass.PassData.NativeFieldInfoPtr_clearColor)) = value;
				}
			}

			// Token: 0x0400174E RID: 5966
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400174F RID: 5967
			private static readonly IntPtr NativeFieldInfoPtr_depth;

			// Token: 0x04001750 RID: 5968
			private static readonly IntPtr NativeFieldInfoPtr_clearFlags;

			// Token: 0x04001751 RID: 5969
			private static readonly IntPtr NativeFieldInfoPtr_clearColor;

			// Token: 0x04001752 RID: 5970
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020001CF RID: 463
		[ObfuscatedName("UnityEngine.Rendering.Universal.ClearTargetsPass+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060020C6 RID: 8390 RVA: 0x0007F594 File Offset: 0x0007D794
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClearTargetsPass>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr);
				ClearTargetsPass.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr, "<>9");
				ClearTargetsPass.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr, "<>9__2_0");
				ClearTargetsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr, 100665686);
				ClearTargetsPass.__c.NativeMethodInfoPtr__Render_b__2_0_Internal_Void_PassData_RenderGraphContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr, 100665687);
			}

			// Token: 0x060020C7 RID: 8391 RVA: 0x0007F610 File Offset: 0x0007D810
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClearTargetsPass.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTargetsPass.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C8 RID: 8392 RVA: 0x0007F64C File Offset: 0x0007D84C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 620506, XrefRangeEnd = 620507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Render_b__2_0(ClearTargetsPass.PassData data, RenderGraphContext context)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ClearTargetsPass.__c.NativeMethodInfoPtr__Render_b__2_0_Internal_Void_PassData_RenderGraphContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060020C9 RID: 8393 RVA: 0x00012D1F File Offset: 0x00010F1F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000BD0 RID: 3024
			// (get) Token: 0x060020CA RID: 8394 RVA: 0x0007F6A0 File Offset: 0x0007D8A0
			// (set) Token: 0x060020CB RID: 8395 RVA: 0x00012D28 File Offset: 0x00010F28
			public unsafe static ClearTargetsPass.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearTargetsPass.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ClearTargetsPass.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearTargetsPass.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000BD1 RID: 3025
			// (get) Token: 0x060020CC RID: 8396 RVA: 0x0007F6C8 File Offset: 0x0007D8C8
			// (set) Token: 0x060020CD RID: 8397 RVA: 0x00012D3A File Offset: 0x00010F3A
			public unsafe static RenderFunc<ClearTargetsPass.PassData> __9__2_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ClearTargetsPass.__c.NativeFieldInfoPtr___9__2_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderFunc<ClearTargetsPass.PassData>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ClearTargetsPass.__c.NativeFieldInfoPtr___9__2_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001753 RID: 5971
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001754 RID: 5972
			private static readonly IntPtr NativeFieldInfoPtr___9__2_0;

			// Token: 0x04001755 RID: 5973
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001756 RID: 5974
			private static readonly IntPtr NativeMethodInfoPtr__Render_b__2_0_Internal_Void_PassData_RenderGraphContext_0;
		}
	}
}
