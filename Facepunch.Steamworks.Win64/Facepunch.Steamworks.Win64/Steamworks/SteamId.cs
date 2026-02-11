using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks
{
	// Token: 0x020000C1 RID: 193
	[StructLayout(2)]
	public struct SteamId
	{
		// Token: 0x06000C83 RID: 3203 RVA: 0x00052F80 File Offset: 0x00051180
		// Note: this type is marked as 'beforefieldinit'.
		static SteamId()
		{
			Il2CppClassPointerStore<SteamId>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks", "SteamId");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SteamId>.NativeClassPtr);
			SteamId.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SteamId>.NativeClassPtr, "Value");
			SteamId.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamId>.NativeClassPtr, 100666378);
			SteamId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamId>.NativeClassPtr, 100666379);
			SteamId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamId>.NativeClassPtr, 100666380);
			SteamId.NativeMethodInfoPtr_get_AccountId_Public_get_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamId>.NativeClassPtr, 100666381);
			SteamId.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SteamId>.NativeClassPtr, 100666382);
		}

		// Token: 0x06000C84 RID: 3204 RVA: 0x00053028 File Offset: 0x00051228
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator SteamId(ulong value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamId.NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_UInt64_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C85 RID: 3205 RVA: 0x00053068 File Offset: 0x00051268
		[CallerCount(1295)]
		[CachedScanResults(RefRangeStart = 308780, RefRangeEnd = 310075, XrefRangeStart = 308780, XrefRangeEnd = 310075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ulong(SteamId value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamId.NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamId_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C86 RID: 3206 RVA: 0x000530A8 File Offset: 0x000512A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 947268, XrefRangeEnd = 947269, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamId.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x000530D4 File Offset: 0x000512D4
		public unsafe uint AccountId
		{
			[CallerCount(200)]
			[CachedScanResults(RefRangeStart = 306429, RefRangeEnd = 306629, XrefRangeStart = 306429, XrefRangeEnd = 306629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamId.NativeMethodInfoPtr_get_AccountId_Public_get_UInt32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00053104 File Offset: 0x00051304
		public unsafe bool IsValid
		{
			[CallerCount(12)]
			[CachedScanResults(RefRangeStart = 608772, RefRangeEnd = 608784, XrefRangeStart = 608772, XrefRangeEnd = 608784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SteamId.NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C89 RID: 3209 RVA: 0x000031AC File Offset: 0x000013AC
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SteamId>.NativeClassPtr, ref this));
		}

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_SteamId_UInt64_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_UInt64_SteamId_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_get_AccountId_Public_get_UInt32_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_get_IsValid_Public_get_Boolean_0;

		// Token: 0x0400131C RID: 4892
		[FieldOffset(0)]
		public ulong Value;
	}
}
