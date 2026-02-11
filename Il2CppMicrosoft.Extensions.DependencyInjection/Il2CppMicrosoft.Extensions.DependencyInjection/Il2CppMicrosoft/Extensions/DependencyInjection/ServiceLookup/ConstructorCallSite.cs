using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x0200001D RID: 29
	public sealed class ConstructorCallSite : ServiceCallSite
	{
		// Token: 0x06000122 RID: 290 RVA: 0x000082CC File Offset: 0x000064CC
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructorCallSite()
		{
			Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ConstructorCallSite");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr);
			ConstructorCallSite.NativeFieldInfoPtr__ConstructorInfo_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, "<ConstructorInfo>k__BackingField");
			ConstructorCallSite.NativeFieldInfoPtr__ParameterCallSites_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, "<ParameterCallSites>k__BackingField");
			ConstructorCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, "<ServiceType>k__BackingField");
			ConstructorCallSite.NativeFieldInfoPtr__Kind_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, "<Kind>k__BackingField");
			ConstructorCallSite.NativeMethodInfoPtr_get_ConstructorInfo_Internal_get_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663504);
			ConstructorCallSite.NativeMethodInfoPtr_get_ParameterCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663505);
			ConstructorCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663506);
			ConstructorCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_Il2CppReferenceArray_1_ServiceCallSite_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663507);
			ConstructorCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663508);
			ConstructorCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663509);
			ConstructorCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr, 100663510);
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000123 RID: 291 RVA: 0x000083D8 File Offset: 0x000065D8
		public unsafe ConstructorInfo ConstructorInfo
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr_get_ConstructorInfo_Internal_get_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr3) : null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000124 RID: 292 RVA: 0x00008418 File Offset: 0x00006618
		public unsafe Il2CppReferenceArray<ServiceCallSite> ParameterCallSites
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr_get_ParameterCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceCallSite>>(intPtr3) : null;
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00008458 File Offset: 0x00006658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204580, XrefRangeEnd = 1204584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x000084CC File Offset: 0x000066CC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1204601, RefRangeEnd = 1204605, XrefRangeStart = 1204584, XrefRangeEnd = 1204601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructorCallSite(ResultCache cache, Type serviceType, ConstructorInfo constructorInfo, Il2CppReferenceArray<ServiceCallSite> parameterCallSites)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructorCallSite>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cache));
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(serviceType);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parameterCallSites);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_Il2CppReferenceArray_1_ServiceCallSite_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000127 RID: 295 RVA: 0x00008554 File Offset: 0x00006754
		public unsafe override Type ServiceType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000128 RID: 296 RVA: 0x00008594 File Offset: 0x00006794
		public unsafe override Type ImplementationType
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204605, XrefRangeEnd = 1204606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000129 RID: 297 RVA: 0x000085D4 File Offset: 0x000067D4
		public unsafe override CallSiteKind Kind
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructorCallSite.NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x000025DD File Offset: 0x000007DD
		public ConstructorCallSite(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600012B RID: 299 RVA: 0x00008610 File Offset: 0x00006810
		// (set) Token: 0x0600012C RID: 300 RVA: 0x000025E6 File Offset: 0x000007E6
		public unsafe ConstructorInfo _ConstructorInfo_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ConstructorInfo_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstructorInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ConstructorInfo_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00008640 File Offset: 0x00006840
		// (set) Token: 0x0600012E RID: 302 RVA: 0x00002605 File Offset: 0x00000805
		public unsafe Il2CppReferenceArray<ServiceCallSite> _ParameterCallSites_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ParameterCallSites_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ServiceCallSite>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ParameterCallSites_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00008670 File Offset: 0x00006870
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002624 File Offset: 0x00000824
		public unsafe Type _ServiceType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__ServiceType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000086A0 File Offset: 0x000068A0
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002643 File Offset: 0x00000843
		public unsafe CallSiteKind _Kind_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__Kind_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstructorCallSite.NativeFieldInfoPtr__Kind_k__BackingField)) = value;
			}
		}

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeFieldInfoPtr__ConstructorInfo_k__BackingField;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeFieldInfoPtr__ParameterCallSites_k__BackingField;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeFieldInfoPtr__ServiceType_k__BackingField;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeFieldInfoPtr__Kind_k__BackingField;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_get_ConstructorInfo_Internal_get_ConstructorInfo_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_get_ParameterCallSites_Internal_get_Il2CppReferenceArray_1_ServiceCallSite_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ResultCache_Type_ConstructorInfo_Il2CppReferenceArray_1_ServiceCallSite_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_get_ServiceType_Public_Virtual_get_Type_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_get_ImplementationType_Public_Virtual_get_Type_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_get_Kind_Public_Virtual_get_CallSiteKind_0;
	}
}
