using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000080 RID: 128
	public class TypedParameterExpression : ParameterExpression
	{
		// Token: 0x06000681 RID: 1665 RVA: 0x0002ECEC File Offset: 0x0002CEEC
		// Note: this type is marked as 'beforefieldinit'.
		static TypedParameterExpression()
		{
			Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "TypedParameterExpression");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr);
			TypedParameterExpression.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr, "<Type>k__BackingField");
			TypedParameterExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr, 100664609);
			TypedParameterExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr, 100664610);
		}

		// Token: 0x06000682 RID: 1666 RVA: 0x0002ED58 File Offset: 0x0002CF58
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1014667, RefRangeEnd = 1014668, XrefRangeStart = 1014661, XrefRangeEnd = 1014667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedParameterExpression(Type type, string name)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedParameterExpression>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedParameterExpression.NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x0002EDB8 File Offset: 0x0002CFB8
		public unsafe override Type Type
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedParameterExpression.NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x00003AA3 File Offset: 0x00001CA3
		public TypedParameterExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x0002EDF8 File Offset: 0x0002CFF8
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00003AAC File Offset: 0x00001CAC
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedParameterExpression.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedParameterExpression.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400052B RID: 1323
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400052C RID: 1324
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Type_String_0;

		// Token: 0x0400052D RID: 1325
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_Virtual_Final_get_Type_0;
	}
}
