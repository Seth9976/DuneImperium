using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000157 RID: 343
	public static class KnownTerminals : Object
	{
		// Token: 0x06001766 RID: 5990 RVA: 0x0009586C File Offset: 0x00093A6C
		// Note: this type is marked as 'beforefieldinit'.
		static KnownTerminals()
		{
			Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "KnownTerminals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr);
			KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100667393);
			KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100667394);
			KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KnownTerminals>.NativeClassPtr, 100667395);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x000958D8 File Offset: 0x00093AD8
		public unsafe static Il2CppStructArray<byte> linux
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346472, XrefRangeEnd = 1346478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001768 RID: 5992 RVA: 0x0009590C File Offset: 0x00093B0C
		public unsafe static Il2CppStructArray<byte> xterm
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346478, XrefRangeEnd = 1346484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x00095940 File Offset: 0x00093B40
		public unsafe static Il2CppStructArray<byte> ansi
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1346484, XrefRangeEnd = 1346490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KnownTerminals.NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00007676 File Offset: 0x00005876
		public KnownTerminals(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001421 RID: 5153
		private static readonly IntPtr NativeMethodInfoPtr_get_linux_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001422 RID: 5154
		private static readonly IntPtr NativeMethodInfoPtr_get_xterm_Public_Static_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x04001423 RID: 5155
		private static readonly IntPtr NativeMethodInfoPtr_get_ansi_Public_Static_get_Il2CppStructArray_1_Byte_0;
	}
}
