using System;
using Canis.json;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.attributes
{
	// Token: 0x02000010 RID: 16
	public sealed class AttributeAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000693C File Offset: 0x00004B3C
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeAnalyzer()
		{
			Il2CppClassPointerStore<AttributeAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "AttributeAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeAnalyzer>.NativeClassPtr);
			AttributeAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeAnalyzer>.NativeClassPtr, 100663352);
			AttributeAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeAnalyzer>.NativeClassPtr, 100663353);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00006994 File Offset: 0x00004B94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215637, XrefRangeEnd = 1215660, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttributeAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AttributeAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000069D0 File Offset: 0x00004BD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215660, XrefRangeEnd = 1215669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AttributeAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002A35 File Offset: 0x00000C35
		public AttributeAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
