using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem.Reflection;
using JsonFx.Json.Resolvers;

namespace dwd.core.platform.json
{
	// Token: 0x0200004D RID: 77
	public sealed class JsonWriteResolverStrategy : JsonResolverStrategy
	{
		// Token: 0x06000316 RID: 790 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		// Note: this type is marked as 'beforefieldinit'.
		static JsonWriteResolverStrategy()
		{
			Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.json", "JsonWriteResolverStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr);
			JsonWriteResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr, 100663792);
			JsonWriteResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr, 100663793);
			JsonWriteResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr, 100663794);
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000FA2C File Offset: 0x0000DC2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169847, XrefRangeEnd = 1169850, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsPropertyIgnored(PropertyInfo member, bool isImmutableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isImmutableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriteResolverStrategy.NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000FA88 File Offset: 0x0000DC88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1169850, XrefRangeEnd = 1169853, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsFieldIgnored(FieldInfo member, bool isImmutableType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(member);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isImmutableType;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriteResolverStrategy.NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000FAE4 File Offset: 0x0000DCE4
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe JsonWriteResolverStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<JsonWriteResolverStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonWriteResolverStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000036C2 File Offset: 0x000018C2
		public JsonWriteResolverStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000208 RID: 520
		private static readonly IntPtr NativeMethodInfoPtr_IsPropertyIgnored_Public_Virtual_Boolean_PropertyInfo_Boolean_0;

		// Token: 0x04000209 RID: 521
		private static readonly IntPtr NativeMethodInfoPtr_IsFieldIgnored_Public_Virtual_Boolean_FieldInfo_Boolean_0;

		// Token: 0x0400020A RID: 522
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
