using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine.UI;

namespace UnityEngine.Rendering.UI
{
	// Token: 0x0200013F RID: 319
	public class UIFoldout : Toggle
	{
		// Token: 0x060014F0 RID: 5360 RVA: 0x0005C870 File Offset: 0x0005AA70
		// Note: this type is marked as 'beforefieldinit'.
		static UIFoldout()
		{
			Il2CppClassPointerStore<UIFoldout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering.UI", "UIFoldout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr);
			UIFoldout.NativeFieldInfoPtr_content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, "content");
			UIFoldout.NativeFieldInfoPtr_arrowOpened = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, "arrowOpened");
			UIFoldout.NativeFieldInfoPtr_arrowClosed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, "arrowClosed");
			UIFoldout.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, 100666306);
			UIFoldout.NativeMethodInfoPtr_OnValidate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, 100666307);
			UIFoldout.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, 100666308);
			UIFoldout.NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, 100666309);
			UIFoldout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr, 100666310);
		}

		// Token: 0x060014F1 RID: 5361 RVA: 0x0005C940 File Offset: 0x0005AB40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981953, XrefRangeEnd = 981965, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UIFoldout.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F2 RID: 5362 RVA: 0x0005C97C File Offset: 0x0005AB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981965, XrefRangeEnd = 981966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFoldout.NativeMethodInfoPtr_OnValidate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F3 RID: 5363 RVA: 0x0005C9B0 File Offset: 0x0005ABB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 981966, XrefRangeEnd = 981967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFoldout.NativeMethodInfoPtr_SetState_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0005C9F0 File Offset: 0x0005ABF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 981991, RefRangeEnd = 981994, XrefRangeStart = 981967, XrefRangeEnd = 981991, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetState(bool state, bool rebuildLayout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref state;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rebuildLayout;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFoldout.NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0005CA3C File Offset: 0x0005AC3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UIFoldout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UIFoldout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UIFoldout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x0000A894 File Offset: 0x00008A94
		public UIFoldout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170005DC RID: 1500
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x0005CA78 File Offset: 0x0005AC78
		// (set) Token: 0x060014F8 RID: 5368 RVA: 0x0000A89D File Offset: 0x00008A9D
		public unsafe GameObject content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DD RID: 1501
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x0005CAA8 File Offset: 0x0005ACA8
		// (set) Token: 0x060014FA RID: 5370 RVA: 0x0000A8BC File Offset: 0x00008ABC
		public unsafe GameObject arrowOpened
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_arrowOpened);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_arrowOpened), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170005DE RID: 1502
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0005CAD8 File Offset: 0x0005ACD8
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0000A8DB File Offset: 0x00008ADB
		public unsafe GameObject arrowClosed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_arrowClosed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UIFoldout.NativeFieldInfoPtr_arrowClosed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000F71 RID: 3953
		private static readonly IntPtr NativeFieldInfoPtr_content;

		// Token: 0x04000F72 RID: 3954
		private static readonly IntPtr NativeFieldInfoPtr_arrowOpened;

		// Token: 0x04000F73 RID: 3955
		private static readonly IntPtr NativeFieldInfoPtr_arrowClosed;

		// Token: 0x04000F74 RID: 3956
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000F75 RID: 3957
		private static readonly IntPtr NativeMethodInfoPtr_OnValidate_Private_Void_0;

		// Token: 0x04000F76 RID: 3958
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_0;

		// Token: 0x04000F77 RID: 3959
		private static readonly IntPtr NativeMethodInfoPtr_SetState_Public_Void_Boolean_Boolean_0;

		// Token: 0x04000F78 RID: 3960
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
