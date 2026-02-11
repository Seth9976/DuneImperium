using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.RendererUtils
{
	// Token: 0x0200025B RID: 603
	public sealed class RendererListDesc : ValueType
	{
		// Token: 0x0600293F RID: 10559 RVA: 0x000AB5B0 File Offset: 0x000A97B0
		// Note: this type is marked as 'beforefieldinit'.
		static RendererListDesc()
		{
			Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering.RendererUtils", "RendererListDesc");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr);
			RendererListDesc.NativeFieldInfoPtr_sortingCriteria = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "sortingCriteria");
			RendererListDesc.NativeFieldInfoPtr_rendererConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "rendererConfiguration");
			RendererListDesc.NativeFieldInfoPtr_renderQueueRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderQueueRange");
			RendererListDesc.NativeFieldInfoPtr_stateBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "stateBlock");
			RendererListDesc.NativeFieldInfoPtr_overrideShader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShader");
			RendererListDesc.NativeFieldInfoPtr_overrideMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterial");
			RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "excludeObjectMotionVectors");
			RendererListDesc.NativeFieldInfoPtr_layerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "layerMask");
			RendererListDesc.NativeFieldInfoPtr_renderingLayerMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "renderingLayerMask");
			RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideMaterialPassIndex");
			RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "overrideShaderPassIndex");
			RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<cullingResult>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<camera>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passName>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "<passNames>k__BackingField");
			RendererListDesc.NativeFieldInfoPtr_s_EmptyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, "s_EmptyName");
			RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668518);
			RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668519);
			RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668520);
			RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668521);
			RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668522);
			RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr, 100668523);
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06002940 RID: 10560 RVA: 0x000AB798 File Offset: 0x000A9998
		// (set) Token: 0x06002968 RID: 10600 RVA: 0x00010135 File Offset: 0x0000E335
		public unsafe CullingResults cullingResult
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._cullingResult_k__BackingField = value;
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06002941 RID: 10561 RVA: 0x000AB7DC File Offset: 0x000A99DC
		// (set) Token: 0x06002969 RID: 10601 RVA: 0x0001013E File Offset: 0x0000E33E
		public unsafe Camera camera
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_camera_Internal_get_Camera_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr3) : null;
			}
			set
			{
				this._camera_k__BackingField = value;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06002942 RID: 10562 RVA: 0x000AB820 File Offset: 0x000A9A20
		// (set) Token: 0x0600296A RID: 10602 RVA: 0x00010147 File Offset: 0x0000E347
		public unsafe ShaderTagId passName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this._passName_k__BackingField = value;
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06002943 RID: 10563 RVA: 0x000AB864 File Offset: 0x000A9A64
		// (set) Token: 0x0600296B RID: 10603 RVA: 0x00010150 File Offset: 0x0000E350
		public unsafe Il2CppStructArray<ShaderTagId> passNames
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr3) : null;
			}
			set
			{
				this._passNames_k__BackingField = value;
			}
		}

		// Token: 0x06002944 RID: 10564 RVA: 0x000AB8A8 File Offset: 0x000A9AA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685633, RefRangeEnd = 685634, XrefRangeStart = 685621, XrefRangeEnd = 685633, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_IsValid_Public_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002945 RID: 10565 RVA: 0x000AB8EC File Offset: 0x000A9AEC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 685721, RefRangeEnd = 685722, XrefRangeStart = 685634, XrefRangeEnd = 685721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static RendererListParams ConvertToParameters([In] ref RendererListDesc desc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(desc);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RendererListDesc.NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new RendererListParams(intPtr);
			}
		}

		// Token: 0x06002946 RID: 10566 RVA: 0x0000FF54 File Offset: 0x0000E154
		public RendererListDesc(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002947 RID: 10567 RVA: 0x0000FF5D File Offset: 0x0000E15D
		public RendererListDesc()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RendererListDesc>.NativeClassPtr))
		{
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06002948 RID: 10568 RVA: 0x000AB92C File Offset: 0x000A9B2C
		// (set) Token: 0x06002949 RID: 10569 RVA: 0x0000FF6F File Offset: 0x0000E16F
		public unsafe SortingCriteria sortingCriteria
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_sortingCriteria)) = value;
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x0600294A RID: 10570 RVA: 0x000AB954 File Offset: 0x000A9B54
		// (set) Token: 0x0600294B RID: 10571 RVA: 0x0000FF8A File Offset: 0x0000E18A
		public unsafe PerObjectData rendererConfiguration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_rendererConfiguration)) = value;
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x0600294C RID: 10572 RVA: 0x000AB97C File Offset: 0x000A9B7C
		// (set) Token: 0x0600294D RID: 10573 RVA: 0x0000FFA5 File Offset: 0x0000E1A5
		public unsafe RenderQueueRange renderQueueRange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderQueueRange)) = value;
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x0600294E RID: 10574 RVA: 0x000AB9A4 File Offset: 0x000A9BA4
		// (set) Token: 0x0600294F RID: 10575 RVA: 0x0000FFC0 File Offset: 0x0000E1C0
		public Nullable<RenderStateBlock> stateBlock
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock);
				return new Nullable<RenderStateBlock>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<RenderStateBlock>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_stateBlock), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<RenderStateBlock>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06002950 RID: 10576 RVA: 0x000AB9D4 File Offset: 0x000A9BD4
		// (set) Token: 0x06002951 RID: 10577 RVA: 0x0000FFEE File Offset: 0x0000E1EE
		public unsafe Shader overrideShader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Shader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x06002952 RID: 10578 RVA: 0x000ABA04 File Offset: 0x000A9C04
		// (set) Token: 0x06002953 RID: 10579 RVA: 0x0001000D File Offset: 0x0000E20D
		public unsafe Material overrideMaterial
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06002954 RID: 10580 RVA: 0x000ABA34 File Offset: 0x000A9C34
		// (set) Token: 0x06002955 RID: 10581 RVA: 0x0001002C File Offset: 0x0000E22C
		public unsafe bool excludeObjectMotionVectors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_excludeObjectMotionVectors)) = value;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06002956 RID: 10582 RVA: 0x000ABA5C File Offset: 0x000A9C5C
		// (set) Token: 0x06002957 RID: 10583 RVA: 0x00010047 File Offset: 0x0000E247
		public unsafe int layerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_layerMask)) = value;
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06002958 RID: 10584 RVA: 0x000ABA84 File Offset: 0x000A9C84
		// (set) Token: 0x06002959 RID: 10585 RVA: 0x00010062 File Offset: 0x0000E262
		public unsafe uint renderingLayerMask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_renderingLayerMask)) = value;
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x0600295A RID: 10586 RVA: 0x000ABAAC File Offset: 0x000A9CAC
		// (set) Token: 0x0600295B RID: 10587 RVA: 0x0001007D File Offset: 0x0000E27D
		public unsafe int overrideMaterialPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideMaterialPassIndex)) = value;
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x0600295C RID: 10588 RVA: 0x000ABAD4 File Offset: 0x000A9CD4
		// (set) Token: 0x0600295D RID: 10589 RVA: 0x00010098 File Offset: 0x0000E298
		public unsafe int overrideShaderPassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr_overrideShaderPassIndex)) = value;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x0600295E RID: 10590 RVA: 0x000ABAFC File Offset: 0x000A9CFC
		// (set) Token: 0x0600295F RID: 10591 RVA: 0x000100B3 File Offset: 0x0000E2B3
		public unsafe CullingResults _cullingResult_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__cullingResult_k__BackingField)) = value;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002960 RID: 10592 RVA: 0x000ABB24 File Offset: 0x000A9D24
		// (set) Token: 0x06002961 RID: 10593 RVA: 0x000100CE File Offset: 0x0000E2CE
		public unsafe Camera _camera_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__camera_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002962 RID: 10594 RVA: 0x000ABB54 File Offset: 0x000A9D54
		// (set) Token: 0x06002963 RID: 10595 RVA: 0x000100ED File Offset: 0x0000E2ED
		public unsafe ShaderTagId _passName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passName_k__BackingField)) = value;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002964 RID: 10596 RVA: 0x000ABB7C File Offset: 0x000A9D7C
		// (set) Token: 0x06002965 RID: 10597 RVA: 0x00010108 File Offset: 0x0000E308
		public unsafe Il2CppStructArray<ShaderTagId> _passNames_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<ShaderTagId>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RendererListDesc.NativeFieldInfoPtr__passNames_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06002966 RID: 10598 RVA: 0x000ABBAC File Offset: 0x000A9DAC
		// (set) Token: 0x06002967 RID: 10599 RVA: 0x00010127 File Offset: 0x0000E327
		public unsafe static ShaderTagId s_EmptyName
		{
			get
			{
				ShaderTagId shaderTagId;
				IL2CPP.il2cpp_field_static_get_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*)(&shaderTagId));
				return shaderTagId;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RendererListDesc.NativeFieldInfoPtr_s_EmptyName, (void*)(&value));
			}
		}

		// Token: 0x0400249C RID: 9372
		private static readonly IntPtr NativeFieldInfoPtr_sortingCriteria;

		// Token: 0x0400249D RID: 9373
		private static readonly IntPtr NativeFieldInfoPtr_rendererConfiguration;

		// Token: 0x0400249E RID: 9374
		private static readonly IntPtr NativeFieldInfoPtr_renderQueueRange;

		// Token: 0x0400249F RID: 9375
		private static readonly IntPtr NativeFieldInfoPtr_stateBlock;

		// Token: 0x040024A0 RID: 9376
		private static readonly IntPtr NativeFieldInfoPtr_overrideShader;

		// Token: 0x040024A1 RID: 9377
		private static readonly IntPtr NativeFieldInfoPtr_overrideMaterial;

		// Token: 0x040024A2 RID: 9378
		private static readonly IntPtr NativeFieldInfoPtr_excludeObjectMotionVectors;

		// Token: 0x040024A3 RID: 9379
		private static readonly IntPtr NativeFieldInfoPtr_layerMask;

		// Token: 0x040024A4 RID: 9380
		private static readonly IntPtr NativeFieldInfoPtr_renderingLayerMask;

		// Token: 0x040024A5 RID: 9381
		private static readonly IntPtr NativeFieldInfoPtr_overrideMaterialPassIndex;

		// Token: 0x040024A6 RID: 9382
		private static readonly IntPtr NativeFieldInfoPtr_overrideShaderPassIndex;

		// Token: 0x040024A7 RID: 9383
		private static readonly IntPtr NativeFieldInfoPtr__cullingResult_k__BackingField;

		// Token: 0x040024A8 RID: 9384
		private static readonly IntPtr NativeFieldInfoPtr__camera_k__BackingField;

		// Token: 0x040024A9 RID: 9385
		private static readonly IntPtr NativeFieldInfoPtr__passName_k__BackingField;

		// Token: 0x040024AA RID: 9386
		private static readonly IntPtr NativeFieldInfoPtr__passNames_k__BackingField;

		// Token: 0x040024AB RID: 9387
		private static readonly IntPtr NativeFieldInfoPtr_s_EmptyName;

		// Token: 0x040024AC RID: 9388
		private static readonly IntPtr NativeMethodInfoPtr_get_cullingResult_Internal_get_CullingResults_0;

		// Token: 0x040024AD RID: 9389
		private static readonly IntPtr NativeMethodInfoPtr_get_camera_Internal_get_Camera_0;

		// Token: 0x040024AE RID: 9390
		private static readonly IntPtr NativeMethodInfoPtr_get_passName_Internal_get_ShaderTagId_0;

		// Token: 0x040024AF RID: 9391
		private static readonly IntPtr NativeMethodInfoPtr_get_passNames_Internal_get_Il2CppStructArray_1_ShaderTagId_0;

		// Token: 0x040024B0 RID: 9392
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Public_Boolean_0;

		// Token: 0x040024B1 RID: 9393
		private static readonly IntPtr NativeMethodInfoPtr_ConvertToParameters_Public_Static_RendererListParams_byref_RendererListDesc_0;
	}
}
