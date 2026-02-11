using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dbgclient.data
{
	// Token: 0x020000D7 RID: 215
	[Serializable]
	public sealed class StringValuePair : ValueType
	{
		// Token: 0x0600091B RID: 2331 RVA: 0x0003A49C File Offset: 0x0003869C
		// Note: this type is marked as 'beforefieldinit'.
		static StringValuePair()
		{
			Il2CppClassPointerStore<StringValuePair>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbgclient.data", "StringValuePair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr);
			StringValuePair.NativeFieldInfoPtr_key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr, "key");
			StringValuePair.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr, "value");
			StringValuePair.NativeMethodInfoPtr_get_kvp_Public_get_KeyValuePair_2_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr, 100664606);
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0003A508 File Offset: 0x00038708
		public unsafe KeyValuePair<string, string> kvp
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 505192, XrefRangeEnd = 505195, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StringValuePair.NativeMethodInfoPtr_get_kvp_Public_get_KeyValuePair_2_String_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new KeyValuePair<string, string>(intPtr);
			}
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0000646A File Offset: 0x0000466A
		public StringValuePair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00006473 File Offset: 0x00004673
		public StringValuePair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StringValuePair>.NativeClassPtr))
		{
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0003A544 File Offset: 0x00038744
		// (set) Token: 0x06000920 RID: 2336 RVA: 0x00006485 File Offset: 0x00004685
		public unsafe string key
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValuePair.NativeFieldInfoPtr_key);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValuePair.NativeFieldInfoPtr_key), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0003A56C File Offset: 0x0003876C
		// (set) Token: 0x06000922 RID: 2338 RVA: 0x000064A4 File Offset: 0x000046A4
		public unsafe string value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValuePair.NativeFieldInfoPtr_value);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StringValuePair.NativeFieldInfoPtr_value), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0400058D RID: 1421
		private static readonly IntPtr NativeFieldInfoPtr_key;

		// Token: 0x0400058E RID: 1422
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x0400058F RID: 1423
		private static readonly IntPtr NativeMethodInfoPtr_get_kvp_Public_get_KeyValuePair_2_String_String_0;
	}
}
