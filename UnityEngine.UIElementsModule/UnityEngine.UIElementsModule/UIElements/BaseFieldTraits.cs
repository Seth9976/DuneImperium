using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000067 RID: 103
	public class BaseFieldTraits<TValueType, TValueUxmlAttributeType> : BaseField<TValueType>.UxmlTraits where TValueUxmlAttributeType : TypedUxmlAttributeDescription<TValueType>, new()
	{
		// Token: 0x0600099E RID: 2462 RVA: 0x0003F084 File Offset: 0x0003D284
		// Note: this type is marked as 'beforefieldinit'.
		static BaseFieldTraits()
		{
			Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseFieldTraits`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValueUxmlAttributeType>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr);
			BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, "m_Value");
			BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, 100664659);
			BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr, 100664660);
		}

		// Token: 0x0600099F RID: 2463 RVA: 0x0003F140 File Offset: 0x0003D340
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296508, RefRangeEnd = 296510, XrefRangeStart = 296490, XrefRangeEnd = 296508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ve);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bag);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cc));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x0003F1B8 File Offset: 0x0003D3B8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 296562, RefRangeEnd = 296564, XrefRangeStart = 296510, XrefRangeEnd = 296562, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseFieldTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseFieldTraits<TValueType, TValueUxmlAttributeType>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00005740 File Offset: 0x00003940
		public BaseFieldTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x0003F1F4 File Offset: 0x0003D3F4
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x0003F21C File Offset: 0x0003D41C
		public unsafe TValueUxmlAttributeType m_Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_Value);
				return IL2CPP.PointerToValueGeneric<TValueUxmlAttributeType>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseFieldTraits<TValueType, TValueUxmlAttributeType>.NativeFieldInfoPtr_m_Value);
				Type typeFromHandle = typeof(TValueUxmlAttributeType);
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

		// Token: 0x040006B1 RID: 1713
		private static readonly IntPtr NativeFieldInfoPtr_m_Value;

		// Token: 0x040006B2 RID: 1714
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Virtual_Void_VisualElement_IUxmlAttributes_CreationContext_0;

		// Token: 0x040006B3 RID: 1715
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
