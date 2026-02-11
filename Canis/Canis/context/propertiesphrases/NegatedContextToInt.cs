using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000135 RID: 309
	[Serializable]
	public class NegatedContextToInt : ContextToInt
	{
		// Token: 0x06000E10 RID: 3600 RVA: 0x000553B8 File Offset: 0x000535B8
		// Note: this type is marked as 'beforefieldinit'.
		static NegatedContextToInt()
		{
			Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "NegatedContextToInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr);
			NegatedContextToInt.NativeFieldInfoPtr_cti = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr, "cti");
			NegatedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr, 100666390);
			NegatedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr, 100666391);
		}

		// Token: 0x06000E11 RID: 3601 RVA: 0x00055424 File Offset: 0x00053624
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NegatedContextToInt(ContextToInt cti)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NegatedContextToInt>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cti);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NegatedContextToInt.NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000E12 RID: 3602 RVA: 0x00055470 File Offset: 0x00053670
		[CallerCount(0)]
		public unsafe override int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NegatedContextToInt.NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x000071DE File Offset: 0x000053DE
		public NegatedContextToInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000E14 RID: 3604 RVA: 0x000554C8 File Offset: 0x000536C8
		// (set) Token: 0x06000E15 RID: 3605 RVA: 0x000071E7 File Offset: 0x000053E7
		public unsafe ContextToInt cti
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NegatedContextToInt.NativeFieldInfoPtr_cti);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NegatedContextToInt.NativeFieldInfoPtr_cti), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000990 RID: 2448
		private static readonly IntPtr NativeFieldInfoPtr_cti;

		// Token: 0x04000991 RID: 2449
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ContextToInt_0;

		// Token: 0x04000992 RID: 2450
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Int32_Context_0;
	}
}
