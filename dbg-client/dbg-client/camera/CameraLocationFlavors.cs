using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace dbg_client.camera
{
	// Token: 0x02000042 RID: 66
	public static class CameraLocationFlavors : Object
	{
		// Token: 0x06000292 RID: 658 RVA: 0x00025B68 File Offset: 0x00023D68
		// Note: this type is marked as 'beforefieldinit'.
		static CameraLocationFlavors()
		{
			Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "dbg_client.camera", "CameraLocationFlavors");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr);
			CameraLocationFlavors.NativeFieldInfoPtr_Dialog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr, "Dialog");
			CameraLocationFlavors.NativeFieldInfoPtr_TutorialSelection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr, "TutorialSelection");
			CameraLocationFlavors.NativeFieldInfoPtr_StrategicView = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr, "StrategicView");
			CameraLocationFlavors.NativeFieldInfoPtr_RecordedPlayerLocation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr, "RecordedPlayerLocation");
			CameraLocationFlavors.NativeFieldInfoPtr_GameStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CameraLocationFlavors>.NativeClassPtr, "GameStart");
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00003207 File Offset: 0x00001407
		public CameraLocationFlavors(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00025BFC File Offset: 0x00023DFC
		// (set) Token: 0x06000295 RID: 661 RVA: 0x00003210 File Offset: 0x00001410
		public unsafe static string Dialog
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationFlavors.NativeFieldInfoPtr_Dialog, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationFlavors.NativeFieldInfoPtr_Dialog, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00025C1C File Offset: 0x00023E1C
		// (set) Token: 0x06000297 RID: 663 RVA: 0x00003222 File Offset: 0x00001422
		public unsafe static string TutorialSelection
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationFlavors.NativeFieldInfoPtr_TutorialSelection, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationFlavors.NativeFieldInfoPtr_TutorialSelection, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00025C3C File Offset: 0x00023E3C
		// (set) Token: 0x06000299 RID: 665 RVA: 0x00003234 File Offset: 0x00001434
		public unsafe static string StrategicView
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationFlavors.NativeFieldInfoPtr_StrategicView, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationFlavors.NativeFieldInfoPtr_StrategicView, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00025C5C File Offset: 0x00023E5C
		// (set) Token: 0x0600029B RID: 667 RVA: 0x00003246 File Offset: 0x00001446
		public unsafe static string RecordedPlayerLocation
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationFlavors.NativeFieldInfoPtr_RecordedPlayerLocation, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationFlavors.NativeFieldInfoPtr_RecordedPlayerLocation, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00025C7C File Offset: 0x00023E7C
		// (set) Token: 0x0600029D RID: 669 RVA: 0x00003258 File Offset: 0x00001458
		public unsafe static string GameStart
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(CameraLocationFlavors.NativeFieldInfoPtr_GameStart, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CameraLocationFlavors.NativeFieldInfoPtr_GameStart, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04000190 RID: 400
		private static readonly IntPtr NativeFieldInfoPtr_Dialog;

		// Token: 0x04000191 RID: 401
		private static readonly IntPtr NativeFieldInfoPtr_TutorialSelection;

		// Token: 0x04000192 RID: 402
		private static readonly IntPtr NativeFieldInfoPtr_StrategicView;

		// Token: 0x04000193 RID: 403
		private static readonly IntPtr NativeFieldInfoPtr_RecordedPlayerLocation;

		// Token: 0x04000194 RID: 404
		private static readonly IntPtr NativeFieldInfoPtr_GameStart;
	}
}
