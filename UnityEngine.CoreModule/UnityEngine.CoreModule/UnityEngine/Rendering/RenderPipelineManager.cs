using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x02000241 RID: 577
	public static class RenderPipelineManager : Object
	{
		// Token: 0x06002684 RID: 9860 RVA: 0x000A3794 File Offset: 0x000A1994
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipelineManager()
		{
			Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipelineManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr);
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineAsset");
			RenderPipelineManager.NativeFieldInfoPtr_s_Cameras = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_Cameras");
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipelineType");
			RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "s_CurrentPipeline");
			RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginFrameRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endFrameRendering");
			RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginContextRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endContextRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endContextRendering");
			RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "beginCameraRendering");
			RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "endCameraRendering");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineTypeChanged");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineAssetChanged");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineCreated");
			RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, "activeRenderPipelineDisposed");
			RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668246);
			RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668247);
			RenderPipelineManager.NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668248);
			RenderPipelineManager.NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668249);
			RenderPipelineManager.NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668250);
			RenderPipelineManager.NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668251);
			RenderPipelineManager.NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668252);
			RenderPipelineManager.NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668253);
			RenderPipelineManager.NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668254);
			RenderPipelineManager.NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668255);
			RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668256);
			RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668257);
			RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668258);
			RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668259);
			RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668260);
			RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668261);
			RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668262);
			RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipelineManager>.NativeClassPtr, 100668263);
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06002685 RID: 9861 RVA: 0x000A3A44 File Offset: 0x000A1C44
		// (set) Token: 0x06002686 RID: 9862 RVA: 0x000A3A78 File Offset: 0x000A1C78
		public unsafe static RenderPipeline currentPipeline
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684006, XrefRangeEnd = 684010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 684024, RefRangeEnd = 684025, XrefRangeStart = 684010, XrefRangeEnd = 684024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x000A3AB0 File Offset: 0x000A1CB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684038, RefRangeEnd = 684039, XrefRangeStart = 684025, XrefRangeEnd = 684038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_beginCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x000A3AE8 File Offset: 0x000A1CE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684052, RefRangeEnd = 684053, XrefRangeStart = 684039, XrefRangeEnd = 684052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_beginCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002689 RID: 9865 RVA: 0x000A3B20 File Offset: 0x000A1D20
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684066, RefRangeEnd = 684067, XrefRangeStart = 684053, XrefRangeEnd = 684066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void add_endCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x000A3B58 File Offset: 0x000A1D58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 684080, RefRangeEnd = 684081, XrefRangeStart = 684067, XrefRangeEnd = 684080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void remove_endCameraRendering(Action<ScriptableRenderContext, Camera> value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000A3B90 File Offset: 0x000A1D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684081, XrefRangeEnd = 684091, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x000A3BD4 File Offset: 0x000A1DD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684091, XrefRangeEnd = 684095, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BeginCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000A3C18 File Offset: 0x000A1E18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684095, XrefRangeEnd = 684105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndContextRendering(ScriptableRenderContext context, List<Camera> cameras)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x000A3C5C File Offset: 0x000A1E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684105, XrefRangeEnd = 684109, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EndCameraRendering(ScriptableRenderContext context, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x000A3CA0 File Offset: 0x000A1EA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684109, XrefRangeEnd = 684113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveRenderPipelineTypeChanged()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x000A3CC8 File Offset: 0x000A1EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684113, XrefRangeEnd = 684122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnActiveRenderPipelineAssetChanged(ScriptableObject from, ScriptableObject to)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(from);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(to);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002691 RID: 9873 RVA: 0x000A3D10 File Offset: 0x000A1F10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684122, XrefRangeEnd = 684131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleRenderPipelineChange(RenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002692 RID: 9874 RVA: 0x000A3D48 File Offset: 0x000A1F48
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 684181, RefRangeEnd = 684185, XrefRangeStart = 684131, XrefRangeEnd = 684181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CleanupRenderPipeline()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002693 RID: 9875 RVA: 0x000A3D70 File Offset: 0x000A1F70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684185, XrefRangeEnd = 684189, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentPipelineAssetType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002694 RID: 9876 RVA: 0x000A3D9C File Offset: 0x000A1F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684189, XrefRangeEnd = 684249, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DoRenderLoop_Internal(RenderPipelineAsset pipe, IntPtr loopPtr, Object renderRequest)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipe);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loopPtr;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(renderRequest);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x000A3DF4 File Offset: 0x000A1FF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 684288, RefRangeEnd = 684290, XrefRangeStart = 684249, XrefRangeEnd = 684288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PrepareRenderPipeline(RenderPipelineAsset pipelineAsset)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pipelineAsset);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002696 RID: 9878 RVA: 0x000A3E2C File Offset: 0x000A202C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 684290, XrefRangeEnd = 684298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsPipelineRequireCreation()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipelineManager.NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002697 RID: 9879 RVA: 0x0000F0F4 File Offset: 0x0000D2F4
		public RenderPipelineManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06002698 RID: 9880 RVA: 0x000A3E5C File Offset: 0x000A205C
		// (set) Token: 0x06002699 RID: 9881 RVA: 0x0000F0FD File Offset: 0x0000D2FD
		public unsafe static RenderPipelineAsset s_CurrentPipelineAsset
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipelineAsset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineAsset, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x0600269A RID: 9882 RVA: 0x000A3E84 File Offset: 0x000A2084
		// (set) Token: 0x0600269B RID: 9883 RVA: 0x0000F10F File Offset: 0x0000D30F
		public unsafe static List<Camera> s_Cameras
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_Cameras, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x0600269C RID: 9884 RVA: 0x000A3EAC File Offset: 0x000A20AC
		// (set) Token: 0x0600269D RID: 9885 RVA: 0x0000F121 File Offset: 0x0000D321
		public unsafe static string s_CurrentPipelineType
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipelineType, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600269E RID: 9886 RVA: 0x000A3ECC File Offset: 0x000A20CC
		// (set) Token: 0x0600269F RID: 9887 RVA: 0x0000F133 File Offset: 0x0000D333
		public unsafe static RenderPipeline s_CurrentPipeline
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderPipeline>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_s_CurrentPipeline, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x060026A0 RID: 9888 RVA: 0x000A3EF4 File Offset: 0x000A20F4
		// (set) Token: 0x060026A1 RID: 9889 RVA: 0x0000F145 File Offset: 0x0000D345
		public unsafe static Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> beginFrameRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginFrameRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x060026A2 RID: 9890 RVA: 0x000A3F1C File Offset: 0x000A211C
		// (set) Token: 0x060026A3 RID: 9891 RVA: 0x0000F157 File Offset: 0x0000D357
		public unsafe static Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> endFrameRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endFrameRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x060026A4 RID: 9892 RVA: 0x000A3F44 File Offset: 0x000A2144
		// (set) Token: 0x060026A5 RID: 9893 RVA: 0x0000F169 File Offset: 0x0000D369
		public unsafe static Action<ScriptableRenderContext, List<Camera>> beginContextRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x060026A6 RID: 9894 RVA: 0x000A3F6C File Offset: 0x000A216C
		// (set) Token: 0x060026A7 RID: 9895 RVA: 0x0000F17B File Offset: 0x0000D37B
		public unsafe static Action<ScriptableRenderContext, List<Camera>> endContextRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endContextRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, List<Camera>>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endContextRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x060026A8 RID: 9896 RVA: 0x000A3F94 File Offset: 0x000A2194
		// (set) Token: 0x060026A9 RID: 9897 RVA: 0x0000F18D File Offset: 0x0000D38D
		public unsafe static Action<ScriptableRenderContext, Camera> beginCameraRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_beginCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x060026AA RID: 9898 RVA: 0x000A3FBC File Offset: 0x000A21BC
		// (set) Token: 0x060026AB RID: 9899 RVA: 0x0000F19F File Offset: 0x0000D39F
		public unsafe static Action<ScriptableRenderContext, Camera> endCameraRendering
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<ScriptableRenderContext, Camera>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_endCameraRendering, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x060026AC RID: 9900 RVA: 0x000A3FE4 File Offset: 0x000A21E4
		// (set) Token: 0x060026AD RID: 9901 RVA: 0x0000F1B1 File Offset: 0x0000D3B1
		public unsafe static Action activeRenderPipelineTypeChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineTypeChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x060026AE RID: 9902 RVA: 0x000A400C File Offset: 0x000A220C
		// (set) Token: 0x060026AF RID: 9903 RVA: 0x0000F1C3 File Offset: 0x0000D3C3
		public unsafe static Action<RenderPipelineAsset, RenderPipelineAsset> activeRenderPipelineAssetChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<RenderPipelineAsset, RenderPipelineAsset>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineAssetChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x060026B0 RID: 9904 RVA: 0x000A4034 File Offset: 0x000A2234
		// (set) Token: 0x060026B1 RID: 9905 RVA: 0x0000F1D5 File Offset: 0x0000D3D5
		public unsafe static Action activeRenderPipelineCreated
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineCreated, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x060026B2 RID: 9906 RVA: 0x000A405C File Offset: 0x000A225C
		// (set) Token: 0x060026B3 RID: 9907 RVA: 0x0000F1E7 File Offset: 0x0000D3E7
		public unsafe static Action activeRenderPipelineDisposed
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderPipelineManager.NativeFieldInfoPtr_activeRenderPipelineDisposed, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x0000F1F9 File Offset: 0x0000D3F9
		public static void add_beginFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0000F206 File Offset: 0x0000D406
		public static void remove_beginFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x0000F213 File Offset: 0x0000D413
		public static void add_endFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x0000F220 File Offset: 0x0000D420
		public static void remove_endFrameRendering(Action<ScriptableRenderContext, Il2CppReferenceArray<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x0000F22D File Offset: 0x0000D42D
		public static void add_beginContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0000F23A File Offset: 0x0000D43A
		public static void remove_beginContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x0000F247 File Offset: 0x0000D447
		public static void add_endContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x0000F254 File Offset: 0x0000D454
		public static void remove_endContextRendering(Action<ScriptableRenderContext, List<Camera>> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0000F261 File Offset: 0x0000D461
		public static void add_activeRenderPipelineTypeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0000F26E File Offset: 0x0000D46E
		public static void remove_activeRenderPipelineTypeChanged(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x0000F27B File Offset: 0x0000D47B
		public static void add_activeRenderPipelineAssetChanged(Action<RenderPipelineAsset, RenderPipelineAsset> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x0000F288 File Offset: 0x0000D488
		public static void remove_activeRenderPipelineAssetChanged(Action<RenderPipelineAsset, RenderPipelineAsset> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0000F295 File Offset: 0x0000D495
		public static void add_activeRenderPipelineCreated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0000F2A2 File Offset: 0x0000D4A2
		public static void remove_activeRenderPipelineCreated(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0000F2AF File Offset: 0x0000D4AF
		public static void add_activeRenderPipelineDisposed(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0000F2BC File Offset: 0x0000D4BC
		public static void remove_activeRenderPipelineDisposed(Action value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x060026C4 RID: 9924 RVA: 0x0000F2C9 File Offset: 0x0000D4C9
		public static bool pipelineSwitchCompleted
		{
			get
			{
				return RenderPipelineManager.s_CurrentPipelineAsset == GraphicsSettings.currentRenderPipeline && !RenderPipelineManager.IsPipelineRequireCreation();
			}
		}

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineAsset;

		// Token: 0x0400227B RID: 8827
		private static readonly IntPtr NativeFieldInfoPtr_s_Cameras;

		// Token: 0x0400227C RID: 8828
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipelineType;

		// Token: 0x0400227D RID: 8829
		private static readonly IntPtr NativeFieldInfoPtr_s_CurrentPipeline;

		// Token: 0x0400227E RID: 8830
		private static readonly IntPtr NativeFieldInfoPtr_beginFrameRendering;

		// Token: 0x0400227F RID: 8831
		private static readonly IntPtr NativeFieldInfoPtr_endFrameRendering;

		// Token: 0x04002280 RID: 8832
		private static readonly IntPtr NativeFieldInfoPtr_beginContextRendering;

		// Token: 0x04002281 RID: 8833
		private static readonly IntPtr NativeFieldInfoPtr_endContextRendering;

		// Token: 0x04002282 RID: 8834
		private static readonly IntPtr NativeFieldInfoPtr_beginCameraRendering;

		// Token: 0x04002283 RID: 8835
		private static readonly IntPtr NativeFieldInfoPtr_endCameraRendering;

		// Token: 0x04002284 RID: 8836
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineTypeChanged;

		// Token: 0x04002285 RID: 8837
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineAssetChanged;

		// Token: 0x04002286 RID: 8838
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineCreated;

		// Token: 0x04002287 RID: 8839
		private static readonly IntPtr NativeFieldInfoPtr_activeRenderPipelineDisposed;

		// Token: 0x04002288 RID: 8840
		private static readonly IntPtr NativeMethodInfoPtr_get_currentPipeline_Public_Static_get_RenderPipeline_0;

		// Token: 0x04002289 RID: 8841
		private static readonly IntPtr NativeMethodInfoPtr_set_currentPipeline_Private_Static_set_Void_RenderPipeline_0;

		// Token: 0x0400228A RID: 8842
		private static readonly IntPtr NativeMethodInfoPtr_add_beginCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x0400228B RID: 8843
		private static readonly IntPtr NativeMethodInfoPtr_remove_beginCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x0400228C RID: 8844
		private static readonly IntPtr NativeMethodInfoPtr_add_endCameraRendering_Public_Static_add_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x0400228D RID: 8845
		private static readonly IntPtr NativeMethodInfoPtr_remove_endCameraRendering_Public_Static_rem_Void_Action_2_ScriptableRenderContext_Camera_0;

		// Token: 0x0400228E RID: 8846
		private static readonly IntPtr NativeMethodInfoPtr_BeginContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x0400228F RID: 8847
		private static readonly IntPtr NativeMethodInfoPtr_BeginCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002290 RID: 8848
		private static readonly IntPtr NativeMethodInfoPtr_EndContextRendering_Internal_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002291 RID: 8849
		private static readonly IntPtr NativeMethodInfoPtr_EndCameraRendering_Internal_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002292 RID: 8850
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineTypeChanged_Internal_Static_Void_0;

		// Token: 0x04002293 RID: 8851
		private static readonly IntPtr NativeMethodInfoPtr_OnActiveRenderPipelineAssetChanged_Internal_Static_Void_ScriptableObject_ScriptableObject_0;

		// Token: 0x04002294 RID: 8852
		private static readonly IntPtr NativeMethodInfoPtr_HandleRenderPipelineChange_Internal_Static_Void_RenderPipelineAsset_0;

		// Token: 0x04002295 RID: 8853
		private static readonly IntPtr NativeMethodInfoPtr_CleanupRenderPipeline_Internal_Static_Void_0;

		// Token: 0x04002296 RID: 8854
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPipelineAssetType_Private_Static_String_0;

		// Token: 0x04002297 RID: 8855
		private static readonly IntPtr NativeMethodInfoPtr_DoRenderLoop_Internal_Private_Static_Void_RenderPipelineAsset_IntPtr_Object_0;

		// Token: 0x04002298 RID: 8856
		private static readonly IntPtr NativeMethodInfoPtr_PrepareRenderPipeline_Internal_Static_Void_RenderPipelineAsset_0;

		// Token: 0x04002299 RID: 8857
		private static readonly IntPtr NativeMethodInfoPtr_IsPipelineRequireCreation_Private_Static_Boolean_0;

		// Token: 0x0400229A RID: 8858
		public const string k_BuiltinPipelineName = "Built-in Pipeline";
	}
}
