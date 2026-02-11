using System;
using dwd.core.platform.providers;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace lib.canis.boardgames.src.notifications
{
	// Token: 0x0200003A RID: 58
	public class PlatformDataResponder : MonoBehaviour
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00018904 File Offset: 0x00016B04
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformDataResponder()
		{
			Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr = IL2CPP.GetIl2CppClass("boardgames.dll", "lib.canis.boardgames.src.notifications", "PlatformDataResponder");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr);
			PlatformDataResponder.NativeFieldInfoPtr_platformProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, "platformProvider");
			PlatformDataResponder.NativeMethodInfoPtr_get_Data_Protected_Abstract_Virtual_New_get_PlatformData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663730);
			PlatformDataResponder.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663731);
			PlatformDataResponder.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663732);
			PlatformDataResponder.NativeMethodInfoPtr_OnDisable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663733);
			PlatformDataResponder.NativeMethodInfoPtr_platformDataDirtied_Protected_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663734);
			PlatformDataResponder.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr, 100663735);
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000189C0 File Offset: 0x00016BC0
		public unsafe virtual PlatformData Data
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDataResponder.NativeMethodInfoPtr_get_Data_Protected_Abstract_Virtual_New_get_PlatformData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PlatformData>(intPtr3) : null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00018A0C File Offset: 0x00016C0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984819, XrefRangeEnd = 984823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDataResponder.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00018A40 File Offset: 0x00016C40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984823, XrefRangeEnd = 984829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDataResponder.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00018A74 File Offset: 0x00016C74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 984829, XrefRangeEnd = 984835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDataResponder.NativeMethodInfoPtr_OnDisable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00018AA8 File Offset: 0x00016CA8
		[CallerCount(0)]
		public unsafe virtual void platformDataDirtied()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlatformDataResponder.NativeMethodInfoPtr_platformDataDirtied_Protected_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00018AE4 File Offset: 0x00016CE4
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformDataResponder()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformDataResponder>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformDataResponder.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00003069 File Offset: 0x00001269
		public PlatformDataResponder(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00018B20 File Offset: 0x00016D20
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00003072 File Offset: 0x00001272
		public unsafe PlatformProvider platformProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDataResponder.NativeFieldInfoPtr_platformProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformProvider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlatformDataResponder.NativeFieldInfoPtr_platformProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400018A RID: 394
		private static readonly IntPtr NativeFieldInfoPtr_platformProvider;

		// Token: 0x0400018B RID: 395
		private static readonly IntPtr NativeMethodInfoPtr_get_Data_Protected_Abstract_Virtual_New_get_PlatformData_0;

		// Token: 0x0400018C RID: 396
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400018D RID: 397
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400018E RID: 398
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Private_Void_0;

		// Token: 0x0400018F RID: 399
		private static readonly IntPtr NativeMethodInfoPtr_platformDataDirtied_Protected_Abstract_Virtual_New_Void_0;

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
