using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000083 RID: 131
	public class ReaderPositionInfo : PositionInfo
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x000595A8 File Offset: 0x000577A8
		// Note: this type is marked as 'beforefieldinit'.
		static ReaderPositionInfo()
		{
			Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ReaderPositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr);
			ReaderPositionInfo.NativeFieldInfoPtr_lineInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, "lineInfo");
			ReaderPositionInfo.NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665828);
			ReaderPositionInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665829);
			ReaderPositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665830);
			ReaderPositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr, 100665831);
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0005963C File Offset: 0x0005783C
		[CallerCount(148)]
		[CachedScanResults(RefRangeStart = 286435, RefRangeEnd = 286583, XrefRangeStart = 286435, XrefRangeEnd = 286583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReaderPositionInfo(IXmlLineInfo lineInfo)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReaderPositionInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(lineInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReaderPositionInfo.NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00059688 File Offset: 0x00057888
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376280, XrefRangeEnd = 376284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReaderPositionInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000F60 RID: 3936 RVA: 0x000596D0 File Offset: 0x000578D0
		public unsafe override int LineNumber
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376284, XrefRangeEnd = 376288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReaderPositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000F61 RID: 3937 RVA: 0x00059718 File Offset: 0x00057918
		public unsafe override int LinePosition
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 376288, XrefRangeEnd = 376292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ReaderPositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00006F9D File Offset: 0x0000519D
		public ReaderPositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000F63 RID: 3939 RVA: 0x00059760 File Offset: 0x00057960
		// (set) Token: 0x06000F64 RID: 3940 RVA: 0x00006FA6 File Offset: 0x000051A6
		public unsafe IXmlLineInfo lineInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderPositionInfo.NativeFieldInfoPtr_lineInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IXmlLineInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReaderPositionInfo.NativeFieldInfoPtr_lineInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000C7B RID: 3195
		private static readonly IntPtr NativeFieldInfoPtr_lineInfo;

		// Token: 0x04000C7C RID: 3196
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IXmlLineInfo_0;

		// Token: 0x04000C7D RID: 3197
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_Boolean_0;

		// Token: 0x04000C7E RID: 3198
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_get_Int32_0;

		// Token: 0x04000C7F RID: 3199
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_get_Int32_0;
	}
}
