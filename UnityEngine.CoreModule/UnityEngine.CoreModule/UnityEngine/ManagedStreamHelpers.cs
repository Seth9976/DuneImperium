using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.IO;

namespace UnityEngine
{
	// Token: 0x02000144 RID: 324
	public static class ManagedStreamHelpers : Object
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x00074B2C File Offset: 0x00072D2C
		// Note: this type is marked as 'beforefieldinit'.
		static ManagedStreamHelpers()
		{
			Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ManagedStreamHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr);
			ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666705);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666706);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666707);
			ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedStreamHelpers>.NativeClassPtr, 100666708);
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00074BAC File Offset: 0x00072DAC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 666417, RefRangeEnd = 666420, XrefRangeStart = 666417, XrefRangeEnd = 666417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ValidateLoadFromStream(Stream stream)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00074BE4 File Offset: 0x00072DE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666420, XrefRangeEnd = 666423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamRead(Il2CppStructArray<byte> buffer, int offset, int count, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00074C58 File Offset: 0x00072E58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666423, XrefRangeEnd = 666426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamSeek(long offset, uint origin, Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x00074CB8 File Offset: 0x00072EB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 666426, XrefRangeEnd = 666429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ManagedStreamLength(Stream stream, IntPtr returnValueAddress)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref returnValueAddress;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagedStreamHelpers.NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00009BE7 File Offset: 0x00007DE7
		public ManagedStreamHelpers(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001623 RID: 5667
		private static readonly IntPtr NativeMethodInfoPtr_ValidateLoadFromStream_Internal_Static_Void_Stream_0;

		// Token: 0x04001624 RID: 5668
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamRead_Internal_Static_Void_Il2CppStructArray_1_Byte_Int32_Int32_Stream_IntPtr_0;

		// Token: 0x04001625 RID: 5669
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamSeek_Internal_Static_Void_Int64_UInt32_Stream_IntPtr_0;

		// Token: 0x04001626 RID: 5670
		private static readonly IntPtr NativeMethodInfoPtr_ManagedStreamLength_Internal_Static_Void_Stream_IntPtr_0;
	}
}
