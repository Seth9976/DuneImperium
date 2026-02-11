using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x02000006 RID: 6
	public sealed class DictionaryAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002BB8 File Offset: 0x00000DB8
		// Note: this type is marked as 'beforefieldinit'.
		static DictionaryAnalyzer()
		{
			Il2CppClassPointerStore<DictionaryAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DictionaryAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DictionaryAnalyzer>.NativeClassPtr);
			DictionaryAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryAnalyzer>.NativeClassPtr, 100663303);
			DictionaryAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DictionaryAnalyzer>.NativeClassPtr, 100663304);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C10 File Offset: 0x00000E10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247827, XrefRangeEnd = 1247858, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DictionaryAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DictionaryAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DictionaryAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002C4C File Offset: 0x00000E4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247858, XrefRangeEnd = 1247874, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(tokens);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(targetType);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DictionaryAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000020E7 File Offset: 0x000002E7
		public DictionaryAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
