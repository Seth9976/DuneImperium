using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using lotus;

namespace boardgames.voodoo
{
	// Token: 0x0200009D RID: 157
	public class NotifiedObserver : DirtyBehaviour
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00027DF4 File Offset: 0x00025FF4
		// Note: this type is marked as 'beforefieldinit'.
		static NotifiedObserver()
		{
			Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "boardgames.voodoo", "NotifiedObserver");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr);
			NotifiedObserver.NativeFieldInfoPtr_updateWhenDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, "updateWhenDisabled");
			NotifiedObserver.NativeFieldInfoPtr_updateManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, "updateManager");
			NotifiedObserver.NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, 100664637);
			NotifiedObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, 100664638);
			NotifiedObserver.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, 100664639);
			NotifiedObserver.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr, 100664640);
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x00027E9C File Offset: 0x0002609C
		[CallerCount(0)]
		public unsafe virtual void start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotifiedObserver.NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x00027ED8 File Offset: 0x000260D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1117259, XrefRangeEnd = 1117260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00027F0C File Offset: 0x0002610C
		[CallerCount(0)]
		public unsafe virtual void dirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NotifiedObserver.NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00027F48 File Offset: 0x00026148
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1089620, RefRangeEnd = 1089621, XrefRangeStart = 1089620, XrefRangeEnd = 1089621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NotifiedObserver()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NotifiedObserver>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NotifiedObserver.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00006836 File Offset: 0x00004A36
		public NotifiedObserver(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x00027F84 File Offset: 0x00026184
		// (set) Token: 0x06000936 RID: 2358 RVA: 0x0000683F File Offset: 0x00004A3F
		public unsafe bool updateWhenDisabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver.NativeFieldInfoPtr_updateWhenDisabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver.NativeFieldInfoPtr_updateWhenDisabled)) = value;
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000937 RID: 2359 RVA: 0x00027FAC File Offset: 0x000261AC
		// (set) Token: 0x06000938 RID: 2360 RVA: 0x0000685A File Offset: 0x00004A5A
		public unsafe UpdateManager updateManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver.NativeFieldInfoPtr_updateManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UpdateManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NotifiedObserver.NativeFieldInfoPtr_updateManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040005BC RID: 1468
		private static readonly IntPtr NativeFieldInfoPtr_updateWhenDisabled;

		// Token: 0x040005BD RID: 1469
		private static readonly IntPtr NativeFieldInfoPtr_updateManager;

		// Token: 0x040005BE RID: 1470
		private static readonly IntPtr NativeMethodInfoPtr_start_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040005BF RID: 1471
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Final_Void_0;

		// Token: 0x040005C0 RID: 1472
		private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x040005C1 RID: 1473
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
