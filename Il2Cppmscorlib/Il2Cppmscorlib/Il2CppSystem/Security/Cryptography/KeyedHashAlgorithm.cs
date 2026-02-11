using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200024D RID: 589
	public class KeyedHashAlgorithm : HashAlgorithm
	{
		// Token: 0x06002639 RID: 9785 RVA: 0x000D1DC4 File Offset: 0x000CFFC4
		// Note: this type is marked as 'beforefieldinit'.
		static KeyedHashAlgorithm()
		{
			Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "KeyedHashAlgorithm");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr);
			KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, "KeyValue");
			KeyedHashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100669666);
			KeyedHashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100669667);
			KeyedHashAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100669668);
			KeyedHashAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr, 100669669);
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x000D1E58 File Offset: 0x000D0058
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeyedHashAlgorithm()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeyedHashAlgorithm>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeyedHashAlgorithm.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x000D1E94 File Offset: 0x000D0094
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372337, XrefRangeEnd = 1372339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x0600263C RID: 9788 RVA: 0x000D1EE0 File Offset: 0x000D00E0
		// (set) Token: 0x0600263D RID: 9789 RVA: 0x000D1F2C File Offset: 0x000D012C
		public unsafe virtual Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372339, XrefRangeEnd = 1372342, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1372342, XrefRangeEnd = 1372360, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeyedHashAlgorithm.NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x0000C657 File Offset: 0x0000A857
		public KeyedHashAlgorithm(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B7 RID: 1975
		// (get) Token: 0x0600263F RID: 9791 RVA: 0x000D1F7C File Offset: 0x000D017C
		// (set) Token: 0x06002640 RID: 9792 RVA: 0x0000C660 File Offset: 0x0000A860
		public unsafe Il2CppStructArray<byte> KeyValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeyedHashAlgorithm.NativeFieldInfoPtr_KeyValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400211F RID: 8479
		private static readonly IntPtr NativeFieldInfoPtr_KeyValue;

		// Token: 0x04002120 RID: 8480
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002121 RID: 8481
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

		// Token: 0x04002122 RID: 8482
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_New_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04002123 RID: 8483
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_New_set_Void_Il2CppStructArray_1_Byte_0;
	}
}
