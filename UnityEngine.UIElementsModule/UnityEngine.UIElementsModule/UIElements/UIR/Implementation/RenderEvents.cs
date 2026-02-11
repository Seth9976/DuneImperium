using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR.Implementation
{
	// Token: 0x0200027B RID: 635
	public static class RenderEvents : Object
	{
		// Token: 0x06002F2E RID: 12078 RVA: 0x000C8418 File Offset: 0x000C6618
		// Note: this type is marked as 'beforefieldinit'.
		static RenderEvents()
		{
			Il2CppClassPointerStore<RenderEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR.Implementation", "RenderEvents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr);
			RenderEvents.NativeFieldInfoPtr_VisibilityTreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, "VisibilityTreshold");
			RenderEvents.NativeMethodInfoPtr_ProcessOnClippingChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670119);
			RenderEvents.NativeMethodInfoPtr_ProcessOnOpacityChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670120);
			RenderEvents.NativeMethodInfoPtr_ProcessOnColorChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670121);
			RenderEvents.NativeMethodInfoPtr_ProcessOnTransformOrSizeChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670122);
			RenderEvents.NativeMethodInfoPtr_ProcessOnVisualsChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670123);
			RenderEvents.NativeMethodInfoPtr_GetTransformIDTransformInfo_Private_Static_Matrix4x4_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670124);
			RenderEvents.NativeMethodInfoPtr_GetClipRectIDClipInfo_Private_Static_Vector4_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670125);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnChildAdded_Internal_Static_UInt32_RenderChain_VisualElement_VisualElement_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670126);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnChildRemoving_Internal_Static_UInt32_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670127);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnClippingChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_Boolean_Boolean_Boolean_Boolean_Boolean_UIRenderDevice_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670128);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnOpacityChanged_Private_Static_Void_RenderChain_Single_VisualElement_UInt32_Boolean_byref_ChainBuilderStats_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670129);
			RenderEvents.NativeMethodInfoPtr_OnColorChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670130);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnTransformOrSizeChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_UIRenderDevice_Boolean_Boolean_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670131);
			RenderEvents.NativeMethodInfoPtr_DepthFirstOnVisualsChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_Boolean_Boolean_byref_ChainBuilderStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670132);
			RenderEvents.NativeMethodInfoPtr_UpdateTextCoreSettings_Private_Static_Boolean_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670133);
			RenderEvents.NativeMethodInfoPtr_IsElementHierarchyHidden_Private_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670134);
			RenderEvents.NativeMethodInfoPtr_GetLastDeepestChild_Private_Static_VisualElement_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670135);
			RenderEvents.NativeMethodInfoPtr_DetermineSelfClipMethod_Private_Static_ClipMethod_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670136);
			RenderEvents.NativeMethodInfoPtr_UpdateLocalFlipsWinding_Private_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670137);
			RenderEvents.NativeMethodInfoPtr_UpdateWorldFlipsWinding_Private_Static_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670138);
			RenderEvents.NativeMethodInfoPtr_UpdateZeroScaling_Private_Static_Void_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670139);
			RenderEvents.NativeMethodInfoPtr_NeedsTransformID_Private_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670140);
			RenderEvents.NativeMethodInfoPtr_NeedsColorID_Internal_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670141);
			RenderEvents.NativeMethodInfoPtr_NeedsTextCoreSettings_Internal_Static_Boolean_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670142);
			RenderEvents.NativeMethodInfoPtr_InitColorIDs_Private_Static_Boolean_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670143);
			RenderEvents.NativeMethodInfoPtr_SetColorValues_Private_Static_Void_RenderChain_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderEvents>.NativeClassPtr, 100670144);
		}

		// Token: 0x06002F2F RID: 12079 RVA: 0x000C8664 File Offset: 0x000C6864
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353414, RefRangeEnd = 353415, XrefRangeStart = 353408, XrefRangeEnd = 353414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessOnClippingChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_ProcessOnClippingChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F30 RID: 12080 RVA: 0x000C86C8 File Offset: 0x000C68C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353422, RefRangeEnd = 353423, XrefRangeStart = 353415, XrefRangeEnd = 353422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessOnOpacityChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_ProcessOnOpacityChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F31 RID: 12081 RVA: 0x000C872C File Offset: 0x000C692C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353427, RefRangeEnd = 353428, XrefRangeStart = 353423, XrefRangeEnd = 353427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessOnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_ProcessOnColorChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F32 RID: 12082 RVA: 0x000C8790 File Offset: 0x000C6990
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353433, RefRangeEnd = 353434, XrefRangeStart = 353428, XrefRangeEnd = 353433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessOnTransformOrSizeChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_ProcessOnTransformOrSizeChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F33 RID: 12083 RVA: 0x000C87F4 File Offset: 0x000C69F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353448, RefRangeEnd = 353449, XrefRangeStart = 353434, XrefRangeEnd = 353448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ProcessOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_ProcessOnVisualsChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F34 RID: 12084 RVA: 0x000C8858 File Offset: 0x000C6A58
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353466, RefRangeEnd = 353468, XrefRangeStart = 353449, XrefRangeEnd = 353466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Matrix4x4 GetTransformIDTransformInfo(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_GetTransformIDTransformInfo_Private_Static_Matrix4x4_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F35 RID: 12085 RVA: 0x000C889C File Offset: 0x000C6A9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353487, RefRangeEnd = 353488, XrefRangeStart = 353468, XrefRangeEnd = 353487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Vector4 GetClipRectIDClipInfo(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_GetClipRectIDClipInfo_Private_Static_Vector4_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F36 RID: 12086 RVA: 0x000C88E0 File Offset: 0x000C6AE0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 353587, RefRangeEnd = 353590, XrefRangeStart = 353488, XrefRangeEnd = 353587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint DepthFirstOnChildAdded(RenderChain renderChain, VisualElement parent, VisualElement ve, int index, bool resetState)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref resetState;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnChildAdded_Internal_Static_UInt32_RenderChain_VisualElement_VisualElement_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F37 RID: 12087 RVA: 0x000C8964 File Offset: 0x000C6B64
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 353782, RefRangeEnd = 353786, XrefRangeStart = 353590, XrefRangeEnd = 353782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint DepthFirstOnChildRemoving(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnChildRemoving_Internal_Static_UInt32_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F38 RID: 12088 RVA: 0x000C89B8 File Offset: 0x000C6BB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353844, RefRangeEnd = 353846, XrefRangeStart = 353786, XrefRangeEnd = 353844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DepthFirstOnClippingChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, bool hierarchical, bool isRootOfChange, bool isPendingHierarchicalRepaint, bool inheritedClipRectIDChanged, bool inheritedMaskingChanged, UIRenderDevice device, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isRootOfChange;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isPendingHierarchicalRepaint;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedClipRectIDChanged;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inheritedMaskingChanged;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnClippingChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_Boolean_Boolean_Boolean_Boolean_Boolean_UIRenderDevice_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F39 RID: 12089 RVA: 0x000C8A8C File Offset: 0x000C6C8C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353878, RefRangeEnd = 353880, XrefRangeStart = 353846, XrefRangeEnd = 353878, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DepthFirstOnOpacityChanged(RenderChain renderChain, float parentCompositeOpacity, VisualElement ve, uint dirtyID, bool hierarchical, ref ChainBuilderStats stats, bool isDoingFullVertexRegeneration = false)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentCompositeOpacity;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isDoingFullVertexRegeneration;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnOpacityChanged_Private_Static_Void_RenderChain_Single_VisualElement_UInt32_Boolean_byref_ChainBuilderStats_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3A RID: 12090 RVA: 0x000C8B1C File Offset: 0x000C6D1C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353899, RefRangeEnd = 353900, XrefRangeStart = 353880, XrefRangeEnd = 353899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OnColorChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_OnColorChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3B RID: 12091 RVA: 0x000C8B80 File Offset: 0x000C6D80
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 353953, RefRangeEnd = 353955, XrefRangeStart = 353900, XrefRangeEnd = 353953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DepthFirstOnTransformOrSizeChanged(RenderChain renderChain, VisualElement parent, VisualElement ve, uint dirtyID, UIRenderDevice device, bool isAncestorOfChangeSkinned, bool transformChanged, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(device);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isAncestorOfChangeSkinned;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref transformChanged;
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnTransformOrSizeChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_UIRenderDevice_Boolean_Boolean_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3C RID: 12092 RVA: 0x000C8C28 File Offset: 0x000C6E28
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 353976, RefRangeEnd = 353977, XrefRangeStart = 353955, XrefRangeEnd = 353976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DepthFirstOnVisualsChanged(RenderChain renderChain, VisualElement ve, uint dirtyID, bool parentHierarchyHidden, bool hierarchical, ref ChainBuilderStats stats)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dirtyID;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref parentHierarchyHidden;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hierarchical;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = &stats;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DepthFirstOnVisualsChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_Boolean_Boolean_byref_ChainBuilderStats_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000C8CAC File Offset: 0x000C6EAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354023, RefRangeEnd = 354024, XrefRangeStart = 353977, XrefRangeEnd = 354023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateTextCoreSettings(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_UpdateTextCoreSettings_Private_Static_Boolean_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F3E RID: 12094 RVA: 0x000C8D00 File Offset: 0x000C6F00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354024, XrefRangeEnd = 354028, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsElementHierarchyHidden(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_IsElementHierarchyHidden_Private_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x000C8D44 File Offset: 0x000C6F44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354028, XrefRangeEnd = 354031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VisualElement GetLastDeepestChild(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_GetLastDeepestChild_Private_Static_VisualElement_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x000C8D88 File Offset: 0x000C6F88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354031, XrefRangeEnd = 354041, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ClipMethod DetermineSelfClipMethod(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_DetermineSelfClipMethod_Private_Static_ClipMethod_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F41 RID: 12097 RVA: 0x000C8DDC File Offset: 0x000C6FDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354050, RefRangeEnd = 354052, XrefRangeStart = 354041, XrefRangeEnd = 354050, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool UpdateLocalFlipsWinding(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_UpdateLocalFlipsWinding_Private_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F42 RID: 12098 RVA: 0x000C8E20 File Offset: 0x000C7020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354052, XrefRangeEnd = 354053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateWorldFlipsWinding(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_UpdateWorldFlipsWinding_Private_Static_Void_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F43 RID: 12099 RVA: 0x000C8E58 File Offset: 0x000C7058
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 354064, RefRangeEnd = 354065, XrefRangeStart = 354053, XrefRangeEnd = 354064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UpdateZeroScaling(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_UpdateZeroScaling_Private_Static_Void_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002F44 RID: 12100 RVA: 0x000C8E90 File Offset: 0x000C7090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354065, XrefRangeEnd = 354066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedsTransformID(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_NeedsTransformID_Private_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F45 RID: 12101 RVA: 0x000C8ED4 File Offset: 0x000C70D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354066, XrefRangeEnd = 354067, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedsColorID(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_NeedsColorID_Internal_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F46 RID: 12102 RVA: 0x000C8F18 File Offset: 0x000C7118
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 354067, XrefRangeEnd = 354071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool NeedsTextCoreSettings(VisualElement ve)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_NeedsTextCoreSettings_Internal_Static_Boolean_VisualElement_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002F47 RID: 12103 RVA: 0x000C8F5C File Offset: 0x000C715C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354152, RefRangeEnd = 354154, XrefRangeStart = 354071, XrefRangeEnd = 354152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InitColorIDs(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_InitColorIDs_Private_Static_Boolean_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002F48 RID: 12104 RVA: 0x000C8FB0 File Offset: 0x000C71B0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 354211, RefRangeEnd = 354213, XrefRangeStart = 354154, XrefRangeEnd = 354211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetColorValues(RenderChain renderChain, VisualElement ve)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(renderChain);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(ve);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderEvents.NativeMethodInfoPtr_SetColorValues_Private_Static_Void_RenderChain_VisualElement_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F49 RID: 12105 RVA: 0x000137A0 File Offset: 0x000119A0
		public RenderEvents(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC6 RID: 3782
		// (get) Token: 0x06002F4A RID: 12106 RVA: 0x000C8FF8 File Offset: 0x000C71F8
		// (set) Token: 0x06002F4B RID: 12107 RVA: 0x000137A9 File Offset: 0x000119A9
		public unsafe static float VisibilityTreshold
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(RenderEvents.NativeFieldInfoPtr_VisibilityTreshold, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RenderEvents.NativeFieldInfoPtr_VisibilityTreshold, (void*)(&value));
			}
		}

		// Token: 0x06002F4C RID: 12108 RVA: 0x000C9014 File Offset: 0x000C7214
		public static VisualElement GetNextDepthFirst(VisualElement ve)
		{
			VisualElement.Hierarchy hierarchy = ve.hierarchy;
			for (VisualElement visualElement = hierarchy.parent; visualElement != null; visualElement = hierarchy.parent)
			{
				hierarchy = visualElement.hierarchy;
				int num = hierarchy.IndexOf(ve);
				hierarchy = visualElement.hierarchy;
				int childCount = hierarchy.childCount;
				bool flag = num < childCount - 1;
				if (flag)
				{
					hierarchy = visualElement.hierarchy;
					return hierarchy[num + 1];
				}
				ve = visualElement;
				hierarchy = visualElement.hierarchy;
			}
			return null;
		}

		// Token: 0x06002F4D RID: 12109 RVA: 0x000C9098 File Offset: 0x000C7298
		public static bool TransformIDHasChanged(Alloc before, Alloc after)
		{
			bool flag = before.size == 0U && after.size == 0U;
			bool flag2;
			if (flag)
			{
				flag2 = false;
			}
			else
			{
				bool flag3 = before.size != after.size || before.start != after.start;
				flag2 = flag3;
			}
			return flag2;
		}

		// Token: 0x06002F4E RID: 12110 RVA: 0x000137B7 File Offset: 0x000119B7
		public static void ResetColorIDs(VisualElement ve)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x040021EA RID: 8682
		private static readonly IntPtr NativeFieldInfoPtr_VisibilityTreshold;

		// Token: 0x040021EB RID: 8683
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOnClippingChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021EC RID: 8684
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOnOpacityChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021ED RID: 8685
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOnColorChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021EE RID: 8686
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOnTransformOrSizeChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021EF RID: 8687
		private static readonly IntPtr NativeMethodInfoPtr_ProcessOnVisualsChanged_Internal_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021F0 RID: 8688
		private static readonly IntPtr NativeMethodInfoPtr_GetTransformIDTransformInfo_Private_Static_Matrix4x4_VisualElement_0;

		// Token: 0x040021F1 RID: 8689
		private static readonly IntPtr NativeMethodInfoPtr_GetClipRectIDClipInfo_Private_Static_Vector4_VisualElement_0;

		// Token: 0x040021F2 RID: 8690
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnChildAdded_Internal_Static_UInt32_RenderChain_VisualElement_VisualElement_Int32_Boolean_0;

		// Token: 0x040021F3 RID: 8691
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnChildRemoving_Internal_Static_UInt32_RenderChain_VisualElement_0;

		// Token: 0x040021F4 RID: 8692
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnClippingChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_Boolean_Boolean_Boolean_Boolean_Boolean_UIRenderDevice_byref_ChainBuilderStats_0;

		// Token: 0x040021F5 RID: 8693
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnOpacityChanged_Private_Static_Void_RenderChain_Single_VisualElement_UInt32_Boolean_byref_ChainBuilderStats_Boolean_0;

		// Token: 0x040021F6 RID: 8694
		private static readonly IntPtr NativeMethodInfoPtr_OnColorChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_byref_ChainBuilderStats_0;

		// Token: 0x040021F7 RID: 8695
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnTransformOrSizeChanged_Private_Static_Void_RenderChain_VisualElement_VisualElement_UInt32_UIRenderDevice_Boolean_Boolean_byref_ChainBuilderStats_0;

		// Token: 0x040021F8 RID: 8696
		private static readonly IntPtr NativeMethodInfoPtr_DepthFirstOnVisualsChanged_Private_Static_Void_RenderChain_VisualElement_UInt32_Boolean_Boolean_byref_ChainBuilderStats_0;

		// Token: 0x040021F9 RID: 8697
		private static readonly IntPtr NativeMethodInfoPtr_UpdateTextCoreSettings_Private_Static_Boolean_RenderChain_VisualElement_0;

		// Token: 0x040021FA RID: 8698
		private static readonly IntPtr NativeMethodInfoPtr_IsElementHierarchyHidden_Private_Static_Boolean_VisualElement_0;

		// Token: 0x040021FB RID: 8699
		private static readonly IntPtr NativeMethodInfoPtr_GetLastDeepestChild_Private_Static_VisualElement_VisualElement_0;

		// Token: 0x040021FC RID: 8700
		private static readonly IntPtr NativeMethodInfoPtr_DetermineSelfClipMethod_Private_Static_ClipMethod_RenderChain_VisualElement_0;

		// Token: 0x040021FD RID: 8701
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLocalFlipsWinding_Private_Static_Boolean_VisualElement_0;

		// Token: 0x040021FE RID: 8702
		private static readonly IntPtr NativeMethodInfoPtr_UpdateWorldFlipsWinding_Private_Static_Void_VisualElement_0;

		// Token: 0x040021FF RID: 8703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateZeroScaling_Private_Static_Void_VisualElement_0;

		// Token: 0x04002200 RID: 8704
		private static readonly IntPtr NativeMethodInfoPtr_NeedsTransformID_Private_Static_Boolean_VisualElement_0;

		// Token: 0x04002201 RID: 8705
		private static readonly IntPtr NativeMethodInfoPtr_NeedsColorID_Internal_Static_Boolean_VisualElement_0;

		// Token: 0x04002202 RID: 8706
		private static readonly IntPtr NativeMethodInfoPtr_NeedsTextCoreSettings_Internal_Static_Boolean_VisualElement_0;

		// Token: 0x04002203 RID: 8707
		private static readonly IntPtr NativeMethodInfoPtr_InitColorIDs_Private_Static_Boolean_RenderChain_VisualElement_0;

		// Token: 0x04002204 RID: 8708
		private static readonly IntPtr NativeMethodInfoPtr_SetColorValues_Private_Static_Void_RenderChain_VisualElement_0;
	}
}
