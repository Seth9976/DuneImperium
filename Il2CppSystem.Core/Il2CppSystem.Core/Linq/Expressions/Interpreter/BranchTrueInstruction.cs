using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009D RID: 157
	public sealed class BranchTrueInstruction : OffsetInstruction
	{
		// Token: 0x06000874 RID: 2164 RVA: 0x00035FBC File Offset: 0x000341BC
		// Note: this type is marked as 'beforefieldinit'.
		static BranchTrueInstruction()
		{
			Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "BranchTrueInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr);
			BranchTrueInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, "s_cache");
			BranchTrueInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, 100664920);
			BranchTrueInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, 100664921);
			BranchTrueInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, 100664922);
			BranchTrueInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, 100664923);
			BranchTrueInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr, 100664924);
		}

		// Token: 0x1700024C RID: 588
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00036064 File Offset: 0x00034264
		public unsafe override Il2CppReferenceArray<Instruction> Cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016042, XrefRangeEnd = 1016051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchTrueInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr3) : null;
			}
		}

		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000360A4 File Offset: 0x000342A4
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016051, XrefRangeEnd = 1016053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchTrueInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000360DC File Offset: 0x000342DC
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchTrueInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00036118 File Offset: 0x00034318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016053, XrefRangeEnd = 1016057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchTrueInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00036168 File Offset: 0x00034368
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1016024, RefRangeEnd = 1016027, XrefRangeStart = 1016024, XrefRangeEnd = 1016027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchTrueInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchTrueInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchTrueInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x00004406 File Offset: 0x00002606
		public BranchTrueInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700024B RID: 587
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000361A4 File Offset: 0x000343A4
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0000440F File Offset: 0x0000260F
		public unsafe static Il2CppReferenceArray<Instruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BranchTrueInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BranchTrueInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400068E RID: 1678
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x0400068F RID: 1679
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0;

		// Token: 0x04000690 RID: 1680
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000691 RID: 1681
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000692 RID: 1682
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x04000693 RID: 1683
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
