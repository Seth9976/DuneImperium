using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AD RID: 173
	public sealed class IntSwitchInstruction<T> : Instruction
	{
		// Token: 0x06000928 RID: 2344 RVA: 0x00038838 File Offset: 0x00036A38
		// Note: this type is marked as 'beforefieldinit'.
		static IntSwitchInstruction()
		{
			Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "IntSwitchInstruction`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr);
			IntSwitchInstruction<T>.NativeFieldInfoPtr__cases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr, "_cases");
			IntSwitchInstruction<T>.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr, 100665018);
			IntSwitchInstruction<T>.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr, 100665019);
			IntSwitchInstruction<T>.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr, 100665020);
			IntSwitchInstruction<T>.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr, 100665021);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x00038908 File Offset: 0x00036B08
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntSwitchInstruction(Dictionary<T, int> cases)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntSwitchInstruction<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cases);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSwitchInstruction<T>.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_T_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00038954 File Offset: 0x00036B54
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016255, XrefRangeEnd = 1016257, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSwitchInstruction<T>.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0003898C File Offset: 0x00036B8C
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSwitchInstruction<T>.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x000389C8 File Offset: 0x00036BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016257, XrefRangeEnd = 1016261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntSwitchInstruction<T>.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x0000472F File Offset: 0x0000292F
		public IntSwitchInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00038A18 File Offset: 0x00036C18
		// (set) Token: 0x0600092F RID: 2351 RVA: 0x00004738 File Offset: 0x00002938
		public unsafe Dictionary<T, int> _cases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSwitchInstruction<T>.NativeFieldInfoPtr__cases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<T, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntSwitchInstruction<T>.NativeFieldInfoPtr__cases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeFieldInfoPtr__cases;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_T_Int32_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
