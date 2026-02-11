using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x0200044A RID: 1098
	[Serializable]
	public class RuntimeModule : Module
	{
		// Token: 0x06004008 RID: 16392 RVA: 0x00132D64 File Offset: 0x00130F64
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeModule()
		{
			Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RuntimeModule");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr);
			RuntimeModule.NativeFieldInfoPtr__impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "_impl");
			RuntimeModule.NativeFieldInfoPtr_assembly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "assembly");
			RuntimeModule.NativeFieldInfoPtr_fqname = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "fqname");
			RuntimeModule.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "name");
			RuntimeModule.NativeFieldInfoPtr_scopename = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "scopename");
			RuntimeModule.NativeFieldInfoPtr_is_resource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "is_resource");
			RuntimeModule.NativeFieldInfoPtr_token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, "token");
			RuntimeModule.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672954);
			RuntimeModule.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672955);
			RuntimeModule.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672956);
			RuntimeModule.NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672957);
			RuntimeModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672958);
			RuntimeModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672959);
			RuntimeModule.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672960);
			RuntimeModule.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672961);
			RuntimeModule.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672962);
			RuntimeModule.NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672963);
			RuntimeModule.NativeMethodInfoPtr_GetGuidInternal_Private_Static_Void_IntPtr_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672964);
			RuntimeModule.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr, 100672965);
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06004009 RID: 16393 RVA: 0x00132F10 File Offset: 0x00131110
		public unsafe override Assembly Assembly
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x0600400A RID: 16394 RVA: 0x00132F5C File Offset: 0x0013115C
		public unsafe override string ScopeName
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x0600400B RID: 16395 RVA: 0x00132FA0 File Offset: 0x001311A0
		public unsafe override Guid ModuleVersionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600400C RID: 16396 RVA: 0x00132FE8 File Offset: 0x001311E8
		[CallerCount(0)]
		public unsafe override bool IsResource()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600400D RID: 16397 RVA: 0x00133030 File Offset: 0x00131230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401837, XrefRangeEnd = 1401841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref inherit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600400E RID: 16398 RVA: 0x00133088 File Offset: 0x00131288
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401841, XrefRangeEnd = 1401845, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Object> GetCustomAttributes(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600400F RID: 16399 RVA: 0x001330F4 File Offset: 0x001312F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401845, XrefRangeEnd = 1401849, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefined(Type attributeType, bool inherit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributeType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref inherit;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004010 RID: 16400 RVA: 0x0013315C File Offset: 0x0013135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401849, XrefRangeEnd = 1401852, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004011 RID: 16401 RVA: 0x001331C0 File Offset: 0x001313C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401852, XrefRangeEnd = 1401854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeAssembly GetRuntimeAssembly()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeModule.NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RuntimeAssembly>(intPtr3) : null;
		}

		// Token: 0x06004012 RID: 16402 RVA: 0x00133200 File Offset: 0x00131400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401854, XrefRangeEnd = 1401859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Guid GetModuleVersionId()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RuntimeModule.NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004013 RID: 16403 RVA: 0x00133248 File Offset: 0x00131448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void GetGuidInternal(IntPtr module, Il2CppStructArray<byte> guid)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref module;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(guid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeModule.NativeMethodInfoPtr_GetGuidInternal_Private_Static_Void_IntPtr_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004014 RID: 16404 RVA: 0x0013328C File Offset: 0x0013148C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1401859, XrefRangeEnd = 1401863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeModule()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeModule>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeModule.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004015 RID: 16405 RVA: 0x00017495 File Offset: 0x00015695
		public RuntimeModule(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06004016 RID: 16406 RVA: 0x001332C8 File Offset: 0x001314C8
		// (set) Token: 0x06004017 RID: 16407 RVA: 0x0001749E File Offset: 0x0001569E
		public unsafe IntPtr _impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr__impl);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr__impl)) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06004018 RID: 16408 RVA: 0x001332F0 File Offset: 0x001314F0
		// (set) Token: 0x06004019 RID: 16409 RVA: 0x000174B9 File Offset: 0x000156B9
		public unsafe Assembly assembly
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_assembly);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_assembly), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x0600401A RID: 16410 RVA: 0x00133320 File Offset: 0x00131520
		// (set) Token: 0x0600401B RID: 16411 RVA: 0x000174D8 File Offset: 0x000156D8
		public unsafe string fqname
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_fqname);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_fqname), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x0600401C RID: 16412 RVA: 0x00133348 File Offset: 0x00131548
		// (set) Token: 0x0600401D RID: 16413 RVA: 0x000174F7 File Offset: 0x000156F7
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x0600401E RID: 16414 RVA: 0x00133370 File Offset: 0x00131570
		// (set) Token: 0x0600401F RID: 16415 RVA: 0x00017516 File Offset: 0x00015716
		public unsafe string scopename
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_scopename);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_scopename), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06004020 RID: 16416 RVA: 0x00133398 File Offset: 0x00131598
		// (set) Token: 0x06004021 RID: 16417 RVA: 0x00017535 File Offset: 0x00015735
		public unsafe bool is_resource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_is_resource);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_is_resource)) = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06004022 RID: 16418 RVA: 0x001333C0 File Offset: 0x001315C0
		// (set) Token: 0x06004023 RID: 16419 RVA: 0x00017550 File Offset: 0x00015750
		public unsafe int token
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_token);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeModule.NativeFieldInfoPtr_token)) = value;
			}
		}

		// Token: 0x040034B7 RID: 13495
		private static readonly IntPtr NativeFieldInfoPtr__impl;

		// Token: 0x040034B8 RID: 13496
		private static readonly IntPtr NativeFieldInfoPtr_assembly;

		// Token: 0x040034B9 RID: 13497
		private static readonly IntPtr NativeFieldInfoPtr_fqname;

		// Token: 0x040034BA RID: 13498
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x040034BB RID: 13499
		private static readonly IntPtr NativeFieldInfoPtr_scopename;

		// Token: 0x040034BC RID: 13500
		private static readonly IntPtr NativeFieldInfoPtr_is_resource;

		// Token: 0x040034BD RID: 13501
		private static readonly IntPtr NativeFieldInfoPtr_token;

		// Token: 0x040034BE RID: 13502
		private static readonly IntPtr NativeMethodInfoPtr_get_Assembly_Public_Virtual_get_Assembly_0;

		// Token: 0x040034BF RID: 13503
		private static readonly IntPtr NativeMethodInfoPtr_get_ScopeName_Public_Virtual_get_String_0;

		// Token: 0x040034C0 RID: 13504
		private static readonly IntPtr NativeMethodInfoPtr_get_ModuleVersionId_Public_Virtual_get_Guid_0;

		// Token: 0x040034C1 RID: 13505
		private static readonly IntPtr NativeMethodInfoPtr_IsResource_Public_Virtual_Boolean_0;

		// Token: 0x040034C2 RID: 13506
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Boolean_0;

		// Token: 0x040034C3 RID: 13507
		private static readonly IntPtr NativeMethodInfoPtr_GetCustomAttributes_Public_Virtual_Il2CppReferenceArray_1_Object_Type_Boolean_0;

		// Token: 0x040034C4 RID: 13508
		private static readonly IntPtr NativeMethodInfoPtr_IsDefined_Public_Virtual_Boolean_Type_Boolean_0;

		// Token: 0x040034C5 RID: 13509
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040034C6 RID: 13510
		private static readonly IntPtr NativeMethodInfoPtr_GetRuntimeAssembly_Internal_RuntimeAssembly_0;

		// Token: 0x040034C7 RID: 13511
		private static readonly IntPtr NativeMethodInfoPtr_GetModuleVersionId_Internal_Virtual_Guid_0;

		// Token: 0x040034C8 RID: 13512
		private static readonly IntPtr NativeMethodInfoPtr_GetGuidInternal_Private_Static_Void_IntPtr_Il2CppStructArray_1_Byte_0;

		// Token: 0x040034C9 RID: 13513
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
