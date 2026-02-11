using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Xml.Linq
{
	// Token: 0x02000004 RID: 4
	public class LineInfoAnnotation : Object
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002E18 File Offset: 0x00001018
		// Note: this type is marked as 'beforefieldinit'.
		static LineInfoAnnotation()
		{
			Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.Linq.dll", "System.Xml.Linq", "LineInfoAnnotation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr);
			LineInfoAnnotation.NativeFieldInfoPtr_lineNumber = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr, "lineNumber");
			LineInfoAnnotation.NativeFieldInfoPtr_linePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr, "linePosition");
			LineInfoAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr, 100663300);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002E84 File Offset: 0x00001084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 313224, RefRangeEnd = 313226, XrefRangeStart = 313224, XrefRangeEnd = 313226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LineInfoAnnotation(int lineNumber, int linePosition)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LineInfoAnnotation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lineNumber;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref linePosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LineInfoAnnotation.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002081 File Offset: 0x00000281
		public LineInfoAnnotation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00002EDC File Offset: 0x000010DC
		// (set) Token: 0x0600000E RID: 14 RVA: 0x0000208A File Offset: 0x0000028A
		public unsafe int lineNumber
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LineInfoAnnotation.NativeFieldInfoPtr_lineNumber);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LineInfoAnnotation.NativeFieldInfoPtr_lineNumber)) = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002F04 File Offset: 0x00001104
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020A5 File Offset: 0x000002A5
		public unsafe int linePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LineInfoAnnotation.NativeFieldInfoPtr_linePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LineInfoAnnotation.NativeFieldInfoPtr_linePosition)) = value;
			}
		}

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_lineNumber;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_linePosition;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;
	}
}
