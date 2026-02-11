using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering.Universal.Internal;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000BA RID: 186
	public sealed class PostProcessPasses : ValueType
	{
		// Token: 0x06000EB8 RID: 3768 RVA: 0x0004839C File Offset: 0x0004659C
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessPasses()
		{
			Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "PostProcessPasses");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr);
			PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLutPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_ColorGradingLutPass");
			PostProcessPasses.NativeFieldInfoPtr_m_PostProcessPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_PostProcessPass");
			PostProcessPasses.NativeFieldInfoPtr_m_FinalPostProcessPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_FinalPostProcessPass");
			PostProcessPasses.NativeFieldInfoPtr_m_AfterPostProcessColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_AfterPostProcessColor");
			PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_ColorGradingLut");
			PostProcessPasses.NativeFieldInfoPtr_m_RendererPostProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_RendererPostProcessData");
			PostProcessPasses.NativeFieldInfoPtr_m_CurrentPostProcessData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_CurrentPostProcessData");
			PostProcessPasses.NativeFieldInfoPtr_m_BlitMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, "m_BlitMaterial");
			PostProcessPasses.NativeMethodInfoPtr_get_colorGradingLutPass_Public_get_ColorGradingLutPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665181);
			PostProcessPasses.NativeMethodInfoPtr_get_postProcessPass_Public_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665182);
			PostProcessPasses.NativeMethodInfoPtr_get_finalPostProcessPass_Public_get_PostProcessPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665183);
			PostProcessPasses.NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665184);
			PostProcessPasses.NativeMethodInfoPtr_get_colorGradingLut_Public_get_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665185);
			PostProcessPasses.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665186);
			PostProcessPasses.NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_byref_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665187);
			PostProcessPasses.NativeMethodInfoPtr_Recreate_Public_Void_PostProcessData_byref_PostProcessParams_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665188);
			PostProcessPasses.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665189);
			PostProcessPasses.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr, 100665190);
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000EB9 RID: 3769 RVA: 0x00048534 File Offset: 0x00046734
		public unsafe ColorGradingLutPass colorGradingLutPass
		{
			[CallerCount(99)]
			[CachedScanResults(RefRangeStart = 306117, RefRangeEnd = 306216, XrefRangeStart = 306117, XrefRangeEnd = 306216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_colorGradingLutPass_Public_get_ColorGradingLutPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass>(intPtr3) : null;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000EBA RID: 3770 RVA: 0x00048578 File Offset: 0x00046778
		public unsafe PostProcessPass postProcessPass
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_postProcessPass_Public_get_PostProcessPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000EBB RID: 3771 RVA: 0x000485BC File Offset: 0x000467BC
		public unsafe PostProcessPass finalPostProcessPass
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_finalPostProcessPass_Public_get_PostProcessPass_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr3) : null;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00048600 File Offset: 0x00046800
		public unsafe RTHandle afterPostProcessColor
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06000EBD RID: 3773 RVA: 0x00048644 File Offset: 0x00046844
		public unsafe RTHandle colorGradingLut
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_colorGradingLut_Public_get_RTHandle_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr3) : null;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06000EBE RID: 3774 RVA: 0x00048688 File Offset: 0x00046888
		public unsafe bool isCreated
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 614445, RefRangeEnd = 614452, XrefRangeStart = 614441, XrefRangeEnd = 614445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x000486CC File Offset: 0x000468CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614461, RefRangeEnd = 614463, XrefRangeStart = 614452, XrefRangeEnd = 614461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessPasses(PostProcessData rendererPostProcessData, ref PostProcessParams postProcessParams)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rendererPostProcessData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(postProcessParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_byref_PostProcessParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x00048730 File Offset: 0x00046930
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614498, RefRangeEnd = 614499, XrefRangeStart = 614463, XrefRangeEnd = 614498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Recreate(PostProcessData data, ref PostProcessParams ppParams)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(ppParams);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_Recreate_Public_Void_PostProcessData_byref_PostProcessParams_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0004878C File Offset: 0x0004698C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614504, RefRangeEnd = 614506, XrefRangeStart = 614499, XrefRangeEnd = 614504, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x000487C4 File Offset: 0x000469C4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614510, RefRangeEnd = 614512, XrefRangeStart = 614506, XrefRangeEnd = 614510, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReleaseRenderTargets()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessPasses.NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Void_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x00009121 File Offset: 0x00007321
		public PostProcessPasses(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0000912A File Offset: 0x0000732A
		public PostProcessPasses()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessPasses>.NativeClassPtr))
		{
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000487FC File Offset: 0x000469FC
		// (set) Token: 0x06000EC6 RID: 3782 RVA: 0x0000913C File Offset: 0x0000733C
		public unsafe ColorGradingLutPass m_ColorGradingLutPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLutPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingLutPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLutPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x0004882C File Offset: 0x00046A2C
		// (set) Token: 0x06000EC8 RID: 3784 RVA: 0x0000915B File Offset: 0x0000735B
		public unsafe PostProcessPass m_PostProcessPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_PostProcessPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_PostProcessPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x06000EC9 RID: 3785 RVA: 0x0004885C File Offset: 0x00046A5C
		// (set) Token: 0x06000ECA RID: 3786 RVA: 0x0000917A File Offset: 0x0000737A
		public unsafe PostProcessPass m_FinalPostProcessPass
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_FinalPostProcessPass);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessPass>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_FinalPostProcessPass), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0004888C File Offset: 0x00046A8C
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x00009199 File Offset: 0x00007399
		public unsafe RTHandle m_AfterPostProcessColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_AfterPostProcessColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_AfterPostProcessColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06000ECD RID: 3789 RVA: 0x000488BC File Offset: 0x00046ABC
		// (set) Token: 0x06000ECE RID: 3790 RVA: 0x000091B8 File Offset: 0x000073B8
		public unsafe RTHandle m_ColorGradingLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_ColorGradingLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000ECF RID: 3791 RVA: 0x000488EC File Offset: 0x00046AEC
		// (set) Token: 0x06000ED0 RID: 3792 RVA: 0x000091D7 File Offset: 0x000073D7
		public unsafe PostProcessData m_RendererPostProcessData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_RendererPostProcessData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_RendererPostProcessData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000ED1 RID: 3793 RVA: 0x0004891C File Offset: 0x00046B1C
		// (set) Token: 0x06000ED2 RID: 3794 RVA: 0x000091F6 File Offset: 0x000073F6
		public unsafe PostProcessData m_CurrentPostProcessData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_CurrentPostProcessData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PostProcessData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_CurrentPostProcessData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000ED3 RID: 3795 RVA: 0x0004894C File Offset: 0x00046B4C
		// (set) Token: 0x06000ED4 RID: 3796 RVA: 0x00009215 File Offset: 0x00007415
		public unsafe Material m_BlitMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_BlitMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessPasses.NativeFieldInfoPtr_m_BlitMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000ABB RID: 2747
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradingLutPass;

		// Token: 0x04000ABC RID: 2748
		private static readonly IntPtr NativeFieldInfoPtr_m_PostProcessPass;

		// Token: 0x04000ABD RID: 2749
		private static readonly IntPtr NativeFieldInfoPtr_m_FinalPostProcessPass;

		// Token: 0x04000ABE RID: 2750
		private static readonly IntPtr NativeFieldInfoPtr_m_AfterPostProcessColor;

		// Token: 0x04000ABF RID: 2751
		private static readonly IntPtr NativeFieldInfoPtr_m_ColorGradingLut;

		// Token: 0x04000AC0 RID: 2752
		private static readonly IntPtr NativeFieldInfoPtr_m_RendererPostProcessData;

		// Token: 0x04000AC1 RID: 2753
		private static readonly IntPtr NativeFieldInfoPtr_m_CurrentPostProcessData;

		// Token: 0x04000AC2 RID: 2754
		private static readonly IntPtr NativeFieldInfoPtr_m_BlitMaterial;

		// Token: 0x04000AC3 RID: 2755
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLutPass_Public_get_ColorGradingLutPass_0;

		// Token: 0x04000AC4 RID: 2756
		private static readonly IntPtr NativeMethodInfoPtr_get_postProcessPass_Public_get_PostProcessPass_0;

		// Token: 0x04000AC5 RID: 2757
		private static readonly IntPtr NativeMethodInfoPtr_get_finalPostProcessPass_Public_get_PostProcessPass_0;

		// Token: 0x04000AC6 RID: 2758
		private static readonly IntPtr NativeMethodInfoPtr_get_afterPostProcessColor_Public_get_RTHandle_0;

		// Token: 0x04000AC7 RID: 2759
		private static readonly IntPtr NativeMethodInfoPtr_get_colorGradingLut_Public_get_RTHandle_0;

		// Token: 0x04000AC8 RID: 2760
		private static readonly IntPtr NativeMethodInfoPtr_get_isCreated_Public_get_Boolean_0;

		// Token: 0x04000AC9 RID: 2761
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PostProcessData_byref_PostProcessParams_0;

		// Token: 0x04000ACA RID: 2762
		private static readonly IntPtr NativeMethodInfoPtr_Recreate_Public_Void_PostProcessData_byref_PostProcessParams_0;

		// Token: 0x04000ACB RID: 2763
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000ACC RID: 2764
		private static readonly IntPtr NativeMethodInfoPtr_ReleaseRenderTargets_Internal_Void_0;
	}
}
