using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x020000B7 RID: 183
	public class TransparentSettingsPass : ScriptableRenderPass
	{
		// Token: 0x06000E9A RID: 3738 RVA: 0x00047DF0 File Offset: 0x00045FF0
		// Note: this type is marked as 'beforefieldinit'.
		static TransparentSettingsPass()
		{
			Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "TransparentSettingsPass");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr);
			TransparentSettingsPass.NativeFieldInfoPtr_m_shouldReceiveShadows = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, "m_shouldReceiveShadows");
			TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilerTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, "m_ProfilerTag");
			TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilingSampler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, "m_ProfilingSampler");
			TransparentSettingsPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665167);
			TransparentSettingsPass.NativeMethodInfoPtr_Setup_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665168);
			TransparentSettingsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665169);
			TransparentSettingsPass.NativeMethodInfoPtr_ExecutePass_Public_Static_Void_CommandBuffer_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr, 100665170);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x00047EAC File Offset: 0x000460AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 614326, RefRangeEnd = 614327, XrefRangeStart = 614315, XrefRangeEnd = 614326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TransparentSettingsPass(RenderPassEvent evt, bool shadowReceiveSupported)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TransparentSettingsPass>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref evt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shadowReceiveSupported;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentSettingsPass.NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9C RID: 3740 RVA: 0x00047F04 File Offset: 0x00046104
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614327, RefRangeEnd = 614329, XrefRangeStart = 614327, XrefRangeEnd = 614327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Setup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentSettingsPass.NativeMethodInfoPtr_Setup_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000E9D RID: 3741 RVA: 0x00047F40 File Offset: 0x00046140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 614329, XrefRangeEnd = 614333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TransparentSettingsPass.NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x00047F9C File Offset: 0x0004619C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 614350, RefRangeEnd = 614352, XrefRangeStart = 614333, XrefRangeEnd = 614350, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ExecutePass(CommandBuffer cmd, bool shouldReceiveShadows)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cmd);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shouldReceiveShadows;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TransparentSettingsPass.NativeMethodInfoPtr_ExecutePass_Public_Static_Void_CommandBuffer_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00009041 File Offset: 0x00007241
		public TransparentSettingsPass(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x00047FE0 File Offset: 0x000461E0
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x0000904A File Offset: 0x0000724A
		public unsafe bool m_shouldReceiveShadows
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentSettingsPass.NativeFieldInfoPtr_m_shouldReceiveShadows);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TransparentSettingsPass.NativeFieldInfoPtr_m_shouldReceiveShadows)) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x06000EA2 RID: 3746 RVA: 0x00048008 File Offset: 0x00046208
		// (set) Token: 0x06000EA3 RID: 3747 RVA: 0x00009065 File Offset: 0x00007265
		public unsafe static string m_ProfilerTag
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilerTag, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilerTag, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00048028 File Offset: 0x00046228
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x00009077 File Offset: 0x00007277
		public unsafe static ProfilingSampler m_ProfilingSampler
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilingSampler, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ProfilingSampler>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TransparentSettingsPass.NativeFieldInfoPtr_m_ProfilingSampler, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000AAB RID: 2731
		private static readonly IntPtr NativeFieldInfoPtr_m_shouldReceiveShadows;

		// Token: 0x04000AAC RID: 2732
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilerTag;

		// Token: 0x04000AAD RID: 2733
		private static readonly IntPtr NativeFieldInfoPtr_m_ProfilingSampler;

		// Token: 0x04000AAE RID: 2734
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_RenderPassEvent_Boolean_0;

		// Token: 0x04000AAF RID: 2735
		private static readonly IntPtr NativeMethodInfoPtr_Setup_Public_Boolean_0;

		// Token: 0x04000AB0 RID: 2736
		private static readonly IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Void_ScriptableRenderContext_byref_RenderingData_0;

		// Token: 0x04000AB1 RID: 2737
		private static readonly IntPtr NativeMethodInfoPtr_ExecutePass_Public_Static_Void_CommandBuffer_Boolean_0;
	}
}
