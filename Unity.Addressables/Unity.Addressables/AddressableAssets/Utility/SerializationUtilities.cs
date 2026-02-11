using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.AddressableAssets.Utility
{
	// Token: 0x0200001D RID: 29
	public static class SerializationUtilities : Object
	{
		// Token: 0x0600024C RID: 588 RVA: 0x0000F524 File Offset: 0x0000D724
		// Note: this type is marked as 'beforefieldinit'.
		static SerializationUtilities()
		{
			Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Utility", "SerializationUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr);
			SerializationUtilities.NativeMethodInfoPtr_ReadInt32FromByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr, 100663774);
			SerializationUtilities.NativeMethodInfoPtr_WriteInt32ToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr, 100663775);
			SerializationUtilities.NativeMethodInfoPtr_ReadObjectFromByteArray_Internal_Static_Object_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr, 100663776);
			SerializationUtilities.NativeMethodInfoPtr_WriteObjectToByteList_Internal_Static_Int32_Object_List_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializationUtilities>.NativeClassPtr, 100663777);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0000F5A4 File Offset: 0x0000D7A4
		[CallerCount(0)]
		public unsafe static int ReadInt32FromByteArray(Il2CppStructArray<byte> data, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtilities.NativeMethodInfoPtr_ReadInt32FromByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0000F5F4 File Offset: 0x0000D7F4
		[CallerCount(0)]
		public unsafe static int WriteInt32ToByteArray(Il2CppStructArray<byte> data, int val, int offset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtilities.NativeMethodInfoPtr_WriteInt32ToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0000F654 File Offset: 0x0000D854
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1163214, RefRangeEnd = 1163218, XrefRangeStart = 1163167, XrefRangeEnd = 1163214, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object ReadObjectFromByteArray(Il2CppStructArray<byte> keyData, int dataIndex)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyData);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref dataIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtilities.NativeMethodInfoPtr_ReadObjectFromByteArray_Internal_Static_Object_Il2CppStructArray_1_Byte_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0000F6A8 File Offset: 0x0000D8A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1163338, RefRangeEnd = 1163339, XrefRangeStart = 1163218, XrefRangeEnd = 1163338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WriteObjectToByteList(Object obj, List<byte> buffer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializationUtilities.NativeMethodInfoPtr_WriteObjectToByteList_Internal_Static_Int32_Object_List_1_Byte_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002AC2 File Offset: 0x00000CC2
		public SerializationUtilities(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040001D8 RID: 472
		private static readonly IntPtr NativeMethodInfoPtr_ReadInt32FromByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001D9 RID: 473
		private static readonly IntPtr NativeMethodInfoPtr_WriteInt32ToByteArray_Internal_Static_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x040001DA RID: 474
		private static readonly IntPtr NativeMethodInfoPtr_ReadObjectFromByteArray_Internal_Static_Object_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x040001DB RID: 475
		private static readonly IntPtr NativeMethodInfoPtr_WriteObjectToByteList_Internal_Static_Int32_Object_List_1_Byte_0;

		// Token: 0x02000079 RID: 121
		public enum ObjectType
		{
			// Token: 0x04000385 RID: 901
			AsciiString,
			// Token: 0x04000386 RID: 902
			UnicodeString,
			// Token: 0x04000387 RID: 903
			UInt16,
			// Token: 0x04000388 RID: 904
			UInt32,
			// Token: 0x04000389 RID: 905
			Int32,
			// Token: 0x0400038A RID: 906
			Hash128,
			// Token: 0x0400038B RID: 907
			Type,
			// Token: 0x0400038C RID: 908
			JsonObject
		}
	}
}
