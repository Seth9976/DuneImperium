using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Runtime.CompilerServices;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000AE RID: 174
	public sealed class StringSwitchInstruction : Instruction
	{
		// Token: 0x06000930 RID: 2352 RVA: 0x00038A48 File Offset: 0x00036C48
		// Note: this type is marked as 'beforefieldinit'.
		static StringSwitchInstruction()
		{
			Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "StringSwitchInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr);
			StringSwitchInstruction.NativeFieldInfoPtr__cases = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, "_cases");
			StringSwitchInstruction.NativeFieldInfoPtr__nullCase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, "_nullCase");
			StringSwitchInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, 100665022);
			StringSwitchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, 100665023);
			StringSwitchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, 100665024);
			StringSwitchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr, 100665025);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00038AF0 File Offset: 0x00036CF0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 442634, RefRangeEnd = 442638, XrefRangeStart = 442634, XrefRangeEnd = 442638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StringSwitchInstruction(Dictionary<string, int> cases, StrongBox<int> nullCase)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringSwitchInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cases);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nullCase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSwitchInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00038B50 File Offset: 0x00036D50
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016261, XrefRangeEnd = 1016263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSwitchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000933 RID: 2355 RVA: 0x00038B88 File Offset: 0x00036D88
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSwitchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00038BC4 File Offset: 0x00036DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016263, XrefRangeEnd = 1016269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringSwitchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00004757 File Offset: 0x00002957
		public StringSwitchInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x00038C14 File Offset: 0x00036E14
		// (set) Token: 0x06000937 RID: 2359 RVA: 0x00004760 File Offset: 0x00002960
		public unsafe Dictionary<string, int> _cases
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSwitchInstruction.NativeFieldInfoPtr__cases);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSwitchInstruction.NativeFieldInfoPtr__cases), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000938 RID: 2360 RVA: 0x00038C44 File Offset: 0x00036E44
		// (set) Token: 0x06000939 RID: 2361 RVA: 0x0000477F File Offset: 0x0000297F
		public unsafe StrongBox<int> _nullCase
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSwitchInstruction.NativeFieldInfoPtr__nullCase);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StrongBox<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringSwitchInstruction.NativeFieldInfoPtr__nullCase), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeFieldInfoPtr__cases;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeFieldInfoPtr__nullCase;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Dictionary_2_String_Int32_StrongBox_1_Int32_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
