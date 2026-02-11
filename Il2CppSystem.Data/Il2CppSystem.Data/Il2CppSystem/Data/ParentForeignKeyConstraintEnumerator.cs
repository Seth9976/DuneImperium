using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000028 RID: 40
	public sealed class ParentForeignKeyConstraintEnumerator : ForeignKeyConstraintEnumerator
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x0001F47C File Offset: 0x0001D67C
		// Note: this type is marked as 'beforefieldinit'.
		static ParentForeignKeyConstraintEnumerator()
		{
			Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ParentForeignKeyConstraintEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr);
			ParentForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr, "_table");
			ParentForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr, 100664180);
			ParentForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr, 100664181);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001F4E8 File Offset: 0x0001D6E8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 898579, RefRangeEnd = 898583, XrefRangeStart = 898579, XrefRangeEnd = 898583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ParentForeignKeyConstraintEnumerator(DataSet dataSet, DataTable inTable)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParentForeignKeyConstraintEnumerator>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inTable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParentForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001F548 File Offset: 0x0001D748
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898585, XrefRangeEnd = 898587, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidCandidate(Constraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ParentForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00003675 File Offset: 0x00001875
		public ParentForeignKeyConstraintEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x0001F598 File Offset: 0x0001D798
		// (set) Token: 0x0600051D RID: 1309 RVA: 0x0000367E File Offset: 0x0000187E
		public unsafe DataTable _table
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParentForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DataTable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ParentForeignKeyConstraintEnumerator.NativeFieldInfoPtr__table), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400044D RID: 1101
		private static readonly IntPtr NativeFieldInfoPtr__table;

		// Token: 0x0400044E RID: 1102
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataSet_DataTable_0;

		// Token: 0x0400044F RID: 1103
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0;
	}
}
