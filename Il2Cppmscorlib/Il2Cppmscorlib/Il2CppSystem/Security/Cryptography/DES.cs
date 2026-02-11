using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x0200023F RID: 575
	public class DES : SymmetricAlgorithm
	{
		// Token: 0x060025B6 RID: 9654 RVA: 0x000D0078 File Offset: 0x000CE278
		// Note: this type is marked as 'beforefieldinit'.
		static DES()
		{
			Il2CppClassPointerStore<DES>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "DES");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DES>.NativeClassPtr);
			DES.NativeFieldInfoPtr_s_legalBlockSizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DES>.NativeClassPtr, "s_legalBlockSizes");
			DES.NativeFieldInfoPtr_s_legalKeySizes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DES>.NativeClassPtr, "s_legalKeySizes");
			DES.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669607);
			DES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669608);
			DES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669609);
			DES.NativeMethodInfoPtr_Create_Public_Static_DES_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669610);
			DES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669611);
			DES.NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669612);
			DES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669613);
			DES.NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DES>.NativeClassPtr, 100669614);
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000D0170 File Offset: 0x000CE370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371683, XrefRangeEnd = 1371691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DES()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DES>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060025B8 RID: 9656 RVA: 0x000D01AC File Offset: 0x000CE3AC
		// (set) Token: 0x060025B9 RID: 9657 RVA: 0x000D01F8 File Offset: 0x000CE3F8
		public unsafe override Il2CppStructArray<byte> Key
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371691, XrefRangeEnd = 1371701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DES.NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1371701, XrefRangeEnd = 1371717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DES.NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x000D0248 File Offset: 0x000CE448
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1371732, RefRangeEnd = 1371737, XrefRangeStart = 1371717, XrefRangeEnd = 1371732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static DES Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_Create_Public_Static_DES_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<DES>(intPtr3) : null;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x000D027C File Offset: 0x000CE47C
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1371744, RefRangeEnd = 1371752, XrefRangeStart = 1371737, XrefRangeEnd = 1371744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x000D02C0 File Offset: 0x000CE4C0
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1371759, RefRangeEnd = 1371767, XrefRangeStart = 1371752, XrefRangeEnd = 1371759, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsSemiWeakKey(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000D0304 File Offset: 0x000CE504
		[CallerCount(0)]
		public unsafe static bool IsLegalKeySize(Il2CppStructArray<byte> rgbKey)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rgbKey);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x000D0348 File Offset: 0x000CE548
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1371767, RefRangeEnd = 1371769, XrefRangeStart = 1371767, XrefRangeEnd = 1371767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ulong QuadWordFromBigEndian(Il2CppStructArray<byte> block)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(block);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DES.NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0000C34B File Offset: 0x0000A54B
		public DES(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x060025C0 RID: 9664 RVA: 0x000D038C File Offset: 0x000CE58C
		// (set) Token: 0x060025C1 RID: 9665 RVA: 0x0000C354 File Offset: 0x0000A554
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalBlockSizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DES.NativeFieldInfoPtr_s_legalBlockSizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DES.NativeFieldInfoPtr_s_legalBlockSizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060025C2 RID: 9666 RVA: 0x000D03B4 File Offset: 0x000CE5B4
		// (set) Token: 0x060025C3 RID: 9667 RVA: 0x0000C366 File Offset: 0x0000A566
		public unsafe static Il2CppReferenceArray<KeySizes> s_legalKeySizes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DES.NativeFieldInfoPtr_s_legalKeySizes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<KeySizes>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DES.NativeFieldInfoPtr_s_legalKeySizes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040020CF RID: 8399
		private static readonly IntPtr NativeFieldInfoPtr_s_legalBlockSizes;

		// Token: 0x040020D0 RID: 8400
		private static readonly IntPtr NativeFieldInfoPtr_s_legalKeySizes;

		// Token: 0x040020D1 RID: 8401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x040020D2 RID: 8402
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Virtual_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020D3 RID: 8403
		private static readonly IntPtr NativeMethodInfoPtr_set_Key_Public_Virtual_set_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020D4 RID: 8404
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_DES_0;

		// Token: 0x040020D5 RID: 8405
		private static readonly IntPtr NativeMethodInfoPtr_IsWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020D6 RID: 8406
		private static readonly IntPtr NativeMethodInfoPtr_IsSemiWeakKey_Public_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020D7 RID: 8407
		private static readonly IntPtr NativeMethodInfoPtr_IsLegalKeySize_Private_Static_Boolean_Il2CppStructArray_1_Byte_0;

		// Token: 0x040020D8 RID: 8408
		private static readonly IntPtr NativeMethodInfoPtr_QuadWordFromBigEndian_Private_Static_UInt64_Il2CppStructArray_1_Byte_0;
	}
}
