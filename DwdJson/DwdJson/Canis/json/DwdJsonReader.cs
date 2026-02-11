using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using JsonFx.Json;
using JsonFx.Serialization;

namespace Canis.json
{
	// Token: 0x02000012 RID: 18
	public sealed class DwdJsonReader : JsonReader
	{
		// Token: 0x0600007C RID: 124 RVA: 0x000023C7 File Offset: 0x000005C7
		// Note: this type is marked as 'beforefieldinit'.
		static DwdJsonReader()
		{
			Il2CppClassPointerStore<DwdJsonReader>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdJsonReader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdJsonReader>.NativeClassPtr);
			DwdJsonReader.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdJsonReader>.NativeClassPtr, 100663347);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000425C File Offset: 0x0000245C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1248502, XrefRangeEnd = 1248519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdJsonReader(DataReaderSettings settings)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdJsonReader>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(settings);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdJsonReader.NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002400 File Offset: 0x00000600
		public DwdJsonReader(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DataReaderSettings_0;
	}
}
