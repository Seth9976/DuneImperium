using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Data
{
	// Token: 0x02000026 RID: 38
	public class ForeignKeyConstraintEnumerator : ConstraintEnumerator
	{
		// Token: 0x0600050D RID: 1293 RVA: 0x0001F1E0 File Offset: 0x0001D3E0
		// Note: this type is marked as 'beforefieldinit'.
		static ForeignKeyConstraintEnumerator()
		{
			Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Data.dll", "System.Data", "ForeignKeyConstraintEnumerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr);
			ForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr, 100664175);
			ForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr, 100664176);
			ForeignKeyConstraintEnumerator.NativeMethodInfoPtr_GetForeignKeyConstraint_Public_ForeignKeyConstraint_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr, 100664177);
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x0001F24C File Offset: 0x0001D44C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 898538, RefRangeEnd = 898539, XrefRangeStart = 898538, XrefRangeEnd = 898539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraintEnumerator(DataSet dataSet)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ForeignKeyConstraintEnumerator>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dataSet);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraintEnumerator.NativeMethodInfoPtr__ctor_Public_Void_DataSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001F298 File Offset: 0x0001D498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 898566, XrefRangeEnd = 898567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValidCandidate(Constraint constraint)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constraint);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ForeignKeyConstraintEnumerator.NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 898569, RefRangeEnd = 898573, XrefRangeStart = 898567, XrefRangeEnd = 898569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ForeignKeyConstraint GetForeignKeyConstraint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ForeignKeyConstraintEnumerator.NativeMethodInfoPtr_GetForeignKeyConstraint_Public_ForeignKeyConstraint_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ForeignKeyConstraint>(intPtr3) : null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00003644 File Offset: 0x00001844
		public ForeignKeyConstraintEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000447 RID: 1095
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataSet_0;

		// Token: 0x04000448 RID: 1096
		private static readonly IntPtr NativeMethodInfoPtr_IsValidCandidate_Protected_Virtual_Boolean_Constraint_0;

		// Token: 0x04000449 RID: 1097
		private static readonly IntPtr NativeMethodInfoPtr_GetForeignKeyConstraint_Public_ForeignKeyConstraint_0;
	}
}
