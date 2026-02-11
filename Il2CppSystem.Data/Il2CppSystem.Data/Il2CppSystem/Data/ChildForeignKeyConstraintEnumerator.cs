using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000027 RID: 39
	public sealed class ChildForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		// Token: 0x06000512 RID: 1298 RVA: 0x0001F330 File Offset: 0x0001D530
		// Note: this type is marked as 'beforefieldinit'.
		static ChildForeignKeyConstraintEnumerator()
		{
			Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ChildForeignKeyConstraintEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr);
			ChildForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr, "_table");
			ChildForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr, 100664178);
			ChildForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr, 100664179);
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001F39C File Offset: 0x0001D59C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 898579, RefRangeEnd = 898583, XrefRangeStart = 898573, XrefRangeEnd = 898579, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChildForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChildForeignKeyConstraintEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001F3FC File Offset: 0x0001D5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898583, XrefRangeEnd = 898585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidCandidate(Constraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChildForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0000364D File Offset: 0x0000184D
		public ChildForeignKeyConstraintEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x0001F44C File Offset: 0x0001D64C
		// (set) Token: 0x06000517 RID: 1303 RVA: 0x00003656 File Offset: 0x00001856
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChildForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044A RID: 1098
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400044B RID: 1099
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0;

		// Token: 0x0400044C RID: 1100
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0;
	}
}
