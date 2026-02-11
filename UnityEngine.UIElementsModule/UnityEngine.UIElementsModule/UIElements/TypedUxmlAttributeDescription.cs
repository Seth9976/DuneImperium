using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x020001F6 RID: 502
	public class TypedUxmlAttributeDescription<T> : UxmlAttributeDescription
	{
		// Token: 0x06002794 RID: 10132 RVA: 0x000AE3B0 File Offset: 0x000AC5B0
		// Note: this type is marked as 'beforefieldinit'.
		static TypedUxmlAttributeDescription()
		{
			Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "TypedUxmlAttributeDescription`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr);
			TypedUxmlAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr, "<defaultValue>k__BackingField");
			TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr, 100669240);
			TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_get_defaultValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr, 100669241);
			TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_set_defaultValue_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr, 100669242);
			TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr, 100669243);
		}

		// Token: 0x06002795 RID: 10133 RVA: 0x000AE480 File Offset: 0x000AC680
		[CallerCount(0)]
		public unsafe virtual T GetValueFromBag(IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(bag);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x000AE4EC File Offset: 0x000AC6EC
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x000AE528 File Offset: 0x000AC728
		public unsafe T defaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_get_defaultValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr_set_defaultValue_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x000AE5A0 File Offset: 0x000AC7A0
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 343255, RefRangeEnd = 343266, XrefRangeStart = 343254, XrefRangeEnd = 343255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedUxmlAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedUxmlAttributeDescription<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedUxmlAttributeDescription<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x00010190 File Offset: 0x0000E390
		public TypedUxmlAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600279A RID: 10138 RVA: 0x000AE5DC File Offset: 0x000AC7DC
		// (set) Token: 0x0600279B RID: 10139 RVA: 0x000AE604 File Offset: 0x000AC804
		public unsafe T _defaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedUxmlAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedUxmlAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField);
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

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600279C RID: 10140 RVA: 0x000AE6AC File Offset: 0x000AC8AC
		public override string defaultValueAsString
		{
			get
			{
				T defaultValue = this.defaultValue;
				return defaultValue.ToString();
			}
		}

		// Token: 0x04001C2A RID: 7210
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue_k__BackingField;

		// Token: 0x04001C2B RID: 7211
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Abstract_Virtual_New_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C2C RID: 7212
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_get_T_0;

		// Token: 0x04001C2D RID: 7213
		private static readonly IntPtr NativeMethodInfoPtr_set_defaultValue_Public_set_Void_T_0;

		// Token: 0x04001C2E RID: 7214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
