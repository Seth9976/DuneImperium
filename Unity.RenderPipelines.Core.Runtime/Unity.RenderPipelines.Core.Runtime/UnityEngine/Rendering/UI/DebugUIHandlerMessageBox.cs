using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200012D RID: 301
	public class DebugUIHandlerMessageBox : DebugUIHandlerWidget
	{
		// Token: 0x06001391 RID: 5009 RVA: 0x000579A0 File Offset: 0x00055BA0
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerMessageBox()
		{
			Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerMessageBox");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr);
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "nameLabel");
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_m_Field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "m_Field");
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "k_WarningBackgroundColor");
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "k_WarningTextColor");
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorBackgroundColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "k_ErrorBackgroundColor");
			DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorTextColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, "k_ErrorTextColor");
			DebugUIHandlerMessageBox.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, 100666134);
			DebugUIHandlerMessageBox.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, 100666135);
			DebugUIHandlerMessageBox.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr, 100666136);
		}

		// Token: 0x06001392 RID: 5010 RVA: 0x00057A84 File Offset: 0x00055C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980870, XrefRangeEnd = 980882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerMessageBox.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001393 RID: 5011 RVA: 0x00057AD4 File Offset: 0x00055CD4
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerMessageBox.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001394 RID: 5012 RVA: 0x00057B3C File Offset: 0x00055D3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerMessageBox()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerMessageBox>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerMessageBox.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001395 RID: 5013 RVA: 0x00009F28 File Offset: 0x00008128
		public DebugUIHandlerMessageBox(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x00057B78 File Offset: 0x00055D78
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x00009F31 File Offset: 0x00008131
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerMessageBox.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerMessageBox.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x00057BA8 File Offset: 0x00055DA8
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x00009F50 File Offset: 0x00008150
		public unsafe DebugUI.MessageBox m_Field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerMessageBox.NativeFieldInfoPtr_m_Field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUI.MessageBox>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerMessageBox.NativeFieldInfoPtr_m_Field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x00057BD8 File Offset: 0x00055DD8
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x00009F6F File Offset: 0x0000816F
		public unsafe static Color32 k_WarningBackgroundColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningBackgroundColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningBackgroundColor, (void*)(&value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x0600139C RID: 5020 RVA: 0x00057BF4 File Offset: 0x00055DF4
		// (set) Token: 0x0600139D RID: 5021 RVA: 0x00009F7D File Offset: 0x0000817D
		public unsafe static Color32 k_WarningTextColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningTextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_WarningTextColor, (void*)(&value));
			}
		}

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x0600139E RID: 5022 RVA: 0x00057C10 File Offset: 0x00055E10
		// (set) Token: 0x0600139F RID: 5023 RVA: 0x00009F8B File Offset: 0x0000818B
		public unsafe static Color32 k_ErrorBackgroundColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorBackgroundColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorBackgroundColor, (void*)(&value));
			}
		}

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x060013A0 RID: 5024 RVA: 0x00057C2C File Offset: 0x00055E2C
		// (set) Token: 0x060013A1 RID: 5025 RVA: 0x00009F99 File Offset: 0x00008199
		public unsafe static Color32 k_ErrorTextColor
		{
			get
			{
				Color32 color;
				IL2CPP.il2cpp_field_static_get_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorTextColor, (void*)(&color));
				return color;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUIHandlerMessageBox.NativeFieldInfoPtr_k_ErrorTextColor, (void*)(&value));
			}
		}

		// Token: 0x04000E84 RID: 3716
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000E85 RID: 3717
		private static readonly IntPtr NativeFieldInfoPtr_m_Field;

		// Token: 0x04000E86 RID: 3718
		private static readonly IntPtr NativeFieldInfoPtr_k_WarningBackgroundColor;

		// Token: 0x04000E87 RID: 3719
		private static readonly IntPtr NativeFieldInfoPtr_k_WarningTextColor;

		// Token: 0x04000E88 RID: 3720
		private static readonly IntPtr NativeFieldInfoPtr_k_ErrorBackgroundColor;

		// Token: 0x04000E89 RID: 3721
		private static readonly IntPtr NativeFieldInfoPtr_k_ErrorTextColor;

		// Token: 0x04000E8A RID: 3722
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000E8B RID: 3723
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E8C RID: 3724
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
