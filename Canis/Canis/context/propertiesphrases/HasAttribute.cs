using System;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.context.propertiesphrases
{
	// Token: 0x02000140 RID: 320
	public class HasAttribute<T> : PropertiesPhrase
	{
		// Token: 0x06000E5C RID: 3676 RVA: 0x0005631C File Offset: 0x0005451C
		// Note: this type is marked as 'beforefieldinit'.
		static HasAttribute()
		{
			Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.propertiesphrases", "HasAttribute`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr);
			HasAttribute<T>.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr, "attribute");
			HasAttribute<T>.NativeFieldInfoPtr_expectedValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr, "expectedValue");
			HasAttribute<T>.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_T_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr, 100666419);
			HasAttribute<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr, 100666420);
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000563D8 File Offset: 0x000545D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577391, XrefRangeEnd = 577398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HasAttribute(AttributeDefinition<T> attribute, T expectedValue)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HasAttribute<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = expectedValue;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref expectedValue;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(HasAttribute<T>.NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_T_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06000E5E RID: 3678 RVA: 0x0005646C File Offset: 0x0005466C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577398, XrefRangeEnd = 577414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Evaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), HasAttribute<T>.NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E5F RID: 3679 RVA: 0x00007417 File Offset: 0x00005617
		public HasAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x000564C4 File Offset: 0x000546C4
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00007420 File Offset: 0x00005620
		public unsafe AttributeDefinition<T> attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAttribute<T>.NativeFieldInfoPtr_attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AttributeDefinition<T>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAttribute<T>.NativeFieldInfoPtr_attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000564F4 File Offset: 0x000546F4
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x0005651C File Offset: 0x0005471C
		public unsafe T expectedValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAttribute<T>.NativeFieldInfoPtr_expectedValue);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HasAttribute<T>.NativeFieldInfoPtr_expectedValue);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x040009B6 RID: 2486
		private static readonly IntPtr NativeFieldInfoPtr_attribute;

		// Token: 0x040009B7 RID: 2487
		private static readonly IntPtr NativeFieldInfoPtr_expectedValue;

		// Token: 0x040009B8 RID: 2488
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AttributeDefinition_1_T_T_0;

		// Token: 0x040009B9 RID: 2489
		private static readonly IntPtr NativeMethodInfoPtr_Evaluate_Public_Virtual_Boolean_Context_0;
	}
}
