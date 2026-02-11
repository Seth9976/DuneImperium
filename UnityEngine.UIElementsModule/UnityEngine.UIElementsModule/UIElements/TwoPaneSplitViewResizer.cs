using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.UIElements
{
	// Token: 0x02000096 RID: 150
	public class TwoPaneSplitViewResizer : PointerManipulator
	{
		// Token: 0x06000F1D RID: 3869 RVA: 0x00052170 File Offset: 0x00050370
		// Note: this type is marked as 'beforefieldinit'.
		static TwoPaneSplitViewResizer()
		{
			Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TwoPaneSplitViewResizer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr);
			TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Start = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, "m_Start");
			TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, "m_Active");
			TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_SplitView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, "m_SplitView");
			TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Direction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, "m_Direction");
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_orientation_Private_get_TwoPaneSplitViewOrientation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665422);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPane_Private_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665423);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPane_Private_get_VisualElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665424);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPaneMinDimension_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665425);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPaneMargins_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665426);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPaneMinDimension_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665427);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPaneMargin_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665428);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr__ctor_Public_Void_TwoPaneSplitView_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665429);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665430);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665431);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_ApplyDelta_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665432);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerDown_Protected_Void_PointerDownEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665433);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerMove_Protected_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665434);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerUp_Protected_Void_PointerUpEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665435);
			TwoPaneSplitViewResizer.NativeMethodInfoPtr_InterruptPointerMove_Protected_Void_PointerMoveEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr, 100665436);
		}

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06000F1E RID: 3870 RVA: 0x0005231C File Offset: 0x0005051C
		public unsafe TwoPaneSplitViewOrientation orientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_orientation_Private_get_TwoPaneSplitViewOrientation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06000F1F RID: 3871 RVA: 0x00052358 File Offset: 0x00050558
		public unsafe VisualElement fixedPane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPane_Private_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06000F20 RID: 3872 RVA: 0x00052398 File Offset: 0x00050598
		public unsafe VisualElement flexedPane
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPane_Private_get_VisualElement_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<VisualElement>(intPtr3) : null;
			}
		}

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06000F21 RID: 3873 RVA: 0x000523D8 File Offset: 0x000505D8
		public unsafe float fixedPaneMinDimension
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307192, XrefRangeEnd = 307199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPaneMinDimension_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06000F22 RID: 3874 RVA: 0x00052414 File Offset: 0x00050614
		public unsafe float fixedPaneMargins
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 307211, RefRangeEnd = 307216, XrefRangeStart = 307199, XrefRangeEnd = 307211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_fixedPaneMargins_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06000F23 RID: 3875 RVA: 0x00052450 File Offset: 0x00050650
		public unsafe float flexedPaneMinDimension
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307223, RefRangeEnd = 307226, XrefRangeStart = 307216, XrefRangeEnd = 307223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPaneMinDimension_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06000F24 RID: 3876 RVA: 0x0005248C File Offset: 0x0005068C
		public unsafe float flexedPaneMargin
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 307238, RefRangeEnd = 307241, XrefRangeStart = 307226, XrefRangeEnd = 307238, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_get_flexedPaneMargin_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000524C8 File Offset: 0x000506C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307241, XrefRangeEnd = 307247, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TwoPaneSplitViewResizer(TwoPaneSplitView splitView, int dir)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TwoPaneSplitViewResizer>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(splitView);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dir;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr__ctor_Public_Void_TwoPaneSplitView_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00052524 File Offset: 0x00050724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307247, XrefRangeEnd = 307278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void RegisterCallbacksOnTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwoPaneSplitViewResizer.NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x00052560 File Offset: 0x00050760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307278, XrefRangeEnd = 307309, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void UnregisterCallbacksFromTarget()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TwoPaneSplitViewResizer.NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x0005259C File Offset: 0x0005079C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307309, XrefRangeEnd = 307414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDelta(float delta)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref delta;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_ApplyDelta_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x000525DC File Offset: 0x000507DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307414, XrefRangeEnd = 307420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerDown(PointerDownEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerDown_Protected_Void_PointerDownEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x00052620 File Offset: 0x00050820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307420, XrefRangeEnd = 307456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerMove(PointerMoveEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerMove_Protected_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x00052664 File Offset: 0x00050864
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307456, XrefRangeEnd = 307463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPointerUp(PointerUpEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_OnPointerUp_Protected_Void_PointerUpEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000526A8 File Offset: 0x000508A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 307463, XrefRangeEnd = 307468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InterruptPointerMove(PointerMoveEvent e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TwoPaneSplitViewResizer.NativeMethodInfoPtr_InterruptPointerMove_Protected_Void_PointerMoveEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00007BBC File Offset: 0x00005DBC
		public TwoPaneSplitViewResizer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000526EC File Offset: 0x000508EC
		// (set) Token: 0x06000F2F RID: 3887 RVA: 0x00007BC5 File Offset: 0x00005DC5
		public unsafe Vector3 m_Start
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Start);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Start)) = value;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x00052714 File Offset: 0x00050914
		// (set) Token: 0x06000F31 RID: 3889 RVA: 0x00007BE0 File Offset: 0x00005DE0
		public unsafe bool m_Active
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Active);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Active)) = value;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06000F32 RID: 3890 RVA: 0x0005273C File Offset: 0x0005093C
		// (set) Token: 0x06000F33 RID: 3891 RVA: 0x00007BFB File Offset: 0x00005DFB
		public unsafe TwoPaneSplitView m_SplitView
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_SplitView);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TwoPaneSplitView>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_SplitView), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x0005276C File Offset: 0x0005096C
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x00007C1A File Offset: 0x00005E1A
		public unsafe int m_Direction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Direction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TwoPaneSplitViewResizer.NativeFieldInfoPtr_m_Direction)) = value;
			}
		}

		// Token: 0x04000A76 RID: 2678
		private static readonly IntPtr NativeFieldInfoPtr_m_Start;

		// Token: 0x04000A77 RID: 2679
		private static readonly IntPtr NativeFieldInfoPtr_m_Active;

		// Token: 0x04000A78 RID: 2680
		private static readonly IntPtr NativeFieldInfoPtr_m_SplitView;

		// Token: 0x04000A79 RID: 2681
		private static readonly IntPtr NativeFieldInfoPtr_m_Direction;

		// Token: 0x04000A7A RID: 2682
		private static readonly IntPtr NativeMethodInfoPtr_get_orientation_Private_get_TwoPaneSplitViewOrientation_0;

		// Token: 0x04000A7B RID: 2683
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPane_Private_get_VisualElement_0;

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeMethodInfoPtr_get_flexedPane_Private_get_VisualElement_0;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPaneMinDimension_Private_get_Single_0;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr_get_fixedPaneMargins_Private_get_Single_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_get_flexedPaneMinDimension_Private_get_Single_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_flexedPaneMargin_Private_get_Single_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_TwoPaneSplitView_Int32_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_RegisterCallbacksOnTarget_Protected_Virtual_Void_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterCallbacksFromTarget_Protected_Virtual_Void_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_ApplyDelta_Public_Void_Single_0;

		// Token: 0x04000A85 RID: 2693
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerDown_Protected_Void_PointerDownEvent_0;

		// Token: 0x04000A86 RID: 2694
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerMove_Protected_Void_PointerMoveEvent_0;

		// Token: 0x04000A87 RID: 2695
		private static readonly IntPtr NativeMethodInfoPtr_OnPointerUp_Protected_Void_PointerUpEvent_0;

		// Token: 0x04000A88 RID: 2696
		private static readonly IntPtr NativeMethodInfoPtr_InterruptPointerMove_Protected_Void_PointerMoveEvent_0;

		// Token: 0x04000A89 RID: 2697
		public const float k_DragLineTolerance = 1f;
	}
}
