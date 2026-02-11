using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x02000082 RID: 130
	public class PositionInfo : Object
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x000593BC File Offset: 0x000575BC
		// Note: this type is marked as 'beforefieldinit'.
		static PositionInfo()
		{
			Il2CppClassPointerStore<PositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "PositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr);
			PositionInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665823);
			PositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665824);
			PositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665825);
			PositionInfo.NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665826);
			PositionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665827);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00059450 File Offset: 0x00057650
		[CallerCount(184)]
		[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool HasLineInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionInfo.NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000F58 RID: 3928 RVA: 0x00059498 File Offset: 0x00057698
		public unsafe virtual int LineNumber
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000F59 RID: 3929 RVA: 0x000594E0 File Offset: 0x000576E0
		public unsafe virtual int LinePosition
		{
			[CallerCount(74)]
			[CachedScanResults(RefRangeStart = 27932, RefRangeEnd = 28006, XrefRangeStart = 27932, XrefRangeEnd = 28006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00059528 File Offset: 0x00057728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 376276, RefRangeEnd = 376280, XrefRangeStart = 376268, XrefRangeEnd = 376276, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PositionInfo GetPositionInfo(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionInfo.NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x0005956C File Offset: 0x0005776C
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00006F94 File Offset: 0x00005194
		public PositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000C76 RID: 3190
		private static readonly IntPtr NativeMethodInfoPtr_HasLineInfo_Public_Virtual_New_Boolean_0;

		// Token: 0x04000C77 RID: 3191
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000C78 RID: 3192
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000C79 RID: 3193
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0;

		// Token: 0x04000C7A RID: 3194
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
