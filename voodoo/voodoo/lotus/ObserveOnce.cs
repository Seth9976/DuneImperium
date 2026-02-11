using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace lotus
{
	// Token: 0x02000065 RID: 101
	public class ObserveOnce : Observer
	{
		// Token: 0x0600060B RID: 1547 RVA: 0x0001D6E0 File Offset: 0x0001B8E0
		// Note: this type is marked as 'beforefieldinit'.
		static ObserveOnce()
		{
			Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr = IL2CPP.GetIl2CppClass("voodoo.dll", "lotus", "ObserveOnce");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr);
			ObserveOnce.NativeFieldInfoPtr_initialized = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, "initialized");
			ObserveOnce.NativeFieldInfoPtr_cachedData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, "cachedData");
			ObserveOnce.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, 100664127);
			ObserveOnce.NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, 100664128);
			ObserveOnce.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, 100664129);
			ObserveOnce.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, 100664130);
			ObserveOnce.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr, 100664131);
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0001D79C File Offset: 0x0001B99C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112729, XrefRangeEnd = 1112740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveOnce.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0001D7D0 File Offset: 0x0001B9D0
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 364726, RefRangeEnd = 364739, XrefRangeStart = 364726, XrefRangeEnd = 364739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void onSpawn(PoolableItem pi)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pi);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveOnce.NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0001D820 File Offset: 0x0001BA20
		[CallerCount(0)]
		public unsafe virtual bool Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveOnce.NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001D868 File Offset: 0x0001BA68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1112740, XrefRangeEnd = 1112745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void DirtyUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObserveOnce.NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0001D8A4 File Offset: 0x0001BAA4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObserveOnce()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObserveOnce>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObserveOnce.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x00004FDC File Offset: 0x000031DC
		public ObserveOnce(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x0001D8E0 File Offset: 0x0001BAE0
		// (set) Token: 0x06000613 RID: 1555 RVA: 0x00004FE5 File Offset: 0x000031E5
		public unsafe bool initialized
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveOnce.NativeFieldInfoPtr_initialized);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveOnce.NativeFieldInfoPtr_initialized)) = value;
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000614 RID: 1556 RVA: 0x0001D908 File Offset: 0x0001BB08
		// (set) Token: 0x06000615 RID: 1557 RVA: 0x00005000 File Offset: 0x00003200
		public unsafe EntityComponent cachedData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveOnce.NativeFieldInfoPtr_cachedData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityComponent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObserveOnce.NativeFieldInfoPtr_cachedData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CB RID: 971
		private static readonly IntPtr NativeFieldInfoPtr_initialized;

		// Token: 0x040003CC RID: 972
		private static readonly IntPtr NativeFieldInfoPtr_cachedData;

		// Token: 0x040003CD RID: 973
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x040003CE RID: 974
		private static readonly IntPtr NativeMethodInfoPtr_onSpawn_Protected_Virtual_New_Void_PoolableItem_0;

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Protected_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_DirtyUpdate_Public_Virtual_Void_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
