using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Networking
{
	// Token: 0x0200000B RID: 11
	public class UploadHandler : Object
	{
		// Token: 0x0600013B RID: 315 RVA: 0x00006F60 File Offset: 0x00005160
		// Note: this type is marked as 'beforefieldinit'.
		static UploadHandler()
		{
			Il2CppClassPointerStore<UploadHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityWebRequestModule.dll", "UnityEngine.Networking", "UploadHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr);
			UploadHandler.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, "m_Ptr");
			UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663438);
			UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663439);
			UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663440);
			UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663441);
			UploadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663442);
			UploadHandler.NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663443);
			UploadHandler.NativeMethodInfoPtr_GetData_Internal_Virtual_New_Il2CppStructArray_1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663444);
			UploadHandler.NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663445);
			UploadHandler.NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr, 100663446);
			UploadHandler.InternalGetContentTypeDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetContentTypeDelegate>("UnityEngine.Networking.UploadHandler::InternalGetContentType");
			UploadHandler.InternalGetProgressDelegateField = IL2CPP.ResolveICall<UploadHandler.InternalGetProgressDelegate>("UnityEngine.Networking.UploadHandler::InternalGetProgress");
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00007078 File Offset: 0x00005278
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247759, XrefRangeEnd = 1247761, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x000070AC File Offset: 0x000052AC
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UploadHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UploadHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x000070E8 File Offset: 0x000052E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007124 File Offset: 0x00005324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247761, XrefRangeEnd = 1247764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00007160 File Offset: 0x00005360
		public unsafe Il2CppStructArray<byte> data
		{
			[CallerCount(55)]
			[CachedScanResults(RefRangeStart = 373745, RefRangeEnd = 373800, XrefRangeStart = 373745, XrefRangeEnd = 373800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000148 RID: 328 RVA: 0x000072EC File Offset: 0x000054EC
		// (set) Token: 0x06000141 RID: 321 RVA: 0x000071A0 File Offset: 0x000053A0
		public unsafe string contentType
		{
			get
			{
				return this.GetContentType();
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 283233, RefRangeEnd = 283236, XrefRangeStart = 283233, XrefRangeEnd = 283236, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x000071E4 File Offset: 0x000053E4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 320672, RefRangeEnd = 320673, XrefRangeStart = 320672, XrefRangeEnd = 320673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Il2CppStructArray<byte> GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_GetData_Internal_Virtual_New_Il2CppStructArray_1_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr3) : null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007230 File Offset: 0x00005430
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1247764, XrefRangeEnd = 1247766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetContentType(string newContentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newContentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UploadHandler.NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007280 File Offset: 0x00005480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InternalSetContentType(string newContentType)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(newContentType);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UploadHandler.NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x000025A6 File Offset: 0x000007A6
		public UploadHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000146 RID: 326 RVA: 0x000072C4 File Offset: 0x000054C4
		// (set) Token: 0x06000147 RID: 327 RVA: 0x000025AF File Offset: 0x000007AF
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UploadHandler.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000149 RID: 329 RVA: 0x00007304 File Offset: 0x00005504
		public float progress
		{
			get
			{
				return this.GetProgress();
			}
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000731C File Offset: 0x0000551C
		public virtual string GetContentType()
		{
			return this.InternalGetContentType();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00007334 File Offset: 0x00005534
		public virtual float GetProgress()
		{
			return this.InternalGetProgress();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000734C File Offset: 0x0000554C
		public string InternalGetContentType()
		{
			IntPtr intPtr = UploadHandler.InternalGetContentTypeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000025CA File Offset: 0x000007CA
		public float InternalGetProgress()
		{
			return UploadHandler.InternalGetProgressDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x040000C1 RID: 193
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x040000C2 RID: 194
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x040000C3 RID: 195
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x040000C4 RID: 196
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040000C5 RID: 197
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_New_Void_0;

		// Token: 0x040000C6 RID: 198
		private static readonly IntPtr NativeMethodInfoPtr_get_data_Public_get_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000C7 RID: 199
		private static readonly IntPtr NativeMethodInfoPtr_set_contentType_Public_set_Void_String_0;

		// Token: 0x040000C8 RID: 200
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Internal_Virtual_New_Il2CppStructArray_1_Byte_0;

		// Token: 0x040000C9 RID: 201
		private static readonly IntPtr NativeMethodInfoPtr_SetContentType_Internal_Virtual_New_Void_String_0;

		// Token: 0x040000CA RID: 202
		private static readonly IntPtr NativeMethodInfoPtr_InternalSetContentType_Private_Void_String_0;

		// Token: 0x040000CB RID: 203
		private static readonly UploadHandler.InternalGetContentTypeDelegate InternalGetContentTypeDelegateField;

		// Token: 0x040000CC RID: 204
		private static readonly UploadHandler.InternalGetProgressDelegate InternalGetProgressDelegateField;

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000184 RID: 388
		private delegate IntPtr InternalGetContentTypeDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000186 RID: 390
		private delegate float InternalGetProgressDelegate(IntPtr @this);
	}
}
