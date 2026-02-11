using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000133 RID: 307
	[Serializable]
	public class ContextToInt : Object
	{
		// Token: 0x06000DFA RID: 3578 RVA: 0x00054CC8 File Offset: 0x00052EC8
		// Note: this type is marked as 'beforefieldinit'.
		static ContextToInt()
		{
			Il2CppClassPointerStore<ContextToInt>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "ContextToInt");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr);
			ContextToInt.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Int32_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666374);
			ContextToInt.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Int32_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666375);
			ContextToInt.NativeMethodInfoPtr_op_Implicit_Public_Static_ContextToInt_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666376);
			ContextToInt.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666377);
			ContextToInt.NativeMethodInfoPtr_op_Addition_Public_Static_ContextToInt_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666378);
			ContextToInt.NativeMethodInfoPtr_op_Subtraction_Public_Static_ContextToInt_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666379);
			ContextToInt.NativeMethodInfoPtr_op_Multiply_Public_Static_ContextToInt_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666380);
			ContextToInt.NativeMethodInfoPtr_op_Equality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666381);
			ContextToInt.NativeMethodInfoPtr_op_Inequality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666382);
			ContextToInt.NativeMethodInfoPtr_op_LessThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666383);
			ContextToInt.NativeMethodInfoPtr_op_GreaterThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666384);
			ContextToInt.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666385);
			ContextToInt.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666386);
			ContextToInt.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr, 100666387);
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00054E10 File Offset: 0x00053010
		[CallerCount(0)]
		public unsafe virtual int Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextToInt.NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Int32_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00054E68 File Offset: 0x00053068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577114, XrefRangeEnd = 577118, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator Func<Context, int>(ContextToInt cti)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cti);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Int32_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Context, int>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00054EAC File Offset: 0x000530AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577118, XrefRangeEnd = 577122, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe static implicit operator ContextToInt(int intVal)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref intVal;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Implicit_Public_Static_ContextToInt_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00054EEC File Offset: 0x000530EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577122, XrefRangeEnd = 577130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToInt operator -(ContextToInt phrase)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(phrase);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00054F30 File Offset: 0x00053130
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577130, XrefRangeEnd = 577137, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToInt operator +(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Addition_Public_Static_ContextToInt_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00054F88 File Offset: 0x00053188
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577137, XrefRangeEnd = 577163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToInt operator -(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Subtraction_Public_Static_ContextToInt_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x00054FE0 File Offset: 0x000531E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577163, XrefRangeEnd = 577170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ContextToInt operator *(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Multiply_Public_Static_ContextToInt_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x00055038 File Offset: 0x00053238
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577170, XrefRangeEnd = 577176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator ==(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Equality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00055090 File Offset: 0x00053290
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577176, XrefRangeEnd = 577184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator !=(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_Inequality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000550E8 File Offset: 0x000532E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577184, XrefRangeEnd = 577190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator <(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_LessThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00055140 File Offset: 0x00053340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577190, XrefRangeEnd = 577196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator >(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_GreaterThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00055198 File Offset: 0x00053398
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577196, XrefRangeEnd = 577202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator <=(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E07 RID: 3591 RVA: 0x000551F0 File Offset: 0x000533F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577202, XrefRangeEnd = 577208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PropertiesPhrase operator >=(ContextToInt first, ContextToInt second)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(first);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(second);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<PropertiesPhrase>(intPtr3) : null;
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00055248 File Offset: 0x00053448
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToInt()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextToInt>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToInt.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x000071B1 File Offset: 0x000053B1
		public ContextToInt(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400097F RID: 2431
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Abstract_Virtual_New_Int32_Context_0;

		// Token: 0x04000980 RID: 2432
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Func_2_Context_Int32_ContextToInt_0;

		// Token: 0x04000981 RID: 2433
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ContextToInt_Int32_0;

		// Token: 0x04000982 RID: 2434
		private static readonly IntPtr NativeMethodInfoPtr_op_UnaryNegation_Public_Static_ContextToInt_ContextToInt_0;

		// Token: 0x04000983 RID: 2435
		private static readonly IntPtr NativeMethodInfoPtr_op_Addition_Public_Static_ContextToInt_ContextToInt_ContextToInt_0;

		// Token: 0x04000984 RID: 2436
		private static readonly IntPtr NativeMethodInfoPtr_op_Subtraction_Public_Static_ContextToInt_ContextToInt_ContextToInt_0;

		// Token: 0x04000985 RID: 2437
		private static readonly IntPtr NativeMethodInfoPtr_op_Multiply_Public_Static_ContextToInt_ContextToInt_ContextToInt_0;

		// Token: 0x04000986 RID: 2438
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x04000987 RID: 2439
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x04000988 RID: 2440
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x04000989 RID: 2441
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThan_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x0400098A RID: 2442
		private static readonly IntPtr NativeMethodInfoPtr_op_LessThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x0400098B RID: 2443
		private static readonly IntPtr NativeMethodInfoPtr_op_GreaterThanOrEqual_Public_Static_PropertiesPhrase_ContextToInt_ContextToInt_0;

		// Token: 0x0400098C RID: 2444
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
