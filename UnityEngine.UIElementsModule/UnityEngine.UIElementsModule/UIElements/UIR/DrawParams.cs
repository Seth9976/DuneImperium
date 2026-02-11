using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000251 RID: 593
	public class DrawParams : Object
	{
		// Token: 0x06002BD4 RID: 11220 RVA: 0x000BD580 File Offset: 0x000BB780
		// Note: this type is marked as 'beforefieldinit'.
		static DrawParams()
		{
			Il2CppClassPointerStore<DrawParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "DrawParams");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DrawParams>.NativeClassPtr);
			DrawParams.NativeFieldInfoPtr_k_UnlimitedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "k_UnlimitedRect");
			DrawParams.NativeFieldInfoPtr_k_FullNormalizedRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "k_FullNormalizedRect");
			DrawParams.NativeFieldInfoPtr_view = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "view");
			DrawParams.NativeFieldInfoPtr_scissor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "scissor");
			DrawParams.NativeFieldInfoPtr_renderTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "renderTexture");
			DrawParams.NativeFieldInfoPtr_defaultMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, "defaultMaterial");
			DrawParams.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, 100669809);
			DrawParams.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DrawParams>.NativeClassPtr, 100669810);
		}

		// Token: 0x06002BD5 RID: 11221 RVA: 0x000BD650 File Offset: 0x000BB850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349779, XrefRangeEnd = 349801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawParams.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000BD684 File Offset: 0x000BB884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349801, XrefRangeEnd = 349830, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawParams()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DrawParams>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DrawParams.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x00011C00 File Offset: 0x0000FE00
		public DrawParams(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000DA0 RID: 3488
		// (get) Token: 0x06002BD8 RID: 11224 RVA: 0x000BD6C0 File Offset: 0x000BB8C0
		// (set) Token: 0x06002BD9 RID: 11225 RVA: 0x00011C09 File Offset: 0x0000FE09
		public unsafe static Rect k_UnlimitedRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(DrawParams.NativeFieldInfoPtr_k_UnlimitedRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawParams.NativeFieldInfoPtr_k_UnlimitedRect, (void*)(&value));
			}
		}

		// Token: 0x17000DA1 RID: 3489
		// (get) Token: 0x06002BDA RID: 11226 RVA: 0x000BD6DC File Offset: 0x000BB8DC
		// (set) Token: 0x06002BDB RID: 11227 RVA: 0x00011C17 File Offset: 0x0000FE17
		public unsafe static Rect k_FullNormalizedRect
		{
			get
			{
				Rect rect;
				IL2CPP.il2cpp_field_static_get_value(DrawParams.NativeFieldInfoPtr_k_FullNormalizedRect, (void*)(&rect));
				return rect;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DrawParams.NativeFieldInfoPtr_k_FullNormalizedRect, (void*)(&value));
			}
		}

		// Token: 0x17000DA2 RID: 3490
		// (get) Token: 0x06002BDC RID: 11228 RVA: 0x000BD6F8 File Offset: 0x000BB8F8
		// (set) Token: 0x06002BDD RID: 11229 RVA: 0x00011C25 File Offset: 0x0000FE25
		public unsafe Stack<Matrix4x4> view
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_view);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Matrix4x4>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_view), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002BDE RID: 11230 RVA: 0x000BD728 File Offset: 0x000BB928
		// (set) Token: 0x06002BDF RID: 11231 RVA: 0x00011C44 File Offset: 0x0000FE44
		public unsafe Stack<Rect> scissor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_scissor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack<Rect>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_scissor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002BE0 RID: 11232 RVA: 0x000BD758 File Offset: 0x000BB958
		// (set) Token: 0x06002BE1 RID: 11233 RVA: 0x00011C63 File Offset: 0x0000FE63
		public unsafe List<RenderTexture> renderTexture
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_renderTexture);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_renderTexture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002BE2 RID: 11234 RVA: 0x000BD788 File Offset: 0x000BB988
		// (set) Token: 0x06002BE3 RID: 11235 RVA: 0x00011C82 File Offset: 0x0000FE82
		public unsafe List<Material> defaultMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_defaultMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Material>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DrawParams.NativeFieldInfoPtr_defaultMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F40 RID: 8000
		private static readonly IntPtr NativeFieldInfoPtr_k_UnlimitedRect;

		// Token: 0x04001F41 RID: 8001
		private static readonly IntPtr NativeFieldInfoPtr_k_FullNormalizedRect;

		// Token: 0x04001F42 RID: 8002
		private static readonly IntPtr NativeFieldInfoPtr_view;

		// Token: 0x04001F43 RID: 8003
		private static readonly IntPtr NativeFieldInfoPtr_scissor;

		// Token: 0x04001F44 RID: 8004
		private static readonly IntPtr NativeFieldInfoPtr_renderTexture;

		// Token: 0x04001F45 RID: 8005
		private static readonly IntPtr NativeFieldInfoPtr_defaultMaterial;

		// Token: 0x04001F46 RID: 8006
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04001F47 RID: 8007
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
