using System;
using boardgames.camera;
using dwd.core.input.compositeModule;
using dwd.core.input.compositeModule.inputDetection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace boardgames.input
{
	// Token: 0x0200013B RID: 315
	public class PlaymatHotKeyMovementHandler : MonoBehaviour
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x0004ADCC File Offset: 0x00048FCC
		// Note: this type is marked as 'beforefieldinit'.
		static PlaymatHotKeyMovementHandler()
		{
			Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "boardgames.input", "PlaymatHotKeyMovementHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr);
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_maxMoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "maxMoveSpeed");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_inputDetector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "inputDetector");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_cameraControlProvider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "cameraControlProvider");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_hotKeyDisabler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "hotKeyDisabler");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveVelocity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "endMoveVelocity");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveDamp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "endMoveDamp");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveSmoothTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "endMoveSmoothTime");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_moveVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "moveVector");
			PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_currentInputModuleType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, "currentInputModuleType");
			PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, 100665370);
			PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, 100665371);
			PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_updateCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, 100665372);
			PlaymatHotKeyMovementHandler.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr, 100665373);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x0004AF00 File Offset: 0x00049100
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511837, XrefRangeEnd = 511859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0004AF34 File Offset: 0x00049134
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511859, XrefRangeEnd = 511883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x0004AF68 File Offset: 0x00049168
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 511894, RefRangeEnd = 511895, XrefRangeStart = 511883, XrefRangeEnd = 511894, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void updateCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatHotKeyMovementHandler.NativeMethodInfoPtr_updateCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x0004AF9C File Offset: 0x0004919C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 511895, XrefRangeEnd = 511898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlaymatHotKeyMovementHandler()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlaymatHotKeyMovementHandler>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlaymatHotKeyMovementHandler.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00008E02 File Offset: 0x00007002
		public PlaymatHotKeyMovementHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000E44 RID: 3652 RVA: 0x0004AFD8 File Offset: 0x000491D8
		// (set) Token: 0x06000E45 RID: 3653 RVA: 0x00008E0B File Offset: 0x0000700B
		public unsafe float maxMoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_maxMoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_maxMoveSpeed)) = value;
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000E46 RID: 3654 RVA: 0x0004B000 File Offset: 0x00049200
		// (set) Token: 0x06000E47 RID: 3655 RVA: 0x00008E26 File Offset: 0x00007026
		public unsafe InputDetector inputDetector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_inputDetector);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_inputDetector), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000E48 RID: 3656 RVA: 0x0004B030 File Offset: 0x00049230
		// (set) Token: 0x06000E49 RID: 3657 RVA: 0x00008E45 File Offset: 0x00007045
		public unsafe ICameraTranslator cameraControlProvider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_cameraControlProvider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ICameraTranslator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_cameraControlProvider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000E4A RID: 3658 RVA: 0x0004B060 File Offset: 0x00049260
		// (set) Token: 0x06000E4B RID: 3659 RVA: 0x00008E64 File Offset: 0x00007064
		public unsafe Disabler<GameObject> hotKeyDisabler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_hotKeyDisabler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Disabler<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_hotKeyDisabler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000E4C RID: 3660 RVA: 0x0004B090 File Offset: 0x00049290
		// (set) Token: 0x06000E4D RID: 3661 RVA: 0x00008E83 File Offset: 0x00007083
		public unsafe Vector3 endMoveVelocity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveVelocity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveVelocity)) = value;
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000E4E RID: 3662 RVA: 0x0004B0B8 File Offset: 0x000492B8
		// (set) Token: 0x06000E4F RID: 3663 RVA: 0x00008E9E File Offset: 0x0000709E
		public unsafe Vector2 endMoveDamp
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveDamp);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveDamp)) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000E50 RID: 3664 RVA: 0x0004B0E0 File Offset: 0x000492E0
		// (set) Token: 0x06000E51 RID: 3665 RVA: 0x00008EB9 File Offset: 0x000070B9
		public unsafe float endMoveSmoothTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveSmoothTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_endMoveSmoothTime)) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000E52 RID: 3666 RVA: 0x0004B108 File Offset: 0x00049308
		// (set) Token: 0x06000E53 RID: 3667 RVA: 0x00008ED4 File Offset: 0x000070D4
		public unsafe Vector2 moveVector
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_moveVector);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_moveVector)) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x0004B130 File Offset: 0x00049330
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x00008EEF File Offset: 0x000070EF
		public unsafe CurrentInputModuleType currentInputModuleType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_currentInputModuleType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CurrentInputModuleType>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlaymatHotKeyMovementHandler.NativeFieldInfoPtr_currentInputModuleType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_maxMoveSpeed;

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_inputDetector;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_cameraControlProvider;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_hotKeyDisabler;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_endMoveVelocity;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_endMoveDamp;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_endMoveSmoothTime;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_moveVector;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_currentInputModuleType;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeMethodInfoPtr_updateCameraMovement_Private_Void_0;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
