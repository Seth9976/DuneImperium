using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection
{
	// Token: 0x02000017 RID: 23
	public class ServiceDescriptor : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00003870 File Offset: 0x00001A70
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceDescriptor()
		{
			Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.Abstractions.dll", "Microsoft.Extensions.DependencyInjection", "ServiceDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr);
			ServiceDescriptor.NativeFieldInfoPtr__Lifetime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "<Lifetime>k__BackingField");
			ServiceDescriptor.NativeFieldInfoPtr__ServiceKey_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "<ServiceKey>k__BackingField");
			ServiceDescriptor.NativeFieldInfoPtr__ServiceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "<ServiceType>k__BackingField");
			ServiceDescriptor.NativeFieldInfoPtr__implementationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "_implementationType");
			ServiceDescriptor.NativeFieldInfoPtr__implementationInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "_implementationInstance");
			ServiceDescriptor.NativeFieldInfoPtr__implementationFactory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, "_implementationFactory");
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663344);
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Type_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663345);
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663346);
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663347);
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663348);
			ServiceDescriptor.NativeMethodInfoPtr__ctor_Private_Void_Type_Object_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663349);
			ServiceDescriptor.NativeMethodInfoPtr_get_Lifetime_Public_get_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663350);
			ServiceDescriptor.NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663351);
			ServiceDescriptor.NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663352);
			ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663353);
			ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationType_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663354);
			ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationInstance_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663355);
			ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationInstance_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663356);
			ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationFactory_Public_get_Func_2_IServiceProvider_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663357);
			ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationFactory_Public_get_Func_3_IServiceProvider_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663358);
			ServiceDescriptor.NativeMethodInfoPtr_get_IsKeyedService_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663359);
			ServiceDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663360);
			ServiceDescriptor.NativeMethodInfoPtr_GetImplementationType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663361);
			ServiceDescriptor.NativeMethodInfoPtr_Transient_Public_Static_ServiceDescriptor_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663362);
			ServiceDescriptor.NativeMethodInfoPtr_Scoped_Public_Static_ServiceDescriptor_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663363);
			ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663364);
			ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663365);
			ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_TService_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663366);
			ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663367);
			ServiceDescriptor.NativeMethodInfoPtr_DescribeKeyed_Private_Static_ServiceDescriptor_Object_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663368);
			ServiceDescriptor.NativeMethodInfoPtr_Describe_Public_Static_ServiceDescriptor_Type_Type_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663369);
			ServiceDescriptor.NativeMethodInfoPtr_DescribeKeyed_Public_Static_ServiceDescriptor_Type_Object_Type_ServiceLifetime_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663370);
			ServiceDescriptor.NativeMethodInfoPtr_ThrowKeyedDescriptor_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663371);
			ServiceDescriptor.NativeMethodInfoPtr_ThrowNonKeyedDescriptor_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr, 100663372);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00003B5C File Offset: 0x00001D5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265214, XrefRangeEnd = 1265224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Type implementationType, ServiceLifetime lifetime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Type_ServiceLifetime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00003BC8 File Offset: 0x00001DC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265224, XrefRangeEnd = 1265234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Object serviceKey, Type implementationType, ServiceLifetime lifetime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Type_ServiceLifetime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00003C48 File Offset: 0x00001E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265234, XrefRangeEnd = 1265244, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Object instance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003CA8 File Offset: 0x00001EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265244, XrefRangeEnd = 1265254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Object serviceKey, Object instance)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(instance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003D18 File Offset: 0x00001F18
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265254, XrefRangeEnd = 1265264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Func<IServiceProvider, Object> factory, ServiceLifetime lifetime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(factory);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Public_Void_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00003D84 File Offset: 0x00001F84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265264, XrefRangeEnd = 1265267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ServiceDescriptor(Type serviceType, Object serviceKey, ServiceLifetime lifetime)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr__ctor_Private_Void_Type_Object_ServiceLifetime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000073 RID: 115 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public unsafe ServiceLifetime Lifetime
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 302497, RefRangeEnd = 302502, XrefRangeStart = 302497, XrefRangeEnd = 302502, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_Lifetime_Public_get_ServiceLifetime_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000074 RID: 116 RVA: 0x00003E2C File Offset: 0x0000202C
		public unsafe Object ServiceKey
		{
			[CallerCount(15)]
			[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000075 RID: 117 RVA: 0x00003E6C File Offset: 0x0000206C
		public unsafe Type ServiceType
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000076 RID: 118 RVA: 0x00003EAC File Offset: 0x000020AC
		public unsafe Type ImplementationType
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1265267, RefRangeEnd = 1265275, XrefRangeStart = 1265267, XrefRangeEnd = 1265267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000077 RID: 119 RVA: 0x00003EEC File Offset: 0x000020EC
		public unsafe Type KeyedImplementationType
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 1265275, RefRangeEnd = 1265283, XrefRangeStart = 1265275, XrefRangeEnd = 1265275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationType_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000078 RID: 120 RVA: 0x00003F2C File Offset: 0x0000212C
		public unsafe Object ImplementationInstance
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1265283, RefRangeEnd = 1265286, XrefRangeStart = 1265283, XrefRangeEnd = 1265283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationInstance_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000079 RID: 121 RVA: 0x00003F6C File Offset: 0x0000216C
		public unsafe Object KeyedImplementationInstance
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 1265286, RefRangeEnd = 1265290, XrefRangeStart = 1265286, XrefRangeEnd = 1265286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationInstance_Public_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00003FAC File Offset: 0x000021AC
		public unsafe Func<IServiceProvider, Object> ImplementationFactory
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1265292, RefRangeEnd = 1265294, XrefRangeStart = 1265290, XrefRangeEnd = 1265292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_ImplementationFactory_Public_get_Func_2_IServiceProvider_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600007B RID: 123 RVA: 0x00003FEC File Offset: 0x000021EC
		public unsafe Func<IServiceProvider, Object, Object> KeyedImplementationFactory
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 1265296, RefRangeEnd = 1265301, XrefRangeStart = 1265294, XrefRangeEnd = 1265296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_KeyedImplementationFactory_Public_get_Func_3_IServiceProvider_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<IServiceProvider, Object, Object>>(intPtr3) : null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000402C File Offset: 0x0000222C
		public unsafe bool IsKeyedService
		{
			[CallerCount(24)]
			[CachedScanResults(RefRangeStart = 318072, RefRangeEnd = 318096, XrefRangeStart = 318072, XrefRangeEnd = 318096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_get_IsKeyedService_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00004068 File Offset: 0x00002268
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265301, XrefRangeEnd = 1265370, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ServiceDescriptor.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000040AC File Offset: 0x000022AC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265377, RefRangeEnd = 1265379, XrefRangeStart = 1265370, XrefRangeEnd = 1265377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetImplementationType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_GetImplementationType_Internal_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x000040EC File Offset: 0x000022EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265390, RefRangeEnd = 1265391, XrefRangeStart = 1265379, XrefRangeEnd = 1265390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Transient(Type service, Type implementationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_Transient_Public_Static_ServiceDescriptor_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00004144 File Offset: 0x00002344
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265400, RefRangeEnd = 1265401, XrefRangeStart = 1265391, XrefRangeEnd = 1265400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Scoped(Type service, Type implementationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_Scoped_Public_Static_ServiceDescriptor_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000419C File Offset: 0x0000239C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265409, RefRangeEnd = 1265411, XrefRangeStart = 1265401, XrefRangeEnd = 1265409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Singleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.MethodInfoStoreGeneric_Singleton_Public_Static_ServiceDescriptor_0<TService, TImplementation>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000041D0 File Offset: 0x000023D0
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1265422, RefRangeEnd = 1265427, XrefRangeStart = 1265411, XrefRangeEnd = 1265422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Singleton(Type service, Type implementationType)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(service);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00004228 File Offset: 0x00002428
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1265449, RefRangeEnd = 1265452, XrefRangeStart = 1265427, XrefRangeEnd = 1265449, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Singleton<TService>(TService implementationInstance) where TService : class
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(TService).IsValueType)
				{
					TService tservice = implementationInstance;
					intPtr = ((tservice is string) ? IL2CPP.ManagedStringToIl2Cpp(tservice as string) : IL2CPP.Il2CppObjectBaseToPtr(tservice as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref implementationInstance;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.MethodInfoStoreGeneric_Singleton_Public_Static_ServiceDescriptor_TService_0<TService>.Pointer, 0, (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr2;
				return (intPtr4 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr4) : null;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000042A4 File Offset: 0x000024A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1265463, RefRangeEnd = 1265464, XrefRangeStart = 1265452, XrefRangeEnd = 1265463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Singleton(Type serviceType, Object implementationInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000042FC File Offset: 0x000024FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265464, XrefRangeEnd = 1265471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor DescribeKeyed<TService, TImplementation>(Object serviceKey, ServiceLifetime lifetime) where TService : class where TImplementation : class, TService
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.MethodInfoStoreGeneric_DescribeKeyed_Private_Static_ServiceDescriptor_Object_ServiceLifetime_0<TService, TImplementation>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004350 File Offset: 0x00002550
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265471, XrefRangeEnd = 1265480, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor Describe(Type serviceType, Type implementationType, ServiceLifetime lifetime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_Describe_Public_Static_ServiceDescriptor_Type_Type_ServiceLifetime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x000043B4 File Offset: 0x000025B4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1265489, RefRangeEnd = 1265491, XrefRangeStart = 1265480, XrefRangeEnd = 1265489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ServiceDescriptor DescribeKeyed(Type serviceType, Object serviceKey, Type implementationType, ServiceLifetime lifetime)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceKey);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(implementationType);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref lifetime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_DescribeKeyed_Public_Static_ServiceDescriptor_Type_Object_Type_ServiceLifetime_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ServiceDescriptor>(intPtr3) : null;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000442C File Offset: 0x0000262C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265491, XrefRangeEnd = 1265499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowKeyedDescriptor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_ThrowKeyedDescriptor_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00004454 File Offset: 0x00002654
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1265499, XrefRangeEnd = 1265507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowNonKeyedDescriptor()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceDescriptor.NativeMethodInfoPtr_ThrowNonKeyedDescriptor_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00002389 File Offset: 0x00000589
		public ServiceDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600008B RID: 139 RVA: 0x0000447C File Offset: 0x0000267C
		// (set) Token: 0x0600008C RID: 140 RVA: 0x00002392 File Offset: 0x00000592
		public unsafe ServiceLifetime _Lifetime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__Lifetime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__Lifetime_k__BackingField)) = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000044A4 File Offset: 0x000026A4
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000023AD File Offset: 0x000005AD
		public unsafe Object _ServiceKey_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__ServiceKey_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__ServiceKey_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000044D4 File Offset: 0x000026D4
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000023CC File Offset: 0x000005CC
		public unsafe Type _ServiceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__ServiceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__ServiceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00004504 File Offset: 0x00002704
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000023EB File Offset: 0x000005EB
		public unsafe Type _implementationType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00004534 File Offset: 0x00002734
		// (set) Token: 0x06000094 RID: 148 RVA: 0x0000240A File Offset: 0x0000060A
		public unsafe Object _implementationInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00004564 File Offset: 0x00002764
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002429 File Offset: 0x00000629
		public unsafe Object _implementationFactory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationFactory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ServiceDescriptor.NativeFieldInfoPtr__implementationFactory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeFieldInfoPtr__Lifetime_k__BackingField;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeFieldInfoPtr__ServiceKey_k__BackingField;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeFieldInfoPtr__ServiceType_k__BackingField;

		// Token: 0x0400004C RID: 76
		private static readonly IntPtr NativeFieldInfoPtr__implementationType;

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeFieldInfoPtr__implementationInstance;

		// Token: 0x0400004E RID: 78
		private static readonly IntPtr NativeFieldInfoPtr__implementationFactory;

		// Token: 0x0400004F RID: 79
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Type_ServiceLifetime_0;

		// Token: 0x04000050 RID: 80
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Type_ServiceLifetime_0;

		// Token: 0x04000051 RID: 81
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_0;

		// Token: 0x04000052 RID: 82
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Object_Object_0;

		// Token: 0x04000053 RID: 83
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_Func_2_IServiceProvider_Object_ServiceLifetime_0;

		// Token: 0x04000054 RID: 84
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Type_Object_ServiceLifetime_0;

		// Token: 0x04000055 RID: 85
		private static readonly IntPtr NativeMethodInfoPtr_get_Lifetime_Public_get_ServiceLifetime_0;

		// Token: 0x04000056 RID: 86
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceKey_Public_get_Object_0;

		// Token: 0x04000057 RID: 87
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_get_Type_0;

		// Token: 0x04000058 RID: 88
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_get_Type_0;

		// Token: 0x04000059 RID: 89
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyedImplementationType_Public_get_Type_0;

		// Token: 0x0400005A RID: 90
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationInstance_Public_get_Object_0;

		// Token: 0x0400005B RID: 91
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyedImplementationInstance_Public_get_Object_0;

		// Token: 0x0400005C RID: 92
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationFactory_Public_get_Func_2_IServiceProvider_Object_0;

		// Token: 0x0400005D RID: 93
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyedImplementationFactory_Public_get_Func_3_IServiceProvider_Object_Object_0;

		// Token: 0x0400005E RID: 94
		private static readonly IntPtr NativeMethodInfoPtr_get_IsKeyedService_Public_get_Boolean_0;

		// Token: 0x0400005F RID: 95
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000060 RID: 96
		private static readonly IntPtr NativeMethodInfoPtr_GetImplementationType_Internal_Type_0;

		// Token: 0x04000061 RID: 97
		private static readonly IntPtr NativeMethodInfoPtr_Transient_Public_Static_ServiceDescriptor_Type_Type_0;

		// Token: 0x04000062 RID: 98
		private static readonly IntPtr NativeMethodInfoPtr_Scoped_Public_Static_ServiceDescriptor_Type_Type_0;

		// Token: 0x04000063 RID: 99
		private static readonly IntPtr NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_0;

		// Token: 0x04000064 RID: 100
		private static readonly IntPtr NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Type_0;

		// Token: 0x04000065 RID: 101
		private static readonly IntPtr NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_TService_0;

		// Token: 0x04000066 RID: 102
		private static readonly IntPtr NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_Type_Object_0;

		// Token: 0x04000067 RID: 103
		private static readonly IntPtr NativeMethodInfoPtr_DescribeKeyed_Private_Static_ServiceDescriptor_Object_ServiceLifetime_0;

		// Token: 0x04000068 RID: 104
		private static readonly IntPtr NativeMethodInfoPtr_Describe_Public_Static_ServiceDescriptor_Type_Type_ServiceLifetime_0;

		// Token: 0x04000069 RID: 105
		private static readonly IntPtr NativeMethodInfoPtr_DescribeKeyed_Public_Static_ServiceDescriptor_Type_Object_Type_ServiceLifetime_0;

		// Token: 0x0400006A RID: 106
		private static readonly IntPtr NativeMethodInfoPtr_ThrowKeyedDescriptor_Private_Static_Void_0;

		// Token: 0x0400006B RID: 107
		private static readonly IntPtr NativeMethodInfoPtr_ThrowNonKeyedDescriptor_Private_Static_Void_0;

		// Token: 0x0200001F RID: 31
		private sealed class MethodInfoStoreGeneric_Singleton_Public_Static_ServiceDescriptor_0<TService, TImplementation>
		{
			// Token: 0x04000077 RID: 119
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_0, Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TService>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TImplementation>.NativeClassPtr))
			}))));
		}

		// Token: 0x02000020 RID: 32
		private sealed class MethodInfoStoreGeneric_Singleton_Public_Static_ServiceDescriptor_TService_0<TService>
		{
			// Token: 0x04000078 RID: 120
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ServiceDescriptor.NativeMethodInfoPtr_Singleton_Public_Static_ServiceDescriptor_TService_0, Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TService>.NativeClassPtr)) }))));
		}

		// Token: 0x02000021 RID: 33
		private sealed class MethodInfoStoreGeneric_DescribeKeyed_Private_Static_ServiceDescriptor_Object_ServiceLifetime_0<TService, TImplementation>
		{
			// Token: 0x04000079 RID: 121
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ServiceDescriptor.NativeMethodInfoPtr_DescribeKeyed_Private_Static_ServiceDescriptor_Object_ServiceLifetime_0, Il2CppClassPointerStore<ServiceDescriptor>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TService>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TImplementation>.NativeClassPtr))
			}))));
		}
	}
}
