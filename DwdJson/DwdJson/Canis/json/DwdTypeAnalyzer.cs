using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x02000008 RID: 8
	public class DwdTypeAnalyzer : Object
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000037A0 File Offset: 0x000019A0
		// Note: this type is marked as 'beforefieldinit'.
		static DwdTypeAnalyzer()
		{
			Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "DwdTypeAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr);
			DwdTypeAnalyzer.NativeFieldInfoPtr_AnalyzedTypes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr, "AnalyzedTypes");
			DwdTypeAnalyzer.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr, 100663322);
			DwdTypeAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr, 100663323);
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000380C File Offset: 0x00001A0C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DwdTypeAnalyzer(Il2CppReferenceArray<Type> analyzedTypes)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DwdTypeAnalyzer>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(analyzedTypes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DwdTypeAnalyzer.NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00003858 File Offset: 0x00001A58
		[CallerCount(0)]
		public unsafe virtual bool Analyze(DwdModelAnalyzer analyzer, MorePeekableStream tokens, Type targetType, out Object result)
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DwdTypeAnalyzer.NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002233 File Offset: 0x00000433
		public DwdTypeAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600004D RID: 77 RVA: 0x000038F8 File Offset: 0x00001AF8
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000223C File Offset: 0x0000043C
		public unsafe Il2CppReferenceArray<Type> AnalyzedTypes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdTypeAnalyzer.NativeFieldInfoPtr_AnalyzedTypes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DwdTypeAnalyzer.NativeFieldInfoPtr_AnalyzedTypes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly IntPtr NativeFieldInfoPtr_AnalyzedTypes;

		// Token: 0x0400002C RID: 44
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Il2CppReferenceArray_1_Type_0;

		// Token: 0x0400002D RID: 45
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Abstract_Virtual_New_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
