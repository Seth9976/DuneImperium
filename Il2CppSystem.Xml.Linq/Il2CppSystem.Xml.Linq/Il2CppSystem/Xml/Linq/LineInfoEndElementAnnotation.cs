using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000005 RID: 5
	public class LineInfoEndElementAnnotation : LineInfoAnnotation
	{
		// Token: 0x06000011 RID: 17 RVA: 0x000020C0 File Offset: 0x000002C0
		// Note: this type is marked as 'beforefieldinit'.
		static LineInfoEndElementAnnotation()
		{
			Il2CppClassPointerStore<LineInfoEndElementAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "LineInfoEndElementAnnotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfoEndElementAnnotation>.NativeClassPtr);
			LineInfoEndElementAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfoEndElementAnnotation>.NativeClassPtr, 100663301);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002F2C File Offset: 0x0000112C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313224, RefRangeEnd = 313226, XrefRangeStart = 313224, XrefRangeEnd = 313226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineInfoEndElementAnnotation(int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineInfoEndElementAnnotation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfoEndElementAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000020F9 File Offset: 0x000002F9
		public LineInfoEndElementAnnotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
