using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UIElements.UIR.Implementation;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x02000265 RID: 613
	public sealed class RenderChainVEData : ValueType
	{
		// Token: 0x06002D41 RID: 11585 RVA: 0x000C26A8 File Offset: 0x000C08A8
		// Note: this type is marked as 'beforefieldinit'.
		static RenderChainVEData()
		{
			Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "RenderChainVEData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr);
			RenderChainVEData.NativeFieldInfoPtr_prev = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "prev");
			RenderChainVEData.NativeFieldInfoPtr_next = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "next");
			RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "groupTransformAncestor");
			RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "boneTransformAncestor");
			RenderChainVEData.NativeFieldInfoPtr_prevDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "prevDirty");
			RenderChainVEData.NativeFieldInfoPtr_nextDirty = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "nextDirty");
			RenderChainVEData.NativeFieldInfoPtr_flags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "flags");
			RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "hierarchyDepth");
			RenderChainVEData.NativeFieldInfoPtr_dirtiedValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "dirtiedValues");
			RenderChainVEData.NativeFieldInfoPtr_dirtyID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "dirtyID");
			RenderChainVEData.NativeFieldInfoPtr_firstCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "firstCommand");
			RenderChainVEData.NativeFieldInfoPtr_lastCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "lastCommand");
			RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "firstClosingCommand");
			RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "lastClosingCommand");
			RenderChainVEData.NativeFieldInfoPtr_isInChain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "isInChain");
			RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "isHierarchyHidden");
			RenderChainVEData.NativeFieldInfoPtr_localFlipsWinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "localFlipsWinding");
			RenderChainVEData.NativeFieldInfoPtr_localTransformScaleZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "localTransformScaleZero");
			RenderChainVEData.NativeFieldInfoPtr_worldFlipsWinding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "worldFlipsWinding");
			RenderChainVEData.NativeFieldInfoPtr_worldTransformScaleZero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "worldTransformScaleZero");
			RenderChainVEData.NativeFieldInfoPtr_clipMethod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "clipMethod");
			RenderChainVEData.NativeFieldInfoPtr_childrenStencilRef = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "childrenStencilRef");
			RenderChainVEData.NativeFieldInfoPtr_childrenMaskDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "childrenMaskDepth");
			RenderChainVEData.NativeFieldInfoPtr_disableNudging = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "disableNudging");
			RenderChainVEData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "data");
			RenderChainVEData.NativeFieldInfoPtr_closingData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "closingData");
			RenderChainVEData.NativeFieldInfoPtr_verticesSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "verticesSpace");
			RenderChainVEData.NativeFieldInfoPtr_displacementUVStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "displacementUVStart");
			RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "displacementUVEnd");
			RenderChainVEData.NativeFieldInfoPtr_transformID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "transformID");
			RenderChainVEData.NativeFieldInfoPtr_clipRectID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "clipRectID");
			RenderChainVEData.NativeFieldInfoPtr_opacityID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "opacityID");
			RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "textCoreSettingsID");
			RenderChainVEData.NativeFieldInfoPtr_colorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "colorID");
			RenderChainVEData.NativeFieldInfoPtr_backgroundColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "backgroundColorID");
			RenderChainVEData.NativeFieldInfoPtr_borderLeftColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "borderLeftColorID");
			RenderChainVEData.NativeFieldInfoPtr_borderTopColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "borderTopColorID");
			RenderChainVEData.NativeFieldInfoPtr_borderRightColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "borderRightColorID");
			RenderChainVEData.NativeFieldInfoPtr_borderBottomColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "borderBottomColorID");
			RenderChainVEData.NativeFieldInfoPtr_tintColorID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "tintColorID");
			RenderChainVEData.NativeFieldInfoPtr_compositeOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "compositeOpacity");
			RenderChainVEData.NativeFieldInfoPtr_backgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "backgroundColor");
			RenderChainVEData.NativeFieldInfoPtr_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, "textures");
			RenderChainVEData.NativeMethodInfoPtr_get_lastClosingOrLastCommand_Internal_get_RenderChainCommand_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, 100669962);
			RenderChainVEData.NativeMethodInfoPtr_AllocatesID_Internal_Static_Boolean_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, 100669963);
			RenderChainVEData.NativeMethodInfoPtr_InheritsID_Internal_Static_Boolean_BMPAlloc_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, 100669964);
			RenderChainVEData.NativeMethodInfoPtr_get_isIgnoringDynamicColorHint_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr, 100669965);
		}

		// Token: 0x17000E44 RID: 3652
		// (get) Token: 0x06002D42 RID: 11586 RVA: 0x000C2A84 File Offset: 0x000C0C84
		public unsafe RenderChainCommand lastClosingOrLastCommand
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainVEData.NativeMethodInfoPtr_get_lastClosingOrLastCommand_Internal_get_RenderChainCommand_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr3) : null;
			}
		}

		// Token: 0x06002D43 RID: 11587 RVA: 0x000C2AC8 File Offset: 0x000C0CC8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 351518, RefRangeEnd = 351521, XrefRangeStart = 351517, XrefRangeEnd = 351518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool AllocatesID(BMPAlloc alloc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainVEData.NativeMethodInfoPtr_AllocatesID_Internal_Static_Boolean_BMPAlloc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D44 RID: 11588 RVA: 0x000C2B08 File Offset: 0x000C0D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 351521, XrefRangeEnd = 351522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InheritsID(BMPAlloc alloc)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref alloc;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainVEData.NativeMethodInfoPtr_InheritsID_Internal_Static_Boolean_BMPAlloc_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000E45 RID: 3653
		// (get) Token: 0x06002D45 RID: 11589 RVA: 0x000C2B48 File Offset: 0x000C0D48
		public unsafe bool isIgnoringDynamicColorHint
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RenderChainVEData.NativeMethodInfoPtr_get_isIgnoringDynamicColorHint_Public_get_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002D46 RID: 11590 RVA: 0x000126B5 File Offset: 0x000108B5
		public RenderChainVEData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06002D47 RID: 11591 RVA: 0x000126BE File Offset: 0x000108BE
		public RenderChainVEData()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RenderChainVEData>.NativeClassPtr))
		{
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x06002D48 RID: 11592 RVA: 0x000C2B8C File Offset: 0x000C0D8C
		// (set) Token: 0x06002D49 RID: 11593 RVA: 0x000126D0 File Offset: 0x000108D0
		public unsafe VisualElement prev
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prev);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prev), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x06002D4A RID: 11594 RVA: 0x000C2BBC File Offset: 0x000C0DBC
		// (set) Token: 0x06002D4B RID: 11595 RVA: 0x000126EF File Offset: 0x000108EF
		public unsafe VisualElement next
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_next);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_next), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x06002D4C RID: 11596 RVA: 0x000C2BEC File Offset: 0x000C0DEC
		// (set) Token: 0x06002D4D RID: 11597 RVA: 0x0001270E File Offset: 0x0001090E
		public unsafe VisualElement groupTransformAncestor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_groupTransformAncestor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06002D4E RID: 11598 RVA: 0x000C2C1C File Offset: 0x000C0E1C
		// (set) Token: 0x06002D4F RID: 11599 RVA: 0x0001272D File Offset: 0x0001092D
		public unsafe VisualElement boneTransformAncestor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_boneTransformAncestor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06002D50 RID: 11600 RVA: 0x000C2C4C File Offset: 0x000C0E4C
		// (set) Token: 0x06002D51 RID: 11601 RVA: 0x0001274C File Offset: 0x0001094C
		public unsafe VisualElement prevDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_prevDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06002D52 RID: 11602 RVA: 0x000C2C7C File Offset: 0x000C0E7C
		// (set) Token: 0x06002D53 RID: 11603 RVA: 0x0001276B File Offset: 0x0001096B
		public unsafe VisualElement nextDirty
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextDirty);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_nextDirty), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06002D54 RID: 11604 RVA: 0x000C2CAC File Offset: 0x000C0EAC
		// (set) Token: 0x06002D55 RID: 11605 RVA: 0x0001278A File Offset: 0x0001098A
		public unsafe RenderDataFlags flags
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_flags);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_flags)) = value;
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06002D56 RID: 11606 RVA: 0x000C2CD4 File Offset: 0x000C0ED4
		// (set) Token: 0x06002D57 RID: 11607 RVA: 0x000127A5 File Offset: 0x000109A5
		public unsafe int hierarchyDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_hierarchyDepth)) = value;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06002D58 RID: 11608 RVA: 0x000C2CFC File Offset: 0x000C0EFC
		// (set) Token: 0x06002D59 RID: 11609 RVA: 0x000127C0 File Offset: 0x000109C0
		public unsafe RenderDataDirtyTypes dirtiedValues
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtiedValues);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtiedValues)) = value;
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x000C2D24 File Offset: 0x000C0F24
		// (set) Token: 0x06002D5B RID: 11611 RVA: 0x000127DB File Offset: 0x000109DB
		public unsafe uint dirtyID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtyID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_dirtyID)) = value;
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06002D5C RID: 11612 RVA: 0x000C2D4C File Offset: 0x000C0F4C
		// (set) Token: 0x06002D5D RID: 11613 RVA: 0x000127F6 File Offset: 0x000109F6
		public unsafe RenderChainCommand firstCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x000C2D7C File Offset: 0x000C0F7C
		// (set) Token: 0x06002D5F RID: 11615 RVA: 0x00012815 File Offset: 0x00010A15
		public unsafe RenderChainCommand lastCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x000C2DAC File Offset: 0x000C0FAC
		// (set) Token: 0x06002D61 RID: 11617 RVA: 0x00012834 File Offset: 0x00010A34
		public unsafe RenderChainCommand firstClosingCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_firstClosingCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x000C2DDC File Offset: 0x000C0FDC
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00012853 File Offset: 0x00010A53
		public unsafe RenderChainCommand lastClosingCommand
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderChainCommand>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_lastClosingCommand), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000C2E0C File Offset: 0x000C100C
		// (set) Token: 0x06002D65 RID: 11621 RVA: 0x00012872 File Offset: 0x00010A72
		public unsafe bool isInChain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isInChain);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isInChain)) = value;
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000C2E34 File Offset: 0x000C1034
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x0001288D File Offset: 0x00010A8D
		public unsafe bool isHierarchyHidden
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_isHierarchyHidden)) = value;
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000C2E5C File Offset: 0x000C105C
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x000128A8 File Offset: 0x00010AA8
		public unsafe bool localFlipsWinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_localFlipsWinding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_localFlipsWinding)) = value;
			}
		}

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x000C2E84 File Offset: 0x000C1084
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x000128C3 File Offset: 0x00010AC3
		public unsafe bool localTransformScaleZero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_localTransformScaleZero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_localTransformScaleZero)) = value;
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x000C2EAC File Offset: 0x000C10AC
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x000128DE File Offset: 0x00010ADE
		public unsafe bool worldFlipsWinding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_worldFlipsWinding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_worldFlipsWinding)) = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x000C2ED4 File Offset: 0x000C10D4
		// (set) Token: 0x06002D6F RID: 11631 RVA: 0x000128F9 File Offset: 0x00010AF9
		public unsafe bool worldTransformScaleZero
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_worldTransformScaleZero);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_worldTransformScaleZero)) = value;
			}
		}

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x06002D70 RID: 11632 RVA: 0x000C2EFC File Offset: 0x000C10FC
		// (set) Token: 0x06002D71 RID: 11633 RVA: 0x00012914 File Offset: 0x00010B14
		public unsafe UnityEngine.UIElements.UIR.Implementation.ClipMethod clipMethod
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipMethod);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipMethod)) = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06002D72 RID: 11634 RVA: 0x000C2F24 File Offset: 0x000C1124
		// (set) Token: 0x06002D73 RID: 11635 RVA: 0x0001292F File Offset: 0x00010B2F
		public unsafe int childrenStencilRef
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_childrenStencilRef);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_childrenStencilRef)) = value;
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06002D74 RID: 11636 RVA: 0x000C2F4C File Offset: 0x000C114C
		// (set) Token: 0x06002D75 RID: 11637 RVA: 0x0001294A File Offset: 0x00010B4A
		public unsafe int childrenMaskDepth
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_childrenMaskDepth);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_childrenMaskDepth)) = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06002D76 RID: 11638 RVA: 0x000C2F74 File Offset: 0x000C1174
		// (set) Token: 0x06002D77 RID: 11639 RVA: 0x00012965 File Offset: 0x00010B65
		public unsafe bool disableNudging
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_disableNudging);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_disableNudging)) = value;
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06002D78 RID: 11640 RVA: 0x000C2F9C File Offset: 0x000C119C
		// (set) Token: 0x06002D79 RID: 11641 RVA: 0x00012980 File Offset: 0x00010B80
		public unsafe MeshHandle data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06002D7A RID: 11642 RVA: 0x000C2FCC File Offset: 0x000C11CC
		// (set) Token: 0x06002D7B RID: 11643 RVA: 0x0001299F File Offset: 0x00010B9F
		public unsafe MeshHandle closingData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_closingData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_closingData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x06002D7C RID: 11644 RVA: 0x000C2FFC File Offset: 0x000C11FC
		// (set) Token: 0x06002D7D RID: 11645 RVA: 0x000129BE File Offset: 0x00010BBE
		public unsafe Matrix4x4 verticesSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_verticesSpace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_verticesSpace)) = value;
			}
		}

		// Token: 0x17000E34 RID: 3636
		// (get) Token: 0x06002D7E RID: 11646 RVA: 0x000C3024 File Offset: 0x000C1224
		// (set) Token: 0x06002D7F RID: 11647 RVA: 0x000129D9 File Offset: 0x00010BD9
		public unsafe int displacementUVStart
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVStart)) = value;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06002D80 RID: 11648 RVA: 0x000C304C File Offset: 0x000C124C
		// (set) Token: 0x06002D81 RID: 11649 RVA: 0x000129F4 File Offset: 0x00010BF4
		public unsafe int displacementUVEnd
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_displacementUVEnd)) = value;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06002D82 RID: 11650 RVA: 0x000C3074 File Offset: 0x000C1274
		// (set) Token: 0x06002D83 RID: 11651 RVA: 0x00012A0F File Offset: 0x00010C0F
		public unsafe BMPAlloc transformID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_transformID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_transformID)) = value;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06002D84 RID: 11652 RVA: 0x000C309C File Offset: 0x000C129C
		// (set) Token: 0x06002D85 RID: 11653 RVA: 0x00012A2A File Offset: 0x00010C2A
		public unsafe BMPAlloc clipRectID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipRectID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_clipRectID)) = value;
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x06002D86 RID: 11654 RVA: 0x000C30C4 File Offset: 0x000C12C4
		// (set) Token: 0x06002D87 RID: 11655 RVA: 0x00012A45 File Offset: 0x00010C45
		public unsafe BMPAlloc opacityID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_opacityID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_opacityID)) = value;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x06002D88 RID: 11656 RVA: 0x000C30EC File Offset: 0x000C12EC
		// (set) Token: 0x06002D89 RID: 11657 RVA: 0x00012A60 File Offset: 0x00010C60
		public unsafe BMPAlloc textCoreSettingsID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textCoreSettingsID)) = value;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06002D8A RID: 11658 RVA: 0x000C3114 File Offset: 0x000C1314
		// (set) Token: 0x06002D8B RID: 11659 RVA: 0x00012A7B File Offset: 0x00010C7B
		public unsafe BMPAlloc colorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_colorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_colorID)) = value;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06002D8C RID: 11660 RVA: 0x000C313C File Offset: 0x000C133C
		// (set) Token: 0x06002D8D RID: 11661 RVA: 0x00012A96 File Offset: 0x00010C96
		public unsafe BMPAlloc backgroundColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_backgroundColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_backgroundColorID)) = value;
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x06002D8E RID: 11662 RVA: 0x000C3164 File Offset: 0x000C1364
		// (set) Token: 0x06002D8F RID: 11663 RVA: 0x00012AB1 File Offset: 0x00010CB1
		public unsafe BMPAlloc borderLeftColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderLeftColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderLeftColorID)) = value;
			}
		}

		// Token: 0x17000E3D RID: 3645
		// (get) Token: 0x06002D90 RID: 11664 RVA: 0x000C318C File Offset: 0x000C138C
		// (set) Token: 0x06002D91 RID: 11665 RVA: 0x00012ACC File Offset: 0x00010CCC
		public unsafe BMPAlloc borderTopColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderTopColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderTopColorID)) = value;
			}
		}

		// Token: 0x17000E3E RID: 3646
		// (get) Token: 0x06002D92 RID: 11666 RVA: 0x000C31B4 File Offset: 0x000C13B4
		// (set) Token: 0x06002D93 RID: 11667 RVA: 0x00012AE7 File Offset: 0x00010CE7
		public unsafe BMPAlloc borderRightColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderRightColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderRightColorID)) = value;
			}
		}

		// Token: 0x17000E3F RID: 3647
		// (get) Token: 0x06002D94 RID: 11668 RVA: 0x000C31DC File Offset: 0x000C13DC
		// (set) Token: 0x06002D95 RID: 11669 RVA: 0x00012B02 File Offset: 0x00010D02
		public unsafe BMPAlloc borderBottomColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderBottomColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_borderBottomColorID)) = value;
			}
		}

		// Token: 0x17000E40 RID: 3648
		// (get) Token: 0x06002D96 RID: 11670 RVA: 0x000C3204 File Offset: 0x000C1404
		// (set) Token: 0x06002D97 RID: 11671 RVA: 0x00012B1D File Offset: 0x00010D1D
		public unsafe BMPAlloc tintColorID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_tintColorID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_tintColorID)) = value;
			}
		}

		// Token: 0x17000E41 RID: 3649
		// (get) Token: 0x06002D98 RID: 11672 RVA: 0x000C322C File Offset: 0x000C142C
		// (set) Token: 0x06002D99 RID: 11673 RVA: 0x00012B38 File Offset: 0x00010D38
		public unsafe float compositeOpacity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_compositeOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_compositeOpacity)) = value;
			}
		}

		// Token: 0x17000E42 RID: 3650
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x000C3254 File Offset: 0x000C1454
		// (set) Token: 0x06002D9B RID: 11675 RVA: 0x00012B53 File Offset: 0x00010D53
		public unsafe Color backgroundColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_backgroundColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_backgroundColor)) = value;
			}
		}

		// Token: 0x17000E43 RID: 3651
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x000C327C File Offset: 0x000C147C
		// (set) Token: 0x06002D9D RID: 11677 RVA: 0x00012B6E File Offset: 0x00010D6E
		public unsafe BasicNode<TextureEntry> textures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BasicNode<TextureEntry>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RenderChainVEData.NativeFieldInfoPtr_textures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeFieldInfoPtr_prev;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeFieldInfoPtr_next;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeFieldInfoPtr_groupTransformAncestor;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeFieldInfoPtr_boneTransformAncestor;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeFieldInfoPtr_prevDirty;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeFieldInfoPtr_nextDirty;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeFieldInfoPtr_flags;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeFieldInfoPtr_hierarchyDepth;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeFieldInfoPtr_dirtiedValues;

		// Token: 0x040020B5 RID: 8373
		private static readonly IntPtr NativeFieldInfoPtr_dirtyID;

		// Token: 0x040020B6 RID: 8374
		private static readonly IntPtr NativeFieldInfoPtr_firstCommand;

		// Token: 0x040020B7 RID: 8375
		private static readonly IntPtr NativeFieldInfoPtr_lastCommand;

		// Token: 0x040020B8 RID: 8376
		private static readonly IntPtr NativeFieldInfoPtr_firstClosingCommand;

		// Token: 0x040020B9 RID: 8377
		private static readonly IntPtr NativeFieldInfoPtr_lastClosingCommand;

		// Token: 0x040020BA RID: 8378
		private static readonly IntPtr NativeFieldInfoPtr_isInChain;

		// Token: 0x040020BB RID: 8379
		private static readonly IntPtr NativeFieldInfoPtr_isHierarchyHidden;

		// Token: 0x040020BC RID: 8380
		private static readonly IntPtr NativeFieldInfoPtr_localFlipsWinding;

		// Token: 0x040020BD RID: 8381
		private static readonly IntPtr NativeFieldInfoPtr_localTransformScaleZero;

		// Token: 0x040020BE RID: 8382
		private static readonly IntPtr NativeFieldInfoPtr_worldFlipsWinding;

		// Token: 0x040020BF RID: 8383
		private static readonly IntPtr NativeFieldInfoPtr_worldTransformScaleZero;

		// Token: 0x040020C0 RID: 8384
		private static readonly IntPtr NativeFieldInfoPtr_clipMethod;

		// Token: 0x040020C1 RID: 8385
		private static readonly IntPtr NativeFieldInfoPtr_childrenStencilRef;

		// Token: 0x040020C2 RID: 8386
		private static readonly IntPtr NativeFieldInfoPtr_childrenMaskDepth;

		// Token: 0x040020C3 RID: 8387
		private static readonly IntPtr NativeFieldInfoPtr_disableNudging;

		// Token: 0x040020C4 RID: 8388
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x040020C5 RID: 8389
		private static readonly IntPtr NativeFieldInfoPtr_closingData;

		// Token: 0x040020C6 RID: 8390
		private static readonly IntPtr NativeFieldInfoPtr_verticesSpace;

		// Token: 0x040020C7 RID: 8391
		private static readonly IntPtr NativeFieldInfoPtr_displacementUVStart;

		// Token: 0x040020C8 RID: 8392
		private static readonly IntPtr NativeFieldInfoPtr_displacementUVEnd;

		// Token: 0x040020C9 RID: 8393
		private static readonly IntPtr NativeFieldInfoPtr_transformID;

		// Token: 0x040020CA RID: 8394
		private static readonly IntPtr NativeFieldInfoPtr_clipRectID;

		// Token: 0x040020CB RID: 8395
		private static readonly IntPtr NativeFieldInfoPtr_opacityID;

		// Token: 0x040020CC RID: 8396
		private static readonly IntPtr NativeFieldInfoPtr_textCoreSettingsID;

		// Token: 0x040020CD RID: 8397
		private static readonly IntPtr NativeFieldInfoPtr_colorID;

		// Token: 0x040020CE RID: 8398
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColorID;

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeFieldInfoPtr_borderLeftColorID;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr_borderTopColorID;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeFieldInfoPtr_borderRightColorID;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeFieldInfoPtr_borderBottomColorID;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeFieldInfoPtr_tintColorID;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeFieldInfoPtr_compositeOpacity;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeFieldInfoPtr_backgroundColor;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeFieldInfoPtr_textures;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_get_lastClosingOrLastCommand_Internal_get_RenderChainCommand_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_AllocatesID_Internal_Static_Boolean_BMPAlloc_0;

		// Token: 0x040020D9 RID: 8409
		private static readonly IntPtr NativeMethodInfoPtr_InheritsID_Internal_Static_Boolean_BMPAlloc_0;

		// Token: 0x040020DA RID: 8410
		private static readonly IntPtr NativeMethodInfoPtr_get_isIgnoringDynamicColorHint_Public_get_Boolean_0;
	}
}
