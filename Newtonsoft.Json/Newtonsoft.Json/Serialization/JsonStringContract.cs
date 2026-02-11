using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Serialization
{
	// Token: 0x02000095 RID: 149
	public class JsonStringContract : JsonPrimitiveContract
	{
		// Token: 0x06000D04 RID: 3332 RVA: 0x0000637E File Offset: 0x0000457E
		// Note: this type is marked as 'beforefieldinit'.
		static JsonStringContract()
		{
			Il2CppClassPointerStore<JsonStringContract>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Serialization", "JsonStringContract");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonStringContract>.NativeClassPtr);
			JsonStringContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonStringContract>.NativeClassPtr, 100665686);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x0004E618 File Offset: 0x0004C818
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 753163, RefRangeEnd = 753164, XrefRangeStart = 753159, XrefRangeEnd = 753163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonStringContract(Type underlyingType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonStringContract>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(underlyingType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonStringContract.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D06 RID: 3334 RVA: 0x000063B7 File Offset: 0x000045B7
		public JsonStringContract(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000A96 RID: 2710
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
