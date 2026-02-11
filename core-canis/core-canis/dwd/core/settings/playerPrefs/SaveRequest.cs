using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dwd.core.settings.playerPrefs
{
	// Token: 0x020000D3 RID: 211
	public class SaveRequest : Object
	{
		// Token: 0x06000CF3 RID: 3315 RVA: 0x000458F4 File Offset: 0x00043AF4
		// Note: this type is marked as 'beforefieldinit'.
		static SaveRequest()
		{
			Il2CppClassPointerStore<SaveRequest>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.settings.playerPrefs", "SaveRequest");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr);
			SaveRequest.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665133);
			SaveRequest.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665134);
			SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr, 100665135);
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00045960 File Offset: 0x00043B60
		public unsafe virtual bool Completed
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000CF5 RID: 3317 RVA: 0x0004599C File Offset: 0x00043B9C
		public unsafe virtual bool Success
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 25017, RefRangeEnd = 25031, XrefRangeStart = 25017, XrefRangeEnd = 25031, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000CF6 RID: 3318 RVA: 0x000459D8 File Offset: 0x00043BD8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SaveRequest()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveRequest>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SaveRequest.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000CF7 RID: 3319 RVA: 0x000068B1 File Offset: 0x00004AB1
		public SaveRequest(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400094F RID: 2383
		private static readonly IntPtr NativeMethodInfoPtr_get_Completed_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000950 RID: 2384
		private static readonly IntPtr NativeMethodInfoPtr_get_Success_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
