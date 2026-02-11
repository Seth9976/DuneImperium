using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000051 RID: 81
	public sealed class LikeNode : BinaryNode
	{
		// Token: 0x06000866 RID: 2150 RVA: 0x0002CF60 File Offset: 0x0002B160
		// Note: this type is marked as 'beforefieldinit'.
		static LikeNode()
		{
			Il2CppClassPointerStore<LikeNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "LikeNode");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LikeNode>.NativeClassPtr);
			LikeNode.NativeFieldInfoPtr__kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LikeNode>.NativeClassPtr, "_kind");
			LikeNode.NativeFieldInfoPtr__pattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LikeNode>.NativeClassPtr, "_pattern");
			LikeNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LikeNode>.NativeClassPtr, 100664686);
			LikeNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LikeNode>.NativeClassPtr, 100664687);
			LikeNode.NativeMethodInfoPtr_AnalyzePattern_Internal_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LikeNode>.NativeClassPtr, 100664688);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x0002CFF4 File Offset: 0x0002B1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LikeNode(DataTable table, int op, ExpressionNode left, ExpressionNode right)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LikeNode>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(table);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref op;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(left);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(right);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LikeNode.NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x0002D074 File Offset: 0x0002B274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903286, XrefRangeEnd = 903303, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object Eval(DataRow row, DataRowVersion version)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(row);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LikeNode.NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x0002D0D4 File Offset: 0x0002B2D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 903303, XrefRangeEnd = 903315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string AnalyzePattern(string pat)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(pat);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LikeNode.NativeMethodInfoPtr_AnalyzePattern_Internal_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000048A6 File Offset: 0x00002AA6
		public LikeNode(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0002D11C File Offset: 0x0002B31C
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x000048AF File Offset: 0x00002AAF
		public unsafe int _kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LikeNode.NativeFieldInfoPtr__kind);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LikeNode.NativeFieldInfoPtr__kind)) = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0002D144 File Offset: 0x0002B344
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x000048CA File Offset: 0x00002ACA
		public unsafe string _pattern
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LikeNode.NativeFieldInfoPtr__pattern);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LikeNode.NativeFieldInfoPtr__pattern), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006E4 RID: 1764
		private static readonly IntPtr NativeFieldInfoPtr__kind;

		// Token: 0x040006E5 RID: 1765
		private static readonly IntPtr NativeFieldInfoPtr__pattern;

		// Token: 0x040006E6 RID: 1766
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_DataTable_Int32_ExpressionNode_ExpressionNode_0;

		// Token: 0x040006E7 RID: 1767
		private static readonly IntPtr NativeMethodInfoPtr_Eval_Internal_Virtual_Object_DataRow_DataRowVersion_0;

		// Token: 0x040006E8 RID: 1768
		private static readonly IntPtr NativeMethodInfoPtr_AnalyzePattern_Internal_String_String_0;
	}
}
