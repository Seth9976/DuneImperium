using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000068 RID: 104
	public sealed class PropertyExpression : MemberExpression
	{
		// Token: 0x060005B2 RID: 1458 RVA: 0x0002BB5C File Offset: 0x00029D5C
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyExpression()
		{
			Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "PropertyExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr);
			PropertyExpression.NativeFieldInfoPtr__property = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr, "_property");
			PropertyExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_PropertyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr, 100664520);
			PropertyExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr, 100664521);
			PropertyExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr, 100664522);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002BBDC File Offset: 0x00029DDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertyExpression(Expression expression, PropertyInfo member)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertyExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(expression);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(member);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyExpression.NativeMethodInfoPtr__ctor_Public_Void_Expression_PropertyInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002BC3C File Offset: 0x00029E3C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MemberInfo GetMember()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyExpression.NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr3) : null;
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x0002BC7C File Offset: 0x00029E7C
		public unsafe override Type Type
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014259, XrefRangeEnd = 1014260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x0000358E File Offset: 0x0000178E
		public PropertyExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060005B7 RID: 1463 RVA: 0x0002BCBC File Offset: 0x00029EBC
		// (set) Token: 0x060005B8 RID: 1464 RVA: 0x00003597 File Offset: 0x00001797
		public unsafe PropertyInfo _property
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyExpression.NativeFieldInfoPtr__property);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PropertyInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PropertyExpression.NativeFieldInfoPtr__property), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004AF RID: 1199
		private static readonly IntPtr NativeFieldInfoPtr__property;

		// Token: 0x040004B0 RID: 1200
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_PropertyInfo_0;

		// Token: 0x040004B1 RID: 1201
		private static readonly IntPtr NativeMethodInfoPtr_GetMember_Internal_Virtual_MemberInfo_0;

		// Token: 0x040004B2 RID: 1202
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
