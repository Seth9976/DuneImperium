using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x0200020B RID: 523
	public class BaseUxmlFactory<TCreatedType, TTraits> : Object where TCreatedType : new() where TTraits : BaseUxmlTraits, new()
	{
		// Token: 0x06002817 RID: 10263 RVA: 0x000B053C File Offset: 0x000AE73C
		// Note: this type is marked as 'beforefieldinit'.
		static BaseUxmlFactory()
		{
			Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseUxmlFactory`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TCreatedType>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTraits>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeFieldInfoPtr_m_Traits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, "m_Traits");
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669330);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669331);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669332);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669333);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlType_Public_Virtual_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669334);
			BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_AcceptsAttributeBag_Public_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr, 100669335);
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x000B0648 File Offset: 0x000AE848
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 344046, RefRangeEnd = 344053, XrefRangeStart = 344038, XrefRangeEnd = 344046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseUxmlFactory()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseUxmlFactory<TCreatedType, TTraits>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C84 RID: 3204
		// (get) Token: 0x06002819 RID: 10265 RVA: 0x000B0684 File Offset: 0x000AE884
		public unsafe virtual string uxmlName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344053, XrefRangeEnd = 344058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C85 RID: 3205
		// (get) Token: 0x0600281A RID: 10266 RVA: 0x000B06C8 File Offset: 0x000AE8C8
		public unsafe virtual string uxmlNamespace
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344058, XrefRangeEnd = 344064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600281B RID: 10267 RVA: 0x000B070C File Offset: 0x000AE90C
		public unsafe virtual string uxmlQualifiedName
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344064, XrefRangeEnd = 344078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000C87 RID: 3207
		// (get) Token: 0x0600281C RID: 10268 RVA: 0x000B0750 File Offset: 0x000AE950
		public unsafe virtual Type uxmlType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 344078, XrefRangeEnd = 344087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_get_uxmlType_Public_Virtual_New_get_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600281D RID: 10269 RVA: 0x000B079C File Offset: 0x000AE99C
		[CallerCount(0)]
		public unsafe virtual bool AcceptsAttributeBag(IUxmlAttributes bag, CreationContext cc)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseUxmlFactory<TCreatedType, TTraits>.NativeMethodInfoPtr_AcceptsAttributeBag_Public_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600281E RID: 10270 RVA: 0x0001034F File Offset: 0x0000E54F
		public BaseUxmlFactory(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C83 RID: 3203
		// (get) Token: 0x0600281F RID: 10271 RVA: 0x000B080C File Offset: 0x000AEA0C
		// (set) Token: 0x06002820 RID: 10272 RVA: 0x000B0834 File Offset: 0x000AEA34
		public unsafe TTraits m_Traits
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUxmlFactory<TCreatedType, TTraits>.NativeFieldInfoPtr_m_Traits);
				return IL2CPP.PointerToValueGeneric<TTraits>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUxmlFactory<TCreatedType, TTraits>.NativeFieldInfoPtr_m_Traits);
				Type typeFromHandle = typeof(TTraits);
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

		// Token: 0x17000C88 RID: 3208
		// (get) Token: 0x06002821 RID: 10273 RVA: 0x000B08DC File Offset: 0x000AEADC
		public bool canHaveAnyAttribute
		{
			get
			{
				return this.m_Traits.canHaveAnyAttribute;
			}
		}

		// Token: 0x17000C89 RID: 3209
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x000B0900 File Offset: 0x000AEB00
		public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription
		{
			get
			{
				return this.m_Traits.uxmlAttributesDescription;
			}
		}

		// Token: 0x17000C8A RID: 3210
		// (get) Token: 0x06002823 RID: 10275 RVA: 0x000B0924 File Offset: 0x000AEB24
		public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				return this.m_Traits.uxmlChildElementsDescription;
			}
		}

		// Token: 0x17000C8B RID: 3211
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x000B0948 File Offset: 0x000AEB48
		public virtual string substituteForTypeName
		{
			get
			{
				bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TCreatedType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>());
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Name;
				}
				return text;
			}
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x06002825 RID: 10277 RVA: 0x000B0990 File Offset: 0x000AEB90
		public virtual string substituteForTypeNamespace
		{
			get
			{
				bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TCreatedType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>());
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).Namespace ?? String.Empty;
				}
				return text;
			}
		}

		// Token: 0x17000C8D RID: 3213
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x000B09E0 File Offset: 0x000AEBE0
		public virtual string substituteForTypeQualifiedName
		{
			get
			{
				bool flag = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TCreatedType>()) == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>());
				string text;
				if (flag)
				{
					text = String.Empty;
				}
				else
				{
					text = Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<VisualElement>()).FullName;
				}
				return text;
			}
		}

		// Token: 0x04001C66 RID: 7270
		private static readonly IntPtr NativeFieldInfoPtr_m_Traits;

		// Token: 0x04001C67 RID: 7271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C68 RID: 7272
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlName_Public_Virtual_New_get_String_0;

		// Token: 0x04001C69 RID: 7273
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04001C6A RID: 7274
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlQualifiedName_Public_Virtual_New_get_String_0;

		// Token: 0x04001C6B RID: 7275
		private static readonly IntPtr NativeMethodInfoPtr_get_uxmlType_Public_Virtual_New_get_Type_0;

		// Token: 0x04001C6C RID: 7276
		private static readonly IntPtr NativeMethodInfoPtr_AcceptsAttributeBag_Public_Virtual_New_Boolean_IUxmlAttributes_CreationContext_0;
	}
}
