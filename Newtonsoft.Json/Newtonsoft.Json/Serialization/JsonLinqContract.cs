using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x0200008C RID: 140
	public class JsonLinqContract : JsonContract
	{
		// Token: 0x06000B73 RID: 2931 RVA: 0x00005AE9 File Offset: 0x00003CE9
		// Note: this type is marked as 'beforefieldinit'.
		static JsonLinqContract()
		{
			Il2CppClassPointerStore<JsonLinqContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonLinqContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonLinqContract>.NativeClassPtr);
			JsonLinqContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonLinqContract>.NativeClassPtr, 100665412);
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x00046384 File Offset: 0x00044584
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 749908, XrefRangeEnd = 749909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonLinqContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonLinqContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonLinqContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00005B22 File Offset: 0x00003D22
		public JsonLinqContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000954 RID: 2388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
