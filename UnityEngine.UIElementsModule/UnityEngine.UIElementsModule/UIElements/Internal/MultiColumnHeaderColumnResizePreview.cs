using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AD RID: 685
	public class MultiColumnHeaderColumnResizePreview : VisualElement
	{
		// Token: 0x060032C4 RID: 12996 RVA: 0x000D6B78 File Offset: 0x000D4D78
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnResizePreview()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnResizePreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr);
			MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_visualUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr, "visualUssClassName");
			MultiColumnHeaderColumnResizePreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr, 100670666);
		}

		// Token: 0x060032C5 RID: 12997 RVA: 0x000D6BE4 File Offset: 0x000D4DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 360344, XrefRangeEnd = 360387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnResizePreview()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnResizePreview>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnResizePreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060032C6 RID: 12998 RVA: 0x0001487D File Offset: 0x00012A7D
		public MultiColumnHeaderColumnResizePreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060032C7 RID: 12999 RVA: 0x000D6C20 File Offset: 0x000D4E20
		// (set) Token: 0x060032C8 RID: 13000 RVA: 0x00014886 File Offset: 0x00012A86
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE5 RID: 4069
		// (get) Token: 0x060032C9 RID: 13001 RVA: 0x000D6C40 File Offset: 0x000D4E40
		// (set) Token: 0x060032CA RID: 13002 RVA: 0x00014898 File Offset: 0x00012A98
		public unsafe static string visualUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_visualUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnResizePreview.NativeFieldInfoPtr_visualUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400253C RID: 9532
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeFieldInfoPtr_visualUssClassName;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
