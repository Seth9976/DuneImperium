using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering.Universal
{
	// Token: 0x0200005D RID: 93
	public class DebugRenderSetup : Object
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0003173C File Offset: 0x0002F93C
		// Note: this type is marked as 'beforefieldinit'.
		static DebugRenderSetup()
		{
			Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Universal.Runtime.dll", "UnityEngine.Rendering.Universal", "DebugRenderSetup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr);
			DebugRenderSetup.NativeFieldInfoPtr_m_DebugHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_DebugHandler");
			DebugRenderSetup.NativeFieldInfoPtr_m_Context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_Context");
			DebugRenderSetup.NativeFieldInfoPtr_m_CommandBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_CommandBuffer");
			DebugRenderSetup.NativeFieldInfoPtr_m_Index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_Index");
			DebugRenderSetup.NativeFieldInfoPtr_m_FilteringSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, "m_FilteringSettings");
			DebugRenderSetup.NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664430);
			DebugRenderSetup.NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664431);
			DebugRenderSetup.NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664432);
			DebugRenderSetup.NativeMethodInfoPtr_Begin_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664433);
			DebugRenderSetup.NativeMethodInfoPtr_End_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664434);
			DebugRenderSetup.NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_Int32_FilteringSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664435);
			DebugRenderSetup.NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664436);
			DebugRenderSetup.NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664437);
			DebugRenderSetup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr, 100664438);
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00031884 File Offset: 0x0002FA84
		public unsafe DebugDisplaySettingsMaterial MaterialSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsMaterial>(intPtr3) : null;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000318C4 File Offset: 0x0002FAC4
		public unsafe DebugDisplaySettingsRendering RenderingSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsRendering>(intPtr3) : null;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00031904 File Offset: 0x0002FB04
		public unsafe DebugDisplaySettingsLighting LightingSettings
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DebugDisplaySettingsLighting>(intPtr3) : null;
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x00031944 File Offset: 0x0002FB44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606113, XrefRangeEnd = 606122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_Begin_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00031978 File Offset: 0x0002FB78
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606127, RefRangeEnd = 606130, XrefRangeStart = 606122, XrefRangeEnd = 606127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_End_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000319AC File Offset: 0x0002FBAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606130, XrefRangeEnd = 606142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugRenderSetup(DebugHandler debugHandler, ScriptableRenderContext context, CommandBuffer commandBuffer, int index, FilteringSettings filteringSettings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugRenderSetup>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(debugHandler);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref context;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(commandBuffer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref filteringSettings;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_Int32_FilteringSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x00031A34 File Offset: 0x0002FC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 606142, XrefRangeEnd = 606144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DrawingSettings CreateDrawingSettings(DrawingSettings drawingSettings)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref drawingSettings;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x00031A80 File Offset: 0x0002FC80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 606176, RefRangeEnd = 606177, XrefRangeStart = 606144, XrefRangeEnd = 606176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderStateBlock GetRenderStateBlock(RenderStateBlock renderStateBlock)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref renderStateBlock;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00031ACC File Offset: 0x0002FCCC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 606127, RefRangeEnd = 606130, XrefRangeStart = 606127, XrefRangeEnd = 606130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugRenderSetup.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00005802 File Offset: 0x00003A02
		public DebugRenderSetup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00031B00 File Offset: 0x0002FD00
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x0000580B File Offset: 0x00003A0B
		public unsafe DebugHandler m_DebugHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_DebugHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_DebugHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00031B30 File Offset: 0x0002FD30
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x0000582A File Offset: 0x00003A2A
		public unsafe ScriptableRenderContext m_Context
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_Context);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_Context)) = value;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00031B58 File Offset: 0x0002FD58
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00005845 File Offset: 0x00003A45
		public unsafe CommandBuffer m_CommandBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_CommandBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CommandBuffer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_CommandBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00031B88 File Offset: 0x0002FD88
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x00005864 File Offset: 0x00003A64
		public unsafe int m_Index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_Index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_Index)) = value;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00031BB0 File Offset: 0x0002FDB0
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x0000587F File Offset: 0x00003A7F
		public unsafe FilteringSettings m_FilteringSettings
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_FilteringSettings);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugRenderSetup.NativeFieldInfoPtr_m_FilteringSettings)) = value;
			}
		}

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeFieldInfoPtr_m_DebugHandler;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeFieldInfoPtr_m_Context;

		// Token: 0x04000635 RID: 1589
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandBuffer;

		// Token: 0x04000636 RID: 1590
		private static readonly IntPtr NativeFieldInfoPtr_m_Index;

		// Token: 0x04000637 RID: 1591
		private static readonly IntPtr NativeFieldInfoPtr_m_FilteringSettings;

		// Token: 0x04000638 RID: 1592
		private static readonly IntPtr NativeMethodInfoPtr_get_MaterialSettings_Private_get_DebugDisplaySettingsMaterial_0;

		// Token: 0x04000639 RID: 1593
		private static readonly IntPtr NativeMethodInfoPtr_get_RenderingSettings_Private_get_DebugDisplaySettingsRendering_0;

		// Token: 0x0400063A RID: 1594
		private static readonly IntPtr NativeMethodInfoPtr_get_LightingSettings_Private_get_DebugDisplaySettingsLighting_0;

		// Token: 0x0400063B RID: 1595
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Private_Void_0;

		// Token: 0x0400063C RID: 1596
		private static readonly IntPtr NativeMethodInfoPtr_End_Private_Void_0;

		// Token: 0x0400063D RID: 1597
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DebugHandler_ScriptableRenderContext_CommandBuffer_Int32_FilteringSettings_0;

		// Token: 0x0400063E RID: 1598
		private static readonly IntPtr NativeMethodInfoPtr_CreateDrawingSettings_Internal_DrawingSettings_DrawingSettings_0;

		// Token: 0x0400063F RID: 1599
		private static readonly IntPtr NativeMethodInfoPtr_GetRenderStateBlock_Internal_RenderStateBlock_RenderStateBlock_0;

		// Token: 0x04000640 RID: 1600
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
	}
}
