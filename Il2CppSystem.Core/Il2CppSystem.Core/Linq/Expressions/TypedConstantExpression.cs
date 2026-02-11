using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000041 RID: 65
	public class TypedConstantExpression : ConstantExpression
	{
		// Token: 0x06000399 RID: 921 RVA: 0x00021AD0 File Offset: 0x0001FCD0
		// Note: this type is marked as 'beforefieldinit'.
		static TypedConstantExpression()
		{
			Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "TypedConstantExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr);
			TypedConstantExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr, "<Type>k__BackingField");
			TypedConstantExpression.NativeMethodInfoPtr__ctor_Internal_Void_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr, 100664167);
			TypedConstantExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr, 100664168);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00021B3C File Offset: 0x0001FD3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1012192, RefRangeEnd = 1012193, XrefRangeStart = 1012186, XrefRangeEnd = 1012192, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedConstantExpression(Object value, Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedConstantExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedConstantExpression.NativeMethodInfoPtr__ctor_Internal_Void_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00021B9C File Offset: 0x0001FD9C
		public unsafe override Type Type
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedConstantExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002D8E File Offset: 0x00000F8E
		public TypedConstantExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00021BDC File Offset: 0x0001FDDC
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00002D97 File Offset: 0x00000F97
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedConstantExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedConstantExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_Type_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
