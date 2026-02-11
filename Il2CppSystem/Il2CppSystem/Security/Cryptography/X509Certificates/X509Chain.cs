using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D1 RID: 209
	public class X509Chain : Object
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x000502C4 File Offset: 0x0004E4C4
		// Note: this type is marked as 'beforefieldinit'.
		static X509Chain()
		{
			Il2CppClassPointerStore<X509Chain>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509Chain");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509Chain>.NativeClassPtr);
			X509Chain.NativeFieldInfoPtr_impl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, "impl");
			X509Chain.NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665309);
			X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665310);
			X509Chain.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665311);
			X509Chain.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665312);
			X509Chain.NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665314);
			X509Chain.NativeMethodInfoPtr_get_ChainPolicy_Public_get_X509ChainPolicy_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665315);
			X509Chain.NativeMethodInfoPtr_get_ChainStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665316);
			X509Chain.NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665317);
			X509Chain.NativeMethodInfoPtr_Reset_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665318);
			X509Chain.NativeMethodInfoPtr_Create_Public_Static_X509Chain_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665319);
			X509Chain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665320);
			X509Chain.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665321);
			X509Chain.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509Chain>.NativeClassPtr, 100665322);
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x0005040C File Offset: 0x0004E60C
		public unsafe X509ChainImpl Impl
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454363, RefRangeEnd = 454365, XrefRangeStart = 454363, XrefRangeEnd = 454363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0005044C File Offset: 0x0004E64C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454365, XrefRangeEnd = 454371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00050488 File Offset: 0x0004E688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454377, RefRangeEnd = 454378, XrefRangeStart = 454371, XrefRangeEnd = 454377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain(bool useMachineContext)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref useMachineContext;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000504D0 File Offset: 0x0004E6D0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 454383, RefRangeEnd = 454387, XrefRangeStart = 454378, XrefRangeEnd = 454383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509Chain(X509ChainImpl impl)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509Chain>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(impl);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x0005051C File Offset: 0x0004E71C
		public unsafe X509ChainElementCollection ChainElements
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 454391, RefRangeEnd = 454394, XrefRangeStart = 454387, XrefRangeEnd = 454391, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainElementCollection>(intPtr3) : null;
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06000DDA RID: 3546 RVA: 0x0005055C File Offset: 0x0004E75C
		public unsafe X509ChainPolicy ChainPolicy
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 454398, RefRangeEnd = 454399, XrefRangeStart = 454394, XrefRangeEnd = 454398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_ChainPolicy_Public_get_X509ChainPolicy_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509ChainPolicy>(intPtr3) : null;
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x0005059C File Offset: 0x0004E79C
		public unsafe Il2CppReferenceArray<X509ChainStatus> ChainStatus
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 454403, RefRangeEnd = 454405, XrefRangeStart = 454399, XrefRangeEnd = 454403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_get_ChainStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<X509ChainStatus>>(intPtr3) : null;
			}
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x000505DC File Offset: 0x0004E7DC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 454409, RefRangeEnd = 454410, XrefRangeStart = 454405, XrefRangeEnd = 454409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Build(X509Certificate2 certificate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(certificate);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0005062C File Offset: 0x0004E82C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454410, XrefRangeEnd = 454420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Reset_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00050660 File Offset: 0x0004E860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454420, XrefRangeEnd = 454429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static X509Chain Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Create_Public_Static_X509Chain_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<X509Chain>(intPtr3) : null;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x00050694 File Offset: 0x0004E894
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 454433, RefRangeEnd = 454436, XrefRangeStart = 454429, XrefRangeEnd = 454433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509Chain.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x000506C8 File Offset: 0x0004E8C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 454436, XrefRangeEnd = 454441, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Chain.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00050714 File Offset: 0x0004E914
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), X509Chain.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00007049 File Offset: 0x00005249
		public X509Chain(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x00050750 File Offset: 0x0004E950
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x00007052 File Offset: 0x00005252
		public unsafe X509ChainImpl impl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_impl);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<X509ChainImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509Chain.NativeFieldInfoPtr_impl), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000B69 RID: 2921
		private static readonly IntPtr NativeFieldInfoPtr_impl;

		// Token: 0x04000B6A RID: 2922
		private static readonly IntPtr NativeMethodInfoPtr_get_Impl_Internal_get_X509ChainImpl_0;

		// Token: 0x04000B6B RID: 2923
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B6C RID: 2924
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000B6D RID: 2925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainImpl_0;

		// Token: 0x04000B6E RID: 2926
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainElements_Public_get_X509ChainElementCollection_0;

		// Token: 0x04000B6F RID: 2927
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainPolicy_Public_get_X509ChainPolicy_0;

		// Token: 0x04000B70 RID: 2928
		private static readonly IntPtr NativeMethodInfoPtr_get_ChainStatus_Public_get_Il2CppReferenceArray_1_X509ChainStatus_0;

		// Token: 0x04000B71 RID: 2929
		private static readonly IntPtr NativeMethodInfoPtr_Build_Public_Boolean_X509Certificate2_0;

		// Token: 0x04000B72 RID: 2930
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Void_0;

		// Token: 0x04000B73 RID: 2931
		private static readonly IntPtr NativeMethodInfoPtr_Create_Public_Static_X509Chain_0;

		// Token: 0x04000B74 RID: 2932
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04000B75 RID: 2933
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04000B76 RID: 2934
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
