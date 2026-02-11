using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x0200009B RID: 155
	public class OffsetInstruction : Instruction
	{
		// Token: 0x06000862 RID: 2146 RVA: 0x00035B3C File Offset: 0x00033D3C
		// Note: this type is marked as 'beforefieldinit'.
		static OffsetInstruction()
		{
			Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "OffsetInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr);
			OffsetInstruction.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, "_offset");
			OffsetInstruction.NativeMethodInfoPtr_get_Cache_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Instruction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, 100664910);
			OffsetInstruction.NativeMethodInfoPtr_Fixup_Public_Instruction_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, 100664911);
			OffsetInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, 100664912);
			OffsetInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, 100664913);
			OffsetInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr, 100664914);
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x00035BE4 File Offset: 0x00033DE4
		public unsafe virtual Il2CppReferenceArray<Instruction> Cache
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffsetInstruction.NativeMethodInfoPtr_get_Cache_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Instruction_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Instruction>>(intPtr3) : null;
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00035C30 File Offset: 0x00033E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1016004, RefRangeEnd = 1016005, XrefRangeStart = 1016002, XrefRangeEnd = 1016004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction Fixup(int offset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffsetInstruction.NativeMethodInfoPtr_Fixup_Public_Instruction_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Instruction>(intPtr3) : null;
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00035C7C File Offset: 0x00033E7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016005, XrefRangeEnd = 1016013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToDebugString(int instructionIndex, Object cookie, Func<int, int> labelIndexer, IReadOnlyList<Object> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref instructionIndex;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(cookie);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(labelIndexer);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffsetInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00035D04 File Offset: 0x00033F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016013, XrefRangeEnd = 1016023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OffsetInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00035D48 File Offset: 0x00033F48
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1016024, RefRangeEnd = 1016027, XrefRangeStart = 1016023, XrefRangeEnd = 1016024, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OffsetInstruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OffsetInstruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OffsetInstruction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000043C7 File Offset: 0x000025C7
		public OffsetInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x00035D84 File Offset: 0x00033F84
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x000043D0 File Offset: 0x000025D0
		public unsafe int _offset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffsetInstruction.NativeFieldInfoPtr__offset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OffsetInstruction.NativeFieldInfoPtr__offset)) = value;
			}
		}

		// Token: 0x04000682 RID: 1666
		private static readonly IntPtr NativeFieldInfoPtr__offset;

		// Token: 0x04000683 RID: 1667
		private static readonly IntPtr NativeMethodInfoPtr_get_Cache_Public_Abstract_Virtual_New_get_Il2CppReferenceArray_1_Instruction_0;

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeMethodInfoPtr_Fixup_Public_Instruction_Int32_0;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
