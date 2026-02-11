using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000067 RID: 103
	public sealed class FieldExpression : MemberExpression
	{
		// Token: 0x060005AB RID: 1451 RVA: 0x0002B9CC File Offset: 0x00029BCC
		// Note: this type is marked as 'beforefieldinit'.
		static FieldExpression()
		{
			Il2CppClassPointerStore<FieldExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "FieldExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr);
			FieldExpression.NativeFieldInfoPtr__field = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr, "_field");
			FieldExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_FieldInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr, 100664517);
			FieldExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr, 100664518);
			FieldExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr, 100664519);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0002BA4C File Offset: 0x00029C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014252, XrefRangeEnd = 1014258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FieldExpression(Expression expression, FieldInfo member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FieldExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_FieldInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0002BAAC File Offset: 0x00029CAC
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MemberInfo GetMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060005AE RID: 1454 RVA: 0x0002BAEC File Offset: 0x00029CEC
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014258, XrefRangeEnd = 1014259, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FieldExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00003566 File Offset: 0x00001766
		public FieldExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060005B0 RID: 1456 RVA: 0x0002BB2C File Offset: 0x00029D2C
		// (set) Token: 0x060005B1 RID: 1457 RVA: 0x0000356F File Offset: 0x0000176F
		public unsafe FieldInfo _field
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldExpression.NativeFieldInfoPtr__field);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FieldExpression.NativeFieldInfoPtr__field), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AB RID: 1195
		private static readonly IntPtr NativeFieldInfoPtr__field;

		// Token: 0x040004AC RID: 1196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_FieldInfo_0;

		// Token: 0x040004AD RID: 1197
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0;

		// Token: 0x040004AE RID: 1198
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
