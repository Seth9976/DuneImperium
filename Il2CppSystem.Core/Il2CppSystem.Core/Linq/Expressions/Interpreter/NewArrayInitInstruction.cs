using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200008F RID: 143
	public sealed class NewArrayInitInstruction : Instruction
	{
		// Token: 0x060007EC RID: 2028 RVA: 0x00033EC0 File Offset: 0x000320C0
		// Note: this type is marked as 'beforefieldinit'.
		static NewArrayInitInstruction()
		{
			Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NewArrayInitInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr);
			NewArrayInitInstruction.NativeFieldInfoPtr__elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, "_elementType");
			NewArrayInitInstruction.NativeFieldInfoPtr__elementCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, "_elementCount");
			NewArrayInitInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, 100664845);
			NewArrayInitInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, 100664846);
			NewArrayInitInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, 100664847);
			NewArrayInitInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, 100664848);
			NewArrayInitInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr, 100664849);
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x00033F7C File Offset: 0x0003217C
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewArrayInitInstruction(Type elementType, int elementCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewArrayInitInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref elementCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitInstruction.NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x060007EE RID: 2030 RVA: 0x00033FD8 File Offset: 0x000321D8
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060007EF RID: 2031 RVA: 0x00034014 File Offset: 0x00032214
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060007F0 RID: 2032 RVA: 0x00034050 File Offset: 0x00032250
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015632, XrefRangeEnd = 1015634, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00034088 File Offset: 0x00032288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1015634, XrefRangeEnd = 1015639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewArrayInitInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000416C File Offset: 0x0000236C
		public NewArrayInitInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000340D8 File Offset: 0x000322D8
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x00004175 File Offset: 0x00002375
		public unsafe Type _elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayInitInstruction.NativeFieldInfoPtr__elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayInitInstruction.NativeFieldInfoPtr__elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00034108 File Offset: 0x00032308
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x00004194 File Offset: 0x00002394
		public unsafe int _elementCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayInitInstruction.NativeFieldInfoPtr__elementCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewArrayInitInstruction.NativeFieldInfoPtr__elementCount)) = value;
			}
		}

		// Token: 0x0400062E RID: 1582
		private static readonly IntPtr NativeFieldInfoPtr__elementType;

		// Token: 0x0400062F RID: 1583
		private static readonly IntPtr NativeFieldInfoPtr__elementCount;

		// Token: 0x04000630 RID: 1584
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_Int32_0;

		// Token: 0x04000631 RID: 1585
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000634 RID: 1588
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;
	}
}
