using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000E2 RID: 226
	public sealed class ValueTypeCopyInstruction : Instruction
	{
		// Token: 0x06000DB6 RID: 3510 RVA: 0x0004CE9C File Offset: 0x0004B09C
		// Note: this type is marked as 'beforefieldinit'.
		static ValueTypeCopyInstruction()
		{
			Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "ValueTypeCopyInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr);
			ValueTypeCopyInstruction.NativeFieldInfoPtr_Instruction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, "Instruction");
			ValueTypeCopyInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, 100665794);
			ValueTypeCopyInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, 100665795);
			ValueTypeCopyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, 100665796);
			ValueTypeCopyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, 100665797);
			ValueTypeCopyInstruction.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr, 100665798);
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000DB7 RID: 3511 RVA: 0x0004CF44 File Offset: 0x0004B144
		public unsafe override int ConsumedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeCopyInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000DB8 RID: 3512 RVA: 0x0004CF80 File Offset: 0x0004B180
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeCopyInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x0004CFBC File Offset: 0x0004B1BC
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024682, XrefRangeEnd = 1024684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeCopyInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x0004CFF4 File Offset: 0x0004B1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024684, XrefRangeEnd = 1024688, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeCopyInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x0004D044 File Offset: 0x0004B244
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ValueTypeCopyInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ValueTypeCopyInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ValueTypeCopyInstruction.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x000061C4 File Offset: 0x000043C4
		public ValueTypeCopyInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000DBD RID: 3517 RVA: 0x0004D080 File Offset: 0x0004B280
		// (set) Token: 0x06000DBE RID: 3518 RVA: 0x000061CD File Offset: 0x000043CD
		public unsafe static ValueTypeCopyInstruction Instruction
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ValueTypeCopyInstruction.NativeFieldInfoPtr_Instruction, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueTypeCopyInstruction>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ValueTypeCopyInstruction.NativeFieldInfoPtr_Instruction, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000A1E RID: 2590
		private static readonly IntPtr NativeFieldInfoPtr_Instruction;

		// Token: 0x04000A1F RID: 2591
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A20 RID: 2592
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A21 RID: 2593
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A22 RID: 2594
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x04000A23 RID: 2595
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
