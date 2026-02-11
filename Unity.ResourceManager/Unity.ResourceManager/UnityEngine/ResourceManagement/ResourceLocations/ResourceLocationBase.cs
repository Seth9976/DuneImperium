using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.ResourceManagement.ResourceLocations
{
	// Token: 0x02000048 RID: 72
	public class ResourceLocationBase : Object
	{
		// Token: 0x0600037C RID: 892 RVA: 0x000127A8 File Offset: 0x000109A8
		// Note: this type is marked as 'beforefieldinit'.
		static ResourceLocationBase()
		{
			Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.ResourceLocations", "ResourceLocationBase");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr);
			ResourceLocationBase.NativeFieldInfoPtr_m_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_Name");
			ResourceLocationBase.NativeFieldInfoPtr_m_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_Id");
			ResourceLocationBase.NativeFieldInfoPtr_m_ProviderId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_ProviderId");
			ResourceLocationBase.NativeFieldInfoPtr_m_Data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_Data");
			ResourceLocationBase.NativeFieldInfoPtr_m_DependencyHashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_DependencyHashCode");
			ResourceLocationBase.NativeFieldInfoPtr_m_HashCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_HashCode");
			ResourceLocationBase.NativeFieldInfoPtr_m_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_Type");
			ResourceLocationBase.NativeFieldInfoPtr_m_Dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_Dependencies");
			ResourceLocationBase.NativeFieldInfoPtr_m_PrimaryKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, "m_PrimaryKey");
			ResourceLocationBase.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663900);
			ResourceLocationBase.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663901);
			ResourceLocationBase.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663902);
			ResourceLocationBase.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663903);
			ResourceLocationBase.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663904);
			ResourceLocationBase.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663905);
			ResourceLocationBase.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663906);
			ResourceLocationBase.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663907);
			ResourceLocationBase.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663908);
			ResourceLocationBase.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663909);
			ResourceLocationBase.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663910);
			ResourceLocationBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663911);
			ResourceLocationBase.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Type_Il2CppReferenceArray_1_IResourceLocation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663912);
			ResourceLocationBase.NativeMethodInfoPtr_ComputeDependencyHash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr, 100663913);
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600037D RID: 893 RVA: 0x000129A4 File Offset: 0x00010BA4
		public unsafe virtual string InternalId
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000129DC File Offset: 0x00010BDC
		public unsafe virtual string ProviderId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600037F RID: 895 RVA: 0x00012A14 File Offset: 0x00010C14
		public unsafe virtual IList<IResourceLocation> Dependencies
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IList<IResourceLocation>>(intPtr3) : null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00012A54 File Offset: 0x00010C54
		public unsafe virtual bool HasDependencies
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1141379, XrefRangeEnd = 1141380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000381 RID: 897 RVA: 0x00012A90 File Offset: 0x00010C90
		// (set) Token: 0x06000382 RID: 898 RVA: 0x00012AD0 File Offset: 0x00010CD0
		public unsafe virtual Object Data
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000383 RID: 899 RVA: 0x00012B14 File Offset: 0x00010D14
		// (set) Token: 0x06000384 RID: 900 RVA: 0x00012B4C File Offset: 0x00010D4C
		public unsafe virtual string PrimaryKey
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00012B90 File Offset: 0x00010D90
		public unsafe virtual int DependencyHashCode
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 137950, RefRangeEnd = 137951, XrefRangeStart = 137950, XrefRangeEnd = 137951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00012BCC File Offset: 0x00010DCC
		public unsafe virtual Type ResourceType
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00012C0C File Offset: 0x00010E0C
		[CallerCount(0)]
		public unsafe virtual int Hash(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00012C5C File Offset: 0x00010E5C
		[CallerCount(15)]
		[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ResourceLocationBase.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00012CA0 File Offset: 0x00010EA0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 1141418, RefRangeEnd = 1141427, XrefRangeStart = 1141380, XrefRangeEnd = 1141418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ResourceLocationBase(string name, string id, string providerId, Type t, [Optional] Il2CppReferenceArray<IResourceLocation> dependencies)
		{
			if (dependencies == null)
			{
				dependencies = new Il2CppReferenceArray<IResourceLocation>(0L);
			}
			this..ctor(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ResourceLocationBase>.NativeClassPtr));
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(providerId);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(dependencies);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Type_Il2CppReferenceArray_1_IResourceLocation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00012D44 File Offset: 0x00010F44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1141452, RefRangeEnd = 1141454, XrefRangeStart = 1141427, XrefRangeEnd = 1141452, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ComputeDependencyHash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ResourceLocationBase.NativeMethodInfoPtr_ComputeDependencyHash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000035F4 File Offset: 0x000017F4
		public ResourceLocationBase(string name, string id, string providerId, Type t, params IResourceLocation[] dependencies)
			: this(name, id, providerId, t, new Il2CppReferenceArray<IResourceLocation>(dependencies))
		{
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00003608 File Offset: 0x00001808
		public ResourceLocationBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00012D78 File Offset: 0x00010F78
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00003611 File Offset: 0x00001811
		public unsafe string m_Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00012DA0 File Offset: 0x00010FA0
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00003630 File Offset: 0x00001830
		public unsafe string m_Id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Id);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Id), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00012DC8 File Offset: 0x00010FC8
		// (set) Token: 0x06000392 RID: 914 RVA: 0x0000364F File Offset: 0x0000184F
		public unsafe string m_ProviderId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_ProviderId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_ProviderId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00012DF0 File Offset: 0x00010FF0
		// (set) Token: 0x06000394 RID: 916 RVA: 0x0000366E File Offset: 0x0000186E
		public unsafe Object m_Data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00012E20 File Offset: 0x00011020
		// (set) Token: 0x06000396 RID: 918 RVA: 0x0000368D File Offset: 0x0000188D
		public unsafe int m_DependencyHashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_DependencyHashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_DependencyHashCode)) = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00012E48 File Offset: 0x00011048
		// (set) Token: 0x06000398 RID: 920 RVA: 0x000036A8 File Offset: 0x000018A8
		public unsafe int m_HashCode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_HashCode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_HashCode)) = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00012E70 File Offset: 0x00011070
		// (set) Token: 0x0600039A RID: 922 RVA: 0x000036C3 File Offset: 0x000018C3
		public unsafe Type m_Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00012EA0 File Offset: 0x000110A0
		// (set) Token: 0x0600039C RID: 924 RVA: 0x000036E2 File Offset: 0x000018E2
		public unsafe List<IResourceLocation> m_Dependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Dependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IResourceLocation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_Dependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039D RID: 925 RVA: 0x00012ED0 File Offset: 0x000110D0
		// (set) Token: 0x0600039E RID: 926 RVA: 0x00003701 File Offset: 0x00001901
		public unsafe string m_PrimaryKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_PrimaryKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ResourceLocationBase.NativeFieldInfoPtr_m_PrimaryKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000261 RID: 609
		private static readonly IntPtr NativeFieldInfoPtr_m_Name;

		// Token: 0x04000262 RID: 610
		private static readonly IntPtr NativeFieldInfoPtr_m_Id;

		// Token: 0x04000263 RID: 611
		private static readonly IntPtr NativeFieldInfoPtr_m_ProviderId;

		// Token: 0x04000264 RID: 612
		private static readonly IntPtr NativeFieldInfoPtr_m_Data;

		// Token: 0x04000265 RID: 613
		private static readonly IntPtr NativeFieldInfoPtr_m_DependencyHashCode;

		// Token: 0x04000266 RID: 614
		private static readonly IntPtr NativeFieldInfoPtr_m_HashCode;

		// Token: 0x04000267 RID: 615
		private static readonly IntPtr NativeFieldInfoPtr_m_Type;

		// Token: 0x04000268 RID: 616
		private static readonly IntPtr NativeFieldInfoPtr_m_Dependencies;

		// Token: 0x04000269 RID: 617
		private static readonly IntPtr NativeFieldInfoPtr_m_PrimaryKey;

		// Token: 0x0400026A RID: 618
		private static readonly IntPtr NativeMethodInfoPtr_get_InternalId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400026B RID: 619
		private static readonly IntPtr NativeMethodInfoPtr_get_ProviderId_Public_Virtual_Final_New_get_String_0;

		// Token: 0x0400026C RID: 620
		private static readonly IntPtr NativeMethodInfoPtr_get_Dependencies_Public_Virtual_Final_New_get_IList_1_IResourceLocation_0;

		// Token: 0x0400026D RID: 621
		private static readonly IntPtr NativeMethodInfoPtr_get_HasDependencies_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x0400026E RID: 622
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x0400026F RID: 623
		private static readonly IntPtr NativeMethodInfoPtr_set_Data_Public_set_Void_Object_0;

		// Token: 0x04000270 RID: 624
		private static readonly IntPtr NativeMethodInfoPtr_get_PrimaryKey_Public_Virtual_Final_New_get_String_0;

		// Token: 0x04000271 RID: 625
		private static readonly IntPtr NativeMethodInfoPtr_set_PrimaryKey_Public_set_Void_String_0;

		// Token: 0x04000272 RID: 626
		private static readonly IntPtr NativeMethodInfoPtr_get_DependencyHashCode_Public_Virtual_Final_New_get_Int32_0;

		// Token: 0x04000273 RID: 627
		private static readonly IntPtr NativeMethodInfoPtr_get_ResourceType_Public_Virtual_Final_New_get_Type_0;

		// Token: 0x04000274 RID: 628
		private static readonly IntPtr NativeMethodInfoPtr_Hash_Public_Virtual_Final_New_Int32_Type_0;

		// Token: 0x04000275 RID: 629
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000276 RID: 630
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_String_Type_Il2CppReferenceArray_1_IResourceLocation_0;

		// Token: 0x04000277 RID: 631
		private static readonly IntPtr NativeMethodInfoPtr_ComputeDependencyHash_Public_Void_0;
	}
}
