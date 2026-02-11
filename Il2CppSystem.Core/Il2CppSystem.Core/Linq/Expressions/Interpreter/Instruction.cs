using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions.Interpreter
{
	// Token: 0x020000BC RID: 188
	public class Instruction : Object
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x0003BC68 File Offset: 0x00039E68
		// Note: this type is marked as 'beforefieldinit'.
		static Instruction()
		{
			Il2CppClassPointerStore<Instruction>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions.Interpreter", "Instruction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Instruction>.NativeClassPtr);
			Instruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665245);
			Instruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665246);
			Instruction.NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665247);
			Instruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665248);
			Instruction.NativeMethodInfoPtr_get_StackBalance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665249);
			Instruction.NativeMethodInfoPtr_get_ContinuationsBalance_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665250);
			Instruction.NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Int32_InterpretedFrame_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665251);
			Instruction.NativeMethodInfoPtr_get_InstructionName_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665252);
			Instruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665253);
			Instruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_New_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665254);
			Instruction.NativeMethodInfoPtr_NullCheck_Protected_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665255);
			Instruction.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Instruction>.NativeClassPtr, 100665256);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0003BD88 File Offset: 0x00039F88
		public unsafe virtual int ConsumedStack
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x0003BDD0 File Offset: 0x00039FD0
		public unsafe virtual int ProducedStack
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0003BE18 File Offset: 0x0003A018
		public unsafe virtual int ConsumedContinuations
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x06000A67 RID: 2663 RVA: 0x0003BE60 File Offset: 0x0003A060
		public unsafe virtual int ProducedContinuations
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0003BEA8 File Offset: 0x0003A0A8
		public unsafe int StackBalance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1017344, RefRangeEnd = 1017345, XrefRangeStart = 1017344, XrefRangeEnd = 1017344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_get_StackBalance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0003BEE4 File Offset: 0x0003A0E4
		public unsafe int ContinuationsBalance
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1017345, RefRangeEnd = 1017346, XrefRangeStart = 1017345, XrefRangeEnd = 1017345, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_get_ContinuationsBalance_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x0003BF20 File Offset: 0x0003A120
		[CallerCount(0)]
		public unsafe virtual int Run(InterpretedFrame frame)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(frame);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Int32_InterpretedFrame_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0003BF78 File Offset: 0x0003A178
		public unsafe virtual string InstructionName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_get_InstructionName_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x0003BFBC File Offset: 0x0003A1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1017346, XrefRangeEnd = 1017349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x0003C000 File Offset: 0x0003A200
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017349, RefRangeEnd = 1017351, XrefRangeStart = 1017349, XrefRangeEnd = 1017349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string ToDebugString(int instructionIndex, Object cookie, Func<int, int> labelIndexer, IReadOnlyList<Object> objects)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Instruction.NativeMethodInfoPtr_ToDebugString_Public_Virtual_New_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x0003C088 File Offset: 0x0003A288
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1017351, RefRangeEnd = 1017353, XrefRangeStart = 1017351, XrefRangeEnd = 1017351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void NullCheck(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr_NullCheck_Protected_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x0003C0C0 File Offset: 0x0003A2C0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Instruction()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Instruction>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Instruction.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00004FBB File Offset: 0x000031BB
		public Instruction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007B4 RID: 1972
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedStack_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007B5 RID: 1973
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedStack_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007B6 RID: 1974
		private static readonly IntPtr NativeMethodInfoPtr_get_ConsumedContinuations_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007B7 RID: 1975
		private static readonly IntPtr NativeMethodInfoPtr_get_ProducedContinuations_Public_Virtual_New_get_Int32_0;

		// Token: 0x040007B8 RID: 1976
		private static readonly IntPtr NativeMethodInfoPtr_get_StackBalance_Public_get_Int32_0;

		// Token: 0x040007B9 RID: 1977
		private static readonly IntPtr NativeMethodInfoPtr_get_ContinuationsBalance_Public_get_Int32_0;

		// Token: 0x040007BA RID: 1978
		private static readonly IntPtr NativeMethodInfoPtr_Run_Public_Abstract_Virtual_New_Int32_InterpretedFrame_0;

		// Token: 0x040007BB RID: 1979
		private static readonly IntPtr NativeMethodInfoPtr_get_InstructionName_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x040007BC RID: 1980
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040007BD RID: 1981
		private static readonly IntPtr NativeMethodInfoPtr_ToDebugString_Public_Virtual_New_String_Int32_Object_Func_2_Int32_Int32_IReadOnlyList_1_Object_0;

		// Token: 0x040007BE RID: 1982
		private static readonly IntPtr NativeMethodInfoPtr_NullCheck_Protected_Static_Void_Object_0;

		// Token: 0x040007BF RID: 1983
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
