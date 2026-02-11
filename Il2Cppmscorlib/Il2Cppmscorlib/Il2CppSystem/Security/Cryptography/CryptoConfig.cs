using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000270 RID: 624
	public class CryptoConfig : Object
	{
		// Token: 0x0600282F RID: 10287 RVA: 0x000D9308 File Offset: 0x000D7508
		// Note: this type is marked as 'beforefieldinit'.
		static CryptoConfig()
		{
			Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "CryptoConfig");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr);
			CryptoConfig.NativeFieldInfoPtr_lockObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, "lockObject");
			CryptoConfig.NativeFieldInfoPtr_algorithms = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, "algorithms");
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669915);
			CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669916);
			CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669917);
			CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669918);
			CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669919);
			CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CryptoConfig>.NativeClassPtr, 100669920);
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x000D93D8 File Offset: 0x000D75D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374152, RefRangeEnd = 1374153, XrefRangeStart = 1374148, XrefRangeEnd = 1374152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x000D941C File Offset: 0x000D761C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374458, RefRangeEnd = 1374460, XrefRangeStart = 1374153, XrefRangeEnd = 1374458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object CreateFromName(string name, [Optional] Il2CppReferenceArray<Object> args)
		{
			if (args == null)
			{
				args = new Il2CppReferenceArray<Object>(0L);
			}
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(args);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x000D9480 File Offset: 0x000D7680
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1374508, RefRangeEnd = 1374515, XrefRangeStart = 1374460, XrefRangeEnd = 1374508, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string MapNameToOID(string name)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x000D94BC File Offset: 0x000D76BC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 1374547, RefRangeEnd = 1374560, XrefRangeStart = 1374515, XrefRangeEnd = 1374547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeOID(string str)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(str);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x000D9500 File Offset: 0x000D7700
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1374567, RefRangeEnd = 1374568, XrefRangeStart = 1374560, XrefRangeEnd = 1374567, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppStructArray<byte> EncodeLongNumber(long x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x000D9540 File Offset: 0x000D7740
		public unsafe static bool AllowOnlyFipsAlgorithms
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CryptoConfig.NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x0000D2F2 File Offset: 0x0000B4F2
		public static Object CreateFromName(string name, params Object[] args)
		{
			return CryptoConfig.CreateFromName(name, new Il2CppReferenceArray<Object>(args));
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0000D300 File Offset: 0x0000B500
		public CryptoConfig(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06002838 RID: 10296 RVA: 0x000D9570 File Offset: 0x000D7770
		// (set) Token: 0x06002839 RID: 10297 RVA: 0x0000D309 File Offset: 0x0000B509
		public unsafe static Object lockObject
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CryptoConfig.NativeFieldInfoPtr_lockObject, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CryptoConfig.NativeFieldInfoPtr_lockObject, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x0600283A RID: 10298 RVA: 0x000D9598 File Offset: 0x000D7798
		// (set) Token: 0x0600283B RID: 10299 RVA: 0x0000D31B File Offset: 0x0000B51B
		public unsafe static Dictionary<string, Type> algorithms
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CryptoConfig.NativeFieldInfoPtr_algorithms, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CryptoConfig.NativeFieldInfoPtr_algorithms, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002273 RID: 8819
		private static readonly IntPtr NativeFieldInfoPtr_lockObject;

		// Token: 0x04002274 RID: 8820
		private static readonly IntPtr NativeFieldInfoPtr_algorithms;

		// Token: 0x04002275 RID: 8821
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_0;

		// Token: 0x04002276 RID: 8822
		private static readonly IntPtr NativeMethodInfoPtr_CreateFromName_Public_Static_Object_String_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04002277 RID: 8823
		private static readonly IntPtr NativeMethodInfoPtr_MapNameToOID_Public_Static_String_String_0;

		// Token: 0x04002278 RID: 8824
		private static readonly IntPtr NativeMethodInfoPtr_EncodeOID_Public_Static_Il2CppStructArray_1_Byte_String_0;

		// Token: 0x04002279 RID: 8825
		private static readonly IntPtr NativeMethodInfoPtr_EncodeLongNumber_Private_Static_Il2CppStructArray_1_Byte_Int64_0;

		// Token: 0x0400227A RID: 8826
		private static readonly IntPtr NativeMethodInfoPtr_get_AllowOnlyFipsAlgorithms_Public_Static_get_Boolean_0;
	}
}
