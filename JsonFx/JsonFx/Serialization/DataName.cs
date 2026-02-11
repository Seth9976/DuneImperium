using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JsonFx.Serialization
{
	// Token: 0x02000004 RID: 4
	public static class DataName : Object
	{
		// Token: 0x06000010 RID: 16 RVA: 0x000040C8 File Offset: 0x000022C8
		// Note: this type is marked as 'beforefieldinit'.
		static DataName()
		{
			Il2CppClassPointerStore<DataName>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization", "DataName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataName>.NativeClassPtr);
			DataName.NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataName>.NativeClassPtr, 100663308);
			DataName.NativeMethodInfoPtr_GetStandardPrefix_Internal_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataName>.NativeClassPtr, 100663309);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00004120 File Offset: 0x00002320
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1189684, RefRangeEnd = 1189686, XrefRangeStart = 1189651, XrefRangeEnd = 1189684, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetTypeName(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataName.NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000415C File Offset: 0x0000235C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1189686, XrefRangeEnd = 1189707, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetStandardPrefix(string namespaceUri)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(namespaceUri);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataName.NativeMethodInfoPtr_GetStandardPrefix_Internal_Static_String_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002062 File Offset: 0x00000262
		public DataName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_GetTypeName_Public_Static_String_Type_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_GetStandardPrefix_Internal_Static_String_String_0;
	}
}
