using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000ED RID: 237
	public class NewInstruction : Instruction
	{
		// Token: 0x06000E53 RID: 3667 RVA: 0x0004ECCC File Offset: 0x0004CECC
		// Note: this type is marked as 'beforefieldinit'.
		static NewInstruction()
		{
			Il2CppClassPointerStore<NewInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "NewInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr);
			NewInstruction.NativeFieldInfoPtr__constructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, "_constructor");
			NewInstruction.NativeFieldInfoPtr__argumentCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, "_argumentCount");
			NewInstruction.NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665938);
			NewInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665939);
			NewInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665940);
			NewInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665941);
			NewInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665942);
			NewInstruction.NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665943);
			NewInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr, 100665944);
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0004EDB0 File Offset: 0x0004CFB0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 660727, RefRangeEnd = 660732, XrefRangeStart = 660727, XrefRangeEnd = 660732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NewInstruction(ConstructorInfo constructor, int argumentCount)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewInstruction>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref argumentCount;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewInstruction.NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000E55 RID: 3669 RVA: 0x0004EE0C File Offset: 0x0004D00C
		public unsafe override int ConsumedStack
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewInstruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x0004EE54 File Offset: 0x0004D054
		public unsafe override int ProducedStack
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29748, RefRangeEnd = 29750, XrefRangeStart = 29748, XrefRangeEnd = 29750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewInstruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06000E57 RID: 3671 RVA: 0x0004EE9C File Offset: 0x0004D09C
		public unsafe override string InstructionName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025197, XrefRangeEnd = 1025199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewInstruction.NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x0004EEE0 File Offset: 0x0004D0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025199, XrefRangeEnd = 1025203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewInstruction.NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x0004EF38 File Offset: 0x0004D138
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1025212, RefRangeEnd = 1025214, XrefRangeStart = 1025203, XrefRangeEnd = 1025212, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(InterpretedFrame frame, int first)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref first;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NewInstruction.NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x0004EF98 File Offset: 0x0004D198
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1025214, XrefRangeEnd = 1025232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NewInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x0000659F File Offset: 0x0000479F
		public NewInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x0004EFDC File Offset: 0x0004D1DC
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x000065A8 File Offset: 0x000047A8
		public unsafe ConstructorInfo _constructor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewInstruction.NativeFieldInfoPtr__constructor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewInstruction.NativeFieldInfoPtr__constructor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x0004F00C File Offset: 0x0004D20C
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x000065C7 File Offset: 0x000047C7
		public unsafe int _argumentCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewInstruction.NativeFieldInfoPtr__argumentCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NewInstruction.NativeFieldInfoPtr__argumentCount)) = value;
			}
		}

		// Token: 0x04000A7C RID: 2684
		private static readonly IntPtr NativeFieldInfoPtr__constructor;

		// Token: 0x04000A7D RID: 2685
		private static readonly IntPtr NativeFieldInfoPtr__argumentCount;

		// Token: 0x04000A7E RID: 2686
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConstructorInfo_Int32_0;

		// Token: 0x04000A7F RID: 2687
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A80 RID: 2688
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_get_Int32_0;

		// Token: 0x04000A81 RID: 2689
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Virtual_get_String_0;

		// Token: 0x04000A82 RID: 2690
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Virtual_Int32_InterpretedFrame_0;

		// Token: 0x04000A83 RID: 2691
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Protected_Il2CppReferenceArray_1_Object_InterpretedFrame_Int32_0;

		// Token: 0x04000A84 RID: 2692
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
