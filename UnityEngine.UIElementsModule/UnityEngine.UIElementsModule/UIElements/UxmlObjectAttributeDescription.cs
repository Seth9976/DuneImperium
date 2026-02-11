using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000202 RID: 514
	public class UxmlObjectAttributeDescription<T> : Object where T : new()
	{
		// Token: 0x060027EC RID: 10220 RVA: 0x000AFB50 File Offset: 0x000ADD50
		// Note: this type is marked as 'beforefieldinit'.
		static UxmlObjectAttributeDescription()
		{
			Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "UxmlObjectAttributeDescription`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr);
			UxmlObjectAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr, "<defaultValue>k__BackingField");
			UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr_get_defaultValue_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr, 100669314);
			UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_New_T_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr, 100669315);
			UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr, 100669316);
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000AFC0C File Offset: 0x000ADE0C
		// (set) Token: 0x060027F3 RID: 10227 RVA: 0x0001026A File Offset: 0x0000E46A
		public unsafe T defaultValue
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr_get_defaultValue_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			set
			{
				this._defaultValue_k__BackingField = value;
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000AFC48 File Offset: 0x000ADE48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344002, XrefRangeEnd = 344013, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_New_T_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000AFCB4 File Offset: 0x000ADEB4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UxmlObjectAttributeDescription()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UxmlObjectAttributeDescription<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UxmlObjectAttributeDescription<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x00010261 File Offset: 0x0000E461
		public UxmlObjectAttributeDescription(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x000AFCF0 File Offset: 0x000ADEF0
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x000AFD18 File Offset: 0x000ADF18
		public unsafe T _defaultValue_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlObjectAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UxmlObjectAttributeDescription<T>.NativeFieldInfoPtr__defaultValue_k__BackingField);
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

		// Token: 0x04001C54 RID: 7252
		private static readonly IntPtr NativeFieldInfoPtr__defaultValue_k__BackingField;

		// Token: 0x04001C55 RID: 7253
		private static readonly IntPtr NativeMethodInfoPtr_get_defaultValue_Public_get_T_0;

		// Token: 0x04001C56 RID: 7254
		private static readonly IntPtr NativeMethodInfoPtr_GetValueFromBag_Public_Virtual_New_T_IUxmlAttributes_CreationContext_0;

		// Token: 0x04001C57 RID: 7255
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
