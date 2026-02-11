using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200012B RID: 299
	public class DebugUIHandlerIndirectToggle : DebugUIHandlerWidget
	{
		// Token: 0x0600136C RID: 4972 RVA: 0x000571AC File Offset: 0x000553AC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerIndirectToggle()
		{
			Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerIndirectToggle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr);
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "nameLabel");
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_valueToggle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "valueToggle");
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_checkmarkImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "checkmarkImage");
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "getter");
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "setter");
			DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, "index");
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666119);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666120);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666121);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666122);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666123);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_UpdateValueLabel_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666124);
			DebugUIHandlerIndirectToggle.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr, 100666125);
		}

		// Token: 0x0600136D RID: 4973 RVA: 0x000572E0 File Offset: 0x000554E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 980829, RefRangeEnd = 980830, XrefRangeStart = 980818, XrefRangeEnd = 980829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x00057314 File Offset: 0x00055514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980830, XrefRangeEnd = 980831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleValueChanged(bool value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600136F RID: 4975 RVA: 0x00057354 File Offset: 0x00055554
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000573BC File Offset: 0x000555BC
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000573F8 File Offset: 0x000555F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980831, XrefRangeEnd = 980833, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnAction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x00057434 File Offset: 0x00055634
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 980838, RefRangeEnd = 980841, XrefRangeStart = 980833, XrefRangeEnd = 980838, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateValueLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectToggle.NativeMethodInfoPtr_UpdateValueLabel_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x00057468 File Offset: 0x00055668
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerIndirectToggle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerIndirectToggle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerIndirectToggle.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001374 RID: 4980 RVA: 0x00009E03 File Offset: 0x00008003
		public DebugUIHandlerIndirectToggle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06001375 RID: 4981 RVA: 0x000574A4 File Offset: 0x000556A4
		// (set) Token: 0x06001376 RID: 4982 RVA: 0x00009E0C File Offset: 0x0000800C
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06001377 RID: 4983 RVA: 0x000574D4 File Offset: 0x000556D4
		// (set) Token: 0x06001378 RID: 4984 RVA: 0x00009E2B File Offset: 0x0000802B
		public unsafe Toggle valueToggle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_valueToggle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Toggle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_valueToggle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06001379 RID: 4985 RVA: 0x00057504 File Offset: 0x00055704
		// (set) Token: 0x0600137A RID: 4986 RVA: 0x00009E4A File Offset: 0x0000804A
		public unsafe Image checkmarkImage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_checkmarkImage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_checkmarkImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600137B RID: 4987 RVA: 0x00057534 File Offset: 0x00055734
		// (set) Token: 0x0600137C RID: 4988 RVA: 0x00009E69 File Offset: 0x00008069
		public unsafe Func<int, bool> getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600137D RID: 4989 RVA: 0x00057564 File Offset: 0x00055764
		// (set) Token: 0x0600137E RID: 4990 RVA: 0x00009E88 File Offset: 0x00008088
		public unsafe Action<int, bool> setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<int, bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x0600137F RID: 4991 RVA: 0x00057594 File Offset: 0x00055794
		// (set) Token: 0x06001380 RID: 4992 RVA: 0x00009EA7 File Offset: 0x000080A7
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerIndirectToggle.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x04000E6C RID: 3692
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000E6D RID: 3693
		private static readonly IntPtr NativeFieldInfoPtr_valueToggle;

		// Token: 0x04000E6E RID: 3694
		private static readonly IntPtr NativeFieldInfoPtr_checkmarkImage;

		// Token: 0x04000E6F RID: 3695
		private static readonly IntPtr NativeFieldInfoPtr_getter;

		// Token: 0x04000E70 RID: 3696
		private static readonly IntPtr NativeFieldInfoPtr_setter;

		// Token: 0x04000E71 RID: 3697
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x04000E72 RID: 3698
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

		// Token: 0x04000E73 RID: 3699
		private static readonly IntPtr NativeMethodInfoPtr_OnToggleValueChanged_Private_Void_Boolean_0;

		// Token: 0x04000E74 RID: 3700
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E75 RID: 3701
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000E76 RID: 3702
		private static readonly IntPtr NativeMethodInfoPtr_OnAction_Public_Virtual_Void_0;

		// Token: 0x04000E77 RID: 3703
		private static readonly IntPtr NativeMethodInfoPtr_UpdateValueLabel_Internal_Void_0;

		// Token: 0x04000E78 RID: 3704
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
