using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x02000214 RID: 532
	public class OnDemandRendering : Object
	{
		// Token: 0x06002250 RID: 8784 RVA: 0x00095E48 File Offset: 0x00094048
		// Note: this type is marked as 'beforefieldinit'.
		static OnDemandRendering()
		{
			Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "OnDemandRendering");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr);
			OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, "m_RenderFrameInterval");
			OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667903);
			OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnDemandRendering>.NativeClassPtr, 100667904);
			OnDemandRendering.GetEffectiveRenderFrameRateDelegateField = IL2CPP.ResolveICall<OnDemandRendering.GetEffectiveRenderFrameRateDelegate>("UnityEngine.Rendering.OnDemandRendering::GetEffectiveRenderFrameRate");
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00095EC4 File Offset: 0x000940C4
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x0000D0D4 File Offset: 0x0000B2D4
		public unsafe static int renderFrameInterval
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681910, XrefRangeEnd = 681914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				OnDemandRendering.m_RenderFrameInterval = Math.Max(1, value);
			}
		}

		// Token: 0x06002252 RID: 8786 RVA: 0x00095EF4 File Offset: 0x000940F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 681914, XrefRangeEnd = 681921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetRenderFrameInterval(out int frameInterval)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &frameInterval;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OnDemandRendering.NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002253 RID: 8787 RVA: 0x0000D0BD File Offset: 0x0000B2BD
		public OnDemandRendering(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00095F28 File Offset: 0x00094128
		// (set) Token: 0x06002255 RID: 8789 RVA: 0x0000D0C6 File Offset: 0x0000B2C6
		public unsafe static int m_RenderFrameInterval
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OnDemandRendering.NativeFieldInfoPtr_m_RenderFrameInterval, (void*)(&value));
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00095F44 File Offset: 0x00094144
		public static bool willCurrentFrameRender
		{
			get
			{
				return Time.frameCount % OnDemandRendering.renderFrameInterval == 0;
			}
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0000D0E3 File Offset: 0x0000B2E3
		public static float GetEffectiveRenderFrameRate()
		{
			return OnDemandRendering.GetEffectiveRenderFrameRateDelegateField();
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00095F64 File Offset: 0x00094164
		public static int effectiveRenderFrameRate
		{
			get
			{
				float effectiveRenderFrameRate = OnDemandRendering.GetEffectiveRenderFrameRate();
				bool flag = (double)effectiveRenderFrameRate <= 0.0;
				int num;
				if (flag)
				{
					num = (int)effectiveRenderFrameRate;
				}
				else
				{
					num = (int)(effectiveRenderFrameRate + 0.5f);
				}
				return num;
			}
		}

		// Token: 0x04001EBB RID: 7867
		private static readonly IntPtr NativeFieldInfoPtr_m_RenderFrameInterval;

		// Token: 0x04001EBC RID: 7868
		private static readonly IntPtr NativeMethodInfoPtr_get_renderFrameInterval_Public_Static_get_Int32_0;

		// Token: 0x04001EBD RID: 7869
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderFrameInterval_Internal_Static_Void_byref_Int32_0;

		// Token: 0x04001EBE RID: 7870
		private static readonly OnDemandRendering.GetEffectiveRenderFrameRateDelegate GetEffectiveRenderFrameRateDelegateField;

		// Token: 0x02000959 RID: 2393
		// (Invoke) Token: 0x06003BCC RID: 15308
		private delegate float GetEffectiveRenderFrameRateDelegate();
	}
}
