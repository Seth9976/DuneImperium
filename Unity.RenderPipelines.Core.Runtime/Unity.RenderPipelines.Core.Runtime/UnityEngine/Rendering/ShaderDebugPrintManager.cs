using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Rendering
{
	// Token: 0x0200007B RID: 123
	public sealed class ShaderDebugPrintManager : Object
	{
		// Token: 0x06000818 RID: 2072 RVA: 0x0002BF7C File Offset: 0x0002A17C
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderDebugPrintManager()
		{
			Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "ShaderDebugPrintManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr);
			ShaderDebugPrintManager.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "s_Instance");
			ShaderDebugPrintManager.NativeFieldInfoPtr_k_DebugUAVSlot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_DebugUAVSlot");
			ShaderDebugPrintManager.NativeFieldInfoPtr_k_FramesInFlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_FramesInFlight");
			ShaderDebugPrintManager.NativeFieldInfoPtr_k_MaxBufferElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_MaxBufferElements");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputBuffers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputBuffers");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_ReadbackRequests = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ReadbackRequests");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_BufferReadCompleteAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_BufferReadCompleteAction");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_FrameCounter");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCleared = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_FrameCleared");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputLine");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_OutputAction");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ShaderPropertyIDInputMouse");
			ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "m_ShaderPropertyIDInputFrame");
			ShaderDebugPrintManager.NativeFieldInfoPtr_k_TypeHasTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "k_TypeHasTag");
			ShaderDebugPrintManager.NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664582);
			ShaderDebugPrintManager.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664583);
			ShaderDebugPrintManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664584);
			ShaderDebugPrintManager.NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664585);
			ShaderDebugPrintManager.NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664586);
			ShaderDebugPrintManager.NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664587);
			ShaderDebugPrintManager.NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664588);
			ShaderDebugPrintManager.NativeMethodInfoPtr_EndFrame_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664589);
			ShaderDebugPrintManager.NativeMethodInfoPtr_get_outputLine_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664590);
			ShaderDebugPrintManager.NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664591);
			ShaderDebugPrintManager.NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, 100664592);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0002C1A0 File Offset: 0x0002A3A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965158, RefRangeEnd = 965159, XrefRangeStart = 965158, XrefRangeEnd = 965158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int DebugValueTypeToElemSize(ShaderDebugPrintManager.DebugValueType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref type;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x0002C1EC File Offset: 0x0002A3EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 965207, RefRangeEnd = 965208, XrefRangeStart = 965159, XrefRangeEnd = 965207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShaderDebugPrintManager()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x0002C228 File Offset: 0x0002A428
		public unsafe static ShaderDebugPrintManager instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965208, XrefRangeEnd = 965212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ShaderDebugPrintManager>(intPtr3) : null;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0002C25C File Offset: 0x0002A45C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965212, XrefRangeEnd = 965235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderDebugPrintInputConstants(CommandBuffer cmd, ShaderDebugPrintInput input)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref input;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x0002C2AC File Offset: 0x0002A4AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965235, XrefRangeEnd = 965255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetShaderDebugPrintBindings(CommandBuffer cmd)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x0002C2F0 File Offset: 0x0002A4F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965255, XrefRangeEnd = 965264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearShaderDebugPrintBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x0002C324 File Offset: 0x0002A524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965264, XrefRangeEnd = 965452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BufferReadComplete(AsyncGPUReadbackRequest request)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref request;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0002C364 File Offset: 0x0002A564
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965452, XrefRangeEnd = 965459, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndFrame()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_EndFrame_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x0002C398 File Offset: 0x0002A598
		public unsafe string outputLine
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_get_outputLine_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000259 RID: 601
		// (set) Token: 0x06000822 RID: 2082 RVA: 0x0002C3D0 File Offset: 0x0002A5D0
		public unsafe Action<string> outputAction
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002C414 File Offset: 0x0002A614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965459, XrefRangeEnd = 965463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DefaultOutput(string line)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(line);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderDebugPrintManager.NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0000532C File Offset: 0x0000352C
		public ShaderDebugPrintManager(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x0002C458 File Offset: 0x0002A658
		// (set) Token: 0x06000826 RID: 2086 RVA: 0x00005335 File Offset: 0x00003535
		public unsafe static ShaderDebugPrintManager s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ShaderDebugPrintManager>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x0002C480 File Offset: 0x0002A680
		// (set) Token: 0x06000828 RID: 2088 RVA: 0x00005347 File Offset: 0x00003547
		public unsafe static int k_DebugUAVSlot
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_DebugUAVSlot, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_DebugUAVSlot, (void*)(&value));
			}
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x0002C49C File Offset: 0x0002A69C
		// (set) Token: 0x0600082A RID: 2090 RVA: 0x00005355 File Offset: 0x00003555
		public unsafe static int k_FramesInFlight
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_FramesInFlight, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_FramesInFlight, (void*)(&value));
			}
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x0002C4B8 File Offset: 0x0002A6B8
		// (set) Token: 0x0600082C RID: 2092 RVA: 0x00005363 File Offset: 0x00003563
		public unsafe static int k_MaxBufferElements
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_MaxBufferElements, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_MaxBufferElements, (void*)(&value));
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x0002C4D4 File Offset: 0x0002A6D4
		// (set) Token: 0x0600082E RID: 2094 RVA: 0x00005371 File Offset: 0x00003571
		public unsafe List<GraphicsBuffer> m_OutputBuffers
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputBuffers);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GraphicsBuffer>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputBuffers), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x0002C504 File Offset: 0x0002A704
		// (set) Token: 0x06000830 RID: 2096 RVA: 0x00005390 File Offset: 0x00003590
		public unsafe List<AsyncGPUReadbackRequest> m_ReadbackRequests
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ReadbackRequests);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AsyncGPUReadbackRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ReadbackRequests), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000831 RID: 2097 RVA: 0x0002C534 File Offset: 0x0002A734
		// (set) Token: 0x06000832 RID: 2098 RVA: 0x000053AF File Offset: 0x000035AF
		public unsafe Action<AsyncGPUReadbackRequest> m_BufferReadCompleteAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_BufferReadCompleteAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncGPUReadbackRequest>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_BufferReadCompleteAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000833 RID: 2099 RVA: 0x0002C564 File Offset: 0x0002A764
		// (set) Token: 0x06000834 RID: 2100 RVA: 0x000053CE File Offset: 0x000035CE
		public unsafe int m_FrameCounter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCounter);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCounter)) = value;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x06000835 RID: 2101 RVA: 0x0002C58C File Offset: 0x0002A78C
		// (set) Token: 0x06000836 RID: 2102 RVA: 0x000053E9 File Offset: 0x000035E9
		public unsafe bool m_FrameCleared
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCleared);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_FrameCleared)) = value;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000837 RID: 2103 RVA: 0x0002C5B4 File Offset: 0x0002A7B4
		// (set) Token: 0x06000838 RID: 2104 RVA: 0x00005404 File Offset: 0x00003604
		public unsafe string m_OutputLine
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputLine);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputLine), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0002C5DC File Offset: 0x0002A7DC
		// (set) Token: 0x0600083A RID: 2106 RVA: 0x00005423 File Offset: 0x00003623
		public unsafe Action<string> m_OutputAction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputAction);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ShaderDebugPrintManager.NativeFieldInfoPtr_m_OutputAction), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0002C60C File Offset: 0x0002A80C
		// (set) Token: 0x0600083C RID: 2108 RVA: 0x00005442 File Offset: 0x00003642
		public unsafe static int m_ShaderPropertyIDInputMouse
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse, (void*)(&value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0002C628 File Offset: 0x0002A828
		// (set) Token: 0x0600083E RID: 2110 RVA: 0x00005450 File Offset: 0x00003650
		public unsafe static int m_ShaderPropertyIDInputFrame
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame, (void*)(&value));
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x0002C644 File Offset: 0x0002A844
		// (set) Token: 0x06000840 RID: 2112 RVA: 0x0000545E File Offset: 0x0000365E
		public unsafe static uint k_TypeHasTag
		{
			get
			{
				uint num;
				IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_TypeHasTag, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.NativeFieldInfoPtr_k_TypeHasTag, (void*)(&value));
			}
		}

		// Token: 0x04000600 RID: 1536
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000601 RID: 1537
		private static readonly IntPtr NativeFieldInfoPtr_k_DebugUAVSlot;

		// Token: 0x04000602 RID: 1538
		private static readonly IntPtr NativeFieldInfoPtr_k_FramesInFlight;

		// Token: 0x04000603 RID: 1539
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxBufferElements;

		// Token: 0x04000604 RID: 1540
		private static readonly IntPtr NativeFieldInfoPtr_m_OutputBuffers;

		// Token: 0x04000605 RID: 1541
		private static readonly IntPtr NativeFieldInfoPtr_m_ReadbackRequests;

		// Token: 0x04000606 RID: 1542
		private static readonly IntPtr NativeFieldInfoPtr_m_BufferReadCompleteAction;

		// Token: 0x04000607 RID: 1543
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameCounter;

		// Token: 0x04000608 RID: 1544
		private static readonly IntPtr NativeFieldInfoPtr_m_FrameCleared;

		// Token: 0x04000609 RID: 1545
		private static readonly IntPtr NativeFieldInfoPtr_m_OutputLine;

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr_m_OutputAction;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderPropertyIDInputMouse;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeFieldInfoPtr_m_ShaderPropertyIDInputFrame;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeFieldInfoPtr_k_TypeHasTag;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr_DebugValueTypeToElemSize_Private_Int32_DebugValueType_0;

		// Token: 0x0400060F RID: 1551
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04000610 RID: 1552
		private static readonly IntPtr NativeMethodInfoPtr_get_instance_Public_Static_get_ShaderDebugPrintManager_0;

		// Token: 0x04000611 RID: 1553
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDebugPrintInputConstants_Public_Void_CommandBuffer_ShaderDebugPrintInput_0;

		// Token: 0x04000612 RID: 1554
		private static readonly IntPtr NativeMethodInfoPtr_SetShaderDebugPrintBindings_Public_Void_CommandBuffer_0;

		// Token: 0x04000613 RID: 1555
		private static readonly IntPtr NativeMethodInfoPtr_ClearShaderDebugPrintBuffer_Private_Void_0;

		// Token: 0x04000614 RID: 1556
		private static readonly IntPtr NativeMethodInfoPtr_BufferReadComplete_Private_Void_AsyncGPUReadbackRequest_0;

		// Token: 0x04000615 RID: 1557
		private static readonly IntPtr NativeMethodInfoPtr_EndFrame_Public_Void_0;

		// Token: 0x04000616 RID: 1558
		private static readonly IntPtr NativeMethodInfoPtr_get_outputLine_Public_get_String_0;

		// Token: 0x04000617 RID: 1559
		private static readonly IntPtr NativeMethodInfoPtr_set_outputAction_Public_set_Void_Action_1_String_0;

		// Token: 0x04000618 RID: 1560
		private static readonly IntPtr NativeMethodInfoPtr_DefaultOutput_Public_Void_String_0;

		// Token: 0x020001B6 RID: 438
		public static class Profiling : Object
		{
			// Token: 0x0600184B RID: 6219 RVA: 0x0000C116 File Offset: 0x0000A316
			// Note: this type is marked as 'beforefieldinit'.
			static Profiling()
			{
				Il2CppClassPointerStore<ShaderDebugPrintManager.Profiling>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderDebugPrintManager>.NativeClassPtr, "Profiling");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderDebugPrintManager.Profiling>.NativeClassPtr);
				ShaderDebugPrintManager.Profiling.NativeFieldInfoPtr_BufferReadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderDebugPrintManager.Profiling>.NativeClassPtr, "BufferReadComplete");
			}

			// Token: 0x0600184C RID: 6220 RVA: 0x0000C14A File Offset: 0x0000A34A
			public Profiling(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006D4 RID: 1748
			// (get) Token: 0x0600184D RID: 6221 RVA: 0x00067200 File Offset: 0x00065400
			// (set) Token: 0x0600184E RID: 6222 RVA: 0x0000C153 File Offset: 0x0000A353
			public unsafe static ProfilingSampler BufferReadComplete
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderDebugPrintManager.Profiling.NativeFieldInfoPtr_BufferReadComplete, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderDebugPrintManager.Profiling.NativeFieldInfoPtr_BufferReadComplete, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001189 RID: 4489
			private static readonly IntPtr NativeFieldInfoPtr_BufferReadComplete;
		}

		// Token: 0x020001B7 RID: 439
		public enum DebugValueType
		{
			// Token: 0x0400118B RID: 4491
			TypeUint = 1,
			// Token: 0x0400118C RID: 4492
			TypeInt,
			// Token: 0x0400118D RID: 4493
			TypeFloat,
			// Token: 0x0400118E RID: 4494
			TypeUint2,
			// Token: 0x0400118F RID: 4495
			TypeInt2,
			// Token: 0x04001190 RID: 4496
			TypeFloat2,
			// Token: 0x04001191 RID: 4497
			TypeUint3,
			// Token: 0x04001192 RID: 4498
			TypeInt3,
			// Token: 0x04001193 RID: 4499
			TypeFloat3,
			// Token: 0x04001194 RID: 4500
			TypeUint4,
			// Token: 0x04001195 RID: 4501
			TypeInt4,
			// Token: 0x04001196 RID: 4502
			TypeFloat4,
			// Token: 0x04001197 RID: 4503
			TypeBool
		}
	}
}
