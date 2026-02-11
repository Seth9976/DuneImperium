using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography
{
	// Token: 0x02000275 RID: 629
	public sealed class RNGCryptoServiceProvider : RandomNumberGenerator
	{
		// Token: 0x060028A4 RID: 10404 RVA: 0x000DA9B4 File Offset: 0x000D8BB4
		// Note: this type is marked as 'beforefieldinit'.
		static RNGCryptoServiceProvider()
		{
			Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Security.Cryptography", "RNGCryptoServiceProvider");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__lock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_lock");
			RNGCryptoServiceProvider.NativeFieldInfoPtr__handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, "_handle");
			RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669956);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669957);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669958);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669959);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_ptr_Byte_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669960);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669961);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669962);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669963);
			RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr, 100669964);
		}

		// Token: 0x060028A5 RID: 10405 RVA: 0x000DAAB8 File Offset: 0x000D8CB8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374903, RefRangeEnd = 1374905, XrefRangeStart = 1374897, XrefRangeEnd = 1374903, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RNGCryptoServiceProvider()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RNGCryptoServiceProvider>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A6 RID: 10406 RVA: 0x000DAAF4 File Offset: 0x000D8CF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1374906, RefRangeEnd = 1374908, XrefRangeStart = 1374905, XrefRangeEnd = 1374906, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Check()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Check_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000DAB28 File Offset: 0x000D8D28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool RngOpen()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000DAB58 File Offset: 0x000D8D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374908, XrefRangeEnd = 1374909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngInitialize(byte* seed, IntPtr seed_length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = seed;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seed_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_ptr_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028A9 RID: 10409 RVA: 0x000DABA4 File Offset: 0x000D8DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374909, XrefRangeEnd = 1374910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IntPtr RngGetBytes(IntPtr handle, byte* data, IntPtr data_length)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = data;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref data_length;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_ptr_Byte_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060028AA RID: 10410 RVA: 0x000DABFC File Offset: 0x000D8DFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374910, XrefRangeEnd = 1374911, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RngClose(IntPtr handle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref handle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AB RID: 10411 RVA: 0x000DAC30 File Offset: 0x000D8E30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374911, XrefRangeEnd = 1374932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetBytes(Il2CppStructArray<byte> data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x000DAC74 File Offset: 0x000D8E74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374932, XrefRangeEnd = 1374940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060028AD RID: 10413 RVA: 0x000DACA8 File Offset: 0x000D8EA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1374940, XrefRangeEnd = 1374941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RNGCryptoServiceProvider.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060028AE RID: 10414 RVA: 0x0000D667 File Offset: 0x0000B867
		public RNGCryptoServiceProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060028AF RID: 10415 RVA: 0x000DACE8 File Offset: 0x000D8EE8
		// (set) Token: 0x060028B0 RID: 10416 RVA: 0x0000D670 File Offset: 0x0000B870
		public unsafe static Object _lock
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RNGCryptoServiceProvider.NativeFieldInfoPtr__lock, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060028B1 RID: 10417 RVA: 0x000DAD10 File Offset: 0x000D8F10
		// (set) Token: 0x060028B2 RID: 10418 RVA: 0x0000D682 File Offset: 0x0000B882
		public unsafe IntPtr _handle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RNGCryptoServiceProvider.NativeFieldInfoPtr__handle)) = value;
			}
		}

		// Token: 0x040022BA RID: 8890
		private static readonly IntPtr NativeFieldInfoPtr__lock;

		// Token: 0x040022BB RID: 8891
		private static readonly IntPtr NativeFieldInfoPtr__handle;

		// Token: 0x040022BC RID: 8892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022BD RID: 8893
		private static readonly IntPtr NativeMethodInfoPtr_Check_Private_Void_0;

		// Token: 0x040022BE RID: 8894
		private static readonly IntPtr NativeMethodInfoPtr_RngOpen_Private_Static_Boolean_0;

		// Token: 0x040022BF RID: 8895
		private static readonly IntPtr NativeMethodInfoPtr_RngInitialize_Private_Static_IntPtr_ptr_Byte_IntPtr_0;

		// Token: 0x040022C0 RID: 8896
		private static readonly IntPtr NativeMethodInfoPtr_RngGetBytes_Private_Static_IntPtr_IntPtr_ptr_Byte_IntPtr_0;

		// Token: 0x040022C1 RID: 8897
		private static readonly IntPtr NativeMethodInfoPtr_RngClose_Private_Static_Void_IntPtr_0;

		// Token: 0x040022C2 RID: 8898
		private static readonly IntPtr NativeMethodInfoPtr_GetBytes_Public_Virtual_Void_Il2CppStructArray_1_Byte_0;

		// Token: 0x040022C3 RID: 8899
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040022C4 RID: 8900
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;
	}
}
