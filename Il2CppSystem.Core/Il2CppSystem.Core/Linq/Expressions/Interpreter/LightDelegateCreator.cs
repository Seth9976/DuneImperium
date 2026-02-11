using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D5 RID: 213
	public sealed class LightDelegateCreator : Object
	{
		// Token: 0x06000D11 RID: 3345 RVA: 0x00045CE0 File Offset: 0x00043EE0
		// Note: this type is marked as 'beforefieldinit'.
		static LightDelegateCreator()
		{
			Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LightDelegateCreator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr);
			LightDelegateCreator.NativeFieldInfoPtr__lambda = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, "_lambda");
			LightDelegateCreator.NativeFieldInfoPtr__Interpreter_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, "<Interpreter>k__BackingField");
			LightDelegateCreator.NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_LambdaExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, 100665660);
			LightDelegateCreator.NativeMethodInfoPtr_get_Interpreter_Internal_get_Interpreter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, 100665661);
			LightDelegateCreator.NativeMethodInfoPtr_CreateDelegate_Public_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, 100665662);
			LightDelegateCreator.NativeMethodInfoPtr_CreateDelegate_Internal_Delegate_Il2CppReferenceArray_1_IStrongBox_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr, 100665663);
		}

		// Token: 0x06000D12 RID: 3346 RVA: 0x00045D88 File Offset: 0x00043F88
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 558839, RefRangeEnd = 558843, XrefRangeStart = 558839, XrefRangeEnd = 558843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LightDelegateCreator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(interpreter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(lambda);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDelegateCreator.NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_LambdaExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00045DE8 File Offset: 0x00043FE8
		public unsafe Interpreter Interpreter
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDelegateCreator.NativeMethodInfoPtr_get_Interpreter_Internal_get_Interpreter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr3) : null;
			}
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x00045E28 File Offset: 0x00044028
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022451, RefRangeEnd = 1022453, XrefRangeStart = 1022450, XrefRangeEnd = 1022451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delegate CreateDelegate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDelegateCreator.NativeMethodInfoPtr_CreateDelegate_Public_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00045E68 File Offset: 0x00044068
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1022466, RefRangeEnd = 1022468, XrefRangeStart = 1022453, XrefRangeEnd = 1022466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Delegate CreateDelegate(Il2CppReferenceArray<IStrongBox> closure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(closure);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LightDelegateCreator.NativeMethodInfoPtr_CreateDelegate_Internal_Delegate_Il2CppReferenceArray_1_IStrongBox_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x0000603C File Offset: 0x0000423C
		public LightDelegateCreator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00045EB8 File Offset: 0x000440B8
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00006045 File Offset: 0x00004245
		public unsafe LambdaExpression _lambda
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightDelegateCreator.NativeFieldInfoPtr__lambda);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LambdaExpression>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightDelegateCreator.NativeFieldInfoPtr__lambda), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00045EE8 File Offset: 0x000440E8
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00006064 File Offset: 0x00004264
		public unsafe Interpreter _Interpreter_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightDelegateCreator.NativeFieldInfoPtr__Interpreter_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Interpreter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LightDelegateCreator.NativeFieldInfoPtr__Interpreter_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400099C RID: 2460
		private static readonly IntPtr NativeFieldInfoPtr__lambda;

		// Token: 0x0400099D RID: 2461
		private static readonly IntPtr NativeFieldInfoPtr__Interpreter_k__BackingField;

		// Token: 0x0400099E RID: 2462
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Interpreter_LambdaExpression_0;

		// Token: 0x0400099F RID: 2463
		private static readonly IntPtr NativeMethodInfoPtr_get_Interpreter_Internal_get_Interpreter_0;

		// Token: 0x040009A0 RID: 2464
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Public_Delegate_0;

		// Token: 0x040009A1 RID: 2465
		private static readonly IntPtr NativeMethodInfoPtr_CreateDelegate_Internal_Delegate_Il2CppReferenceArray_1_IStrongBox_0;
	}
}
