using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009E RID: 158
	public sealed class CoalescingBranchInstruction : OffsetInstruction
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x000361CC File Offset: 0x000343CC
		// Note: this type is marked as 'beforefieldinit'.
		static CoalescingBranchInstruction()
		{
			Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "CoalescingBranchInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr);
			CoalescingBranchInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, "s_cache");
			CoalescingBranchInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664925);
			CoalescingBranchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664926);
			CoalescingBranchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664927);
			CoalescingBranchInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664928);
			CoalescingBranchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664929);
			CoalescingBranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr, 100664930);
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x00036288 File Offset: 0x00034488
		public unsafe override Il2CppReferenceArray<Instruction> Cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016057, XrefRangeEnd = 1016066, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x000362C8 File Offset: 0x000344C8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016066, XrefRangeEnd = 1016068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x00036300 File Offset: 0x00034500
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0003633C File Offset: 0x0003453C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00036378 File Offset: 0x00034578
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016068, XrefRangeEnd = 1016069, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x000363C8 File Offset: 0x000345C8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1016024, RefRangeEnd = 1016027, XrefRangeStart = 1016024, XrefRangeEnd = 1016027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CoalescingBranchInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CoalescingBranchInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CoalescingBranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00004421 File Offset: 0x00002621
		public CoalescingBranchInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x00036404 File Offset: 0x00034604
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0000442A File Offset: 0x0000262A
		public unsafe static Il2CppReferenceArray<Instruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CoalescingBranchInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CoalescingBranchInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000694 RID: 1684
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x04000695 RID: 1685
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0;

		// Token: 0x04000696 RID: 1686
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000697 RID: 1687
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000698 RID: 1688
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000699 RID: 1689
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x0400069A RID: 1690
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
