using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000133 RID: 307
	public class DebugUIHandlerProgressBar : DebugUIHandlerWidget
	{
		// Token: 0x060013EE RID: 5102 RVA: 0x00058C78 File Offset: 0x00056E78
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerProgressBar()
		{
			Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerProgressBar");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr);
			DebugUIHandlerProgressBar.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, "nameLabel");
			DebugUIHandlerProgressBar.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, "valueLabel");
			DebugUIHandlerProgressBar.NativeFieldInfoPtr_progressBarRect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, "progressBarRect");
			DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, "m_Value");
			DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, "m_Timer");
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666174);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666175);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666176);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666177);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666178);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr_UpdateValue_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666179);
			DebugUIHandlerProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr, 100666180);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00058D98 File Offset: 0x00056F98
		[CallerCount(0)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00058DD4 File Offset: 0x00056FD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981119, XrefRangeEnd = 981126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerProgressBar.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00058E24 File Offset: 0x00057024
		[CallerCount(0)]
		public unsafe override bool OnSelection(bool fromNext, DebugUIHandlerWidget previous)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fromNext;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(previous);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013F2 RID: 5106 RVA: 0x00058E8C File Offset: 0x0005708C
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerProgressBar.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F3 RID: 5107 RVA: 0x00058EC8 File Offset: 0x000570C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981126, XrefRangeEnd = 981128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerProgressBar.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F4 RID: 5108 RVA: 0x00058EFC File Offset: 0x000570FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 981135, RefRangeEnd = 981137, XrefRangeStart = 981128, XrefRangeEnd = 981135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerProgressBar.NativeMethodInfoPtr_UpdateValue_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00058F30 File Offset: 0x00057130
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerProgressBar()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerProgressBar>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerProgressBar.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013F6 RID: 5110 RVA: 0x0000A1DB File Offset: 0x000083DB
		public DebugUIHandlerProgressBar(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060013F7 RID: 5111 RVA: 0x00058F6C File Offset: 0x0005716C
		// (set) Token: 0x060013F8 RID: 5112 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060013F9 RID: 5113 RVA: 0x00058F9C File Offset: 0x0005719C
		// (set) Token: 0x060013FA RID: 5114 RVA: 0x0000A203 File Offset: 0x00008403
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x060013FB RID: 5115 RVA: 0x00058FCC File Offset: 0x000571CC
		// (set) Token: 0x060013FC RID: 5116 RVA: 0x0000A222 File Offset: 0x00008422
		public unsafe RectTransform progressBarRect
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_progressBarRect);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_progressBarRect), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x060013FD RID: 5117 RVA: 0x00058FFC File Offset: 0x000571FC
		// (set) Token: 0x060013FE RID: 5118 RVA: 0x0000A241 File Offset: 0x00008441
		public unsafe DebugUI.ProgressBarValue m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Value);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.ProgressBarValue>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Value), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x060013FF RID: 5119 RVA: 0x0005902C File Offset: 0x0005722C
		// (set) Token: 0x06001400 RID: 5120 RVA: 0x0000A260 File Offset: 0x00008460
		public unsafe float m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerProgressBar.NativeFieldInfoPtr_m_Timer)) = value;
			}
		}

		// Token: 0x04000EBE RID: 3774
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000EBF RID: 3775
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000EC0 RID: 3776
		private static readonly IntPtr NativeFieldInfoPtr_progressBarRect;

		// Token: 0x04000EC1 RID: 3777
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x04000EC2 RID: 3778
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04000EC3 RID: 3779
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000EC4 RID: 3780
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000EC5 RID: 3781
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000EC6 RID: 3782
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000EC7 RID: 3783
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000EC8 RID: 3784
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValue_Private_Void_0;

		// Token: 0x04000EC9 RID: 3785
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
