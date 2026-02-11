using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using TMPro;

namespace lotus
{
	// Token: 0x020000D5 RID: 213
	public class FXUnitWithLabel : FXUnit
	{
		// Token: 0x06000AB6 RID: 2742 RVA: 0x0003336C File Offset: 0x0003156C
		// Note: this type is marked as 'beforefieldinit'.
		static FXUnitWithLabel()
		{
			Il2CppClassPointerStore<FXUnitWithLabel>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lotus", "FXUnitWithLabel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FXUnitWithLabel>.NativeClassPtr);
			FXUnitWithLabel.NativeFieldInfoPtr_label = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FXUnitWithLabel>.NativeClassPtr, "label");
			FXUnitWithLabel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FXUnitWithLabel>.NativeClassPtr, 100665029);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x000333C4 File Offset: 0x000315C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 994191, XrefRangeEnd = 994192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FXUnitWithLabel()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FXUnitWithLabel>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FXUnitWithLabel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00006EB0 File Offset: 0x000050B0
		public FXUnitWithLabel(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000AB9 RID: 2745 RVA: 0x00033400 File Offset: 0x00031600
		// (set) Token: 0x06000ABA RID: 2746 RVA: 0x00006EB9 File Offset: 0x000050B9
		public unsafe TMP_Text label
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitWithLabel.NativeFieldInfoPtr_label);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TMP_Text>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FXUnitWithLabel.NativeFieldInfoPtr_label), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeFieldInfoPtr_label;

		// Token: 0x0400069B RID: 1691
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
