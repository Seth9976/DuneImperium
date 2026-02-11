using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.IO;
using Il2CppSystem.Net;
using Il2CppSystem.Reflection;

namespace Steamworks
{
	// Token: 0x020000CF RID: 207
	public static class Utility : Object
	{
		// Token: 0x06000CFC RID: 3324 RVA: 0x000548AC File Offset: 0x00052AAC
		// Note: this type is marked as 'beforefieldinit'.
		static Utility()
		{
			Il2CppClassPointerStore<Utility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "Utility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Utility>.NativeClassPtr);
			Utility.NativeFieldInfoPtr_readBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Utility>.NativeClassPtr, "readBuffer");
			Utility.NativeMethodInfoPtr_ToType_Internal_Static_T_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666456);
			Utility.NativeMethodInfoPtr_ToType_Internal_Static_Object_IntPtr_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666457);
			Utility.NativeMethodInfoPtr_Swap_Internal_Static_UInt32_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666458);
			Utility.NativeMethodInfoPtr_IpToInt32_Public_Static_UInt32_IPAddress_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666459);
			Utility.NativeMethodInfoPtr_Int32ToIp_Public_Static_IPAddress_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666460);
			Utility.NativeMethodInfoPtr_FormatPrice_Public_Static_String_String_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666461);
			Utility.NativeMethodInfoPtr_ReadNullTerminatedUTF8String_Public_Static_String_BinaryReader_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Utility>.NativeClassPtr, 100666462);
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x0005497C File Offset: 0x00052B7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 948302, RefRangeEnd = 948303, XrefRangeStart = 948290, XrefRangeEnd = 948302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T ToType<T>(this IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.MethodInfoStoreGeneric_ToType_Internal_Static_T_IntPtr_0<T>.Pointer, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x000549B8 File Offset: 0x00052BB8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 948308, RefRangeEnd = 948309, XrefRangeStart = 948303, XrefRangeEnd = 948308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ToType(this IntPtr ptr, Type t)
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(t);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ToType_Internal_Static_Object_IntPtr_Type_0, 0, (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000CFF RID: 3327 RVA: 0x00054A0C File Offset: 0x00052C0C
		[CallerCount(0)]
		public unsafe static uint Swap(uint x)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Swap_Internal_Static_UInt32_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D00 RID: 3328 RVA: 0x00054A4C File Offset: 0x00052C4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 948313, RefRangeEnd = 948317, XrefRangeStart = 948309, XrefRangeEnd = 948313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static uint IpToInt32(this IPAddress ipAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ipAddress);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_IpToInt32_Public_Static_UInt32_IPAddress_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000D01 RID: 3329 RVA: 0x00054A90 File Offset: 0x00052C90
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 948324, RefRangeEnd = 948329, XrefRangeStart = 948317, XrefRangeEnd = 948324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IPAddress Int32ToIp(uint ipAddress)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref ipAddress;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_Int32ToIp_Public_Static_IPAddress_UInt32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IPAddress>(intPtr3) : null;
			}
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x00054AD0 File Offset: 0x00052CD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 948418, RefRangeEnd = 948420, XrefRangeStart = 948329, XrefRangeEnd = 948418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatPrice(string currency, double price)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(currency);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref price;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_FormatPrice_Public_Static_String_String_Double_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00054B1C File Offset: 0x00052D1C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 948438, RefRangeEnd = 948440, XrefRangeStart = 948420, XrefRangeEnd = 948438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ReadNullTerminatedUTF8String(this BinaryReader br)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(br);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Utility.NativeMethodInfoPtr_ReadNullTerminatedUTF8String_Public_Static_String_BinaryReader_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00003427 File Offset: 0x00001627
		public Utility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00054B58 File Offset: 0x00052D58
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00003430 File Offset: 0x00001630
		public unsafe static Il2CppStructArray<byte> readBuffer
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Utility.NativeFieldInfoPtr_readBuffer, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Utility.NativeFieldInfoPtr_readBuffer, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001363 RID: 4963
		private static readonly IntPtr NativeFieldInfoPtr_readBuffer;

		// Token: 0x04001364 RID: 4964
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Internal_Static_T_IntPtr_0;

		// Token: 0x04001365 RID: 4965
		private static readonly IntPtr NativeMethodInfoPtr_ToType_Internal_Static_Object_IntPtr_Type_0;

		// Token: 0x04001366 RID: 4966
		private static readonly IntPtr NativeMethodInfoPtr_Swap_Internal_Static_UInt32_UInt32_0;

		// Token: 0x04001367 RID: 4967
		private static readonly IntPtr NativeMethodInfoPtr_IpToInt32_Public_Static_UInt32_IPAddress_0;

		// Token: 0x04001368 RID: 4968
		private static readonly IntPtr NativeMethodInfoPtr_Int32ToIp_Public_Static_IPAddress_UInt32_0;

		// Token: 0x04001369 RID: 4969
		private static readonly IntPtr NativeMethodInfoPtr_FormatPrice_Public_Static_String_String_Double_0;

		// Token: 0x0400136A RID: 4970
		private static readonly IntPtr NativeMethodInfoPtr_ReadNullTerminatedUTF8String_Public_Static_String_BinaryReader_0;

		// Token: 0x0200028B RID: 651
		private sealed class MethodInfoStoreGeneric_ToType_Internal_Static_T_IntPtr_0<T>
		{
			// Token: 0x04002311 RID: 8977
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Utility.NativeMethodInfoPtr_ToType_Internal_Static_T_IntPtr_0, Il2CppClassPointerStore<Utility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
