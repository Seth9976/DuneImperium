using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000138 RID: 312
	public class DebugUIHandlerValue : DebugUIHandlerWidget
	{
		// Token: 0x06001436 RID: 5174 RVA: 0x00059CA0 File Offset: 0x00057EA0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerValue()
		{
			Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerValue");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr);
			DebugUIHandlerValue.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, "nameLabel");
			DebugUIHandlerValue.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, "valueLabel");
			DebugUIHandlerValue.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, "m_Field");
			DebugUIHandlerValue.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, "m_Timer");
			DebugUIHandlerValue.NativeFieldInfoPtr_k_ZeroColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, "k_ZeroColor");
			DebugUIHandlerValue.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666212);
			DebugUIHandlerValue.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666213);
			DebugUIHandlerValue.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666214);
			DebugUIHandlerValue.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666215);
			DebugUIHandlerValue.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666216);
			DebugUIHandlerValue.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr, 100666217);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00059DAC File Offset: 0x00057FAC
		[CallerCount(0)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValue.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00059DE8 File Offset: 0x00057FE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981431, XrefRangeEnd = 981437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValue.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00059E38 File Offset: 0x00058038
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValue.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00059EA0 File Offset: 0x000580A0
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValue.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00059EDC File Offset: 0x000580DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981437, XrefRangeEnd = 981446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerValue.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00059F10 File Offset: 0x00058110
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerValue()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerValue>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerValue.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0000A3C0 File Offset: 0x000085C0
		public DebugUIHandlerValue(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x0600143E RID: 5182 RVA: 0x00059F4C File Offset: 0x0005814C
		// (set) Token: 0x0600143F RID: 5183 RVA: 0x0000A3C9 File Offset: 0x000085C9
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06001440 RID: 5184 RVA: 0x00059F7C File Offset: 0x0005817C
		// (set) Token: 0x06001441 RID: 5185 RVA: 0x0000A3E8 File Offset: 0x000085E8
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06001442 RID: 5186 RVA: 0x00059FAC File Offset: 0x000581AC
		// (set) Token: 0x06001443 RID: 5187 RVA: 0x0000A407 File Offset: 0x00008607
		public unsafe DebugUI.Value m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.Value>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06001444 RID: 5188 RVA: 0x00059FDC File Offset: 0x000581DC
		// (set) Token: 0x06001445 RID: 5189 RVA: 0x0000A426 File Offset: 0x00008626
		public unsafe float m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_m_Timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValue.NativeFieldInfoPtr_m_Timer)) = value;
			}
		}

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0005A004 File Offset: 0x00058204
		// (set) Token: 0x06001447 RID: 5191 RVA: 0x0000A441 File Offset: 0x00008641
		public unsafe static Color k_ZeroColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerValue.NativeFieldInfoPtr_k_ZeroColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerValue.NativeFieldInfoPtr_k_ZeroColor, (void*)(&value));
			}
		}

		// Token: 0x04000EED RID: 3821
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000EEE RID: 3822
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000EEF RID: 3823
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04000EF0 RID: 3824
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04000EF1 RID: 3825
		private static readonly IntPtr NativeFieldInfoPtr_k_ZeroColor;

		// Token: 0x04000EF2 RID: 3826
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000EF3 RID: 3827
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000EF4 RID: 3828
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000EF5 RID: 3829
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000EF6 RID: 3830
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000EF7 RID: 3831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
