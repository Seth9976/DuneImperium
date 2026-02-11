using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Rendering
{
	// Token: 0x0200023E RID: 574
	public class RenderPipeline : Object
	{
		// Token: 0x0600264D RID: 9805 RVA: 0x000A263C File Offset: 0x000A083C
		// Note: this type is marked as 'beforefieldinit'.
		static RenderPipeline()
		{
			Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "RenderPipeline");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr);
			RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "<disposed>k__BackingField");
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668203);
			RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668204);
			RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668205);
			RenderPipeline.NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668206);
			RenderPipeline.NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668207);
			RenderPipeline.NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668208);
			RenderPipeline.NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668209);
			RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668210);
			RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668211);
			RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668212);
			RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668213);
			RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668214);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668215);
			RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668216);
			RenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668217);
			RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, 100668218);
		}

		// Token: 0x0600264E RID: 9806 RVA: 0x000A27C0 File Offset: 0x000A09C0
		[CallerCount(0)]
		public unsafe virtual void Render(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600264F RID: 9807 RVA: 0x000A281C File Offset: 0x000A0A1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = renderRequest;
				intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref renderRequest;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x000A28C0 File Offset: 0x000A0AC0
		[CallerCount(18)]
		[CachedScanResults(RefRangeStart = 291198, RefRangeEnd = 291216, XrefRangeStart = 291198, XrefRangeEnd = 291216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool IsRenderRequestSupported<RequestData>(Camera camera, RequestData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = data;
				intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref data;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x000A2960 File Offset: 0x000A0B60
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683901, RefRangeEnd = 683903, XrefRangeStart = 683888, XrefRangeEnd = 683901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x000A29A4 File Offset: 0x000A0BA4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 683910, RefRangeEnd = 683914, XrefRangeStart = 683903, XrefRangeEnd = 683910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x000A29E8 File Offset: 0x000A0BE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683927, RefRangeEnd = 683929, XrefRangeStart = 683914, XrefRangeEnd = 683927, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x000A2A2C File Offset: 0x000A0C2C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 683936, RefRangeEnd = 683940, XrefRangeStart = 683929, XrefRangeEnd = 683936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002655 RID: 9813 RVA: 0x000A2A70 File Offset: 0x000A0C70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683940, XrefRangeEnd = 683944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Render(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002656 RID: 9814 RVA: 0x000A2ACC File Offset: 0x000A0CCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683944, XrefRangeEnd = 683951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalRender(ScriptableRenderContext context, List<Camera> cameras)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cameras);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x000A2B1C File Offset: 0x000A0D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683959, RefRangeEnd = 683960, XrefRangeStart = 683951, XrefRangeEnd = 683959, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalProcessRenderRequests<RequestData>(ScriptableRenderContext context, Camera camera, RequestData renderRequest)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref context;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(RequestData).IsValueType)
			{
				RequestData requestData = renderRequest;
				intPtr = ((requestData is string) ? IL2CPP.ManagedStringToIl2Cpp(requestData as string) : IL2CPP.Il2CppObjectBaseToPtr(requestData as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref renderRequest;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x170007A3 RID: 1955
		// (get) Token: 0x06002658 RID: 9816 RVA: 0x000A2BB4 File Offset: 0x000A0DB4
		// (set) Token: 0x06002659 RID: 9817 RVA: 0x000A2BF0 File Offset: 0x000A0DF0
		public unsafe bool disposed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x000A2C30 File Offset: 0x000A0E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683960, XrefRangeEnd = 683964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr_Dispose_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x000A2C64 File Offset: 0x000A0E64
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007A4 RID: 1956
		// (get) Token: 0x0600265C RID: 9820 RVA: 0x000A2CB0 File Offset: 0x000A0EB0
		public unsafe virtual RenderPipelineGlobalSettings defaultSettings
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RenderPipeline.NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderPipelineGlobalSettings>(intPtr3) : null;
			}
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000A2CFC File Offset: 0x000A0EFC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderPipeline()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderPipeline.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x0000F05A File Offset: 0x0000D25A
		public RenderPipeline(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007A2 RID: 1954
		// (get) Token: 0x0600265F RID: 9823 RVA: 0x000A2D38 File Offset: 0x000A0F38
		// (set) Token: 0x06002660 RID: 9824 RVA: 0x0000F063 File Offset: 0x0000D263
		public unsafe bool _disposed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.NativeFieldInfoPtr__disposed_k__BackingField)) = value;
			}
		}

		// Token: 0x06002661 RID: 9825 RVA: 0x0000F07E File Offset: 0x0000D27E
		public static void BeginFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.BeginContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x06002662 RID: 9826 RVA: 0x0000F08E File Offset: 0x0000D28E
		public static void EndFrameRendering(ScriptableRenderContext context, Il2CppReferenceArray<Camera> cameras)
		{
			RenderPipelineManager.EndContextRendering(context, new List<Camera>(cameras));
		}

		// Token: 0x06002663 RID: 9827 RVA: 0x000A2D60 File Offset: 0x000A0F60
		public static bool SupportsRenderRequest<RequestData>(Camera camera, RequestData data)
		{
			bool flag = false;
			bool flag2 = GraphicsSettings.currentRenderPipeline != null;
			if (flag2)
			{
				bool flag3 = RenderPipelineManager.currentPipeline == null;
				if (flag3)
				{
					RenderPipelineManager.PrepareRenderPipeline(GraphicsSettings.currentRenderPipeline);
				}
				flag = RenderPipelineManager.currentPipeline.IsRenderRequestSupported<RequestData>(camera, data);
			}
			return flag;
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x0000F09E File Offset: 0x0000D29E
		public static void SubmitRenderRequest<RequestData>(Camera camera, RequestData data)
		{
			camera.SubmitRenderRequest<RequestData>(data);
		}

		// Token: 0x0400224E RID: 8782
		private static readonly IntPtr NativeFieldInfoPtr__disposed_k__BackingField;

		// Token: 0x0400224F RID: 8783
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Abstract_Virtual_New_Void_ScriptableRenderContext_Il2CppReferenceArray_1_Camera_0;

		// Token: 0x04002250 RID: 8784
		private static readonly IntPtr NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0;

		// Token: 0x04002251 RID: 8785
		private static readonly IntPtr NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0;

		// Token: 0x04002252 RID: 8786
		private static readonly IntPtr NativeMethodInfoPtr_BeginContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002253 RID: 8787
		private static readonly IntPtr NativeMethodInfoPtr_BeginCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002254 RID: 8788
		private static readonly IntPtr NativeMethodInfoPtr_EndContextRendering_Protected_Static_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002255 RID: 8789
		private static readonly IntPtr NativeMethodInfoPtr_EndCameraRendering_Protected_Static_Void_ScriptableRenderContext_Camera_0;

		// Token: 0x04002256 RID: 8790
		private static readonly IntPtr NativeMethodInfoPtr_Render_Protected_Virtual_New_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002257 RID: 8791
		private static readonly IntPtr NativeMethodInfoPtr_InternalRender_Internal_Void_ScriptableRenderContext_List_1_Camera_0;

		// Token: 0x04002258 RID: 8792
		private static readonly IntPtr NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0;

		// Token: 0x04002259 RID: 8793
		private static readonly IntPtr NativeMethodInfoPtr_get_disposed_Public_get_Boolean_0;

		// Token: 0x0400225A RID: 8794
		private static readonly IntPtr NativeMethodInfoPtr_set_disposed_Private_set_Void_Boolean_0;

		// Token: 0x0400225B RID: 8795
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Internal_Void_0;

		// Token: 0x0400225C RID: 8796
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x0400225D RID: 8797
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultSettings_Public_Virtual_New_get_RenderPipelineGlobalSettings_0;

		// Token: 0x0400225E RID: 8798
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020009DC RID: 2524
		public class StandardRequest : Object
		{
			// Token: 0x06003CD5 RID: 15573 RVA: 0x000BEC9C File Offset: 0x000BCE9C
			// Note: this type is marked as 'beforefieldinit'.
			static StandardRequest()
			{
				Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr, "StandardRequest");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr);
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "destination");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "mipLevel");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_face = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "face");
				RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderPipeline.StandardRequest>.NativeClassPtr, "slice");
			}

			// Token: 0x06003CD6 RID: 15574 RVA: 0x000166E2 File Offset: 0x000148E2
			public StandardRequest(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000A3C RID: 2620
			// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x000BED18 File Offset: 0x000BCF18
			// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x000166EB File Offset: 0x000148EB
			public unsafe RenderTexture destination
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_destination), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000A3D RID: 2621
			// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x000BED48 File Offset: 0x000BCF48
			// (set) Token: 0x06003CDA RID: 15578 RVA: 0x0001670A File Offset: 0x0001490A
			public unsafe int mipLevel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_mipLevel)) = value;
				}
			}

			// Token: 0x17000A3E RID: 2622
			// (get) Token: 0x06003CDB RID: 15579 RVA: 0x000BED70 File Offset: 0x000BCF70
			// (set) Token: 0x06003CDC RID: 15580 RVA: 0x00016725 File Offset: 0x00014925
			public unsafe CubemapFace face
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_face);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_face)) = value;
				}
			}

			// Token: 0x17000A3F RID: 2623
			// (get) Token: 0x06003CDD RID: 15581 RVA: 0x000BED98 File Offset: 0x000BCF98
			// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00016740 File Offset: 0x00014940
			public unsafe int slice
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderPipeline.StandardRequest.NativeFieldInfoPtr_slice)) = value;
				}
			}

			// Token: 0x04002D2F RID: 11567
			private static readonly IntPtr NativeFieldInfoPtr_destination;

			// Token: 0x04002D30 RID: 11568
			private static readonly IntPtr NativeFieldInfoPtr_mipLevel;

			// Token: 0x04002D31 RID: 11569
			private static readonly IntPtr NativeFieldInfoPtr_face;

			// Token: 0x04002D32 RID: 11570
			private static readonly IntPtr NativeFieldInfoPtr_slice;
		}

		// Token: 0x020009DD RID: 2525
		private sealed class MethodInfoStoreGeneric_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002D33 RID: 11571
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_ProcessRenderRequests_Protected_Virtual_New_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}

		// Token: 0x020009DE RID: 2526
		private sealed class MethodInfoStoreGeneric_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002D34 RID: 11572
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_IsRenderRequestSupported_FamOrAssem_Virtual_New_Boolean_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}

		// Token: 0x020009DF RID: 2527
		private sealed class MethodInfoStoreGeneric_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0<RequestData>
		{
			// Token: 0x04002D35 RID: 11573
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(RenderPipeline.NativeMethodInfoPtr_InternalProcessRenderRequests_Internal_Void_ScriptableRenderContext_Camera_RequestData_0, Il2CppClassPointerStore<RenderPipeline>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<RequestData>.NativeClassPtr)) }))));
		}
	}
}
