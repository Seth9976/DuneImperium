using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200012E RID: 302
	public class DebugUIHandlerObject : DebugUIHandlerWidget
	{
		// Token: 0x060013A2 RID: 5026 RVA: 0x00057C48 File Offset: 0x00055E48
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUIHandlerObject()
		{
			Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "DebugUIHandlerObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr);
			DebugUIHandlerObject.NativeFieldInfoPtr_nameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, "nameLabel");
			DebugUIHandlerObject.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, "valueLabel");
			DebugUIHandlerObject.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, 100666138);
			DebugUIHandlerObject.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, 100666139);
			DebugUIHandlerObject.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, 100666140);
			DebugUIHandlerObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr, 100666141);
		}

		// Token: 0x060013A3 RID: 5027 RVA: 0x00057CF0 File Offset: 0x00055EF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 980882, XrefRangeEnd = 980891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetWidget(DebugUI.Widget widget)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(widget);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerObject.NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x00057D40 File Offset: 0x00055F40
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerObject.NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x00057DA8 File Offset: 0x00055FA8
		[CallerCount(0)]
		public unsafe override void OnDeselection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DebugUIHandlerObject.NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x00057DE4 File Offset: 0x00055FE4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 979810, RefRangeEnd = 979814, XrefRangeStart = 979810, XrefRangeEnd = 979814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUIHandlerObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUIHandlerObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUIHandlerObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013A7 RID: 5031 RVA: 0x00009FA7 File Offset: 0x000081A7
		public DebugUIHandlerObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x00057E20 File Offset: 0x00056020
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x00009FB0 File Offset: 0x000081B0
		public unsafe Text nameLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerObject.NativeFieldInfoPtr_nameLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerObject.NativeFieldInfoPtr_nameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x00057E50 File Offset: 0x00056050
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x00009FCF File Offset: 0x000081CF
		public unsafe Text valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerObject.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUIHandlerObject.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000E8D RID: 3725
		private static readonly IntPtr NativeFieldInfoPtr_nameLabel;

		// Token: 0x04000E8E RID: 3726
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x04000E8F RID: 3727
		private static readonly IntPtr NativeMethodInfoPtr_SetWidget_Internal_Virtual_Void_Widget_0;

		// Token: 0x04000E90 RID: 3728
		private static readonly IntPtr NativeMethodInfoPtr_OnSelection_Public_Virtual_Boolean_Boolean_DebugUIHandlerWidget_0;

		// Token: 0x04000E91 RID: 3729
		private static readonly IntPtr NativeMethodInfoPtr_OnDeselection_Public_Virtual_Void_0;

		// Token: 0x04000E92 RID: 3730
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
