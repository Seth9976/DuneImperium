using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Linq.Expressions
{
	// Token: 0x02000060 RID: 96
	public sealed class FullExpression<TDelegate> : ExpressionN<TDelegate>
	{
		// Token: 0x06000570 RID: 1392 RVA: 0x0002AC58 File Offset: 0x00028E58
		// Note: this type is marked as 'beforefieldinit'.
		static FullExpression()
		{
			Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("System.Core.dll", "System.Linq.Expressions", "FullExpression`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TDelegate>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr);
			FullExpression<TDelegate>.NativeFieldInfoPtr__NameCore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr, "<NameCore>k__BackingField");
			FullExpression<TDelegate>.NativeFieldInfoPtr__TailCallCore_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr, "<TailCallCore>k__BackingField");
			FullExpression<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_String_Boolean_IReadOnlyList_1_ParameterExpression_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr, 100664492);
			FullExpression<TDelegate>.NativeMethodInfoPtr_get_NameCore_Internal_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr, 100664493);
			FullExpression<TDelegate>.NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr, 100664494);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x0002AD28 File Offset: 0x00028F28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1014198, XrefRangeEnd = 1014199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FullExpression(Expression body, string name, bool tailCall, IReadOnlyList<ParameterExpression> parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullExpression<TDelegate>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(body);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref tailCall;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameters);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullExpression<TDelegate>.NativeMethodInfoPtr__ctor_Public_Void_Expression_String_Boolean_IReadOnlyList_1_ParameterExpression_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0002ADA8 File Offset: 0x00028FA8
		public unsafe override string NameCore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullExpression<TDelegate>.NativeMethodInfoPtr_get_NameCore_Internal_Virtual_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000573 RID: 1395 RVA: 0x0002ADE0 File Offset: 0x00028FE0
		public unsafe override bool TailCallCore
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FullExpression<TDelegate>.NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x000033E3 File Offset: 0x000015E3
		public FullExpression(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x0002AE1C File Offset: 0x0002901C
		// (set) Token: 0x06000576 RID: 1398 RVA: 0x000033EC File Offset: 0x000015EC
		public unsafe string _NameCore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullExpression<TDelegate>.NativeFieldInfoPtr__NameCore_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullExpression<TDelegate>.NativeFieldInfoPtr__NameCore_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000577 RID: 1399 RVA: 0x0002AE44 File Offset: 0x00029044
		// (set) Token: 0x06000578 RID: 1400 RVA: 0x0000340B File Offset: 0x0000160B
		public unsafe bool _TailCallCore_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullExpression<TDelegate>.NativeFieldInfoPtr__TailCallCore_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FullExpression<TDelegate>.NativeFieldInfoPtr__TailCallCore_k__BackingField)) = value;
			}
		}

		// Token: 0x04000483 RID: 1155
		private static readonly IntPtr NativeFieldInfoPtr__NameCore_k__BackingField;

		// Token: 0x04000484 RID: 1156
		private static readonly IntPtr NativeFieldInfoPtr__TailCallCore_k__BackingField;

		// Token: 0x04000485 RID: 1157
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Expression_String_Boolean_IReadOnlyList_1_ParameterExpression_0;

		// Token: 0x04000486 RID: 1158
		private static readonly IntPtr NativeMethodInfoPtr_get_NameCore_Internal_Virtual_get_String_0;

		// Token: 0x04000487 RID: 1159
		private static readonly IntPtr NativeMethodInfoPtr_get_TailCallCore_Internal_Virtual_get_Boolean_0;
	}
}
