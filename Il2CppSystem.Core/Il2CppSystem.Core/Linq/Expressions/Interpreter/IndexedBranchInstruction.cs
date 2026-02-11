using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000A0 RID: 160
	public class IndexedBranchInstruction : Instruction
	{
		// Token: 0x06000896 RID: 2198 RVA: 0x000367A8 File Offset: 0x000349A8
		// Note: this type is marked as 'beforefieldinit'.
		static IndexedBranchInstruction()
		{
			Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "IndexedBranchInstruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr);
			IndexedBranchInstruction.NativeFieldInfoPtr__labelIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr, "_labelIndex");
			IndexedBranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr, 100664938);
			IndexedBranchInstruction.NativeMethodInfoPtr_GetLabel_Public_RuntimeLabel_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr, 100664939);
			IndexedBranchInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr, 100664940);
			IndexedBranchInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr, 100664941);
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x0003683C File Offset: 0x00034A3C
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IndexedBranchInstruction(int labelIndex)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IndexedBranchInstruction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref labelIndex;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedBranchInstruction.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00036884 File Offset: 0x00034A84
		[CallerCount(0)]
		public unsafe RuntimeLabel GetLabel(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IndexedBranchInstruction.NativeMethodInfoPtr_GetLabel_Public_RuntimeLabel_InterpretedFrame_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x000368D4 File Offset: 0x00034AD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016099, XrefRangeEnd = 1016107, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexedBranchInstruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x0003695C File Offset: 0x00034B5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1016107, XrefRangeEnd = 1016113, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IndexedBranchInstruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x0000448D File Offset: 0x0000268D
		public IndexedBranchInstruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x000369A0 File Offset: 0x00034BA0
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00004496 File Offset: 0x00002696
		public unsafe int _labelIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedBranchInstruction.NativeFieldInfoPtr__labelIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IndexedBranchInstruction.NativeFieldInfoPtr__labelIndex)) = value;
			}
		}

		// Token: 0x040006A5 RID: 1701
		private static readonly IntPtr NativeFieldInfoPtr__labelIndex;

		// Token: 0x040006A6 RID: 1702
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x040006A7 RID: 1703
		private static readonly IntPtr NativeMethodInfoPtr_GetLabel_Public_RuntimeLabel_InterpretedFrame_0;

		// Token: 0x040006A8 RID: 1704
		private static readonly IntPtr NativeMethodInfoPtr_ToDebugString_Public_Virtual_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0;

		// Token: 0x040006A9 RID: 1705
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
