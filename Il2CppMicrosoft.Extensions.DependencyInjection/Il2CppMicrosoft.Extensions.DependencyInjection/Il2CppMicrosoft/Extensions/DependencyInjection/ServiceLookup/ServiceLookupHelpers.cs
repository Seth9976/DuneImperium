using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Il2CppMicrosoft.Extensions.DependencyInjection.ServiceLookup
{
	// Token: 0x02000027 RID: 39
	public static class ServiceLookupHelpers : Object
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x0000A248 File Offset: 0x00008448
		// Note: this type is marked as 'beforefieldinit'.
		static ServiceLookupHelpers()
		{
			Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Microsoft.Extensions.DependencyInjection.dll", "Microsoft.Extensions.DependencyInjection.ServiceLookup", "ServiceLookupHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr);
			ServiceLookupHelpers.NativeFieldInfoPtr_ArrayEmptyMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "ArrayEmptyMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_InvokeFactoryMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "InvokeFactoryMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_CaptureDisposableMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "CaptureDisposableMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_TryGetValueMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "TryGetValueMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_ResolveCallSiteAndScopeMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "ResolveCallSiteAndScopeMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_AddMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "AddMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_MonitorEnterMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "MonitorEnterMethodInfo");
			ServiceLookupHelpers.NativeFieldInfoPtr_MonitorExitMethodInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, "MonitorExitMethodInfo");
			ServiceLookupHelpers.NativeMethodInfoPtr_GetArrayEmptyMethodInfo_Internal_Static_MethodInfo_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServiceLookupHelpers>.NativeClassPtr, 100663577);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000A32C File Offset: 0x0000852C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1204872, XrefRangeEnd = 1204986, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetArrayEmptyMethodInfo(Type itemType)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ServiceLookupHelpers.NativeMethodInfoPtr_GetArrayEmptyMethodInfo_Internal_Static_MethodInfo_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
			}
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002904 File Offset: 0x00000B04
		public ServiceLookupHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000A370 File Offset: 0x00008570
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000290D File Offset: 0x00000B0D
		public unsafe static MethodInfo ArrayEmptyMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_ArrayEmptyMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_ArrayEmptyMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000A398 File Offset: 0x00008598
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000291F File Offset: 0x00000B1F
		public unsafe static MethodInfo InvokeFactoryMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_InvokeFactoryMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_InvokeFactoryMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000A3C0 File Offset: 0x000085C0
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002931 File Offset: 0x00000B31
		public unsafe static MethodInfo CaptureDisposableMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_CaptureDisposableMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_CaptureDisposableMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000A3E8 File Offset: 0x000085E8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002943 File Offset: 0x00000B43
		public unsafe static MethodInfo TryGetValueMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_TryGetValueMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_TryGetValueMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000A410 File Offset: 0x00008610
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002955 File Offset: 0x00000B55
		public unsafe static MethodInfo ResolveCallSiteAndScopeMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_ResolveCallSiteAndScopeMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_ResolveCallSiteAndScopeMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000A438 File Offset: 0x00008638
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002967 File Offset: 0x00000B67
		public unsafe static MethodInfo AddMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_AddMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_AddMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000A460 File Offset: 0x00008660
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x00002979 File Offset: 0x00000B79
		public unsafe static MethodInfo MonitorEnterMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_MonitorEnterMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_MonitorEnterMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x0000A488 File Offset: 0x00008688
		// (set) Token: 0x060001B6 RID: 438 RVA: 0x0000298B File Offset: 0x00000B8B
		public unsafe static MethodInfo MonitorExitMethodInfo
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ServiceLookupHelpers.NativeFieldInfoPtr_MonitorExitMethodInfo, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ServiceLookupHelpers.NativeFieldInfoPtr_MonitorExitMethodInfo, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400013F RID: 319
		private static readonly IntPtr NativeFieldInfoPtr_ArrayEmptyMethodInfo;

		// Token: 0x04000140 RID: 320
		private static readonly IntPtr NativeFieldInfoPtr_InvokeFactoryMethodInfo;

		// Token: 0x04000141 RID: 321
		private static readonly IntPtr NativeFieldInfoPtr_CaptureDisposableMethodInfo;

		// Token: 0x04000142 RID: 322
		private static readonly IntPtr NativeFieldInfoPtr_TryGetValueMethodInfo;

		// Token: 0x04000143 RID: 323
		private static readonly IntPtr NativeFieldInfoPtr_ResolveCallSiteAndScopeMethodInfo;

		// Token: 0x04000144 RID: 324
		private static readonly IntPtr NativeFieldInfoPtr_AddMethodInfo;

		// Token: 0x04000145 RID: 325
		private static readonly IntPtr NativeFieldInfoPtr_MonitorEnterMethodInfo;

		// Token: 0x04000146 RID: 326
		private static readonly IntPtr NativeFieldInfoPtr_MonitorExitMethodInfo;

		// Token: 0x04000147 RID: 327
		private static readonly IntPtr NativeMethodInfoPtr_GetArrayEmptyMethodInfo_Internal_Static_MethodInfo_Type_0;
	}
}
