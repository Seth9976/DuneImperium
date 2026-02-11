using System;
using boardgames.camera;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.match.validators
{
	// Token: 0x02000250 RID: 592
	public class CameraStationaryValidator : MonoBehaviour
	{
		// Token: 0x06001AF4 RID: 6900 RVA: 0x000755DC File Offset: 0x000737DC
		// Note: this type is marked as 'beforefieldinit'.
		static CameraStationaryValidator()
		{
			Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.match.validators", "CameraStationaryValidator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr);
			CameraStationaryValidator.NativeFieldInfoPtr_cameraLocationManager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr, "cameraLocationManager");
			CameraStationaryValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr, 100667593);
			CameraStationaryValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr, 100667594);
			CameraStationaryValidator.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr, 100667595);
			CameraStationaryValidator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr, 100667596);
		}

		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06001AF5 RID: 6901 RVA: 0x00075670 File Offset: 0x00073870
		// (set) Token: 0x06001AF6 RID: 6902 RVA: 0x000756AC File Offset: 0x000738AC
		public unsafe virtual bool Valid
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532878, XrefRangeEnd = 532879, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraStationaryValidator.NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraStationaryValidator.NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06001AF7 RID: 6903 RVA: 0x000756EC File Offset: 0x000738EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 532879, XrefRangeEnd = 532882, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraStationaryValidator.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF8 RID: 6904 RVA: 0x00075720 File Offset: 0x00073920
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CameraStationaryValidator()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CameraStationaryValidator>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CameraStationaryValidator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001AF9 RID: 6905 RVA: 0x0000EB80 File Offset: 0x0000CD80
		public CameraStationaryValidator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06001AFA RID: 6906 RVA: 0x0007575C File Offset: 0x0007395C
		// (set) Token: 0x06001AFB RID: 6907 RVA: 0x0000EB89 File Offset: 0x0000CD89
		public unsafe CameraLocationManager cameraLocationManager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraStationaryValidator.NativeFieldInfoPtr_cameraLocationManager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CameraLocationManager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CameraStationaryValidator.NativeFieldInfoPtr_cameraLocationManager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_cameraLocationManager;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeMethodInfoPtr_get_Valid_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeMethodInfoPtr_set_Valid_Public_Virtual_Final_New_set_Void_Boolean_0;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
