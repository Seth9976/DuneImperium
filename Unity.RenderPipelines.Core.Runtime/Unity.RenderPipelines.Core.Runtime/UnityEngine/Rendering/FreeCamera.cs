using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.Rendering
{
	// Token: 0x02000033 RID: 51
	public class FreeCamera : MonoBehaviour
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0001D9B0 File Offset: 0x0001BBB0
		// Note: this type is marked as 'beforefieldinit'.
		static FreeCamera()
		{
			Il2CppClassPointerStore<FreeCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "FreeCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr);
			FreeCamera.NativeFieldInfoPtr_k_MouseSensitivityMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "k_MouseSensitivityMultiplier");
			FreeCamera.NativeFieldInfoPtr_m_LookSpeedController = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_LookSpeedController");
			FreeCamera.NativeFieldInfoPtr_m_LookSpeedMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_LookSpeedMouse");
			FreeCamera.NativeFieldInfoPtr_m_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_MoveSpeed");
			FreeCamera.NativeFieldInfoPtr_m_MoveSpeedIncrement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_MoveSpeedIncrement");
			FreeCamera.NativeFieldInfoPtr_m_Turbo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "m_Turbo");
			FreeCamera.NativeFieldInfoPtr_kMouseX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kMouseX");
			FreeCamera.NativeFieldInfoPtr_kMouseY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kMouseY");
			FreeCamera.NativeFieldInfoPtr_kRightStickX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kRightStickX");
			FreeCamera.NativeFieldInfoPtr_kRightStickY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kRightStickY");
			FreeCamera.NativeFieldInfoPtr_kVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kVertical");
			FreeCamera.NativeFieldInfoPtr_kHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kHorizontal");
			FreeCamera.NativeFieldInfoPtr_kYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kYAxis");
			FreeCamera.NativeFieldInfoPtr_kSpeedAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "kSpeedAxis");
			FreeCamera.NativeFieldInfoPtr_inputRotateAxisX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputRotateAxisX");
			FreeCamera.NativeFieldInfoPtr_inputRotateAxisY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputRotateAxisY");
			FreeCamera.NativeFieldInfoPtr_inputChangeSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputChangeSpeed");
			FreeCamera.NativeFieldInfoPtr_inputVertical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputVertical");
			FreeCamera.NativeFieldInfoPtr_inputHorizontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputHorizontal");
			FreeCamera.NativeFieldInfoPtr_inputYAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "inputYAxis");
			FreeCamera.NativeFieldInfoPtr_leftShiftBoost = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "leftShiftBoost");
			FreeCamera.NativeFieldInfoPtr_leftShift = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "leftShift");
			FreeCamera.NativeFieldInfoPtr_fire1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, "fire1");
			FreeCamera.NativeMethodInfoPtr_OnEnable_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663841);
			FreeCamera.NativeMethodInfoPtr_RegisterInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663842);
			FreeCamera.NativeMethodInfoPtr_UpdateInputs_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663843);
			FreeCamera.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663844);
			FreeCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr, 100663845);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001DC10 File Offset: 0x0001BE10
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCamera.NativeMethodInfoPtr_OnEnable_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0001DC44 File Offset: 0x0001BE44
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegisterInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCamera.NativeMethodInfoPtr_RegisterInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001DC78 File Offset: 0x0001BE78
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 958938, RefRangeEnd = 958939, XrefRangeStart = 958912, XrefRangeEnd = 958938, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateInputs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCamera.NativeMethodInfoPtr_UpdateInputs_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001DCAC File Offset: 0x0001BEAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958939, XrefRangeEnd = 958973, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCamera.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0001DCE0 File Offset: 0x0001BEE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 958973, XrefRangeEnd = 958974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FreeCamera()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FreeCamera>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FreeCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00003D0A File Offset: 0x00001F0A
		public FreeCamera(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001DD1C File Offset: 0x0001BF1C
		// (set) Token: 0x06000467 RID: 1127 RVA: 0x00003D13 File Offset: 0x00001F13
		public unsafe static float k_MouseSensitivityMultiplier
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_k_MouseSensitivityMultiplier, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_k_MouseSensitivityMultiplier, (void*)(&value));
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001DD38 File Offset: 0x0001BF38
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00003D21 File Offset: 0x00001F21
		public unsafe float m_LookSpeedController
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_LookSpeedController);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_LookSpeedController)) = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001DD60 File Offset: 0x0001BF60
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x00003D3C File Offset: 0x00001F3C
		public unsafe float m_LookSpeedMouse
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_LookSpeedMouse);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_LookSpeedMouse)) = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001DD88 File Offset: 0x0001BF88
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x00003D57 File Offset: 0x00001F57
		public unsafe float m_MoveSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_MoveSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_MoveSpeed)) = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001DDB0 File Offset: 0x0001BFB0
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x00003D72 File Offset: 0x00001F72
		public unsafe float m_MoveSpeedIncrement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_MoveSpeedIncrement);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_MoveSpeedIncrement)) = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001DDD8 File Offset: 0x0001BFD8
		// (set) Token: 0x06000471 RID: 1137 RVA: 0x00003D8D File Offset: 0x00001F8D
		public unsafe float m_Turbo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_Turbo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_m_Turbo)) = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x0001DE00 File Offset: 0x0001C000
		// (set) Token: 0x06000473 RID: 1139 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public unsafe static string kMouseX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kMouseX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kMouseX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001DE20 File Offset: 0x0001C020
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x00003DBA File Offset: 0x00001FBA
		public unsafe static string kMouseY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kMouseY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kMouseY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x0001DE40 File Offset: 0x0001C040
		// (set) Token: 0x06000477 RID: 1143 RVA: 0x00003DCC File Offset: 0x00001FCC
		public unsafe static string kRightStickX
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kRightStickX, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kRightStickX, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x0001DE60 File Offset: 0x0001C060
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x00003DDE File Offset: 0x00001FDE
		public unsafe static string kRightStickY
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kRightStickY, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kRightStickY, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001DE80 File Offset: 0x0001C080
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00003DF0 File Offset: 0x00001FF0
		public unsafe static string kVertical
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kVertical, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kVertical, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
		// (set) Token: 0x0600047D RID: 1149 RVA: 0x00003E02 File Offset: 0x00002002
		public unsafe static string kHorizontal
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kHorizontal, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kHorizontal, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001DEC0 File Offset: 0x0001C0C0
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x00003E14 File Offset: 0x00002014
		public unsafe static string kYAxis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kYAxis, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kYAxis, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001DEE0 File Offset: 0x0001C0E0
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x00003E26 File Offset: 0x00002026
		public unsafe static string kSpeedAxis
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(FreeCamera.NativeFieldInfoPtr_kSpeedAxis, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FreeCamera.NativeFieldInfoPtr_kSpeedAxis, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0001DF00 File Offset: 0x0001C100
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x00003E38 File Offset: 0x00002038
		public unsafe float inputRotateAxisX
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputRotateAxisX);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputRotateAxisX)) = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0001DF28 File Offset: 0x0001C128
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00003E53 File Offset: 0x00002053
		public unsafe float inputRotateAxisY
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputRotateAxisY);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputRotateAxisY)) = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001DF50 File Offset: 0x0001C150
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x00003E6E File Offset: 0x0000206E
		public unsafe float inputChangeSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputChangeSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputChangeSpeed)) = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001DF78 File Offset: 0x0001C178
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003E89 File Offset: 0x00002089
		public unsafe float inputVertical
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputVertical);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputVertical)) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x0001DFA0 File Offset: 0x0001C1A0
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003EA4 File Offset: 0x000020A4
		public unsafe float inputHorizontal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputHorizontal);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputHorizontal)) = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x0001DFC8 File Offset: 0x0001C1C8
		// (set) Token: 0x0600048D RID: 1165 RVA: 0x00003EBF File Offset: 0x000020BF
		public unsafe float inputYAxis
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputYAxis);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_inputYAxis)) = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001DFF0 File Offset: 0x0001C1F0
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x00003EDA File Offset: 0x000020DA
		public unsafe bool leftShiftBoost
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_leftShiftBoost);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_leftShiftBoost)) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001E018 File Offset: 0x0001C218
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00003EF5 File Offset: 0x000020F5
		public unsafe bool leftShift
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_leftShift);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_leftShift)) = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001E040 File Offset: 0x0001C240
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x00003F10 File Offset: 0x00002110
		public unsafe bool fire1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_fire1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FreeCamera.NativeFieldInfoPtr_fire1)) = value;
			}
		}

		// Token: 0x04000315 RID: 789
		private static readonly IntPtr NativeFieldInfoPtr_k_MouseSensitivityMultiplier;

		// Token: 0x04000316 RID: 790
		private static readonly IntPtr NativeFieldInfoPtr_m_LookSpeedController;

		// Token: 0x04000317 RID: 791
		private static readonly IntPtr NativeFieldInfoPtr_m_LookSpeedMouse;

		// Token: 0x04000318 RID: 792
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveSpeed;

		// Token: 0x04000319 RID: 793
		private static readonly IntPtr NativeFieldInfoPtr_m_MoveSpeedIncrement;

		// Token: 0x0400031A RID: 794
		private static readonly IntPtr NativeFieldInfoPtr_m_Turbo;

		// Token: 0x0400031B RID: 795
		private static readonly IntPtr NativeFieldInfoPtr_kMouseX;

		// Token: 0x0400031C RID: 796
		private static readonly IntPtr NativeFieldInfoPtr_kMouseY;

		// Token: 0x0400031D RID: 797
		private static readonly IntPtr NativeFieldInfoPtr_kRightStickX;

		// Token: 0x0400031E RID: 798
		private static readonly IntPtr NativeFieldInfoPtr_kRightStickY;

		// Token: 0x0400031F RID: 799
		private static readonly IntPtr NativeFieldInfoPtr_kVertical;

		// Token: 0x04000320 RID: 800
		private static readonly IntPtr NativeFieldInfoPtr_kHorizontal;

		// Token: 0x04000321 RID: 801
		private static readonly IntPtr NativeFieldInfoPtr_kYAxis;

		// Token: 0x04000322 RID: 802
		private static readonly IntPtr NativeFieldInfoPtr_kSpeedAxis;

		// Token: 0x04000323 RID: 803
		private static readonly IntPtr NativeFieldInfoPtr_inputRotateAxisX;

		// Token: 0x04000324 RID: 804
		private static readonly IntPtr NativeFieldInfoPtr_inputRotateAxisY;

		// Token: 0x04000325 RID: 805
		private static readonly IntPtr NativeFieldInfoPtr_inputChangeSpeed;

		// Token: 0x04000326 RID: 806
		private static readonly IntPtr NativeFieldInfoPtr_inputVertical;

		// Token: 0x04000327 RID: 807
		private static readonly IntPtr NativeFieldInfoPtr_inputHorizontal;

		// Token: 0x04000328 RID: 808
		private static readonly IntPtr NativeFieldInfoPtr_inputYAxis;

		// Token: 0x04000329 RID: 809
		private static readonly IntPtr NativeFieldInfoPtr_leftShiftBoost;

		// Token: 0x0400032A RID: 810
		private static readonly IntPtr NativeFieldInfoPtr_leftShift;

		// Token: 0x0400032B RID: 811
		private static readonly IntPtr NativeFieldInfoPtr_fire1;

		// Token: 0x0400032C RID: 812
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Private_Void_0;

		// Token: 0x0400032D RID: 813
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInputs_Private_Void_0;

		// Token: 0x0400032E RID: 814
		private static readonly IntPtr NativeMethodInfoPtr_UpdateInputs_Private_Void_0;

		// Token: 0x0400032F RID: 815
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000330 RID: 816
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
