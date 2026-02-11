using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Dynamic;
using Il2CppSystem.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000053 RID: 83
	public static class DynamicUtils : Object
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x000045EB File Offset: 0x000027EB
		// Note: this type is marked as 'beforefieldinit'.
		static DynamicUtils()
		{
			Il2CppClassPointerStore<DynamicUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "DynamicUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicUtils>.NativeClassPtr);
			DynamicUtils.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Static_IEnumerable_1_String_IDynamicMetaObjectProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils>.NativeClassPtr, 100664813);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00037094 File Offset: 0x00035294
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743070, RefRangeEnd = 743071, XrefRangeStart = 743061, XrefRangeEnd = 743070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerable<string> GetDynamicMemberNames(this IDynamicMetaObjectProvider dynamicProvider)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(dynamicProvider);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.NativeMethodInfoPtr_GetDynamicMemberNames_Public_Static_IEnumerable_1_String_IDynamicMetaObjectProvider_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable<string>>(intPtr3) : null;
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x00004624 File Offset: 0x00002824
		public DynamicUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006CB RID: 1739
		private static readonly IntPtr NativeMethodInfoPtr_GetDynamicMemberNames_Public_Static_IEnumerable_1_String_IDynamicMetaObjectProvider_0;

		// Token: 0x02000190 RID: 400
		public static class BinderWrapper : Object
		{
			// Token: 0x06001CE6 RID: 7398 RVA: 0x00087C50 File Offset: 0x00085E50
			// Note: this type is marked as 'beforefieldinit'.
			static BinderWrapper()
			{
				Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DynamicUtils>.NativeClassPtr, "BinderWrapper");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr);
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpAssemblyName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "CSharpAssemblyName");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr_BinderTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "BinderTypeName");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "CSharpArgumentInfoTypeName");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoFlagsTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "CSharpArgumentInfoFlagsTypeName");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpBinderFlagsTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "CSharpBinderFlagsTypeName");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getCSharpArgumentInfoArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "_getCSharpArgumentInfoArray");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setCSharpArgumentInfoArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "_setCSharpArgumentInfoArray");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getMemberCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "_getMemberCall");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setMemberCall = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "_setMemberCall");
				DynamicUtils.BinderWrapper.NativeFieldInfoPtr__init = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, "_init");
				DynamicUtils.BinderWrapper.NativeMethodInfoPtr_Init_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, 100664814);
				DynamicUtils.BinderWrapper.NativeMethodInfoPtr_CreateSharpArgumentInfoArray_Private_Static_Object_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, 100664815);
				DynamicUtils.BinderWrapper.NativeMethodInfoPtr_CreateMemberCalls_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, 100664816);
				DynamicUtils.BinderWrapper.NativeMethodInfoPtr_GetMember_Public_Static_CallSiteBinder_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, 100664817);
				DynamicUtils.BinderWrapper.NativeMethodInfoPtr_SetMember_Public_Static_CallSiteBinder_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicUtils.BinderWrapper>.NativeClassPtr, 100664818);
			}

			// Token: 0x06001CE7 RID: 7399 RVA: 0x00087DA8 File Offset: 0x00085FA8
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 742871, RefRangeEnd = 742873, XrefRangeStart = 742843, XrefRangeEnd = 742871, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void Init()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.BinderWrapper.NativeMethodInfoPtr_Init_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CE8 RID: 7400 RVA: 0x00087DD0 File Offset: 0x00085FD0
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 742915, RefRangeEnd = 742917, XrefRangeStart = 742873, XrefRangeEnd = 742915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static Object CreateSharpArgumentInfoArray([Optional] Il2CppStructArray<int> values)
			{
				if (values == null)
				{
					values = new Il2CppStructArray<int>(0L);
				}
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(values);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.BinderWrapper.NativeMethodInfoPtr_CreateSharpArgumentInfoArray_Private_Static_Object_Il2CppStructArray_1_Int32_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001CE9 RID: 7401 RVA: 0x00087E24 File Offset: 0x00086024
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 743018, RefRangeEnd = 743019, XrefRangeStart = 742917, XrefRangeEnd = 743018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void CreateMemberCalls()
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.BinderWrapper.NativeMethodInfoPtr_CreateMemberCalls_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001CEA RID: 7402 RVA: 0x00087E4C File Offset: 0x0008604C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 743039, RefRangeEnd = 743040, XrefRangeStart = 743019, XrefRangeEnd = 743039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static CallSiteBinder GetMember(string name, Type context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.BinderWrapper.NativeMethodInfoPtr_GetMember_Public_Static_CallSiteBinder_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteBinder>(intPtr3) : null;
			}

			// Token: 0x06001CEB RID: 7403 RVA: 0x00087EA4 File Offset: 0x000860A4
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 743060, RefRangeEnd = 743061, XrefRangeStart = 743040, XrefRangeEnd = 743060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static CallSiteBinder SetMember(string name, Type context)
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DynamicUtils.BinderWrapper.NativeMethodInfoPtr_SetMember_Public_Static_CallSiteBinder_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CallSiteBinder>(intPtr3) : null;
			}

			// Token: 0x06001CEC RID: 7404 RVA: 0x0000E400 File Offset: 0x0000C600
			public static Object CreateSharpArgumentInfoArray(params int[] values)
			{
				return DynamicUtils.BinderWrapper.CreateSharpArgumentInfoArray(new Il2CppStructArray<int>(values));
			}

			// Token: 0x06001CED RID: 7405 RVA: 0x0000E40D File Offset: 0x0000C60D
			public BinderWrapper(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000824 RID: 2084
			// (get) Token: 0x06001CEE RID: 7406 RVA: 0x00087EFC File Offset: 0x000860FC
			// (set) Token: 0x06001CEF RID: 7407 RVA: 0x0000E416 File Offset: 0x0000C616
			public unsafe static string CSharpAssemblyName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpAssemblyName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpAssemblyName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000825 RID: 2085
			// (get) Token: 0x06001CF0 RID: 7408 RVA: 0x00087F1C File Offset: 0x0008611C
			// (set) Token: 0x06001CF1 RID: 7409 RVA: 0x0000E428 File Offset: 0x0000C628
			public unsafe static string BinderTypeName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_BinderTypeName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_BinderTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000826 RID: 2086
			// (get) Token: 0x06001CF2 RID: 7410 RVA: 0x00087F3C File Offset: 0x0008613C
			// (set) Token: 0x06001CF3 RID: 7411 RVA: 0x0000E43A File Offset: 0x0000C63A
			public unsafe static string CSharpArgumentInfoTypeName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoTypeName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000827 RID: 2087
			// (get) Token: 0x06001CF4 RID: 7412 RVA: 0x00087F5C File Offset: 0x0008615C
			// (set) Token: 0x06001CF5 RID: 7413 RVA: 0x0000E44C File Offset: 0x0000C64C
			public unsafe static string CSharpArgumentInfoFlagsTypeName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoFlagsTypeName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpArgumentInfoFlagsTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000828 RID: 2088
			// (get) Token: 0x06001CF6 RID: 7414 RVA: 0x00087F7C File Offset: 0x0008617C
			// (set) Token: 0x06001CF7 RID: 7415 RVA: 0x0000E45E File Offset: 0x0000C65E
			public unsafe static string CSharpBinderFlagsTypeName
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpBinderFlagsTypeName, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr_CSharpBinderFlagsTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17000829 RID: 2089
			// (get) Token: 0x06001CF8 RID: 7416 RVA: 0x00087F9C File Offset: 0x0008619C
			// (set) Token: 0x06001CF9 RID: 7417 RVA: 0x0000E470 File Offset: 0x0000C670
			public unsafe static Object _getCSharpArgumentInfoArray
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getCSharpArgumentInfoArray, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getCSharpArgumentInfoArray, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082A RID: 2090
			// (get) Token: 0x06001CFA RID: 7418 RVA: 0x00087FC4 File Offset: 0x000861C4
			// (set) Token: 0x06001CFB RID: 7419 RVA: 0x0000E482 File Offset: 0x0000C682
			public unsafe static Object _setCSharpArgumentInfoArray
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setCSharpArgumentInfoArray, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setCSharpArgumentInfoArray, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082B RID: 2091
			// (get) Token: 0x06001CFC RID: 7420 RVA: 0x00087FEC File Offset: 0x000861EC
			// (set) Token: 0x06001CFD RID: 7421 RVA: 0x0000E494 File Offset: 0x0000C694
			public unsafe static MethodCall<Object, Object> _getMemberCall
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getMemberCall, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__getMemberCall, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082C RID: 2092
			// (get) Token: 0x06001CFE RID: 7422 RVA: 0x00088014 File Offset: 0x00086214
			// (set) Token: 0x06001CFF RID: 7423 RVA: 0x0000E4A6 File Offset: 0x0000C6A6
			public unsafe static MethodCall<Object, Object> _setMemberCall
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setMemberCall, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__setMemberCall, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001D00 RID: 7424 RVA: 0x0008803C File Offset: 0x0008623C
			// (set) Token: 0x06001D01 RID: 7425 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
			public unsafe static bool _init
			{
				get
				{
					bool flag;
					IL2CPP.il2cpp_field_static_get_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__init, (void*)(&flag));
					return flag;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DynamicUtils.BinderWrapper.NativeFieldInfoPtr__init, (void*)(&value));
				}
			}

			// Token: 0x04001560 RID: 5472
			private static readonly IntPtr NativeFieldInfoPtr_CSharpAssemblyName;

			// Token: 0x04001561 RID: 5473
			private static readonly IntPtr NativeFieldInfoPtr_BinderTypeName;

			// Token: 0x04001562 RID: 5474
			private static readonly IntPtr NativeFieldInfoPtr_CSharpArgumentInfoTypeName;

			// Token: 0x04001563 RID: 5475
			private static readonly IntPtr NativeFieldInfoPtr_CSharpArgumentInfoFlagsTypeName;

			// Token: 0x04001564 RID: 5476
			private static readonly IntPtr NativeFieldInfoPtr_CSharpBinderFlagsTypeName;

			// Token: 0x04001565 RID: 5477
			private static readonly IntPtr NativeFieldInfoPtr__getCSharpArgumentInfoArray;

			// Token: 0x04001566 RID: 5478
			private static readonly IntPtr NativeFieldInfoPtr__setCSharpArgumentInfoArray;

			// Token: 0x04001567 RID: 5479
			private static readonly IntPtr NativeFieldInfoPtr__getMemberCall;

			// Token: 0x04001568 RID: 5480
			private static readonly IntPtr NativeFieldInfoPtr__setMemberCall;

			// Token: 0x04001569 RID: 5481
			private static readonly IntPtr NativeFieldInfoPtr__init;

			// Token: 0x0400156A RID: 5482
			private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Static_Void_0;

			// Token: 0x0400156B RID: 5483
			private static readonly IntPtr NativeMethodInfoPtr_CreateSharpArgumentInfoArray_Private_Static_Object_Il2CppStructArray_1_Int32_0;

			// Token: 0x0400156C RID: 5484
			private static readonly IntPtr NativeMethodInfoPtr_CreateMemberCalls_Private_Static_Void_0;

			// Token: 0x0400156D RID: 5485
			private static readonly IntPtr NativeMethodInfoPtr_GetMember_Public_Static_CallSiteBinder_String_Type_0;

			// Token: 0x0400156E RID: 5486
			private static readonly IntPtr NativeMethodInfoPtr_SetMember_Public_Static_CallSiteBinder_String_Type_0;
		}
	}
}
