using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace dwd.core.bundles
{
	// Token: 0x020001FC RID: 508
	public sealed class BundleReference : Object
	{
		// Token: 0x06001C3B RID: 7227 RVA: 0x00083704 File Offset: 0x00081904
		// Note: this type is marked as 'beforefieldinit'.
		static BundleReference()
		{
			Il2CppClassPointerStore<BundleReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("core-canis.dll", "dwd.core.bundles", "BundleReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BundleReference>.NativeClassPtr);
			BundleReference.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, "request");
			BundleReference.NativeMethodInfoPtr__ctor_Public_Void_AssetBundleRequest_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667776);
			BundleReference.NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667777);
			BundleReference.NativeMethodInfoPtr_get_Error_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667778);
			BundleReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667779);
			BundleReference.NativeMethodInfoPtr_assertNotDisposed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667780);
			BundleReference.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667781);
			BundleReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BundleReference>.NativeClassPtr, 100667782);
		}

		// Token: 0x06001C3C RID: 7228 RVA: 0x000837D4 File Offset: 0x000819D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885402, XrefRangeEnd = 885410, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BundleReference(AssetBundleRequest request)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BundleReference>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr__ctor_Public_Void_AssetBundleRequest_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00083820 File Offset: 0x00081A20
		public unsafe bool Loaded
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x0008385C File Offset: 0x00081A5C
		public unsafe string Error
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_get_Error_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00083894 File Offset: 0x00081A94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885410, XrefRangeEnd = 885416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x000838C8 File Offset: 0x00081AC8
		[CallerCount(0)]
		public unsafe void assertNotDisposed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_assertNotDisposed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x000838FC File Offset: 0x00081AFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885416, XrefRangeEnd = 885422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x0008393C File Offset: 0x00081B3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 885422, XrefRangeEnd = 885427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BundleReference.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x0000C2A9 File Offset: 0x0000A4A9
		public BundleReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00083970 File Offset: 0x00081B70
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x0000C2B2 File Offset: 0x0000A4B2
		public unsafe AssetBundleRequest request
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleReference.NativeFieldInfoPtr_request);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AssetBundleRequest>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BundleReference.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040013C8 RID: 5064
		private static readonly IntPtr NativeFieldInfoPtr_request;

		// Token: 0x040013C9 RID: 5065
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AssetBundleRequest_0;

		// Token: 0x040013CA RID: 5066
		private static readonly IntPtr NativeMethodInfoPtr_get_Loaded_Public_get_Boolean_0;

		// Token: 0x040013CB RID: 5067
		private static readonly IntPtr NativeMethodInfoPtr_get_Error_Public_get_String_0;

		// Token: 0x040013CC RID: 5068
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x040013CD RID: 5069
		private static readonly IntPtr NativeMethodInfoPtr_assertNotDisposed_Private_Void_0;

		// Token: 0x040013CE RID: 5070
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Private_Void_Boolean_0;

		// Token: 0x040013CF RID: 5071
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;
	}
}
