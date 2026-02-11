using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000085 RID: 133
	[StructLayout(2)]
	public struct LineInfo
	{
		// Token: 0x06000F6A RID: 3946 RVA: 0x000598F4 File Offset: 0x00057AF4
		// Note: this type is marked as 'beforefieldinit'.
		static LineInfo()
		{
			Il2CppClassPointerStore<LineInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "LineInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfo>.NativeClassPtr);
			LineInfo.NativeFieldInfoPtr_lineNo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "lineNo");
			LineInfo.NativeFieldInfoPtr_linePos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, "linePos");
			LineInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, 100665835);
			LineInfo.NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, 100665836);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00059974 File Offset: 0x00057B74
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineInfo(int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfo.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x000599B4 File Offset: 0x00057BB4
		[CallerCount(39)]
		[CachedScanResults(RefRangeStart = 283577, RefRangeEnd = 283616, XrefRangeStart = 283577, XrefRangeEnd = 283616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Set(int lineNo, int linePos)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNo;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePos;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfo.NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00006FCE File Offset: 0x000051CE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LineInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x04000C83 RID: 3203
		private static readonly IntPtr NativeFieldInfoPtr_lineNo;

		// Token: 0x04000C84 RID: 3204
		private static readonly IntPtr NativeFieldInfoPtr_linePos;

		// Token: 0x04000C85 RID: 3205
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000C86 RID: 3206
		private static readonly IntPtr NativeMethodInfoPtr_Set_Public_Void_Int32_Int32_0;

		// Token: 0x04000C87 RID: 3207
		[FieldOffset(0)]
		public int lineNo;

		// Token: 0x04000C88 RID: 3208
		[FieldOffset(4)]
		public int linePos;
	}
}
