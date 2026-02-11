using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200005A RID: 90
	public class FSharpUtils : Object
	{
		// Token: 0x06000800 RID: 2048 RVA: 0x00037E18 File Offset: 0x00036018
		// Note: this type is marked as 'beforefieldinit'.
		static FSharpUtils()
		{
			Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "FSharpUtils");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr);
			FSharpUtils.NativeFieldInfoPtr_Lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "Lock");
			FSharpUtils.NativeFieldInfoPtr__instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "_instance");
			FSharpUtils.NativeFieldInfoPtr__ofSeq = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "_ofSeq");
			FSharpUtils.NativeFieldInfoPtr__mapType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "_mapType");
			FSharpUtils.NativeFieldInfoPtr__FSharpCoreAssembly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<FSharpCoreAssembly>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__IsUnion_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<IsUnion>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__GetUnionCases_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<GetUnionCases>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__PreComputeUnionTagReader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<PreComputeUnionTagReader>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__PreComputeUnionReader_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<PreComputeUnionReader>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__PreComputeUnionConstructor_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<PreComputeUnionConstructor>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoDeclaringType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<GetUnionCaseInfoDeclaringType>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<GetUnionCaseInfoName>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoTag_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<GetUnionCaseInfoTag>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoFields_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<GetUnionCaseInfoFields>k__BackingField");
			FSharpUtils.NativeFieldInfoPtr_FSharpSetTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "FSharpSetTypeName");
			FSharpUtils.NativeFieldInfoPtr_FSharpListTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "FSharpListTypeName");
			FSharpUtils.NativeFieldInfoPtr_FSharpMapTypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "FSharpMapTypeName");
			FSharpUtils.NativeMethodInfoPtr__ctor_Private_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664846);
			FSharpUtils.NativeMethodInfoPtr_get_Instance_Public_Static_get_FSharpUtils_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664847);
			FSharpUtils.NativeMethodInfoPtr_get_FSharpCoreAssembly_Public_get_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664848);
			FSharpUtils.NativeMethodInfoPtr_set_FSharpCoreAssembly_Private_set_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664849);
			FSharpUtils.NativeMethodInfoPtr_get_IsUnion_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664850);
			FSharpUtils.NativeMethodInfoPtr_set_IsUnion_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664851);
			FSharpUtils.NativeMethodInfoPtr_get_GetUnionCases_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664852);
			FSharpUtils.NativeMethodInfoPtr_set_GetUnionCases_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664853);
			FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionTagReader_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664854);
			FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionTagReader_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664855);
			FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionReader_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664856);
			FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionReader_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664857);
			FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionConstructor_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664858);
			FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionConstructor_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664859);
			FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoDeclaringType_Public_get_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664860);
			FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoDeclaringType_Private_set_Void_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664861);
			FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoName_Public_get_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664862);
			FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoName_Private_set_Void_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664863);
			FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoTag_Public_get_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664864);
			FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoTag_Private_set_Void_Func_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664865);
			FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoFields_Public_get_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664866);
			FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoFields_Private_set_Void_MethodCall_2_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664867);
			FSharpUtils.NativeMethodInfoPtr_EnsureInitialized_Public_Static_Void_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664868);
			FSharpUtils.NativeMethodInfoPtr_GetMethodWithNonPublicFallback_Private_Static_MethodInfo_Type_String_BindingFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664869);
			FSharpUtils.NativeMethodInfoPtr_CreateFSharpFuncCall_Private_Static_MethodCall_2_Object_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664870);
			FSharpUtils.NativeMethodInfoPtr_CreateSeq_Public_ObjectConstructor_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664871);
			FSharpUtils.NativeMethodInfoPtr_CreateMap_Public_ObjectConstructor_1_Object_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664872);
			FSharpUtils.NativeMethodInfoPtr_BuildMapCreator_Public_ObjectConstructor_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, 100664873);
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x000381CC File Offset: 0x000363CC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743569, RefRangeEnd = 743570, XrefRangeStart = 743485, XrefRangeEnd = 743569, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FSharpUtils(Assembly fsharpCoreAssembly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsharpCoreAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr__ctor_Private_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00038218 File Offset: 0x00036418
		public unsafe static FSharpUtils Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743570, XrefRangeEnd = 743574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_Instance_Public_Static_get_FSharpUtils_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FSharpUtils>(intPtr3) : null;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0003824C File Offset: 0x0003644C
		// (set) Token: 0x06000804 RID: 2052 RVA: 0x0003828C File Offset: 0x0003648C
		public unsafe Assembly FSharpCoreAssembly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_FSharpCoreAssembly_Public_get_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_FSharpCoreAssembly_Private_set_Void_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x000382D0 File Offset: 0x000364D0
		// (set) Token: 0x06000806 RID: 2054 RVA: 0x00038310 File Offset: 0x00036510
		public unsafe MethodCall<Object, Object> IsUnion
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 31264, RefRangeEnd = 31268, XrefRangeStart = 31264, XrefRangeEnd = 31268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_IsUnion_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_IsUnion_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00038354 File Offset: 0x00036554
		// (set) Token: 0x06000808 RID: 2056 RVA: 0x00038394 File Offset: 0x00036594
		public unsafe MethodCall<Object, Object> GetUnionCases
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 131885, RefRangeEnd = 131899, XrefRangeStart = 131885, XrefRangeEnd = 131899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_GetUnionCases_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_GetUnionCases_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x000383D8 File Offset: 0x000365D8
		// (set) Token: 0x0600080A RID: 2058 RVA: 0x00038418 File Offset: 0x00036618
		public unsafe MethodCall<Object, Object> PreComputeUnionTagReader
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 139770, RefRangeEnd = 139777, XrefRangeStart = 139770, XrefRangeEnd = 139777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionTagReader_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionTagReader_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x0003845C File Offset: 0x0003665C
		// (set) Token: 0x0600080C RID: 2060 RVA: 0x0003849C File Offset: 0x0003669C
		public unsafe MethodCall<Object, Object> PreComputeUnionReader
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 329189, RefRangeEnd = 329190, XrefRangeStart = 329189, XrefRangeEnd = 329190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionReader_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionReader_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x000384E0 File Offset: 0x000366E0
		// (set) Token: 0x0600080E RID: 2062 RVA: 0x00038520 File Offset: 0x00036720
		public unsafe MethodCall<Object, Object> PreComputeUnionConstructor
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_PreComputeUnionConstructor_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_PreComputeUnionConstructor_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00038564 File Offset: 0x00036764
		// (set) Token: 0x06000810 RID: 2064 RVA: 0x000385A4 File Offset: 0x000367A4
		public unsafe Func<Object, Object> GetUnionCaseInfoDeclaringType
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 129671, RefRangeEnd = 129672, XrefRangeStart = 129671, XrefRangeEnd = 129672, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoDeclaringType_Public_get_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoDeclaringType_Private_set_Void_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x000385E8 File Offset: 0x000367E8
		// (set) Token: 0x06000812 RID: 2066 RVA: 0x00038628 File Offset: 0x00036828
		public unsafe Func<Object, Object> GetUnionCaseInfoName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoName_Public_get_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoName_Private_set_Void_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x0003866C File Offset: 0x0003686C
		// (set) Token: 0x06000814 RID: 2068 RVA: 0x000386AC File Offset: 0x000368AC
		public unsafe Func<Object, Object> GetUnionCaseInfoTag
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoTag_Public_get_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoTag_Private_set_Void_Func_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x000386F0 File Offset: 0x000368F0
		// (set) Token: 0x06000816 RID: 2070 RVA: 0x00038730 File Offset: 0x00036930
		public unsafe MethodCall<Object, Object> GetUnionCaseInfoFields
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_get_GetUnionCaseInfoFields_Public_get_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
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
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_set_GetUnionCaseInfoFields_Private_set_Void_MethodCall_2_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00038774 File Offset: 0x00036974
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743594, RefRangeEnd = 743597, XrefRangeStart = 743574, XrefRangeEnd = 743594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnsureInitialized(Assembly fsharpCoreAssembly)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fsharpCoreAssembly);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_EnsureInitialized_Public_Static_Void_Assembly_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x000387AC File Offset: 0x000369AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743597, XrefRangeEnd = 743600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodInfo GetMethodWithNonPublicFallback(Type type, string methodName, BindingFlags bindingFlags)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref bindingFlags;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_GetMethodWithNonPublicFallback_Private_Static_MethodInfo_Type_String_BindingFlags_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00038810 File Offset: 0x00036A10
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 743631, RefRangeEnd = 743634, XrefRangeStart = 743600, XrefRangeEnd = 743631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static MethodCall<Object, Object> CreateFSharpFuncCall(Type type, string methodName)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(methodName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_CreateFSharpFuncCall_Private_Static_MethodCall_2_Object_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr3) : null;
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00038868 File Offset: 0x00036A68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743647, RefRangeEnd = 743648, XrefRangeStart = 743634, XrefRangeEnd = 743647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectConstructor<Object> CreateSeq(Type t)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_CreateSeq_Public_ObjectConstructor_1_Object_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x000388B8 File Offset: 0x00036AB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 743667, RefRangeEnd = 743668, XrefRangeStart = 743648, XrefRangeEnd = 743667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectConstructor<Object> CreateMap(Type keyType, Type valueType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyType);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(valueType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.NativeMethodInfoPtr_CreateMap_Public_ObjectConstructor_1_Object_Type_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x0003891C File Offset: 0x00036B1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743668, XrefRangeEnd = 743698, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectConstructor<Object> BuildMapCreator<TKey, TValue>()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.MethodInfoStoreGeneric_BuildMapCreator_Public_ObjectConstructor_1_Object_0<TKey, TValue>.Pointer, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr3) : null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000047AD File Offset: 0x000029AD
		public FSharpUtils(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x0003895C File Offset: 0x00036B5C
		// (set) Token: 0x0600081F RID: 2079 RVA: 0x000047B6 File Offset: 0x000029B6
		public unsafe static Object Lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FSharpUtils.NativeFieldInfoPtr_Lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSharpUtils.NativeFieldInfoPtr_Lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00038984 File Offset: 0x00036B84
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x000047C8 File Offset: 0x000029C8
		public unsafe static FSharpUtils _instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FSharpUtils.NativeFieldInfoPtr__instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FSharpUtils>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSharpUtils.NativeFieldInfoPtr__instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000389AC File Offset: 0x00036BAC
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x000047DA File Offset: 0x000029DA
		public unsafe MethodInfo _ofSeq
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__ofSeq);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__ofSeq), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x000389DC File Offset: 0x00036BDC
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x000047F9 File Offset: 0x000029F9
		public unsafe Type _mapType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__mapType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__mapType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00038A0C File Offset: 0x00036C0C
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00004818 File Offset: 0x00002A18
		public unsafe Assembly _FSharpCoreAssembly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__FSharpCoreAssembly_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Assembly>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__FSharpCoreAssembly_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00038A3C File Offset: 0x00036C3C
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x00004837 File Offset: 0x00002A37
		public unsafe MethodCall<Object, Object> _IsUnion_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__IsUnion_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__IsUnion_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00038A6C File Offset: 0x00036C6C
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x00004856 File Offset: 0x00002A56
		public unsafe MethodCall<Object, Object> _GetUnionCases_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCases_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCases_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00038A9C File Offset: 0x00036C9C
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x00004875 File Offset: 0x00002A75
		public unsafe MethodCall<Object, Object> _PreComputeUnionTagReader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionTagReader_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionTagReader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00038ACC File Offset: 0x00036CCC
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x00004894 File Offset: 0x00002A94
		public unsafe MethodCall<Object, Object> _PreComputeUnionReader_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionReader_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionReader_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x00038AFC File Offset: 0x00036CFC
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x000048B3 File Offset: 0x00002AB3
		public unsafe MethodCall<Object, Object> _PreComputeUnionConstructor_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionConstructor_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__PreComputeUnionConstructor_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x00038B2C File Offset: 0x00036D2C
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x000048D2 File Offset: 0x00002AD2
		public unsafe Func<Object, Object> _GetUnionCaseInfoDeclaringType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoDeclaringType_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoDeclaringType_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00038B5C File Offset: 0x00036D5C
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x000048F1 File Offset: 0x00002AF1
		public unsafe Func<Object, Object> _GetUnionCaseInfoName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoName_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoName_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00038B8C File Offset: 0x00036D8C
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x00004910 File Offset: 0x00002B10
		public unsafe Func<Object, Object> _GetUnionCaseInfoTag_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoTag_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoTag_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00038BBC File Offset: 0x00036DBC
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0000492F File Offset: 0x00002B2F
		public unsafe MethodCall<Object, Object> _GetUnionCaseInfoFields_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoFields_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.NativeFieldInfoPtr__GetUnionCaseInfoFields_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00038BEC File Offset: 0x00036DEC
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0000494E File Offset: 0x00002B4E
		public unsafe static string FSharpSetTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FSharpUtils.NativeFieldInfoPtr_FSharpSetTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSharpUtils.NativeFieldInfoPtr_FSharpSetTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00038C0C File Offset: 0x00036E0C
		// (set) Token: 0x0600083D RID: 2109 RVA: 0x00004960 File Offset: 0x00002B60
		public unsafe static string FSharpListTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FSharpUtils.NativeFieldInfoPtr_FSharpListTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSharpUtils.NativeFieldInfoPtr_FSharpListTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00038C2C File Offset: 0x00036E2C
		// (set) Token: 0x0600083F RID: 2111 RVA: 0x00004972 File Offset: 0x00002B72
		public unsafe static string FSharpMapTypeName
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FSharpUtils.NativeFieldInfoPtr_FSharpMapTypeName, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FSharpUtils.NativeFieldInfoPtr_FSharpMapTypeName, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040006EC RID: 1772
		private static readonly IntPtr NativeFieldInfoPtr_Lock;

		// Token: 0x040006ED RID: 1773
		private static readonly IntPtr NativeFieldInfoPtr__instance;

		// Token: 0x040006EE RID: 1774
		private static readonly IntPtr NativeFieldInfoPtr__ofSeq;

		// Token: 0x040006EF RID: 1775
		private static readonly IntPtr NativeFieldInfoPtr__mapType;

		// Token: 0x040006F0 RID: 1776
		private static readonly IntPtr NativeFieldInfoPtr__FSharpCoreAssembly_k__BackingField;

		// Token: 0x040006F1 RID: 1777
		private static readonly IntPtr NativeFieldInfoPtr__IsUnion_k__BackingField;

		// Token: 0x040006F2 RID: 1778
		private static readonly IntPtr NativeFieldInfoPtr__GetUnionCases_k__BackingField;

		// Token: 0x040006F3 RID: 1779
		private static readonly IntPtr NativeFieldInfoPtr__PreComputeUnionTagReader_k__BackingField;

		// Token: 0x040006F4 RID: 1780
		private static readonly IntPtr NativeFieldInfoPtr__PreComputeUnionReader_k__BackingField;

		// Token: 0x040006F5 RID: 1781
		private static readonly IntPtr NativeFieldInfoPtr__PreComputeUnionConstructor_k__BackingField;

		// Token: 0x040006F6 RID: 1782
		private static readonly IntPtr NativeFieldInfoPtr__GetUnionCaseInfoDeclaringType_k__BackingField;

		// Token: 0x040006F7 RID: 1783
		private static readonly IntPtr NativeFieldInfoPtr__GetUnionCaseInfoName_k__BackingField;

		// Token: 0x040006F8 RID: 1784
		private static readonly IntPtr NativeFieldInfoPtr__GetUnionCaseInfoTag_k__BackingField;

		// Token: 0x040006F9 RID: 1785
		private static readonly IntPtr NativeFieldInfoPtr__GetUnionCaseInfoFields_k__BackingField;

		// Token: 0x040006FA RID: 1786
		private static readonly IntPtr NativeFieldInfoPtr_FSharpSetTypeName;

		// Token: 0x040006FB RID: 1787
		private static readonly IntPtr NativeFieldInfoPtr_FSharpListTypeName;

		// Token: 0x040006FC RID: 1788
		private static readonly IntPtr NativeFieldInfoPtr_FSharpMapTypeName;

		// Token: 0x040006FD RID: 1789
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Assembly_0;

		// Token: 0x040006FE RID: 1790
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_FSharpUtils_0;

		// Token: 0x040006FF RID: 1791
		private static readonly IntPtr NativeMethodInfoPtr_get_FSharpCoreAssembly_Public_get_Assembly_0;

		// Token: 0x04000700 RID: 1792
		private static readonly IntPtr NativeMethodInfoPtr_set_FSharpCoreAssembly_Private_set_Void_Assembly_0;

		// Token: 0x04000701 RID: 1793
		private static readonly IntPtr NativeMethodInfoPtr_get_IsUnion_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x04000702 RID: 1794
		private static readonly IntPtr NativeMethodInfoPtr_set_IsUnion_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x04000703 RID: 1795
		private static readonly IntPtr NativeMethodInfoPtr_get_GetUnionCases_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x04000704 RID: 1796
		private static readonly IntPtr NativeMethodInfoPtr_set_GetUnionCases_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x04000705 RID: 1797
		private static readonly IntPtr NativeMethodInfoPtr_get_PreComputeUnionTagReader_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x04000706 RID: 1798
		private static readonly IntPtr NativeMethodInfoPtr_set_PreComputeUnionTagReader_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x04000707 RID: 1799
		private static readonly IntPtr NativeMethodInfoPtr_get_PreComputeUnionReader_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x04000708 RID: 1800
		private static readonly IntPtr NativeMethodInfoPtr_set_PreComputeUnionReader_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x04000709 RID: 1801
		private static readonly IntPtr NativeMethodInfoPtr_get_PreComputeUnionConstructor_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x0400070A RID: 1802
		private static readonly IntPtr NativeMethodInfoPtr_set_PreComputeUnionConstructor_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x0400070B RID: 1803
		private static readonly IntPtr NativeMethodInfoPtr_get_GetUnionCaseInfoDeclaringType_Public_get_Func_2_Object_Object_0;

		// Token: 0x0400070C RID: 1804
		private static readonly IntPtr NativeMethodInfoPtr_set_GetUnionCaseInfoDeclaringType_Private_set_Void_Func_2_Object_Object_0;

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeMethodInfoPtr_get_GetUnionCaseInfoName_Public_get_Func_2_Object_Object_0;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeMethodInfoPtr_set_GetUnionCaseInfoName_Private_set_Void_Func_2_Object_Object_0;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeMethodInfoPtr_get_GetUnionCaseInfoTag_Public_get_Func_2_Object_Object_0;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr_set_GetUnionCaseInfoTag_Private_set_Void_Func_2_Object_Object_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_GetUnionCaseInfoFields_Public_get_MethodCall_2_Object_Object_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_set_GetUnionCaseInfoFields_Private_set_Void_MethodCall_2_Object_Object_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_EnsureInitialized_Public_Static_Void_Assembly_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodWithNonPublicFallback_Private_Static_MethodInfo_Type_String_BindingFlags_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_CreateFSharpFuncCall_Private_Static_MethodCall_2_Object_Object_Type_String_0;

		// Token: 0x04000716 RID: 1814
		private static readonly IntPtr NativeMethodInfoPtr_CreateSeq_Public_ObjectConstructor_1_Object_Type_0;

		// Token: 0x04000717 RID: 1815
		private static readonly IntPtr NativeMethodInfoPtr_CreateMap_Public_ObjectConstructor_1_Object_Type_Type_0;

		// Token: 0x04000718 RID: 1816
		private static readonly IntPtr NativeMethodInfoPtr_BuildMapCreator_Public_ObjectConstructor_1_Object_0;

		// Token: 0x02000194 RID: 404
		[ObfuscatedName("Newtonsoft.Json.Utilities.FSharpUtils+<>c__55`2")]
		[Serializable]
		public sealed class __c__55<TKey, TValue> : Object
		{
			// Token: 0x06001D13 RID: 7443 RVA: 0x0008838C File Offset: 0x0008658C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__55()
			{
				Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<>c__55`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr);
				FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr, "<>9");
				FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9__55_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr, "<>9__55_1");
				FSharpUtils.__c__55<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr, 100664876);
				FSharpUtils.__c__55<TKey, TValue>.NativeMethodInfoPtr__BuildMapCreator_b__55_1_Internal_Tuple_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr, 100664877);
			}

			// Token: 0x06001D14 RID: 7444 RVA: 0x00088454 File Offset: 0x00086654
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__55()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSharpUtils.__c__55<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__55<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D15 RID: 7445 RVA: 0x00088490 File Offset: 0x00086690
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743441, XrefRangeEnd = 743445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Tuple<TKey, TValue> _BuildMapCreator_b__55_1(KeyValuePair<TKey, TValue> kv)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(kv));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__55<TKey, TValue>.NativeMethodInfoPtr__BuildMapCreator_b__55_1_Internal_Tuple_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Tuple<TKey, TValue>>(intPtr3) : null;
				}
			}

			// Token: 0x06001D16 RID: 7446 RVA: 0x0000E520 File Offset: 0x0000C720
			public __c__55(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x06001D17 RID: 7447 RVA: 0x000884E8 File Offset: 0x000866E8
			// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0000E529 File Offset: 0x0000C729
			public unsafe static FSharpUtils.__c__55<TKey, TValue> __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FSharpUtils.__c__55<TKey, TValue>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x06001D19 RID: 7449 RVA: 0x00088510 File Offset: 0x00086710
			// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0000E53B File Offset: 0x0000C73B
			public unsafe static Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>> __9__55_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9__55_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<TKey, TValue>, Tuple<TKey, TValue>>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FSharpUtils.__c__55<TKey, TValue>.NativeFieldInfoPtr___9__55_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001578 RID: 5496
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001579 RID: 5497
			private static readonly IntPtr NativeFieldInfoPtr___9__55_1;

			// Token: 0x0400157A RID: 5498
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400157B RID: 5499
			private static readonly IntPtr NativeMethodInfoPtr__BuildMapCreator_b__55_1_Internal_Tuple_2_TKey_TValue_KeyValuePair_2_TKey_TValue_0;
		}

		// Token: 0x02000195 RID: 405
		[ObfuscatedName("Newtonsoft.Json.Utilities.FSharpUtils+<>c__DisplayClass52_0")]
		public sealed class __c__DisplayClass52_0 : Object
		{
			// Token: 0x06001D1B RID: 7451 RVA: 0x00088538 File Offset: 0x00086738
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass52_0()
			{
				Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<>c__DisplayClass52_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr);
				FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_call = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr, "call");
				FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_invoke = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr, "invoke");
				FSharpUtils.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr, 100664878);
				FSharpUtils.__c__DisplayClass52_0.NativeMethodInfoPtr__CreateFSharpFuncCall_b__0_Internal_Object_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr, 100664879);
			}

			// Token: 0x06001D1C RID: 7452 RVA: 0x000885B4 File Offset: 0x000867B4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass52_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass52_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__DisplayClass52_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D1D RID: 7453 RVA: 0x000885F0 File Offset: 0x000867F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743445, XrefRangeEnd = 743451, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _CreateFSharpFuncCall_b__0(Object target, Il2CppReferenceArray<Object> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__DisplayClass52_0.NativeMethodInfoPtr__CreateFSharpFuncCall_b__0_Internal_Object_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}

			// Token: 0x06001D1E RID: 7454 RVA: 0x0000E54D File Offset: 0x0000C74D
			public __c__DisplayClass52_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00088654 File Offset: 0x00086854
			// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0000E556 File Offset: 0x0000C756
			public unsafe MethodCall<Object, Object> call
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_call);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_call), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06001D21 RID: 7457 RVA: 0x00088684 File Offset: 0x00086884
			// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0000E575 File Offset: 0x0000C775
			public unsafe MethodCall<Object, Object> invoke
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_invoke);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MethodCall<Object, Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass52_0.NativeFieldInfoPtr_invoke), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400157C RID: 5500
			private static readonly IntPtr NativeFieldInfoPtr_call;

			// Token: 0x0400157D RID: 5501
			private static readonly IntPtr NativeFieldInfoPtr_invoke;

			// Token: 0x0400157E RID: 5502
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400157F RID: 5503
			private static readonly IntPtr NativeMethodInfoPtr__CreateFSharpFuncCall_b__0_Internal_Object_Object_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x02000196 RID: 406
		[ObfuscatedName("Newtonsoft.Json.Utilities.FSharpUtils+<>c__DisplayClass55_0`2")]
		public sealed class __c__DisplayClass55_0<TKey, TValue> : Object
		{
			// Token: 0x06001D23 RID: 7459 RVA: 0x000886B4 File Offset: 0x000868B4
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass55_0()
			{
				Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr, "<>c__DisplayClass55_0`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr);
				FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeFieldInfoPtr_ctorDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr, "ctorDelegate");
				FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr, 100664880);
				FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeMethodInfoPtr__BuildMapCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr, 100664881);
			}

			// Token: 0x06001D24 RID: 7460 RVA: 0x00088768 File Offset: 0x00086968
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass55_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FSharpUtils.__c__DisplayClass55_0<TKey, TValue>>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001D25 RID: 7461 RVA: 0x000887A4 File Offset: 0x000869A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 743451, XrefRangeEnd = 743485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Object _BuildMapCreator_b__0(Il2CppReferenceArray<Object> args)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeMethodInfoPtr__BuildMapCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001D26 RID: 7462 RVA: 0x0000E594 File Offset: 0x0000C794
			public __c__DisplayClass55_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000887F4 File Offset: 0x000869F4
			// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0000E59D File Offset: 0x0000C79D
			public unsafe ObjectConstructor<Object> ctorDelegate
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeFieldInfoPtr_ctorDelegate);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectConstructor<Object>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FSharpUtils.__c__DisplayClass55_0<TKey, TValue>.NativeFieldInfoPtr_ctorDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001580 RID: 5504
			private static readonly IntPtr NativeFieldInfoPtr_ctorDelegate;

			// Token: 0x04001581 RID: 5505
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001582 RID: 5506
			private static readonly IntPtr NativeMethodInfoPtr__BuildMapCreator_b__0_Internal_Object_Il2CppReferenceArray_1_Object_0;
		}

		// Token: 0x02000197 RID: 407
		private sealed class MethodInfoStoreGeneric_BuildMapCreator_Public_ObjectConstructor_1_Object_0<TKey, TValue>
		{
			// Token: 0x04001583 RID: 5507
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(FSharpUtils.NativeMethodInfoPtr_BuildMapCreator_Public_ObjectConstructor_1_Object_0, Il2CppClassPointerStore<FSharpUtils>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TKey>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TValue>.NativeClassPtr))
			}))));
		}
	}
}
