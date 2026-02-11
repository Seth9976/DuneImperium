using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000072 RID: 114
	public class CamelCasePropertyNamesContractResolver : DefaultContractResolver
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x0003F054 File Offset: 0x0003D254
		// Note: this type is marked as 'beforefieldinit'.
		static CamelCasePropertyNamesContractResolver()
		{
			Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "CamelCasePropertyNamesContractResolver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr);
			CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_TypeContractCacheLock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, "TypeContractCacheLock");
			CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_NameTable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, "NameTable");
			CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr__contractCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, "_contractCache");
			CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, 100665145);
			CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Virtual_JsonContract_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, 100665146);
			CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr_GetNameTable_Internal_Virtual_DefaultJsonNameTable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr, 100665147);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0003F0FC File Offset: 0x0003D2FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746759, XrefRangeEnd = 746769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CamelCasePropertyNamesContractResolver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CamelCasePropertyNamesContractResolver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x0003F138 File Offset: 0x0003D338
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746769, XrefRangeEnd = 746812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override JsonContract ResolveContract(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr_ResolveContract_Public_Virtual_JsonContract_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<JsonContract>(intPtr3) : null;
			}
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x0003F194 File Offset: 0x0003D394
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 746812, XrefRangeEnd = 746816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DefaultJsonNameTable GetNameTable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CamelCasePropertyNamesContractResolver.NativeMethodInfoPtr_GetNameTable_Internal_Virtual_DefaultJsonNameTable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DefaultJsonNameTable>(intPtr3) : null;
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00004F1C File Offset: 0x0000311C
		public CamelCasePropertyNamesContractResolver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x0003F1E0 File Offset: 0x0003D3E0
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00004F25 File Offset: 0x00003125
		public unsafe static Object TypeContractCacheLock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_TypeContractCacheLock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_TypeContractCacheLock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x0003F208 File Offset: 0x0003D408
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x00004F37 File Offset: 0x00003137
		public unsafe static DefaultJsonNameTable NameTable
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_NameTable, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultJsonNameTable>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr_NameTable, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x0003F230 File Offset: 0x0003D430
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00004F49 File Offset: 0x00003149
		public new unsafe static Dictionary<StructMultiKey<Type, Type>, JsonContract> _contractCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr__contractCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<StructMultiKey<Type, Type>, JsonContract>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CamelCasePropertyNamesContractResolver.NativeFieldInfoPtr__contractCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400080F RID: 2063
		private static readonly IntPtr NativeFieldInfoPtr_TypeContractCacheLock;

		// Token: 0x04000810 RID: 2064
		private static readonly IntPtr NativeFieldInfoPtr_NameTable;

		// Token: 0x04000811 RID: 2065
		private static readonly IntPtr NativeFieldInfoPtr__contractCache;

		// Token: 0x04000812 RID: 2066
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000813 RID: 2067
		private static readonly IntPtr NativeMethodInfoPtr_ResolveContract_Public_Virtual_JsonContract_Type_0;

		// Token: 0x04000814 RID: 2068
		private static readonly IntPtr NativeMethodInfoPtr_GetNameTable_Internal_Virtual_DefaultJsonNameTable_0;
	}
}
