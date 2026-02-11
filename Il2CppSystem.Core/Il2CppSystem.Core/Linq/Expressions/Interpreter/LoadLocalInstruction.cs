using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000D9 RID: 217
	public sealed class LoadLocalInstruction : LocalAccessInstruction
	{
		// Token: 0x06000D7A RID: 3450 RVA: 0x0004BEA0 File Offset: 0x0004A0A0
		// Note: this type is marked as 'beforefieldinit'.
		static LoadLocalInstruction()
		{
			Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "LoadLocalInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr);
			LoadLocalInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr, 100665752);
			LoadLocalInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr, 100665753);
			LoadLocalInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr, 100665754);
			LoadLocalInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr, 100665755);
			LoadLocalInstruction.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr, 100665756);
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x0004BF34 File Offset: 0x0004A134
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadLocalInstruction(int index)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadLocalInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLocalInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06000D7C RID: 3452 RVA: 0x0004BF7C File Offset: 0x0004A17C
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLocalInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x0004BFB8 File Offset: 0x0004A1B8
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024611, XrefRangeEnd = 1024613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLocalInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x0004BFF0 File Offset: 0x0004A1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024613, XrefRangeEnd = 1024615, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLocalInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x0004C040 File Offset: 0x0004A240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024615, XrefRangeEnd = 1024619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction BoxIfIndexMatches(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadLocalInstruction.NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00006173 File Offset: 0x00004373
		public LoadLocalInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040009F4 RID: 2548
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_0;

		// Token: 0x040009F5 RID: 2549
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x040009F6 RID: 2550
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x040009F7 RID: 2551
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x040009F8 RID: 2552
		private static readonly IntPtr NativeMethodInfoPtr_BoxIfIndexMatches_Public_Virtual_Final_New_Instruction_Int32_0;
	}
}
