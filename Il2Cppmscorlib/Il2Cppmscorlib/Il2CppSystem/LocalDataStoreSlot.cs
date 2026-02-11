using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem
{
	// Token: 0x02000129 RID: 297
	public sealed class LocalDataStoreSlot : Object
	{
		// Token: 0x060013B3 RID: 5043 RVA: 0x00085148 File Offset: 0x00083348
		// Note: this type is marked as 'beforefieldinit'.
		static LocalDataStoreSlot()
		{
			Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "LocalDataStoreSlot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr);
			LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_mgr");
			LocalDataStoreSlot.NativeFieldInfoPtr_m_slot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_slot");
			LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, "m_cookie");
			LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666790);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666791);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666792);
			LocalDataStoreSlot.NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666793);
			LocalDataStoreSlot.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666794);
			LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr, 100666795);
		}

		// Token: 0x060013B4 RID: 5044 RVA: 0x0008522C File Offset: 0x0008342C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338115, XrefRangeEnd = 1338117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(mgr);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref slot;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref cookie;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060013B5 RID: 5045 RVA: 0x00085294 File Offset: 0x00083494
		public unsafe LocalDataStoreMgr Manager
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr3) : null;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060013B6 RID: 5046 RVA: 0x000852D4 File Offset: 0x000834D4
		public unsafe int Slot
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060013B7 RID: 5047 RVA: 0x00085310 File Offset: 0x00083510
		public unsafe long Cookie
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060013B8 RID: 5048 RVA: 0x0008534C File Offset: 0x0008354C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338117, XrefRangeEnd = 1338123, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x00085380 File Offset: 0x00083580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1338123, XrefRangeEnd = 1338126, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LocalDataStoreSlot()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LocalDataStoreSlot>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LocalDataStoreSlot.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x000064B1 File Offset: 0x000046B1
		public LocalDataStoreSlot(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060013BB RID: 5051 RVA: 0x000853BC File Offset: 0x000835BC
		// (set) Token: 0x060013BC RID: 5052 RVA: 0x000064BA File Offset: 0x000046BA
		public unsafe LocalDataStoreMgr m_mgr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalDataStoreMgr>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_mgr), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060013BD RID: 5053 RVA: 0x000853EC File Offset: 0x000835EC
		// (set) Token: 0x060013BE RID: 5054 RVA: 0x000064D9 File Offset: 0x000046D9
		public unsafe int m_slot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_slot);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_slot)) = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060013BF RID: 5055 RVA: 0x00085414 File Offset: 0x00083614
		// (set) Token: 0x060013C0 RID: 5056 RVA: 0x000064F4 File Offset: 0x000046F4
		public unsafe long m_cookie
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LocalDataStoreSlot.NativeFieldInfoPtr_m_cookie)) = value;
			}
		}

		// Token: 0x040010C1 RID: 4289
		private static readonly IntPtr NativeFieldInfoPtr_m_mgr;

		// Token: 0x040010C2 RID: 4290
		private static readonly IntPtr NativeFieldInfoPtr_m_slot;

		// Token: 0x040010C3 RID: 4291
		private static readonly IntPtr NativeFieldInfoPtr_m_cookie;

		// Token: 0x040010C4 RID: 4292
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_LocalDataStoreMgr_Int32_Int64_0;

		// Token: 0x040010C5 RID: 4293
		private static readonly IntPtr NativeMethodInfoPtr_get_Manager_Internal_get_LocalDataStoreMgr_0;

		// Token: 0x040010C6 RID: 4294
		private static readonly IntPtr NativeMethodInfoPtr_get_Slot_Internal_get_Int32_0;

		// Token: 0x040010C7 RID: 4295
		private static readonly IntPtr NativeMethodInfoPtr_get_Cookie_Internal_get_Int64_0;

		// Token: 0x040010C8 RID: 4296
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x040010C9 RID: 4297
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
