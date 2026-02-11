using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security
{
	// Token: 0x02000220 RID: 544
	public sealed class SecureString : Object
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x000CA2B8 File Offset: 0x000C84B8
		// Note: this type is marked as 'beforefieldinit'.
		static SecureString()
		{
			Il2CppClassPointerStore<SecureString>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security", "SecureString");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SecureString>.NativeClassPtr);
			SecureString.NativeFieldInfoPtr_length = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "length");
			SecureString.NativeFieldInfoPtr_disposed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "disposed");
			SecureString.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SecureString>.NativeClassPtr, "data");
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669397);
			SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669398);
			SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669399);
			SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669400);
			SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669401);
			SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669402);
			SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669403);
			SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SecureString>.NativeClassPtr, 100669404);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x000CA3C4 File Offset: 0x000C85C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369809, XrefRangeEnd = 1369815, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x000CA400 File Offset: 0x000C8600
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369817, RefRangeEnd = 1369818, XrefRangeStart = 1369815, XrefRangeEnd = 1369817, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SecureString(char* value, int length)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SecureString>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = value;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x06002425 RID: 9253 RVA: 0x000CA454 File Offset: 0x000C8654
		public unsafe int Length
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 1369818, RefRangeEnd = 1369821, XrefRangeStart = 1369818, XrefRangeEnd = 1369818, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_get_Length_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000CA490 File Offset: 0x000C8690
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1369821, XrefRangeEnd = 1369823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000CA4C4 File Offset: 0x000C86C4
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 359432, RefRangeEnd = 359440, XrefRangeStart = 359432, XrefRangeEnd = 359440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Encrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Encrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000CA4F8 File Offset: 0x000C86F8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 359432, RefRangeEnd = 359440, XrefRangeStart = 359432, XrefRangeEnd = 359440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Decrypt()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Decrypt_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x000CA52C File Offset: 0x000C872C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1369828, RefRangeEnd = 1369829, XrefRangeStart = 1369823, XrefRangeEnd = 1369828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Alloc(int length, bool realloc)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref length;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref realloc;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x000CA578 File Offset: 0x000C8778
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1369834, RefRangeEnd = 1369836, XrefRangeStart = 1369829, XrefRangeEnd = 1369834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppStructArray<byte> GetBuffer()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SecureString.NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x0000B84A File Offset: 0x00009A4A
		public SecureString(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000722 RID: 1826
		// (get) Token: 0x0600242C RID: 9260 RVA: 0x000CA5B8 File Offset: 0x000C87B8
		// (set) Token: 0x0600242D RID: 9261 RVA: 0x0000B853 File Offset: 0x00009A53
		public unsafe int length
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_length)) = value;
			}
		}

		// Token: 0x17000723 RID: 1827
		// (get) Token: 0x0600242E RID: 9262 RVA: 0x000CA5E0 File Offset: 0x000C87E0
		// (set) Token: 0x0600242F RID: 9263 RVA: 0x0000B86E File Offset: 0x00009A6E
		public unsafe bool disposed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_disposed)) = value;
			}
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x06002430 RID: 9264 RVA: 0x000CA608 File Offset: 0x000C8808
		// (set) Token: 0x06002431 RID: 9265 RVA: 0x0000B889 File Offset: 0x00009A89
		public unsafe Il2CppStructArray<byte> data
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SecureString.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F99 RID: 8089
		private static readonly IntPtr NativeFieldInfoPtr_length;

		// Token: 0x04001F9A RID: 8090
		private static readonly IntPtr NativeFieldInfoPtr_disposed;

		// Token: 0x04001F9B RID: 8091
		private static readonly IntPtr NativeFieldInfoPtr_data;

		// Token: 0x04001F9C RID: 8092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001F9D RID: 8093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ptr_Char_Int32_0;

		// Token: 0x04001F9E RID: 8094
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_get_Int32_0;

		// Token: 0x04001F9F RID: 8095
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001FA0 RID: 8096
		private static readonly IntPtr NativeMethodInfoPtr_Encrypt_Private_Void_0;

		// Token: 0x04001FA1 RID: 8097
		private static readonly IntPtr NativeMethodInfoPtr_Decrypt_Private_Void_0;

		// Token: 0x04001FA2 RID: 8098
		private static readonly IntPtr NativeMethodInfoPtr_Alloc_Private_Void_Int32_Boolean_0;

		// Token: 0x04001FA3 RID: 8099
		private static readonly IntPtr NativeMethodInfoPtr_GetBuffer_Internal_Il2CppStructArray_1_Byte_0;
	}
}
