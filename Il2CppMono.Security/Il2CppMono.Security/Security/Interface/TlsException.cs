using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.Interface
{
	// Token: 0x0200002D RID: 45
	public sealed class TlsException : Exception
	{
		// Token: 0x0600029C RID: 668 RVA: 0x0000DE34 File Offset: 0x0000C034
		// Note: this type is marked as 'beforefieldinit'.
		static TlsException()
		{
			Il2CppClassPointerStore<TlsException>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.Interface", "TlsException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TlsException>.NativeClassPtr);
			TlsException.NativeFieldInfoPtr_alert = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TlsException>.NativeClassPtr, "alert");
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663675);
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663676);
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663677);
			TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TlsException>.NativeClassPtr, 100663678);
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0000DEC8 File Offset: 0x0000C0C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149444, XrefRangeEnd = 1149448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(Alert alert)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alert);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000DF14 File Offset: 0x0000C114
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1149453, RefRangeEnd = 1149456, XrefRangeStart = 1149448, XrefRangeEnd = 1149453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(Alert alert, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(alert);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000DF74 File Offset: 0x0000C174
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1149464, RefRangeEnd = 1149466, XrefRangeStart = 1149456, XrefRangeEnd = 1149464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(AlertDescription description)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref description;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1149466, XrefRangeEnd = 1149471, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TlsException(AlertDescription description, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TlsException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref description;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TlsException.NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0000322A File Offset: 0x0000142A
		public TlsException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0000E018 File Offset: 0x0000C218
		// (set) Token: 0x060002A3 RID: 675 RVA: 0x00003233 File Offset: 0x00001433
		public unsafe Alert alert
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsException.NativeFieldInfoPtr_alert);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Alert>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TlsException.NativeFieldInfoPtr_alert), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000301 RID: 769
		private static readonly IntPtr NativeFieldInfoPtr_alert;

		// Token: 0x04000302 RID: 770
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Alert_0;

		// Token: 0x04000303 RID: 771
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Alert_String_0;

		// Token: 0x04000304 RID: 772
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_0;

		// Token: 0x04000305 RID: 773
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AlertDescription_String_0;
	}
}
