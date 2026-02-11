using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000134 RID: 308
	[Serializable]
	public class ConstantContextToInt : ContextToInt
	{
		// Token: 0x06000E0A RID: 3594 RVA: 0x00055284 File Offset: 0x00053484
		// Note: this type is marked as 'beforefieldinit'.
		static ConstantContextToInt()
		{
			Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ConstantContextToInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr);
			ConstantContextToInt.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr, "amount");
			ConstantContextToInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr, 100666388);
			ConstantContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr, 100666389);
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x000552F0 File Offset: 0x000534F0
		[CallerCount(73)]
		[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstantContextToInt(int amount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstantContextToInt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amount;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstantContextToInt.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00055338 File Offset: 0x00053538
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstantContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E0D RID: 3597 RVA: 0x000071BA File Offset: 0x000053BA
		public ConstantContextToInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000E0E RID: 3598 RVA: 0x00055390 File Offset: 0x00053590
		// (set) Token: 0x06000E0F RID: 3599 RVA: 0x000071C3 File Offset: 0x000053C3
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantContextToInt.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstantContextToInt.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x0400098D RID: 2445
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x0400098E RID: 2446
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400098F RID: 2447
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0;
	}
}
