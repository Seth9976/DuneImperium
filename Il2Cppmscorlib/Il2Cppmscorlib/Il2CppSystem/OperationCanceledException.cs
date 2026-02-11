using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Runtime.Serialization;
using Il2CppSystem.Threading;

namespace Il2CppSystem
{
	// Token: 0x020000D3 RID: 211
	[Serializable]
	public class OperationCanceledException : SystemException
	{
		// Token: 0x06000DBA RID: 3514 RVA: 0x00066340 File Offset: 0x00064540
		// Note: this type is marked as 'beforefieldinit'.
		static OperationCanceledException()
		{
			Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "OperationCanceledException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr);
			OperationCanceledException.NativeFieldInfoPtr__cancellationToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, "_cancellationToken");
			OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665714);
			OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665715);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665716);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665717);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665718);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665719);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665720);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665721);
			OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr, 100665722);
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000DBB RID: 3515 RVA: 0x00066438 File Offset: 0x00064638
		// (set) Token: 0x06000DBC RID: 3516 RVA: 0x00066470 File Offset: 0x00064670
		public unsafe CancellationToken CancellationToken
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 34751, RefRangeEnd = 34758, XrefRangeStart = 34751, XrefRangeEnd = 34758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new CancellationToken(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318178, XrefRangeEnd = 1318179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(value));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x000664B8 File Offset: 0x000646B8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 1318185, RefRangeEnd = 1318190, XrefRangeStart = 1318179, XrefRangeEnd = 1318185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x000664F4 File Offset: 0x000646F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318194, RefRangeEnd = 1318195, XrefRangeStart = 1318190, XrefRangeEnd = 1318194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00066540 File Offset: 0x00064740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318195, XrefRangeEnd = 1318199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message, Exception innerException)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x000665A0 File Offset: 0x000647A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1318199, XrefRangeEnd = 1318206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(CancellationToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x000665F0 File Offset: 0x000647F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1318211, RefRangeEnd = 1318214, XrefRangeStart = 1318206, XrefRangeEnd = 1318211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message, CancellationToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00066654 File Offset: 0x00064854
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1318219, RefRangeEnd = 1318220, XrefRangeStart = 1318214, XrefRangeEnd = 1318219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(string message, Exception innerException, CancellationToken token)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(innerException);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(token));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Public_Void_String_Exception_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x000666C8 File Offset: 0x000648C8
		[CallerCount(66)]
		[CachedScanResults(RefRangeStart = 1318224, RefRangeEnd = 1318290, XrefRangeStart = 1318220, XrefRangeEnd = 1318224, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OperationCanceledException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OperationCanceledException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OperationCanceledException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x000054A1 File Offset: 0x000036A1
		public OperationCanceledException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000DC5 RID: 3525 RVA: 0x0006672C File Offset: 0x0006492C
		// (set) Token: 0x06000DC6 RID: 3526 RVA: 0x000054AA File Offset: 0x000036AA
		public CancellationToken _cancellationToken
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken);
				return new CancellationToken(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OperationCanceledException.NativeFieldInfoPtr__cancellationToken), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CancellationToken>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x04000B47 RID: 2887
		private static readonly IntPtr NativeFieldInfoPtr__cancellationToken;

		// Token: 0x04000B48 RID: 2888
		private static readonly IntPtr NativeMethodInfoPtr_get_CancellationToken_Public_get_CancellationToken_0;

		// Token: 0x04000B49 RID: 2889
		private static readonly IntPtr NativeMethodInfoPtr_set_CancellationToken_Private_set_Void_CancellationToken_0;

		// Token: 0x04000B4A RID: 2890
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000B4B RID: 2891
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000B4C RID: 2892
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_0;

		// Token: 0x04000B4D RID: 2893
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CancellationToken_0;

		// Token: 0x04000B4E RID: 2894
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_CancellationToken_0;

		// Token: 0x04000B4F RID: 2895
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Exception_CancellationToken_0;

		// Token: 0x04000B50 RID: 2896
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
