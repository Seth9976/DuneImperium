using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Reflection.Emit
{
	// Token: 0x0200045C RID: 1116
	[StructLayout(2)]
	public struct OpCode
	{
		// Token: 0x06004130 RID: 16688 RVA: 0x00138988 File Offset: 0x00136B88
		// Note: this type is marked as 'beforefieldinit'.
		static OpCode()
		{
			Il2CppClassPointerStore<OpCode>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection.Emit", "OpCode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OpCode>.NativeClassPtr);
			OpCode.NativeFieldInfoPtr_op1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "op1");
			OpCode.NativeFieldInfoPtr_op2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "op2");
			OpCode.NativeFieldInfoPtr_push = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "push");
			OpCode.NativeFieldInfoPtr_pop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "pop");
			OpCode.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "size");
			OpCode.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "type");
			OpCode.NativeFieldInfoPtr_args = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "args");
			OpCode.NativeFieldInfoPtr_flow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OpCode>.NativeClassPtr, "flow");
			OpCode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673167);
			OpCode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673168);
			OpCode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673169);
			OpCode.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_OpCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673170);
			OpCode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673171);
			OpCode.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OpCode>.NativeClassPtr, 100673172);
		}

		// Token: 0x06004131 RID: 16689 RVA: 0x00138AD0 File Offset: 0x00136CD0
		[CallerCount(0)]
		public unsafe OpCode(int p, int q)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref p;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref q;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004132 RID: 16690 RVA: 0x00138B10 File Offset: 0x00136D10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403611, XrefRangeEnd = 1403613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004133 RID: 16691 RVA: 0x00138B40 File Offset: 0x00136D40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403613, XrefRangeEnd = 1403616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004134 RID: 16692 RVA: 0x00138B84 File Offset: 0x00136D84
		[CallerCount(0)]
		public unsafe bool Equals(OpCode obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_OpCode_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004135 RID: 16693 RVA: 0x00138BC4 File Offset: 0x00136DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1403616, XrefRangeEnd = 1403617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06004136 RID: 16694 RVA: 0x00138BF0 File Offset: 0x00136DF0
		public unsafe string Name
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1403621, RefRangeEnd = 1403623, XrefRangeStart = 1403617, XrefRangeEnd = 1403621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OpCode.NativeMethodInfoPtr_get_Name_Public_get_String_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06004137 RID: 16695 RVA: 0x000178E4 File Offset: 0x00015AE4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OpCode>.NativeClassPtr, ref this));
		}

		// Token: 0x040035AA RID: 13738
		private static readonly IntPtr NativeFieldInfoPtr_op1;

		// Token: 0x040035AB RID: 13739
		private static readonly IntPtr NativeFieldInfoPtr_op2;

		// Token: 0x040035AC RID: 13740
		private static readonly IntPtr NativeFieldInfoPtr_push;

		// Token: 0x040035AD RID: 13741
		private static readonly IntPtr NativeFieldInfoPtr_pop;

		// Token: 0x040035AE RID: 13742
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040035AF RID: 13743
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040035B0 RID: 13744
		private static readonly IntPtr NativeFieldInfoPtr_args;

		// Token: 0x040035B1 RID: 13745
		private static readonly IntPtr NativeFieldInfoPtr_flow;

		// Token: 0x040035B2 RID: 13746
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_0;

		// Token: 0x040035B3 RID: 13747
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040035B4 RID: 13748
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040035B5 RID: 13749
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_OpCode_0;

		// Token: 0x040035B6 RID: 13750
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040035B7 RID: 13751
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x040035B8 RID: 13752
		[FieldOffset(0)]
		public readonly byte op1;

		// Token: 0x040035B9 RID: 13753
		[FieldOffset(1)]
		public readonly byte op2;

		// Token: 0x040035BA RID: 13754
		[FieldOffset(2)]
		public readonly byte push;

		// Token: 0x040035BB RID: 13755
		[FieldOffset(3)]
		public readonly byte pop;

		// Token: 0x040035BC RID: 13756
		[FieldOffset(4)]
		public readonly byte size;

		// Token: 0x040035BD RID: 13757
		[FieldOffset(5)]
		public readonly byte type;

		// Token: 0x040035BE RID: 13758
		[FieldOffset(6)]
		public readonly byte args;

		// Token: 0x040035BF RID: 13759
		[FieldOffset(7)]
		public readonly byte flow;
	}
}
