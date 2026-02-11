using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x0200050A RID: 1290
	[Serializable]
	public class ByteEqualityComparer : EqualityComparer<byte>
	{
		// Token: 0x06004F42 RID: 20290 RVA: 0x00170D70 File Offset: 0x0016EF70
		// Note: this type is marked as 'beforefieldinit'.
		static ByteEqualityComparer()
		{
			Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ByteEqualityComparer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr);
			ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675250);
			ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675251);
			ByteEqualityComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675252);
			ByteEqualityComparer.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675253);
			ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675254);
			ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675255);
			ByteEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr, 100675256);
		}

		// Token: 0x06004F43 RID: 20291 RVA: 0x00170E2C File Offset: 0x0016F02C
		[CallerCount(0)]
		public unsafe override bool Equals(byte x, byte y)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F44 RID: 20292 RVA: 0x00170E90 File Offset: 0x0016F090
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426439, XrefRangeEnd = 1426440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode(byte b)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref b;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F45 RID: 20293 RVA: 0x00170EE4 File Offset: 0x0016F0E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426440, XrefRangeEnd = 1426442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int IndexOf(Il2CppStructArray<byte> array, byte value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F46 RID: 20294 RVA: 0x00170F68 File Offset: 0x0016F168
		[CallerCount(0)]
		public unsafe override int LastIndexOf(Il2CppStructArray<byte> array, byte value, int startIndex, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startIndex;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F47 RID: 20295 RVA: 0x00170FEC File Offset: 0x0016F1EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426442, XrefRangeEnd = 1426443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004F48 RID: 20296 RVA: 0x00171044 File Offset: 0x0016F244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426443, XrefRangeEnd = 1426445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ByteEqualityComparer.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004F49 RID: 20297 RVA: 0x0017108C File Offset: 0x0016F28C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1426445, XrefRangeEnd = 1426448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteEqualityComparer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteEqualityComparer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteEqualityComparer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004F4A RID: 20298 RVA: 0x0001C7D5 File Offset: 0x0001A9D5
		public ByteEqualityComparer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040040AA RID: 16554
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Byte_Byte_0;

		// Token: 0x040040AB RID: 16555
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_Byte_0;

		// Token: 0x040040AC RID: 16556
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0;

		// Token: 0x040040AD RID: 16557
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Internal_Virtual_Int32_Il2CppStructArray_1_Byte_Byte_Int32_Int32_0;

		// Token: 0x040040AE RID: 16558
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040040AF RID: 16559
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040040B0 RID: 16560
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
