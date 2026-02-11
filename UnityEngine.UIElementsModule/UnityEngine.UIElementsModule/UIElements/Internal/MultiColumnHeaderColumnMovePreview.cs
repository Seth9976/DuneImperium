using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UIElements.Internal
{
	// Token: 0x020002AA RID: 682
	public class MultiColumnHeaderColumnMovePreview : VisualElement
	{
		// Token: 0x06003275 RID: 12917 RVA: 0x000D5A68 File Offset: 0x000D3C68
		// Note: this type is marked as 'beforefieldinit'.
		static MultiColumnHeaderColumnMovePreview()
		{
			Il2CppClassPointerStore<MultiColumnHeaderColumnMovePreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.Internal", "MultiColumnHeaderColumnMovePreview");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MultiColumnHeaderColumnMovePreview>.NativeClassPtr);
			MultiColumnHeaderColumnMovePreview.NativeFieldInfoPtr_ussClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MultiColumnHeaderColumnMovePreview>.NativeClassPtr, "ussClassName");
			MultiColumnHeaderColumnMovePreview.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MultiColumnHeaderColumnMovePreview>.NativeClassPtr, 100670629);
		}

		// Token: 0x06003276 RID: 12918 RVA: 0x000D5AC0 File Offset: 0x000D3CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 359818, XrefRangeEnd = 359846, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MultiColumnHeaderColumnMovePreview()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MultiColumnHeaderColumnMovePreview>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MultiColumnHeaderColumnMovePreview.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003277 RID: 12919 RVA: 0x0001465C File Offset: 0x0001285C
		public MultiColumnHeaderColumnMovePreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FCE RID: 4046
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000D5AFC File Offset: 0x000D3CFC
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x00014665 File Offset: 0x00012865
		public unsafe static string ussClassName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(MultiColumnHeaderColumnMovePreview.NativeFieldInfoPtr_ussClassName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MultiColumnHeaderColumnMovePreview.NativeFieldInfoPtr_ussClassName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04002505 RID: 9477
		private static readonly IntPtr NativeFieldInfoPtr_ussClassName;

		// Token: 0x04002506 RID: 9478
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
