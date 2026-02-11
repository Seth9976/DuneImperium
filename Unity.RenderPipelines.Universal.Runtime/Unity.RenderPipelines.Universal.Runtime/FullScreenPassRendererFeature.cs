using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

// Token: 0x02000004 RID: 4
public class FullScreenPassRendererFeature : ScriptableRendererFeature
{
	// Token: 0x06000007 RID: 7 RVA: 0x00015408 File Offset: 0x00013608
	// Note: this type is marked as 'beforefieldinit'.
	static FullScreenPassRendererFeature()
	{
		Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "", "FullScreenPassRendererFeature");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr);
		FullScreenPassRendererFeature.NativeFieldInfoPtr_injectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "injectionPoint");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_fetchColorBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "fetchColorBuffer");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_requirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "requirements");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_passMaterial = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "passMaterial");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_showAdditionalProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "showAdditionalProperties");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_passIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "passIndex");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_bindDepthStencilAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "bindDepthStencilAttachment");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_m_FullScreenPass = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "m_FullScreenPass");
		FullScreenPassRendererFeature.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "m_Version");
		FullScreenPassRendererFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663299);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663300);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663301);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663302);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_UpgradeIfNeeded_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663303);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663304);
		FullScreenPassRendererFeature.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663305);
		FullScreenPassRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, 100663306);
	}

	// Token: 0x06000008 RID: 8 RVA: 0x0001558C File Offset: 0x0001378C
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596446, XrefRangeEnd = 596460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Create()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.NativeMethodInfoPtr_Create_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000009 RID: 9 RVA: 0x000155C8 File Offset: 0x000137C8
	[CallerCount(0)]
	public unsafe override bool RequireRenderingLayers(bool isDeferred, bool needsGBufferAccurateNormals, out RenderingLayerUtils.Event atEvent, out RenderingLayerUtils.MaskSize maskSize)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref isDeferred;
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref needsGBufferAccurateNormals;
		ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &atEvent;
		ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &maskSize;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		return *IL2CPP.il2cpp_object_unbox(intPtr);
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00015648 File Offset: 0x00013848
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596460, XrefRangeEnd = 596485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr;
		checked
		{
			ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderer);
		}
		ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000B RID: 11 RVA: 0x000156A8 File Offset: 0x000138A8
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596485, XrefRangeEnd = 596486, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void Dispose(bool disposing)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = ref disposing;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}
	}

	// Token: 0x0600000C RID: 12 RVA: 0x000156F4 File Offset: 0x000138F4
	[CallerCount(21425)]
	[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe void UpgradeIfNeeded()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.NativeMethodInfoPtr_UpgradeIfNeeded_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00015728 File Offset: 0x00013928
	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000E RID: 14 RVA: 0x0001575C File Offset: 0x0001395C
	[CallerCount(0)]
	public unsafe virtual void UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00015790 File Offset: 0x00013990
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596486, XrefRangeEnd = 596487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe FullScreenPassRendererFeature()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000020D4 File Offset: 0x000002D4
	public FullScreenPassRendererFeature(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000001 RID: 1
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000157CC File Offset: 0x000139CC
	// (set) Token: 0x06000012 RID: 18 RVA: 0x000020DD File Offset: 0x000002DD
	public unsafe FullScreenPassRendererFeature.InjectionPoint injectionPoint
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_injectionPoint);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_injectionPoint)) = value;
		}
	}

	// Token: 0x17000002 RID: 2
	// (get) Token: 0x06000013 RID: 19 RVA: 0x000157F4 File Offset: 0x000139F4
	// (set) Token: 0x06000014 RID: 20 RVA: 0x000020F8 File Offset: 0x000002F8
	public unsafe bool fetchColorBuffer
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_fetchColorBuffer);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_fetchColorBuffer)) = value;
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000015 RID: 21 RVA: 0x0001581C File Offset: 0x00013A1C
	// (set) Token: 0x06000016 RID: 22 RVA: 0x00002113 File Offset: 0x00000313
	public unsafe ScriptableRenderPassInput requirements
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_requirements);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_requirements)) = value;
		}
	}

	// Token: 0x17000004 RID: 4
	// (get) Token: 0x06000017 RID: 23 RVA: 0x00015844 File Offset: 0x00013A44
	// (set) Token: 0x06000018 RID: 24 RVA: 0x0000212E File Offset: 0x0000032E
	public unsafe Material passMaterial
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_passMaterial);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_passMaterial), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x06000019 RID: 25 RVA: 0x00015874 File Offset: 0x00013A74
	// (set) Token: 0x0600001A RID: 26 RVA: 0x0000214D File Offset: 0x0000034D
	public unsafe bool showAdditionalProperties
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_showAdditionalProperties);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_showAdditionalProperties)) = value;
		}
	}

	// Token: 0x17000006 RID: 6
	// (get) Token: 0x0600001B RID: 27 RVA: 0x0001589C File Offset: 0x00013A9C
	// (set) Token: 0x0600001C RID: 28 RVA: 0x00002168 File Offset: 0x00000368
	public unsafe int passIndex
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_passIndex);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_passIndex)) = value;
		}
	}

	// Token: 0x17000007 RID: 7
	// (get) Token: 0x0600001D RID: 29 RVA: 0x000158C4 File Offset: 0x00013AC4
	// (set) Token: 0x0600001E RID: 30 RVA: 0x00002183 File Offset: 0x00000383
	public unsafe bool bindDepthStencilAttachment
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_bindDepthStencilAttachment);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_bindDepthStencilAttachment)) = value;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x0600001F RID: 31 RVA: 0x000158EC File Offset: 0x00013AEC
	// (set) Token: 0x06000020 RID: 32 RVA: 0x0000219E File Offset: 0x0000039E
	public unsafe FullScreenPassRendererFeature.FullScreenRenderPass m_FullScreenPass
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_m_FullScreenPass);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<FullScreenPassRendererFeature.FullScreenRenderPass>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_m_FullScreenPass), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000009 RID: 9
	// (get) Token: 0x06000021 RID: 33 RVA: 0x0001591C File Offset: 0x00013B1C
	// (set) Token: 0x06000022 RID: 34 RVA: 0x000021BD File Offset: 0x000003BD
	public unsafe FullScreenPassRendererFeature.Version m_Version
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_m_Version);
			return *intPtr;
		}
		set
		{
			*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.NativeFieldInfoPtr_m_Version)) = value;
		}
	}

	// Token: 0x04000003 RID: 3
	private static readonly IntPtr NativeFieldInfoPtr_injectionPoint;

	// Token: 0x04000004 RID: 4
	private static readonly IntPtr NativeFieldInfoPtr_fetchColorBuffer;

	// Token: 0x04000005 RID: 5
	private static readonly IntPtr NativeFieldInfoPtr_requirements;

	// Token: 0x04000006 RID: 6
	private static readonly IntPtr NativeFieldInfoPtr_passMaterial;

	// Token: 0x04000007 RID: 7
	private static readonly IntPtr NativeFieldInfoPtr_showAdditionalProperties;

	// Token: 0x04000008 RID: 8
	private static readonly IntPtr NativeFieldInfoPtr_passIndex;

	// Token: 0x04000009 RID: 9
	private static readonly IntPtr NativeFieldInfoPtr_bindDepthStencilAttachment;

	// Token: 0x0400000A RID: 10
	private static readonly IntPtr NativeFieldInfoPtr_m_FullScreenPass;

	// Token: 0x0400000B RID: 11
	private static readonly IntPtr NativeFieldInfoPtr_m_Version;

	// Token: 0x0400000C RID: 12
	private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Virtual_Void_0;

	// Token: 0x0400000D RID: 13
	private static readonly IntPtr NativeMethodInfoPtr_RequireRenderingLayers_Internal_Virtual_Boolean_Boolean_Boolean_byref_Event_byref_MaskSize_0;

	// Token: 0x0400000E RID: 14
	private static readonly IntPtr NativeMethodInfoPtr_AddRenderPasses_Public_Virtual_Void_ScriptableRenderer_byref_RenderingData_0;

	// Token: 0x0400000F RID: 15
	private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

	// Token: 0x04000010 RID: 16
	private static readonly IntPtr NativeMethodInfoPtr_UpgradeIfNeeded_Private_Void_0;

	// Token: 0x04000011 RID: 17
	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnBeforeSerialize_Private_Virtual_Final_New_Void_0;

	// Token: 0x04000012 RID: 18
	private static readonly IntPtr NativeMethodInfoPtr_UnityEngine_ISerializationCallbackReceiver_OnAfterDeserialize_Private_Virtual_Final_New_Void_0;

	// Token: 0x04000013 RID: 19
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x02000142 RID: 322
	public enum InjectionPoint
	{
		// Token: 0x04001382 RID: 4994
		BeforeRenderingTransparents = 450,
		// Token: 0x04001383 RID: 4995
		BeforeRenderingPostProcessing = 550,
		// Token: 0x04001384 RID: 4996
		AfterRenderingPostProcessing = 600
	}

	// Token: 0x02000143 RID: 323
	public class FullScreenRenderPass : ScriptableRenderPass
	{
		// Token: 0x06001B04 RID: 6916 RVA: 0x00071320 File Offset: 0x0006F520
		// Note: this type is marked as 'beforefieldinit'.
		static FullScreenRenderPass()
		{
			Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullScreenPassRendererFeature>.NativeClassPtr, "FullScreenRenderPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_Material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "m_Material");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_PassIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "m_PassIndex");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopyActiveColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "m_CopyActiveColor");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_BindDepthStencilAttachment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "m_BindDepthStencilAttachment");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopiedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "m_CopiedColor");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_s_SharedPropertyBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, "s_SharedPropertyBlock");
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663307);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_SetupMembers_Public_Void_Material_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663308);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663309);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ReAllocate_Internal_Void_RenderTextureDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663310);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_Dispose_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663311);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ExecuteCopyColorPass_Private_Static_Void_CommandBuffer_RTHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663312);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ExecuteMainPass_Private_Static_Void_CommandBuffer_RTHandle_Material_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663313);
			FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr, 100663314);
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00071464 File Offset: 0x0006F664
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596336, XrefRangeEnd = 596345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullScreenRenderPass(string passName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullScreenPassRendererFeature.FullScreenRenderPass>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(passName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B06 RID: 6918 RVA: 0x000714B0 File Offset: 0x0006F6B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596345, XrefRangeEnd = 596346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupMembers(Material material, int passIndex, bool copyActiveColor, bool bindDepthStencilAttachment)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(material);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref copyActiveColor;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindDepthStencilAttachment;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_SetupMembers_Public_Void_Material_Int32_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B07 RID: 6919 RVA: 0x0007151C File Offset: 0x0006F71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596346, XrefRangeEnd = 596354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnCameraSetup(CommandBuffer cmd, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B08 RID: 6920 RVA: 0x0007157C File Offset: 0x0006F77C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 596361, RefRangeEnd = 596362, XrefRangeStart = 596354, XrefRangeEnd = 596361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReAllocate(RenderTextureDescriptor desc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref desc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ReAllocate_Internal_Void_RenderTextureDescriptor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001B09 RID: 6921 RVA: 0x000715BC File Offset: 0x0006F7BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596362, XrefRangeEnd = 596363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_Dispose_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0A RID: 6922 RVA: 0x000715F0 File Offset: 0x0006F7F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596363, XrefRangeEnd = 596367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteCopyColorPass(CommandBuffer cmd, RTHandle sourceTexture)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTexture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ExecuteCopyColorPass_Private_Static_Void_CommandBuffer_RTHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x00071638 File Offset: 0x0006F838
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596367, XrefRangeEnd = 596392, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecuteMainPass(CommandBuffer cmd, RTHandle sourceTexture, Material material, int passIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(sourceTexture);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(material);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref passIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_ExecuteMainPass_Private_Static_Void_CommandBuffer_RTHandle_Material_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000716A0 File Offset: 0x0006F8A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 596392, XrefRangeEnd = 596446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtrNotNull(renderingData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FullScreenPassRendererFeature.FullScreenRenderPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x0000F43C File Offset: 0x0000D63C
		public FullScreenRenderPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06001B0E RID: 6926 RVA: 0x000716FC File Offset: 0x0006F8FC
		// (set) Token: 0x06001B0F RID: 6927 RVA: 0x0000F445 File Offset: 0x0000D645
		public unsafe Material m_Material
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_Material);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_Material), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06001B10 RID: 6928 RVA: 0x0007172C File Offset: 0x0006F92C
		// (set) Token: 0x06001B11 RID: 6929 RVA: 0x0000F464 File Offset: 0x0000D664
		public unsafe int m_PassIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_PassIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_PassIndex)) = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06001B12 RID: 6930 RVA: 0x00071754 File Offset: 0x0006F954
		// (set) Token: 0x06001B13 RID: 6931 RVA: 0x0000F47F File Offset: 0x0000D67F
		public unsafe bool m_CopyActiveColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopyActiveColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopyActiveColor)) = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06001B14 RID: 6932 RVA: 0x0007177C File Offset: 0x0006F97C
		// (set) Token: 0x06001B15 RID: 6933 RVA: 0x0000F49A File Offset: 0x0000D69A
		public unsafe bool m_BindDepthStencilAttachment
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_BindDepthStencilAttachment);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_BindDepthStencilAttachment)) = value;
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06001B16 RID: 6934 RVA: 0x000717A4 File Offset: 0x0006F9A4
		// (set) Token: 0x06001B17 RID: 6935 RVA: 0x0000F4B5 File Offset: 0x0000D6B5
		public unsafe RTHandle m_CopiedColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopiedColor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_m_CopiedColor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06001B18 RID: 6936 RVA: 0x000717D4 File Offset: 0x0006F9D4
		// (set) Token: 0x06001B19 RID: 6937 RVA: 0x0000F4D4 File Offset: 0x0000D6D4
		public unsafe static MaterialPropertyBlock s_SharedPropertyBlock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_s_SharedPropertyBlock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MaterialPropertyBlock>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FullScreenPassRendererFeature.FullScreenRenderPass.NativeFieldInfoPtr_s_SharedPropertyBlock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001385 RID: 4997
		private static readonly IntPtr NativeFieldInfoPtr_m_Material;

		// Token: 0x04001386 RID: 4998
		private static readonly IntPtr NativeFieldInfoPtr_m_PassIndex;

		// Token: 0x04001387 RID: 4999
		private static readonly IntPtr NativeFieldInfoPtr_m_CopyActiveColor;

		// Token: 0x04001388 RID: 5000
		private static readonly IntPtr NativeFieldInfoPtr_m_BindDepthStencilAttachment;

		// Token: 0x04001389 RID: 5001
		private static readonly IntPtr NativeFieldInfoPtr_m_CopiedColor;

		// Token: 0x0400138A RID: 5002
		private static readonly IntPtr NativeFieldInfoPtr_s_SharedPropertyBlock;

		// Token: 0x0400138B RID: 5003
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400138C RID: 5004
		private static readonly IntPtr NativeMethodInfoPtr_SetupMembers_Public_Void_Material_Int32_Boolean_Boolean_0;

		// Token: 0x0400138D RID: 5005
		private static readonly IntPtr NativeMethodInfoPtr_OnCameraSetup_Public_Virtual_Void_CommandBuffer_byref_RenderingData_0;

		// Token: 0x0400138E RID: 5006
		private static readonly IntPtr NativeMethodInfoPtr_ReAllocate_Internal_Void_RenderTextureDescriptor_0;

		// Token: 0x0400138F RID: 5007
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Void_0;

		// Token: 0x04001390 RID: 5008
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteCopyColorPass_Private_Static_Void_CommandBuffer_RTHandle_0;

		// Token: 0x04001391 RID: 5009
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteMainPass_Private_Static_Void_CommandBuffer_RTHandle_Material_Int32_0;

		// Token: 0x04001392 RID: 5010
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;
	}

	// Token: 0x02000144 RID: 324
	public enum Version
	{
		// Token: 0x04001394 RID: 5012
		Uninitialised = -1,
		// Token: 0x04001395 RID: 5013
		Initial,
		// Token: 0x04001396 RID: 5014
		AddFetchColorBufferCheckbox,
		// Token: 0x04001397 RID: 5015
		Count,
		// Token: 0x04001398 RID: 5016
		Latest = 1
	}
}
