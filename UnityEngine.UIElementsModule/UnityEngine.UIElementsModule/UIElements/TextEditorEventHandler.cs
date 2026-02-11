using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000069 RID: 105
	public class TextEditorEventHandler : Object
	{
		// Token: 0x060009B3 RID: 2483 RVA: 0x0003F6A4 File Offset: 0x0003D8A4
		// Note: this type is marked as 'beforefieldinit'.
		static TextEditorEventHandler()
		{
			Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TextEditorEventHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr);
			TextEditorEventHandler.NativeFieldInfoPtr_textElement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr, "textElement");
			TextEditorEventHandler.NativeFieldInfoPtr_editingUtilities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr, "editingUtilities");
			TextEditorEventHandler.NativeMethodInfoPtr__ctor_Protected_Void_TextElement_TextEditingUtilities_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr, 100664670);
			TextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_New_Void_EventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr, 100664671);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x0003F724 File Offset: 0x0003D924
		[CallerCount(54)]
		[CachedScanResults(RefRangeStart = 296744, RefRangeEnd = 296798, XrefRangeStart = 296741, XrefRangeEnd = 296744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TextEditorEventHandler(TextElement textElement, TextEditingUtilities editingUtilities)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextEditorEventHandler>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(textElement);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(editingUtilities);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TextEditorEventHandler.NativeMethodInfoPtr__ctor_Protected_Void_TextElement_TextEditingUtilities_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x0003F784 File Offset: 0x0003D984
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void ExecuteDefaultActionAtTarget(EventBase evt)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(evt);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TextEditorEventHandler.NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_New_Void_EventBase_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x0000578C File Offset: 0x0000398C
		public TextEditorEventHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x0003F7D4 File Offset: 0x0003D9D4
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00005795 File Offset: 0x00003995
		public unsafe TextElement textElement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditorEventHandler.NativeFieldInfoPtr_textElement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextElement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditorEventHandler.NativeFieldInfoPtr_textElement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0003F804 File Offset: 0x0003DA04
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000057B4 File Offset: 0x000039B4
		public unsafe TextEditingUtilities editingUtilities
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditorEventHandler.NativeFieldInfoPtr_editingUtilities);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextEditingUtilities>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TextEditorEventHandler.NativeFieldInfoPtr_editingUtilities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040006C1 RID: 1729
		private static readonly IntPtr NativeFieldInfoPtr_textElement;

		// Token: 0x040006C2 RID: 1730
		private static readonly IntPtr NativeFieldInfoPtr_editingUtilities;

		// Token: 0x040006C3 RID: 1731
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_TextElement_TextEditingUtilities_0;

		// Token: 0x040006C4 RID: 1732
		private static readonly IntPtr NativeMethodInfoPtr_ExecuteDefaultActionAtTarget_Public_Virtual_New_Void_EventBase_0;
	}
}
