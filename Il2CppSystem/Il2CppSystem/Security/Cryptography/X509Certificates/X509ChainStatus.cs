using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Security.Cryptography.X509Certificates
{
	// Token: 0x020000D8 RID: 216
	public sealed class X509ChainStatus : ValueType
	{
		// Token: 0x06000E82 RID: 3714 RVA: 0x00052DAC File Offset: 0x00050FAC
		// Note: this type is marked as 'beforefieldinit'.
		static X509ChainStatus()
		{
			Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Security.Cryptography.X509Certificates", "X509ChainStatus");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr);
			X509ChainStatus.NativeFieldInfoPtr_status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "status");
			X509ChainStatus.NativeFieldInfoPtr_info = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, "info");
			X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665407);
			X509ChainStatus.NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665408);
			X509ChainStatus.NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665409);
			X509ChainStatus.NativeMethodInfoPtr_get_StatusInformation_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665410);
			X509ChainStatus.NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665411);
			X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr, 100665412);
		}

		// Token: 0x06000E83 RID: 3715 RVA: 0x00052E7C File Offset: 0x0005107C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 455296, RefRangeEnd = 455298, XrefRangeStart = 455294, XrefRangeEnd = 455296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe X509ChainStatus(X509ChainStatusFlags flag)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flag;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x00052EC8 File Offset: 0x000510C8
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x00052F0C File Offset: 0x0005110C
		public unsafe X509ChainStatusFlags Status
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x00052F50 File Offset: 0x00051150
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x00052F8C File Offset: 0x0005118C
		public unsafe string StatusInformation
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 306629, RefRangeEnd = 306630, XrefRangeStart = 306629, XrefRangeEnd = 306630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_get_StatusInformation_Public_get_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 315685, RefRangeEnd = 315686, XrefRangeStart = 315685, XrefRangeEnd = 315686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000E88 RID: 3720 RVA: 0x00052FD4 File Offset: 0x000511D4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 455302, RefRangeEnd = 455309, XrefRangeStart = 455298, XrefRangeEnd = 455302, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetInformation(X509ChainStatusFlags flags)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref flags;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X509ChainStatus.NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000E89 RID: 3721 RVA: 0x0000743B File Offset: 0x0000563B
		public X509ChainStatus(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000E8A RID: 3722 RVA: 0x00007444 File Offset: 0x00005644
		public X509ChainStatus()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X509ChainStatus>.NativeClassPtr))
		{
		}

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x0005300C File Offset: 0x0005120C
		// (set) Token: 0x06000E8C RID: 3724 RVA: 0x00007456 File Offset: 0x00005656
		public unsafe X509ChainStatusFlags status
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_status)) = value;
			}
		}

		// Token: 0x17000473 RID: 1139
		// (get) Token: 0x06000E8D RID: 3725 RVA: 0x00053034 File Offset: 0x00051234
		// (set) Token: 0x06000E8E RID: 3726 RVA: 0x00007471 File Offset: 0x00005671
		public unsafe string info
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X509ChainStatus.NativeFieldInfoPtr_info), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000BE9 RID: 3049
		private static readonly IntPtr NativeFieldInfoPtr_status;

		// Token: 0x04000BEA RID: 3050
		private static readonly IntPtr NativeFieldInfoPtr_info;

		// Token: 0x04000BEB RID: 3051
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_X509ChainStatusFlags_0;

		// Token: 0x04000BEC RID: 3052
		private static readonly IntPtr NativeMethodInfoPtr_get_Status_Public_get_X509ChainStatusFlags_0;

		// Token: 0x04000BED RID: 3053
		private static readonly IntPtr NativeMethodInfoPtr_set_Status_Public_set_Void_X509ChainStatusFlags_0;

		// Token: 0x04000BEE RID: 3054
		private static readonly IntPtr NativeMethodInfoPtr_get_StatusInformation_Public_get_String_0;

		// Token: 0x04000BEF RID: 3055
		private static readonly IntPtr NativeMethodInfoPtr_set_StatusInformation_Public_set_Void_String_0;

		// Token: 0x04000BF0 RID: 3056
		private static readonly IntPtr NativeMethodInfoPtr_GetInformation_Internal_Static_String_X509ChainStatusFlags_0;
	}
}
