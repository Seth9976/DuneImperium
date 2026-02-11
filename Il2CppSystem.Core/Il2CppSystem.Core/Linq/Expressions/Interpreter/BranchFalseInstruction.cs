using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009C RID: 156
	public sealed class BranchFalseInstruction : OffsetInstruction
	{
		// Token: 0x0600086B RID: 2155 RVA: 0x00035DAC File Offset: 0x00033FAC
		// Note: this type is marked as 'beforefieldinit'.
		static BranchFalseInstruction()
		{
			Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "BranchFalseInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr);
			BranchFalseInstruction.NativeFieldInfoPtr_s_cache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, "s_cache");
			BranchFalseInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, 100664915);
			BranchFalseInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, 100664916);
			BranchFalseInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, 100664917);
			BranchFalseInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, 100664918);
			BranchFalseInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr, 100664919);
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x00035E54 File Offset: 0x00034054
		public unsafe override Il2CppReferenceArray<Instruction> Cache
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016027, XrefRangeEnd = 1016036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchFalseInstruction.NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr3) : null;
			}
		}

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x00035E94 File Offset: 0x00034094
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016036, XrefRangeEnd = 1016038, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchFalseInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x00035ECC File Offset: 0x000340CC
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchFalseInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00035F08 File Offset: 0x00034108
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016038, XrefRangeEnd = 1016042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchFalseInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00035F58 File Offset: 0x00034158
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1016024, RefRangeEnd = 1016027, XrefRangeStart = 1016024, XrefRangeEnd = 1016027, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BranchFalseInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BranchFalseInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BranchFalseInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x000043EB File Offset: 0x000025EB
		public BranchFalseInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x00035F94 File Offset: 0x00034194
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x000043F4 File Offset: 0x000025F4
		public unsafe static Il2CppReferenceArray<Instruction> s_cache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(BranchFalseInstruction.NativeFieldInfoPtr_s_cache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BranchFalseInstruction.NativeFieldInfoPtr_s_cache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeFieldInfoPtr_s_cache;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_Virtual_get_Il2CppReferenceArray_1_Instruction_0;

		// Token: 0x0400068A RID: 1674
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x0400068B RID: 1675
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x0400068C RID: 1676
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x0400068D RID: 1677
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
