using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x0200012E RID: 302
	public class TypeDescriptionProvider : Object
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x00062C10 File Offset: 0x00060E10
		// Note: this type is marked as 'beforefieldinit'.
		static TypeDescriptionProvider()
		{
			Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "TypeDescriptionProvider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr);
			TypeDescriptionProvider.NativeFieldInfoPtr__parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, "_parent");
			TypeDescriptionProvider.NativeFieldInfoPtr__emptyDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, "_emptyDescriptor");
			TypeDescriptionProvider.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665978);
			TypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665979);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_New_IDictionary_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665980);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665981);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665982);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665983);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_New_Type_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665984);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665985);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665986);
			TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, 100665987);
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00062D30 File Offset: 0x00060F30
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeDescriptionProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProvider.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00062D6C File Offset: 0x00060F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460525, XrefRangeEnd = 460530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object CreateInstance(IServiceProvider provider, Type objectType, Il2CppReferenceArray<Type> argTypes, Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(provider);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(argTypes);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00062E00 File Offset: 0x00061000
		[CallerCount(0)]
		public unsafe virtual IDictionary GetCache(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_GetCache_Public_Virtual_New_IDictionary_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionary>(intPtr3) : null;
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00062E5C File Offset: 0x0006105C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460530, XrefRangeEnd = 460535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ICustomTypeDescriptor GetExtendedTypeDescriptor(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00062EB8 File Offset: 0x000610B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460535, XrefRangeEnd = 460545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppReferenceArray<IExtenderProvider> GetExtenderProviders(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<IExtenderProvider>>(intPtr3) : null;
			}
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x00062F14 File Offset: 0x00061114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460545, RefRangeEnd = 460546, XrefRangeStart = 460545, XrefRangeEnd = 460545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetReflectionType(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x00062F64 File Offset: 0x00061164
		[CallerCount(0)]
		public unsafe virtual Type GetReflectionType(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_GetReflectionType_Public_Virtual_New_Type_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x00062FD4 File Offset: 0x000611D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 460546, RefRangeEnd = 460550, XrefRangeStart = 460546, XrefRangeEnd = 460546, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICustomTypeDescriptor GetTypeDescriptor(Type objectType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x00063024 File Offset: 0x00061224
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 460557, RefRangeEnd = 460558, XrefRangeStart = 460550, XrefRangeEnd = 460557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ICustomTypeDescriptor GetTypeDescriptor(Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
			}
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x00063074 File Offset: 0x00061274
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 460558, XrefRangeEnd = 460563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual ICustomTypeDescriptor GetTypeDescriptor(Type objectType, Object instance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(objectType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypeDescriptionProvider.NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Type_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICustomTypeDescriptor>(intPtr3) : null;
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x00008754 File Offset: 0x00006954
		public TypeDescriptionProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x000630E4 File Offset: 0x000612E4
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x0000875D File Offset: 0x0000695D
		public unsafe TypeDescriptionProvider _parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProvider.NativeFieldInfoPtr__parent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptionProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProvider.NativeFieldInfoPtr__parent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x00063114 File Offset: 0x00061314
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x0000877C File Offset: 0x0000697C
		public unsafe TypeDescriptionProvider.EmptyCustomTypeDescriptor _emptyDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProvider.NativeFieldInfoPtr__emptyDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TypeDescriptionProvider.EmptyCustomTypeDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeDescriptionProvider.NativeFieldInfoPtr__emptyDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000EA3 RID: 3747
		private static readonly IntPtr NativeFieldInfoPtr__parent;

		// Token: 0x04000EA4 RID: 3748
		private static readonly IntPtr NativeFieldInfoPtr__emptyDescriptor;

		// Token: 0x04000EA5 RID: 3749
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000EA6 RID: 3750
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Virtual_New_Object_IServiceProvider_Type_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000EA7 RID: 3751
		private static readonly IntPtr NativeMethodInfoPtr_GetCache_Public_Virtual_New_IDictionary_Object_0;

		// Token: 0x04000EA8 RID: 3752
		private static readonly IntPtr NativeMethodInfoPtr_GetExtendedTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Object_0;

		// Token: 0x04000EA9 RID: 3753
		private static readonly IntPtr NativeMethodInfoPtr_GetExtenderProviders_FamOrAssem_Virtual_New_Il2CppReferenceArray_1_IExtenderProvider_Object_0;

		// Token: 0x04000EAA RID: 3754
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Type_Type_0;

		// Token: 0x04000EAB RID: 3755
		private static readonly IntPtr NativeMethodInfoPtr_GetReflectionType_Public_Virtual_New_Type_Type_Object_0;

		// Token: 0x04000EAC RID: 3756
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Type_0;

		// Token: 0x04000EAD RID: 3757
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_ICustomTypeDescriptor_Object_0;

		// Token: 0x04000EAE RID: 3758
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeDescriptor_Public_Virtual_New_ICustomTypeDescriptor_Type_Object_0;

		// Token: 0x020002DE RID: 734
		public sealed class EmptyCustomTypeDescriptor : CustomTypeDescriptor
		{
			// Token: 0x06002C38 RID: 11320 RVA: 0x00013EBA File Offset: 0x000120BA
			// Note: this type is marked as 'beforefieldinit'.
			static EmptyCustomTypeDescriptor()
			{
				Il2CppClassPointerStore<TypeDescriptionProvider.EmptyCustomTypeDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TypeDescriptionProvider>.NativeClassPtr, "EmptyCustomTypeDescriptor");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeDescriptionProvider.EmptyCustomTypeDescriptor>.NativeClassPtr);
				TypeDescriptionProvider.EmptyCustomTypeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeDescriptionProvider.EmptyCustomTypeDescriptor>.NativeClassPtr, 100665988);
			}

			// Token: 0x06002C39 RID: 11321 RVA: 0x000C2D90 File Offset: 0x000C0F90
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmptyCustomTypeDescriptor()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeDescriptionProvider.EmptyCustomTypeDescriptor>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeDescriptionProvider.EmptyCustomTypeDescriptor.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002C3A RID: 11322 RVA: 0x00013EEE File Offset: 0x000120EE
			public EmptyCustomTypeDescriptor(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x040022EE RID: 8942
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
