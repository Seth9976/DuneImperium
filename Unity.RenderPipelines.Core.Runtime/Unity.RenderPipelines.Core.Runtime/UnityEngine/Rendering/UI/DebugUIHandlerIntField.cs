using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200012C RID: 300
	public class DebugUIHandlerIntField : DebugUIHandlerWidget
	{
		// Token: 0x06001381 RID: 4993 RVA: 0x000575BC File Offset: 0x000557BC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerIntField()
		{
			Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerIntField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr);
			DebugUIHandlerIntField.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, "nameLabel");
			DebugUIHandlerIntField.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, "valueLabel");
			DebugUIHandlerIntField.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, "m_Field");
			DebugUIHandlerIntField.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666126);
			DebugUIHandlerIntField.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666127);
			DebugUIHandlerIntField.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666128);
			DebugUIHandlerIntField.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666129);
			DebugUIHandlerIntField.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666130);
			DebugUIHandlerIntField.NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666131);
			DebugUIHandlerIntField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666132);
			DebugUIHandlerIntField.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr, 100666133);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x000576C8 File Offset: 0x000558C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980841, XrefRangeEnd = 980848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIntField.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x00057718 File Offset: 0x00055918
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIntField.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001384 RID: 4996 RVA: 0x00057780 File Offset: 0x00055980
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIntField.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x000577BC File Offset: 0x000559BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980848, XrefRangeEnd = 980849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnIncrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIntField.NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001386 RID: 4998 RVA: 0x00057808 File Offset: 0x00055A08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980849, XrefRangeEnd = 980850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDecrement(bool fast)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIntField.NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001387 RID: 4999 RVA: 0x00057854 File Offset: 0x00055A54
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980856, RefRangeEnd = 980858, XrefRangeStart = 980850, XrefRangeEnd = 980856, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ChangeValue(bool fast, int multiplier)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref fast;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref multiplier;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIntField.NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001388 RID: 5000 RVA: 0x000578A0 File Offset: 0x00055AA0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 980868, RefRangeEnd = 980870, XrefRangeStart = 980858, XrefRangeEnd = 980868, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIntField.NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x000578D4 File Offset: 0x00055AD4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerIntField()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerIntField>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIntField.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x00009EC2 File Offset: 0x000080C2
		public DebugUIHandlerIntField(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x0600138B RID: 5003 RVA: 0x00057910 File Offset: 0x00055B10
		// (set) Token: 0x0600138C RID: 5004 RVA: 0x00009ECB File Offset: 0x000080CB
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x0600138D RID: 5005 RVA: 0x00057940 File Offset: 0x00055B40
		// (set) Token: 0x0600138E RID: 5006 RVA: 0x00009EEA File Offset: 0x000080EA
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x0600138F RID: 5007 RVA: 0x00057970 File Offset: 0x00055B70
		// (set) Token: 0x06001390 RID: 5008 RVA: 0x00009F09 File Offset: 0x00008109
		public unsafe DebugUI.IntField m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.IntField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIntField.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E79 RID: 3705
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000E7A RID: 3706
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000E7B RID: 3707
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04000E7C RID: 3708
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000E7D RID: 3709
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E7E RID: 3710
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000E7F RID: 3711
		private static readonly IntPtr NativeMethodInfoPtr_OnIncrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000E80 RID: 3712
		private static readonly IntPtr NativeMethodInfoPtr_OnDecrement_Public_Virtual_Void_Boolean_0;

		// Token: 0x04000E81 RID: 3713
		private static readonly IntPtr NativeMethodInfoPtr_ChangeValue_Private_Void_Boolean_Int32_0;

		// Token: 0x04000E82 RID: 3714
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_Private_Void_0;

		// Token: 0x04000E83 RID: 3715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
