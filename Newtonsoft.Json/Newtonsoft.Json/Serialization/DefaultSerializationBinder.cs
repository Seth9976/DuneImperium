using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000076 RID: 118
	public class DefaultSerializationBinder : SerializationBinder
	{
		// Token: 0x06000A15 RID: 2581 RVA: 0x00041340 File Offset: 0x0003F540
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultSerializationBinder()
		{
			Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "DefaultSerializationBinder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr);
			DefaultSerializationBinder.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, "Instance");
			DefaultSerializationBinder.NativeFieldInfoPtr__typeCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, "_typeCache");
			DefaultSerializationBinder.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665255);
			DefaultSerializationBinder.NativeMethodInfoPtr_GetTypeFromTypeNameKey_Private_Type_StructMultiKey_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665256);
			DefaultSerializationBinder.NativeMethodInfoPtr_GetGenericTypeFromTypeName_Private_Type_String_Assembly_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665257);
			DefaultSerializationBinder.NativeMethodInfoPtr_GetTypeByName_Private_Type_StructMultiKey_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665258);
			DefaultSerializationBinder.NativeMethodInfoPtr_BindToType_Public_Virtual_Type_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665259);
			DefaultSerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_Void_Type_byref_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr, 100665260);
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00041410 File Offset: 0x0003F610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748718, XrefRangeEnd = 748732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultSerializationBinder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultSerializationBinder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSerializationBinder.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0004144C File Offset: 0x0003F64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748732, XrefRangeEnd = 748740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetTypeFromTypeNameKey(StructMultiKey<string, string> typeNameKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(typeNameKey));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSerializationBinder.NativeMethodInfoPtr_GetTypeFromTypeNameKey_Private_Type_StructMultiKey_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x000414A4 File Offset: 0x0003F6A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748740, XrefRangeEnd = 748768, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetGenericTypeFromTypeName(string typeName, Assembly assembly)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assembly);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSerializationBinder.NativeMethodInfoPtr_GetGenericTypeFromTypeName_Private_Type_String_Assembly_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x00041508 File Offset: 0x0003F708
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748768, XrefRangeEnd = 748771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetTypeByName(StructMultiKey<string, string> typeNameKey)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(typeNameKey));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultSerializationBinder.NativeMethodInfoPtr_GetTypeByName_Private_Type_StructMultiKey_2_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x00041560 File Offset: 0x0003F760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748771, XrefRangeEnd = 748777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Type BindToType(string assemblyName, string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(assemblyName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(typeName);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultSerializationBinder.NativeMethodInfoPtr_BindToType_Public_Virtual_Type_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000415D0 File Offset: 0x0003F7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 748777, XrefRangeEnd = 748780, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void BindToName(Type serializedType, out string assemblyName, out string typeName)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(serializedType);
			}
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2 = 0;
			ptr3 = &intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DefaultSerializationBinder.NativeMethodInfoPtr_BindToName_Public_Virtual_Void_Type_byref_String_byref_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
			assemblyName = IL2CPP.Il2CppStringToManaged(intPtr);
			typeName = IL2CPP.Il2CppStringToManaged(intPtr2);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000050C6 File Offset: 0x000032C6
		public DefaultSerializationBinder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000A1D RID: 2589 RVA: 0x00041654 File Offset: 0x0003F854
		// (set) Token: 0x06000A1E RID: 2590 RVA: 0x000050CF File Offset: 0x000032CF
		public unsafe static DefaultSerializationBinder Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DefaultSerializationBinder.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DefaultSerializationBinder>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DefaultSerializationBinder.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x0004167C File Offset: 0x0003F87C
		// (set) Token: 0x06000A20 RID: 2592 RVA: 0x000050E1 File Offset: 0x000032E1
		public unsafe ThreadSafeStore<StructMultiKey<string, string>, Type> _typeCache
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultSerializationBinder.NativeFieldInfoPtr__typeCache);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ThreadSafeStore<StructMultiKey<string, string>, Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DefaultSerializationBinder.NativeFieldInfoPtr__typeCache), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400086A RID: 2154
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x0400086B RID: 2155
		private static readonly IntPtr NativeFieldInfoPtr__typeCache;

		// Token: 0x0400086C RID: 2156
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400086D RID: 2157
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeFromTypeNameKey_Private_Type_StructMultiKey_2_String_String_0;

		// Token: 0x0400086E RID: 2158
		private static readonly IntPtr NativeMethodInfoPtr_GetGenericTypeFromTypeName_Private_Type_String_Assembly_0;

		// Token: 0x0400086F RID: 2159
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeByName_Private_Type_StructMultiKey_2_String_String_0;

		// Token: 0x04000870 RID: 2160
		private static readonly IntPtr NativeMethodInfoPtr_BindToType_Public_Virtual_Type_String_String_0;

		// Token: 0x04000871 RID: 2161
		private static readonly IntPtr NativeMethodInfoPtr_BindToName_Public_Virtual_Void_Type_byref_String_byref_String_0;
	}
}
