using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x0200011E RID: 286
	[Serializable]
	public class MissingMemberException : MemberAccessException
	{
		// Token: 0x060012BD RID: 4797 RVA: 0x0007FC8C File Offset: 0x0007DE8C
		// Note: this type is marked as 'beforefieldinit'.
		static MissingMemberException()
		{
			Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MissingMemberException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr);
			MissingMemberException.NativeFieldInfoPtr_ClassName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "ClassName");
			MissingMemberException.NativeFieldInfoPtr_MemberName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "MemberName");
			MissingMemberException.NativeFieldInfoPtr_Signature = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, "Signature");
			MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666567);
			MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666568);
			MissingMemberException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666569);
			MissingMemberException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666570);
			MissingMemberException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666571);
			MissingMemberException.NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr, 100666572);
		}

		// Token: 0x060012BE RID: 4798 RVA: 0x0007FD70 File Offset: 0x0007DF70
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1334899, RefRangeEnd = 1334900, XrefRangeStart = 1334896, XrefRangeEnd = 1334899, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0007FDAC File Offset: 0x0007DFAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334901, RefRangeEnd = 1334903, XrefRangeStart = 1334900, XrefRangeEnd = 1334901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException(string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0007FDF8 File Offset: 0x0007DFF8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1334936, RefRangeEnd = 1334938, XrefRangeStart = 1334903, XrefRangeEnd = 1334936, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MissingMemberException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MissingMemberException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0007FE5C File Offset: 0x0007E05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334938, XrefRangeEnd = 1334974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingMemberException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x060012C2 RID: 4802 RVA: 0x0007FEC0 File Offset: 0x0007E0C0
		public unsafe override string Message
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 1334989, RefRangeEnd = 1334990, XrefRangeStart = 1334974, XrefRangeEnd = 1334989, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MissingMemberException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0007FF04 File Offset: 0x0007E104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1334990, XrefRangeEnd = 1334992, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string FormatSignature(Il2CppStructArray<byte> signature)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(signature);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MissingMemberException.NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x00006219 File Offset: 0x00004419
		public MissingMemberException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x0007FF40 File Offset: 0x0007E140
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x00006222 File Offset: 0x00004422
		public unsafe string ClassName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_ClassName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_ClassName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x0007FF68 File Offset: 0x0007E168
		// (set) Token: 0x060012C8 RID: 4808 RVA: 0x00006241 File Offset: 0x00004441
		public unsafe string MemberName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_MemberName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_MemberName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x060012C9 RID: 4809 RVA: 0x0007FF90 File Offset: 0x0007E190
		// (set) Token: 0x060012CA RID: 4810 RVA: 0x00006260 File Offset: 0x00004460
		public unsafe Il2CppStructArray<byte> Signature
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_Signature);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MissingMemberException.NativeFieldInfoPtr_Signature), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeFieldInfoPtr_ClassName;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeFieldInfoPtr_MemberName;

		// Token: 0x04000FFB RID: 4091
		private static readonly IntPtr NativeFieldInfoPtr_Signature;

		// Token: 0x04000FFC RID: 4092
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000FFD RID: 4093
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000FFE RID: 4094
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000FFF RID: 4095
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_FormatSignature_Internal_Static_String_Il2CppStructArray_1_Byte_0;
	}
}
