using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.IO
{
	// Token: 0x02000545 RID: 1349
	public class FileStreamAsyncResult : Object
	{
		// Token: 0x06005330 RID: 21296 RVA: 0x00183918 File Offset: 0x00181B18
		// Note: this type is marked as 'beforefieldinit'.
		static FileStreamAsyncResult()
		{
			Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileStreamAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr);
			FileStreamAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "state");
			FileStreamAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completed");
			FileStreamAsyncResult.NativeFieldInfoPtr_wh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "wh");
			FileStreamAsyncResult.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "cb");
			FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completedSynch");
			FileStreamAsyncResult.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "Count");
			FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "OriginalCount");
			FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "BytesRead");
			FileStreamAsyncResult.NativeFieldInfoPtr_realcb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "realcb");
			FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676060);
			FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676061);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676062);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676063);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676064);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100676065);
		}

		// Token: 0x06005331 RID: 21297 RVA: 0x00183A74 File Offset: 0x00181C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433057, XrefRangeEnd = 1433072, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStreamAsyncResult(AsyncCallback cb, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005332 RID: 21298 RVA: 0x00183AD4 File Offset: 0x00181CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1433072, XrefRangeEnd = 1433075, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CBWrapper(IAsyncResult ares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001528 RID: 5416
		// (get) Token: 0x06005333 RID: 21299 RVA: 0x00183B0C File Offset: 0x00181D0C
		public unsafe virtual Object AsyncState
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17001529 RID: 5417
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x00183B4C File Offset: 0x00181D4C
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700152A RID: 5418
		// (get) Token: 0x06005335 RID: 21301 RVA: 0x00183B88 File Offset: 0x00181D88
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700152B RID: 5419
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x00183BC8 File Offset: 0x00181DC8
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06005337 RID: 21303 RVA: 0x0001D809 File Offset: 0x0001BA09
		public FileStreamAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x00183C04 File Offset: 0x00181E04
		// (set) Token: 0x06005339 RID: 21305 RVA: 0x0001D812 File Offset: 0x0001BA12
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x0600533A RID: 21306 RVA: 0x00183C34 File Offset: 0x00181E34
		// (set) Token: 0x0600533B RID: 21307 RVA: 0x0001D831 File Offset: 0x0001BA31
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x0600533C RID: 21308 RVA: 0x00183C5C File Offset: 0x00181E5C
		// (set) Token: 0x0600533D RID: 21309 RVA: 0x0001D84C File Offset: 0x0001BA4C
		public unsafe ManualResetEvent wh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x0600533E RID: 21310 RVA: 0x00183C8C File Offset: 0x00181E8C
		// (set) Token: 0x0600533F RID: 21311 RVA: 0x0001D86B File Offset: 0x0001BA6B
		public unsafe AsyncCallback cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x06005340 RID: 21312 RVA: 0x00183CBC File Offset: 0x00181EBC
		// (set) Token: 0x06005341 RID: 21313 RVA: 0x0001D88A File Offset: 0x0001BA8A
		public unsafe bool completedSynch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch)) = value;
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x06005342 RID: 21314 RVA: 0x00183CE4 File Offset: 0x00181EE4
		// (set) Token: 0x06005343 RID: 21315 RVA: 0x0001D8A5 File Offset: 0x0001BAA5
		public unsafe int Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count)) = value;
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x06005344 RID: 21316 RVA: 0x00183D0C File Offset: 0x00181F0C
		// (set) Token: 0x06005345 RID: 21317 RVA: 0x0001D8C0 File Offset: 0x0001BAC0
		public unsafe int OriginalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount)) = value;
			}
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06005346 RID: 21318 RVA: 0x00183D34 File Offset: 0x00181F34
		// (set) Token: 0x06005347 RID: 21319 RVA: 0x0001D8DB File Offset: 0x0001BADB
		public unsafe int BytesRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead)) = value;
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06005348 RID: 21320 RVA: 0x00183D5C File Offset: 0x00181F5C
		// (set) Token: 0x06005349 RID: 21321 RVA: 0x0001D8F6 File Offset: 0x0001BAF6
		public unsafe AsyncCallback realcb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043F0 RID: 17392
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x040043F1 RID: 17393
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x040043F2 RID: 17394
		private static readonly IntPtr NativeFieldInfoPtr_wh;

		// Token: 0x040043F3 RID: 17395
		private static readonly IntPtr NativeFieldInfoPtr_cb;

		// Token: 0x040043F4 RID: 17396
		private static readonly IntPtr NativeFieldInfoPtr_completedSynch;

		// Token: 0x040043F5 RID: 17397
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x040043F6 RID: 17398
		private static readonly IntPtr NativeFieldInfoPtr_OriginalCount;

		// Token: 0x040043F7 RID: 17399
		private static readonly IntPtr NativeFieldInfoPtr_BytesRead;

		// Token: 0x040043F8 RID: 17400
		private static readonly IntPtr NativeFieldInfoPtr_realcb;

		// Token: 0x040043F9 RID: 17401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x040043FA RID: 17402
		private static readonly IntPtr NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0;

		// Token: 0x040043FB RID: 17403
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x040043FC RID: 17404
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040043FD RID: 17405
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x040043FE RID: 17406
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;
	}
}
