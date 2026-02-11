using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x02000139 RID: 313
	public class DebugUIHandlerValueTuple : DebugUIHandlerWidget
	{
		// Token: 0x06001448 RID: 5192 RVA: 0x0005A020 File Offset: 0x00058220
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerValueTuple()
		{
			Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerValueTuple");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr);
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "nameLabel");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "valueLabel");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "m_Field");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueElements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "valueElements");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_XOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "k_XOffset");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "m_Timer");
			DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_ZeroColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, "k_ZeroColor");
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666219);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666220);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666221);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666222);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_UpdateValueLabels_Internal_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666223);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666224);
			DebugUIHandlerValueTuple.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr, 100666225);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005A168 File Offset: 0x00058368
		[CallerCount(0)]
		public unsafe override void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005A1A4 File Offset: 0x000583A4
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005A20C File Offset: 0x0005840C
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValueTuple.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005A248 File Offset: 0x00058448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981446, XrefRangeEnd = 981484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValueTuple.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0005A298 File Offset: 0x00058498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981484, XrefRangeEnd = 981498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateValueLabels()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerValueTuple.NativeMethodInfoPtr_UpdateValueLabels_Internal_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0005A2D4 File Offset: 0x000584D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981498, XrefRangeEnd = 981501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerValueTuple.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x0005A308 File Offset: 0x00058508
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerValueTuple()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerValueTuple>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerValueTuple.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x0000A44F File Offset: 0x0000864F
		public DebugUIHandlerValueTuple(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06001451 RID: 5201 RVA: 0x0005A344 File Offset: 0x00058544
		// (set) Token: 0x06001452 RID: 5202 RVA: 0x0000A458 File Offset: 0x00008658
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06001453 RID: 5203 RVA: 0x0005A374 File Offset: 0x00058574
		// (set) Token: 0x06001454 RID: 5204 RVA: 0x0000A477 File Offset: 0x00008677
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06001455 RID: 5205 RVA: 0x0005A3A4 File Offset: 0x000585A4
		// (set) Token: 0x06001456 RID: 5206 RVA: 0x0000A496 File Offset: 0x00008696
		public unsafe DebugUI.ValueTuple m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.ValueTuple>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06001457 RID: 5207 RVA: 0x0005A3D4 File Offset: 0x000585D4
		// (set) Token: 0x06001458 RID: 5208 RVA: 0x0000A4B5 File Offset: 0x000086B5
		public unsafe Il2CppReferenceArray<Text> valueElements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueElements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Text>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_valueElements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06001459 RID: 5209 RVA: 0x0005A404 File Offset: 0x00058604
		// (set) Token: 0x0600145A RID: 5210 RVA: 0x0000A4D4 File Offset: 0x000086D4
		public unsafe static float k_XOffset
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_XOffset, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_XOffset, (void*)(&value));
			}
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x0600145B RID: 5211 RVA: 0x0005A420 File Offset: 0x00058620
		// (set) Token: 0x0600145C RID: 5212 RVA: 0x0000A4E2 File Offset: 0x000086E2
		public unsafe float m_Timer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Timer);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerValueTuple.NativeFieldInfoPtr_m_Timer)) = value;
			}
		}

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x0600145D RID: 5213 RVA: 0x0005A448 File Offset: 0x00058648
		// (set) Token: 0x0600145E RID: 5214 RVA: 0x0000A4FD File Offset: 0x000086FD
		public unsafe static Color k_ZeroColor
		{
			get
			{
				Color color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_ZeroColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerValueTuple.NativeFieldInfoPtr_k_ZeroColor, (void*)(&value));
			}
		}

		// Token: 0x04000EF8 RID: 3832
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000EF9 RID: 3833
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000EFA RID: 3834
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04000EFB RID: 3835
		private static readonly IntPtr NativeFieldInfoPtr_valueElements;

		// Token: 0x04000EFC RID: 3836
		private static readonly IntPtr NativeFieldInfoPtr_k_XOffset;

		// Token: 0x04000EFD RID: 3837
		private static readonly IntPtr NativeFieldInfoPtr_m_Timer;

		// Token: 0x04000EFE RID: 3838
		private static readonly IntPtr NativeFieldInfoPtr_k_ZeroColor;

		// Token: 0x04000EFF RID: 3839
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_Void_0;

		// Token: 0x04000F00 RID: 3840
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000F01 RID: 3841
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000F02 RID: 3842
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000F03 RID: 3843
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabels_Internal_Virtual_New_Void_0;

		// Token: 0x04000F04 RID: 3844
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000F05 RID: 3845
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
