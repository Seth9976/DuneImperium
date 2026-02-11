using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Steamworks.Data
{
	// Token: 0x020001B5 RID: 437
	public sealed class MatchMakingKeyValuePair : ValueType
	{
		// Token: 0x0600162C RID: 5676 RVA: 0x0006DE84 File Offset: 0x0006C084
		// Note: this type is marked as 'beforefieldinit'.
		static MatchMakingKeyValuePair()
		{
			Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Facepunch.Steamworks.Win64.dll", "Steamworks.Data", "MatchMakingKeyValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr);
			MatchMakingKeyValuePair.NativeFieldInfoPtr_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr, "Key");
			MatchMakingKeyValuePair.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr, "Value");
			MatchMakingKeyValuePair.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_MatchMakingKeyValuePair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr, 100667392);
		}

		// Token: 0x0600162D RID: 5677 RVA: 0x0006DEF0 File Offset: 0x0006C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 951106, XrefRangeEnd = 951117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InternalConstruct(ref MatchMakingKeyValuePair self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtrNotNull(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MatchMakingKeyValuePair.NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_MatchMakingKeyValuePair_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x00007640 File Offset: 0x00005840
		public MatchMakingKeyValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x00007649 File Offset: 0x00005849
		public MatchMakingKeyValuePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MatchMakingKeyValuePair>.NativeClassPtr))
		{
		}

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06001630 RID: 5680 RVA: 0x0006DF28 File Offset: 0x0006C128
		// (set) Token: 0x06001631 RID: 5681 RVA: 0x0000765B File Offset: 0x0000585B
		public unsafe string Key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair.NativeFieldInfoPtr_Key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair.NativeFieldInfoPtr_Key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06001632 RID: 5682 RVA: 0x0006DF50 File Offset: 0x0006C150
		// (set) Token: 0x06001633 RID: 5683 RVA: 0x0000767A File Offset: 0x0000587A
		public unsafe string Value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair.NativeFieldInfoPtr_Value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MatchMakingKeyValuePair.NativeFieldInfoPtr_Value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001B70 RID: 7024
		private static readonly IntPtr NativeFieldInfoPtr_Key;

		// Token: 0x04001B71 RID: 7025
		private static readonly IntPtr NativeFieldInfoPtr_Value;

		// Token: 0x04001B72 RID: 7026
		private static readonly IntPtr NativeMethodInfoPtr_InternalConstruct_Internal_Static_Void_byref_MatchMakingKeyValuePair_0;
	}
}
