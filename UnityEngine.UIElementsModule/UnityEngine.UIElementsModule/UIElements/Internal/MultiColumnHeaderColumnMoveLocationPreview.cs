using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AB RID: 683
	public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
	{
		// Token: 0x0600327A RID: 12922 RVA: 0x000D5B1C File Offset: 0x000D3D1C
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnMoveLocationPreview()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnMoveLocationPreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr);
			MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_visualUssClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr, "visualUssClassName");
			MultiColumnHeaderColumnMoveLocationPreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr, 100670631);
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x000D5B88 File Offset: 0x000D3D88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359846, XrefRangeEnd = 359875, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnMoveLocationPreview()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnMoveLocationPreview>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnMoveLocationPreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600327C RID: 12924 RVA: 0x00014677 File Offset: 0x00012877
		public MultiColumnHeaderColumnMoveLocationPreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FCF RID: 4047
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000D5BC4 File Offset: 0x000D3DC4
		// (set) Token: 0x0600327E RID: 12926 RVA: 0x00014680 File Offset: 0x00012880
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FD0 RID: 4048
		// (get) Token: 0x0600327F RID: 12927 RVA: 0x000D5BE4 File Offset: 0x000D3DE4
		// (set) Token: 0x06003280 RID: 12928 RVA: 0x00014692 File Offset: 0x00012892
		public unsafe static string visualUssClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_visualUssClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnMoveLocationPreview.NativeFieldInfoPtr_visualUssClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002507 RID: 9479
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04002508 RID: 9480
		private static readonly IntPtr NativeFieldInfoPtr_visualUssClassName;

		// Token: 0x04002509 RID: 9481
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
