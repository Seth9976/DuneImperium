using System;
using Canis.json;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Networking.selection.json.analyzers
{
	// Token: 0x02000091 RID: 145
	public class SquareCoordsAnalyzer : DwdTypeAnalyzer
	{
		// Token: 0x060004C8 RID: 1224 RVA: 0x00012F84 File Offset: 0x00011184
		// Note: this type is marked as 'beforefieldinit'.
		static SquareCoordsAnalyzer()
		{
			Il2CppClassPointerStore<SquareCoordsAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.json.analyzers", "SquareCoordsAnalyzer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SquareCoordsAnalyzer>.NativeClassPtr);
			SquareCoordsAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsAnalyzer>.NativeClassPtr, 100663618);
			SquareCoordsAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SquareCoordsAnalyzer>.NativeClassPtr, 100663619);
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00012FDC File Offset: 0x000111DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195128, XrefRangeEnd = 1195144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SquareCoordsAnalyzer()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SquareCoordsAnalyzer>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SquareCoordsAnalyzer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00013018 File Offset: 0x00011218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1195144, XrefRangeEnd = 1195146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SquareCoordsAnalyzer.NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			result = ((intPtr4 == 0) ? null : new Object(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004E3E File Offset: 0x0000303E
		public SquareCoordsAnalyzer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000299 RID: 665
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400029A RID: 666
		private static readonly IntPtr NativeMethodInfoPtr_Analyze_Public_Virtual_Boolean_DwdModelAnalyzer_MorePeekableStream_Type_byref_Object_0;
	}
}
